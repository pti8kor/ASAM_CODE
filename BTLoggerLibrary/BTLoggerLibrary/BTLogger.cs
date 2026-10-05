using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;  // for ArrayList
using ClearQuestOleServer;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Threading;

namespace RB.BTLoggerLibrary
{
    //public class Class1
    //{

    //    public bool test()
    //    {
    //        return true;
    //    }
    //}

    /*  public class MyHttpStage : HttpProcessingStage
      {
          public override void ProcessRequest(HttpRequestMessage request)
          {

              request.Headers.Add("OSLC-Core-Version", "2.0");

          }
          public override void ProcessResponse(HttpResponseMessage response)
          {
              Console.WriteLine("ProcessResponse called: {0}",
                  response.StatusCode);
          }

      }*/

    [Serializable]

    public class ROUpdater
    {

        public bool Write2XProt(string dbString, string XProtIDStr, string fieldname, string logText, Logger objlogger)
        {
            string dbSet, dbName;
            string tmpStr = "";
            string returnStr1 = "";
            string returnStr2 = "";
            int XProtID = Convert.ToInt32(XProtIDStr);
            bool result = true;


            Session cqSession = new Session();
            IOAdEntity cqEntity;

            // System.Threading.Thread.Sleep(100); //Let RQ1 release XProt

            //BTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Debug: Step 1");

            // exception handling ...
            dbSet = System.Text.RegularExpressions.Regex.Replace(dbString, "(.*)@.*", "$1");
            dbName = System.Text.RegularExpressions.Regex.Replace(dbString, ".*@(.*)", "$1");

            try
            {
                cqSession.UserLogon("btuser", "", dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu
                // >>>> hier knallt's wenn der aktuell benutzte windows-user nicht als solcher im CQ-Lizenz-Server registriert ist:
                // Abhilfe: BTService einfach unter hlu2si laufen lassen
                cqEntity = cqSession.LoadEntityByDbId("ExchangeProtocol", XProtID);

                tmpStr = cqEntity.GetFieldStringValue(fieldname);
                if (tmpStr != null)
                {
                    tmpStr = tmpStr + "\n" + logText;
                }
                else
                {
                    tmpStr = logText;
                }
                cqSession.EditEntity(cqEntity, "modify");
                returnStr1 = cqEntity.SetFieldValue(fieldname, tmpStr);
                returnStr2 = cqEntity.Validate();
                if (returnStr2 == null)
                {
                    cqEntity.Commit();
                }
                cqSession.SignOff();

            }
            catch (Exception e)
            {
                //Console.WriteLine("{0} Exception caught.", e);
                result = false;
                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Write2Xprot exception: " + e);
            }

            if (cqSession == null)
            {
                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Debug: empty session");
            }

            return result;
        }

        public  string Attach2XProt(string dbString, string XProtIDStr, string fieldname, string dirName, string comFileList, Logger objlogger, string LifeToken4files)
        {
            dbString = "CDG_DEV_INTEGRATION@RQ1ML";

            bool failureOccured = false;
            string failureMessage = "";
            string dlDirPath;
            string dbSet, dbName;
            string returnStr = "";
            string[] fileEntries = new string[] { };
            List<string> lstFiles = new List<string>();
            bool truncationNeeded = false;
            string truncFileName;  // filename truncated to 50 chars
            string orgFileName;

            string upLoadPathName;
            ArrayList filesToDelete = new ArrayList();

            string CQUser = string.Empty;
            string CQPasword = string.Empty;


            int XProtID = Convert.ToInt32(XProtIDStr);
            bool tmpBool;

            //objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : Attach2XProt Session starts " + dbString + "," + XProtIDStr + "," + fieldname + "," + dirName + "," + comFileList + "<-");

            Session cqSession = new Session();

            //objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : Attach2XProt Session instantiated " + dbString + "," + XProtIDStr + "," + fieldname + "," + dirName + "," + comFileList + "<-");
            IOAdEntity cqEntity = null; //REUBK-1786
            IOAdEntity cqTestEntity = null;
            IOAdAttachmentFields cqRdAtts; //cq record Attachments
            IOAdAttachmentField cqAttField, tmpAttField;
            IOAdAttachmentField cqComAttField, tmpComAttField;
            IOAdAttachments cqAttFieldEntries;
            IOAdAttachments cqComAttFieldEntries;
            int cqRdAttsNum, i;
            int attID = 1;
            string attIDStr = "";
            string logStr;
            int GERetries; // GetEntityRetries
            bool entityValid; //did getEntity give back valid result?

            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : Attach2XProt started " + dbString + "," + XProtIDStr + "," + fieldname + "," + dirName + "," + comFileList + "<-");



            // scan download directory first
            dlDirPath = GlobalConstants.FTP_LOCAL_BASE_DIR + dirName + "\\";
            if (Directory.Exists(dlDirPath) == false)
            {
                if(!LifeToken4files.Contains("File Name is not valid"))
                {
                    failureOccured = true;
                    failureMessage = "failure: FTPIssueTransfer Debug Attach2XProt - missing directory - stop XProt";
                    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Debug Attach2XProt: missing directory");
                    return failureMessage;
                }
                
            }

            if (Directory.Exists(dlDirPath))
            {
                    fileEntries = Directory.GetFiles(dlDirPath);

                    lstFiles = fileEntries.ToList<string>();
            }
            
            

            if (fileEntries.Length == 0)
            {
                failureOccured = true;
                failureMessage = "failure: FTPIssueTransfer Debug Attach2XProt - missing files - stop XProt";
                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Debug Attach2XProt: missing files");
                return failureMessage;
            }
            else
            {
                //setup RO-Connection
                dbSet = System.Text.RegularExpressions.Regex.Replace(dbString, "(.*)@.*", "$1");
                dbName = System.Text.RegularExpressions.Regex.Replace(dbString, ".*@(.*)", "$1");
                try
                {
                    //REUBK:2073

                    //switch (dbString)
                    //{
                    //    case "CDG_DEV_INTEGRATION@RQ1ML":
                    //        cqSession.UserLogon("BizTalk", "bt4dev01", dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu
                    //        break;
                    //    case "RQ1_ACCEPTANCE@RQONE":
                    //        cqSession.UserLogon("BizTalk", "EAIServ", dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu
                    //        break;
                    //    case "RQ1_PRODUCTIVE@RQONE":
                    //        cqSession.UserLogon("BizTalk", "EAIServ", dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu
                    //        break;
                    //    default:
                    //        cqSession.UserLogon("BizTalk", "EAIServ", dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu
                    //        break;
                    //}

                    try
                    {
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : Attach2XProt-calling Load Config file");

                        XDocument xconfig = LoadConfigurationXML(GlobalConstants.CONF_FILE, objlogger);
                        XElement xCQNode = xconfig.Element("CONFIGURATIONS")
                                                             .Element("ROSETTINGS").Element("CQ")
                                                             .Element("SERVERS").Elements("SERVER")
                                                             .Where(n => n.FirstAttribute != null
                                                             && n.FirstAttribute.Value == dbString)
                                                             .Select(n => n).Single();
                        CQUser = xCQNode.Element("LDAPUSER").Value;
                        CQPasword = DecryptString(xCQNode.Element("PASSWORD").Value, "RO");
                        string CQEncryptedPass = xCQNode.Element("PASSWORD").Value;
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :dbNAME " + dbName);
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :dbSet " + dbSet);
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :CQUser " + CQUser);
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :CQPass " + CQEncryptedPass);

                        cqSession.UserLogon(CQUser, CQPasword, dbName, 2, dbSet);  // 2 means PRIVATE_SESSION, s. API docu

                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("{0} Exception caught.", e);
                        failureOccured = true;
                        failureMessage = "failure: FTPIssueTransfer Attach2XProt load config or UserLogon exception: " + e + " - stop XProt";
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + " Attach2XProt load config or UserLogon exception: " + e);
                        return failureMessage;
                    }




                    GERetries = 0;
                    entityValid = false;
                    do
                    {
                        try
                        {
                            cqTestEntity = cqSession.LoadEntityByDbId("ExchangeProtocol", XProtID);
                            entityValid = true;
                            cqTestEntity = null;
                            //cqTestEntity.Revert(); --> this is not needed as we did not edit testentity
                        }
                        catch (Exception e2)
                        {
                            //commented for delay reduction
                            //System.Threading.Thread.Sleep(5000);
                            System.Threading.Thread.Sleep(3000);
                            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt LoadEntity failed for " + XProtIDStr);
                            //just continue

                        }
                        GERetries++;
                    }
                    while ((entityValid == false) && (GERetries < 24)); //REUBK-1786
                    try
                    {

                        cqEntity = cqSession.LoadEntityByDbId("ExchangeProtocol", XProtID);
                    }
                    catch (Exception ex)
                    {
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt exception in loadentity after retry" + ex);
                        failureOccured = true;
                        failureMessage = "failure: Exception in loading Exchange Protocol. Could not find RQ1 ExchangeProtocolID. Please try again";
                        cqSession.SignOff();
                        return failureMessage;
                    }

                    // objlogger.LogInfo("- " + DateTime.Now.ToString("hh.mm.ss.ffffff") + " - Before edit entity");
                    cqSession.EditEntity(cqEntity, "modify");
                    // objlogger.LogInfo("- " + DateTime.Now.ToString("hh.mm.ss.ffffff") + " - After edit entity");
                    //Get Attachment Field
                    cqRdAtts = cqEntity.AttachmentFields;
                    cqRdAttsNum = cqRdAtts.Count;
                    for (i = 0; i < cqRdAttsNum; i++)
                    {
                        object tmpAttachIndex = i;
                        tmpAttField = cqRdAtts.item(ref tmpAttachIndex);
                        if (tmpAttField.fieldname == "ExchangedFiles")
                        {
                            break;
                        }
                    }
                    object attachIndex = i;
                    cqAttField = cqRdAtts.item(ref attachIndex);
                    cqAttFieldEntries = cqAttField.Attachments;
                    //Get Commercial Attachment Field
                    for (i = 0; i < cqRdAttsNum; i++)
                    {
                        object tmpComAttachIndex = i;
                        tmpComAttField = cqRdAtts.item(ref tmpComAttachIndex);
                        if (tmpComAttField.fieldname == "ExchangedCommercialFiles")
                        {
                            break;
                        }
                    }
                    object comAttachIndex = i;
                    cqComAttField = cqRdAtts.item(ref comAttachIndex);
                    cqComAttFieldEntries = cqComAttField.Attachments;
                    if ((cqAttField == null) || (cqComAttField == null))
                    {
                        failureOccured = true;
                        failureMessage = "failure: FTPIssueTransfer Attach2XProt attachment field(s) not found - stop XProt";
                        cqEntity.Revert();
                        cqSession.SignOff();
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt attachment field not found");
                        return failureMessage;
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("{0} Exception caught.", e);
                    failureOccured = true;
                    failureMessage = "failure: FTPIssueTransfer Attach2XProt login exception: " + e + " - stop XProt";
                    cqSession.SignOff();
                    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt login exception: " + e);
                    return failureMessage;
                }

                if (failureOccured == false)
                {
                    //Festlegung : Directory / Filname = Path

                    foreach (string pathName in fileEntries)  //filePath contains complete directory and filename!!!
                    {

                        orgFileName = Path.GetFileName(pathName);

                        // check filename length constraint first
                        //if (utf8Length(orgFileName) > 50)
                        if (utf8Length(orgFileName) > GlobalConstants.MAX_ATTNAMELENGTH)
                        {
                            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : truncation needed for " + orgFileName);
                            truncationNeeded = true;

                            dirName = Path.GetDirectoryName(pathName);
                            truncFileName = utf8Trunc(orgFileName);
                            truncFileName = ReduceCharacters(truncFileName, attID);

                            //objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "truncFileName=" + truncFileName);

                            //commented as shortname with trunc convention is not allowed
                            //foreach (string path in lstFiles)
                            //{
                            //    string sname = Path.GetFileName(path);
                            //    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "from list name=" + sname);
                            //    if (sname == truncFileName)
                            //    {
                            //        bmatch = true;
                            //        break;
                            //    }
                            //    else
                            //    {
                            //        continue;
                            //    }
                            //}
                            //if (bmatch)
                            //{
                            //    failureOccured = true;


                            //    failureMessage = "failure: FTPIssueTransfer Import failed due to availability of attachments which resemble truncated filename convention of RQ1 - stop XProt";
                            //    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer trunc attachment of " + orgFileName + "is present - stop XProt");
                            //    cqEntity.Revert();
                            //    cqSession.SignOff();
                            //    return failureMessage;

                            //}
                            upLoadPathName = dirName + "\\" + truncFileName;

                            //copy file, rename it with truncFileName and delete it after upload
                            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : truncPathName = " + upLoadPathName);

                            //System.IO.File.Copy(pathName, upLoadPathName, true);

                            if (!(File.Exists(upLoadPathName)))
                            {
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : trunc file not there - copy");
                                File.Copy(pathName, upLoadPathName, true);
                            }
                            //else
                            //{
                            //    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : trunc file is ther -rename and copy");
                            //    truncFileName = ReduceCharacters(truncFileName, attID);
                            //    upLoadPathName = dirName + "\\" + truncFileName;
                            //    objlogger.LogInfo("renamed trunc file" + upLoadPathName);
                            //    File.Copy(pathName, upLoadPathName, true);
                            //}




                            filesToDelete.Add(upLoadPathName);

                            attIDStr = string.Format("ATTID{0:000}", attID);
                            attID++;
                        }
                        else
                        {

                            bool bistruncatedfile = false;
                            //if (utf8Length(orgFileName) == 50)
                            if (utf8Length(orgFileName) == GlobalConstants.MAX_ATTNAMELENGTH)
                            {
                                bistruncatedfile = isTruncFile(pathName);
                            }
                            if (bistruncatedfile)
                            {
                                failureOccured = true;
                                failureMessage = "failure: FTPIssueTransfer Import failed due to availability of attachments which resemble truncated filename convention of RQ1 - stop XProt";
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer trunc attachment of " + orgFileName + "is present - stop XProt");
                                cqEntity.Revert();
                                cqSession.SignOff();
                                return failureMessage;
                            }
                            else
                            {
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 2");
                                truncationNeeded = false;
                                upLoadPathName = pathName;
                            }


                        }

                        try
                        {
                            if (truncationNeeded)
                            {
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 3");
                                if (!comFileList.Contains(orgFileName))
                                {
                                    tmpBool = cqAttFieldEntries.Add(upLoadPathName, attIDStr + " added by BizTalk on " + System.String.Format("{0:dd.MM.yyyy-HH.mm.ss}", System.DateTime.Now));
                                }
                                else
                                {
                                    tmpBool = cqComAttFieldEntries.Add(upLoadPathName, attIDStr + " added by BizTalk on " + System.String.Format("{0:dd.MM.yyyy-HH.mm.ss}", System.DateTime.Now));
                                }
                                logStr = cqEntity.GetFieldStringValue("Log");
                                logStr = logStr + "\n" + attIDStr + " fullname : " + Path.GetFileName(pathName);
                                returnStr = cqEntity.SetFieldValue("Log", logStr);
                            }
                            else
                            {
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 4");
                                if (!comFileList.Contains(orgFileName))
                                {
                                    tmpBool = cqAttFieldEntries.Add(upLoadPathName, "added by BizTalk on " + System.String.Format("{0:dd.MM.yyyy-HH.mm.ss}", System.DateTime.Now));
                                }
                                else
                                {
                                    tmpBool = cqComAttFieldEntries.Add(upLoadPathName, "added by BizTalk on " + System.String.Format("{0:dd.MM.yyyy-HH.mm.ss}", System.DateTime.Now));
                                }
                            }


                            if (tmpBool == false)
                            {
                                failureOccured = true;
                                failureMessage = "failure: FTPIssueTransfer Attach2XProt add attachment: - stop XProt";
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt: add attachment failed");
                                cqEntity.Revert();
                                cqSession.SignOff();
                                return failureMessage;

                            }
                        }
                        catch (Exception e)
                        {
                            failureOccured = true;
                            failureMessage = "failure: FTPIssueTransfer Att2XProt exception: " + e + " - stop XProt";
                            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Att2XProt exception: " + e + " - stop XProt");
                            cqEntity.Revert();
                            cqSession.SignOff();
                            return failureMessage;
                        }


                    }
                    objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 6");

                    try
                    {
                        //Set OPMODE & OPCONTEXT
                        try
                        {
                            cqEntity.SetFieldValue("OperationMode", "ASAM-IMPORT");
                            cqEntity.SetFieldValue("OperationContext", "BizTalk");
                        }
                        catch (Exception ex)
                        {
                            objlogger.LogInfo(ex.Message);
                        }
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Entered Validate Command");
                        returnStr = cqEntity.Validate();
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Exited Validate Command");
                        //objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 7");
                        try
                        {
                            if (returnStr == null)
                            {
                                //Thread.Sleep(10000); //removed on 27.05.2011
                               objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "retrn strng is null");

                                cqEntity.Commit();

                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + " CQ Commited");

                            }
                            else
                            {
                                failureOccured = true;
                                failureMessage = "failure: validation error: " + returnStr + " - stop XProt";
                                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Att2XProt - validation error: " + returnStr);
                                cqEntity.Revert();
                                cqSession.SignOff();
                                return failureMessage;
                            }
                        }
                        catch(Exception e)
                        {
                            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + e.Message);
                        }
                        
                    }
                    catch (Exception e)
                    {
                        failureOccured = true;
                        failureMessage = "failure: FTPIssueTransfer Att2XProt exception : validate or commit: " + e + " - stop XProt";
                        objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Att2XProt exception commit: " + e + " - stop XProt - 8");
                        cqEntity.Revert();
                        return failureMessage;
                    }


                    cqSession.SignOff();

                    //objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Attach2XProt : 8");


                    foreach (string dPathName in filesToDelete)
                    {
                        System.IO.File.Delete(dPathName);
                    }


                }
            }

            if (cqSession == null)
            {
                objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer Debug: empty session");
            }

            objlogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Almost completed");
            //end of method
            return failureMessage;
        }

        public bool isTruncFile(string pathName)
        {
            bool breturn = false;

            string filename = Path.GetFileName(pathName);
            string filenamewoextn = Path.GetFileNameWithoutExtension(pathName);

            var matchcollatttach = Regex.Matches(filenamewoextn, "~\\d+");
            foreach (Match m in matchcollatttach)
            {
                if (filenamewoextn.EndsWith(m.Value))
                {
                    breturn = true;
                    break;
                }
            }
            return breturn;
        }

        public int utf8Length(string fileName)
        {
            int len;
            byte[] byteStream;

            byteStream = Encoding.UTF8.GetBytes(fileName);
            len = byteStream.GetUpperBound(0);
            return len + 1;
        }

        public string utf8Trunc(string fileName)
        {
            int i;
            string truncTry;
            string fileBody, fileExtender;

            fileBody = System.Text.RegularExpressions.Regex.Replace(fileName, "(.+)\\.\\w*?$", "$1");
            fileExtender = System.Text.RegularExpressions.Regex.Replace(fileName, ".+(\\.\\w*?)$", "$1");

            //iteratively compose truncFileName
            //2 byte Umlaute shall not be cut in midth
            i = 0; // how many chars shall be removed
            do
            {
                i++;
                truncTry = fileBody.Substring(0, fileBody.Length - i) + fileExtender; //subtract chars
            } while (utf8Length(truncTry) > GlobalConstants.MAX_ATTNAMELENGTH);
            //while (utf8Length(truncTry) > 50);

            truncTry = fileBody.Substring(0, fileBody.Length - i - 1) + "~" + fileExtender;

            return truncTry;
        }

        public string ReduceCharacters(string fileName, int count)
        {
            string fileBody, fileExtender, sreturn = string.Empty;
            fileBody = System.Text.RegularExpressions.Regex.Replace(fileName, "(.+)\\.\\w*?$", "$1");
            fileExtender = System.Text.RegularExpressions.Regex.Replace(fileName, ".+(\\.\\w*?)$", "$1");

            if (count > 0)
            {
                sreturn = fileBody.Substring(0, fileBody.Length - 2) + "~" + count.ToString() + fileExtender;
            }
            if (count >= 10)
            {
                sreturn = fileBody.Substring(0, fileBody.Length - 3) + "~" + count.ToString() + fileExtender;
            }
            if (count >= 100)
            {
                sreturn = fileBody.Substring(0, fileBody.Length - 4) + "~" + count.ToString() + fileExtender;
            }

            return sreturn;

        }

        public XDocument LoadConfigurationXML(string ConfigXMLPath, Logger objlogger)
        {

            XDocument xConfigXML = null;
            try
            {

                if (ConfigXMLPath.Length > 0)
                {
                    if (System.IO.File.Exists(ConfigXMLPath) == true)
                    {
                        //File RecordCount, start processing

                        xConfigXML = XDocument.Load(ConfigXMLPath);
                        if (xConfigXML == null)
                        {
                            objlogger.LogException(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Config xml file is null");
                        }
                    }
                }
                else
                {
                    objlogger.LogException(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Config filepath not found");
                }
            }
            catch (Exception ex)
            {
                xConfigXML = null;
                objlogger.LogException(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Exception in LoadConfigurationXML" + ex.Message);
            }
            finally
            {

            }

            return xConfigXML;
        }

        private static string DecryptString(string Message, string Passphrase) //REUBK-1741
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            // Step 1. We hash the passphrase using MD5 
            // We use the MD5 hash generator as the result is a 128 bit byte array 
            // which is a valid length for the TripleDES encoder we use below 
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();

            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            // Step 2. Create a new TripleDESCryptoServiceProvider object 

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder 

            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[] 

            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string 

            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information 
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format 
            return UTF8.GetString(Results);
        }


    }

    [Serializable]
    public class GlobalConstants
    {
        public const string LOG_FILE = "D:\\ASAM-IF-IMPORT\\Import\\950 - BTLogs\\current-FTP-LOG.txt";
        public const string FTP_LOCAL_BASE_DIR = "D:\\ASAM-IF-IMPORT\\Import\\010 - TransferedFiles\\";
        public const string CONF_FILE = "D:\\ASAM-IF-IMPORT\\Import\\910 - BTConfigurations\\BT_FTP_Config.xml";
        public const int MAX_ATTNAMELENGTH = 137;
    }

    [Serializable]
    public class BTLogger
    {
        public string GetInstanceID()
        {
            try
            {
                return Microsoft.XLANGs.Core.Service.RootService.InstanceId.ToString();
            }
            catch (Exception exc)
            {
                return "Exception returning instance ID: " + exc.Message;
            }
        }


        public bool WriteLog(string logLine, string InstanceId)
        {

            string logfilepath = "D:\\ASAM-IF-IMPORT\\Import\\950 - BTLogs\\" + "FTP-LOG_" + InstanceId + ".txt";

            if (!File.Exists(logfilepath))
            {
                // Create a file to write to.
                using (StreamWriter tw = File.CreateText(logfilepath))
                {
                    //tw.WriteLine(logLine); // initial entry
                    tw.Close();
                }
            }

            using (StreamWriter tw = File.AppendText(logfilepath))
            {
                //tw.WriteLine(InstanceId + ":" + logLine);
                tw.WriteLine(logLine);
                tw.Close();
            }



            return true;
        }


        public void WriteLog(string logLine, Logger objlogger)
        {
            objlogger.LogInfo(logLine);
        }

        public void WriteLogException(Exception ex,Logger objlogger)
        {
            objlogger.LogException(ex);
        }
        public bool WriteLogOld(string logLine)
        {


            if (!File.Exists(GlobalConstants.LOG_FILE))
            {
                // Create a file to write to.
                using (StreamWriter tw = File.CreateText(GlobalConstants.LOG_FILE))
                {
                    //tw.WriteLine(logLine); // initial entry
                    tw.Close();
                }
            }

            using (StreamWriter tw = File.AppendText(GlobalConstants.LOG_FILE))
            {
                tw.WriteLine(logLine);
                tw.Close();
            }



            return true;
        }


        public bool WriteLogToBTXProt(string logText)
        {

            //System.ServiceModel.


            TextWriter tw = new StreamWriter(GlobalConstants.LOG_FILE);

            tw.WriteLine(logText);

            tw.Close();

            return true;
        }



        public string InsertAllTokenStatus(string tokenStr, string status, string type)
        {


            
            string modStr = string.Empty;

            if(type.ToLower() == "export")
            {
                modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, ",", "::" + status + "||||");
            }

            else
            {
                tokenStr = tokenStr.Replace(",", "·"); //REUBK-1388
                // \\w statt \\S verwenden, da sonst .xml nur einmal gematched wird:
                modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(\\w+\\.xml)", "$1::" + status + "||||");
            }
            


            return modStr;
        }

        public string GetFileNameWithoutExtn(string sCompletename)
        {
            string fileBody = string.Empty;
            fileBody = System.Text.RegularExpressions.Regex.Replace(sCompletename, "(.+)\\.\\w*?$", "$1");
            string fileExtender = System.Text.RegularExpressions.Regex.Replace(sCompletename, ".+(\\.\\w*?)$", "$1");
            return fileBody;
        }


        public string ChangeFileNameInToken(string tokenStr, string filename)
        {
            string modStr = tokenStr;

            string newFileName = GetFileNameWithoutExtn(filename) + "_M.xml";

            modStr = tokenStr.Replace(filename, newFileName);
            return modStr;
        }

        public string SetAllTokenStatus(string tokenStr, string status, string message)
        {
            string modStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            string UserAndDateTime = SetTokenActionStampForFile();

            //modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(\\w+\\.xml::)[^\\|]+\\|\\|[^\\|]*\\|\\|,", "$1" + status + "||" + message + "||,");
            modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(\\w+\\.xml::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + UserAndDateTime + "||" + message + "||·");//REUBK-1884

            //modStr = System.Text.RegularExpressions.Regex.Replace(modStr, ",$", "");
            modStr = System.Text.RegularExpressions.Regex.Replace(modStr, "·$", "");//REUBK-1388 tBC


            return modStr;
        }


        public string SetTokenStatus(string tokenStr, string filename, string status, string message)
        {

            string modStr;

            //REUBK-2826
            //string AddedBy = " >>DATETIME - CQUSER<<";
            //AddedBy = AddedBy.Replace("DATETIME", System.String.Format("{0:dd.MM.yyyy HH.mm.ss}", System.DateTime.Now));

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            string UserAndDateTime = SetTokenActionStampForFile();
            //REUBK-2826
            if (System.Text.RegularExpressions.Regex.IsMatch(tokenStr, filename + "::.+") && status.ToUpper() == "FAILURE")
            {
                
                modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + UserAndDateTime + "||" + message + "||·");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tokenStr, filename + "::.+"))
            {
                modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + "||" + message + "||·");

            }
            else if(!filename.Contains(".xml") && message.Contains("File Name is not valid") && status.ToUpper() == "FAILURE")
            {
                modStr = tokenStr.Trim() +":"+":"+  status + UserAndDateTime + "File Name is not valid. Please provide file with .xml extension.";
            }
            else
            {
                modStr = tokenStr;
            }


            //if (System.Text.RegularExpressions.Regex.IsMatch(tokenStr, filename + "::.+"))
            //{
            //    modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + "||" + message + "||·");

            //}
            //else
            //{
            //    modStr = tokenStr;
            //}

            //modStr = System.Text.RegularExpressions.Regex.Replace(modStr, ",$", "");
            modStr = System.Text.RegularExpressions.Regex.Replace(modStr, "·$", "");//REUBK-1388 tBC


            return modStr;
        }

        public static string SetTokenActionStampForFile()
        {
            string AddedBy = " >>DATETIME - CQUSER<<";
            AddedBy = AddedBy.Replace("DATETIME", System.String.Format("{0:dd.MM.yyyy HH.mm.ss}", System.DateTime.Now));
            return AddedBy;
        }


        //RUEBK-2945
        /*   public string SetUpdatedFileNameForToken(string tokenstr, string fileName, string updatedFileName)
           {
               string modStr;

               if (tokenstr.Contains(fileName))
               {
                   modStr = tokenstr.Replace(fileName, updatedFileName);
               }
               else
               {
                   modStr = tokenstr;
               }

               return modStr;
           }*/



        public string GetFileName(string tokenStr, string filename)
        {
            string sReturn = filename;

            string sNameWOE = GetFileNameWithoutExtn(filename);
            if (tokenStr.Contains(sNameWOE + "_M.xml"))
            {
                sReturn = sNameWOE + "_M.xml";

            }
            return sReturn;
        }

        public string GetTokenStatusForFile(string tokenStr, string filename)
        {

            string statusStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";//REUBK-2826

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);

            //string pattern = filename + @"::([^\|]+)\|\|[^\|]*\|\|·";
            if (match.Success)
            {
                statusStr = match.Groups[1].Value;
            }
            else
            {
                statusStr = "failure:status not found";
            }


            return statusStr;
        }



        public string GetTokenMessageForFile(string tokenStr, string filename)
        {

            string messageStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            //string pattern = filename + @"::[^\|]+\|\|([^\|]*)\|\|·";

            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";//REUBK-2826
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);

            if (match.Success)
            {
                messageStr = match.Groups[3].Value;
            }
            else
            {
                messageStr = "failure:message not found";
            }


            return messageStr;
        }

        public static string GetTokenActionStampForFile(string tokenStr, string filename)
        {
            string UserandDateTime;

            tokenStr = tokenStr + "·";

            //REUBK-2826
            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);

            if (match.Success)
            {
                UserandDateTime = match.Groups[2].Value;
            }
            else
            {
                UserandDateTime = "failure:message not found";
            }

            return UserandDateTime;

        }

        public string GetOverallTokenStatus(string tokenStr)
        {
            string overallStatus;

            //> alle "In Work" > Failure gibts nicht einmal
            //> alle "Failure" > In Work gibts nicht einmal
            //> zT "Failure"

            if (!System.Text.RegularExpressions.Regex.IsMatch(tokenStr, "::Failure"))
            {
                overallStatus = "In Progress";
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(tokenStr, "::In Progress"))
                {
                    overallStatus = "Failure";
                }
                else
                {
                    overallStatus = "Incomplete";
                }
            }

            return overallStatus;
        }

        public string FilterTokenStatus(string tokenStr, string statusStr)
        {
            // takes LifeTokenString and returns the same but only entries fitting to status given in statusStr
            string filteredToken = "";

            string pattern = @"([\w-]+\.xml::Success\|\|[^\|]*\|\|)";

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern);
            while (match.Success)
            {
                filteredToken = filteredToken + match.Groups[1].Value + "·";
                match = match.NextMatch();
            }

            filteredToken = System.Text.RegularExpressions.Regex.Replace(filteredToken, "·$", "");

            return filteredToken;
        }

        public string ExtractFilenamesFromToken(string tokenStr)
        {
            // takes LifeTokenString and returns the same but only entries fitting to status given in statusStr
            string fileNames;

            fileNames = System.Text.RegularExpressions.Regex.Replace(tokenStr, "::\\w*\\|\\|[^\\|]*\\|\\|", "");
            fileNames = System.Text.RegularExpressions.Regex.Replace(fileNames, "·", "\n");

            return fileNames;
        }

        /*   public bool SendJSonRequest(string urlString)
           {

               string tmpStr;
               Stream srm;
               StreamReader srmRd;



               //http://fe0vm221.de.bosch.com/cqweb/oslc/repo/CDG_DEV_KUHLMANN/discovery

               using (HttpClient client = new HttpClient("http://fe0vm221.de.bosch.com/"))
               {

                   client.TransportSettings.Credentials = new NetworkCredential("admin", "");


                   // Getting the response as a string  

                   // Adding OSCL-Header:
                   client.Stages.Add(new MyHttpStage());
                   client.DefaultHeaders.Accept.AddString("application/rdf+xml");

                   using (HttpResponseMessage response = client.Get("/cqweb/oslc/repo/CDG_DEV_KUHLMANN/db/RQ1KD/record/16777243-33603825"))
                   {

                       response.EnsureStatusIsSuccessful();
                       tmpStr = response.Content.ReadAsString();
                       //srm = response.Content.ReadAsStream();
                       //srmRd = new StreamReader(srm);
                       //tmpStr = srmRd.ReadToEnd();
                       //Console.WriteLine(tmpStr);
                   }
                   Console.WriteLine();

                   return true;
               }

           }*/



        #region Logger
        public Logger GetLogger(string sExchangeFormat, string sXPROT, string type)
        {
            Logger objlogger = null;
            if(type.ToLower() == "import")
            {
                 objlogger = Logger.GetLoggerInstanceForImport(sExchangeFormat, sXPROT);
            }
            else
            {
                objlogger = Logger.GetLoggerInstanceForExport(sExchangeFormat, sXPROT);
            }

            
            return objlogger;
        }

        public void CloseLogger(Logger objlogger)
        {
            //No need to close the handler as it is done just after using the stream.
            //Method not removed purposely - monitor [791] defect. After monitoring,remove the method and references
            //objlogger.CloseHandler();
        }

        #endregion

    }

    [Serializable]
    public class Logger : ISerializable
    {
        //[SecurityPermissionAttribute(
        //        SecurityAction.Demand,
        //        SerializationFormatter = true)]

        void ISerializable.GetObjectData(
        SerializationInfo info, StreamingContext context)
        {
            // Instead of serializing this object, 
            // serialize a SingletonSerializationHelp instead.
            info.SetType(typeof(Logger));
            // No other values need to be added.
        }
        /// <summary>
        /// The ISerializable interface implies a constructor with the 
        /// signature constructor (SerializationInfo information, StreamingContext context). 
        /// At deserialization time, the current constructor is called only after the data in the 
        /// SerializationInfo has been deserialized by the formatter. 
        /// In general, this constructor should be protected if the class is not sealed.
        /// If not added, SerializationException is occurred in scope of orchestrations
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Logger(SerializationInfo info,
               StreamingContext context)
        {

        }
        public Logger(string sConfigPath)
        {
            ConfigPath = sConfigPath;
        }
        public string ConfigPath { get; set; }

        public void LogException(Exception ex)
        {
            try
            {
                string strStackTrace = ex.StackTrace.ToString();
                string sDetail = strStackTrace + ex.ToString();
                StreamWriter LWHandle = SetLogHandler(ConfigPath);
                LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                LWHandle.Close();
                LWHandle.Dispose();
            }
            catch (Exception exp)
            {
                
            }
        }
        public void LogException(Exception ex, string strMessage)
        {
            try
            {
                string strStackTrace = ex.StackTrace.ToString();
                string sDetail = strStackTrace + ex.Message.ToString();
                sDetail = sDetail + "Additional Info : " + strMessage;
                StreamWriter LWHandle = SetLogHandler(ConfigPath);
                LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                LWHandle.Close(); 
                LWHandle.Dispose();
            }
            catch (Exception exp)
            {
                
            }

        }

        public void LogInfo(string strMessage)
        {
            try
            {
                StreamWriter LWHandle = SetLogHandler(ConfigPath);
                LWHandle.WriteLine(DateTime.Now.ToString() + strMessage + System.Environment.NewLine);
                LWHandle.Close(); // closing the stream, the buffer is also flushed.
                LWHandle.Dispose(); //to release all resources if any.

            }
            catch (Exception ex)
            {
                
            }
        }

        public void LogException(string strMessage)
        {
            try
            {
                StreamWriter LWHandle = SetLogHandler(ConfigPath);
                LWHandle.WriteLine(DateTime.Now.ToString() + strMessage + System.Environment.NewLine);
                LWHandle.Close();
                LWHandle.Dispose();
            }
            catch (Exception ex)
            {
                
            }
        }


        public StreamWriter SetLogHandler(string sConfigPath)
        {
            //write code to create logger file with stream writer obj          
            StreamWriter logwriter = null;
            try
            {
                if (!File.Exists(sConfigPath))
                {
                    logwriter = new StreamWriter(sConfigPath);
                }
                else
                {

                    logwriter = File.AppendText(sConfigPath);
                }
            }
            catch (Exception ex)
            {
                
            }
            return logwriter;
        }

        public static Logger GetLoggerInstanceForImport(string sExchangeFormat, string xprot)
        {
            Logger LogHelperInstance = null;

            string strLogFilePath = string.Empty;

            
            
            strLogFilePath = "D:\\ASAM-IF-IMPORT\\Import\\950 - BTLogs\\";
            
            
            string sPath = sExchangeFormat + "_" + xprot + "_FTP-LOG.txt";

            strLogFilePath = strLogFilePath + sPath;
            LogHelperInstance = new Logger(strLogFilePath);
            return LogHelperInstance;
        }

        public static Logger GetLoggerInstanceForExport(string sExchangeFormat, string xprot)
        {
            Logger LogHelperInstance = null;

            string strLogFilePath = string.Empty;

            strLogFilePath = "D:\\ASAM-IF-EXPORT\\Export\\950 - BTLogs\\" + xprot +"\\";

            if (!Directory.Exists(strLogFilePath))
            {
                Directory.CreateDirectory(strLogFilePath);
            }

            string sPath = sExchangeFormat + "_" + xprot + "_FTP-LOG.txt";

            strLogFilePath = strLogFilePath + sPath;
            LogHelperInstance = new Logger(strLogFilePath);
            return LogHelperInstance;
        }
    }
}
