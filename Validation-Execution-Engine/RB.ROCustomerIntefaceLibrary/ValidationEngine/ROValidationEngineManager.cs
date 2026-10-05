using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Saxon.Api;
using System.Web;
using System.Threading;

namespace RB.ROCustomerIntefaceLibrary
{
    public class ROValidationEngineManager : RORuleValidationEngine
    {
        bool bCustomErrorRegistered = false, bMsgACK = false;
        RODataInterface l_oDataInterface = null;
        Logger objlogger = null;

        //Declare Reset variables  REUBK-1232
        bool bReset = false;
        int iResetCount = 0;
        public string sResetMessage = string.Empty;
        public string sXSLTLNScriptPath = string.Empty;
        public string sXSLTROIMFScriptPath = string.Empty;

        Dictionary<string, object> ListQueryResults { get; set; }
        IQueryResult QueryResult { get; set; }
        List<int> ListOfDbids { get; set; }

        public Dictionary<string, string> OrcParms
        {
            get;
            set;
        }
        XmlNamespaceManager nsIMFMgr;
        public ROValidationEngineManager(string strRuleFile, XDocument xIssueIntermFile, Dictionary<string, string> p_OrcParms, bool bIsMsgAck, Logger l_ologger)
        {
            ValidationRuleFilePath = strRuleFile;
            IssueIMF = xIssueIntermFile;
            nsIMFMgr = Utilities.GetIMFNameSpace(xIssueIntermFile);
            OrcParms = p_OrcParms;
            objlogger = l_ologger;
           // GetIssueExternalID();
            bMsgACK = bIsMsgAck;

        }
        //void GetIssueExternalID()
        //{

        //    objlogger.LogInfo("GetIssueExternalID: Starts");
        //    try
        //    {
        //        IssueExternalID = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
        //                .Element(IMFFileTags.ISSUE).Element(IMFFileTags.EXTERNALID).Value.ToString();
        //        objlogger.LogInfo("IssueExternalID: " + IssueExternalID);
        //    }
        //    catch (Exception ex)
        //    {
        //        IssueExternalID = null;
        //        objlogger.LogException(ex, "ValidateIMF: Issue External ID not present");
        //    }
        //    objlogger.LogInfo("GetIssueExternalID: Ends");
        //}

        public override bool ValidateIMF()
        {

            bool isValid = false;
            /* Temp code to be removed later */
            //Commented by Karthik
            //InterfaceConfigFile = XDocument.Load("RO_Interface_Config.xml");
            /*Tem code end*/



            l_oDataInterface =
                     Factory.GetInterface(ROAvailableDataInterfaces.OSLC, OrcParms[OrcParameters.EXCHANGEFORMAT], null, OrcParms[OrcParameters.SYSTEM], OrcParms[OrcParameters.ATTACHMENTPATH], objlogger);



            #region ExecutingStack
            if (GlobalConstants.isCurrentlyExecuting(OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], objlogger))
            {
                ROErrorLogger.RegisterUserError("Validation engine failed with error - File is currently being imported by another Exchange Protocol or not registered."
                                   , OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                return false;
            }
            #endregion

            try
            {
               // objlogger.LogInfo("ROValidationEngineManager::ValidateIMF :- Starts");

                //if (!bMsgACK)
                {

                    try
                    {
                        //1. load the rule file

                        objlogger.LogInfo("ROValidationEngineManager::ValidateIMF: Step 1: LoadValidationsRulesFile() Starts", GlobalConstants.LOGGERLEVEL1);
                        
                        if (LoadValidationsRulesFile(ValidationRuleFilePath))
                        {
                            isValid = true;

                            try
                            {
                                objlogger.LogInfo("Step 2: CheckIfAttachmentExists", GlobalConstants.LOGGERLEVEL1);
                                //check if attachments are presnet in transferredfilesfolder - if not stop import

                                if (CheckIfAttachmentExists())
                                {

                                    isValid = true;
                                    objlogger.LogInfo("Step 3: ProcessAllRules() Starts ", GlobalConstants.LOGGERLEVEL1);

                                    if (ProcessAllRules())
                                    {
                                        objlogger.LogInfo("Step 4: Processed Starts", GlobalConstants.LOGGERLEVEL1);
                                        isValid = true;

                                        //add code for isolatedstorage
                                        IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                                        oIMFmgr.WriteToIsolatedStorage(OrcParms, PersistenceDataStores.ROISSUEIMF);

                                        //REUBK-4475 Check sizes of attachments present in IMF and give warning message
                                        CheckAttachmentSizes();
                                    }
                                    else
                                    {
                                        if (!bCustomErrorRegistered)
                                        {
                                            ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                                                + "Error in processing rules", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                        }
                                        isValid = false;
                                    }
                                }
                                else
                                {
                                    isValid = false;
                                    ROErrorLogger.RegisterUserError("Import failed with validation engine error - "
                                    + "Attachments are missing in temporary download directory", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                }
                            }
                            catch (ProcessAllRulesException paex)
                            {
                                objlogger.LogException(paex, "ProcessAllRules() Exception");
                                ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                                        + paex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                isValid = false;
                            }
                            //}
                            //else
                            //{
                            //    //Utilities.objLogger.LogInfo("ValidateVRF() Exception");
                            //    //ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                            //    //            + "VRF could not be validated against xsd", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                            //    return false;

                            //}
                        }
                        else
                        {
                            objlogger.LogInfo("LoadValidationsRulesFile() IMRuleFileLoadingException", GlobalConstants.LOGGERLEVEL1);
                            ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                                        + "Loading of the VRF file failed", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                            return false;

                        }

                        //else
                        //{
                        //    //External ID is missing. Do not proceed further.
                        //    ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                        //                   + "Issue ExternalID Missing", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                        //    return false;
                        //}
                    }
                    catch (ExternalIDMissingException eidmex)
                    {
                        isValid = false;
                        objlogger.LogException(eidmex, "ValidateIMF: Issue External ID not present");
                        ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                                          + "ValidateIMF: Issue External ID not present", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                    }
                    catch (IMRuleFileLoadingException imex)
                    {
                        objlogger.LogException(imex, "ValidateIMF: IMF Loading Exception");
                        ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                                         + "Loading IMF Failed", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                        isValid = false;
                    }
                }
                //else
                //{
                //    //Validation for MSGACK
                //    if (ValidateMSGACK())
                //    {
                //        isValid = true;
                //        IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                //        oIMFmgr.WriteToIsolatedStorage(OrcParms, PersistenceDataStores.ROISSUEIMF);
                //    }
                //    else
                //    {
                //        if (!bCustomErrorRegistered)
                //        {
                //            ROErrorLogger.RegisterUserError("Import failed with validation engine error -"
                //                + "Error in processing rules", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                //        }
                //        isValid = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ValidateIMF: Other error -");
                ROErrorLogger.RegisterUserError("Validation engine failed with error -"
                                    + ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                isValid = false;
            }
            finally
            {
                // GlobalConstants.DeRegisterFromExecution(OrcParms[OrcParameters.ISSUEFILENAME]);
                if (l_oDataInterface != null) l_oDataInterface.Close();
            }
            //objlogger.LogInfo("ROValidationEngineManager::ValidateIMF :- Ends");
            return isValid;
        }


        /*public bool ValidateMSGACK()
        {
            bool isValid = false;
            string sQuery = "oslc_cm.query=dbid=%22$IMF.DBID¶%22&rcm.type=Issuereleasemap";

            try
            {

                IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                Query oROmgr = new Query(OrcParms, objlogger);
                oROmgr.QueryString = sQuery;
                XElement xContext = IssueIMF.Root.Element(IMFFileTags.RT_IRMAPS).Element(IMFFileTags.IRMAP);

                l_oDataInterface =
                 Factory.GetInterface(ROAvailableDataInterfaces.OSLC, OrcParms[OrcParameters.EXCHANGEFORMAT], null, OrcParms[OrcParameters.SYSTEM], OrcParms[OrcParameters.ATTACHMENTPATH], objlogger);

                IQueryResult l_oQueryResult = l_oDataInterface.Query(oROmgr.Prepare(xContext, oIMFmgr));
                XDocument xROdoc = l_oQueryResult.GetRaw() as XDocument;
                objlogger.LogInfo("xROdoc:" + xROdoc.ToString());

                //Second level query
                QueryParameters l_oParametersField = new QueryParameters();
                l_oParametersField.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryResult.GetRaw());
                IQueryResult l_oQueryResultField = l_oDataInterface.Query(l_oParametersField);

                string sROExtConv = string.Empty;
                if (l_oQueryResultField.FieldValues.ContainsKey("ExternalConversation"))
                {
                    sROExtConv = l_oQueryResultField.FieldValues["ExternalConversation"];
                    objlogger.LogInfo("sROExtConv:" + sROExtConv);
                }

                if (!string.IsNullOrEmpty(sROExtConv))
                {
                                        
                        string sTxnIDval = string.Empty;
                        string sTXPattern = @"\[TRANSACTION-ID=(?<TransactionID>.*)\]";

                        IEnumerable<XElement> IExtConv = xContext.Element(IMFFileTags.IR_EXTERNALCONVERSATION).Elements("P");
                        string TxnID = IExtConv.Where(p => Regex.IsMatch(p.Value, sTXPattern)).Single().Value;


                        if (Regex.IsMatch(TxnID, sTXPattern))
                        {
                            Match m = Regex.Match(TxnID, sTXPattern);
                            sTxnIDval = m.Groups["TransactionID"].Value;

                        }

                        objlogger.LogInfo("TransactionIDValue:" + sTxnIDval);

                        string pattern = @"###\s([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]:[0-6][0-9]#(ESTIMATED|SPECIFIED|INFO-UPDATE|DELIVERED)##(?'Email'(.*?)\@[^#]+)\###[\n\r]+\[TRANSACTION-ID=" + sTxnIDval + @"\]";
                        string ECpattern = @"###\s([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]:[0-6][0-9]#(ESTIMATED|SPECIFIED|INFO-UPDATE|DELIVERED)##(?'Email'(.*?)\@[^#]+)\###[\n\r]+\[TRANSACTION-ID=.*?\]";

                        objlogger.LogInfo(" pattern:" + pattern);

                        MatchCollection matches = Regex.Matches(sROExtConv, pattern);
                        if (matches.Count > 0)
                        {
                            objlogger.LogInfo("TransactionID found in IRM ExternalConversation");
                            isValid = true; 
                            string sMatch = matches[0].Value;
                            objlogger.LogInfo("sMatch:" + sMatch);

                            if (xContext.Element(IMFFileTags.IR_LIFECYCLESTATE) != null && xContext.Element(IMFFileTags.IR_LIFECYCLESTATE).Value.ToUpper() == "CONFLICTED")
                            {                               
                                string sErrorCode = IExtConv.ElementAt(IExtConv.Count() - 1).Value;

                                string sBody = "Your last export to Daimler for IRM:" + xContext.Element(IMFFileTags.DBID).Value + " failed with following error code:" + System.Environment.NewLine + sErrorCode;
                                
                                //Mail for error code
                                objlogger.LogInfo("Send mail for error code");
                                SendMailforMSGACK(sMatch, pattern,sBody);

                            }
                        }
                        else
                        {
                            //Add error message and stop import      
                            isValid = false;
                            string sMessage = "Error - No Matching Transaction-ID found.";
                            objlogger.LogInfo("Adding error message: " + sMessage);
                            ROErrorLogger.RegisterUserError(sMessage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                            bCustomErrorRegistered = true;

                            if (Regex.IsMatch(sROExtConv, ECpattern))
                            {
                                MatchCollection mcol = Regex.Matches(sROExtConv, ECpattern);
                                string sMatch = mcol[0].Value; //Get first export entry
                                objlogger.LogInfo("sMatch:" + sMatch);

                                string sBody = "Import of MSG-ACKNOWLEDGE failed because Transaction-ID '" + sTxnIDval + "' could not be determined in IRM.ExternalConversation for " + xContext.Element("DBID").Value ;

                                //Mail for import error
                                objlogger.LogInfo("Send mail for import error");
                                SendMailforMSGACK(sMatch, ECpattern, sBody);

                            }
                        }                   

                }
            }
            catch(Exception ex)
            {
                objlogger.LogException(ex, "ValidateMSGACK() Exception");
                if (!bCustomErrorRegistered)
                {
                    ROErrorLogger.RegisterUserError("Import failed with validation engine error -" + ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                }
            }

            return isValid;
        }

        private void SendMailforMSGACK(string sEntry, string sPattern, string sBody)
        {
            string sMailId = string.Empty;

            try
            {
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(OrcParms[OrcParameters.EXCHANGEFORMAT] + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(OrcParms[OrcParameters.EXCHANGEFORMAT]);

                if (l_oConfig == null)
                {
                    //exception handling
                    objlogger.LogInfo("SendMailForMSGACK: Error Interface config file not loaded / not found");
                }
                else
                {
                    if (Regex.IsMatch(sEntry, sPattern))
                    {
                        sMailId = Regex.Match(sEntry, sPattern).Groups["Email"].Value;
                        objlogger.LogInfo("sMailId:" + sMailId);

                        string sSubject = "MSG-ACK alert from " + OrcParms[OrcParameters.SYSTEM] + " - XPROT:" + OrcParms[OrcParameters.XCHANGEPROTOCOLID];

                        MailMessage oMail = new MailMessage(sMailId, sMailId, sSubject, sBody);
                        objlogger.LogInfo("Sending mail");
                        Utilities.SendMail(l_oConfig, oMail);
                    }
                    else
                    {
                        objlogger.LogInfo("No match for Email");
                    }
                }
            }
            catch(Exception ex)
            {
                objlogger.LogInfo("Error SendMailforMSGACK: "+ ex.Message);
            }
        }*/

        //REUBK-4475
        public void CheckAttachmentSizes()
        {
            objlogger.LogInfo("Checking attachment sizes", GlobalConstants.LOGGERLEVEL1);

            if (IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)!=null && IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ATTACHEMENTS) != null)
            {
                XElement xattachments = IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE).Elements(IMFFileTags.ISSUE)
                      .Elements(IMFFileTags.ATTACHEMENTS).Single();
                IEnumerable<XElement> attlist = xattachments.Elements(IMFFileTags.ATTACHMENT).Where(e => e.Element(IMFFileTags.ATTACHMENT_NAME).HasAttributes == false);

                //objlogger.LogInfo("Getting Attachment WarningSize from Config file starts, InterfaceName =" + OrcParms[OrcParameters.EXCHANGEFORMAT]);
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(OrcParms[OrcParameters.EXCHANGEFORMAT] + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(OrcParms[OrcParameters.EXCHANGEFORMAT]);
                //objlogger.LogInfo("Loaded ConfigFile for getting warning size");

                string attWarningSize = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS)
                                                    .Element(ConfigurationFileTags.ATTACHMENTS)
                                                    .Element(ConfigurationFileTags.WARNING_SIZE).Value;

                //objlogger.LogInfo("Completed Querying the Config for Attachments Warning Size in MB =" + attWarningSize);
                int sizeInBytes = Convert.ToInt32(attWarningSize) * 1024 * 1024; //MB to Bytes
                foreach (XElement att in attlist)
                {
                    string attSize = string.Empty;
                    if(!string.IsNullOrEmpty(att.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString().Trim()))
                    {
                        attSize = att.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value.ToString().Trim();
                        objlogger.LogInfo("Attachment size in bytes:" + attSize, GlobalConstants.LOGGERLEVEL1);
                        if (Convert.ToInt32(attSize) > sizeInBytes)
                        {
                            //Add warning message
                            string sMessage = "Warning - Attachment: " + att.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value + " size is greater than " + attWarningSize + "MB";
                            objlogger.LogInfo("Adding warning message: " + sMessage, GlobalConstants.LOGGERLEVEL2);
                            RegisterViolationMessage(sMessage, true);
                        }
                    }
                    
                    
                    

                }
            }
            else
            { objlogger.LogInfo("No attachments", GlobalConstants.LOGGERLEVEL1); }
        }

        public override bool ProcessAllRules()
        {
            bool isValid = false;
            
            try
            {
                //GetEvaluator current State of the Issue
                GetIssueState();

                //GetEvaluator current WF of the Issue
                GetIssueWorkFlow();//REUBK-1884


                //if (CheckIMFForRules(IssueExternalState))
                //{
                if (ProcessCommonRules(IssueWorkflow)) //REUBK-1884
                {
                    objlogger.LogInfo("ProcessCommonRules--returned true--after restart", GlobalConstants.LOGGERLEVEL1);
                    if (ProcessStateBasedRules(IssueExternalState, IssueWorkflow))
                    {
                        objlogger.LogInfo("ProcessStateBasedRules--succeded", GlobalConstants.LOGGERLEVEL1);
                        return true;
                    }
                    //REUBK-1232
                    else if (bReset)
                    {
                        objlogger.LogInfo("breset is true", GlobalConstants.LOGGERLEVEL1);
                        iResetCount++;
                        bCustomErrorRegistered = false;
                        bReset = false;
                        if (iResetCount == 1)
                        {
                            objlogger.LogInfo("reset occured once", GlobalConstants.LOGGERLEVEL1);
                            IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                            oIMFmgr.WriteToIsolatedStorage(OrcParms, PersistenceDataStores.ROISSUEIMFRESET);
                            objlogger.LogInfo("clear all messages-add reset message alone", GlobalConstants.LOGGERLEVEL1);  //recreate lifetoken with append=false                         
                            oIMFmgr.WriteToIsolatedStorage(OrcParms, PersistenceDataStores.LIFETOKEN);
                            //objlogger.LogInfo("add reset message");
                            ROErrorLogger.RegisterUserError(sResetMessage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], true, RulesFileTags.WARNING);
                            objlogger.LogInfo("calling process ProcessStateBasedRules from restart", GlobalConstants.LOGGERLEVEL1);
                            if (ProcessStateBasedRules(IssueExternalState, IssueWorkflow)) //REUBK-1884                          
                            {
                                objlogger.LogInfo("ProcessStateBasedRules--returned true--after restart", GlobalConstants.LOGGERLEVEL1);
                                return true;
                            }
                            else
                            {
                                objlogger.LogInfo("ProcessStateBasedRules--returned false--after restart", GlobalConstants.LOGGERLEVEL1);
                                return false;
                            }
                        }
                        else
                        {
                            if (iResetCount > 1)
                            {
                                objlogger.LogInfo("reset occured more than once", GlobalConstants.LOGGERLEVEL1);
                                //register error if reset encountered more than once
                                ROErrorLogger.RegisterUserError("Reset encountered more than once. Please contact administrator", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                bCustomErrorRegistered = true;
                                return false;
                            }
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("ProcessStateBasedRules failed", GlobalConstants.LOGGERLEVEL1);
                        return false;
                    }
                }
                objlogger.LogInfo("ProcessAllRules :- Ends", GlobalConstants.LOGGERLEVEL1);
                return false;
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ProcessAllRules() Exception");
                if (!bCustomErrorRegistered)
                {
                    ROErrorLogger.RegisterUserError("Import failed with validation engine error -" + ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                }
            }
            //objlogger.LogInfo("Processallules :- Ends");
            return isValid;

        }

        public override string GetIssueState()
        {
            string strIsssueState = "";
            //objlogger.LogInfo("GetIssueState :- Starts");
            try
            {
                //GetEvaluator the IssueState & IssueExternalState 
                //IssueState = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                //	.Element(IMFFileTags.ISSUE).Element(IMFFileTags.STATE).Value;
                //Utilities.objLogger.LogInfo("IssueState: " + IssueState);

                IssueExternalState = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO)
                    .Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMEXTERNALSTATE).Value;
                    
                    //IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.OEMEXTERNALSTATE).Value;
                objlogger.LogInfo("IssueExternalState: " + IssueExternalState, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetIssueState: Error in getting state values");
            }
            //objlogger.LogInfo("GetIssueState :- Ends");
            return strIsssueState;
        }



        //public override bool ProcessCommonRulesOld()
        //{
        //    bool isValid = false;
        //    objlogger.LogInfo("ProcessCommonRules - Starts");
        //    try
        //    {
        //        XElement xoCommonRule = ValidationRuleConfigurationXMLFile
        //            .Root.Element(RulesFileTags.INTERFACE)
        //            .Element(RulesFileTags.COMMON_RULES);

        //        if (ProcessRule(xoCommonRule))
        //        {
        //            isValid = true;
        //        }
        //        else
        //        {
        //            throw new ProcessCommonRulesException("ProcessCommonRules(): Return value is false from ProcessRule()");
        //        }

        //    }
        //    catch (ProcessCommonRulesException pceex)
        //    {
        //        objlogger.LogException(pceex, "ProcessCommonRules");
        //        isValid = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        objlogger.LogException(ex, "ProcessCommonRules");
        //        isValid = false;
        //    }

        //    objlogger.LogInfo("ProcessCommonRules - Ends");
        //    return isValid;
        //}

        //public override bool ProcessStateBasedRulesOld(string strStatename)
        //{
        //    bool isValid = false;
        //    XElement xoCommonRule = null;

        //    try
        //    {
        //        IEnumerable<XElement> l_oElements =
        //             from el in ValidationRuleConfigurationXMLFile.Root
        //                 .Element(RulesFileTags.INTERFACE).Elements(RulesFileTags.EXTERNAL_STATE_BASED_RULE)
        //             where
        //                 (string)el.Attribute(RulesFileTags.ATTR_NAME) == strStatename
        //             select el;

        //        xoCommonRule = l_oElements.First<XElement>();
        //    }
        //    catch (Exception e)
        //    {
        //        objlogger.LogException(e);
        //        ROErrorLogger.RegisterUserError("Validation failed as State base rules for " + strStatename + " could not be loaded, Please contact your administrator", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
        //        bCustomErrorRegistered = true;
        //        return false;
        //    }

        //    if (ProcessRule(xoCommonRule))
        //    {
        //        isValid = true;
        //    }
        //    else
        //    {
        //        objlogger.LogInfo("ValidateIMF: Error processing statebased rules");
        //        if (!bCustomErrorRegistered)
        //        {
        //            ROErrorLogger.RegisterUserError("Validation failed as State base rules filed, Please contact your administrator", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
        //        }
        //    }

        //    return isValid;
        //}
        #region 1884

        public override string GetIssueWorkFlow()//REUBK 1884
        {
            //objlogger.LogInfo("GetIssueWorkFlow :- Starts");
            try
            {

                IssueWorkflow = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO)
                    .Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMWORKFLOW).Value;

                    //IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.OEMWORKFLOW).Value;
                objlogger.LogInfo("IssueWorkFlow: " + IssueWorkflow, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetIssueWorkFlow: Error in getting WorkFlow value");
            }
            //objlogger.LogInfo("GetIssueWorkFlow :- Ends");
            return IssueWorkflow;
        }
        public override bool ProcessCommonRules(string strIssueWF)
        {
            bool isValid = false;
            objlogger.LogInfo("ProcessCommonRules - Starts", GlobalConstants.LOGGERLEVEL1);
            //objlogger.LogInfo("issuewf=" + strIssueWF);
            try
            {
                if (string.IsNullOrEmpty(strIssueWF))
                {
                    ROErrorLogger.RegisterUserError("Import is stopped because of blank ExternalExchangeWorkflow value", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                    bCustomErrorRegistered = true;
                    return false;
                }
                else
                {
                    //objlogger.LogInfo("ProcessCommonRules - check for WF IN vrf");

                    XElement xoCommonRule = null;

                    IEnumerable<XElement> l_oWFElementsCheck =
                       from el in ValidationRuleConfigurationXMLFile.Root
                            .Element(RulesFileTags.INTERFACE)
                           .Elements(RulesFileTags.WFLTYPES)
                       select el;


                    bool bisWFinVRF = false;
                    foreach (XElement xe in l_oWFElementsCheck)
                    {
                        objlogger.LogInfo("check for WF IN vrf" + xe.Name.ToString(), GlobalConstants.LOGGERLEVEL2);
                        objlogger.LogInfo("check for WF IN vrf" + xe.Attribute(RulesFileTags.ATTR_NAME).Value, GlobalConstants.LOGGERLEVEL2);
                        if (xe.Attribute(RulesFileTags.ATTR_NAME).Value.Contains(strIssueWF))
                        {
                            //objlogger.LogInfo("check for WF IN vrf set true");
                            bisWFinVRF = true;
                            break;
                        }
                    }


                    if (bisWFinVRF == false)
                    {

                        ROErrorLogger.RegisterUserError("Import is stopped because ExternalExchangeWorkflow cannot be found in validation rules: " + strIssueWF + ".", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                        bCustomErrorRegistered = true;
                        return false;

                    }

                    //REUBK 1884
                    IEnumerable<XElement> l_oWFElements =
                       from el in ValidationRuleConfigurationXMLFile.Root
                            .Element(RulesFileTags.INTERFACE)
                           .Elements(RulesFileTags.WFLTYPES)
                       where
                       el.Attribute(RulesFileTags.ATTR_NAME).Value.Contains(strIssueWF)
                       select el;
                    IEnumerable<XElement> l_oElements = l_oWFElements.Elements(RulesFileTags.VALIDATIONRULES).Elements(RulesFileTags.COMMON_RULES);

                    xoCommonRule = l_oElements.First<XElement>();

                    if (ProcessRule(xoCommonRule))
                    {
                        isValid = true;
                    }
                    else
                    {
                        throw new ProcessCommonRulesException("ProcessCommonRules(): Return value is false from ProcessRule()");
                    }
                }


            }
            catch (ProcessCommonRulesException pceex)
            {
                objlogger.LogException(pceex, "ProcessCommonRules");
                isValid = false;
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ProcessCommonRules");
                isValid = false;
            }

            objlogger.LogInfo("ProcessCommonRules - Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public override bool ProcessStateBasedRules(string strStatename, string strIssueWF)
        {
            bool isValid = false;
            XElement xoCommonRule = null;
            XElement xoWFRule = null;
            try
            {

                //REUBK 1884
                IEnumerable<XElement> l_oWFElements =
                 from el in ValidationRuleConfigurationXMLFile.Root
                 .Element(RulesFileTags.INTERFACE)
                        .Elements(RulesFileTags.WFLTYPES)
                 where
                 el.Attribute(RulesFileTags.ATTR_NAME).Value.Contains(strIssueWF)
                 select el;


                xoWFRule = l_oWFElements.Elements(RulesFileTags.VALIDATIONRULES).First<XElement>();

                IEnumerable<XElement> l_oElements =
              from el in xoWFRule.Elements(RulesFileTags.EXTERNAL_STATE_BASED_RULE)
              where
                  (string)el.Attribute(RulesFileTags.ATTR_NAME) == strStatename
              select el;
                xoCommonRule = l_oElements.First<XElement>();
            }
            catch (Exception e)
            {
                objlogger.LogException(e);
                ROErrorLogger.RegisterUserError("Validation failed as State base rules for " + strStatename + " could not be loaded, Please contact your administrator", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                bCustomErrorRegistered = true;
                return false;
            }

            if (ProcessRule(xoCommonRule))
            {
                isValid = true;
            }
            else
            {
                objlogger.LogInfo("ValidateIMF: Error processing statebased rules", GlobalConstants.LOGGERLEVEL1);
                if (!bCustomErrorRegistered)
                {
                    ROErrorLogger.RegisterUserError("Validation failed as State base rules filed, Please contact your administrator", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                }
            }

            return isValid;
        }

        #endregion
        public bool CheckForPilot(XElement Xcontext)
        {
            objlogger.LogInfo("Inside CheckForPilot", GlobalConstants.LOGGERLEVEL1);
            bool bReturn = false;
            try
            {
                if (IssueExternalState == GlobalConstants.ASAMFileTags.STATECLOSEDNOTOK ||
                    IssueExternalState == GlobalConstants.ASAMFileTags.STATECLOSEDOK ||
                    IssueExternalState == GlobalConstants.ASAMFileTags.STATECANCELLED)
                {
                    objlogger.LogInfo("state = cok|cnok|canc", GlobalConstants.LOGGERLEVEL2);
                    objlogger.LogInfo("node name=" + (Xcontext.Name.ToString()), GlobalConstants.LOGGERLEVEL2);
                    if (Xcontext.Name.ToString() == IMFFileTags.IRMAP)
                    {
                        if ((string.IsNullOrEmpty(Xcontext.Element(IMFFileTags.IR_ISPILOT).Value)) || ((Xcontext.Element(IMFFileTags.IR_ISPILOT).Value == GlobalConstants.NO)))
                        {
                            objlogger.LogInfo("CheckForPilot- pilot=no", GlobalConstants.LOGGERLEVEL2);
                            bReturn = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "CheckForPilot()");

            }
            objlogger.LogInfo("CheckForPilot- return value=" + bReturn.ToString(), GlobalConstants.LOGGERLEVEL1);
            return bReturn;

        }
        public bool ProcessRule(XElement xRulesNode)
        {
            bool isValid = true;

            objlogger.LogInfo("ProcessRule() - Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                //Process rules one after another
                foreach (XElement xRule in xRulesNode.Elements())
                {

                    GlobalConstants.RORecordTypes roRecordType
                        = (GlobalConstants.RORecordTypes)Enum.Parse(typeof(GlobalConstants.RORecordTypes),
                            xRule.Attribute(RulesFileTags.ATTR_NAME).Value.ToString(), true);

                    //objlogger.LogInfo("Getting XPATH from rule");
                    string sIMFXPath = xRule.Element(RulesFileTags.XPATH).Value.ToString();

                    //To Process IMFRules
                    XElement xoIMFRules = xRule.Element(RulesFileTags.IMF_RULES);

                    //To Process RORules
                    XElement xoRORules = xRule.Element(RulesFileTags.RO_RULES);

                    //objlogger.LogInfo("calling ProcessIMFRule()");
                    if (ProcessIMFRules(xoIMFRules, roRecordType, sIMFXPath))
                    {
                        //objlogger.LogInfo("calling ProcessRORules()");

                        if (!ProcessRORules(xoRORules, roRecordType, sIMFXPath))
                        {
                            objlogger.LogInfo("ProcessRule :- Ends", GlobalConstants.LOGGERLEVEL1);
                            return false;
                        }

                    }
                    else
                    {
                        throw new ProcessIMFRuleException("ValidationWarning of IMF Rule failed");
                    }


                }
            }
            catch (ArgumentException ex)
            {
                isValid = false;
                objlogger.LogException(ex, "ProcessRule() - Invalid recordtype from IMF RULE ValidationWarning file");
            }

            catch (Exception ex)
            {

                isValid = false;
                objlogger.LogException(ex, "ProcessRule() - Error");

            }
            //objlogger.LogInfo("ProcessRule() - ends");
            return isValid;
        }

        public override bool ProcessIMFRules(XElement xRulesNode, GlobalConstants.RORecordTypes rorecType, string sXPATH)
        {
            bool isValid = false;
            objlogger.LogInfo("ProcessIMFRules() - Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                if (!(string.IsNullOrWhiteSpace(sXPATH)))
                {
                    //Process IMF_RULE -> IDRULE, RORULES
                    IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                    Query oROmgr = null;

                    //set count based on xpath
                    int iResult = IssueIMF.Root.XPathSelectElements(sXPATH, nsIMFMgr).Count();


                    IQueryResult l_oQueryResult = new OSLC_QueryResult();
                    l_oQueryResult.RecordCount = iResult;

                    XElement xIMFIDRule = xRulesNode.Element(RulesFileTags.IDRULE);
                    //objlogger.LogInfo("calling ProcessIMFIDRule");

                    //ProcessIMFIDRules
                    if (ProcessIMFIDRule(xIMFIDRule, rorecType, l_oQueryResult, null, sXPATH, oIMFmgr, oROmgr))
                    {
                        //objlogger.LogInfo("ProcessIMFIDRule() - succeded");
                        isValid = true;
                    }
                    else
                    {
                        objlogger.LogInfo("IMFID rule failed\n" + xIMFIDRule.ToString(), GlobalConstants.LOGGERLEVEL1);
                        return false;
                    }

                    objlogger.LogInfo("XPath value:" + sXPATH, GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> xElems = IssueIMF.Root.XPathSelectElements(sXPATH, nsIMFMgr);

                    if (xElems.Elements().Count() != 0)
                    {
                        foreach (XElement xContext in xElems)
                        {
                            //REUBK-3603
                            bool bValidateRecord = true;
                            try
                            {
                                if (xContext.Attribute(RulesFileTags.CAN_VALIDATE).Value == "0")
                                {
                                    bValidateRecord = false;
                                }
                            }
                            catch { }

                            if (bValidateRecord)
                            {
                                //objlogger.LogInfo("calling CheckForPilot");

                                //ProcessIMFFieldRules
                                XElement xIMFFieldRule = xRulesNode.Element(RulesFileTags.FIELDRULES);
                                //objlogger.LogInfo("calling ProcessIMFFieldRules");
                                if (ProcessIMFFieldRules(xIMFFieldRule, rorecType, l_oQueryResult, xContext, sXPATH, oIMFmgr, oROmgr))
                                {
                                    objlogger.LogInfo("ProcessIMFFieldRules() - succeded", GlobalConstants.LOGGERLEVEL1);
                                    isValid = true;
                                }
                                else
                                {
                                    objlogger.LogInfo("IMF Fieldrule failed\n" + xIMFFieldRule.ToString(), GlobalConstants.LOGGERLEVEL1);
                                    return false;
                                }
                            }

                        }
                    }
                    else
                    {
                        objlogger.LogInfo(rorecType.ToString() + " node is not present in IMF, IMF Field Rules not excecuted", GlobalConstants.LOGGERLEVEL1);
                        isValid = true;
                    }
                }
                else
                {
                    throw new IMFXPATHMissingException("XPATH missing for recordtype -" + rorecType.ToString());
                }
            }
            catch (IMFRulesFileNotFoundFileException ex)
            {
                objlogger.LogException(ex, "ProcessIMFRule(): Error occured");
                isValid = false;
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ProcessIMFRule(): Error occured");
                isValid = false;
            }
            return isValid;
        }


        public override bool ProcessIMFIDRule(XElement xIMFIDRule,
            GlobalConstants.RORecordTypes roRecordType, IQueryResult l_oQueryResult,
            XElement xContext, string sXPath, IMFManager oIMFmgr, Query oROmgr)
        {
            bool isValid = false;
            objlogger.LogInfo("ProcessIMFIDRules: Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                //objlogger.LogInfo("calling EvaluateIDRule");
                objlogger.LogInfo("roRecordType" + roRecordType.ToString(), GlobalConstants.LOGGERLEVEL1);
                if (EvaluateIDRule(xIMFIDRule, l_oQueryResult, xContext, oIMFmgr, null, oROmgr))
                {
                    //objlogger.LogInfo("EvaluateIMFIDRule--succeeded");
                    isValid = true;
                }
                else
                {
                    //objlogger.LogInfo("EvaluateIMFIDRule--failed");
                    return false;
                }

            }
            catch (Exception ex)
            {
                objlogger.LogInfo("ProcessIMFIDRules: error in ID rule " + ex.StackTrace, GlobalConstants.LOGGERLEVEL1);
                isValid = false;
            }
            objlogger.LogInfo("ProcessIMFIDRules: Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }



        public override bool ProcessIMFFieldRules(XElement xIMFFieldRules,
            GlobalConstants.RORecordTypes roRecordType, IQueryResult oQueryResults,
            XElement xNode, string sXPath, IMFManager oIMFmgr, Query oROmgr)
        {
            if (xIMFFieldRules == null) return true; // No rules to verify

            bool isValid = false;
            objlogger.LogInfo("ProcessIMFFieldRules: Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                //cal EvaluateFieldRule
                //objlogger.LogInfo("calling EvaluateFieldRule");
                if (EvaluateFieldRule(xIMFFieldRules, oQueryResults, xNode, oIMFmgr, null, oROmgr))
                {
                    //objlogger.LogInfo("IMFFieldRule succeeded");
                    isValid = true;
                }
                else
                {
                    //objlogger.LogInfo("IMFFieldRule failed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("ProcessIMFFieldRules(): Check if FieldName in Rule file exist in corresponding RequestOne recordtype", GlobalConstants.LOGGERLEVEL1);
                objlogger.LogException(ex, "ProcessROFieldRules()");
            }
            objlogger.LogInfo("ProcessIMFFieldRules() - Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public void RegisterValidationError(XElement xElement)
        {
            try
            {
                objlogger.LogInfo("in RegisterValidationError", GlobalConstants.LOGGERLEVEL1);
                string sErrorMssage = xElement.Element(RulesFileTags.ERR_MESSAGE).Value;
                ROErrorLogger.RegisterUserError("Validation  failed " + sErrorMssage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                objlogger.LogInfo("Logging validation error measage " + sErrorMssage, GlobalConstants.LOGGERLEVEL1);
                bCustomErrorRegistered = true;
            }
            catch { }
        }

        public void RegisterViolationMessage(string sMessage, bool IsOptCondition)
        {
            try
            {
                objlogger.LogInfo("in RegisterViolationMessage", GlobalConstants.LOGGERLEVEL1);
                string sErrorMssage = sMessage;

                if (IsOptCondition)
                {
                    ROErrorLogger.RegisterUserError(sErrorMssage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], true, RulesFileTags.WARNING);
                }
                else
                {
                    ROErrorLogger.RegisterUserError("Validation failed " + sErrorMssage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                }

                objlogger.LogInfo("Logging Violation error measage " + sErrorMssage, GlobalConstants.LOGGERLEVEL1);
                bCustomErrorRegistered = true;
            }
            catch
            {

            }
        }

        public bool ProcessRORules(XElement xRORules, GlobalConstants.RORecordTypes roRecType, string sXPATH)
        {
            bool isValid = true;
            objlogger.LogInfo("ProcessRORules: Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                if (!(string.IsNullOrWhiteSpace(sXPATH)))
                {
                    XElement xROIDRule = xRORules.Element(RulesFileTags.IDRULE);
                    //objlogger.LogInfo("roRecType=: " + roRecType);
                    objlogger.LogInfo("roRecType----=: " + roRecType.ToString().ToUpper(), GlobalConstants.LOGGERLEVEL1);
                    if (roRecType.ToString().ToUpper() == IMFFileTags.ISSUE)
                    {
                        //objlogger.LogInfo("inside issue rec type");

                        if (xRORules.Element(RulesFileTags.ROPREPROCESSING) != null)
                        {
                            sXSLTLNScriptPath = xRORules.Element(RulesFileTags.ROPREPROCESSING).Value;
                        }
                    }

                    //objlogger.LogInfo("calling ProcessROIDRules()");
                    if (ProcessROIDRules(xRORules, sXPATH, roRecType))
                    {
                        isValid = true;
                    }
                    else
                    {
                        objlogger.LogInfo("ROID rule failed", GlobalConstants.LOGGERLEVEL1);
                       // objlogger.LogInfo("ROID rule failed\n" + xROIDRule.ToString());
                        objlogger.LogInfo("ProcessRORules: Ends", GlobalConstants.LOGGERLEVEL1);
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
                objlogger.LogInfo("error while executing the query - " + ex.Message, GlobalConstants.LOGGERLEVEL1);
                isValid = false;
            }
            objlogger.LogInfo("ProcessRORules: Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public bool ProcessROIDRules(XElement xRORules, string sXPath, GlobalConstants.RORecordTypes roRecordType)
        {
            bool isValid = false, bLoopQueryResults = false;
            objlogger.LogInfo("ProcessROIDRules: Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                XElement xIDRule = xRORules.Element(RulesFileTags.IDRULE);
                XElement xROFieldRule = xRORules.Element(RulesFileTags.FIELDRULES);
                XElement xROElementRules = xRORules.Element(RulesFileTags.ELEMENTRULES);


                //GetEvaluator The Key
                IEnumerable<XElement> xoKeys = xIDRule.Elements(RulesFileTags.KEY);

                //GetEvaluator all nodes for the given XPath                 
                IEnumerable<XElement> xElems = IssueIMF.Root.XPathSelectElements(sXPath, nsIMFMgr);
                string sValueToCheck = string.Empty;
                string strQuery = string.Empty;

                //If Record node is not present in IMF then simply return true
                if (xElems.Elements().Count() != 0)
                {
                    IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
                    Query oROmgr = new Query(OrcParms, objlogger);

                    foreach (XElement xContext in xElems)
                    {                         
                        //REUBK-3603
                        bool bValidateRecord = true;
                        try
                        {
                            // if (string.IsNullOrEmpty(xContext.Element(GlobalConstants.DBID).Value) || xContext.Element(GlobalConstants.DBID).Value=="0")
                            if (xContext.Attribute(RulesFileTags.CAN_VALIDATE).Value == "0")
                            {
                                bValidateRecord = false;
                            }
                        }
                        catch { }

                        if (bValidateRecord)
                        {

                            int iResult = -1;

                            IQueryResult l_oQueryResult = null;
                            IQueryResult l_oQueryResultField = null;

                            try
                            {

                                //objlogger.LogInfo("Checking for LOOPQUERYRESULTS");
                                try
                                {
                                    if (xIDRule.Element(RulesFileTags.OPTCONDITION).Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPQUERYRESULTS).Value == "TRUE")
                                    {
                                        bLoopQueryResults = true;
                                        objlogger.LogInfo("bLoopQueryResults: " + bLoopQueryResults, GlobalConstants.LOGGERLEVEL1);
                                    }
                                }
                                catch
                                {
                                    //objlogger.LogInfo("no LOOPQUERYRESULTS");

                                }

                                l_oQueryResult = GetIDRuleResult(xIDRule, xContext, roRecordType, bLoopQueryResults);
                                iResult = l_oQueryResult.RecordCount;

                                objlogger.LogInfo("Queryresult : IDQuery" + iResult.ToString(), GlobalConstants.LOGGERLEVEL1);
                                if (iResult == 1 || (iResult > 1 && bLoopQueryResults == true))
                                {
                                    //objlogger.LogInfo("Queryresult : IDQuery -iResult == 1");
                                    //call updateback maps to update imf (with result of query in fieldrule)
                                    QueryParameters l_oParametersField = new QueryParameters();

                                    l_oParametersField.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryResult.GetRaw());
                                    l_oQueryResultField = l_oDataInterface.Query(l_oParametersField, bLoopQueryResults, xIDRule, OrcParms[OrcParameters.XCHANGEPROTOCOLID]);

                                    
                                    l_oQueryResultField.RecordCount = iResult;

                                    //objlogger.LogInfo("Checking l_oQueryResultField rec count : " + l_oQueryResultField.RecordCount);
                                    //objlogger.LogInfo("calling UpdateBackMaps in ROID rules");
                                    oIMFmgr.UpdateBackMaps(l_oQueryResultField, xContext, OrcParms[OrcParameters.EXCHANGEFORMAT]);


                                }
                                else if (iResult == 0)
                                {
                                    //objlogger.LogInfo("Queryresult : IDQuery -iResult == 0");

                                    if (xROElementRules != null)
                                    {
                                        //objlogger.LogInfo("--iResult-0--");
                                        foreach (XElement element in xROElementRules.Elements())
                                        {
                                            objlogger.LogInfo("Checking ElementRules for Attachment"+ element.Element("SELECTION").Element("OPERATOR").Value, GlobalConstants.LOGGERLEVEL1);
                                            if (!(element.Element("SELECTION").Element("OPERATOR").Value == "DISJUNCTION"))
                                            {
                                                AttachmentHandler oattachhandler = new AttachmentHandler();
                                                objlogger.LogInfo("--call-AttachmentHandler", GlobalConstants.LOGGERLEVEL1);

                                                IssueIMF = oattachhandler.GetTruncNameInIMF(IssueIMF, objlogger);
                                                //add size to imf as it is used in exec engine
                                                List<ROAttachment> lstIMFattach = new List<ROAttachment>();
                                                lstIMFattach = oattachhandler.GetInitialIMFAttachmentsList(IssueIMF, objlogger);
                                                foreach (ROAttachment att in lstIMFattach)
                                                {
                                                    try
                                                    {
                                                        XElement xattachment = IssueIMF.Descendants("ATTACHMENT")
                                                        .Where(e => e.Element("FULL_NAME").Value != string.Empty && e.Element("FULL_NAME").Value == att.FULLNAME).Single();

                                                        if (!string.IsNullOrEmpty(xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString().Trim()))
                                                        {
                                                            string strSize = new FileInfo(OrcParms[OrcParameters.ATTACHMENTPATH] + "\\" + xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value).Length.ToString();
                                                            objlogger.LogInfo("IMF - strSize" + strSize, GlobalConstants.LOGGERLEVEL1);
                                                            XElement xsize = new XElement(IMFFileTags.ATTACHMENT_FILESIZE, strSize);
                                                            xattachment.Add(xsize);
                                                        }
                                                    }

                                                    catch (Exception ex)
                                                    {

                                                    }
                                                    
                                                    
                                                    
                                                }
                                                objlogger.LogInfo("IMF - att size element added", GlobalConstants.LOGGERLEVEL1);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        objlogger.LogInfo("xROElementRules=null", GlobalConstants.LOGGERLEVEL1);
                                    }
                                }
                            }
                            catch (System.Net.WebException ex)
                            {
                                objlogger.LogException(ex, "ProcessROIDRules() Exception");
                                ROErrorLogger.RegisterUserError("OSLC error :" + ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                bCustomErrorRegistered = true;
                                objlogger.LogInfo("ProcessROIDRules: error in ROID rule " + ex.StackTrace, GlobalConstants.LOGGERLEVEL1);
                                return false;
                            }
                            catch (Exception e)
                            {
                                objlogger.LogException(e, "ProcessROIDRules() Exception");
                                string message = e.Message;
                                message = Utilities.FilterInvalidChar(message);
                                ROErrorLogger.RegisterUserError("OSLC error :" + message.Trim(), OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                bCustomErrorRegistered = true;
                                objlogger.LogInfo("ProcessROIDRules: error in ROID rule " + e.StackTrace, GlobalConstants.LOGGERLEVEL1);
                                return false;
                            }

                            //Evaluate RO ID Rules 
                            objlogger.LogInfo("calling EvaluateROIDRuleCondition", GlobalConstants.LOGGERLEVEL1);
                            //objlogger.LogInfo("calling EvaluateROIDRuleCondition" + xContext.ToString());


                            if (EvaluateIDRule(xIDRule, l_oQueryResult, xContext, oIMFmgr, roRecordType.ToString(), oROmgr))
                            {

                                objlogger.LogInfo("EvaluateROIDRuleCondition--succeeded", GlobalConstants.LOGGERLEVEL1);
                                isValid = true;
                                ///Story 457868---Check Annotations with Empty SI----Rakesh/////////
                                CheckEmptySIAnnotation(oIMFmgr.IssueIMF, xROElementRules);
                                //////Check Annotations with Empty SI/////////
                                if (iResult == 1 || (iResult > 1 && bLoopQueryResults == true)) //REUBK-3603
                                {
                                    if (xROElementRules != null)
                                    {
                                        
                                        try
                                        {
                                            ///Story 457868---Check Duplicate External Conversation---Rakesh//////
                                            try
                                            {
                                                CheckDuplicateExternalConversation(l_oQueryResultField, oIMFmgr, xROElementRules);
                                            }
                                            catch (Exception ex){
                                                objlogger.LogInfo("Exception in CheckDuplicateExternalConversation: "+ex.Message, GlobalConstants.LOGGERLEVEL1);
                                            }
                                            ///Check Duplicate External Conversation//////
                                            //REUBK-2137 - Add code to fetch ro-attachments
                                            //check for imf attachments if any
                                            bool bAttachExists = CheckIfIMFAttachmentExists();

                                            List<ROAttachment> lstIMFattach = new List<ROAttachment>();
                                            List<ROAttachment> lstResults = new List<ROAttachment>();
                                            List<ROAttachment> lstROExclusive = new List<ROAttachment>();
                                            List<ROAttachment> lstROIMFIntersection = new List<ROAttachment>();

                                            if (bAttachExists)
                                            {
                                                objlogger.LogInfo("inside --bAttachExists", GlobalConstants.LOGGERLEVEL1);
                                                //exec attachments query
                                                XDocument xroissueatt = new XDocument();
                                                XDocument ROIMF = null;
                                                string sexternalxvalue = string.Empty;
                                                string sROEEWValue = string.Empty;
                                                bool isAttSizeAdded = false;

                                                //string ROattquery = "oslc_cm.query=id=%2522$IMF.ID¶%2522&rcm.type=Issue&oslc_cm.properties=id,Attachments{filesize,filename,description}";
                                                string ROattquery = "oslc_cm.query=id=%22$IMF.ID¶%22&rcm.type=Issue&oslc_cm.properties=id,Attachments{filesize,filename,description}";
                                                oROmgr.QueryString = ROattquery;
                                                

                                                xroissueatt = l_oDataInterface.QueryAttachments(oROmgr.Prepare(xContext, oIMFmgr));
                                                //objlogger.LogInfo("xroissueatt=" + xroissueatt.ToString());
                                                //fetch ext attachments from ro
                                                string sROExtAttach = "$RO.EXTERNALEXCHANGEDATTACH¶";
                                                string sROEEW = "$RO.EXTERNALEXCHANGEWORKFLOW¶";
                                                Condition oCondition = new Condition(null, l_oQueryResultField, xContext, null, null, null, OrcParms, false, roRecordType.ToString(), null, objlogger);
                                                sexternalxvalue = oCondition.DecodeOperandForString(sROExtAttach);
                                                sROEEWValue = oCondition.DecodeOperandForString(sROEEW);

                                                //objlogger.LogInfo("EXTERNALEXCHANGEDATTACH=" + sexternalxvalue);
                                                //objlogger.LogInfo("sROEEWValue=" + sROEEWValue);

                                                AttachmentHandler oattachhandler = new AttachmentHandler();
                                                if ((!(string.IsNullOrEmpty(sexternalxvalue))) && (!(string.IsNullOrEmpty(sROEEWValue))))
                                                {
                                                    if (xroissueatt != null)
                                                    {

                                                        objlogger.LogInfo("--call-AttachmentHandler", GlobalConstants.LOGGERLEVEL1);
                                                        isAttSizeAdded = true;
                                                        sXSLTROIMFScriptPath = GetXSLTPathFromConfigFile(OrcParms[OrcParameters.EXCHANGEFORMAT], objlogger);
                                                        ROIMF = oattachhandler.GetROIMFAttachments(IssueIMF, xroissueatt, sexternalxvalue, sXSLTROIMFScriptPath, sXSLTLNScriptPath, objlogger);
                                                        objlogger.LogInfo("ROIMF=" + ROIMF.ToString(), GlobalConstants.LOGGERLEVEL1);
                                                        lstIMFattach = oattachhandler.GetInitialIMFAttachmentsList(IssueIMF, objlogger);

                                                        XElement ROAttachments = ROIMF.Root.Elements("RT_ISSUES").Elements("ISSUE")
                                                         .Elements("ATTACHMENTS").Single();

                                                        foreach (ROAttachment att in lstIMFattach)
                                                        {
                                                            try
                                                            {
                                                                XElement xattachment = IssueIMF.Descendants("ATTACHMENT")
                                                                                                .Where(e => e.Element("FULL_NAME").Value != string.Empty
                                                                                                 && e.Element("FULL_NAME").Value == att.FULLNAME
                                                                                                                            ).Single();
                                                                if (!string.IsNullOrEmpty(xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString().Trim()))
                                                                {
                                                                    string strSize = new FileInfo(OrcParms[OrcParameters.ATTACHMENTPATH] + "\\" + xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value).Length.ToString();
                                                                    objlogger.LogInfo("IMF - strSize" + strSize, GlobalConstants.LOGGERLEVEL1);
                                                                    XElement xsize = new XElement(IMFFileTags.ATTACHMENT_FILESIZE, strSize);
                                                                    xattachment.Add(xsize);
                                                                }
                                                            }
                                                            catch(Exception Ex)
                                                            {

                                                            }
                                                            
                                                        }
                                                        objlogger.LogInfo("IMF - att size element added", GlobalConstants.LOGGERLEVEL1);
                                                        //TO be checked: REUBK-2136
                                                        oattachhandler.LoadSkippedAttachments(IssueIMF, ROIMF, objlogger);

                                                        //check for Compliment/Intersection:
                                                        if (lstIMFattach.Count > 0)
                                                        {
                                                            foreach (XElement element in xROElementRules.Elements())
                                                            {
                                                                //objlogger.LogInfo("IMF - inside element rules");
                                                                string sXSLTIMFEXTScriptPath = element.Element("IMF-EXTENSION").Value;
                                                                objlogger.LogInfo("Inside element rules" + sXSLTIMFEXTScriptPath, GlobalConstants.LOGGERLEVEL2);
                                                                if (!string.IsNullOrEmpty(sXSLTIMFEXTScriptPath))
                                                                {
                                                                    if (element.Element("SELECTION").Element("OPERATOR").Value == "RO-COMPLEMENT")
                                                                    {
                                                                        //objlogger.LogInfo("inside element rules -- COMPLEMENT");
                                                                        lstROExclusive = oattachhandler.GetROCompliments(ROIMF, IssueIMF, sXSLTIMFEXTScriptPath, objlogger);
                                                                        objlogger.LogInfo("lstROExclusive count=" + lstROExclusive.Count.ToString(), GlobalConstants.LOGGERLEVEL2);
                                                                        lstResults = lstROExclusive;
                                                                    }
                                                                    else if (element.Element("SELECTION").Element("OPERATOR").Value == "INTERSECTION")
                                                                    {
                                                                        //objlogger.LogInfo("inside element rules -- INTERSECTION");
                                                                        lstROIMFIntersection = oattachhandler.GetROIMFIntersection(ROIMF, IssueIMF, sXSLTIMFEXTScriptPath, objlogger);
                                                                        objlogger.LogInfo("lstROIMFIntersection count=" + lstROIMFIntersection.Count.ToString(), GlobalConstants.LOGGERLEVEL2);
                                                                        lstResults = lstROIMFIntersection;
                                                                    }
                                                                }

                                                                    //Check for ELEMENTCHANGES
                                                                    if (element.Element("ELEMENTCHANGES") != null && element.Element("ELEMENTCHANGES").HasElements)
                                                                    {
                                                                        foreach (XElement xchange in element.Element("ELEMENTCHANGES").Elements())
                                                                        {
                                                                            if (xchange.Name == RulesFileTags.OPTCONDITION)
                                                                            {
                                                                                foreach (ROAttachment att in lstIMFattach)
                                                                                {
                                                                                    XElement xattachment = IssueIMF.Descendants("ATTACHMENT")
                                                                                                                   .Where(e => e.Element("FULL_NAME").Value != string.Empty
                                                                                                                    && e.Element("FULL_NAME").Value == att.FULLNAME).Single();
                                                                                    //objlogger.LogInfo("call ProcessROElementRules");
                                                                                    ProcessROElementRules(xchange, xattachment, ROAttachments, oIMFmgr);
                                                                                }
                                                                            }
                                                                            else if (xchange.Name == RulesFileTags.SETHANDLER)
                                                                            {
                                                                                
                                                                                //add results to IMF
                                                                                if (lstResults.Count > 0)
                                                                                {
                                                                                    string sOperator = xchange.Element(RulesFileTags.OPERATOR).Value;
                                                                                    objlogger.LogInfo("Calling SetHandler for " + sOperator, GlobalConstants.LOGGERLEVEL1);
                                                                                    IssueIMF = oattachhandler.AddROAttachmentsToIMF(IssueIMF, lstResults, sOperator, objlogger);
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                //no handling
                                                                            }
                                                                        }
                                                                    }


                                                                    objlogger.LogInfo("IssueIMF:" + IssueIMF.ToString(), GlobalConstants.LOGGERLEVEL1);
                                                            }

                                                            /*  foreach (ROAttachment att in lstIMFattach)
                                                              {
                                                                  XElement xattachment = IssueIMF.Descendants("ATTACHMENT")
                                                                                                 .Where(e => e.Element("FULL_NAME").Value != string.Empty
                                                                                                  && e.Element("FULL_NAME").Value == att.FULLNAME).Single();
                                                                  objlogger.LogInfo("call ProcessROElementRules");
                                                                  ProcessROElementRules(xROElementRules, xattachment, ROAttachments, oIMFmgr);
                                                              }*/


                                                        }
                                                    }                                                  

                                                    //add ROCompliments to IMF
                                                    //if (lstROExclusive.Count > 0)
                                                    //{
                                                    //    IssueIMF = oattachhandler.AddROAttachmentsToIMF(IssueIMF, lstROExclusive, objlogger);
                                                    //}

                                                    //if (lstROIMFIntersection.Count > 0)
                                                    //{
                                                    //    IssueIMF = oattachhandler.AddROAttachmentsToIMF(IssueIMF, lstROIMFIntersection, objlogger);
                                                    //}


                                                }

                                                if (isAttSizeAdded == false)
                                                {
                                                    //REUBK-4180 allow initial import of preexisting issue - add size to IMF ATT
                                                    //add size to imf as it is used in exec engine
                                                    List<ROAttachment> lstIMFattachments = new List<ROAttachment>();
                                                    lstIMFattachments = oattachhandler.GetInitialIMFAttachmentsList(IssueIMF, objlogger);
                                                    foreach (ROAttachment att in lstIMFattachments)
                                                    {
                                                        XElement xattachment = IssueIMF.Descendants("ATTACHMENT")
                                                                                        .Where(e => e.Element("FULL_NAME").Value != string.Empty
                                                                                         && e.Element("FULL_NAME").Value == att.FULLNAME
                                                                                                                    ).Single();
                                                        if(!string.IsNullOrEmpty(xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value.ToString().Trim()))
                                                        {
                                                            string strSize = new FileInfo(OrcParms[OrcParameters.ATTACHMENTPATH] + "\\" + xattachment.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value).Length.ToString();
                                                            objlogger.LogInfo("IMF - strSize" + strSize, GlobalConstants.LOGGERLEVEL1);
                                                            XElement xsize = new XElement(IMFFileTags.ATTACHMENT_FILESIZE, strSize);
                                                            xattachment.Add(xsize);
                                                        }
                                                        
                                                    }
                                                    objlogger.LogInfo("IMF - att size element added", GlobalConstants.LOGGERLEVEL1);
                                                }
                                                //objlogger.LogInfo("call GetTruncNameInIMF");
                                                IssueIMF = oattachhandler.GetTruncNameInIMF(IssueIMF, objlogger);
                                                IssueIMF = oattachhandler.ReNumberATTID(IssueIMF, objlogger);
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            objlogger.LogException("Exception in element rule evaluation" + ex.Message);
                                        }
                                    }
                                    if (xROFieldRule != null)
                                    {
                                        //Calling ProcessROFieldRules
                                       // objlogger.LogInfo("calling ProcessROFieldRules");
                                       // objlogger.LogInfo("2. Checking l_oQueryResultField rec count : " + l_oQueryResultField.RecordCount);
                                        isValid = ProcessROFieldRules(xROFieldRule, roRecordType,
                                               l_oQueryResultField, xContext, sXPath, oIMFmgr, oROmgr);
                                    }

                                    if (!isValid) return false;
                                }

                                else if (iResult > 1 && bLoopQueryResults == false) //REUBK-3603
                                {
                                    objlogger.LogInfo("ro data error mutiple rec found", GlobalConstants.LOGGERLEVEL1);
                                    ROErrorLogger.RegisterUserError("Multiple " + roRecordType.ToString()
                                                                   + " Records found " + " - validation error", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                                    bCustomErrorRegistered = true;
                                    return false;
                                }

                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    objlogger.LogInfo(roRecordType.ToString() + " node not present in IMF, RO Rules not executed", GlobalConstants.LOGGERLEVEL1);
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("ProcessROIDRules: error in ROID rule " + ex.StackTrace, GlobalConstants.LOGGERLEVEL1);

                isValid = false;
            }
            objlogger.LogInfo("ProcessROIDRules: Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        private void CheckDuplicateExternalConversation(IQueryResult ROResult, IMFManager IMFinter, XElement xROElementRules)
        {
            foreach (XElement element in xROElementRules.Elements())
            {
                if (element.Element("SELECTION").Element("OPERATOR").Value == "DISJUNCTION")
                {
                    string RO_text = ROResult.GetValue("EXTERNALCONVERSATION");
                    RO_text = ReConstructROText(RO_text);
                    objlogger.LogInfo("Inside Annotation Comparision", GlobalConstants.LOGGERLEVEL1);
                    XDocument XdocROfile = new XDocument();
                    XdocROfile = XDocument.Parse(RO_text);
                    XDocument XdocIMFfile = new XDocument(IMFinter.IssueIMF);

                    XDocument XdocIMFfile_inter_output = new XDocument();
                    var destination = new DomDestination();
                    Processor processor = new Processor();
                    // string strxslMarkup = @"D:\Tasks\BMW Annotations 26_02_20\FinalIntermediatoryNode.xsl";
                    string strxslMarkup = element.Element("IMFPOSTPROCESSING").Value;

                    XdmNode input = processor.NewDocumentBuilder().Build(XdocIMFfile.CreateReader());
                    XsltTransformer transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                    transformer.InitialContextNode = input;

                    transformer.Run(destination);
                    using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                    {
                        nodeReader.MoveToContent();
                        XdocIMFfile_inter_output = XDocument.Load(nodeReader);
                    }

                    XDocument XdocROfile_output = new XDocument();
                    destination = new DomDestination();
                    processor = new Processor();
                    // strxslMarkup = @"D:\Tasks\BMW Annotations 26_02_20\FinalIntermediatoryNode - Copy.xsl";
                    strxslMarkup = element.Element("ROPREPROCESSING").Value;
                    input = processor.NewDocumentBuilder().Build(XdocROfile.CreateReader());
                    transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                    transformer.InitialContextNode = input;

                    transformer.Run(destination);
                    using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                    {
                        nodeReader.MoveToContent();
                        XdocROfile_output = XDocument.Load(nodeReader);
                    }
                    objlogger.LogInfo("RO External Conversation Value: " + XdocROfile_output.ToString() + "", GlobalConstants.LOGGERLEVEL1);
                    objlogger.LogInfo("IMF External Conversation Value: " + XdocIMFfile_inter_output.ToString() + "", GlobalConstants.LOGGERLEVEL1);
                    List<string> commentIDList = CompareXMLFILES(XdocIMFfile, XdocIMFfile_inter_output, XdocROfile_output);
                    RemoveCommonNodes(IMFinter.IssueIMF, commentIDList);
                    //XdocIMFfile = CompareXMLFILES(XdocIMFfile, XdocIMFfile_inter_output, XdocROfile_output);
                    //XElement l_oMappableIssue
                    //       = IMFinter.IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE)
                    //       .Elements(IMFFileTags.ISSUE).Elements(IMFFileTags.IR_EXTERNALCONVERSATION).SingleOrDefault();
                    //XElement IMFModified = XdocIMFfile.Root.Elements(IMFFileTags.RT_ISSUE)
                    //       .Elements(IMFFileTags.ISSUE).Elements(IMFFileTags.IR_EXTERNALCONVERSATION).SingleOrDefault();
                    //// IMFinter.IssueIMF = XdocIMFfile;
                    ////l_oMappableIssue.Value = IMFModified.Value;
                    //// l_oMappableIssue= XElement.Parse(IMFModified.ToString());
                    //l_oMappableIssue.ReplaceWith(XElement.Parse(IMFModified.ToString()));
                    objlogger.LogInfo("IMF with modified External Conversation Value: " + IMFinter.IssueIMF.ToString() + "", GlobalConstants.LOGGERLEVEL1);
                    objlogger.LogInfo("Annotation Comparision Ends", GlobalConstants.LOGGERLEVEL1);
                }
            }
        }
        public string ReConstructROText(string RO_text)
        {
            string RO_text_modified = "<EXTERNALCONVERSATION>";
            string[] comments = RO_text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            //string[] comments = RO_text.Split(new string[] { Environment.NewLine + Environment.NewLine },
            //                   StringSplitOptions.RemoveEmptyEntries);
            foreach (var comment in comments)
            {
                if (comment != "" && comment != null && !string.IsNullOrWhiteSpace(comment))
                {
                    string tags = "<P>" + HttpUtility.HtmlEncode(comment.ToString()) + "</P>";
                    RO_text_modified = RO_text_modified + "\r\n" + tags;
                }
            }
            RO_text_modified = RO_text_modified + "\r\n" + "</EXTERNALCONVERSATION>";
            return RO_text_modified;
        }
        public bool CheckEmptySIAnnotation(XDocument IMF_, XElement xROElementRules)
        {
            objlogger.LogInfo("CheckEmptySIAnnotation Starts", GlobalConstants.LOGGERLEVEL1);
            //if (IMF_.Root.Elements(IMFFileTags.RT_ISSUE)
            //               .Elements(IMFFileTags.ISSUE).Elements(IMFFileTags.IR_EXTERNALEXCHANGEWORKFLOW).SingleOrDefault().Value == "BMW_PROSPR_REQ")
            string workflow = IMF_.XPathSelectElements("//RT_VALEX_CONTROLINFO/VALEX_CONTROLINFO/OEMWORKFLOW").Select(q => q.Value).SingleOrDefault().ToString();
            //   if (IMF_.Root.Elements(IMFFileTags.RT_VALEXCONTROLINFO)
            //.Elements(IMFFileTags.VALEXCONTROLINFO).Elements(IMFFileTags.OEMWORKFLOW).SingleOrDefault().Value == "BMW_PROSPR_REQ")
            if (workflow == "BMW_PROSPR_REQ" || workflow == "BMW_PROSPR_DEF" || workflow == "BMW_PROSPR-CC_REQ" || workflow == "BMW_PROSPR-CC_DEF")
                {
                var ptaglist = IMF_.XPathSelectElements("//RT_ISSUES/ISSUE/EXTERNALCONVERSATION/P").Select(q => q.Value).ToList();
                if (ptaglist != null)
                {
                    // List<string> emptySIlis = new List<string>(ptaglist.FindAll(isEmptySIPattern));
                    List<string> emptySIlis = new List<string>(ptaglist);
                    emptySIlis = emptySIlis.Where(q => q.Contains("[:invalid_text:›")).Select(q => q).ToList();
                    if (emptySIlis.Count() >= 1)
                    {
                        // string violationMessage = xROElementRules.Elements("ELEMENTRULE").Where(q => q.Elements("SELECTION").Elements("OPERATOR").SingleOrDefault().Value == "DISJUNCTION").Elements("MUSTCONDITION").Elements("VIOLATIONMESSAGE").SingleOrDefault().Value;
                        string violationMessage = "Error in ASAM-File (E-0042):Annotations with empty SI value or text or special characters is not allowed.";
                        objlogger.LogInfo(violationMessage, GlobalConstants.LOGGERLEVEL1);
                        RegisterViolationMessage(violationMessage, false);
                        throw new Exception(violationMessage);
                    }
                }
            }
            objlogger.LogInfo("CheckEmptySIAnnotation Ends", GlobalConstants.LOGGERLEVEL1);
            return true;
        }
        public List<string> CompareXMLFILES(XDocument IMF_, XDocument IMF_inter, XDocument RO_inter)
        {
            List<string> commentIDList = new List<string>();
            try
            {
                objlogger.LogInfo("inside CompareXMLFILES Starts:", GlobalConstants.LOGGERLEVEL1);
                bool isMatch = false;
                XDocument IMF_inter_out = new XDocument(IMF_inter);

                IEnumerable<XElement> ROComments_ = RO_inter.Descendants("CommentID"); //RO_inter.Descendants("Comment").Select(q => q).SelectMany(e => e.Elements());

                IEnumerable<XElement> IMFComments_ = IMF_inter.Descendants("CommentID");//.Select(q => q).SelectMany(e => e.Elements());
                foreach (var IMFComment in IMFComments_)
                {
                    isMatch = false;
                    foreach (var ROComment in ROComments_)
                    {
                        if (IMFComment.Value == ROComment.Value) { isMatch = true; break; }
                    }
                    if (!isMatch)
                    {
                        IMF_inter_out.Descendants("Comment").Where(q => q.Element("CommentID").Value == IMFComment.Value).Remove();
                    }
                }
                // UpdateIMFFile(IMF_inter_out);
               
                var commentIds = IMF_inter_out.Descendants("CommentID");
                foreach (var commentId in commentIds)
                {
                    commentIDList.Add(commentId.Value);
                    objlogger.LogInfo("Common ISSUE Annotation ID's :"+ commentId.Value, GlobalConstants.LOGGERLEVEL1);
                }
                // IMF_ = RemoveCommonNodes(IMF_, commentIDList);
                objlogger.LogInfo("inside CompareXMLFILES Ends:", GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {

            }
           // return IMF_;
            return commentIDList;

        }
        public void RemoveCommonNodes(XDocument IMF_, List<string> commonids)
        {
           // XDocument IMF_ = new XDocument(IMF);
            try
            {
                objlogger.LogInfo("inside RemoveCommonNodes Starts", GlobalConstants.LOGGERLEVEL1);
                var ptaglist = IMF_.XPathSelectElements("//RT_ISSUES/ISSUE/EXTERNALCONVERSATION/P").Select(q => q.Value).ToList();
                List<string> lis = new List<string>(ptaglist.FindAll(isPattern));
                for (int i = 0; i < lis.Count(); i++)
                {
                    //Match Id = Regex.Match(lis[i], @"\d+");
                    string pattern = "[0-9]+";
                    Match Id = Regex.Match(lis[i], pattern);
                    if (commonids.Contains(Id.Value))
                    {
                        IEnumerable<XElement> test_ = IMF_.XPathSelectElements("//RT_ISSUES/ISSUE/EXTERNALCONVERSATION").Descendants("P").Where(q => q.Value == lis[i + 1]).Select(q => q).SelectMany(e => e.ElementsBeforeSelf());
                        IMF_.XPathSelectElements("//RT_ISSUES/ISSUE/EXTERNALCONVERSATION").Descendants("P").Where(q => q.Value == lis[i]).Select(q => q).SelectMany(e => e.ElementsAfterSelf()).Intersect(test_).Remove();
                        IMF_.XPathSelectElements("//RT_ISSUES/ISSUE/EXTERNALCONVERSATION").Descendants("P").Where(q => q.Value == lis[i] || q.Value == lis[i + 1]).Remove();
                    }
                    i++;
                }
                objlogger.LogInfo("inside RemoveCommonNodes Ends", GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {

            }
           // return IMF_;
        }
        private bool isPattern(string ptagval)
        {
            // return Regex.IsMatch(ptagval, @"(\S+(\b\d{5}\b)+\S)+\S");
            // return Regex.IsMatch(ptagval, @"(\S+(\d{5})+\S)+\S");
            return Regex.IsMatch(ptagval, @"\[:[0-9]+:›|‹:[0-9]+:\]");
        }
        private bool isEmptySIPattern(string ptagval)
        {
            return Regex.IsMatch(ptagval, @"(\S+(\b\d{9}\b)+\S)+\S");
        }

        bool CheckIfIMFAttachmentExists()
        {
            //return true;
            bool doesAttExists = false;
            objlogger.LogInfo("CheckIfIMFAttachmentExists(): Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                objlogger.LogInfo("CheckIfIMFAttachmentExists():", GlobalConstants.LOGGERLEVEL1);

                IEnumerable<XElement> xAttachments = from xAttachment in IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).
                                                         Element(IMFFileTags.ATTACHEMENTS).Elements(IMFFileTags.ATTACHMENT)
                                                           .Where(x => x.Element(IMFFileTags.ATTACHMENT_NAME).Value != string.Empty)
                                                     select xAttachment;
                if (xAttachments.Count() > 0)
                {
                    doesAttExists = true;
                }
                else
                {
                    objlogger.LogInfo("No attachments", GlobalConstants.LOGGERLEVEL1);
                    doesAttExists = false;
                }

            }
            catch (Exception ex)
            {

                doesAttExists = false;
                objlogger.LogException(ex, "Error while checking or imf attachments");
            }

            objlogger.LogInfo("CheckIfIMFAttachmentExists(): Ends", GlobalConstants.LOGGERLEVEL1);
            return doesAttExists;
        }

        private IQueryResult GetIDRuleResult(XElement xIDRule, XElement xContext, GlobalConstants.RORecordTypes roRecordType, bool bLoopQueryResults)
        {
            //This processes all the IDQUERY tags present under <IDRULE> tag.
            int iTotalRecords = ProcessIDQueries(xIDRule, xContext, bLoopQueryResults);
            objlogger.LogInfo("iTotalRecords :" + iTotalRecords, GlobalConstants.LOGGERLEVEL1);

            if (iTotalRecords > 1)
            {
                objlogger.LogInfo(iTotalRecords.ToString() + " records found from ID query set", GlobalConstants.LOGGERLEVEL1);
                if (bLoopQueryResults)
                {
                    string sDBiD = ListQueryResults.Keys.SingleOrDefault();
                    QueryResult = ListQueryResults[sDBiD] as IQueryResult;
                    QueryResult.RecordCount = iTotalRecords;
                    QueryResult.ReturnedDbids = ListOfDbids;
                    return QueryResult;
                }
                else
                {
                    IQueryResult l_oQueryRes = new OSLC_QueryResult();
                    l_oQueryRes.RecordCount = iTotalRecords;
                    return l_oQueryRes;
                }
            }
            else
            {
                //ALM - 554729 - Implementing <ADDITIONAL-QUERIES> tag introduced in VRF
                //If the result of all the <IDQUERY> tags is 0, then only process <ADDITIONAL-QUERIES>
                if (iTotalRecords == 0)
                {
                    try
                    {
                        XElement additionalQueryElement = (XElement)Utilities.TryGetElementValue(xIDRule, RulesFileTags.ADDITIONALQUERIES);
                        if (additionalQueryElement != null)
                        {
                            string attributeVal = Utilities.TryGetAttributeValue(additionalQueryElement, RulesFileTags.CNTRES);
                            if (!string.IsNullOrEmpty(attributeVal) && attributeVal.Equals("0"))
                            {
                                if (additionalQueryElement.HasElements && additionalQueryElement.Elements(RulesFileTags.IDQUERY).Count() > 0)
                                {
                                    //Process the inner <IDQUERY> tags present inside the <ADDITIONAL-QUERIES> tag 
                                    iTotalRecords = ProcessIDQueries(additionalQueryElement, xContext, bLoopQueryResults);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        objlogger.LogException(ex, "Error while processing <ADDITIONAL-QUERIES> tag");
                    }
                }
                // 1 or 0 records
                if (ListQueryResults.Count == 1)
                {
                    string sDBiD = ListQueryResults.Keys.SingleOrDefault();
                    objlogger.LogInfo("One unique record found from ID query" + sDBiD, GlobalConstants.LOGGERLEVEL1);
                    return ListQueryResults[sDBiD] as IQueryResult;
                }
                else
                {
                    IQueryResult l_oQueryRes = new OSLC_QueryResult();
                    l_oQueryRes.RecordCount = iTotalRecords;
                    return l_oQueryRes;
                }
            }
        }

        /// <summary>
        /// Process all the IDQUERY tags present directly under
        /// IDRULE or under ADDITIONAL-QUERIES tag
        /// </summary>
        /// <param name="xQueryElement"></param>
        /// <param name="xContext"></param>
        /// <param name="bLoopQueryResults"></param>
        /// <returns></returns>
        private int ProcessIDQueries(XElement xQueryElement,XElement xContext,bool bLoopQueryResults)
        {
            ListQueryResults = new Dictionary<string, object>();
            int sSumOfRecords = 0, iTotalRecords = 0;
            ListOfDbids = new List<int>();
            QueryResult = null;

            Query oROmgr = new Query(OrcParms, objlogger);
            oROmgr.OrcParms = OrcParms;
            IMFManager oIMFmgr = new IMFManager(IssueIMF, objlogger);
            foreach (XElement xIDQuery in xQueryElement.Elements(RulesFileTags.IDQUERY))
            {
                string strQuery = xIDQuery.Value.ToString();
                objlogger.LogInfo("From Rulesfile: IDQuery:" + strQuery, GlobalConstants.LOGGERLEVEL1);
                oROmgr.QueryString = strQuery;
                //get query results
                objlogger.LogInfo("Calling Query class", GlobalConstants.LOGGERLEVEL1);
                IQueryResult l_oQueryResult = l_oDataInterface.Query(oROmgr.Prepare(xContext, oIMFmgr));

                if (l_oQueryResult.RecordCount > 0)
                {
                    objlogger.LogInfo("Record count > 0", GlobalConstants.LOGGERLEVEL1);
                    if (l_oQueryResult.RecordCount == 1 || (l_oQueryResult.RecordCount > 1 && bLoopQueryResults == true)) //REUBK-3603
                    {
                        objlogger.LogInfo("Record count =" + l_oQueryResult.RecordCount, GlobalConstants.LOGGERLEVEL1);
                        objlogger.LogInfo("bLoopQueryResults :" + bLoopQueryResults, GlobalConstants.LOGGERLEVEL1);
                        if (bLoopQueryResults)
                        {
                            sSumOfRecords += l_oQueryResult.RecordCount;
                        }
                        QueryParameters l_oParameters = new QueryParameters();
                        l_oParameters.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryResult.GetRaw());
                        objlogger.LogInfo("Second level query starts", GlobalConstants.LOGGERLEVEL1);
                        IQueryResult l_oQueryResultField = l_oDataInterface.Query(l_oParameters, bLoopQueryResults, xQueryElement);  //REUBK-3603

                        if (l_oQueryResultField.FieldValues.Keys.Count != 0) //REUBK-3603
                        {
                            if (l_oQueryResult.RecordCount == 1 || (l_oQueryResult.RecordCount > 1 && bLoopQueryResults == true)) //REUBK-3603
                            {

                                if (!ListQueryResults.ContainsKey(l_oQueryResultField.FieldValues[GlobalConstants.DBID.ToLower()]))
                                {
                                    if (l_oQueryResult.RecordCount == 1)
                                    {
                                        objlogger.LogInfo("Single unique record found for query " + strQuery, GlobalConstants.LOGGERLEVEL1);
                                    }
                                    else
                                    {
                                        objlogger.LogInfo(l_oQueryResult.RecordCount + " records found for query " + strQuery, GlobalConstants.LOGGERLEVEL1);
                                    }

                                    ListQueryResults.Add(l_oQueryResultField.FieldValues[GlobalConstants.DBID.ToLower()], l_oQueryResult);
                                }
                                else
                                {
                                    objlogger.LogInfo("Duplicate record found with DBID "
                                               + ListQueryResults.ContainsKey(l_oQueryResultField.FieldValues[GlobalConstants.DBID.ToLower()]).ToString(), GlobalConstants.LOGGERLEVEL1);
                                }
                            }
                            QueryResult = l_oQueryResultField; //REUBK-3603

                        }

                        //REUBK-3063 Add subIssue Dbid to list
                        if (bLoopQueryResults == true)
                        {
                            foreach (int iDbid in l_oQueryResultField.ReturnedDbids)
                            {
                                if (!ListOfDbids.Contains(iDbid))
                                {
                                    ListOfDbids.Add(iDbid);
                                    objlogger.LogInfo("Adding dbid to list: " + iDbid, GlobalConstants.LOGGERLEVEL1);
                                }
                            }
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("Multiple records found for ID query " + strQuery, GlobalConstants.LOGGERLEVEL1);
                        sSumOfRecords += l_oQueryResult.RecordCount;
                    }
                }
                else
                {
                    objlogger.LogInfo("No records found for ID query " + strQuery, GlobalConstants.LOGGERLEVEL1);
                }
            }

            if (bLoopQueryResults)
            {
                iTotalRecords = sSumOfRecords;
            }
            else
            {
                iTotalRecords = sSumOfRecords + ListQueryResults.Count;
            }
            return iTotalRecords;
        }
       // public void ProcessROElementRules(XElement xROElementRules, XElement IMFAttachment, XElement ROAttachment, IMFManager oIMFmgr)
        public void ProcessROElementRules(XElement element, XElement IMFAttachment, XElement ROAttachment, IMFManager oIMFmgr)
        {
            try
            {
                objlogger.LogInfo("inside ProcessROElementRules-----", GlobalConstants.LOGGERLEVEL1);


               /* foreach (XElement l_element in xROElementRules.Elements())
                {
                    objlogger.LogInfo("inside elements of ProcessROElementRules" + l_element.Elements().Count().ToString());


                 foreach (XElement element in xROElementRules.Elements("ELEMENTCHANGES").Elements())
                    foreach (XElement element in xConditionElems.Elements())
                    {
                        objlogger.LogInfo("inside elements of ELEMENTCHANGES" + element.Elements().Count().ToString()); */

                        if (element.Name == RulesFileTags.OPTCONDITION)
                        {
                            objlogger.LogInfo("Evaluate OPT CONDITION", GlobalConstants.LOGGERLEVEL1);

                            Condition l_oMust = new Condition(element,
                                                           null,
                                                           IMFAttachment,
                                                           ROAttachment,
                                                           oIMFmgr,
                                                           null, OrcParms, false, null, null, objlogger);
                            objlogger.LogInfo("call ElementRuleEvaluate", GlobalConstants.LOGGERLEVEL1);

                            ConditionResult l_oResult = l_oMust.ElementRuleEvaluate();

                        }
                  //}
               //}
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Exception in ProcessROElementRules" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
        }

        public bool ProcessROFieldRules(XElement xROFieldRules,
            GlobalConstants.RORecordTypes roRecordType, IQueryResult oQueryResults,
            XElement xNode, string sXPath, IMFManager oIMFmgr, Query oROmgr)
        {

            bool isValid = false;
            objlogger.LogInfo("ProcessROFieldRules() - Starts", GlobalConstants.LOGGERLEVEL1);
            string sValueFromOSLC = string.Empty;
            string sOrginalValueOSLC = string.Empty;


            if (oQueryResults == null) return false;

            try
            {

                //cal EvaluateROFieldRule

                //objlogger.LogInfo("calling EvaluateROFieldRule");
                if (EvaluateFieldRule(xROFieldRules, oQueryResults, xNode, oIMFmgr, roRecordType.ToString(), oROmgr))
                {
                    //objlogger.LogInfo("ROFieldRule succeeded");
                    isValid = true;
                }
                else
                {
                   // objlogger.LogInfo("ROFieldRule failed");

                    //RegisterValidationError(xFieldRules);
                    return false;
                }


            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ProcessROFieldRules() Exception");
                string message = ex.Message;

                message = Utilities.FilterInvalidChar(message);
                ROErrorLogger.RegisterUserError("OSLC error :" + message.Trim(), OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);//REUBK-1740
                bCustomErrorRegistered = true;
                objlogger.LogInfo("ProcessROFieldRules: Exception in field rule " + ex.StackTrace, GlobalConstants.LOGGERLEVEL1);
                return false;

            }
            objlogger.LogInfo("ProcessROFieldRules() - Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        bool CheckIfAttachmentExists()
        {
            //return true;
            bool doesAttExists = false;           

            try
            {
                
                string sAttachmentPath = OrcParms[OrcParameters.ATTACHMENTPATH];
                objlogger.LogInfo("sAttachmentPath: " + sAttachmentPath, GlobalConstants.LOGGERLEVEL2);
                if (string.IsNullOrWhiteSpace(sAttachmentPath) == false)
                {
                    if (IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)!=null && IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ATTACHEMENTS) != null)
                    {

                        IEnumerable<XElement> xAttachments = from xAttachment in IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ATTACHEMENTS).Elements(IMFFileTags.ATTACHMENT)
                                                             select xAttachment;
                        
                        //objlogger.LogInfo("count: " + xAttachments.Count().ToString());
                        if (xAttachments.Count() > 0)
                        {
                            foreach (XElement xElement in xAttachments)
                            {
                                if (xElement.Element(IMFFileTags.ATTACHMENT_NAME).HasAttributes == false)
                                {
                                    string sFileName = xElement.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value;
                                    
                                    //objlogger.LogInfo("sFullFileName: " + string.Concat(sAttachmentPath, @"\", sFileName));
                                    //objlogger.LogInfo("sFullFileName: " + string.Concat(sAttachmentPath, sFileName));

                                    if (String.IsNullOrWhiteSpace(sFileName) == false)
                                    {
                                        if (File.Exists(string.Concat(sAttachmentPath, sFileName)))
                                        //if (File.Exists(string.Concat(sAttachmentPath, @"\", sFileName)))
                                        {
                                            objlogger.LogInfo(sFileName + " - File exists", GlobalConstants.LOGGERLEVEL1);
                                            
                                            doesAttExists = true;
                                        }
                                        else
                                        {
                                            objlogger.LogInfo(sFileName + " - File Does not exists", GlobalConstants.LOGGERLEVEL1);
                                            doesAttExists = false;
                                            // Return false even if one att is not found
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        //since attachment node is present
                                        objlogger.LogInfo("File name is empty", GlobalConstants.LOGGERLEVEL1);
                                        doesAttExists = true;
                                    }

                                }
                            }
                        }
                        else
                        {
                            //objlogger.LogInfo("No attachments");
                            doesAttExists = true; // True since No attachments. 
                        }
                    }
                    else
                    {
                        //objlogger.LogInfo("No attachments in imf");
                        doesAttExists = true; // True since No attachments. 
                    }
                }
                else
                {
                    //objlogger.LogInfo("No attachments path specified");
                    doesAttExists = false;
                }
            }
            catch (Exception ex)
            {

                doesAttExists = false;
                //if (RODataInterface.InterfaceConfigFile == null)  //REUBK-1915
                //{
                //    Utilities.objLogger.LogInfo("RODataInterface.InterfaceConfigFile is null");
                //}
                objlogger.LogException(ex, "Error while checking or attachments");
            }
            //objlogger.LogInfo("doesAttExists: " + doesAttExists.ToString());
            //objlogger.LogInfo("CheckIfAttachmentExists(): Ends");
            return doesAttExists;
        }

        public bool EvaluateIDRule(XElement xRoIDRule, IQueryResult l_oQueryResult, XElement xNode, IMFManager oIMFmgr, string rorectype, Query oROmgr)
        {
            bool IsValid = true;

            objlogger.LogInfo("EvaluateIDRule() - Starts", GlobalConstants.LOGGERLEVEL1);

            //objlogger.LogInfo(xRoIDRule.ToString());


            foreach (XElement element in xRoIDRule.Elements())
            {
                if (element.Name == RulesFileTags.MUSTCONDITION)
                {
                    objlogger.LogInfo("Evaluate MUST CONDITION", GlobalConstants.LOGGERLEVEL1);
                    Condition l_oMust = new Condition(element,
                                                      l_oQueryResult,
                                                      xNode, null,
                                                      oIMFmgr,
                                                      oROmgr, OrcParms, true, rorectype, l_oDataInterface, objlogger);

                    //Subscribe to the reset event REUBK-1232)
                    l_oMust.Reset += new EventHandler(l_oMust_Reset);

                    ConditionResult l_oResult = l_oMust.Evaluate();
                    IsValid = l_oResult.Success;

                    if (!IsValid)
                    {
                        RegisterViolationMessage(l_oResult.ValidationMessage, false);
                        return IsValid;
                    }
                }

                else if (element.Name == RulesFileTags.OPTCONDITION)
                {
                    objlogger.LogInfo("Evaluate OPT CONDITION", GlobalConstants.LOGGERLEVEL1);
                    Condition l_oMust = new Condition(element,
                                                      l_oQueryResult,
                                                      xNode,
                                                      null,
                                                      oIMFmgr,
                                                      oROmgr, OrcParms, true, rorectype, l_oDataInterface, objlogger);

                    //Subscribe to the reset event REUBK-1232)
                    l_oMust.Reset += new EventHandler(l_oMust_Reset);

                    ConditionResult l_oResult = l_oMust.Evaluate();

                    if (!l_oResult.Success)
                    {
                        RegisterViolationMessage(l_oResult.ValidationMessage, true);
                    }

                    //This optcondition wont return even if result is false but reset must return REUBK-1232
                    if (bReset) return false;
                }
            }

            objlogger.LogInfo("EvaluateIDRule() - Ends", GlobalConstants.LOGGERLEVEL1);
            return IsValid;
        }

        public bool EvaluateFieldRule(XElement xRoFieldRule, IQueryResult l_oQueryResult, XElement xNode, IMFManager oIMFmgr, string rorectype, Query oROmgr)
        {
            bool IsValid = true;

            objlogger.LogInfo("EvaluateFieldRule() - Starts", GlobalConstants.LOGGERLEVEL1);
           // objlogger.LogInfo(xRoFieldRule.ToString());
            IQueryResult l_oQueryResultFieldRule = new OSLC_QueryResult(); //for exec query in field rule 

            foreach (XElement element in xRoFieldRule.Elements().Elements())
            {
                if (element.Name == RulesFileTags.MUSTCONDITION)
                {
                    objlogger.LogInfo("Evaluate MUST CONDITION", GlobalConstants.LOGGERLEVEL1);

                    if (element.Element("QUERYSTRING") != null || element.Element(RulesFileTags.STRUCTUREQUERY) != null)
                    {
                        string query = string.Empty;
                        if (element.Element("QUERYSTRING") != null)
                        {
                            //objlogger.LogInfo("FIELD RULE with QueryString");
                            query = element.Element("QUERYSTRING").Value;
                        }
                        else
                        {
                            //objlogger.LogInfo("FIELD RULE with StructureQuery");
                            query = element.Element(RulesFileTags.STRUCTUREQUERY).Value;
                        }
                        oROmgr.QueryString = query;
                        objlogger.LogInfo("EvaluateFieldRule-- exec query" + query, GlobalConstants.LOGGERLEVEL1);

                        //set intermediate query result  to l_oQueryResult (original value = ro id query result count)
                        l_oQueryResultFieldRule = l_oDataInterface.Query(oROmgr.Prepare(xNode, oIMFmgr));

                        objlogger.LogInfo("FIELD RULE with QueryString - result count =" + l_oQueryResultFieldRule.RecordCount, GlobalConstants.LOGGERLEVEL1);


                    }
                        
                        
                    Condition l_oMust = new Condition(element,
                                                      l_oQueryResult,
                                                      xNode, null,
                                                      oIMFmgr,
                                                      oROmgr, OrcParms, false, rorectype, null, objlogger, l_oQueryResultFieldRule);

                    //Subscribe to the reset event REUBK-1232)
                    l_oMust.Reset += new EventHandler(l_oMust_Reset);
                    ConditionResult l_oResult = l_oMust.Evaluate();

                    IsValid = l_oResult.Success;                    

                    if (!IsValid)
                    {
                        RegisterViolationMessage(l_oResult.ValidationMessage, false);
                        return IsValid;
                    }
                }

                else if (element.Name == RulesFileTags.OPTCONDITION)
                {
                    objlogger.LogInfo("Evaluate OPT CONDITION", GlobalConstants.LOGGERLEVEL1);

                    //added start
                    if (element.Element(RulesFileTags.STRUCTUREQUERY) != null)
                    {
                        //objlogger.LogInfo("FIELD RULE with StructureQuery");

                        string query = element.Element(RulesFileTags.STRUCTUREQUERY).Value;
                        oROmgr.QueryString = query;
                        objlogger.LogInfo("EvaluateFieldRule-- exec query" + query, GlobalConstants.LOGGERLEVEL1);

                        //set intermediate query result  to l_oQueryResult (original value = ro id query result count)
                        l_oQueryResultFieldRule = l_oDataInterface.Query(oROmgr.Prepare(xNode, oIMFmgr));

                        objlogger.LogInfo("FIELD RULE with StructureQuery - result count =" + l_oQueryResultFieldRule.RecordCount, GlobalConstants.LOGGERLEVEL1);


                    }
                    //added end

                    Condition l_oMust = new Condition(element,
                                                      l_oQueryResult,
                                                      xNode, null,
                                                      oIMFmgr,
                                                      oROmgr, OrcParms, false, rorectype, null, objlogger, l_oQueryResultFieldRule);

                    //Subscribe to the reset event REUBK-1232)
                    l_oMust.Reset += new EventHandler(l_oMust_Reset);
                    ConditionResult l_oResult = l_oMust.Evaluate();

                    if (!l_oResult.Success)
                    {
                        RegisterViolationMessage(l_oResult.ValidationMessage, true);
                    }
                    //This optcondition wont return even if result is false but reset must return REUBK-1232
                    if (bReset)
                    {
                        sResetMessage = l_oResult.ValidationMessage;
                        return false;
                    }
                }
            }
            objlogger.LogInfo("EvaluateFieldRule() - Ends", GlobalConstants.LOGGERLEVEL1);
            return IsValid;
        }

        //Event handler set reset to true REUBK-1232
        void l_oMust_Reset(object sender, EventArgs e)
        {
            bReset = true;
        }


        public bool CheckIMFForRules(string strState)
        {
            bool IsValid = false;
            try
            {
                objlogger.LogInfo("CheckIMFForRules() - Starts", GlobalConstants.LOGGERLEVEL1);
                IEnumerable<XElement> oElementsToProcess = IssueIMF.Root.Elements().Elements();

                foreach (XElement oElement in oElementsToProcess)
                {
                    IEnumerable<XElement> xMatchingElements = ValidationRuleConfigurationXMLFile.Root.Elements().Elements(RulesFileTags.EXTERNAL_STATE_BASED_RULE)
                         .Where(n => n.Attribute(RulesFileTags.ATTR_NAME).Value.ToUpper().Trim() == strState.ToUpper().Trim())
                         .Elements("RULES")
                         .Where(x => x.Attribute(RulesFileTags.ATTR_NAME).Value.ToUpper() == oElement.Name.ToString().ToUpper());



                    int iCount = xMatchingElements.Count();

                    if (iCount > 0)
                    {
                        objlogger.LogInfo(oElement.Name.ToString() + " Tag Exists in VRF", GlobalConstants.LOGGERLEVEL1);
                        IsValid = true;
                    }
                    else
                    {
                        string sErrorMssage = oElement.Name.ToString() + " - element does not exist in validation rules file. Please contact administrator";
                        ROErrorLogger.RegisterUserError("Validation  failed " + sErrorMssage, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                        objlogger.LogInfo("Logging validation error message " + sErrorMssage, GlobalConstants.LOGGERLEVEL1);
                        bCustomErrorRegistered = true;
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Exception in CheckIMFForRules()" + ex.Message.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
            objlogger.LogInfo("Return value CheckIMFForRules()" + IsValid.ToString(), GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("CheckIMFForRules() - Ends", GlobalConstants.LOGGERLEVEL1);
            return IsValid;
        }

        /// <summary>
        /// Validation Rules file is validated against XSD. Return true, if valid, else returns False
        /// </summary>
        /// <param name="VRFpath"></param>
        /// <param name="XSDpath"></param>
        /// <returns></returns>
        //public bool ValidateVRFAgainstXSD(string XSDpath) //REUBK-1206
        //{
        //    Utilities.objLogger.LogInfo("ValidateVRFAgainstXSD() - Starts");
        //    bool isValid = true;
        //    try
        //    {
        //        if (IsSchemaFileExists(XSDpath))
        //        {
        //            Utilities.objLogger.LogInfo("ValidateVRFAgainstXSD() - File exists");

        //            StringBuilder sErrors = new StringBuilder();

        //            XDocument xVRFDoc = ValidationRuleConfigurationXMLFile;
        //            XmlSchemaSet xSchema = new XmlSchemaSet();
        //            xSchema.Add(null, XmlReader.Create(XSDpath));

        //            xVRFDoc.Validate(xSchema, (o, e) =>
        //            {
        //                sErrors.Append(e.Message + System.Environment.NewLine);
        //                Utilities.objLogger.LogInfo("error in ValidateVRFAgainstXSD"+ sErrors);
        //                ROErrorLogger.RegisterUserError("VRF could not be validated against xsd " + sErrors, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
        //                isValid = false;
        //            });

        //        }
        //        else
        //        {
        //            Utilities.objLogger.LogInfo("ValidateVRFAgainstXSD() -- Schema file Notfound");
        //            isValid = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Utilities.objLogger.LogInfo("Exception in ValidateVRFAgainstXSD()" + ex.Message);
        //    }
        //    Utilities.objLogger.LogInfo("ValidateVRFAgainstXSD() Ends: isValid== " + isValid.ToString());
        //    return isValid;
        //} 

        public string GetXSLTPathFromConfigFile(string sExchangeFormat, Logger objlogger)
        {
            string sXSLTPath = string.Empty;
            objlogger.LogInfo("GetXSLTPathFromConfigFile() - Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {

                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat); //REUBK-1915

                //XDocument l_oConfig = XDocument.Load("RO-ASAM-BMW_RO_Interface_Config.xml");
                if (l_oConfig == null)
                {
                    //exception handling
                    objlogger.LogInfo("RequestOneCustomerInterface: ValidateIMF: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                    throw new System.Exception("Could not find config file in GetXSLTPathFromConfigFile");
                }

                //sXSLTPath = rConfigMgr.ConfigurationXML.Root.XPathSelectElement(ConfigurationFileTags.ROPREPROCESSINGXSLTXPATH).Value.ToString();
                sXSLTPath = l_oConfig.Root.XPathSelectElement(ConfigurationFileTags.ROPREPROCESSINGXSLTXPATH).Value.ToString();
            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in GetXSLTPathFromConfigFile" + ex.Message);

            }
            objlogger.LogInfo("GetXSLTPathFromConfigFile() - Ends", GlobalConstants.LOGGERLEVEL1);

            return sXSLTPath;


        }

    }


}
