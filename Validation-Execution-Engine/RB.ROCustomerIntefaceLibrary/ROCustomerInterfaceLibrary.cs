using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.Xml.XPath;
using System.Timers;
using System.Data;

namespace RB.ROCustomerIntefaceLibrary
{
    /// <summary>
    /// RequestOneCustomerInterface - Class which will act a facade for other functionalities
    /// Will be called from BTHelper
    /// </summary>
    public class RequestOneCustomerInterface : RequestOneCustomerInterfaceLibrary
    {
       

        XNamespace nsIMFMgr = XNamespace.Get(GlobalConstants.IMF_NAMESPACE_URI);
        public RequestOneCustomerInterface(string strExchangeFormat)
        {
            ExchangeFormat = strExchangeFormat;           
        }
              


        public override bool ValidateIMF(XDocument xIssueDoc, Dictionary<string, string> Orc_Parameters, bool bIsMsgAck, Logger objlogger)
        {
            bool isValid = false;
            try
            {
                objlogger.LogInfo("RequestOneCustomerInterface::ValidateIMF - Starts", GlobalConstants.LOGGERLEVEL1);
                //objlogger.LogInfo("ExchangeFormat =" + ExchangeFormat);
                //Setting Attachments path         

                //if (!bIsMsgAck)
                {
                    string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(ExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                    ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                    //XDocument xConfigData = rConfigMgr.LoadConfigurationXML();                    
                    //RODataInterface.InterfaceConfigFile = rConfigMgr.LoadConfigurationXML(); //1915
                    XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(ExchangeFormat);
                    if (l_oConfig == null)
                    {
                        //exception handling
                        objlogger.LogInfo("RequestOneCustomerInterface: ValidateIMF: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                    }
                    else
                    {
                        //RODataInterface.InterfaceConfigFile;
                        string strVRFPath = rConfigMgr.ConfigurationXML.Root.XPathSelectElement(ConfigurationFileTags.IMF_RULES_FILE_XPATH).Value.ToString();
                        objlogger.LogInfo("strVRFPath: " + strVRFPath, GlobalConstants.LOGGERLEVEL1);

                        //Added by Karthik, 25-03-2011 to support passthrough for validation
                        //objlogger.LogInfo("Getting the UseRule attribute");
                        string strUseIMFFile = rConfigMgr.ConfigurationXML.Root.XPathSelectElement(ConfigurationFileTags.IMF_RULES_FILE_XPATH).Attribute(ConfigurationFileTags.IMF_RULES_USEAGE_ATTRIBUTE).Value;
                        //if strUseIMFFile = 1, then proceed with the validation of the IMF
                        //if strUseIMFFile <> 1, then skip validation and return ture always

                        #region ExecutingStack
                        //Cleare Executing stack if the attr is set, a mechanisum to ensure that 
                        //even in case of exceptions resulting curropted execution stack we can clear and start new.
                        string sInterfaceNewStart = rConfigMgr.ConfigurationXML.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS)
                                         .Element(ConfigurationFileTags.INTERFACE_NEWSTART).Value;

                        if (sInterfaceNewStart == GlobalConstants.YES)
                        {
                            GlobalConstants.g_CurrentlyExecuting.Clear();
                        }
                        #endregion

                        objlogger.LogInfo("Check for ValidationWarning strUseIMFFile: " + strUseIMFFile, GlobalConstants.LOGGERLEVEL2);
                        if (strUseIMFFile == "1")
                        {
                            objlogger.LogInfo("Proceed for validation ", GlobalConstants.LOGGERLEVEL2);
                            // XDocument xModifiedIssueDoc = ProcessIMFAndFillMissingDetails(xIssueDoc, Orc_Parameters); REUBK-1660
                            ROValidationEngineManager rValMgr = new ROValidationEngineManager(strVRFPath, xIssueDoc, Orc_Parameters,bIsMsgAck, objlogger);
                            //rValMgr.InterfaceConfigFile = xoInterfaceConfigurationFile;
                            isValid = rValMgr.ValidateIMF();
                        }
                        else
                        {   //Added by Karthik, 25-03-2011 to support passthrough for validation
                            //No valdiation rule file to be used. always return true
                            objlogger.LogInfo("Skip validation and return true always", GlobalConstants.LOGGERLEVEL1);
                            isValid = true;
                        }
                    }
                }
               /* else
                {
                    //MSG-ACK handling
                    string strVRFPath = string.Empty;
                    ROValidationEngineManager rValMgr = new ROValidationEngineManager(strVRFPath, xIssueDoc, Orc_Parameters,bIsMsgAck, objlogger);
                    isValid = rValMgr.ValidateIMF();
                }*/

            }
            catch (Exception ex)
            {
                isValid = false;
                objlogger.LogInfo("Check the Configuration file", GlobalConstants.LOGGERLEVEL1);
                objlogger.LogException(ex, "RequestOneCustomerInterface: ValidateIMF:");
            }
            objlogger.LogInfo("RequestOneCustomerInterface::ValidateIMF - Ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public bool Execute(XDocument xIssueDoc, Dictionary<string, string> Orc_Parms, Logger objlogger)
        {
            bool isValid = false;
            try
            {
                objlogger.LogInfo("RequestOneCustomerInterface::Execute - Starts", GlobalConstants.LOGGERLEVEL1);

                //Setting Attachments path                
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(ExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(ExchangeFormat);
                //RODataInterface.InterfaceConfigFile = rConfigMgr.LoadConfigurationXML(); //1915
                
                if (l_oConfig == null)
                {
                    //exception handling
                    objlogger.LogInfo("RequestOneCustomerInterface: Execute: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                }
                else
                {
                    //RODataInterface.InterfaceConfigFile;
                    //string strIMFPath = rConfigMgr.ConfigurationXML.Root.XPathSelectElement(ConfigurationFileTags.IMF_RULES_FILE_XPATH).Value.ToString();
                    //objlogger.LogInfo("RequestOneCustomerInterface: Execute: calling exec engine");
                    // XDocument xModifiedIssueDoc = ProcessIMFAndFillMissingDetails(xIssueDoc, Orc_Parms); REUBK-1660
                    ROExecutionEngine oExecutionEngine = new ROExecutionEngine(xIssueDoc, Orc_Parms, l_oConfig, objlogger);
                    //rValMgr.InterfaceConfigFile = xoInterfaceConfigurationFile;
                    isValid = oExecutionEngine.Execute();
                }

                objlogger.LogInfo("RequestOneCustomerInterface::Execute - Ends", GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                isValid = false;
                objlogger.LogException(ex, "RequestOneCustomerInterface: Execute:");
            }
            
            return isValid;
        }

  

        public override bool UpdateIMRToRO(XDocument xIssueDoc)
        {
            throw new NotImplementedException();
        }

        public override string GetProjectIDFromConfig()
        {
            throw new NotImplementedException();
        }

        public override XmlDocument GetImportFileNamesForExchange()
        {
            throw new NotImplementedException();
        }


        #region unused methods
        //This method is not required - REUBK-1660 
        public override XDocument ProcessIMFAndFillMissingDetails(XDocument xIssueDoc, Dictionary<string, string> Orc_Parameters)
        {
        //    //InterfaceConfigurationFile contains the 
        //    Utilities.objLogger.LogInfo("RequestOneCustomerInterface::ProcessIMFAndFillMissingDetails- Starts");
        //    if (RODataInterface.InterfaceConfigFile == null)
        //    {
        //        Utilities.objLogger.LogInfo("Interface Configuration file not loaded. Issue may not be inserted");
        //    }
        //    else
        //    {
        //        //check for issue state?
        //        string strType = string.Empty;
        //        string strDomain = string.Empty;
        //        string strScope = string.Empty;
        //        try
        //        {
        //            Utilities.objLogger.LogInfo("Interface Configuration file loaded");

        //            //string strBelongsToProject = string.Empty;
        //            XElement xIssuesNode = RODataInterface.InterfaceConfigFile.Element(ConfigurationFileTags.ROOT_NODE).Element(ConfigurationFileTags.REQUESTONE).Element(ConfigurationFileTags.REQUESTONE_ISSUES);
        //            XElement xIssueDefValue = xIssuesNode.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALS_ROOT);
        //            var DomainValue = from domain in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
        //                              where (string)domain.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.DOMAIN_NAME_VALUE
        //                              select domain.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
        //            foreach (var item in DomainValue)
        //            {
        //                strDomain = item.ToString();
        //            }
        //            Utilities.objLogger.LogInfo("after getting domain");
        //            var TypeValue = from typeval in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
        //                            where (string)typeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.TYPE_NAME_VALUE
        //                            select typeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
        //            foreach (var item in TypeValue)
        //            {
        //                strType = item.ToString();
        //            }
        //            Utilities.objLogger.LogInfo("after getting type");
        //            var ScopeValue = from scopeval in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
        //                             where (string)scopeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.SCOPE_NAME_VALUE
        //                             select scopeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
        //            foreach (var item in ScopeValue)
        //            {
        //                strScope = item.ToString();
        //            }
        //            Utilities.objLogger.LogInfo("after getting scope");
        //        }
        //        catch (Exception exp)
        //        {
        //            Utilities.objLogger.LogInfo("exp in filling details" + exp.Message.ToString());
        //        }

        //        Utilities.objLogger.LogInfo("b4 assigning to xissuedoc");
        //        try
        //        {
        //            //strBelongsToProject = RODataInterface.InterfaceConfigFile.Element(ConfigurationFileTags.ROOT_NODE).Element(ConfigurationFileTags.REQUESTONE).Element(ConfigurationFileTags.PROJECTS).Element(ConfigurationFileTags.PROJECTS_PROJECT).Element(ConfigurationFileTags.PROJECT_ID).Value;
        //            xIssueDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_TYPE).Value = strType;
        //            xIssueDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_DOMAIN).Value = strDomain;
        //            xIssueDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_SCOPE).Value = strScope;
        //            xIssueDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_BELONGSTOPROJECT).Value = Orc_Parameters[OrcParameters.BELONGSTOPROJECT];

        //            Utilities.objLogger.LogInfo("TYPE: " + strType);
        //            Utilities.objLogger.LogInfo("DOMAIN: " + strDomain);
        //            Utilities.objLogger.LogInfo("Scope: " + strScope);
        //            Utilities.objLogger.LogInfo("BELONGSTOPROJECT: " + Orc_Parameters[OrcParameters.BELONGSTOPROJECT]);
        //        }
        //        catch (Exception ex)
        //        {
        //            Utilities.objLogger.LogInfo("exp in assigning to xissuedoc" + ex.Message.ToString());
        //        }
        //        Utilities.objLogger.LogInfo("after assigning to xissuedoc");
        //    }
        //    Utilities.objLogger.LogInfo("RequestOneCustomerInterface::ProcessIMFAndFillMissingDetails- Ends");
            return xIssueDoc;
        }
        #endregion
    }

}
