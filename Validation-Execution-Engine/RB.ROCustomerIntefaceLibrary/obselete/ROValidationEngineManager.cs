using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;


namespace RB.ROCustomerIntefaceLibrary
{
    public class ROValidationEngineManager:RORuleValidationEngine   
    {
        ROResultSet l_oResultSet = new ROResultSet();

        public ROValidationEngineManager(string strRuleFile, XDocument xIssueIntermFile)
        {
            ValidationRuleFilePath = strRuleFile;
            IssueIMF = xIssueIntermFile;
            GetIssueExternalID();
        }

        void GetIssueExternalID()
        {
            try
            {
                IssueExternalID = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                        .Element(IMFFileTags.ISSUE).Element(IMFFileTags.EXTERNALID).Value.ToString();
            }
            catch (Exception ex)
            {
                IssueExternalID = null;
                Utilities.objLogger.LogException(ex, "ValidateIMF: Issue External ID not present");
            }
            
        }

        public override bool ValidateIMF()
        {

            bool isValid = false;
            /* Temp code to be removed later */

            InterfaceConfigFile = XDocument.Load("RO_Interface_Config.xml");

            /*Tem code end*/

            try
            {
                Utilities.objLogger.LogInfo("ROValidationEngineManager::ValidateIMF :- Starts");
                  //1. load the rule file
                Utilities.objLogger.LogInfo("ValidateIMF - ValidationRuleFilePath: " + ValidationRuleFilePath);
                try
                {
                    Utilities.objLogger.LogInfo("Initial validation - Check for IssueExternalID");
                    if (String.IsNullOrWhiteSpace(IssueExternalID) == false)
                    { 
                        Utilities.objLogger.LogInfo("Step 1: LoadValidationsRulesFile() Starts ");
                        if (LoadValidationsRulesFile(ValidationRuleFilePath))
                        {
                            isValid = true;
                            //2. Call ProcessAllRules
                            try
                            {
                                Utilities.objLogger.LogInfo("Step 2: ProcessAllRules() Starts ");
                                if (ProcessAllRules())
                                {
                                    isValid = true;
                                }
                                else
                                {
                                    throw new ProcessAllRulesException("Process All rules failed");
                                }
                            }
                            catch (ProcessAllRulesException ex)
                            {
                                Utilities.objLogger.LogInfo("ProcessAllRules() Exception");
                                isValid = false;
                            }
                        }
                        else
                        {
                            Utilities.objLogger.LogInfo("LoadValidationsRulesFile() Exception");
                            throw new IMRuleFileLoadingException("Loading of the IMFRule file failed");
                        }
                    }
                    else
                    {
                        //External ID is missing. Do not proceed further.
                        throw new ExternalIDMissingException("ExternalID Missing");
                    }
                }
                catch (ExternalIDMissingException eidmex)
                {
                    isValid = false;
                    Utilities.objLogger.LogException(eidmex, "ValidateIMF: Issue External ID not present");
                }
                catch (IMRuleFileLoadingException imex)
                {
                    Utilities.objLogger.LogException(imex, "ValidateIMF: Loading Exception");
                    isValid = false;
                }               
            }
            catch (Exception ex)
            {
                Utilities.objLogger.LogException(ex, "ValidateIMF: Other error -");
                isValid = false;
            }
            finally
            {
               
            }
            Utilities.objLogger.LogInfo("ROValidationEngineManager::ValidateIMF :- Ends");
            return isValid;
        }

        public override bool ProcessAllRules()
        {
            bool isValid = false;
            Utilities.objLogger.LogInfo("ProcessAllRules :- Starts");
            try
            {
                //Get current State of the Issue
                GetIssueState();

                if (ProcessCommonRules())
                {
                    if (ProcessStateBasedRules(IssueExternalState))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (ProcessAllRulesException ex)
            {
                Utilities.objLogger.LogException(ex, "ProcessAllRules");
            }
            catch (Exception)
            {

                throw;
            }
            Utilities.objLogger.LogInfo("ProcessAllRules :- Ends");
            return isValid;
         
        }

        public override string GetIssueState()
        {
            string strIsssueState = "";
            Utilities.objLogger.LogInfo("GetIssueState :- Starts");
            try
            {
                //Get the IssueState & IssueExternalState 
                IssueState = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                        .Element(IMFFileTags.ISSUE).Element(IMFFileTags.STATE).Value;
                Utilities.objLogger.LogInfo("IssueState: " + IssueState);
                
                IssueExternalState = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                    .Element(IMFFileTags.ISSUE).Element(IMFFileTags.EXTERNALSTATE).Value;
                Utilities.objLogger.LogInfo("IssueExternalState: " + IssueExternalState);
            }
            catch (Exception ex)
            {

                Utilities.objLogger.LogException(ex, "GetIssueState: Error in getting state values");
            
            }
            Utilities.objLogger.LogInfo("GetIssueState :- Ends");
            return strIsssueState;
        }

        public override bool ProcessCommonRules()
        {
            bool isValid = false;
            Utilities.objLogger.LogInfo("ProcessCommonRules - Starts");
            try
            {
                XElement xoCommonRule = ValidationRuleConfigurationXMLFile
                    .Root.Element(RulesFileTags.INTERFACE)
                    .Element(RulesFileTags.COMMON_RULES);

                if(ProcessRule(xoCommonRule))
                {
                    isValid = true;
                }
                else
                {
                    throw new ProcessCommonRulesException("ProcessCommonRules(): Return value is false from ProcessRule()");
                }

            }
            catch (ProcessCommonRulesException pceex)
            {
                Utilities.objLogger.LogException(pceex, "ProcessCommonRules");
                isValid = false;
            }
            catch (Exception ex)
            {
                Utilities.objLogger.LogException(ex, "ProcessCommonRules");
                isValid = false;
            }

            Utilities.objLogger.LogInfo("ProcessCommonRules - Ends");
            return isValid;
        }

        public override bool ProcessStateBasedRules(string strStatename)
        {

            bool isValid = false;

           IEnumerable<XElement> l_oElements =
                from el in ValidationRuleConfigurationXMLFile.Root
                    .Element(RulesFileTags.INTERFACE).Elements(RulesFileTags.EXTERNAL_STATE_BASED_RULE)
                where
                    (string)el.Attribute(RulesFileTags.ATTR_NAME) == strStatename
                select el;

            XElement xoCommonRule = l_oElements.First<XElement>(); 
    
            if (ProcessRule(xoCommonRule))
            {
                isValid = true;
            }
            else
            {
                throw new ProcessCommonRulesException("ProcessStateBasedRules(): Return value is false from ProcessRule()");
            }

            return isValid;
        }

        public bool ProcessRule(XElement xRulesNode)
        {
            bool isValid = true;
            Utilities.objLogger.LogInfo("ProcessRule() - Starts");
            try
            {
                //Process rules one after another
                foreach (XElement xRule  in xRulesNode.Elements())
                {
                    //string strRecType = xRule.Attribute("name").Value.ToString();

                    GlobalConstants.RORecordTypes roRecordType 
                        = (GlobalConstants.RORecordTypes) Enum.Parse(typeof(GlobalConstants.RORecordTypes), 
                            xRule.Attribute(RulesFileTags.ATTR_NAME).Value.ToString(),true);

                    Utilities.objLogger.LogInfo("Getting XPATH from rule");
                    string sIMFXPath = xRule.Element(RulesFileTags.XPATH).Value.ToString();  
 
                   //Process IMFRules
                    XElement xoIMFRules = xRule.Element(RulesFileTags.IMF_RULES);
                    
                    //PROCESS RORULES
                    XElement xoRORules = xRule.Element(RulesFileTags.RO_RULES);

                    if (ProcessIMFRule(xoIMFRules, roRecordType, sIMFXPath))
                    {
                        if (!ProcessRORules(xoRORules, roRecordType, sIMFXPath))
                        {
                           return false;
                        }
                    }
                    else
                    {
                        throw new ProcessIMFRuleException("Validation of IMF Rule failed");
                    }

                }
            }
            catch (ArgumentException ex)
            {
                isValid = false;
                Utilities.objLogger.LogException(ex, "ProcessRule() - Invalid recordtype from IMF RULE Validation file");
            }
                
            catch (Exception ex)
            {

                isValid = false;
                Utilities.objLogger.LogException(ex,"ProcessRule() - Error");

            }
            Utilities.objLogger.LogInfo("ProcessRule() - ends");
            return isValid;
        }


        public override bool ProcessIMFRule(XElement xRulesNode, GlobalConstants.RORecordTypes rorecType, string sXPATH)
        {
            bool isValid = false;
            try
            {
                if (!(string.IsNullOrWhiteSpace(sXPATH)))
                {    //Process IMF_RULE -> IDRULE, RORULES
                    XElement xIMFIDRule = xRulesNode.Element(RulesFileTags.IDRULE);
                    if (ProcessIMFIDRules(xIMFIDRule, sXPATH))
                    {
                        isValid = true;
                    }
                    else 
                    {
                        Utilities.objLogger.LogInfo("IMFID rule failed\n" + xIMFIDRule.ToString());
                        return false;
                    }

                    XElement xIMFFieldRule = xRulesNode.Element(RulesFileTags.FIELDRULES);
                    if (ProcessIMFFieldRules(xIMFFieldRule, sXPATH))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Utilities.objLogger.LogInfo("IMF Fieldrule failed\n" + xIMFIDRule.ToString());
                        return false;
                    }
                }
                else
                {
                    throw new IMFXPATHMissingException("XPATH missing for recordtype -" + rorecType.ToString());
                }
            }
            catch (IMFRulesFileNotFoundFileException ex)
            {
                Utilities.objLogger.LogException(ex, "ProcessIMFRule(): Error occured");
                isValid = false;
            }
            catch (Exception ex)
            {
                Utilities.objLogger.LogException(ex, "ProcessIMFRule(): Error occured");
                isValid = false;
            }
            return isValid;
        }

        public bool ProcessIMFIDRules(XElement xIDRule, string sXPath)
        {
            bool isValid = false;
            try
            {
                //Get the count value and query for the xpath
                XElement xoCount = xIDRule.Element(RulesFileTags.COUNT);
                Int16 iCount = Convert.ToInt16(xoCount.Element(RulesFileTags.VALUE).Value.ToString());
                GlobalConstants.Operation operation 
                    = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation), 
                    xoCount.Element(RulesFileTags.OPERATOR).Value.ToString(), true);

                XElement xRoot = IssueIMF.Root.XPathSelectElement(sXPath);
                //IEnumerable<XElement> xElems = xDoc.Root.XPathSelectElements(sXPath);
                //Get the count of nodes
                int iResult = IssueIMF.Root.XPathSelectElements(sXPath).Count();
                if (Utilities.PerformOperation(iResult, iCount, operation))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }


            }
            catch (ArgumentException aex)
            {
                isValid = false;
            }
            catch (XPathException xpex)
            { 
                isValid = false;
            }
            catch (Exception ex)
            {

                isValid = false;
            }
            return isValid;
        }

        public override bool ProcessIMFFieldRules(XElement xIMFFieldRules, string sXPath)
        {
            bool isValid = false;
            try
            {
                foreach (XElement xFieldRule in xIMFFieldRules.Elements(RulesFileTags.FIELDRULE))
                {
                    //check against the xpath
                    //Get the field name 
                    string sFieldName = xFieldRule.Element(RulesFileTags.FIELDNAME).Value;
                    //get the field value
                    string sFieldValue = xFieldRule.Element(RulesFileTags.FIELDVALUE).Value;
                    //Operator
                    GlobalConstants.Operation operation = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation), xFieldRule.Element("OPERATOR").Value.ToString(), true);
                    string sValueFromIMF;
                    
                    IEnumerable<XElement> XElements = IssueIMF.Root.XPathSelectElements(sXPath);

                    foreach (XElement xoSelElement in XElements)
                    {
                        sValueFromIMF = xoSelElement.Element(sFieldName.Trim().ToUpper()).Value.ToString();

                        if (Utilities.PerformOperation(sFieldValue, sValueFromIMF, operation, true))
                        {
                            isValid = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            } 
            return isValid;
        }

        public bool ProcessRORules(XElement xRORules, GlobalConstants.RORecordTypes roRecType, string sXPATH)
        {
            bool isValid = true;
           
            try
            {
                if (!(string.IsNullOrWhiteSpace(sXPATH)))
                {
                    XElement xROIDRule = xRORules.Element(RulesFileTags.IDRULE);
                    if (ProcessROIDRules(xRORules, sXPATH, roRecType))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Utilities.objLogger.LogInfo("ROID rule failed\n" + xROIDRule.ToString());
                        return false;
                    }

                }
                else
                {
                    throw new IMFXPATHMissingException("XPATH missing for recordtype -" + roRecType.ToString());
                }

            }
            catch (Exception ex)
            {
                Utilities.objLogger.LogInfo("error while executing the query - " + ex.Message);
                isValid = false;
            }

            return isValid;
        }


        public bool ProcessROIDRules(XElement xRORules, string sXPath, GlobalConstants.RORecordTypes roRecordType)
        {
             bool isValid = false;
             try
             {
                 XElement xIDRule = xRORules.Element(RulesFileTags.IDRULE);
                 XElement xROFieldRule = xRORules.Element(RulesFileTags.FIELDRULES);

                 //Get the count value and query for the xpath
                 XElement xoCount = xIDRule.Element(RulesFileTags.COUNT);
                 Int16 iCount = Convert.ToInt16(xoCount.Element(RulesFileTags.VALUE).Value.ToString());
                 GlobalConstants.Operation operation
                     = (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation),
                     xoCount.Element(RulesFileTags.OPERATOR).Value.ToString(), true);

                 //Get The Key
                 XElement xoKey = xIDRule.Element(RulesFileTags.KEY);
                 string sKeyTocheck = xoKey.Value.ToString();

                 //Get all nodes for the given XPath
                 XElement xRoot = IssueIMF.Root.XPathSelectElement(sXPath);
                 IEnumerable<XElement> xElems = IssueIMF.Root.XPathSelectElements(sXPath);
                 string sValueToCheck = string.Empty;

                 foreach (XElement xContext in xElems)
                 {
                     try
                     {
                         IEnumerable<XElement> xValueToCheck = xContext.Elements(sKeyTocheck.ToUpper());
                         sValueToCheck = xValueToCheck.First<XElement>().Value.ToString();
                     }
                     catch
                     {
                         Utilities.objLogger.LogInfo("Key not found in IMF file " +sKeyTocheck);
                         throw;
                     }

                     //Get the count from OSCL
                     string sQuery = BuildQuery(sKeyTocheck, sValueToCheck, roRecordType);
                     ROClearQuestManager rCQMgr = new ROClearQuestManager(InterfaceConfigFile);
                     XDocument xResponseFromCQ = rCQMgr.ExecuteOSLCQuery(sQuery);
                     int iResult = GetRecordCount(xResponseFromCQ, rCQMgr);
                     
                     if (Utilities.PerformOperation(iResult,iCount, operation))
                     {
                         isValid = true;

                         if (iResult > 0)
                         {
                             isValid = ProcessROFieldRules(xROFieldRule, roRecordType
                                 , xResponseFromCQ, xContext);

                             if (!isValid) return false;
                         }
                         else
                         {
                             //Now we know that that this is a new record so update the result set
                             l_oResultSet.AddNodeForAddtion(xContext);

                         }
                     }
                     else
                     {
                         return false;
                     }
                 }
             }
             catch (Exception ex)
             {
                 Utilities.objLogger.LogInfo("error in ROID rule " + ex.StackTrace);
                 isValid = false;
             }

             return isValid;
        }

        public string BuildQuery(string sKey, string sValue, GlobalConstants.RORecordTypes roRecType)
        {
            string sQuery = string.Empty;

            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("oslc_cm.query=");
            sBuilder.Append(sKey);
            sBuilder.Append("=");
            sBuilder.Append("\"");
            sBuilder.Append(sValue);
            sBuilder.Append("\"");
            sBuilder.Append("&rcm.type=" + roRecType.ToString());

            sQuery = sBuilder.ToString();

            return sQuery;
        }


        public int GetRecordCount(XDocument xResponseFromCQ, ROClearQuestManager rCQMgr)
        {
            XElement xLink = xResponseFromCQ.Descendants(rCQMgr.nsoslc + "totalCount").Single();

            return Convert.ToInt16(xLink.Value.ToString());
        }

        public bool ProcessROFieldRules(XElement xROFieldRules, 
            GlobalConstants.RORecordTypes roRecordType,XDocument xDoc,
            XElement xNode)
        {
            bool isValid = false;
            string sValueFromOSLC = string.Empty;
            string sOrginalValueOSLC = string.Empty;
            bool isNodeUpdated = false;

            try
            {
                foreach (XElement xFieldRules in xROFieldRules.Elements(RulesFileTags.FIELDRULE))
                {
                    //check against the xpath
                    //Get the field name 
                    string sFieldName = xFieldRules.Element(RulesFileTags.FIELDNAME).Value;
                    //get the field value
                    string sFieldValue = xFieldRules.Element(RulesFileTags.FIELDVALUE).Value;
                    //Operator
                    GlobalConstants.Operation operation = 
                        (GlobalConstants.Operation)Enum.Parse(typeof(GlobalConstants.Operation),
                        xFieldRules.Element(RulesFileTags.OPERATOR).Value.ToString(), true);


                    ROClearQuestManager rCQMgr = new ROClearQuestManager(InterfaceConfigFile);
                    XDocument xResponseFromCQ = rCQMgr.GetLinkedRecord(xDoc);

                    if (xResponseFromCQ == null) return false;

                    //sValueFromOSLC = xResponseFromCQ.Root.Element(sFieldName.Trim()).Value.ToString();

                    foreach (XElement xProperty in xResponseFromCQ.Root.Elements())
                    {
                        string sAttr = xProperty.Name.ToString();
                        sAttr = sAttr.Replace("{","");
                        sAttr = sAttr.Replace("}","");
                        sAttr = sAttr.Replace("http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/", "");

                        try
                        {
                            /* As we are getting the value here makes sense to 
                             look also for changes */

                            sOrginalValueOSLC = xProperty.Value.ToString();

                            if (sAttr.ToUpper() == "DBID")
                            {
                                l_oResultSet.AddElementToNode(sAttr.ToUpper(), xNode, sOrginalValueOSLC);
                            }

                            string sIMFValue = xNode.Element(sAttr.ToUpper()).Value.ToString();

                            if (sOrginalValueOSLC != sIMFValue)
                            {
                                l_oResultSet.MarkFieldForUpdation(sAttr.ToUpper(),xNode);
                                isNodeUpdated = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.objLogger.LogInfo("Tag not found in IMF " + ex.StackTrace);
                        }

                        if (sAttr.ToUpper() == sFieldName.ToUpper())
                        {
                            sValueFromOSLC = xProperty.Value.ToString();
                            
                        }
                    }

                    if (Utilities.PerformOperation(sFieldValue, sValueFromOSLC, operation, true))
                    {
                        isValid = true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (isNodeUpdated) l_oResultSet.AddNodeForUpdate(xNode);
            return isValid;
        }

        public void ValidateRODataWithXML()
        {
            throw new NotImplementedException();
        }

        public void LoadContentFromRO(string strEntity, string strStringToSearch)
        {
            throw new NotImplementedException();
        }

        public void SaveResultSet(string sFileName)
        {
            l_oResultSet.SaveXML(sFileName);
        }
    }

  
}
