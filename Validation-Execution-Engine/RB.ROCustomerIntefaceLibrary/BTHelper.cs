using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;
using System.Reflection;
using System.Threading;
using System.Xml.XPath;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Net.Mail;
using static RB.ROCustomerIntefaceLibrary.GlobalConstants;
namespace RB.ROCustomerIntefaceLibrary
{
    /*
      * This class will be the interface between BizTalk Orchestration and RequestOne
      * The Methods in this class will be called in BizTalk's Orchestartion
      */
    [Serializable]
    public class BTHelper
    {


        //Dictionary will store the values from Orchestatation and returns to MAP
        //[ThreadStatic]
        static Dictionary<int, Dictionary<string, string>> internalDictStore = new Dictionary<int, Dictionary<string, string>>();
        private static object BTHlocker = new object();

        public BTHelper()
        { }

        #region "Getting values from Orchestration -> MAP"

        /// <summary>
        /// Gets the corresponding map name from interface config file
        /// </summary>
        /// <param name="sExchangeFormat"></param>
        /// <param name="sIssueState"></param>
        /// <param name="sIssueCategory"></param>
        /// <param name="objlogger"></param>
        /// <returns></returns>
        public string GetMappingFileNameFromConfiguration(string sExchangeFormat, string sIssueState, string sIssueCategory, Logger objlogger)
        {
            string sMapName = string.Empty;
            objlogger.LogInfo("GetMappingFileNameFromConfiguration starts, InterfaceName =" + sExchangeFormat
                + "IssueState = " + sIssueState + "Issue Category= " + sIssueCategory, GlobalConstants.LOGGERLEVEL1);
            string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
            ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
            XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat);
            //objlogger.LogInfo("Loaded ConfigFile for identifying the Map");
            if (l_oConfig != null && !string.IsNullOrEmpty(sIssueState) && !string.IsNullOrEmpty(sIssueCategory))
            {
                sMapName = l_oConfig.Root.Elements(ConfigurationFileTags.REQUESTONE)
                                                    .Elements(ConfigurationFileTags.MAPS)
                                                    .Elements(ConfigurationFileTags.WORKFLOW).Where(n => n.FirstAttribute.Value == sIssueCategory.ToUpper())
                                                    .Elements(ConfigurationFileTags.STATE)
                                                    .Elements().Where(n => n.Value == sIssueState)
                                                    .Select(n => n.Parent.Element(ConfigurationFileTags.MAPNAME).Value)
                                                    .SingleOrDefault();
            }
            objlogger.LogInfo("MAP Name =" + sMapName, GlobalConstants.LOGGERLEVEL1);
            return sMapName;
        }

        //This method is used for modifying transaction ID for BMW interface. It includes IRM ID and removed .xml
        public string GetModfiedTransactionID(XmlDocument xIssueDoc, Logger objlogger, string transactionID, string InterfaceName)
        {
            string IRMID = string.Empty;
            string ProjectID = string.Empty;
            

            if (InterfaceName == "RO-ASAM-BMW")
            {
                transactionID = transactionID.Replace(".xml", "");

                XNamespace objname;
                XElement l_oelement = null;
                XElement delv_MileStone_element = null;
                XElement Project_element = null;

                objname = xIssueDoc.DocumentElement.NamespaceURI.ToString();

                XDocument xIssueDocument = null;
                using (var nodeReader = new XmlNodeReader(xIssueDoc))
                {
                    nodeReader.MoveToContent();
                    xIssueDocument = XDocument.Load(nodeReader);
                }

                try
                {
                    //Fetching Delivery Milestone element from msgIssue
                    delv_MileStone_element = xIssueDocument.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES)
                                                      .Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                                                      .Elements(objname + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                                                      .Elements(objname + GlobalConstants.ASAMFileTags.DELIVERYMILESTONES)
                                                      .SingleOrDefault();

                    if (delv_MileStone_element == null)
                    {
                        // Fetching ProjectID from msgIssue
                        Project_element = xIssueDocument.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES)
                                                         .Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                                                         .Elements(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS).Descendants(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                                                         .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.COMPANYDATAREF).Value.ToUpper() == "BMW")
                                                         .SingleOrDefault();

                        ProjectID = Project_element.Element(objname + GlobalConstants.ASAMFileTags.PROJECT_ID).Value;

                        if (!string.IsNullOrEmpty(ProjectID))
                        {
                            //Fetching IRM ID from msgIssue
                            l_oelement = xIssueDocument.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES)
                                                              .Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                                                              .Elements(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS).Descendants(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                                                              .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.COMPANYDATAREF).Value.ToUpper() == "BOSCH")
                                                              .SingleOrDefault();

                            IRMID = l_oelement.Element(objname + GlobalConstants.ASAMFileTags.ISSUEID).Value;


                            //Concatinating IRM ID to the transactionID for IRM based imports
                            if (!string.IsNullOrEmpty(IRMID))
                            {
                                transactionID = IRMID + "#" + transactionID;
                            }                           
                        }
                     }
                  }

                  catch (Exception ex)
                  {
                    objlogger.LogException(ex, "GetIssueFileFromTransferPath()");                
                  }
                  objlogger.LogInfo("ModfiedTransactionID = " + transactionID, GlobalConstants.LOGGERLEVEL1);
                }
                      
            return transactionID;

        }



        public string GetOrchNameFromConfiguration(string sExchangeFormat, string sIssueState, string sIssueCategory, Logger objlogger)
        {
            objlogger.LogInfo("GetOrchNameFromConfiguration starts, InterfaceName =" + sExchangeFormat
                + "IssueState = " + sIssueState + "Issue Category= " + sIssueCategory, GlobalConstants.LOGGERLEVEL1);
            string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
            ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
            XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat);
            //objlogger.LogInfo("Loaded ConfigFile for identifying the OrchName");
            string sOrchName = string.Empty;


            sOrchName = l_oConfig.Root.Elements(ConfigurationFileTags.REQUESTONE)
                                                .Elements(ConfigurationFileTags.MAPS)
                                                .Elements(ConfigurationFileTags.WORKFLOW).Where(n => n.FirstAttribute.Value == sIssueCategory.ToUpper())
                                                .Elements(ConfigurationFileTags.STATE)
                                                .Elements().Where(n => n.Value == sIssueState && n.Parent.Element(ConfigurationFileTags.ENRICHMENTORCH) != null)
                                                .Select(n => n.Parent.Element(ConfigurationFileTags.MAPNAME).Value)
                                                .SingleOrDefault();


            objlogger.LogInfo("Completed Querying the Config for OrchName =" + sOrchName, GlobalConstants.LOGGERLEVEL1);
            return sOrchName;
        }


        //Set the values which can be used in the MAP
        public void AddOrchestrationVaraibles(string key, string value, Logger objlogger)
        {
            Dictionary<string, string> currentDictionary;
            objlogger.LogInfo("Current thread ID:" + Thread.CurrentThread.ManagedThreadId, GlobalConstants.LOGGERLEVEL1);

            if (System.Threading.Monitor.TryEnter(BTHlocker, 5000)) //timeout of 5sec
            {
                try
                {
                    if (internalDictStore.TryGetValue(Thread.CurrentThread.ManagedThreadId, out currentDictionary))
                    {
                        objlogger.LogInfo("Current thread available in internalDictStore", GlobalConstants.LOGGERLEVEL1);
                        currentDictionary[key] = value;

                    }
                    else
                    {
                        objlogger.LogInfo("Current thread unavailable in internalDictStore", GlobalConstants.LOGGERLEVEL1);
                        currentDictionary = new Dictionary<string, string>();
                        currentDictionary.Add(key, value);
                        internalDictStore.Add(Thread.CurrentThread.ManagedThreadId, currentDictionary);
                    }
                }
                finally
                {
                    //Releasing lock
                    System.Threading.Monitor.Exit(BTHlocker);
                }
            }
            else
            {
                objlogger.LogInfo("Time out obtaining lock", GlobalConstants.LOGGERLEVEL1);
            }


            //objlogger.LogInfo("AddOrchestrationVaraibles ends", GlobalConstants.LOGGERLEVEL1);
        }
        //GetEvaluator the values which can be used in the MAP
        public string GetOrchestrationVaraibles(string key)
        {
            string value = "";
            Dictionary<string, string> currentDictionary;
            if (internalDictStore.TryGetValue(Thread.CurrentThread.ManagedThreadId, out currentDictionary))
            {

                if (currentDictionary.TryGetValue(key, out value))
                    return value;
            }
            return value;
        }

        public void RemoveData()
        {
            if (internalDictStore.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                internalDictStore.Remove(Thread.CurrentThread.ManagedThreadId);
        }

        #endregion

        #region Logger

        public string GetConfigPathForLogger(string sExchangeFormat, string sXPROT)
        {
            string configPath = Utilities.LoadItemFromBizTalkAppConfig(GlobalConstants.LOGGER_KEY);
            string strdatetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            strdatetime = strdatetime.Replace('/', '.'); // '/' not acc in file name
            strdatetime = strdatetime.Replace(':', '.'); //:not acc in file name
            string sPath = strdatetime + "_" + sExchangeFormat + "_" + sXPROT + ".txt";
            configPath = configPath + sPath;
            //configPath = configPath + sExchangeFormat + "_" + sXPROT + "_ValEx.txt";
            return configPath;
        }

        public void SetLoggingMode(string sExchangeFormat, Logger objlogger)
        {

            try
            {
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat);

                string sLogLevel = string.Empty;

                foreach (XElement xe in l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element("LOGGER_SETTINGS").Elements("LOGGINGLEVEL").Where(e => e.Attribute("ENABLE").Value == "TRUE"))
                {
                    sLogLevel = xe.Attribute("LEVEL").Value;
                }

                objlogger.LogInfo("Setting Log Level value", GlobalConstants.LOGGERLEVEL1);
                switch (sLogLevel)
                {
                    case "1":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL1;
                        break;

                    case "2":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL2;
                        break;

                    case "3":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL3;
                        break;

                    default:
                        objlogger.LogException("Please enable atleast one Logger level");
                        break;
                }
                objlogger.LogInfo("Log Level Value: " + objlogger.iLogLevel, GlobalConstants.LOGGERLEVEL1);


            }
            catch (Exception ex)
            {
                objlogger.LogException(ex);
            }

        }

        #endregion

        #region  "Importing of Files from FTP folder"



        public string GetAIFilesLocation(string transferPath)
        {
            string subdir = string.Empty;

            foreach (string folder in Directory.GetDirectories(transferPath))
            {
                subdir = Path.GetFileName(folder);
                break;
            }

            //return transferPath + "\\" + subdir;
            // return transferPath + subdir;  // transferPath already ends with \ hence, extra \ removed for allowing max atts of file name length = max length limit
            return transferPath + subdir + "\\";
        }

        public int GetFilesCount(string strTransferPath, string sLifeToken) //RUBK-1410,REUBK-1634
        {
            int iFilesCount = 0;
            try
            {
                var fileList = Directory.GetFiles(strTransferPath).Where(file => file.EndsWith(".xml"))
                               .Select(file =>
                               new
                               {
                                   FullName = file,
                                   FileName = System.IO.Path.GetFileName(file)
                               });

                foreach (var item in fileList)
                {
                    if (sLifeToken.Contains(item.FileName))
                    {
                        iFilesCount++;
                    }
                }

            }
            catch
            { }
            return iFilesCount;
        }

        //Sup -08   
        public string GetAllIssueFiles(string strTransferPath, string strInterfaceName, string sExchangeProtocol, string sLifeToken, Logger objlogger)
        {

            //testing
            if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols.Add(Thread.CurrentThread.ManagedThreadId, sExchangeProtocol);
            }

            objlogger.LogInfo("GetAllIssueFiles STARTS", GlobalConstants.LOGGERLEVEL1);


            objlogger.LogInfo("strTransferPath: " + strTransferPath, GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("LifeToken Value = " + sLifeToken, GlobalConstants.LOGGERLEVEL1);
            string strFileNames = "";
            try
            {
                if (Directory.Exists(strTransferPath))
                {
                    //objlogger.LogInfo("Transfer Path folder exist");
                    #region NormalFiles
                    var fileList = Directory.GetFiles(strTransferPath).Where(file => file.EndsWith(".xml"))
                              .Select(file =>
                              new
                              {
                                  FullName = file,
                                  FileName = System.IO.Path.GetFileName(file)
                              });

                    List<string> lstfiles = new List<string>();
                    foreach (var item in fileList)
                    {
                        lstfiles.Add(item.FileName);
                    }

                    //Logic changed to Consider All Issue files based on lifetoken order              
                    sLifeToken = "·" + sLifeToken;
                    MatchCollection matchcoll = Regex.Matches(sLifeToken, "·(.*?).xml");
                    foreach (Match singlematch in matchcoll)
                    {
                        objlogger.LogInfo("Checking File = " + Regex.Replace(singlematch.Value, "^·", ""), GlobalConstants.LOGGERLEVEL1);
                        if (lstfiles.Contains(Regex.Replace(singlematch.Value, "^·", "")))
                        {
                            objlogger.LogInfo("Considerd File = " + Regex.Replace(singlematch.Value, "^·", ""), GlobalConstants.LOGGERLEVEL1);
                            if (strFileNames == string.Empty)
                            {
                                strFileNames = Regex.Replace(singlematch.Value, "^·", "");
                            }
                            else
                            {
                                strFileNames = strFileNames + "|" + Regex.Replace(singlematch.Value, "^·", "");
                            }
                        }
                        else
                        {
                            objlogger.LogInfo("File " + Regex.Replace(singlematch.Value, "^·", "") + " not found in transfered files folder", GlobalConstants.LOGGERLEVEL1);
                        }
                    }

                    /* foreach (var item in fileList)
                     {
                         objlogger.LogInfo("Checking fileName = " + item.FileName);
                         if (sLifeToken.Contains(item.FileName))
                         {
                             objlogger.LogInfo("Considerd File = " + item.FileName);
                             if (strFileNames == string.Empty)
                             {
                                 strFileNames = item.FileName.ToString();
                             }
                             else
                             {
                                 strFileNames = strFileNames + "|" + item.FileName.ToString();
                             }
                         }
                     } */


                    #endregion

                    #region CommertialFiles
                    /*if (Directory.Exists(strTransferPath + "COMMERCIAL\\"))
                    {
                        var CommertialfileList = from file in Directory.GetFiles(strTransferPath + "COMMERCIAL\\")
                                                 where file.EndsWith(".xml")
                                                 select new
                                                 {
                                                     FullName = file,
                                                     FileName = System.IO.Path.GetFileName(file)
                                                 };

                        foreach (var item in CommertialfileList)
                        {
                            if (strFileNames == string.Empty)
                            {
                                strFileNames = item.FileName.ToString();
                            }
                            else
                            {
                                strFileNames = strFileNames + "|" + item.FileName.ToString();
                            }

                        }
                    } */
                    #endregion

                    objlogger.LogInfo("strFileNames: " + strFileNames, GlobalConstants.LOGGERLEVEL1);
                }
                else
                {
                    objlogger.LogInfo("Transfer Path folder does not exist", GlobalConstants.LOGGERLEVEL1);
                }
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetAllIssueFielNames()");
            }
            //objlogger.LogInfo("GetAllIssueFielNames() - Ends");

            //objlogger.LogInfo("TEST FOR NEW LOGGING--GetAllIssueFiles ENDS");


            return strFileNames;
        }
        //Sup -08   

        //Sup -08   
        public string GetIssueFielName(string strTransferPath, string strInterfaceName, string sExchangeProtocol, string sFileNames, Logger objlogger)
        {
            if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols.Add(Thread.CurrentThread.ManagedThreadId, sExchangeProtocol);
            }
            objlogger.LogInfo("GetIssueFielName STARTS", GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("All files=" + sFileNames, GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("strTransferPath: " + strTransferPath, GlobalConstants.LOGGERLEVEL1);
            string strFileName = "";
            try
            {
                string[] sFileNamearr = sFileNames.Split('|');

                //objlogger.LogInfo("Number of files=" + sFileNamearr.Length.ToString());

                for (int i = 0; i < sFileNamearr.Length; i++)
                {
                    if (sFileNamearr[i] != "Processed"
                        && sFileNamearr[i] != "")
                    {
                        strFileName = sFileNamearr[i].Trim();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetIssueFielName()");
            }


            if (objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols[Thread.CurrentThread.ManagedThreadId]
                    = sExchangeProtocol + " File Name:" + strFileName;
            }
            objlogger.LogInfo("GetIssueFielName - Ends with file name = " + strFileName, GlobalConstants.LOGGERLEVEL1);
            //objlogger.LogInfo("GetIssueFielName ENDS");

            return strFileName;
        }
        //Sup -08   

        //Sup -08
        public XmlDocument GetIssueFileFromTransferPath(string strTransferPath, string sFileName, string strInterfaceName, Logger objLogger)
        {
            objLogger.LogInfo("GetIssueFileFromTransferPath() - Starts", GlobalConstants.LOGGERLEVEL1);
            //objLogger.LogInfo("GetIssueFileFromTransferPath() - Starts: " + strTransferPath);
            XmlDocument xIssueDoc = new XmlDocument();
            try
            {
                if (Directory.Exists(strTransferPath))
                {
                    //objLogger.LogInfo("Transfer Path folder exist");
                    #region NormalFiles
                    var fileList = from file in Directory.GetFiles(strTransferPath)
                                   where file.EndsWith(".xml")
                                   select new
                                   {
                                       FullName = file,
                                       FileName = System.IO.Path.GetFileName(file)
                                   };
                    string strTransferFile;
                    foreach (var item in fileList)
                    {
                        strTransferFile = item.FullName.ToString();

                        objLogger.LogInfo("Checking TransferFile: " + strTransferFile, GlobalConstants.LOGGERLEVEL2);

                        if (item.FileName.Trim() == sFileName.Trim())
                        {
                            objLogger.LogInfo("Selected TransferFile: " + strTransferFile, GlobalConstants.LOGGERLEVEL1);
                            xIssueDoc.Load(strTransferFile);
                        }

                    }
                    #endregion

                    #region CommertialFiles
                    /*if (Directory.Exists(strTransferPath + "COMMERCIAL\\"))
                    {
                        var CommertialfileList = from file in Directory.GetFiles(strTransferPath + "COMMERCIAL\\")
                                                 where file.EndsWith(".xml")
                                                 select new
                                                 {
                                                     FullName = file,
                                                     FileName = System.IO.Path.GetFileName(file)
                                                 };

                        foreach (var item in CommertialfileList)
                        {
                            strTransferFile = item.FullName.ToString();

                            if (item.FileName.Trim() == sFileName.Trim())
                            {
                                Utilities.fobjLogger.LogInfo("Selected TransferFile: " + strTransferFile);
                                xIssueDoc.Load(strTransferFile);
                            }

                        }
                    }*/
                    #endregion

                }
                else
                {
                    objLogger.LogInfo("Transfer Path folder does not exist", GlobalConstants.LOGGERLEVEL1);
                }


            }
            catch (Exception ex)
            {
                objLogger.LogException(ex, "GetIssueFileFromTransferPath()");
                //throw;
            }
            objLogger.LogInfo("GetIssueFileFromTransferPath() - Ends", GlobalConstants.LOGGERLEVEL1);
            return xIssueDoc;
        }
        //Sup -08

        //Sup -08


        public string RemoveFromListAfterProcessing(string sAllFileNames, string sFileName, string sInterfaceName, Logger objlogger)
        {
            sAllFileNames = sAllFileNames.Trim();
            objlogger.LogInfo("Before Removing file =" + sAllFileNames, GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("Removing file =" + sFileName, GlobalConstants.LOGGERLEVEL1);
            if (!string.IsNullOrEmpty(sFileName))
            {
                sAllFileNames = sAllFileNames.Replace(sFileName.Trim(), "Processed");
                objlogger.LogInfo("After Removing file =" + sAllFileNames, GlobalConstants.LOGGERLEVEL1);
            }
            return sAllFileNames;
        }
   

        public void MoveIssueAfterProcessing(string strTransferPath, string strProcessedIssue, bool isSucces = true)
        {
            //Move the file to another folder after processing. required for Orchestation to take only unprocessed XML files            
            //Utilities.objLogger.LogInfo("MoveIssueAfterProcessing() - Starts");
            //Utilities.objLogger.LogInfo("strTransferPath: " + strTransferPath);
            //Utilities.objLogger.LogInfo("strProcessedIssue: " + strProcessedIssue);
            //Utilities.objLogger.LogInfo("isSucces: " + isSucces.ToString());
            string strNewPath = "";
            try
            {
                if (Directory.Exists(strTransferPath))
                {
                    //isSucces: true => move to CONSUMED folder, false => move to FAILED folder
                    if (isSucces)
                    {
                        strNewPath = strTransferPath + @"\" + IssueFileHandling.ISSUE_CONSUMED;
                        // Utilities.objLogger.LogInfo("strNewPath: " + strNewPath);
                    }
                    else
                    {
                        strNewPath = strTransferPath + @"\" + IssueFileHandling.ISSUE_FAILED;
                        // Utilities.objLogger.LogInfo("strNewPath: " + strNewPath);
                    }
                    if (ManageFolders(strNewPath, strTransferPath, strProcessedIssue))
                    {
                        // Utilities.objLogger.LogInfo("File Movement Succeeded");
                    }
                    else
                    {
                        // Utilities.objLogger.LogInfo("File Movement failed");
                    }
                }
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogException(ex, "Error in MoveIssueAfterProcessing()");
            }
            // Utilities.objLogger.LogInfo("MoveIssueAfterProcessing() - Ends");
        }

        public void SetExchangeProtocolForLogging(string sExchangeProtocol)
        {
            //   Utilities.objLogger.sExchangeProtocol = sExchangeProtocol;
        }

        private bool ManageFolders(string strPathName, string strTransferPath, string strIssueFileName)
        {
            //Utilities.objLogger.LogInfo("ManageFolders() - Starts");
            //Utilities.objLogger.LogInfo("strPathName: " + strPathName);
            //Utilities.objLogger.LogInfo("strTransferPath: " + strTransferPath);
            //Utilities.objLogger.LogInfo("strIssueFileName: " + strIssueFileName);

            //Create if it does not exist
            bool isSuccess = false;
            try
            {
                string strSourceFileName = strTransferPath + @"\" + strIssueFileName;
                string strDestFileName = strPathName + @"\" + strIssueFileName;
                if (!Directory.Exists(strPathName))
                {
                    //Utilities.objLogger.LogInfo("Path " + strPathName + " does not exist. Create");
                    Directory.CreateDirectory(strPathName);
                }
                //Move 
                //Utilities.objLogger.LogInfo("strSourceFileName: " + strSourceFileName);
                //Utilities.objLogger.LogInfo("strDestFileName: " + strDestFileName);
                //Utilities.objLogger.LogInfo("Move of Issue file Starts");
                File.Move(strSourceFileName, strDestFileName);
                //Utilities.objLogger.LogInfo("Move of Issue file Ends");
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogException(ex, "Error in ManageFolders()");
            }
            //Utilities.objLogger.LogInfo("isSuccess: " + isSuccess.ToString());
            //Utilities.objLogger.LogInfo("ManageFolders() - ends");
            return isSuccess;
        }

        #endregion

        public void WriteHISMappinglog(string sExchangeProtocolID, Logger objlogger)
        {
            //if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            //{
            //    objlogger.sExchangeProtocols.Add(Thread.CurrentThread.ManagedThreadId, sExchangeProtocolID);
            //}
            objlogger.LogInfo("BTHelper::HISMapping: Starts", GlobalConstants.LOGGERLEVEL1);
        }

        public void writeHISMappingError(string sExchangeProtocolID, string sIssueFileName, Logger objlogger)
        {
            objlogger.LogInfo("BTHelper::writeHISMappingError:Starts", GlobalConstants.LOGGERLEVEL1);
            ROErrorLogger.RegisterUserError("Import is stopped because of blank ENGG-OBJECT Teilenummer value", sExchangeProtocolID, sIssueFileName);
            objlogger.LogInfo("BTHelper::writeHISMappingError:Ends", GlobalConstants.LOGGERLEVEL1);
        }

        public void writeHISMappingException(string sExchangeProtocolID, string sIssueFileName, Logger objlogger)
        {
            objlogger.LogInfo("BTHelper::writeHISMappingException:Starts", GlobalConstants.LOGGERLEVEL1);
            ROErrorLogger.RegisterUserError("Import is stopped because of exception in HISMapping", sExchangeProtocolID, sIssueFileName);
            objlogger.LogInfo("BTHelper::writeHISMappingException:Ends", GlobalConstants.LOGGERLEVEL1);
        }
        public void WriteHISMappingEndlog(string sExchangeProtocolID, Logger objlogger)
        {
            //if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            //{
            //    objlogger.sExchangeProtocols[Thread.CurrentThread.ManagedThreadId]
            //        = sExchangeProtocolID + " File Name:" + sfilename;
            //}

            objlogger.LogInfo("BTHelper::HISMapping: Ends", GlobalConstants.LOGGERLEVEL1);
        }

        #region  "ValidationWarning and Execution"

        /// <summary>
        /// This method is called by Orchestration after the mapping is done. Based on the return value from this function, 
        /// </summary>
        /// <param name="xIssueDoc">Message from BizTalk after mapping</param>
        /// <param name="strExchangeFormat">Exchange format : ASAM , BMW etc. this is mainly used to load the Configuration file</param>
        /// <param name="strIssueFilesPath">Issue File path which is passed as parameter which will be used for attachment path</param>
        /// <param name="strRoProjectID">GetEvaluator the project ID from the FTP Transfer message in Orchestration and set it to the global variable</param>
        /// <returns>True if the IMF is valid, False if IMF is invalid</returns>

        public void WriteInitialLifetokenData(string sLifeToken, string sExchangeProtocolID, string sIssueFileName, Logger objlogger)
        {
            objlogger.LogInfo("BTHelper::WriteLifetokenData:Starts", GlobalConstants.LOGGERLEVEL1);
            //objlogger.LogInfo("call writedata--");
            PersistenceDataManager l_odm = new PersistenceDataManager();
            l_odm.WriteData(sLifeToken, PersistenceDataStores.LIFETOKEN, false, sExchangeProtocolID);
            //objlogger.LogInfo("after writedata--");
            objlogger.LogInfo("BTHelper::WriteLifetokenData:Ends", GlobalConstants.LOGGERLEVEL1);

        }
        public bool ValidateIMF(XmlDocument xIssueDoc, string strExchangeFormat, string strIssueFilesPath, string strRoProjectID
            , string sExchangeProtocolID, string sIssueFilename, string sLifeToken, string sSystem, string sFileNames, bool isMsgAck, Logger objlogger)
        {
            objlogger.LogInfo("DATE TIME testing : " + DateTime.Now.ToShortDateString() + " " +DateTime.Now.ToShortTimeString());
            if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols[Thread.CurrentThread.ManagedThreadId]
                    = sExchangeProtocolID + " File Name:" + sIssueFilename;
            }

            objlogger.LogInfo("BTHelper::ValidateIMF: Starts", GlobalConstants.LOGGERLEVEL1);

            Dictionary<string, string> Orc_Params = new Dictionary<string, string>();


            //added by Karthik , 28-03-2011
            //Setting of projectID from the FTPTransfer Message
            //objlogger.LogInfo("Setting Project Id in ValidateIMF Starts:"+ strRoProjectID);
            //objlogger.LogInfo("ProjectID: " + strRoProjectID);
            Orc_Params.Add(OrcParameters.BELONGSTOPROJECT, strRoProjectID);
            Orc_Params.Add(OrcParameters.BELONGSTOPOOLPROJECT, strRoProjectID);
            //objlogger.LogInfo("Setting Project Id in ValidateIMF Ends");
            Orc_Params.Add(OrcParameters.XCHANGEPROTOCOLID, sExchangeProtocolID);
            Orc_Params.Add(OrcParameters.ATTACHMENTPATH, strIssueFilesPath);
            Orc_Params.Add(OrcParameters.ISSUEFILENAME, sIssueFilename);
            Orc_Params.Add(OrcParameters.EXCHANGEFORMAT, strExchangeFormat);
            Orc_Params.Add(OrcParameters.SYSTEM, sSystem);
            Orc_Params.Add(OrcParameters.INITIALLIFETOKEN, sLifeToken);
            Orc_Params.Add(OrcParameters.ISSUEFILENAMES, sFileNames);

            objlogger.LogInfo("can procced for validation starts-- " + "sLifeToken=" + sLifeToken + " sIssueFilename=" + sIssueFilename, GlobalConstants.LOGGERLEVEL1);
            //objlogger.LogInfo("can procced for validation-- sLifeToken=" + sLifeToken);
            // objlogger.LogInfo("can procced for validation-- sIssueFilename=" + sIssueFilename);

            if (!LifeTokenHandler.CanProceed(sLifeToken, sIssueFilename)) return false;
            //objlogger.LogInfo("can procced for validation-- ends");

            bool isValid = false;
            try
            {
                objlogger.LogInfo("ValidateIMF: ExchangeFormat=" + strExchangeFormat + " strIssueFilesPath=" + strIssueFilesPath, GlobalConstants.LOGGERLEVEL1);
                if (String.IsNullOrWhiteSpace(strExchangeFormat))
                {
                    objlogger.LogInfo("ValidateIMF: Invalid Exchange format specified. Exchangeformat is empty", GlobalConstants.LOGGERLEVEL1);
                    return false;
                }

                //Convert XMLDocument to XDocument (For processing via LINQ)
                XDocument xIssueDocument = null;
                using (var nodeReader = new XmlNodeReader(xIssueDoc))
                {
                    nodeReader.MoveToContent();
                    xIssueDocument = XDocument.Load(nodeReader);
                }
               
                /* if (isMsgAck)
                 {
                     isValid = true;
                     objlogger.LogInfo("BTHelper::ValidateIMF: MSGACK - writing IMF to isolated storage");
                     IMFManager oIMFmgr = new IMFManager(xIssueDocument, objlogger);
                     oIMFmgr.WriteToIsolatedStorage(Orc_Params, PersistenceDataStores.ROISSUEIMF);
                     RequestOneCustomerInterface RQ1CustInterface = new RequestOneCustomerInterface(strExchangeFormat);
                 }
                 else
                 {

                     RequestOneCustomerInterface RQ1CustInterface = new RequestOneCustomerInterface(strExchangeFormat);  //REUBK-1915                           
                     isValid = RQ1CustInterface.ValidateIMF(xIssueDocument, Orc_Params, objlogger);
                 } */


                RequestOneCustomerInterface RQ1CustInterface = new RequestOneCustomerInterface(strExchangeFormat);  //REUBK-1915                           
                isValid = RQ1CustInterface.ValidateIMF(xIssueDocument, Orc_Params, isMsgAck, objlogger);

                //objlogger.LogInfo("BTHelper::ValidateIMF: Calling ROCustInterface ValidateIMF Method - Ends");

            }
            catch (InvalidExchangeFormatException iefex)
            {
                isValid = false;
                objlogger.LogException(iefex, "ValidateIMF: Invalid Exchange Format specified");
            }

            catch (Exception ex)
            {
                isValid = false;
                objlogger.LogException(ex, "BTHelper::ValidateIMF: Error - ");
            }
            //objlogger.LogInfo("Return value isValid: " + isValid.ToString());
            objlogger.LogInfo("BTHelper::ValidateIMF ends with return value: " + isValid.ToString(), GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public bool Execute(XmlDocument xIssueDoc, string strExchangeFormat, string strIssueFilesPath,
            string strRoProjectID, string sExchangeProtocolId, string sIssueFileName, string sSystem, string sFileNames, Logger objlogger)
        {
            Dictionary<string, string> Orc_Params = new Dictionary<string, string>();
            if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols.Add(Thread.CurrentThread.ManagedThreadId, sExchangeProtocolId);
            }
            objlogger.LogInfo("BTHelper::Execute: Starts", GlobalConstants.LOGGERLEVEL1);

            IMFManager oIMFmgr = new IMFManager(null, objlogger);

            // 3 following lines uncommented - Ku 31.8.2011
            string sUdatedDoc = oIMFmgr.ReadFromIsolatedStorage(sExchangeProtocolId);
            XmlDocument l_oxDoc = new XmlDocument();
            l_oxDoc.LoadXml(sUdatedDoc);

            // 1 line commented - Ku 31.8.2011
            //XmlDocument l_oxDoc = xIssueDoc; //only for debugging

            //Setting of projectID from the FTPTransfer Message
            //objlogger.LogInfo("Setting Project Id in Execute Starts");
            Orc_Params.Add(OrcParameters.BELONGSTOPROJECT, strRoProjectID);
            //objlogger.LogInfo("Setting Project Id in Execute Ends");
            Orc_Params.Add(OrcParameters.BELONGSTOPOOLPROJECT, strRoProjectID);
            Orc_Params.Add(OrcParameters.XCHANGEPROTOCOLID, sExchangeProtocolId);
            Orc_Params.Add(OrcParameters.ATTACHMENTPATH, strIssueFilesPath);
            Orc_Params.Add(OrcParameters.ISSUEFILENAME, sIssueFileName);
            Orc_Params.Add(OrcParameters.EXCHANGEFORMAT, strExchangeFormat);
            Orc_Params.Add(OrcParameters.SYSTEM, sSystem);
            Orc_Params.Add(OrcParameters.ISSUEFILENAMES, sFileNames);


            bool isValid = false;
            try
            {
                objlogger.LogInfo("BTHelper::Execute: ExchangeFormat=" + strExchangeFormat + " strIssueFilesPath=" + strIssueFilesPath, GlobalConstants.LOGGERLEVEL1);

                if (String.IsNullOrWhiteSpace(strExchangeFormat))
                {
                    objlogger.LogInfo("Execute: Invalid Exchange Format specified", GlobalConstants.LOGGERLEVEL1);
                    return false;
                }
                //Convert XMLDocument to XDocument (For processing via LINQ)
                XDocument xIssueDocument = null;
                using (var nodeReader = new XmlNodeReader(l_oxDoc))
                {
                    nodeReader.MoveToContent();
                    xIssueDocument = XDocument.Load(nodeReader);
                }


                //REUBK-2136
                //PersistenceDataManager l_oPManager = new PersistenceDataManager();
                //l_oPManager.ClearStoreForAttachments(PersistenceDataStores.UNIMPORTEDATTACHMENTS);


                //objlogger.LogInfo("BTHelper::Execute: Calling ROCustInterface Execute Method - Starts ");
                RequestOneCustomerInterface RQ1CustInterface = new RequestOneCustomerInterface(strExchangeFormat); //REUBK-1915
                isValid = RQ1CustInterface.Execute(xIssueDocument, Orc_Params, objlogger);
                //objlogger.LogInfo("BTHelper::Execute: Calling ROCustInterface Execute Method - Ends");

            }
            catch (InvalidExchangeFormatException iefex)
            {
                isValid = false;
                objlogger.LogException(iefex, "Execute: Invalid Exchange Format specified");
            }

            catch (Exception ex)
            {
                isValid = false;
                objlogger.LogException(ex, "BTHelper::Execute: Error");
            }
            //objlogger.LogInfo("Return value isValid: " + isValid.ToString());
            objlogger.LogInfo("BTHelper::Execute ends with return value:" + isValid.ToString(), GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }

        public string GetISSUEIDForBinCompare(XmlDocument xIssueDoc, Logger objlogger)
        {
            string sreturn = string.Empty;

            try
            {
                objlogger.LogInfo("GetISSUEIDForBinCompare : Starts", GlobalConstants.LOGGERLEVEL1);
                XDocument xIssueDocument = null;
                if (xIssueDoc != null)
                {
                    using (var nodeReader = new XmlNodeReader(xIssueDoc))
                    {
                        nodeReader.MoveToContent();
                        xIssueDocument = XDocument.Load(nodeReader);
                    }


                    sreturn = xIssueDocument.Root.Element(IMFFileTags.RT_ISSUE)
                            .Element(IMFFileTags.ISSUE).Element(IMFFileTags.ID).Value.ToString();
                    objlogger.LogInfo("sreturn=" + sreturn, GlobalConstants.LOGGERLEVEL1);
                }

            }
            catch (Exception ex)
            {
                sreturn = null;
            }
            return sreturn;
        }

        // Parallel import of same file - DAIMLER
        public string GetSkipParallelImportField(string sConfigPath,string sInterfaceName, Logger objlogger)
        {
            string sFilterRegex = "";
            
            try
            {
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sInterfaceName + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sInterfaceName);
                
                if (l_oConfig == null)
                {
                    //exception handling
                    objlogger.LogInfo("GetSkipParallelImportField: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                }
                else
                {
                    string sEnabled = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.SKIPPARALLELIMPORTS).Attribute(ConfigurationFileTags.ENABLED).Value;
                    if (sEnabled.Equals("1"))
                    {
                        sFilterRegex = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.SKIPPARALLELIMPORTS).Value;
                        objlogger.LogInfo("GetSkipParallelImportField sFilterRegex:" + sFilterRegex, GlobalConstants.LOGGERLEVEL1);
                    }
                        
                }
            }
            catch { }
            return sFilterRegex;
        }

        public void DeregisterFiles(string xprot, Logger objlogger)
        {
            GlobalConstants.DeRegisterFromExecution(xprot, objlogger);
        }

        

        public void RegisterFiles(string xprot,string interfacename, string filenames, Logger objlogger, string  sFilterRegex)
        {
            GlobalConstants.RegisterForExecution(xprot, interfacename ,filenames, objlogger, sFilterRegex);
        }


        #region BinaryCompareAttachments

        public int GetUnimportedAttCount(string sIssueID, Logger objlogger)
        {
            int iFilesCount = 0;
            objlogger.LogInfo("GetFileCountofATT : Starts " + sIssueID, GlobalConstants.LOGGERLEVEL1);
            try
            {
                PersistenceDataManager l_odm = new PersistenceDataManager();
                iFilesCount = l_odm.GetFileCountofATT(PersistenceDataStores.UNIMPORTEDATTACHMENTS, sIssueID, objlogger);
                //objlogger.LogInfo("iFilesCount=" + iFilesCount.ToString());
            }
            catch
            { }
            return iFilesCount;
        }


        public XmlDocument GetUnImportedAttXML(string sIssueID, int icount, Logger objlogger)
        {
            XmlDocument l_oXDoc = new XmlDocument();

            objlogger.LogInfo("inside GetUnImportedAttXML name=" + sIssueID + icount.ToString() + "_" + PersistenceDataStores.UNIMPORTEDATTACHMENTS, GlobalConstants.LOGGERLEVEL1);
            try
            {
                if (sIssueID != string.Empty)
                {
                    PersistenceDataManager l_oDataManager = new PersistenceDataManager();

                    //objlogger.LogInfo("name=" + sIssueID + icount.ToString() + "_" + PersistenceDataStores.UNIMPORTEDATTACHMENTS);

                    string strData = l_oDataManager.ReadDataTest(icount.ToString() + "_" + PersistenceDataStores.UNIMPORTEDATTACHMENTS, sIssueID, objlogger);
                    //objlogger.LogInfo("inside GetUnImportedAttXML-strData" + strData);

                    l_oXDoc.LoadXml(strData);
                    objlogger.LogInfo("inside GetUnImportedAttXML-xml size" + l_oXDoc.OuterXml.Length.ToString(), GlobalConstants.LOGGERLEVEL1);

                }
            }
            catch (Exception e)
            {
                objlogger.LogException("GetUnImportedAttXML : Exp " + e.Message);
                return null;
            }
            //objlogger.LogInfo("inside GetUnImportedAttXML");
            return l_oXDoc;
        }


        public XmlDocument AddMissingparams(XmlDocument l_oXDoc, string sid, string ssystem, string spath, string InterfaceName, string sfilename, Logger objlogger)
        {
            objlogger.LogInfo("inside AddMissingparamas", GlobalConstants.LOGGERLEVEL1);


            XmlDocument l_oXDocFilled = new XmlDocument();

            XDocument xdoc = null;
            try
            {

                if (l_oXDoc != null)
                {
                    using (var nodeReader = new XmlNodeReader(l_oXDoc))
                    {
                        nodeReader.MoveToContent();
                        xdoc = XDocument.Load(nodeReader);
                    }

                    xdoc.Root.Element("RQ1System").Value = ssystem;
                    xdoc.Root.Element("XProtID").Value = sid;
                    xdoc.Root.Element("InterfaceName").Value = InterfaceName;
                    xdoc.Root.Element("DownloadTargetPath").Value = spath;
                    xdoc.Root.Element("ASAMFileName").Value = sfilename;


                    using (var xmlReader = xdoc.CreateReader())
                    {
                        l_oXDocFilled.Load(xmlReader);
                    }
                    objlogger.LogInfo("end AddMissingparamas", GlobalConstants.LOGGERLEVEL1);
                }
            }
            catch (Exception e)
            {
                objlogger.LogException("AddMissingparams : Exp " + e.Message);
                return null;
            }
            return l_oXDocFilled;
        }

        public string GetFileNameWithoutExtn(string sCompletename, Logger objlogger)
        {
            string fileBody = string.Empty;
            objlogger.LogInfo("GetFileNameWithoutExtn sCompletename=" + sCompletename, GlobalConstants.LOGGERLEVEL1);
            fileBody = System.Text.RegularExpressions.Regex.Replace(sCompletename, "(.+)\\.\\w*?$", "$1");
            string fileExtender = System.Text.RegularExpressions.Regex.Replace(sCompletename, ".+(\\.\\w*?)$", "$1");
            objlogger.LogInfo("GetFileNameWithoutExtn fileBody=" + fileBody, GlobalConstants.LOGGERLEVEL1);
            return fileBody;
        }

        #endregion

        public bool FileHasNoFTPError(string sToken, string sIssueFileName, string sInterfaceName, Logger objlogger)
        {
            //Set the interface name for Logfile handling            
            //RODataInterface.InterfaceName = sInterfaceName; REUBK-1916
            objlogger.LogInfo("Starting FTP error check", GlobalConstants.LOGGERLEVEL1);
            string sStatus = LifeTokenHandler.GetTokenStatusForFile(sToken, sIssueFileName);
            objlogger.LogInfo("FTP Error status is" + sStatus, GlobalConstants.LOGGERLEVEL1);
            if (sStatus.ToUpper() == "FAILURE") return false;
            objlogger.LogInfo("FileHasNoFTPError-- continue to valex", GlobalConstants.LOGGERLEVEL1);
            return true;
        }

        public string GetFTPFileStatus(string sToken, string sIssueFileName, string sInterfaceName, Logger objlogger)
        {
            //Set the interface name for Logfile handling            
            //RODataInterface.InterfaceName = sInterfaceName; REUBK-1916
            objlogger.LogInfo("Starting FTP error check", GlobalConstants.LOGGERLEVEL1);
            string sStatus = LifeTokenHandler.GetTokenStatusForFile(sToken, sIssueFileName);
            objlogger.LogInfo("FTP Error status is" + sStatus, GlobalConstants.LOGGERLEVEL1);
            return sStatus;
        }


        public XmlDocument GetModifiedIMF(string sExchangeProtocolId, Logger objlogger)
        {
            XmlDocument l_oXDoc = new XmlDocument();

            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                string strData = l_oDataManager.ReadData(PersistenceDataStores.ROISSUEIMF, sExchangeProtocolId);
                l_oXDoc.LoadXml(strData);
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Error in GetModifiedIMF");
                return null;
            }
            objlogger.LogInfo("GetModifiedIMF : ends", GlobalConstants.LOGGERLEVEL1);
            return l_oXDoc;
        }




        public void WriteLifeTokenString(string sIssueFileName, string sLifeTokenXPort, string sInterfaceName, Logger objlogger) //REUBK-1485 //REUBK1916
        {
            //objlogger.LogInfo("WriteLifeTokenString : Starts ");
            try
            {
                objlogger.LogInfo("LIFETOKEN:" + sIssueFileName + " Value=" + sLifeTokenXPort, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "Error in WriteLifeTokenString ");
            }

            //objlogger.LogInfo("WriteLifeTokenString : Ends");
        }




        public void WriteUserInformation(string sExchangeProtocolId, string slifeToken, bool bAppend, string sExchangeFormat, string sSystem, bool bdata, bool bConcat, string slog, Logger objlogger)
        {
            objlogger.LogInfo("WriteUserInformation : Starts ", GlobalConstants.LOGGERLEVEL1);
            try
            {

                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat);
                //RODataInterface.InterfaceConfigFile = rConfigMgr.LoadConfigurationXML(); //1915
                if (l_oConfig == null)
                {
                    //exception handling
                    objlogger.LogInfo("RequestOneCustomerInterface: ValidateIMF: Error Interface config file not loaded / not found", GlobalConstants.LOGGERLEVEL1);
                }
                else
                {
                    ROErrorLogger RoErrorLogger = new ROErrorLogger();
                    Dictionary<string, string> oAddtionalFields = new Dictionary<string, string>();

                    slifeToken = slifeToken.Replace("||", "\n");
                    //REUBK-1388
                    //slifeToken = slifeToken.Replace(",", "\n\n");
                    slifeToken = slifeToken.Replace("·", "\n\n");

                    //slifeToken = slifeToken.Replace("~", "\n"); REUBK-2266 
                    slifeToken = slifeToken.Replace("¬", "\n");

                    slifeToken = slifeToken.Replace("<<", "<|");
                    slifeToken = slifeToken.Replace(">>", "|>");

                    //get current cquser
                    XElement xCQNode = l_oConfig.Element("CONFIGURATIONS")
                                                     .Element("REQUESTONE").Element("CQ")
                                                     .Element("SERVERS").Elements("SERVER")
                                                     .Where(n => n.FirstAttribute != null
                                                     && n.FirstAttribute.Value == sSystem)
                                                     .Select(n => n).Single();

                    string CQUser = string.Empty;

                    if ((xCQNode.Element("LDAPUSER").Attribute("CQUSERNAME") != null) && (xCQNode.Element("LDAPUSER").Attribute("CQUSERNAME").Value != ""))
                    {
                        CQUser = xCQNode.Element("LDAPUSER").Attribute("CQUSERNAME").Value;

                    }
                    else
                    {
                        CQUser = xCQNode.Element("LDAPUSER").Value;

                    }

                    slifeToken = slifeToken.Replace("CQUSER", CQUser);


                    objlogger.LogInfo("WriteUserInformation-bdata" + bdata.ToString() + " -bConcat" + bConcat.ToString(), GlobalConstants.LOGGERLEVEL1);

                    //objlogger.LogInfo("WriteUserInformation-bConcat" + bConcat.ToString());
                    if (bdata)
                    {
                        objlogger.LogInfo("Life token value =" + slifeToken, GlobalConstants.LOGGERLEVEL1);

                        objlogger.LogInfo("calling WriteInitialLifeToken- data present", GlobalConstants.LOGGERLEVEL1);
                        RoErrorLogger.WriteLifeToken(sExchangeFormat, sExchangeProtocolId,
                              GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), "Log", bAppend, slifeToken, null, sSystem, objlogger, "", slog, bConcat);
                    }
                    else
                    {
                        objlogger.LogInfo("update status only-- lifetoken not reqd", GlobalConstants.LOGGERLEVEL1);
                        string sState = LifeTokenHandler.GetOverallTokenStatus(slifeToken);
                        objlogger.LogInfo("Status =" + sState, GlobalConstants.LOGGERLEVEL1);
                        oAddtionalFields.Add("Status", sState);
                        RoErrorLogger.WriteLifeToken(sExchangeFormat, sExchangeProtocolId,
                        GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), "Log", bAppend, null, oAddtionalFields, sSystem, objlogger, "", slog, bConcat);
                    }

                    PersistenceDataManager l_oPManager = new PersistenceDataManager();

                    l_oPManager.Clear(PersistenceDataStores.LIFETOKEN, sExchangeProtocolId);
                    l_oPManager.Clear(PersistenceDataStores.USERERROR, sExchangeProtocolId);
                    l_oPManager.Clear(PersistenceDataStores.ADMINERROR, sExchangeProtocolId);
                    l_oPManager.Clear(PersistenceDataStores.ROISSUEIMF, sExchangeProtocolId);
                    l_oPManager.Clear(PersistenceDataStores.ROISSUEIMFRESET, sExchangeProtocolId);
                    //REUBK-2136                    
                    l_oPManager.ClearStoreForAttachments(PersistenceDataStores.UNIMPORTEDATTACHMENTS, objlogger);
                }
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "Error in WriteUserInformation ");
            }

            objlogger.LogInfo("WriteUserInformation : Ends", GlobalConstants.LOGGERLEVEL1);
        }


        public string GetInitialValueofXprot(string sExchangeProtocolId, string sExchangeFormat, string sSystem, Logger objlogger)
        {
            string sValue = "";
            try
            {
                ROErrorLogger RoErrorLogger = new ROErrorLogger();
                sValue = RoErrorLogger.GetInitialVal(sExchangeFormat, sExchangeProtocolId, GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), sSystem, "Log", objlogger);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "Error in WriteUserInformation ");
            }

            return sValue;


        }
        public string GetLifeTokenString(string sExchangeProtocolId, string sInterfaceName, Logger objlogger)
        {
            try
            {
                objlogger.LogInfo("GetLifeTokenString : starts", GlobalConstants.LOGGERLEVEL1);
                PersistenceDataManager l_oDm = new PersistenceDataManager();
                return l_oDm.ReadData(PersistenceDataStores.LIFETOKEN, sExchangeProtocolId);
            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }

            return "";
        }

        public string UpdateLifeToken(string sMessage, string sLifeToken, string sIssueFileName, string sStatus = "Failure")
        {
            return LifeTokenHandler.SetTokenStatus(sLifeToken, sIssueFileName, sStatus, sMessage);

        }
        #endregion


        public bool IsValidSchema(XmlDocument xInputDoc)
        {
            // Utilities.objLogger.LogInfo("IsValidSchema :- Starts");
            bool IsValid = true;
            try
            {
                if (!(string.IsNullOrEmpty(xInputDoc.DocumentElement.NamespaceURI.ToString())))
                {
                    if (xInputDoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_BMW310URI)
                    {
                        //Utilities.objLogger.LogInfo("Set IsValid = false");
                        IsValid = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Utilities.objLogger.LogException(ex, "IsValidSchema: Error in checking valid schema");
            }
            //Utilities.objLogger.LogInfo("IsValidSchema :Ends--IsValid=" + IsValid);
            return IsValid;
        }


        public string GetTransactionID(XmlDocument Xdoc, string strExchangeFormat, string strMode, string strDownloadTargetPath, string strIssueFileName, Logger objlogger)
        {
            objlogger.LogInfo("GetTransactionID :- Starts", GlobalConstants.LOGGERLEVEL1);
            string strToReturn = string.Empty;


            XNamespace objname;

            try
            {
                //objlogger.LogInfo("GetTransactionID :- Check if xdoc is null");

                if (Xdoc != null) //1 Declaration Node
                {
                    //objlogger.LogInfo("GetTransactionID :- xdoc not null");
                    if (Xdoc.ChildNodes.Count <= 1)
                    {
                        objlogger.LogInfo("Invalid xml", GlobalConstants.LOGGERLEVEL1);

                        if (File.Exists(strDownloadTargetPath + strIssueFileName))
                        {
                            string strContent = File.ReadAllText(strDownloadTargetPath + strIssueFileName);
                            objlogger.LogInfo("Reading file content as text", GlobalConstants.LOGGERLEVEL1);
                            if (Regex.IsMatch(strContent, "<CATEGORY\\s*>BMW-PROSPR</CATEGORY\\s*>", RegexOptions.Singleline))
                            {
                                objlogger.LogInfo("GetTransactionID :- BMW BMW_PROSPR_REQ workflow", GlobalConstants.LOGGERLEVEL1);
                                strToReturn = strIssueFileName;
                                return strToReturn;
                            }

                            else if(Regex.IsMatch(strContent, "<CATEGORY\\s*>BMW-CC-PROSPR</CATEGORY\\s*>", RegexOptions.Singleline))
                            {
                                objlogger.LogInfo("GetTransactionID :- BMW BMW_PROSPR-CC_REQ workflow", GlobalConstants.LOGGERLEVEL1);
                                strToReturn = strIssueFileName;
                                return strToReturn;
                            }

                           else if (!(strMode.ToUpper().Equals("NORMAL") && Regex.IsMatch(strContent, "<ISSUE-STATE\\s+SI\\s*=\\s*\"\\s*SPECIFIED\\s*\"\\s*>ACCEPTED</ISSUE-STATE\\s*>", RegexOptions.Singleline)))
                            {
                                if (Regex.IsMatch(strContent, "<TRANSACTION-ID\\s*>(?<ID>.*)</TRANSACTION-ID\\s*>", RegexOptions.Singleline))
                                {
                                    Match m = Regex.Match(strContent, "<TRANSACTION-ID\\s*>(?<ID>.*)</TRANSACTION-ID\\s*>", RegexOptions.Singleline);
                                    strToReturn = m.Groups["ID"].Value;
                                }
                            }
                        }
                    }
                    else
                    {

                        //commented for delay reduction
                        /* if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_URI)
                         {
                             objname = GlobalConstants.ASAMFileTags.ASAM_URI;
                         }
                         else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_310MODIFIEDURI)
                         {
                             objname = GlobalConstants.ASAMFileTags.ASAM_310MODIFIEDURI;
                         }
                         else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_311MODIFIEDURI)
                         {
                             objname = GlobalConstants.ASAMFileTags.ASAM_311MODIFIEDURI;
                         }
                         else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_MSGACK)
                         {
                             objname = GlobalConstants.ASAMFileTags.ASAM_MSGACK;
                         }
                         else
                         {
                             objname = GlobalConstants.ASAMFileTags.ASAM_BMW310URI;
                         } */

                        objname = Xdoc.DocumentElement.NamespaceURI.ToString();

                        XDocument xIssuedoc = null;

                        using (var nodeReader = new XmlNodeReader(Xdoc))
                        {
                            nodeReader.MoveToContent();
                            xIssuedoc = XDocument.Load(nodeReader);
                        }

                        objlogger.LogInfo("GetTransactionID :- get l_oelement", GlobalConstants.LOGGERLEVEL1);
                        string workflow = "";
                        XElement workflow_elem = null;
                        try
                        {
                            objlogger.LogInfo("GetTransactionID :- checking workflow", GlobalConstants.LOGGERLEVEL1);
                            //workflow = xIssuedoc.XPathSelectElements("//MSR-ISSUE/CATEGORY").Select(q => q.Value).SingleOrDefault().ToString();
                            workflow_elem= xIssuedoc.Root.Elements(objname + GlobalConstants.ASAMFileTags.CATEGORY).Single();
                            workflow = workflow_elem==null?"":workflow_elem.Value.ToString();
                            if (workflow == "BMW-PROSPR")
                            {
                                objlogger.LogInfo("GetTransactionID :- BMW BMW_PROSPR_REQ workflow", GlobalConstants.LOGGERLEVEL1);
                                strToReturn = strIssueFileName;
                                objlogger.LogInfo("GetTransactionID return value =" + strToReturn, GlobalConstants.LOGGERLEVEL1);
                                return strToReturn;
                            }
                            else if (workflow == "BMW-CC-PROSPR")
                            {
                                objlogger.LogInfo("GetTransactionID :- BMW BMW_PROSPR-CC_REQ workflow", GlobalConstants.LOGGERLEVEL1);
                                strToReturn = strIssueFileName;
                                objlogger.LogInfo("GetTransactionID return value =" + strToReturn, GlobalConstants.LOGGERLEVEL1);
                                return strToReturn;
                            }
                        }
                        catch(Exception ex)
                        {
                            objlogger.LogInfo("GetTransactionID :- error checking  workflow", GlobalConstants.LOGGERLEVEL1);
                        }
                        XElement l_oelement = null;
                        try
                        {
                            l_oelement = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES)
                                              .Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                                              .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).Value == GlobalConstants.ASAMFileTags.ISSUECATEGORYVALUE)
                                              .Elements(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS).Descendants(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                                              .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.COMPANYDATAREF).Value.ToUpper() == GlobalConstants.ASAMFileTags.DAIMLER)
                                              .Single();
                        }
                        catch(Exception ex)
                        {
                             l_oelement = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES)
                                              .Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                                              .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).Attribute(GlobalConstants.ASAMFileTags.LEVEL).Value == GlobalConstants.ASAMFileTags.ISSUECATEGORYVALUE)
                                              .Elements(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS).Descendants(objname + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                                              .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.COMPANYDATAREF).Value.ToUpper() == GlobalConstants.ASAMFileTags.DAIMLER)
                                              .Single();
                        }

                        XElement l_ostate = null;

                        try
                        {
                                l_ostate = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                            .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).Value == GlobalConstants.ASAMFileTags.ISSUECATEGORYVALUE)
                            .Elements(objname + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES).Descendants(objname + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE)
                            .Descendants(objname + GlobalConstants.ASAMFileTags.ISSUESTATE).Single();
                        }
                        catch (Exception ex)
                        {
                                l_ostate = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).Elements(objname + GlobalConstants.ASAMFileTags.ISSUE)
                            .Where(e => e.Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).Attribute(GlobalConstants.ASAMFileTags.LEVEL).Value == GlobalConstants.ASAMFileTags.ISSUECATEGORYVALUE)
                            .Elements(objname + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES).Descendants(objname + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE)
                            .Descendants(objname + GlobalConstants.ASAMFileTags.ISSUESTATE).Single();
                        }
                        //(As part of defect fix of - 569979) 572457 is impltd - the generation of MSG-ACK for SPECIFIED-ACCEPTED will be considered as well.
                        //if (l_ostate.HasAttributes && l_ostate.Attribute(GlobalConstants.ASAMFileTags.SI) != null && l_ostate.Attribute(GlobalConstants.ASAMFileTags.SI).Value.Equals(GlobalConstants.ASAMFileTags.STATESPECIFIED) && l_ostate.Value.Equals(GlobalConstants.ASAMFileTags.STATEACCEPTED) && strMode.ToUpper().Equals("NORMAL"))
                        // {
                        //     strToReturn = "";
                        // }
                        // else if(l_ostate.HasAttributes && l_ostate.Attribute(GlobalConstants.ASAMFileTags.ORIGIN) != null && l_ostate.Attribute(GlobalConstants.ASAMFileTags.ORIGIN).Value.Equals(GlobalConstants.ASAMFileTags.STATESPECIFIED) && l_ostate.Value.Equals(GlobalConstants.ASAMFileTags.STATEACCEPTED) && strMode.ToUpper().Equals("NORMAL"))
                        // {
                        //     strToReturn = "";
                        // }
                        // else
                        // {
                        strToReturn = l_oelement.Element(objname + GlobalConstants.ASAMFileTags.TRANSACTIONID).Value;
                        //}
                    }
                }

                objlogger.LogInfo("GetTransactionID return value =" + strToReturn, GlobalConstants.LOGGERLEVEL1);

            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in GetTransactionID" + ex.Message.ToString());
            }
            return strToReturn;
        }

        /// <summary>
        /// Gets issue state for mapping 
        /// </summary>
        /// <param name="Xdoc"></param>
        /// <param name="strExchangeFormat"></param>
        /// <param name="objlogger"></param>
        /// <returns></returns>
        public string GetIssueStateForMapping(XmlDocument Xdoc, string strExchangeFormat, Logger objlogger)
        {
            objlogger.LogInfo("GetIssueStateForMapping :- Starts", GlobalConstants.LOGGERLEVEL1);
            string strToReturn = string.Empty;
            XNamespace xmlNameSpace;
            try
            {
                if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_MSGACK)
                {
                    strToReturn = GlobalConstants.ASAMFileTags.STATEMSGACK;
                    objlogger.LogInfo("strToReturn:" + strToReturn, GlobalConstants.LOGGERLEVEL1);
                    return strToReturn;
                }
                xmlNameSpace = Xdoc.DocumentElement.NamespaceURI.ToString();
                objlogger.LogInfo("xmlNameSpace:" + xmlNameSpace, GlobalConstants.LOGGERLEVEL1);

                XDocument xIssuedoc = null;
                string strState, strAnnotation, isPilot, strLevel, strSI, strORIGIN ;
                strState = strAnnotation = isPilot = strLevel = strSI = strORIGIN = string.Empty;

                using (var nodeReader = new XmlNodeReader(Xdoc))
                {
                    nodeReader.MoveToContent();
                    xIssuedoc = XDocument.Load(nodeReader);
                }
                strState = CheckIssueStateExists(xIssuedoc, xmlNameSpace, objlogger);
                strAnnotation = CheckIssueAnnotationExists(xIssuedoc, xmlNameSpace, objlogger);
                isPilot = CheckIsPilotExists(xIssuedoc, xmlNameSpace, objlogger);
                strLevel = CheckLevelAttributeExists(xIssuedoc, xmlNameSpace, objlogger);
                strSI = CheckSIAttributeExists(xIssuedoc, xmlNameSpace, objlogger);
                strORIGIN = CheckOriginAttributeExists(xIssuedoc, xmlNameSpace, objlogger);

                objlogger.LogInfo("GetIssueStateForMapping : Annotation=" + strAnnotation
                                                        + "  Ispilot=" + isPilot
                                                        + "  strLevel=" + strLevel
                                                        + "  strSI=" + strSI
                                                        + "  strORIGIN=" + strORIGIN
                                                        + "  ExchangeFormat=" + strExchangeFormat, GlobalConstants.LOGGERLEVEL1);

                strToReturn = GetIssueStateBasedOnAttributes(xIssuedoc,xmlNameSpace, strState, strExchangeFormat, strLevel, 
                    strAnnotation, isPilot,strSI,strORIGIN,objlogger);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetIssueStateForMapping: Error in getting state value");
            }
            return strToReturn;
        }


        private string CheckIssueStateExists(XDocument xIssuedoc,XNamespace xmlNameSpace,Logger objlogger)
        {
            string strState = string.Empty;
            try
            {
                objlogger.LogInfo("Checking ISSUE STATE starts", GlobalConstants.LOGGERLEVEL1);
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Value)))
                {
                    strState = xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Value;
                }
                objlogger.LogInfo("strState:" + strState, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception exState)
            {
                objlogger.LogInfo("GetIssueStateForMapping :-exp in getting state" + exState.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
            return strState;
        }

        private string CheckIssueAnnotationExists(XDocument xIssuedoc, XNamespace xmlNameSpace, Logger objlogger)
        {
            try
            {
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEANNOTATIONS)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEANNOTATION)
                    .FirstAttribute.Value.ToString())))
                {
                    return xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEANNOTATIONS)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEANNOTATION).FirstAttribute.Value.ToString();
                }
            }
            catch (Exception exAnnotation)
            {
                //REUBK-1437: do not log execption as annotation will not be present in some asam files.
                //Utilities.GetLogger(strExchangeFormat).LogInfo("GetIssueStateForMapping :-exp in getting Annotation" + exAnnotation.ToString());
            }
            return string.Empty;
        }

        private string CheckIsPilotExists(XDocument xIssuedoc, XNamespace xmlNameSpace, Logger objlogger)
        {
            try
            {
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.PROJECT_ID).FirstAttribute.Value)))
                {
                    return xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.COMPANYISSUEINFOS)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.COMPANYISSUEINFO)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.PROJECT_ID).FirstAttribute.Value;
                }
            }
            catch (Exception exIspilot)
            {
                //REUBK-1437: do not log execption as ispilot will not be present in some asam files.
                //Utilities.GetLogger(strExchangeFormat).LogInfo("GetIssueStateForMapping :-exp in getting Ispilot" + exIspilot.ToString());
            }
            return string.Empty;
        }

        private string CheckLevelAttributeExists(XDocument xIssuedoc, XNamespace xmlNameSpace, Logger objlogger)
        {
            try
            {
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Attribute(GlobalConstants.ASAMFileTags.LEVEL).Value)))
                {
                    return xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                   .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Attribute(GlobalConstants.ASAMFileTags.LEVEL).Value;
                }
            }
            catch (Exception exLevelAttr)
            {
                // CATEGORY/@LEVEL attribute not present in ASAM file
            }
            return string.Empty;
        }

        private string CheckSIAttributeExists(XDocument xIssuedoc, XNamespace xmlNameSpace, Logger objlogger)
        {
            try
            {
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE).Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Attribute(GlobalConstants.ASAMFileTags.SI).Value)))
                {
                    return xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE).Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Attribute(GlobalConstants.ASAMFileTags.SI).Value;
                }
            }
            catch (Exception exSIAttr)
            {
                // ISSUE-STATE/@SI attribute not present in ASAM file
            }
            return string.Empty;
        }

        private string CheckOriginAttributeExists(XDocument xIssuedoc, XNamespace xmlNameSpace, Logger objlogger)
        {
            try
            {
                if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE).Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Attribute(GlobalConstants.ASAMFileTags.ORIGIN).Value)))
                {
                    return xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUES).
                    Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUE)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUEPROPERTIES)
                    .Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUECURRENTSTATE).Element(xmlNameSpace + GlobalConstants.ASAMFileTags.ISSUESTATE).Attribute(GlobalConstants.ASAMFileTags.ORIGIN).Value;
                }
            }
            catch (Exception exORIGINAttr)
            {
                // ISSUE-STATE/@ORIGIN attribute not present in ASAM file
            }
            return string.Empty;
        }

        private string GetIssueStateBasedOnAttributes(XDocument xIssuedoc,XNamespace xmlNameSpace, string strState,string strExchangeFormat,string strLevel,
            string strAnnotation,string isPilot,string strSI,string strORIGIN,Logger objlogger)
        {
            string strToReturn = string.Empty;
            switch (strState.ToUpper())
            {
                case GlobalConstants.ASAMFileTags.STATEREQUESTED:
                    strToReturn = GetRequestedState(strLevel);
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.BMW))
                    {
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_REQUESTED;
                        }
                        //[1560] code changes start here.
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_REQUESTED;
                        }
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATEREJECTED:
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.AUDI))
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for Audi Rejected", GlobalConstants.LOGGERLEVEL1);
                        switch (strAnnotation.ToUpper())
                        {
                            case GlobalConstants.ASAMFileTags.REJECT_SPECIFIED:
                                objlogger.LogInfo("GetIssueStateForMapping : for Audi SETSTATESPECIFIEDREJECTED", GlobalConstants.LOGGERLEVEL1);
                                strToReturn = GlobalConstants.ASAMFileTags.SETSTATESPECIFIEDREJECTED;
                                break;
                            case GlobalConstants.ASAMFileTags.REJECT_ESTIMATED:
                                if (isPilot.ToUpper() == GlobalConstants.ASAMFileTags.PILOT)
                                {
                                    objlogger.LogInfo("GetIssueStateForMapping : for Audi SETSTATEESTIMATEDPILOTREJECTED", GlobalConstants.LOGGERLEVEL1);
                                    strToReturn = GlobalConstants.ASAMFileTags.SETSTATEESTIMATEDPILOTREJECTED;
                                }
                                else
                                {
                                    objlogger.LogInfo("GetIssueStateForMapping : for Audi SETSTATEESTIMATEDREJECTED", GlobalConstants.LOGGERLEVEL1);
                                    strToReturn = GlobalConstants.ASAMFileTags.SETSTATEESTIMATEDREJECTED;
                                }
                                break;
                        }
                    }
                    else if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.DAIMLER))
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for DAIMLER rejected", GlobalConstants.LOGGERLEVEL1);
                        if (!string.IsNullOrEmpty(strSI))
                        {
                            strToReturn = string.Concat(strSI.ToUpper(), "-", GlobalConstants.ASAMFileTags.STATEREJECTED);
                        }
                        else if (!string.IsNullOrEmpty(strORIGIN))
                        {
                            strToReturn = string.Concat(strORIGIN.ToUpper(), "-", GlobalConstants.ASAMFileTags.SETSTATE320REJECTED);
                        }
                        else
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.STATEREJECTED;
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for BMW Rejected", GlobalConstants.LOGGERLEVEL1);
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_REJECTED;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_REJECTED;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(strLevel))
                            {
                                strToReturn = GlobalConstants.ASAMFileTags.STATEREJECTED;
                            }
                            else
                            {
                                strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320REJECTED;
                            }
                        }
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATEAPPROVED:
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.DAIMLER) && !(string.IsNullOrEmpty(strLevel)))
                    {
                        strToReturn = GlobalConstants.ASAMFileTags.SETSTATESPECIFIEDAPPROVED320;
                    }
                    else
                    {
                        strToReturn = GlobalConstants.ASAMFileTags.SETSTATESPECIFIEDAPPROVED;
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATEACCEPTED:
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.AUDI))
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for AUDI accepted", GlobalConstants.LOGGERLEVEL1);
                        if (isPilot.ToUpper() == GlobalConstants.ASAMFileTags.PILOT)
                        {
                            objlogger.LogInfo("GetIssueStateForMapping : for AUDI SETSTATEESTIMATEDPILOTACCEPTED", GlobalConstants.LOGGERLEVEL1);
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEESTIMATEDPILOTACCEPTED;
                        }
                        else
                        {
                            objlogger.LogInfo("GetIssueStateForMapping : for AUDI SETSTATEESTIMATEDACCEPTED", GlobalConstants.LOGGERLEVEL1);
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEESTIMATEDACCEPTED;
                        }
                    }
                    else if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.DAIMLER))
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for DAIMLER accepted", GlobalConstants.LOGGERLEVEL1);
                        if (!string.IsNullOrEmpty(strSI))
                        {
                            strToReturn = string.Concat(strSI.ToUpper(), "-", GlobalConstants.ASAMFileTags.STATEACCEPTED);
                        }
                        else if (!string.IsNullOrEmpty(strORIGIN))
                        {
                            strToReturn = string.Concat(strORIGIN.ToUpper(), "-", GlobalConstants.ASAMFileTags.SETSTATE320ACCEPTED);
                        }
                        else
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.STATEACCEPTED;
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("GetIssueStateForMapping : for BMW accepted", GlobalConstants.LOGGERLEVEL1);
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_ACCEPTED;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_ACCEPTED;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(strLevel))
                            {
                                strToReturn = GlobalConstants.ASAMFileTags.STATEACCEPTED;
                            }
                            else
                            {
                                strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320ACCEPTED;
                            }
                        }
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATECLOSEDNOTOK:
                    strToReturn = GlobalConstants.ASAMFileTags.SETSTATECLOSEDNOTOK;
                    break;
                case GlobalConstants.ASAMFileTags.STATECLOSEDOK:
                    strToReturn = GlobalConstants.ASAMFileTags.SETSTATECLOSEDOK;
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.BMW))
                    {
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320CLOSEDOK;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320CLOSEDOK;
                        }
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATEINFOUPDATE:
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.DAIMLER) && !(string.IsNullOrEmpty(strLevel)))
                    {
                        strToReturn = GlobalConstants.ASAMFileTags.SETSTATEINFOUPDATE320;
                    }
                    else if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.BMW))
                    {
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEINFOUPDATE_PROSPR;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEINFOUPDATE_PROSPR;
                        }
                        else
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEINFOUPDATE;
                        }
                    }
                    else
                    {
                        strToReturn = GlobalConstants.ASAMFileTags.SETSTATEINFOUPDATE;
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATEPROPOSED:
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.BMW))
                    {
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEPROPOSED_PROSPR;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEPROPOSED_PROSPR;
                        }
                        else
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATEPROPOSED;
                        }
                    }
                    break;
                case GlobalConstants.ASAMFileTags.STATECANCELLED:
                    strToReturn = GetCancelledState(strLevel);
                    if (strExchangeFormat.ToUpper().Contains(GlobalConstants.ASAMFileTags.BMW))
                    {
                        if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_CANCELLED;
                        }
                        else if (xIssuedoc.Root.Element(xmlNameSpace + GlobalConstants.ASAMFileTags.CATEGORY).Value == "BMW-CC-PROSPR")
                        {
                            strToReturn = GlobalConstants.ASAMFileTags.SETSTATE320PROSPR_CANCELLED;
                        }
                    }
                    break;
                default:
                    break;
            }
            objlogger.LogInfo("GetIssueStateForMapping :- return state = " + strToReturn, GlobalConstants.LOGGERLEVEL1);
            return strToReturn;
        }

        /// <summary>
        /// Gets requested state based on level attribute
        /// </summary>
        /// <param name="levelAttribute"></param>
        /// <returns></returns>
        private string GetRequestedState(string levelAttribute)
        {
            if (string.IsNullOrEmpty(levelAttribute))
            {
                return GlobalConstants.ASAMFileTags.STATEREQUESTED;
            }
            else
            {
                return GlobalConstants.ASAMFileTags.SETSTATE320REQUESTED;
            }
        }

        /// <summary>
        /// Gets cancelled state based on level attribute 
        /// </summary>
        /// <param name="levelAttribute"></param>
        /// <returns></returns>
        private string GetCancelledState(string levelAttribute)
        {
            if (string.IsNullOrEmpty(levelAttribute))
            {
                return GlobalConstants.ASAMFileTags.STATECANCELLED;
            }
            else
            {
                return GlobalConstants.ASAMFileTags.SETSTATE320CANCELLED;
            }
        }

        public string GetIssueCategoryForMapping(XmlDocument Xdoc, string strExchangeFormat, Logger objlogger)
        {
            objlogger.LogInfo("GetIssueCategoryForMapping :- Starts", GlobalConstants.LOGGERLEVEL1);
            string strCategory = string.Empty;

            XNamespace objname;

            try
            {
                //commented for delay reduction
                /* if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_URI)
                 {
                     objname = GlobalConstants.ASAMFileTags.ASAM_URI;
                 }
                 else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_310MODIFIEDURI)
                 {
                     objname = GlobalConstants.ASAMFileTags.ASAM_310MODIFIEDURI;
                 }
                 else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_311MODIFIEDURI)
                 {
                     objname = GlobalConstants.ASAMFileTags.ASAM_311MODIFIEDURI;
                 }
                 else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_BMW320URI)
                 {
                     objname = GlobalConstants.ASAMFileTags.ASAM_BMW320URI;
                 }
                 else if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_MSGACK)
                 {
                     strCategory = "SOFTWARE";
                     objlogger.LogInfo("strCategory:" + strCategory);

                     return strCategory;
                 }
                 else
                 {
                     objname = GlobalConstants.ASAMFileTags.ASAM_BMW310URI;
                 } */

                if (Xdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_MSGACK)
                {
                    strCategory = "SOFTWARE";
                    objlogger.LogInfo("strCategory:" + strCategory, GlobalConstants.LOGGERLEVEL1);

                    return strCategory;
                }
                else
                {
                    objname = Xdoc.DocumentElement.NamespaceURI.ToString();
                }

                objlogger.LogInfo("objname:" + objname, GlobalConstants.LOGGERLEVEL1);
                XDocument xIssuedoc = null;

                string strAttCategory = string.Empty;

                using (var nodeReader = new XmlNodeReader(Xdoc))
                {
                    nodeReader.MoveToContent();
                    xIssuedoc = XDocument.Load(nodeReader);
                }
                //objlogger.LogInfo("GetIssueCategoryForMapping :- xIssuedoc=" + xIssuedoc.ToString());

                try
                {
                    // objlogger.LogInfo("Checking ISSUE CATEGORY attr starts");
                    if (xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUE).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).HasAttributes)
                    {
                        //objlogger.LogInfo("Checking ISSUE CATEGORY attr value");
                        strAttCategory = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUE).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUECATEGORY).FirstAttribute.Value;

                        if (strAttCategory.ToUpper() == "HARDWARE")
                        {
                            strCategory = "HARDWARE";
                            // objlogger.LogInfo("strCategory = HARDWARE");
                        }
                        else
                        {
                            strCategory = "SOFTWARE";
                            // objlogger.LogInfo("strCategory = SOFTWARE");
                        }
                    }
                    else
                    {
                        //objlogger.LogInfo("No attr");
                        strCategory = "SOFTWARE";
                    }
                }
                catch (Exception exp)
                {
                    objlogger.LogInfo("GetIssueCategoryForMapping :-exp in getting category" + exp.ToString(), GlobalConstants.LOGGERLEVEL1);
                }


                objlogger.LogInfo("GetIssueCategoryForMapping :- return category = " + strCategory, GlobalConstants.LOGGERLEVEL1);

            }
            catch (Exception ex)
            {

                objlogger.LogException(ex, "GetIssueCategoryForMapping: Error in getting category value");

            }
            return strCategory;
        }

        //method to find the category from Input file for BMW (ASCENT or CodeCraft) 
        public string GetCategoryForBMWfromInpFile(XmlDocument Xdoc, string strExchangeFormat, Logger objlogger)
        {
            objlogger.LogInfo("GetCategoryForBMWfromInpFile :- Starts", GlobalConstants.LOGGERLEVEL1);
            string BMWCategory = string.Empty;
            try
            {
                XDocument xIssuedoc = null;
                using (var nodeReader = new XmlNodeReader(Xdoc))
                {
                    nodeReader.MoveToContent();
                    xIssuedoc = XDocument.Load(nodeReader);
                }
                try
                {
                    foreach (XNode node in xIssuedoc.Root.Nodes())
                    {
                        if (node.ToString().Contains("CATEGORY") && node.ToString().Contains("PROSPR"))
                        {
                            BMWCategory = ((XElement)node).Value.ToString();
                            break;
                        }
                        
                    }
                }
                catch (Exception exp)
                {
                    objlogger.LogInfo("GetCategoryForBMWfromInpFile :-exp in getting category" + exp.ToString(), GlobalConstants.LOGGERLEVEL1);
                }
                objlogger.LogInfo("GetCategoryForBMWfromInpFile :- return category = " + BMWCategory, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "GetCategoryForBMWfromInpFile: Error in getting category value for BMW");
            }
            return BMWCategory;
        }


        public string GetTargetProject(string IssueCategory, XmlDocument xFTP, Logger objlogger, XmlDocument msgIssue)
        {
            objlogger.LogInfo("GetTargetProject :- Starts for" + IssueCategory, GlobalConstants.LOGGERLEVEL1);
            string strTargetProject = string.Empty;
            XNamespace objFTPNamespace = null;

            try
            {

                if (xFTP.DocumentElement.NamespaceURI.ToString() == GlobalConstants.FTPRESULTURI)
                {
                    objFTPNamespace = GlobalConstants.FTPRESULTURI;
                }

                //objlogger.LogInfo("GetTargetProject :- objFTPNamespace:" + objFTPNamespace.ToString());

                XDocument xFTPdoc = null;

                using (var nodeReader = new XmlNodeReader(xFTP))
                {
                    nodeReader.MoveToContent();
                    xFTPdoc = XDocument.Load(nodeReader);
                }

                //objlogger.LogInfo("GetTargetProject :- xFTPdoc:" + xFTPdoc.ToString());
                try
                {
                    // objlogger.LogInfo("GetTargetProject  :- xFTPdoc Root:" + xFTPdoc.Root.Name.ToString());
                    // objlogger.LogInfo("GetTargetProject :- xFTPdoc TARGETPROJECTS:" + xFTPdoc.Root.Element(GlobalConstants.TARGETPROJECTS).Value);


                    IEnumerable<XElement> l_oProjectData = xFTPdoc.Root.Element(GlobalConstants.TARGETPROJECTS)
                                                                .Elements(GlobalConstants.TARGETPROJECT)
                                                                .Where(n => n.Element(GlobalConstants.PROJECTDOMAIN).Value.ToUpper() == IssueCategory.ToUpper())
                                                                .Select(n => n);
                    //  objlogger.LogInfo("GetTargetProject ID");
                    foreach (XElement l_oElement in l_oProjectData)
                    {
                        strTargetProject = l_oElement.Element(GlobalConstants.PROJECTID).Value;
                        //objlogger.LogInfo("GetTargetProject :- strTargetProject:" + strTargetProject);

                        //code added for #[1791] - IMPORT VW DEV: Enable import to a separate pool project for Skoda# by shreya 
                        //if (msgIssue.GetElementsByTagName("SHORT-NAME").Item(0).InnerXml.ToString().ToUpper() == "SKODA")
                        //{
                        //    continue;
                        //}
                        break;
                    }

                }
                catch (Exception exp)
                {
                    objlogger.LogInfo("GetTargetProject :-exp in getting target projectid" + exp.ToString(), GlobalConstants.LOGGERLEVEL1);
                }


                objlogger.LogInfo("GetTargetProject :- return projectid = " + strTargetProject, GlobalConstants.LOGGERLEVEL1);

            }
            catch (Exception ex)
            {

                objlogger.LogException(ex, "GetTargetProject: Error in getting projectid value");

            }
            return strTargetProject;
        }

        public void ClearIsoStoreReset(string sExchangePrtotocolID)
        {
            PersistenceDataManager l_oPManager = new PersistenceDataManager();

            l_oPManager.Clear(PersistenceDataStores.ROISSUEIMFRESET, sExchangePrtotocolID);
        }
        public int GetRestartedFilesCount(string XProtID)
        {
            int iFilesCount = 0;
            try
            {
                PersistenceDataManager l_odm = new PersistenceDataManager();
                iFilesCount = l_odm.GetFileCountofIS(PersistenceDataStores.ROISSUEIMFRESET, XProtID);
            }
            catch
            { }
            return iFilesCount;
        }
        public XmlDocument GetRestartedIMF(string sExchangeProtocolId)
        {
            XmlDocument l_oXDoc = new XmlDocument();

            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                string strData = l_oDataManager.ReadData(PersistenceDataStores.ROISSUEIMFRESET, sExchangeProtocolId);
                l_oXDoc.LoadXml(strData);
            }
            catch (Exception e)
            {
                return null;
            }
            return l_oXDoc;
        }

        public string GetStatusInfoforFile(string sToken, string sIssueFileName, string sInterfaceName, Logger objlogger)
        {
            objlogger.LogInfo("inside GetStatusInfoforFile" + sToken, GlobalConstants.LOGGERLEVEL1);
            string sStatusInfo = LifeTokenHandler.GetTokenMessageForFile(sToken, sIssueFileName);
            objlogger.LogInfo("GetStatusInfoforFile return value=" + sStatusInfo, GlobalConstants.LOGGERLEVEL1);
            return sStatusInfo;
        }

        public string GetStatusforFile(string sToken, string sIssueFileName, string sInterfaceName, Logger objlogger)
        {
            objlogger.LogInfo("inside GetStatusforFile" + sToken, GlobalConstants.LOGGERLEVEL1);
            string sStatus = LifeTokenHandler.GetTokenStatusForFile(sToken, sIssueFileName);
            objlogger.LogInfo("GetStatusForFile return value=" + sStatus, GlobalConstants.LOGGERLEVEL1);
            return sStatus;
        }

        //test for log files
        public string MergeLogFiles(string sInterfaceName)
        {
            string strlogfolder = "D:\\ASAM-IF-IMPORT\\Import\\950 - BTLogs";
            string strlogfilename = sInterfaceName + GlobalConstants.LOG_FILE_PATTERN;
            string sToReturn = string.Empty;

            try
            {
                string[] tmpfiles = Directory.GetFiles(strlogfolder, "*.log");
                string strlogfilenamewox = Path.GetFileNameWithoutExtension(strlogfilename);
                string strextension = Path.GetExtension(strlogfilename);
                FileStream outPutFile = null;
                string PrevFileName = string.Empty;
                List<string> lstguid = new List<string>();

                foreach (string tempFile in tmpfiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tempFile);

                    if (fileName.ToUpper() != strlogfilenamewox.ToUpper())
                    {
                        FileInfo fitemp = new FileInfo(tempFile);
                        FileInfo filog = new FileInfo(strlogfolder + "\\" + strlogfilename);

                        if (fileName.Contains(strlogfilenamewox) && (fileName.Contains('.')))
                        {
                            FileInfo fi = new FileInfo(tempFile);
                            string strdate = fi.CreationTime.ToString();
                            strdate = strdate.Replace(':', '-');
                            strdate = strdate.Replace('.', '-');
                            string strnewfile = strlogfolder + "\\" + strlogfilenamewox + "_" + strdate + strextension;
                            fi.MoveTo(strnewfile);
                        }
                        else if (fileName.Contains(strlogfilenamewox) && (!fileName.StartsWith(sInterfaceName)))
                        {
                            string baseFileName = fileName;
                            if (!PrevFileName.Equals(baseFileName))
                            {
                                lstguid.Add(tempFile);
                                PrevFileName = baseFileName;
                            }
                        }
                    }
                }

                if (lstguid.Count > 0)
                {
                    string strdate = DateTime.Now.ToString();
                    strdate = strdate.Replace(':', '-');
                    strdate = strdate.Replace('.', '-');

                    outPutFile = new FileStream(strlogfolder + "\\" + strlogfilenamewox + "_" + strdate + strextension, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 1048731);

                    //System.Threading.Thread.Sleep(120000);
                    foreach (string tempFile in lstguid)
                    {
                        int bytesRead = 0;
                        byte[] buffer = new byte[1024];
                        FileStream inputTempFile = new FileStream(tempFile, FileMode.OpenOrCreate, FileAccess.Read);

                        while ((bytesRead = inputTempFile.Read(buffer, 0, 1024)) > 0)
                        {
                            outPutFile.Write(buffer, 0, bytesRead);
                        }


                        inputTempFile.Close();
                        File.Delete(tempFile);
                    }
                    outPutFile.Flush();
                    outPutFile.Close();
                }
            }
            catch (Exception ex)
            {
                sToReturn = "Exception in logfilemerge" + ex.Message;
            }
            return sToReturn;
        }



        public XmlDocument SetDefaultValues(XmlDocument XIMF, string sExchangeProtocolId, string sTargetPrj, string strExchangeFormat, bool isMsgAck, Logger objlogger)
        {
            try
            {
                objlogger.LogInfo("SetDefaultValues :- Starts", GlobalConstants.LOGGERLEVEL1);
                if (!isMsgAck)
                {

                    XDocument xIssuedoc = null;
                    string strHistory = string.Empty;
                    string strSetValue = string.Empty;
                    string strSetValue2 = string.Empty;
                    using (var nodeReader = new XmlNodeReader(XIMF))
                    {
                        nodeReader.MoveToContent();
                        xIssuedoc = XDocument.Load(nodeReader);
                    }
                    //objlogger.LogInfo("SetDefaultValues : after getting xdoc");
                    try
                    {
                        strHistory = xIssuedoc.Root.Element(IMFFileTags.RT_ISSUE)
                        .Element(IMFFileTags.ISSUE)
                        .Element(IMFFileTags.EXTERNALHISTORY).Value;

                        //objlogger.LogInfo("SetXProtForExternalHistory-History from map-" + strHistory);

                        if (!(string.IsNullOrEmpty(strHistory)))
                        {
                            strSetValue = strHistory.Replace("<XPROT>", sExchangeProtocolId);
                        }

                        objlogger.LogInfo("SetXProtForExternalHistory: History from map-" + strHistory + " :strSetValue-" + strSetValue, GlobalConstants.LOGGERLEVEL1);

                        xIssuedoc.Root.Element(IMFFileTags.RT_ISSUE)
                            .Element(IMFFileTags.ISSUE)
                            .Element(IMFFileTags.EXTERNALHISTORY).Value = strSetValue;
                    }

                    catch (Exception ex)
                    {

                    }

                    try
                    {
                        //set External History of IRM for DAIMLER
                        foreach (XElement element in xIssuedoc.Descendants(IMFFileTags.IRMAP))
                        {
                            string oem_WorkFlow = xIssuedoc.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO)
                                                         .Element(IMFFileTags.VALEXCONTROLINFO)
                                                         .Element(IMFFileTags.OEMWORKFLOW).Value.ToString().Trim();
                            if (oem_WorkFlow.Contains("DAI_ASAM320_SWRQ")
                                || oem_WorkFlow.Contains("DAI_ASAM320_SWSP"))
                            {
                                if (!(string.IsNullOrEmpty(element.Element(IMFFileTags.EXTERNALHISTORY).Value)))
                                {
                                    strSetValue2 = element.Element(IMFFileTags.EXTERNALHISTORY).Value.Replace("<XPROT>", sExchangeProtocolId);
                                }

                                objlogger.LogInfo("SetXProtForExternalHistory: History from map-" + element.Element(IMFFileTags.EXTERNALHISTORY).Value + " :strSetValue-" + strSetValue2, GlobalConstants.LOGGERLEVEL1);

                                element.Element(IMFFileTags.EXTERNALHISTORY).Value = strSetValue2;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    try
                    {
                        //set External Last Import of Issue for All OEM's
                        foreach (XElement element in xIssuedoc.Descendants(IMFFileTags.ISSUE))
                        {
                            string lastimportdate = element.Element("EXTERNALLASTIMPORTEDDATE").Value.ToString().Trim();
                            if(lastimportdate!=null && lastimportdate!="")
                            {
                                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("de-DE");
                                string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString("MM/dd/yyyy HH:mm:ss", culture);

                                objlogger.LogInfo("Setlastimportdate: lastimportdate for IMF-" + strFormatedDateTime, GlobalConstants.LOGGERLEVEL1);

                                element.Element("EXTERNALLASTIMPORTEDDATE").Value = strFormatedDateTime;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    try
                    {
                        //set External Last Import of IRMAP for Daimler
                        foreach(XElement rt_IRMAPS in xIssuedoc.Descendants(IMFFileTags.RT_IRMAPS))
                        {
                            foreach (XElement irmap in rt_IRMAPS.Descendants(IMFFileTags.IRMAP))
                            {

                                string lastimportdate = irmap.Element("EXTERNALLASTIMPORTEDDATE").Value.ToString().Trim();

                                if (lastimportdate != null && lastimportdate != "")
                                {
                                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("de-DE");
                                    string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString("MM/dd/yyyy HH:mm:ss", culture);

                                    objlogger.LogInfo("Setlastimportdate: lastimportdate for IMF-" + strFormatedDateTime, GlobalConstants.LOGGERLEVEL1);

                                    irmap.Element("EXTERNALLASTIMPORTEDDATE").Value = strFormatedDateTime;
                                    
                                }

                            }
                        }
                            
                    }
                    catch (Exception ex)
                    {
                        objlogger.LogInfo("Error in updating IRAMP last import date", GlobalConstants.LOGGERLEVEL1);
                    }

                    //set BELONGSTOPRJ REUBK-1660
                    objlogger.LogInfo("SetBelongsToPrj for Issue" + sTargetPrj, GlobalConstants.LOGGERLEVEL1);

                    xIssuedoc.Root.Element(IMFFileTags.RT_ISSUE)
                     .Element(IMFFileTags.ISSUE)
                     .Element(IMFFileTags.ISSUE_BELONGSTOPROJECT).Value = sTargetPrj;


                    using (var xmlReader = xIssuedoc.CreateReader())
                    {
                        XIMF.Load(xmlReader);
                    }

                    //objlogger.LogInfo("SetDefaultValues : after getting xml filled");
                }
                else
                {
                    objlogger.LogInfo("SetDefaultValues not required for MSGACK", GlobalConstants.LOGGERLEVEL1);
                }

            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in set default values" + ex.Message);
            }

            objlogger.LogInfo("SetDefaultValues :- Ends", GlobalConstants.LOGGERLEVEL1);
            return XIMF;


        }

        public string Test()
        {
            return "";
        }


        //REUBK-2178


        public XmlDocument AddNamespace(XmlDocument xmldoc)
        {
            XDocument xdoc = null;
            XmlDocument l_oXDocFilled = new XmlDocument();

            using (var nodeReader = new XmlNodeReader(xmldoc))
            {
                nodeReader.MoveToContent();
                xdoc = XDocument.Load(nodeReader);
            }

            XNamespace ns0 = @"http://DBMapper.Schema";

            foreach (XElement xe in xdoc.Root.Elements())
            {
                if (xe.Name == "VWPartnumberMappingsMapping")
                {
                    string sname = xe.Name.ToString();
                    xe.Name = ns0 + sname;
                }
            }

            using (var xmlReader = xdoc.CreateReader())
            {
                l_oXDocFilled.Load(xmlReader);
            }
            return l_oXDocFilled;

        }


        public XmlDocument SetNewLifeTokenForTransferResult(XmlDocument xFTPResultUpdate, Logger objlogger)
        {
            objlogger.LogInfo("inside SetNewLifeTokenForTransferResult", GlobalConstants.LOGGERLEVEL1);
            XDocument xdocResult = null;
            XmlDocument xmldocResult = null;

            try
            {
                xdocResult = ConvertXMLtoXdoc(xFTPResultUpdate);
                string sLifeToken = xdocResult.Element("LifeToken4Files").Value;
                string sLifeTokenNew = string.Empty;
                MatchCollection matchcoll;
                matchcoll = Regex.Matches(sLifeToken, @"([\w]+\.xml)::In Progress\|\|\|\|");
                foreach (Match m in matchcoll)
                {
                    sLifeTokenNew = sLifeTokenNew + m.Value + "·";
                }

                int lindex = sLifeTokenNew.LastIndexOf("·");
                sLifeTokenNew = sLifeTokenNew.Remove(lindex);
                objlogger.LogInfo("sLifeTokenNew=" + sLifeTokenNew, GlobalConstants.LOGGERLEVEL1);
                xdocResult.Root.Element("LifeToken4Files").Value = sLifeTokenNew;

                xmldocResult = ConvertXdocToXML(xdocResult);
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Exception in SetNewLifeTokenForTransferResult");
            }
            return xmldocResult;

        }


        public void UpdateXPROTLog(string sExchangeProtocolId, string sLogValueInitial, string sExchangeFormat, string sSystem, Logger objlogger)
        {
            objlogger.LogInfo("UpdateXPROTLog : Starts ", GlobalConstants.LOGGERLEVEL1);
            try
            {
                string sAttachments = string.Empty;
                MatchCollection matchcoll;

                matchcoll = Regex.Matches(sLogValueInitial, "ATTID(?'Match1'(.*))");
                objlogger.LogInfo("in UpdateXPROTLog : matchcoll= " + matchcoll.Count, GlobalConstants.LOGGERLEVEL1);
                if (matchcoll.Count > 0)
                {
                    foreach (Match m in matchcoll)
                    {
                        if (m.Groups["Match1"].Length != 0)
                        {
                            sAttachments = sAttachments + "ATTID" + m.Groups["Match1"].Value + System.Environment.NewLine;
                        }
                    }
                }
                else
                {
                    objlogger.LogInfo("UpdateXPROTLog : no long name attachments in xprot", GlobalConstants.LOGGERLEVEL1);
                    sAttachments = System.Environment.NewLine; //since blank value is not considered for update
                }

                ROErrorLogger RoErrorLogger = new ROErrorLogger();
                //objlogger.LogInfo("UpdateXPROTLog : call WriteLifeToken");
                RoErrorLogger.WriteLifeToken(sExchangeFormat, sExchangeProtocolId,
                            GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), "Log", false, sAttachments, null, sSystem, objlogger, string.Empty, string.Empty, false);

                objlogger.LogInfo("UpdateXPROTLog : Ends", GlobalConstants.LOGGERLEVEL1);



            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Exception in UpdateXPROTLog");
            }
        }


        public XDocument ConvertXMLtoXdoc(XmlDocument xmldoc)
        {
            XDocument xdoc = null;

            using (var nodeReader = new XmlNodeReader(xmldoc))
            {
                nodeReader.MoveToContent();
                xdoc = XDocument.Load(nodeReader);
            }
            return xdoc;
        }

        public XmlDocument ConvertXdocToXML(XDocument xdoc)
        {
            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(xdoc.ToString());
            return xmldoc;
        }

        public void UnlockRecord(string xprotID, string sInterfaceName, string sSystem, Logger objlogger)
        {
            try
            {
                ROErrorLogger RoErrorLogger = new ROErrorLogger();
                objlogger.LogInfo("inside UnlockRecord : call UnlockRecord", GlobalConstants.LOGGERLEVEL1);
                RoErrorLogger.UnlockRecord(sInterfaceName, xprotID, GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), sSystem, objlogger);
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Exception in UnlockRecord");
            }
        }

        public void AddXProtForLogger(string sXPROTID, Logger objlogger)
        {
            if (!objlogger.sExchangeProtocols.ContainsKey(Thread.CurrentThread.ManagedThreadId))
            {
                objlogger.sExchangeProtocols[Thread.CurrentThread.ManagedThreadId]
                    = sXPROTID;
            }
        }

        public bool CheckForMSGACK(XmlDocument xDoc, Logger objlogger)
        {
            if (xDoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_MSGACK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /* public void SendMailForMSGACK(XmlDocument xmlMSGACK, string sExchangeFormat, string sSystem, string sattPath, string sXProtID, Logger objlogger)
         {
             objlogger.LogInfo("SendMailForMSGACK starts");
             RODataInterface l_oDataInterface = null;
             XNamespace nsAtom = "http://www.w3.org/2005/Atom", cq = "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/";
             try
             {
                 XDocument xMSGACK = ConvertXMLtoXdoc(xmlMSGACK);
                 string sValue = xMSGACK.Root.Element(IMFFileTags.RT_IRMAPS).Element(IMFFileTags.IRMAP).Element(IMFFileTags.IR_LIFECYCLESTATE).Value;

                 objlogger.LogInfo("SendMailForMSGACK sValue:" + sValue);

                 if(!string.IsNullOrEmpty(sValue) && sValue.ToUpper() == "CONFLICTED")
                 {
                     string sQuery = "oslc_cm.query=dbid=%22$IMF.DBID¶%22&rcm.type=Issuereleasemap&oslc_cm.properties=ExternalConversation";
                    
                     Dictionary<string, string> Orc_Params = new Dictionary<string, string>();
                     Orc_Params.Add(OrcParameters.EXCHANGEFORMAT, sExchangeFormat);
                     Orc_Params.Add(OrcParameters.SYSTEM, sSystem);
                     Orc_Params.Add(OrcParameters.ATTACHMENTPATH, sattPath);

                     Query oROmgr = new Query(Orc_Params, objlogger);
                     oROmgr.QueryString = sQuery;
                     l_oDataInterface = 
                      Factory.GetInterface(ROAvailableDataInterfaces.OSLC, Orc_Params[OrcParameters.EXCHANGEFORMAT], null, Orc_Params[OrcParameters.SYSTEM], Orc_Params[OrcParameters.ATTACHMENTPATH], objlogger);

                     XElement xContext = xMSGACK.Root.Element(IMFFileTags.RT_IRMAPS).Element(IMFFileTags.IRMAP);
                     IEnumerable<XElement> IExtConv = xContext.Element("EXTERNALCONVERSATION").Elements("P");
                     IMFManager oIMFmgr = new IMFManager(xMSGACK, objlogger);

                     OSLC_QueryResult l_oQueryResult = l_oDataInterface.Query(oROmgr.Prepare(xContext, oIMFmgr)) as OSLC_QueryResult;
                     XDocument xROdoc = l_oQueryResult.GetRaw() as XDocument;
                     objlogger.LogInfo("xROdoc:" + xROdoc.ToString());

                     string sROExtConv = xROdoc.Root.Element(nsAtom + "entry").Element(nsAtom + "content").Element(cq + "Issuereleasemap").Element(cq + "ExternalConversation").Value;
                     objlogger.LogInfo("sROExtConv:" + sROExtConv);

                     if(!string.IsNullOrEmpty(sROExtConv))
                     {
                         string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                         ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                         XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sExchangeFormat);
                       
                         if (l_oConfig == null)
                         {
                             //exception handling
                             objlogger.LogInfo("SendMailForMSGACK: Error Interface config file not loaded / not found");
                         }
                         else
                         {
                             string sTxnIDval = string.Empty, sErrorCode = string.Empty;
                             //string sMSGACKPattern = @"###\s(([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]:[0-6][0-9])#MSG-ACKNOWLEDGE###[\s\n\r]+\[TRANSACTION-ID=(?<TransactionID>.*?)\][\s\n\r]+(?<ErrorCode>.*)";
                             string sTXPattern = @"\[TRANSACTION-ID=(?<TransactionID>.*?)\]";
                             string TxnID = IExtConv.Elements("P").Where(p => Regex.IsMatch(p.Value,sTXPattern)).Single().Value;
                             sErrorCode = IExtConv.Elements("P").Where(p => !Regex.IsMatch(p.Value, sTXPattern) && !p.Value.Contains("###")).Single().Value;

                             if (Regex.IsMatch(TxnID, sTXPattern))
                             {
                                 Match m = Regex.Match(TxnID, sTXPattern);
                                 sTxnIDval = m.Groups["TransactionID"].Value;
                               
                             }

                             objlogger.LogInfo("TransactionID:" + sTxnIDval +" sErrorCode:"+ sErrorCode);

                             string pattern = @"###\s([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]:[0-6][0-9]#(ESTIMATED|SPECIFIED|INFO-UPDATE|DELIVERED)##(?'Email'(.*?)\@[^#]+)\###[\n\r]+\[TRANSACTION-ID=" + sTxnIDval + @"\]";
                                 //@"\###\s([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]:[0-6][0-9]\#\b(ESTIMATED|SPECIFIED|INFO-UPDATE|DELIVERED)\b\##(?'EMAIL'(.*?)\@\bin.bosch.com\b)";

                             objlogger.LogInfo(" pattern:" + pattern);

                             MatchCollection matches = Regex.Matches(sROExtConv, pattern);
                             if (matches.Count > 0)
                             {
                                 string sMatch = matches[0].Value;
                                 objlogger.LogInfo("sMatch:" + sMatch);

                                 string sMailId = string.Empty;
                                 if (Regex.IsMatch(sMatch, pattern))
                                 {
                                     sMailId = Regex.Match(sMatch, pattern).Groups["Email"].Value;
                                     objlogger.LogInfo("sMailId:" + sMailId);
                                 }
                                 else
                                 {
                                     objlogger.LogInfo("No match");
                                 }

                                 string sBody = "Your last export to Daimler for IRM:" + xContext.Element("DBID").Value + " failed with following error code:" + System.Environment.NewLine + sErrorCode, sSubject = "MSG-ACK alert from " + sSystem + " - XPROT:" + sXProtID;
                                 MailMessage oMail = new MailMessage(sMailId, sMailId, sSubject, sBody);
                                 objlogger.LogInfo("Sending mail");
                                 Utilities.SendMail(l_oConfig, oMail);
                             }
                             else
                             {
                                 //Add error message                                
                             }
                          
                         }

                     }
                 }
                 else 
                 {
                     objlogger.LogInfo("SendMailForMSGACK - No mail trigger required");
                 }
             }
             catch(Exception ex)
             {
                 objlogger.LogInfo("Error in SendMailForMSGACK:"+ex.Message);
             }
             finally
             {
                 if (l_oDataInterface != null) l_oDataInterface.Close();
             }

             objlogger.LogInfo("SendMailForMSGACK ends");
         } */

        #region unused methods
        //these methods are not used 
        public string GetIssueCategoryForMapping(XmlDocument Xdoc)
        {
            //Utilities.objLogger.LogInfo("GetIssueCategoryForMapping :- Starts");
            string strCategory = "";
            XDocument xIssuedoc = null;

            XNamespace objname = GlobalConstants.ASAMFileTags.ASAM_BMW310URI;
            try
            {
                using (var nodeReader = new XmlNodeReader(Xdoc))
                {
                    nodeReader.MoveToContent();
                    xIssuedoc = XDocument.Load(nodeReader);
                }

                try
                {

                    if (!(string.IsNullOrEmpty(xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUE)
                        .Element(objname + GlobalConstants.ASAMFileTags.CATEGORY).Value)))
                    {
                        strCategory = xIssuedoc.Root.Element(objname + GlobalConstants.ASAMFileTags.ISSUES).
                        Element(objname + GlobalConstants.ASAMFileTags.ISSUE)
                        .Element(objname + GlobalConstants.ASAMFileTags.CATEGORY).Value;
                    }
                }
                catch (Exception exCategory)
                {
                    // Utilities.objLogger.LogInfo("GetIssueCategoryForMapping :-exp in getting Category" + exCategory.ToString());
                }
                // Utilities.objLogger.LogInfo("IssueCategory: " + strCategory);
            }
            catch (Exception ex)
            {

                // Utilities.objLogger.LogException(ex, "GetIssueState: Error in getting state values");

            }
            //Utilities.objLogger.LogInfo("GetIssueCategoryForMapping :- Ends");
            return strCategory;
        }

        public void WriteUserInformationOld(string sExchangeProtocolId, string slifeToken, bool bAppend, string sExchangeFormat, string sSystem)
        {
            //Utilities.objLogger.LogInfo("WriteUserErrors : Starts ");
            //try
            //{

            //    string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);
            //    ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath);
            //    RODataInterface.InterfaceConfigFile = rConfigMgr.LoadConfigurationXML();
            //    if (RODataInterface.InterfaceConfigFile == null)
            //    {
            //        //exception handling
            //        Utilities.objLogger.LogInfo("RequestOneCustomerInterface: ValidateIMF: Error Interface config file not loaded / not found");
            //    }
            //    else
            //    {
            //        ROErrorLogger RoErrorLogger = new ROErrorLogger();
            //        Dictionary<string, string> oAddtionalFields = new Dictionary<string, string>();
            //        Utilities.objLogger.LogInfo("Life token value =" + slifeToken);
            //        string sState = LifeTokenHandler.GetOverallTokenStatus(slifeToken);
            //        Utilities.objLogger.LogInfo("Status =" + sState);
            //        oAddtionalFields.Add("Status", sState);
            //        slifeToken = slifeToken.Replace("||", "\n");
            //        slifeToken = slifeToken.Replace(",", "\n\n");
            //        slifeToken = slifeToken.Replace("~", "\n");
            //        RoErrorLogger.WriteLifeToken(sExchangeFormat, sExchangeProtocolId,
            //        GlobalConstants.RORecordTypes.EXCHANGEPROTOCOL.ToString(), "Log", bAppend, slifeToken, oAddtionalFields, sSystem);
            //        PersistenceDataManager l_oPManager = new PersistenceDataManager();

            //        l_oPManager.Clear(PersistenceDataStores.LIFETOKEN, sExchangeProtocolId);
            //        l_oPManager.Clear(PersistenceDataStores.USERERROR, sExchangeProtocolId);
            //        l_oPManager.Clear(PersistenceDataStores.ADMINERROR, sExchangeProtocolId);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Utilities.objLogger.LogException(ex, "Error in WriteUserErrors ");
            //}

            //Utilities.objLogger.LogInfo("WriteUserErrors : Ends");
        }

        public XmlDocument GetDBMappedIMF(string sExchangeProtocolId, Logger objlogger)
        {
            objlogger.LogInfo("GetDBMappedIMF : starts", GlobalConstants.LOGGERLEVEL1);
            XmlDocument l_oXDoc = new XmlDocument();

            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                string strData = l_oDataManager.ReadData(PersistenceDataStores.ROISSUEIMF, sExchangeProtocolId);
                l_oXDoc.LoadXml(strData);
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Error in GetDBMappedIMF");
                return null;
            }
            objlogger.LogInfo("GetDBMappedIMF : ends", GlobalConstants.LOGGERLEVEL1);
            return l_oXDoc;
        }

        public void ModifyIMFForDBMappedValues(string sExchangeProtocolId, XmlDocument xmlDBdoc, XmlDocument xmlIMF, Logger objlogger)
        {
            objlogger.LogInfo("ModifyIMFForDBMappedValues : starts", GlobalConstants.LOGGERLEVEL1);


            // objlogger.LogInfo("ModifyIMFForDBMappedValues : after loading xml");

            XDocument xDBDoc = null;

            Dictionary<string, string> oPartNumbers = new Dictionary<string, string>();
            Dictionary<string, string> oReleaseInfo = new Dictionary<string, string>();

            XNamespace objname;
            try
            {

                if (xmlDBdoc.DocumentElement.NamespaceURI.ToString() == GlobalConstants.DBMAPPERURI)
                {
                    objname = GlobalConstants.ASAMFileTags.ASAM_URI;
                }
                using (var nodeReader = new XmlNodeReader(xmlDBdoc))
                {
                    nodeReader.MoveToContent();
                    xDBDoc = XDocument.Load(nodeReader);
                }
                objlogger.LogInfo("xDBDoc :" + xDBDoc.ToString(), GlobalConstants.LOGGERLEVEL2);

                IEnumerable<XElement> l_oElements
                                = xDBDoc.Root.Elements().Elements("VWPartnumberMappingsMapping");
                foreach (XElement oRecord in l_oElements)
                {
                    oPartNumbers.Add(oRecord.Element("CUSTTN").Value, oRecord.Element("RBTTN").Value);
                    oReleaseInfo.Add(oRecord.Element("RBRELTYPE").Value, oRecord.Element("RBSGBEZ").Value);
                }

                objlogger.LogInfo("calling WriteDBMappedIMF", GlobalConstants.LOGGERLEVEL1);

                WriteDBMappedIMF(xmlIMF, oPartNumbers, oReleaseInfo, sExchangeProtocolId, objlogger);
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Error in ModifyIMFForDBMappedValues");
            }
            objlogger.LogInfo("ModifyIMFForDBMappedValues : ends", GlobalConstants.LOGGERLEVEL1);
        }

        public void WriteDBMappedIMF(XmlDocument xmlIMF, Dictionary<string, string> oPartNumbers, Dictionary<string, string> oReleaseInfo, string sExchangeProtocolId, Logger objlogger)
        {
            objlogger.LogInfo("WriteDBMappedIMF starts", GlobalConstants.LOGGERLEVEL1);
            XNamespace objname;
            string sElementName = "MAPINT2EXT";
            XDocument xIssuedoc = null;

            if (xmlIMF.DocumentElement.NamespaceURI.ToString() == GlobalConstants.ASAMFileTags.ASAM_URI)
            {
                objname = GlobalConstants.ASAMFileTags.ASAM_URI;
            }
            using (var nodeReader = new XmlNodeReader(xmlIMF))
            {
                nodeReader.MoveToContent();
                xIssuedoc = XDocument.Load(nodeReader);

            }
            //populate IRM - Mapping to Derivatives
            IEnumerable<XElement> xIRMaps
                     = xIssuedoc.Root.Elements("RT_IRMAPS").Elements("IRMAP");

            foreach (XElement xIRMap in xIRMaps)
            {
                xIRMap.Element(IMFFileTags.IR_MAPPINGTODERIVATES).Remove();

                XElement xDerivate = new XElement(IMFFileTags.IR_MAPPINGTODERIVATES);
                xIRMap.Add(xDerivate);

                List<XElement> lstSubElements = new List<XElement>();
                foreach (KeyValuePair<string, string> item in oPartNumbers)
                {
                    XElement oxMElement = new XElement(sElementName);
                    oxMElement.Value = item.Value;
                    oxMElement.SetAttributeValue("SI", item.Key);
                    lstSubElements.Add(oxMElement);
                }
                foreach (XElement element in lstSubElements)
                {
                    xIRMap.Element(IMFFileTags.IR_MAPPINGTODERIVATES).Add(element);
                }
            }

            objlogger.LogInfo("after populating irm - mapping to deriatives starts", GlobalConstants.LOGGERLEVEL1);


            //populate Release Title
            //check for structure in ReleaseTitle: TBD
            //IEnumerable<XElement> xRelease
            //         = xIssuedoc.Root.Elements("RT_RELEASES").Elements("RELEASE");


            //XElement xReleaseTitle = xRelease.Elements().Where(x => x.Name == "TITLE").Single();

            //xReleaseTitle.Value = "";

            //add code for isolatedstorage
            IMFManager oIMFmgr = new IMFManager(xIssuedoc, objlogger);
            Dictionary<string, string> OrcParms = new Dictionary<string, string>();
            OrcParms.Add(OrcParameters.XCHANGEPROTOCOLID, sExchangeProtocolId);
            oIMFmgr.WriteToIsolatedStorage(OrcParms, PersistenceDataStores.ROISSUEIMF);
        }

        /// <summary>
        /// Indents the Xml with linebreaks
        /// </summary>
        /// <param name="xmLDoc"></param>
        /// <param name="objlogger"></param>
        /// <returns></returns>
        public XmlDocument PrettyXml(XmlDocument xmLDoc, Logger objlogger)
        {
            try
            {
                objlogger.LogInfo("BTHelper::PrettyXml:Starts", GlobalConstants.LOGGERLEVEL1);
                
                StringBuilder stringBuilder = new StringBuilder();
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = true                                       
                };
                using (XmlWriter writer = XmlWriter.Create(stringBuilder, settings))
                {
                    xmLDoc.Save(writer);
                }                
                xmLDoc.LoadXml(stringBuilder.ToString());
                objlogger.LogInfo("BTHelper::PrettyXml:Ends", GlobalConstants.LOGGERLEVEL1);
                return xmLDoc;
            }
            catch(Exception ex)
            {
                objlogger.LogException(ex, "BTHelper::PrettyXml: Error - ");
                return xmLDoc;
            }
        }
        #endregion
    }
}
