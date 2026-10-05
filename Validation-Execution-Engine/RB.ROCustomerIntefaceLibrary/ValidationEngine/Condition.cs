using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net.Mail;

namespace RB.ROCustomerIntefaceLibrary
{
    public class Condition
    {
        private XElement m_oConditionElement;
        private IQueryResult m_oQueryResult, s_oQueryResult, m_oQueryResultFieldRule;
        private List<object> s_oQueryResults = new List<object>();
        private RODataInterface m_oInterface;
        private XElement m_xIMFNode;
        private XElement m_xRONode; //only for elementrules
        private IMFManager m_oIMFmgr;
        private Query m_oROmgr;
        private string m_oRecType;
        Dictionary<string, string> m_oRuntimeParms;
        private bool boolIDRule;
        string oldDecodedValue = string.Empty;
        private int iDbidIndex = 0, iStructQueryResultIndex = 0, iFilterSuccessCount = 0;
        bool bLoopQueryresults = false, bLoopStructureQuery = false, bLoopStructureQueryResults = false;

        //Declare the Reset event REUBK-1232
        public event System.EventHandler Reset;

        private Logger objlogger = null;

        public Condition(XElement ConditionElement,
                            IQueryResult l_oQueryResult,
                            XElement xIMFNode,
                            XElement xRONode,
                            IMFManager oIMFmgr,
                            Query oROmgr,
                            Dictionary<string, string> oRuntimeParms, bool IsIDRule, string rorecTyp, RODataInterface l_oInterface, Logger l_ologger, IQueryResult l_oQueryResultFieldRule = null)
        {
            m_oConditionElement = ConditionElement;
            m_oQueryResult = l_oQueryResult;
            m_oQueryResultFieldRule = l_oQueryResultFieldRule;
            m_xIMFNode = xIMFNode;
            m_oIMFmgr = oIMFmgr;
            m_xRONode = xRONode;
            m_oROmgr = oROmgr;
            m_oRuntimeParms = oRuntimeParms;
            boolIDRule = IsIDRule; //to identify idrule/fieldrule
            m_oRecType = rorecTyp;
            m_oInterface = l_oInterface;
            objlogger = l_ologger;
        }

        public ConditionResult Evaluate()
        {
            string sOperand1;
            string sOperand2;
            int iResult;
            int iCount;
            string sDelimiter = ";";
            bool bFilter = false;

            ConditionResult l_oResult = new ConditionResult();
            l_oResult.Success = true;

            objlogger.LogInfo(m_oConditionElement.ToString(), GlobalConstants.LOGGERLEVEL1);


            try
            {
                //Operator
                //objlogger.LogInfo("fetch operator");
                GlobalConstants.Operation operation =
                    (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation),
                    m_oConditionElement.Element(RulesFileTags.OPERATOR).Value.ToString(), true);

                try
                {
                    if (operation == GlobalConstants.Operation.IN || operation == GlobalConstants.Operation.NOT_IN)
                    {
                        if (operation == GlobalConstants.Operation.IN)
                        {
                            objlogger.LogInfo("IN operator", GlobalConstants.LOGGERLEVEL1);
                        }
                        else
                        {
                            objlogger.LogInfo("NOT_IN operator", GlobalConstants.LOGGERLEVEL1);
                        }
                        XAttribute l_oDelimiter = m_oConditionElement.Element(RulesFileTags.OPERATOR).FirstAttribute;
                        sDelimiter = l_oDelimiter.Value;
                    }
                }
                catch { }

                objlogger.LogInfo("boolIDRule" + boolIDRule.ToString(), GlobalConstants.LOGGERLEVEL1);
                objlogger.LogInfo("m_oRecType" + m_oRecType, GlobalConstants.LOGGERLEVEL1);

                //if (m_oConditionElement.Parent.Name == RulesFileTags.IDRULE)  //REUBK-1232

                if (boolIDRule && (!string.IsNullOrEmpty(m_oRecType) && (m_oRecType.ToUpper() == "IRMAP" || m_oRecType.ToUpper() == "RELEASE")))
                {
                    objlogger.LogInfo("inside IRM/RELEASE ID rule", GlobalConstants.LOGGERLEVEL1);

                    sOperand1 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND1));
                    sOperand2 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND2));

                    objlogger.LogInfo("FIELDS: Operand1=" + sOperand1 + "Operand2=" + sOperand2, GlobalConstants.LOGGERLEVEL1);


                    if (sOperand1.ToUpper() == RulesFileTags.COUNTRECORDS)
                    {
                        objlogger.LogInfo("inside IRM/REL ID rule--values only", GlobalConstants.LOGGERLEVEL1);
                        iResult = m_oQueryResult.RecordCount;
                        iCount = Convert.ToInt16(m_oConditionElement.Element(RulesFileTags.OPERAND2).Value.ToString());
                        objlogger.LogInfo("iResult=" + iResult.ToString() + "iCount=" + iCount.ToString(), GlobalConstants.LOGGERLEVEL1);

                        if (Utilities.PerformOperation(iResult, iCount, operation))
                        {
                            objlogger.LogInfo("ID RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = true;
                        }
                        else
                        {
                            objlogger.LogInfo("ID RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = false;
                        }

                    }
                    else
                    {

                        objlogger.LogInfo("inside IRMID rule--with fields only", GlobalConstants.LOGGERLEVEL1);
                        if (!(operation == GlobalConstants.Operation.IN_CS))
                        {
                            if (Utilities.PerformOperation(sOperand2, sOperand1, operation, true, sDelimiter))
                            {
                                objlogger.LogInfo("ID RULE with field name CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = true;
                            }
                            else
                            {
                                objlogger.LogInfo("ID RULE with field name CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = false;
                            }
                        }
                        else
                        {
                            objlogger.LogInfo("CASE SENSITIVE IN operation", GlobalConstants.LOGGERLEVEL1);
                            if (Utilities.PerformOperation(sOperand2, sOperand1, operation, false, sDelimiter))
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = true;
                            }
                            else
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = false;
                            }
                        }
                    }
                }

                else if (boolIDRule)
                {
                    objlogger.LogInfo("inside ID rule", GlobalConstants.LOGGERLEVEL1);
                    iResult = m_oQueryResult.RecordCount;
                    sOperand1 = m_oConditionElement.Element(RulesFileTags.OPERAND1).Value.ToString();

                    if (sOperand1.ToUpper() == RulesFileTags.COUNTRECORDS)
                    {
                        iCount = Convert.ToInt16(m_oConditionElement.Element(RulesFileTags.OPERAND2).Value.ToString()); //only if sOperand1=COUNTRECORDS
                        objlogger.LogInfo("iResult=" + iResult.ToString() + "iCount=" + iCount.ToString(), GlobalConstants.LOGGERLEVEL1);

                        if (Utilities.PerformOperation(iResult, iCount, operation))
                        {
                            objlogger.LogInfo("ID RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = true;
                        }
                        else
                        {
                            objlogger.LogInfo("ID RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = false;
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("inside id rule -- getvalues from imf/ro", GlobalConstants.LOGGERLEVEL1);
                        sOperand1 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND1));
                        sOperand2 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND2));


                        if (Utilities.PerformOperation(sOperand2, sOperand1, operation))
                        {
                            objlogger.LogInfo("ID RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = true;
                        }
                        else
                        {
                            objlogger.LogInfo("ID RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = false;
                        }
                    }
                }

                //Get Field Values  
                // if ((m_oConditionElement.Parent.Name == RulesFileTags.FIELDRULE) || (m_oConditionElement.Parent.Parent.Name == RulesFileTags.FIELDRULE)) //for or-and eval
                else
                {
                    objlogger.LogInfo("inside field rule", GlobalConstants.LOGGERLEVEL1);
                    sOperand1 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND1));
                    sOperand2 = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND2));


                    objlogger.LogInfo("FIELDS: Operand1=" + sOperand1 + "Operand2=" + sOperand2, GlobalConstants.LOGGERLEVEL1);


                    //for cnok countrecords operation in field rule
                    if (sOperand1.ToUpper() == RulesFileTags.COUNTRECORDS)
                    {
                        //objlogger.LogInfo("inside field rule with COUNTRECORDS");
                        iResult = m_oQueryResultFieldRule.RecordCount;
                        iCount = Convert.ToInt16(m_oConditionElement.Element(RulesFileTags.OPERAND2).Value.ToString());
                        objlogger.LogInfo("iResult=" + iResult.ToString() + "iCount=" + iCount.ToString(), GlobalConstants.LOGGERLEVEL1);

                        if (Utilities.PerformOperation(iResult, iCount, operation))
                        {
                            objlogger.LogInfo("FIELD RULE CONDITION - COUNT CHECK SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = true;
                        }
                        else
                        {
                            objlogger.LogInfo("FIELD RULE CONDITION COUNT CHECK FAILED", GlobalConstants.LOGGERLEVEL1);
                            l_oResult.Success = false;
                        }

                    }
                    else
                    {

                        if (!(operation == GlobalConstants.Operation.IN_CS))
                        {
                            if (Utilities.PerformOperation(sOperand2, sOperand1, operation, true, sDelimiter))
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = true;
                            }
                            else
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = false;
                            }
                        }
                        else
                        {
                            objlogger.LogInfo("CASE SENSITIVE IN operation", GlobalConstants.LOGGERLEVEL1);
                            if (Utilities.PerformOperation(sOperand2, sOperand1, operation, false, sDelimiter))
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = true;
                            }
                            else
                            {
                                objlogger.LogInfo("FIELD RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.Success = false;
                            }
                        }
                    }
                }

                // Now we are done evaluating the base condition let us look for AND 
                // no point looking for AND if the first condition has already failed
                #region AndEvaluation
                if (l_oResult.Success)
                {
                    objlogger.LogInfo("Getting And Conditions", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> xAndConditions = m_oConditionElement.Elements().Where(n => n.Name
                                                                        == RulesFileTags.AND);

                    foreach (XElement oElement in xAndConditions)
                    {
                        //objlogger.LogInfo("Evaluating And Condition" + oElement.ToString());

                        Condition l_oCondition = new Condition(oElement
                                                            , m_oQueryResult,
                                                            m_xIMFNode, null,
                                                            m_oIMFmgr,
                                                            m_oROmgr, m_oRuntimeParms, boolIDRule, m_oRecType, m_oInterface, objlogger);

                        l_oResult.Success = l_oResult.Success && l_oCondition.Evaluate().Success;
                    }

                }
                #endregion
                // Now we are done evaluating the base condition let us look for OR 
                // no point looking for OR if the first condition has already True
                #region Or Evaluation
                if (!l_oResult.Success)
                {
                    objlogger.LogInfo("FIELD RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);

                    IEnumerable<XElement> xOrConditions = m_oConditionElement.Elements().Where(n => n.Name
                                                                        == RulesFileTags.OR);

                    foreach (XElement oElement in xOrConditions)
                    {
                        Condition l_oCondition = new Condition(oElement
                                                            , m_oQueryResult,
                                                            m_xIMFNode, null,
                                                            m_oIMFmgr,
                                                            m_oROmgr, m_oRuntimeParms, boolIDRule, m_oRecType, m_oInterface, objlogger);

                        l_oResult.Success = l_oResult.Success || l_oCondition.Evaluate().Success;
                    }
                }
                #endregion

                if (!l_oResult.Success)
                {
                    objlogger.LogInfo("Overall evaluation failed", GlobalConstants.LOGGERLEVEL1);
                    try
                    {
                        //Check for FILTER attribute
                        if (m_oConditionElement.Element(RulesFileTags.VIOLATIONMESSAGE).Attribute(RulesFileTags.FILTER) != null && m_oConditionElement.Element(RulesFileTags.VIOLATIONMESSAGE).Attribute(RulesFileTags.FILTER).Value == "1")
                        {
                            bFilter = true;
                            //objlogger.LogInfo("Set VIOLATIONMESSAGE based on FILTER condition result");
                        }
                        else
                        {
                            //decode msg first then proceed for violationhandler
                            l_oResult.ValidationMessage = DecodeOperandForString(m_oConditionElement.Element(RulesFileTags.VIOLATIONMESSAGE).Value);
                        }

                        HandleViolation(m_oConditionElement);                       

                        //Set VIOLATIONMESSAGE based on FILTER condition result
                        //objlogger.LogInfo("bFilter:" + bFilter);

                        if (bFilter == true)
                        {
                            objlogger.LogInfo("iFilterSuccessCount:" + iFilterSuccessCount, GlobalConstants.LOGGERLEVEL1);

                            if (iFilterSuccessCount > 0)
                            {
                                objlogger.LogInfo("Filter condition succeeded atleast once, Setting VIOLATIONMESSAGE", GlobalConstants.LOGGERLEVEL1);
                                l_oResult.ValidationMessage = DecodeMessage(m_oConditionElement.Element(RulesFileTags.VIOLATIONMESSAGE).Value);
                            }
                            else
                            {
                                objlogger.LogInfo("Filter condition failed, donot set VIOLATIONMESSAGE", GlobalConstants.LOGGERLEVEL1);
                                //Condition did not fail
                                l_oResult.Success = true;
                            }
                        }

                        objlogger.LogInfo("after  HandelVialotion", GlobalConstants.LOGGERLEVEL1);
                    }
                    catch { }
                }
                else
                {
                    objlogger.LogInfo("Overall evaluation Succeeded", GlobalConstants.LOGGERLEVEL1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return l_oResult;
        }


        private void HandleViolation(XElement oElement)
        {
            if (oElement.HasElements && oElement.Element(RulesFileTags.VIOLATIONHANDLER) != null)
            {
                //objlogger.LogInfo("Inside Violation handler");


                if (oElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.FIELDCHANGE).Count() > 0)
                {
                    objlogger.LogInfo("Inside Field change", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> xoKeys = oElement.Elements(RulesFileTags.VIOLATIONHANDLER)
                        .Elements(RulesFileTags.FIELDCHANGE);

                    foreach (XElement xelem in xoKeys)
                    {
                        string sVar = xelem.Element(RulesFileTags.IMFUPDATEFIELD).Value;
                        XElement xUpdateValue = xelem.Element(RulesFileTags.IMFUPDATEVALUE);
                        string sValue = DecodeFunction(xUpdateValue);
                        //sValue = DecodeOperandForString(sValue); //REUBK-1222
                        objlogger.LogInfo("VALUES: Var=" + sVar + "Value=" + sValue, GlobalConstants.LOGGERLEVEL1);
                        //get imf value without $
                        string sIMFField = ReplaceString(sVar, "");
                        m_oIMFmgr.UpdateIMFFromRulesFile(sIMFField, sValue, m_xIMFNode, true, m_oRuntimeParms[OrcParameters.EXCHANGEFORMAT]);
                    }
                }
                if (oElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.STRUCTURECHANGE).Count() > 0)
                {
                    objlogger.LogInfo("Inside Structure change", GlobalConstants.LOGGERLEVEL1);

                    //Check for LOOPSTRUCTUREQUERY attribute
                    if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPSTRUCTUREQUERY) != null)
                    {
                        if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPSTRUCTUREQUERY).Value.ToUpper() == "TRUE")
                        {
                            bLoopStructureQuery = true;
                        }
                    }
                    objlogger.LogInfo("bLoopStructureQuery = " + bLoopStructureQuery, GlobalConstants.LOGGERLEVEL1);


                    //Check for LOOPSTRUCTUREQUERYRESULTS attribute
                    if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPSTRUCTUREQUERYRESULTS) != null)
                    {
                        if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPSTRUCTUREQUERYRESULTS).Value.ToUpper() == "TRUE")
                        {
                            bLoopStructureQueryResults = true;
                        }
                    }

                    //V2.0 Workitem  132278
                    if (bLoopStructureQuery)
                    {
                        LoopStructureQuery(oElement);
                    }
                    else if (bLoopStructureQueryResults)
                    {
                        LoopStructureQueryResults(oElement);
                    }
                    else
                    {
                        //Proceed with normal implementation for structure change

                        int iCount = 1;
                        IEnumerable<XElement> xoStructKeys = oElement.Elements(RulesFileTags.VIOLATIONHANDLER)
                            .Elements(RulesFileTags.STRUCTURECHANGE).Elements(RulesFileTags.CHANGE);

                        //REUBK-3603 Execute STRUCTURECHANGE multiple times
                        if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPQUERYRESULTS) != null)
                        {
                            if (oElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPQUERYRESULTS).Value == "TRUE")
                            {
                                objlogger.LogInfo("STRUCTURECHANGE LOOPQUERYRESULTS :" + m_oQueryResult.ReturnedDbids.Count(), GlobalConstants.LOGGERLEVEL1);
                                bLoopQueryresults = true;
                                iCount = m_oQueryResult.ReturnedDbids.Count();

                                xoStructKeys = oElement.Elements(RulesFileTags.VIOLATIONHANDLER)
                                .Elements(RulesFileTags.STRUCTURECHANGE).Elements(RulesFileTags.LOOP).Elements(RulesFileTags.CHANGE);
                            }
                        }


                        for (int i = 0; i < iCount; i++)
                        {
                            foreach (XElement xelem in xoStructKeys)
                            {
                                if (xelem.HasElements)
                                {
                                    XElement Xpath = xelem.Element(RulesFileTags.XPATH);
                                    XElement XValueToUpdate = xelem.Element(RulesFileTags.VALUE);

                                    string sXpath = DecodeFunction(Xpath);
                                    string sValueToUpdate = DecodeFunction(XValueToUpdate);
                                    string sAction = xelem.Elements().Last().Name.ToString();
                                    string sName = xelem.Elements().Last().Value.ToString();
                                    objlogger.LogInfo("calling UpdateIMFForStructChange, name=" + sName + "Value=" + sValueToUpdate, GlobalConstants.LOGGERLEVEL1);
                                    m_oIMFmgr.UpdateIMFForStructChange(sName, sValueToUpdate, sXpath, sAction, objlogger);
                                }
                            }
                            iDbidIndex++;
                        }

                        bLoopQueryresults = false; iDbidIndex = 0;
                    }

                }
                if (oElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.EMAIL).Count() > 0)
                {
                    objlogger.LogInfo("Inside Email", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> xoKeys = oElement.Elements(RulesFileTags.VIOLATIONHANDLER)
                        .Elements(RulesFileTags.EMAIL);

                    string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(m_oRuntimeParms[OrcParameters.EXCHANGEFORMAT] + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                    ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                    XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(m_oRuntimeParms[OrcParameters.EXCHANGEFORMAT]);

                    if (l_oConfig == null)
                    {
                        //exception handling
                        objlogger.LogInfo("SendMail: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                    }
                    else
                    {
                        foreach (XElement xelem in xoKeys)
                        {
                            string from = DecodeFunction(xelem.Element(RulesFileTags.SENDER));
                            string to = DecodeFunction(xelem.Element(RulesFileTags.RECEPIENT));
                            string subject = DecodeFunction(xelem.Element(RulesFileTags.EMAILSUBJECT));
                            string body = DecodeFunction(xelem.Element(RulesFileTags.EMAILBODY));

                            MailMessage oMail = new MailMessage(from, to, subject, body);

                            Utilities.SendMail(l_oConfig, oMail, objlogger);
                        }
                    }

                }
                if (oElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.RESET).Count() > 0)
                {

                    // IEnumerable<XElement> xoResetKeys = oElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.RESET);
                    //  if (xoResetKeys.Count() > 0)
                    //  {
                    objlogger.LogInfo("Inside Reset..", GlobalConstants.LOGGERLEVEL1);
                    Reset(null, null);
                    // }

                }

            }
        }


        private string[] IncrementVersion(string[] CDATAparams)
        {
            string sNewVersion = string.Empty, sOldVersion = CDATAparams[0], sASAMfileOEMversion = string.Empty;
            Match ROCustmatch;
            try
            {
                objlogger.LogInfo("IncrementVersion", GlobalConstants.LOGGERLEVEL1);
                if (Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHVERSION, RegexOptions.Singleline).Success)
                {
                    //Increment DAI Version                
                    ROCustmatch = Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHVERSION, RegexOptions.Singleline);
                    sASAMfileOEMversion = (Convert.ToInt32(ROCustmatch.Groups["Match1"].Value) + 1).ToString();
                    if ((ROCustmatch.Groups["Match1"].Value[0] == '0') && (Convert.ToInt32(sASAMfileOEMversion) < 9))
                    {
                        //Prefix with 0
                        sASAMfileOEMversion = "0" + sASAMfileOEMversion;
                    }

                    sNewVersion = "DAI" + sASAMfileOEMversion + sOldVersion.Substring(sOldVersion.IndexOf('#'));
                }
                else if (Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHVERSIONBMW, RegexOptions.Singleline).Success)
                {
                    //Increment BMW Version                
                    ROCustmatch = Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHVERSIONBMW, RegexOptions.Singleline);
                    sASAMfileOEMversion = (Convert.ToInt32(ROCustmatch.Groups["Match1"].Value) + 1).ToString();
                    if ((ROCustmatch.Groups["Match1"].Value[0] == '0') && (Convert.ToInt32(sASAMfileOEMversion) < 9))
                    {
                        //Prefix with 0
                        sASAMfileOEMversion = "0" + sASAMfileOEMversion;
                    }

                    sNewVersion = "BMW" + sASAMfileOEMversion + sOldVersion.Substring(sOldVersion.IndexOf('#'));
                }
                else if (Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHOEMVERSIONBMW, RegexOptions.Singleline).Success)
                {
                    //objlogger.LogInfo("match found");
                    ROCustmatch = Regex.Match(sOldVersion, GlobalConstants.REGEX_MATCHOEMVERSIONBMW, RegexOptions.Singleline);
                    //objlogger.LogInfo("after match found:" + ROCustmatch.Groups["Match1"].Value);
                    sASAMfileOEMversion = (Convert.ToInt32(ROCustmatch.Groups["Match1"].Value) + 1).ToString();
                    //if ((ROCustmatch.Groups["Match1"].Value[0] == '0') && (Convert.ToInt32(sASAMfileOEMversion) < 9))
                    //{
                    //    //Prefix with 0
                    //    sASAMfileOEMversion = "0" + sASAMfileOEMversion;
                    //}

                    sNewVersion = sASAMfileOEMversion;
                }
                objlogger.LogInfo("sASAMfileOEMversion :" + sASAMfileOEMversion, GlobalConstants.LOGGERLEVEL1);
                CDATAparams[2] = sNewVersion;
                objlogger.LogInfo("sNewVersion :" + sNewVersion, GlobalConstants.LOGGERLEVEL1);

            }

            catch (Exception ex)
            {
                objlogger.LogInfo("Inside catch", GlobalConstants.LOGGERLEVEL1);
                objlogger.LogInfo(ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
            return CDATAparams;

        }

        public string DecodeMessage(string sMessage)
        {

            objlogger.LogInfo("DecodeMessage: " + sMessage, GlobalConstants.LOGGERLEVEL1);
            sMessage = DecodeOperandForString(sMessage);
            objlogger.LogInfo("Message after DecodeOperandForString: " + sMessage, GlobalConstants.LOGGERLEVEL1);
            //Decode XPATH in string
            Regex XpathRegex = new Regex(@"XPATH\(.*\)",
              RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
              | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

            MatchCollection matchcoll = XpathRegex.Matches(sMessage);
            string sXpath = string.Empty;

            foreach (Match m in matchcoll)
            {
                objlogger.LogInfo("Decoding -- match found =" + m.Value, GlobalConstants.LOGGERLEVEL1);
                sXpath = m.Value.Trim();

                //objlogger.LogInfo("Start XPATH evaluation");
                string xpathResult = string.Empty;
                string[] sFunNames = sXpath.Split('(');
                string sFunName = sFunNames[0];
                sXpath = sXpath.Replace(sFunName + "(", "");
                sXpath = sXpath.Remove(sXpath.Length - 1, 1);
                objlogger.LogInfo("XPATH =" + sXpath, GlobalConstants.LOGGERLEVEL1);
                xpathResult = m_oIMFmgr.ResolveXPATH(sXpath);
                objlogger.LogInfo("Decoded Value =" + xpathResult, GlobalConstants.LOGGERLEVEL1);
                sMessage = sMessage.Replace(m.Value.Trim(), xpathResult);
                //objlogger.LogInfo("String after replace =" + sMessage);
            }

            return sMessage;

        }


        public string GetOperandDecoded(XElement oOperandNode)
        {
            string sOperand = oOperandNode.Value, sToReturn = string.Empty;

            if (oOperandNode.DescendantNodes().Count() > 0
                && oOperandNode.DescendantNodes().First().NodeType == System.Xml.XmlNodeType.CDATA)
            {
                #region RegxDecoding
                objlogger.LogInfo("CDATA node found", GlobalConstants.LOGGERLEVEL1);



                //<OPERAND2><![CDATA[Replace($IMF.HASMAPPEDISSUE.EXTERNALDESCRIPTION ¶(<P>)(.*?)(</P>)¶$2\n¶RegexOptions.Singleline)]]></OPERAND1>

                if (sOperand.Contains("XPATH"))
                {
                    objlogger.LogInfo("XPATH evaluation", GlobalConstants.LOGGERLEVEL1);
                    string xpathResult = string.Empty;
                    string[] sFunNames = sOperand.Split('(');
                    string sFunName = sFunNames[0];
                    sOperand = sOperand.Replace(sFunName + "(", "");
                    sOperand = sOperand.Remove(sOperand.Length - 1, 1);
                    objlogger.LogInfo("XPATH=" + sOperand, GlobalConstants.LOGGERLEVEL1);
                    //Decoding $IMF, $RO and $SC values
                    sOperand = DecodeOperandForString(sOperand);
                    objlogger.LogInfo("XPATH after decoding=" + sOperand, GlobalConstants.LOGGERLEVEL1);
                    xpathResult = m_oIMFmgr.ResolveXPATH(sOperand);
                    objlogger.LogInfo("after ResolveXPATH=" + xpathResult, GlobalConstants.LOGGERLEVEL1);
                    sToReturn = xpathResult;
                }
                else
                {
                    objlogger.LogInfo("REGEX evaluation", GlobalConstants.LOGGERLEVEL1);

                    int count = oOperandNode.DescendantNodes().Count();
                    objlogger.LogInfo("CDATA node Count:" + count, GlobalConstants.LOGGERLEVEL1);

                    foreach (XNode node in oOperandNode.DescendantNodes())
                    {

                        string sNode = node.ToString();
                        objlogger.LogInfo("Node:" + sNode, GlobalConstants.LOGGERLEVEL1);

                        sOperand = Regex.Replace(sNode, "<!\\[CDATA\\[(.*?)\\]\\]>", "$1");
                        //objlogger.LogInfo("sOperand:" + sOperand);

                        sOperand = DecodeOperandForString(sOperand);

                        //Get the function Name
                        //objlogger.LogInfo("Getting function name");
                        string[] sFunNames = sOperand.Split('(');
                        string sFunName = sFunNames[0];
                        objlogger.LogInfo("Function is =" + sFunName, GlobalConstants.LOGGERLEVEL1);

                        //Get parameters now
                        //objlogger.LogInfo("Getting parameters ");
                        sOperand = sOperand.Replace(sFunName + "(", "");
                        sOperand = sOperand.Remove(sOperand.Length - 1, 1);
                        string[] Params = sOperand.Split('§');


                        //Check for Versiom Increment
                        if (sOperand.Contains(GlobalConstants.INCREMENTVERSION))
                        {
                            objlogger.LogInfo("Increment required", GlobalConstants.LOGGERLEVEL1);

                            sOperand = sOperand.Replace(GlobalConstants.INCREMENTVERSION, "");

                            //objlogger.LogInfo("sOperand after increment version replace :" + sOperand);

                            Params = sOperand.Split('§');
                            Params[0] = DecodeStandard(Params[0].Trim());


                            objlogger.LogInfo("Params[0] :" + Params[0], GlobalConstants.LOGGERLEVEL2);
                            objlogger.LogInfo("Params[1] :" + Params[1], GlobalConstants.LOGGERLEVEL2);

                            if (Params[0] == Regex.Match(Params[0], Params[1], RegexOptions.Singleline).Value)
                            {

                                //objlogger.LogInfo("Calling IncrementVersion method");
                                Params = IncrementVersion(Params);

                                /* foreach (string str in Params)
                                 {
                                     objlogger.LogInfo("Param value :" + str);
                                 }*/


                            }
                            else if (Params[0].Contains(Regex.Match(Params[0], Params[1], RegexOptions.Singleline).Value))
                            {
                                Params[0] = Regex.Match(Params[0], Params[1], RegexOptions.Singleline).Value;
                                objlogger.LogInfo("Params[0] :" + Params[0], GlobalConstants.LOGGERLEVEL2);
                                //objlogger.LogInfo("Calling IncrementVersion");
                                Params = IncrementVersion(Params);
                                /* foreach (string str in Params)
                                 {
                                     objlogger.LogInfo("Param value :" + str);
                                 }*/
                            }
                            else { }
                        }

                        List<object> l_oparams = new List<object>();
                        int iGrpPram = 0;

                        if (sFunName == "Match")
                        {
                            iGrpPram = int.Parse(Params[Params.Length - 1]);
                            Params = Params.Where(p => p != Params[Params.Length - 1]).ToArray(); //remove the last parameter which indicates group number for match

                        }

                        foreach (object o in Params)
                        {
                            if (o.ToString().Contains("RegexOptions"))
                            {
                                System.Type l_oType = typeof(RegexOptions);
                                System.Reflection.FieldInfo l_oField = l_oType.GetField(o.ToString().Replace("RegexOptions.", ""));
                                l_oparams.Add(l_oField.GetValue(null));
                            }
                            else
                            {
                                l_oparams.Add(o);
                            }
                        }
                        objlogger.LogInfo("No of parameters =" + l_oparams.Count.ToString(), GlobalConstants.LOGGERLEVEL1);


                        if (!(oOperandNode.DescendantNodes().First() == node))
                        {
                            //Output of first execution is input for next execution

                            l_oparams.Remove(l_oparams.First());
                            l_oparams.Insert(0, sToReturn);
                        }


                        Type t = typeof(System.Text.RegularExpressions.Regex);
                        objlogger.LogInfo("Invoking function", GlobalConstants.LOGGERLEVEL1);
                        object oResult = t.InvokeMember(sFunName, System.Reflection.BindingFlags.InvokeMethod, null, t, l_oparams.ToArray());

                        if (oResult is string || oResult is bool)
                        {
                            objlogger.LogInfo("String or bool result", GlobalConstants.LOGGERLEVEL1);
                            sToReturn = oResult.ToString();
                        }
                        else if (oResult is Match)
                        {
                            objlogger.LogInfo("Match result", GlobalConstants.LOGGERLEVEL1);
                            Match oResultm = oResult as Match;
                            if (oResultm.Success)
                            {
                                objlogger.LogInfo("Group " + iGrpPram.ToString(), GlobalConstants.LOGGERLEVEL1);
                                sToReturn = oResultm.Groups[iGrpPram].Value;
                            }
                            else
                            {
                                objlogger.LogInfo("NULL case1", GlobalConstants.LOGGERLEVEL1);
                                sToReturn = "NULL";
                            }
                        }
                        else
                        {
                            objlogger.LogInfo("NULL case2", GlobalConstants.LOGGERLEVEL1);
                            sToReturn = "NULL";
                        }


                #endregion
                    }
                }
            }

            else
            {
                sToReturn = DecodeStandard(sOperand);
            }

            return sToReturn;
        }

        private string DecodeStandard(string sOperand)
        {
            string sToReturn = string.Empty;
            try
            {
                if (!(string.IsNullOrEmpty(sOperand)))
                {
                    if (sOperand.Contains("sub")) //REUBK-2029 for operand with sub() value
                    {
                        sToReturn = DecodeOperandForString(sOperand);
                    }

                    //get ro value without $RO.   
                    else if (sOperand.Contains("$RO"))
                    {
                        objlogger.LogInfo("$ Found in RO - replace and get value from RO resultset", GlobalConstants.LOGGERLEVEL2);

                        sOperand = sOperand.Replace("$RO.", "");

                        if (bLoopQueryresults)
                        {
                            if (sOperand.ToUpper() == GlobalConstants.DBID)
                            {
                                sToReturn = m_oQueryResult.ReturnedDbids.ElementAt(iDbidIndex).ToString();
                            }
                        }
                        else
                        {
                            sToReturn = m_oQueryResult.GetValue(sOperand);
                        }
                        objlogger.LogInfo("sOperand value after GetValue is:" + sToReturn, GlobalConstants.LOGGERLEVEL1);
                    }
                    else if (sOperand.Contains("$IMF"))
                    {
                        objlogger.LogInfo("$ Found in IMF - replace and get value from IMF file", GlobalConstants.LOGGERLEVEL2);
                        sOperand = sOperand.Replace("$IMF.", "");
                        sToReturn = m_oIMFmgr.GetValueFromIMF(sOperand, m_xIMFNode, m_oRuntimeParms[OrcParameters.EXCHANGEFORMAT]);
                    }
                    else if (sOperand.Contains("$RT"))
                    {
                        objlogger.LogInfo("$ Found in RT - replace and get value from RT file", GlobalConstants.LOGGERLEVEL2);
                        sOperand = sOperand.Replace("$RT.", "");
                        //objlogger.LogInfo("Looking for " + sOperand + "in Runtime params");
                        sToReturn = m_oRuntimeParms[sOperand];
                    }
                    else if (sOperand.Contains("$SC"))
                    {
                        objlogger.LogInfo("$ Found in SC - replace and get value from SC result", GlobalConstants.LOGGERLEVEL2);
                        sOperand = sOperand.Replace("$SC.", "");
                        //objlogger.LogInfo("Looking for " + sOperand);
                        if (bLoopStructureQueryResults == true)
                        {
                            //objlogger.LogInfo("bLoopStructureQueryResults true");
                            IQueryResult scQueryResult = s_oQueryResults.ElementAt(iStructQueryResultIndex) as IQueryResult;
                            sToReturn = scQueryResult.GetValue(sOperand);
                            objlogger.LogInfo("sToReturn =" + sToReturn, GlobalConstants.LOGGERLEVEL1);
                        }
                        else
                        {
                            if (s_oQueryResult != null)
                            {
                                sToReturn = s_oQueryResult.GetValue(sOperand);
                            }
                        }
                    }
                    else if (sOperand.Contains("$DT"))
                    {
                        objlogger.LogInfo("$ Found in DT - replace and get value", GlobalConstants.LOGGERLEVEL2);
                        sOperand = sOperand.Replace("$DT.", "");
                        sToReturn = DetermineDateTime(sOperand);

                    }
                    else
                    {
                        objlogger.LogInfo("string value", GlobalConstants.LOGGERLEVEL2);
                        sToReturn = sOperand;
                    }
                }
                else
                {
                    return sOperand;
                }
            }
            catch (Exception ex)  //REUBK-1740 xprot log field should be udpated with exception msg in case of any excep in oslc query of linked record
            {
                objlogger.LogException(ex, "OSLC Query Exception in DecodeStandard()");
                throw;
            }
            return sToReturn;
        }

        public string DetermineDateTime(string sOperand)
        {
            string sDateTime = string.Empty;
            try
            {
                if (sOperand.ToUpper() == "CURRENTUTCDATETIME")
                {
                    sDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Excep in DetermineDateTime" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }

            return sDateTime;
        }

        public string DecodeOperandForString(string sOperand) //REUBK-1222
        {
            objlogger.LogInfo("inside DecodeOperandForString-sOperand: " + sOperand, GlobalConstants.LOGGERLEVEL1);

            Regex MyRegex = new Regex(@"\$\w{2,3}.(.*?)\¶",
               RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
               | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

            MatchCollection matchcoll = MyRegex.Matches(sOperand);
            string sMatch = string.Empty;

            foreach (Match m in matchcoll)
            {
                objlogger.LogInfo("Decoding -- match found =" + m.Value, GlobalConstants.LOGGERLEVEL1);
                sMatch = m.Value;
                sMatch = sMatch.Remove(sMatch.Length - 1);
                string sDecoded = DecodeStandard(sMatch.Trim());
                objlogger.LogInfo("Decoded Value =" + sDecoded, GlobalConstants.LOGGERLEVEL1);
                sOperand = sOperand.Replace(m.Value.Trim(), sDecoded);
                //objlogger.LogInfo("String after replace =" + sOperand);
            }
            objlogger.LogInfo("end of DecodeOperandForString-return value: " + sOperand, GlobalConstants.LOGGERLEVEL1);
            return sOperand;
        }

        public string DecodeFunction(XElement Updatevalue) //REUBK-1411
        {
            objlogger.LogInfo("Inside DecodeFunction", GlobalConstants.LOGGERLEVEL1);
            string sValue = string.Empty;
            if (Updatevalue.HasElements && Updatevalue.Element(RulesFileTags.QUERY) != null)
            {
                //objlogger.LogInfo("Call DecodeQuery");
                sValue = DecodeQuery(Updatevalue);
            }
            else if (Updatevalue.DescendantNodes().Count() > 0
                && Updatevalue.DescendantNodes().First().NodeType == System.Xml.XmlNodeType.CDATA)
            {
                objlogger.LogInfo("Call GetOperandDecoded", GlobalConstants.LOGGERLEVEL1);
                sValue = GetOperandDecoded(Updatevalue);
            }
            else
            {
                //objlogger.LogInfo("Call DecodeOperandForString");
                sValue = DecodeOperandForString(Updatevalue.Value);
            }
            objlogger.LogInfo("End of DecodeFunction--Return value =" + sValue, GlobalConstants.LOGGERLEVEL1);
            return sValue;
        }

        public string DecodeQuery(XElement Updatevalue) //REUBK-1411
        {
            objlogger.LogInfo("Inside DecodeQuery", GlobalConstants.LOGGERLEVEL1);
            string sToReturn = string.Empty;

            try
            {
                IEnumerable<XElement> xoKeys = Updatevalue.Elements(RulesFileTags.QUERY);

                //objlogger.LogInfo("Inside DecodeQuery - get keys");
                foreach (XElement xelem in xoKeys)
                {
                    //objlogger.LogInfo("Inside DecodeQuery - inside xoKeys");
                    string sQuery = xelem.Element(RulesFileTags.QUERYSTRING).Value;
                    string sField = xelem.Element(RulesFileTags.FIELDNAME).Value;
                    string sAttr = string.Empty;

                    if (xelem.Element(RulesFileTags.FIELDNAME).HasAttributes)
                    {
                        //objlogger.LogInfo("From Rulesfile:IDQuery - inside HasAttributes");
                        sAttr = xelem.Element(RulesFileTags.FIELDNAME).Attribute(RulesFileTags.ISREFFIELD).Value;
                        //objlogger.LogInfo("From Rulesfile:IDQuery - sAttr" + sAttr);
                    }

                    objlogger.LogInfo("From Rulesfile:IDQuery:" + sQuery, GlobalConstants.LOGGERLEVEL1);
                    objlogger.LogInfo("From Rulesfile:FIELD:" + sField, GlobalConstants.LOGGERLEVEL1);
                    objlogger.LogInfo("From Rulesfile:sAttr:" + sAttr, GlobalConstants.LOGGERLEVEL1);
                    sQuery = DecodeOperandForString(sQuery);
                    objlogger.LogInfo("After decode:IDQuery:" + sQuery, GlobalConstants.LOGGERLEVEL1);
                    m_oROmgr.QueryString = sQuery;

                    //objlogger.LogInfo("Get query result");
                    objlogger.LogInfo("m_oQueryResult.count" + m_oQueryResult.RecordCount, GlobalConstants.LOGGERLEVEL1);
                    RODataInterface l_oInterface;

                    if (m_oQueryResult.RecordCount == 0)
                    {
                        l_oInterface = m_oInterface;
                    }
                    else
                    {
                        l_oInterface = ((OSLC_QueryResult)m_oQueryResult).DataInterface;
                    }

                    //objlogger.LogInfo("exec query");
                    IQueryResult l_oQueryResult = l_oInterface.Query(sQuery);
                    //objlogger.LogInfo("after Get query result");
                    if (l_oQueryResult.RecordCount > 0)
                    {

                        if (l_oQueryResult.RecordCount == 1)
                        {
                            QueryParameters l_oParameters = new QueryParameters();
                            l_oParameters.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryResult.GetRaw());

                            try
                            {
                                if (sAttr == "1")
                                {
                                    objlogger.LogInfo("sAttr ==1 get linked record value", GlobalConstants.LOGGERLEVEL1);
                                    sToReturn = l_oInterface.Query(l_oParameters, sField, "label"); //label attr contains id in oslc result
                                    //objlogger.LogInfo("sToReturn" + sToReturn);
                                }
                                else
                                {
                                    IQueryResult l_oQueryResultField = l_oInterface.Query(l_oParameters);
                                    //objlogger.LogInfo("Second level query results l_oQueryResultField count= " + l_oQueryResultField.FieldValues.Count.ToString());
                                    //objlogger.LogInfo("Second level query results = " + l_oQueryResultField.RecordCount.ToString());

                                    if (l_oQueryResultField.FieldValues[sField.ToLower()] != null)
                                    {
                                        //objlogger.LogInfo("get value of sField");
                                        sToReturn = l_oQueryResultField.FieldValues[sField.ToLower()].ToString();
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                objlogger.LogException("Exception in getting field values of " + sField + "Exception message=" + e.Message);
                                throw e;
                            }
                        }
                        if (l_oQueryResult.RecordCount > 1)
                        {
                            //objlogger.LogInfo("Many records found from ID query " + sQuery);
                            throw new SystemException("Multiple Records found for IDQuery. Please contact administrator");
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("No records found for query", GlobalConstants.LOGGERLEVEL1);
                    }
                }
                //objlogger.LogInfo("sToReturn=" + sToReturn);
            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }

            objlogger.LogInfo("End of DecodeQuery - sToReturn=" + sToReturn, GlobalConstants.LOGGERLEVEL1);

            return sToReturn;
        }


        public ConditionResult ElementRuleEvaluate()
        {
            objlogger.LogInfo("Inside  ElementRuleEvaluate", GlobalConstants.LOGGERLEVEL1);
            ConditionResult l_oResultElementEval = new ConditionResult();
            l_oResultElementEval.Success = true;

            GlobalConstants.Operation operation =
                   (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation),
                   m_oConditionElement.Element(RulesFileTags.OPERATOR).Value.ToString(), true);

            string sOperand1;

            string sIMFFieldName = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND1));
            string sROFieldName = GetOperandDecoded(m_oConditionElement.Element(RulesFileTags.OPERAND2));

            //sOperand1 = m_xIMFNode.Element(sIMFFieldName).Value.ToString();



            if (sIMFFieldName.Contains(IMFFileTags.ATTACHMENT_FULLNAME))
            {
                objlogger.LogInfo("Inside  ElementRuleEvaluate--1", GlobalConstants.LOGGERLEVEL1);
                sOperand1 = m_xIMFNode.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString();


                List<string> l_oROAttNames = new List<string>();

                l_oROAttNames = m_xRONode.Elements(IMFFileTags.ATTACHMENT).Select(n => n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value).ToList<string>();

                objlogger.LogInfo("sOperand1" + sOperand1, GlobalConstants.LOGGERLEVEL1);
                /* foreach (string s in l_oROAttNames)
                 {
                     objlogger.LogInfo("in list ronames" + s);
                 }*/


                if (Utilities.PerformOperation(sOperand1, l_oROAttNames, operation, objlogger))
                {
                    objlogger.LogInfo("ELEMENT RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                    l_oResultElementEval.Success = true;
                }
                else
                {
                    objlogger.LogInfo("ELEMENT RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                    l_oResultElementEval.Success = false;

                }
            }
            if (sIMFFieldName.Contains(IMFFileTags.ATTACHMENT_FILESIZE))
            {
                objlogger.LogInfo("Inside  ElementRuleEvaluate--2", GlobalConstants.LOGGERLEVEL1);

                sOperand1 = m_xIMFNode.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value.ToString();

                List<string> l_oROAttSizes = new List<string>();

                l_oROAttSizes = m_xRONode.Elements(IMFFileTags.ATTACHMENT)
                    .Where(n => n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value == m_xIMFNode.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString()).
                    Select(n => n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value).ToList<string>();

                /* foreach (string s in l_oROAttSizes)
                 {
                     objlogger.LogInfo("in list rosizes" + s);
                 }*/

                objlogger.LogInfo("sOperand1" + sOperand1, GlobalConstants.LOGGERLEVEL1);
                //TEST
                //XElement ATTTobeChnagedinRO = m_xRONode.Elements()
                //     .Where(n => n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value == m_xIMFNode.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString())
                //     .Single();
                //string newval = ATTTobeChnagedinRO.Element("DESCRIPTION").Value.Replace("OrgReqDoc", "OldReqDoc");
                //ATTTobeChnagedinRO.SetElementValue("DESCRIPTION", "OldReqDoc");



                if (Utilities.PerformOperation(sOperand1, l_oROAttSizes, operation, objlogger))
                {
                    objlogger.LogInfo("ELEMENT RULE CONDITION SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                    l_oResultElementEval.Success = true;
                }
                else
                {
                    objlogger.LogInfo("ELEMENT RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);
                    l_oResultElementEval.Success = false;

                }

            }

            #region Or Evaluation
            if (!l_oResultElementEval.Success)
            {
                objlogger.LogInfo("FIELD RULE CONDITION FAILED", GlobalConstants.LOGGERLEVEL1);

                IEnumerable<XElement> xOrConditions = m_oConditionElement.Elements().Where(n => n.Name
                                                                   == RulesFileTags.OR);
                //objlogger.LogInfo("FIELD RULE CONDITION FAILED");

                foreach (XElement oElement in xOrConditions)
                {

                    Condition l_oMust = new Condition(oElement,
                                                       null,
                                                       m_xIMFNode,
                                                       m_xRONode,
                                                       m_oIMFmgr,
                                                       null, null, false, m_oRecType, null, objlogger);
                    objlogger.LogInfo("call ElementRuleEvaluate", GlobalConstants.LOGGERLEVEL1);

                    l_oResultElementEval.Success = l_oResultElementEval.Success || l_oMust.ElementRuleEvaluate().Success;
                }
            }
            #endregion

            if (!l_oResultElementEval.Success)
            {
                objlogger.LogInfo("Overall element rule evaluation failed", GlobalConstants.LOGGERLEVEL1);
                try
                {
                    //decode msg first then proceed for violationhandler
                    l_oResultElementEval.ValidationMessage = DecodeOperandForString(m_oConditionElement.Element(RulesFileTags.VIOLATIONMESSAGE).Value);


                    HandelVialotion(m_oConditionElement, m_xIMFNode);
                }
                catch { }
            }
            else
            {
                objlogger.LogInfo("Overall element rule evaluation Succeeded", GlobalConstants.LOGGERLEVEL1);
            }

            return l_oResultElementEval;
        }

        private void HandelVialotion(XElement oCondElement, XElement IMFAttachment)
        {
            objlogger.LogInfo("Inside HandelVialotion", GlobalConstants.LOGGERLEVEL1);
            if (oCondElement.HasElements && oCondElement.Element(RulesFileTags.VIOLATIONHANDLER) != null)
            {
                //objlogger.LogInfo("Inside Violation handler");

                if (oCondElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements("ELEMENTCHANGE") != null)
                {
                    objlogger.LogInfo("Inside ELEMENT change", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> xoStructKeys = oCondElement.Elements(RulesFileTags.VIOLATIONHANDLER)
                        .Elements("ELEMENTCHANGE").Elements(RulesFileTags.CHANGE);

                    foreach (XElement xelem in xoStructKeys)
                    {
                        if (xelem.HasElements)
                        {
                            XElement Xpath = xelem.Element(RulesFileTags.XPATH);
                            XElement XValueToUpdate = xelem.Element(RulesFileTags.VALUE);

                            string sXpath = ReplaceElementValues(Xpath.Value, IMFAttachment);
                            string soperand = XValueToUpdate.Value;
                            string sValueToUpdate = string.Empty;
                            if (soperand != string.Empty)
                            {
                                if (XValueToUpdate.DescendantNodes().First().NodeType == System.Xml.XmlNodeType.CDATA)
                                {
                                    //objlogger.LogInfo("Getting function name");
                                    string[] sFunNames = soperand.Split('(');
                                    string sFunName = sFunNames[0];
                                    objlogger.LogInfo("Function is =" + sFunName, GlobalConstants.LOGGERLEVEL1);
                                    soperand = soperand.Replace(sFunName + "(", "");

                                    string[] sFunNames1 = soperand.Split(')');
                                    //Get parameters now
                                    //objlogger.LogInfo("Getting parameters ");
                                    soperand = sFunNames1[0];
                                    //objlogger.LogInfo("calling ReplaceElementValues");
                                    sValueToUpdate = ReplaceElementValues(soperand, IMFAttachment);
                                    sValueToUpdate = sValueToUpdate.TrimEnd();
                                    sValueToUpdate = sValueToUpdate.TrimStart();
                                }

                            }
                            else
                            {
                                //objlogger.LogInfo("inside else");
                                sValueToUpdate = ReplaceElementValues(XValueToUpdate.Value, IMFAttachment);
                            }

                            string sAction = xelem.Elements().Last().Name.ToString();
                            string sName = xelem.Elements().Last().Value.ToString();
                            objlogger.LogInfo("calling UpdateIMFForElementChange, name=" + sName + "Value=" + sValueToUpdate, GlobalConstants.LOGGERLEVEL1);
                            m_oIMFmgr.UpdateIMFForElementChange(sName, sValueToUpdate, sXpath, sAction, objlogger);
                        }
                    }
                }
            }
        }

        private string ReplaceElementValues(string item, XElement IMFAttachment)
        {
            objlogger.LogInfo("Inside  ReplaceElementValues", GlobalConstants.LOGGERLEVEL1);
            string sValue = item;
            if (!(string.IsNullOrEmpty(sValue)))
            {
                if (item.Contains("¶ATTNAME"))
                {
                    objlogger.LogInfo("decode--1", GlobalConstants.LOGGERLEVEL2);
                    sValue = sValue.Replace("¶ATTNAME", IMFAttachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value);
                }
                if (item.Contains("¶ATTID"))
                {
                    objlogger.LogInfo("decode--2", GlobalConstants.LOGGERLEVEL2);
                    MatchCollection matchcollatttach;

                    matchcollatttach = Regex.Matches(IMFAttachment.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value, "(?'Match1'([0-9A-Za-z]*)):(?'Match2'([0-9. :]*))", RegexOptions.Multiline);
                    foreach (Match m in matchcollatttach)
                    {
                        if ((m.Groups["Match1"].Length != 0))
                        {
                            sValue = sValue.Replace("¶ATTID", m.Groups["Match1"].ToString());
                        }
                    }

                }
                if (item.Contains("¶ATTDATETIME"))
                {
                    objlogger.LogInfo("decode--3", GlobalConstants.LOGGERLEVEL2);
                    MatchCollection matchcollatttach;

                    matchcollatttach = Regex.Matches(IMFAttachment.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value, "(?'Match1'([0-9A-Za-z]*)):(?'Match2'([0-9. :]*))", RegexOptions.Multiline);
                    foreach (Match m in matchcollatttach)
                    {
                        if ((m.Groups["Match2"].Length != 0))
                        {
                            sValue = sValue.Replace("¶ATTDATETIME", m.Groups["Match2"].ToString());
                        }
                    }
                }
            }


            sValue = sValue.Trim();
            // sValueToUpdate = "ATT002:08.03.2013 11:03:09 - 20130128 Attachment - with extremly long name and changes after 50th char REBUK2121--01.txt";
            objlogger.LogInfo("End ReplaceElementValues", GlobalConstants.LOGGERLEVEL1);
            return sValue;
        }

        public string ReplaceString(string sValue, string sToReplace)
        {
            string sToReturn = string.Empty;

            if (sValue.Contains(RulesFileTags.ROFIELD))
            {
                sToReturn = sValue.Replace(RulesFileTags.ROFIELD, "");
            }
            else
            {
                sToReturn = sValue.Replace(RulesFileTags.IMFFIELD, "");
            }

            return sToReturn;
        }

        //V2.0 Workitem  132278
        private void LoopStructureQuery(XElement xElement)
        {
            string sStructureQuery = string.Empty, sReplacedQuery = string.Empty, sNewLoopVarValue = string.Empty;
            bool bLoop = true;
            try
            {
                if (xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP) != null)
                {
                    // sStructureQuery = xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP).Element(RulesFileTags.STRUCTUREQUERY).Element(RulesFileTags.IDQUERY).Value;
                    IEnumerable<XElement> xIDQuerys = xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP).Element(RulesFileTags.STRUCTUREQUERY).Elements(RulesFileTags.IDQUERY);

                    if (xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP_VARIABLE) != null)
                    {
                        XElement xLoopVariable = xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP_VARIABLE);

                        while (bLoop)
                        {
                            foreach (XElement IDQuery in xIDQuerys)
                            {
                                sStructureQuery = IDQuery.Value;
                                objlogger.LogInfo("IDQuery : " + sStructureQuery, GlobalConstants.LOGGERLEVEL1);

                                //Replace Loop Variable with with RO field name in Query - $RO.AFFECTEDISSUE.ID
                                if (string.IsNullOrEmpty(sNewLoopVarValue) && sStructureQuery.Contains("$" + xLoopVariable.Element(RulesFileTags.VAR_NAME).Value + "¶"))
                                {
                                    sReplacedQuery = sStructureQuery.Replace("$" + xLoopVariable.Element(RulesFileTags.VAR_NAME).Value + "¶", xLoopVariable.Element(RulesFileTags.VAR_VALUE).Value);
                                    objlogger.LogInfo("Query after replacing loop variable with RO field name: " + sReplacedQuery, GlobalConstants.LOGGERLEVEL1);
                                }
                                //Replace Loop Variable with  with SC field name in Query - $SC.AFFECTEDISSUE.ID
                                else if (!string.IsNullOrEmpty(sNewLoopVarValue) && sStructureQuery.Contains("$" + xLoopVariable.Element(RulesFileTags.VAR_NAME).Value + "¶"))
                                {
                                    sReplacedQuery = sStructureQuery.Replace("$" + xLoopVariable.Element(RulesFileTags.VAR_NAME).Value + "¶", sNewLoopVarValue);
                                    objlogger.LogInfo("Query after replacing loop variable with SC field name: " + sReplacedQuery, GlobalConstants.LOGGERLEVEL1);
                                }
                                else
                                { objlogger.LogInfo("Loop Variable not found in Query : " + sStructureQuery, GlobalConstants.LOGGERLEVEL1); }

                                //Execute StructureChange IDQuery
                                ProcessStructureQuery(sReplacedQuery);
                            }

                            
                            if (s_oQueryResult != null && s_oQueryResult.RecordCount > 0)
                            {
                                objlogger.LogInfo(string.Format("s_oQueryResult count is - {0}", s_oQueryResult.RecordCount));
                                IEnumerable<XElement> xoStructKeys = xElement.Elements(RulesFileTags.VIOLATIONHANDLER).Elements(RulesFileTags.STRUCTURECHANGE).Elements(RulesFileTags.LOOP).Elements(RulesFileTags.CHANGE);
                                //objlogger.LogInfo("Before Structure change");
                                //Processing of CHANGE elements 
                                foreach (XElement xelem in xoStructKeys)
                                {
                                    if (xelem.HasElements)
                                    {
                                        XElement Xpath = xelem.Element(RulesFileTags.XPATH);
                                        XElement XValueToUpdate = xelem.Element(RulesFileTags.VALUE);

                                        string sXpath = DecodeFunction(Xpath);
                                        string sValueToUpdate = DecodeFunction(XValueToUpdate);
                                        string sAction = xelem.Elements().Last().Name.ToString();
                                        string sName = xelem.Elements().Last().Value.ToString();
                                        objlogger.LogInfo("calling UpdateIMFForStructChange, name=" + sName + "Value=" + sValueToUpdate, GlobalConstants.LOGGERLEVEL1);
                                        m_oIMFmgr.UpdateIMFForStructChange(sName, sValueToUpdate, sXpath, sAction, objlogger);
                                    }

                                }

                                //objlogger.LogInfo("After Structure change");
                                sNewLoopVarValue = xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP).Element(RulesFileTags.LOOP_VARIABLE).Element(RulesFileTags.VAR_VALUE).Value;
                                
                                string sDecodedValue = string.Empty;
                                try
                                {
                                    sDecodedValue = DecodeOperandForString(sNewLoopVarValue);
                                }
                                catch (Exception ex)
                                {
                                    objlogger.LogInfo("Error decoding sNewLoopVarValue: " + ex.Message, GlobalConstants.LOGGERLEVEL2);
                                }
                                
                                // Decode sNewLoopVarValue and check its value -  If not empty, perpare next query based on current query result
                                if (string.IsNullOrEmpty(sDecodedValue))
                                {
                                    objlogger.LogInfo("sNewLoopVarValue after decoding is empty", GlobalConstants.LOGGERLEVEL2);
                                    bLoop = false;
                                }
                                else
                                {
                                    objlogger.LogInfo("sNewLoopVarValue after decoding is: " + sDecodedValue, GlobalConstants.LOGGERLEVEL2);
                                    objlogger.LogInfo("oldLoopVarValue: " + oldDecodedValue);
                                    if (!string.Equals(sDecodedValue, oldDecodedValue))
                                    {
                                        oldDecodedValue = sDecodedValue;
                                        objlogger.LogInfo("Updated oldLoopVarValue : " + oldDecodedValue);
                                    }
                                    else
                                    {
                                        bLoop = false;
                                        objlogger.LogInfo("Same loop variable found again : " + oldDecodedValue);
                                        string sOperand1, sOperand2 = string.Empty;
                                        if (xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP).Element(RulesFileTags.OPTCONDITION) != null)
                                        {
                                            XElement innerOptConditionElement = xElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Element(RulesFileTags.LOOP).Element(RulesFileTags.OPTCONDITION);
                                            sOperand1 = GetOperandDecoded(innerOptConditionElement.Element(RulesFileTags.OPERAND1));
                                            sOperand2 = GetOperandDecoded(innerOptConditionElement.Element(RulesFileTags.OPERAND2));
                                            GlobalConstants.Operation operation = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation), innerOptConditionElement.Element(RulesFileTags.OPERATOR).Value.ToString(), true);

                                            objlogger.LogInfo("FIELDS: Operand1=" + sOperand1 + "Operand2=" + sOperand2, GlobalConstants.LOGGERLEVEL1);

                                            if (sOperand1.ToUpper() == RulesFileTags.COUNTRECORDS)
                                            {
                                                objlogger.LogInfo("inside OPTCONDITION of structure query", GlobalConstants.LOGGERLEVEL1);
                                                int iResult = 0; // directly set to 0 ,though s_QueryResult count is not zero - because there is no result yielded in the IDQueries of 
                                                //the current affected issue and the same loop variable(affected issue) is found again which will be an endless execution 
                                                //(Refer - 614881 WI in ALM)

                                                int iCount = Convert.ToInt16(innerOptConditionElement.Element(RulesFileTags.OPERAND2).Value.ToString());
                                                objlogger.LogInfo("iResult=" + iResult.ToString() + "iCount=" + iCount.ToString(), GlobalConstants.LOGGERLEVEL1);

                                                if (Utilities.PerformOperation(iResult, iCount, operation))
                                                {
                                                    objlogger.LogInfo("OPTCONDITION of structure query SUCCEEDED", GlobalConstants.LOGGERLEVEL1);
                                                }
                                                else
                                                {
                                                    objlogger.LogInfo("OPTCONDITION of structure query FAILED", GlobalConstants.LOGGERLEVEL1);
                                                    if (innerOptConditionElement.Elements(RulesFileTags.VIOLATIONHANDLER) != null)
                                                    {
                                                        XElement fieldChangeElement = innerOptConditionElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.FIELDCHANGE);
                                                        string sVar = fieldChangeElement.Element(RulesFileTags.IMFUPDATEFIELD).Value;
                                                        XElement xUpdateValue = fieldChangeElement.Element(RulesFileTags.IMFUPDATEVALUE);
                                                        string sValue = DecodeFunction(xUpdateValue);
                                                        objlogger.LogInfo("VALUES: Var=" + sVar + "Value=" + sValue, GlobalConstants.LOGGERLEVEL1);
                                                        //get imf value without $
                                                        string sIMFField = ReplaceString(sVar, "");
                                                        m_oIMFmgr.UpdateIMFFromRulesFile(sIMFField, sValue, m_xIMFNode, true, m_oRuntimeParms[OrcParameters.EXCHANGEFORMAT]);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                objlogger.LogInfo("No records found out of structure query", GlobalConstants.LOGGERLEVEL1);
                                bLoop = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Error in sStructureQuery:" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
        }

        private void ProcessStructureQuery(string sStructureQuery, bool bLoopStrQueryResults = false)
        {
            try
            {
                sStructureQuery = DecodeOperandForString(sStructureQuery);

                //objlogger.LogInfo("After decode:Structure Query:" + sStructureQuery);
                m_oROmgr.QueryString = sStructureQuery;

                RODataInterface l_oInterface;

                //  m_oInterface!=null for ID Rule
                // if (m_oInterface!=null)     
                // {
                //   objlogger.LogInfo("m_oInterface not null");
                //   l_oInterface = m_oInterface;
                //  }
                // else 
                // {
                //  m_oInterface=null for Field Rule
                //objlogger.LogInfo("m_oInterface is null");
                l_oInterface = ((OSLC_QueryResult)m_oQueryResult).DataInterface;
                // }

                objlogger.LogInfo("exec Structutre query", GlobalConstants.LOGGERLEVEL1);
                IQueryResult l_oQueryResult = l_oInterface.Query(sStructureQuery);

                if (l_oQueryResult.RecordCount > 0)
                {
                    // objlogger.LogInfo("Record count > 0");
                    if (l_oQueryResult.RecordCount == 1)
                    {
                        QueryParameters l_oParameters = new QueryParameters();
                        l_oParameters.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryResult.GetRaw());
                        IQueryResult l_oQueryResultField = l_oInterface.Query(l_oParameters);
                        s_oQueryResult = l_oQueryResultField;
                        s_oQueryResult.RecordCount = l_oQueryResult.RecordCount;

                        if (bLoopStrQueryResults)
                        {
                            s_oQueryResults.Add(s_oQueryResult);
                        }
                    }
                    else if (l_oQueryResult.RecordCount > 1 && bLoopStrQueryResults == true)
                    {
                        objlogger.LogInfo("Multiple records found from structure query: " + sStructureQuery, GlobalConstants.LOGGERLEVEL1);
                        QueryParameters l_oParameters = new QueryParameters();
                        l_oParameters.AddComplex(OSLCComplexType.ALLRECORDS, l_oQueryResult.GetRaw());
                        s_oQueryResults = l_oInterface.Query(l_oParameters, bLoopStrQueryResults);

                    }
                    else
                    {
                        //objlogger.LogInfo("Many records found from structure query " + sStructureQuery);
                        throw new SystemException("Multiple Records found for structure Query. Please contact administrator");
                    }
                }
                else
                {
                    objlogger.LogInfo("No records found for structure query " + sStructureQuery, GlobalConstants.LOGGERLEVEL1);
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("ProcessStructureQuery" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
        }


        private void LoopStructureQueryResults(XElement xConditionElement)
        {
            string sStructureQuery = string.Empty, sOperand1 = string.Empty, sOperand2 = string.Empty;
            try
            {
                if (xConditionElement.Element(RulesFileTags.STRUCTUREQUERY) != null)
                {
                    sStructureQuery = xConditionElement.Element(RulesFileTags.STRUCTUREQUERY).Value;
                    //objlogger.LogInfo("StructureQuery : " + sStructureQuery);
                    ProcessStructureQuery(sStructureQuery, bLoopStructureQueryResults);
                }

                if (s_oQueryResults != null && s_oQueryResults.Count > 0)
                {
                    XElement xStructureChange = xConditionElement.Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE);
                    XElement xFilter = xStructureChange.Element(RulesFileTags.FILTER);
                    foreach (object s_oQueryResult in s_oQueryResults)
                    {
                        bool bFilterSuccess = false;

                        sOperand1 = GetOperandDecoded(xFilter.Element(RulesFileTags.OPERAND1));
                        sOperand2 = GetOperandDecoded(xFilter.Element(RulesFileTags.OPERAND2));
                        GlobalConstants.Operation operation = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation), xFilter.Element(RulesFileTags.OPERATOR).Value, true);

                        objlogger.LogInfo("sOperand1 , sOperand2 and operation = " + sOperand1 + ", " + sOperand2 + ", " + operation.ToString(), GlobalConstants.LOGGERLEVEL1);
                        objlogger.LogInfo("Before checking FILTER condition - iFilterSuccessCount:" + iFilterSuccessCount + " iStructQueryResultIndex:" + iStructQueryResultIndex, GlobalConstants.LOGGERLEVEL1);

                        bFilterSuccess = Utilities.PerformOperation(sOperand2, sOperand1, operation);
                        // AND evaluation
                        IEnumerable<XElement> xANDConditions = xFilter.Elements().Where(n => n.Name
                                                                       == RulesFileTags.AND);

                        if (bFilterSuccess == true)
                        {
                            // AND evaluation
                            foreach (XElement xANDCondition in xANDConditions)
                            {
                                bool bSuccess = false;
                                //objlogger.LogInfo("Evaluating And Condition" + xANDCondition.ToString());
                                sOperand1 = GetOperandDecoded(xANDCondition.Element(RulesFileTags.OPERAND1));
                                sOperand2 = GetOperandDecoded(xANDCondition.Element(RulesFileTags.OPERAND2));
                                operation = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation), xANDCondition.Element(RulesFileTags.OPERATOR).Value, true);
                                objlogger.LogInfo("Evaluating And Condition - sOperand1 , sOperand2 and operation = " + sOperand1 + ", " + sOperand2 + ", " + operation.ToString(), GlobalConstants.LOGGERLEVEL1);
                                bSuccess = Utilities.PerformOperation(sOperand2, sOperand1, operation);
                                objlogger.LogInfo("bSuccess:" + bSuccess, GlobalConstants.LOGGERLEVEL1);
                                bFilterSuccess = bFilterSuccess && bSuccess;

                                //Skip further AND evaluation if its already false
                                if (!bFilterSuccess)
                                {
                                    break;
                                }

                            }
                        }


                        if (bFilterSuccess)
                        {
                            objlogger.LogInfo("FILTER condition succeeded", GlobalConstants.LOGGERLEVEL1);
                            iFilterSuccessCount = iFilterSuccessCount + 1;

                            if (xStructureChange.Elements(RulesFileTags.LOOP).Elements(RulesFileTags.CHANGE) != null)
                            {
                                IEnumerable<XElement> xChangeElements = xStructureChange.Elements(RulesFileTags.LOOP).Elements(RulesFileTags.CHANGE);
                                //objlogger.LogInfo("Before Structure change");
                                //Processing of CHANGE elements 
                                foreach (XElement xChange in xChangeElements)
                                {
                                    if (xChange.HasElements)
                                    {
                                        XElement Xpath = xChange.Element(RulesFileTags.XPATH);
                                        XElement XValueToUpdate = xChange.Element(RulesFileTags.VALUE);

                                        string sXpath = DecodeFunction(Xpath);
                                        string sValueToUpdate = DecodeFunction(XValueToUpdate);
                                        string sAction = xChange.Elements().Last().Name.ToString();
                                        string sName = xChange.Elements().Last().Value.ToString();
                                        objlogger.LogInfo("Calling UpdateIMFForStructChange: Name=" + sName + "Value=" + sValueToUpdate, GlobalConstants.LOGGERLEVEL1);
                                        m_oIMFmgr.UpdateIMFForStructChange(sName, sValueToUpdate, sXpath, sAction, objlogger);
                                        //objlogger.LogInfo("After UpdateIMFForStructChange");
                                    }
                                }
                            }
                        }
                        else
                        {
                            objlogger.LogInfo("FILTER condition failed", GlobalConstants.LOGGERLEVEL1);

                        }

                        iStructQueryResultIndex = iStructQueryResultIndex + 1;
                        objlogger.LogInfo("iStructQueryResultIndex :" + iStructQueryResultIndex, GlobalConstants.LOGGERLEVEL1);
                        objlogger.LogInfo("iFilterSuccessCount :" + iFilterSuccessCount, GlobalConstants.LOGGERLEVEL1);
                    }

                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Error in LoopStructureQueryResults:" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
            finally
            {
                bLoopStructureQueryResults = false;
            }
        }
    }
}
