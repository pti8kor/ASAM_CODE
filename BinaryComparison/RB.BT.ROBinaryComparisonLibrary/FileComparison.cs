using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Xml.XPath;
using System.Collections;
using System.Data;
using ClearQuestOleServer;
using System.Security.Cryptography;
using System.Configuration;



namespace RB.BT.ROBinaryComparisonLibrary
{
     [Serializable]
    public class FileComparison
    {
        public string CQUser { get; set; }
        public string CQPasword { get; set; }
        public string CQRepo { get; set; }
        public string CQDB { get; set; }
        public string CQWebURL { get; set; }
        public string CQOSLCServer { get; set; }
        public string CQWebRecordFormat { get; set; }
        public string CQOSLCCOREVersion { get; set; }
        public string ROAttachmentPath = "D:\\ASAM-IF-IMPORT\\Import\\090 - TemporaryFiles\\BINARYCOMPARISON\\";
        public string INTERFACE_CONFIG_PATTERN = "_BT_RO_INTERFACE_CONFIG";
        public string RODownloadPath = string.Empty;
        public int CQ_AD_PRIVATE_SESSION = 2;
        public string LOG_FILE = "D:\\ASAM-IF-IMPORT\\Import\\950 - BTLogs\\BinCompare.txt";
      
         public FileComparison()
         {
         }


         public bool WriteLog(string logLine)
         {


             if (!File.Exists(LOG_FILE))
             {
                 // Create a file to write to.
                 using (StreamWriter tw = File.CreateText(LOG_FILE))
                 {
                     //tw.WriteLine(logLine); // initial entry
                     tw.Close();
                 }
             }

             using (StreamWriter tw = File.AppendText(LOG_FILE))
             {
                 tw.WriteLine(logLine);
                 tw.Close();
             }



             return true;
         }


         public bool LoggedIn
         {
             get;
             set;
         }

         public void StartCompare(XmlDocument xmlBinCompareDoc)
         {
             //WriteLog(DateTime.Now.ToString() + "Inside BinaryCompare");
             //XDocument xdc = GetXDocument(xmlBinCompareDoc);

             //WriteLog(DateTime.Now.ToString() + "xmlBinCompareDoc=" + xdc.ToString());

         }

         public string GetStatus(XmlDocument xmldoc)
         {              
             string sStatus = string.Empty;

             XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
             xdoc = GetXDocument(xmldoc);
             try
             {
                 sStatus = xdoc.Root.Element("BinaryComparisonStatus").Value;
             }
             catch (Exception ex)
             {
                 sStatus = "Error: " + ex.Message;
             }
             return sStatus;
         }


         public string TestCompare(XmlDocument xmlBinCompareDoc)
         {
             XDocument xDocBinCompare = new XDocument();

             string sStatus = string.Empty;
             
             bool isMatch = false;

             try
             {
                 xDocBinCompare = GetXDocument(xmlBinCompareDoc);
                 string IMFdownloadpath = xDocBinCompare.Root.Element("DownloadTargetPath").Value;
                 string IMFfilename = xDocBinCompare.Root.Element("ORGFileName").Value;
                 string RQ1TruncFileName = xDocBinCompare.Root.Element("RQ1TruncFileName").Value;
                 string IssueID = xDocBinCompare.Root.Element("IssueID").Value;
                 string InterfaceName = xDocBinCompare.Root.Element("InterfaceName").Value;
                 string SystemKey = xDocBinCompare.Root.Element("RQ1System").Value;
                 string RQ1Desc = xDocBinCompare.Root.Element("RQ1FileDescription").Value;

                 if (!Directory.Exists(ROAttachmentPath + GetInstanceID())) Directory.CreateDirectory(ROAttachmentPath + GetInstanceID());


                 IMFdownloadpath = IMFdownloadpath + IMFfilename;
                 RODownloadPath = ROAttachmentPath + GetInstanceID() + "\\" + RQ1TruncFileName;

                 bool bIsAttLoaded = LoadROAttachments(IssueID, RQ1TruncFileName, RQ1Desc, InterfaceName, SystemKey);



                 if (bIsAttLoaded == false || string.IsNullOrEmpty(RODownloadPath) || (string.IsNullOrEmpty(IMFdownloadpath)))
                 {
                     sStatus = "Error: ROAttachments/IMF attachments could not be downloaded";
                 }
                 else
                 {
                     if (CheckFilesExist(IMFdownloadpath, RODownloadPath))
                     {
                         isMatch = FileEquals(IMFdownloadpath, RODownloadPath);
                         if (isMatch)
                         {
                             sStatus = "Identical";
                         }
                         else
                         {
                             sStatus = "Different";
                         }
                     }
                     else
                     {
                         sStatus = "Error: File does not exists in IMFDownloadPath/RODownloadPath";
                     }
                 }
             }

             catch (Exception ex)
             {
                 sStatus = "Error: " + ex.Message;                
             }
             return sStatus;
         }


         public XmlDocument TestCompareNew(XmlDocument xmlBinCompareDoc)
         {
             XmlDocument xmldoc = new XmlDocument();
             XDocument xDocBinCompare = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));

             string sStatus = string.Empty;

             bool isMatch = false;
             xDocBinCompare = GetXDocument(xmlBinCompareDoc);
             try
             {
                
                 string IMFdownloadpath = xDocBinCompare.Root.Element("DownloadTargetPath").Value;
                 string IMFfilename = xDocBinCompare.Root.Element("ORGFileName").Value;
                 string RQ1TruncFileName = xDocBinCompare.Root.Element("RQ1TruncFileName").Value;
                 string IssueID = xDocBinCompare.Root.Element("IssueID").Value;
                 string InterfaceName = xDocBinCompare.Root.Element("InterfaceName").Value;
                 string SystemKey = xDocBinCompare.Root.Element("RQ1System").Value;
                 string RQ1Desc = xDocBinCompare.Root.Element("RQ1FileDescription").Value;

                 if (!Directory.Exists(ROAttachmentPath + GetInstanceID())) Directory.CreateDirectory(ROAttachmentPath + GetInstanceID());


                 IMFdownloadpath = IMFdownloadpath + IMFfilename;
                 RODownloadPath = ROAttachmentPath + GetInstanceID() + "\\" + RQ1TruncFileName;

                 bool bIsAttLoaded = LoadROAttachments(IssueID, RQ1TruncFileName, RQ1Desc, InterfaceName, SystemKey);



                 if (bIsAttLoaded == false || string.IsNullOrEmpty(RODownloadPath) || (string.IsNullOrEmpty(IMFdownloadpath)))
                 {
                     sStatus = "Error: ROAttachments/IMF attachments could not be downloaded";
                 }
                 else
                 {
                     if (CheckFilesExist(IMFdownloadpath, RODownloadPath))
                     {
                         isMatch = FileEquals(IMFdownloadpath, RODownloadPath);
                         if (isMatch)
                         {
                             sStatus = "Identical";
                         }
                         else
                         {
                             sStatus = "Different";
                         }
                     }
                     else
                     {
                         sStatus = "Error: File does not exists in IMFDownloadPath/RODownloadPath";
                     }
                 }
             }

             catch (Exception ex)
             {
                 sStatus = "Error: " + ex.Message;
             }

             xDocBinCompare.Root.Element("BinaryComparisonStatus").Value = sStatus;

             using (var xmlReader = xDocBinCompare.CreateReader())
             {
                 xmldoc.Load(xmlReader);
             }

             return xmldoc;
         }
       
         public XDocument GetXDocument(XmlDocument xmldoc)
         {
             XDocument xdoc = null;
             string strState = string.Empty;
             string strAnnotation = string.Empty;
             string Ispilot = string.Empty;

             using (var nodeReader = new XmlNodeReader(xmldoc))
             {
                 nodeReader.MoveToContent();
                 xdoc = XDocument.Load(nodeReader);
             }
             return xdoc;
         }


         public bool LoadROAttachments(string IssueID, string ROATTFileName, string ROATTDesc, string InterfaceName, string SystemKey)
         {     
             Session cqSession = new Session();

             if (!LoggedIn) LoginToRequestOne(cqSession, SystemKey, InterfaceName);
             bool bIsSuccess = true;            


             IOAdEntity l_oEntity = null;          
             l_oEntity = cqSession.GetEntity("ISSUE", IssueID);

             IOAdAttachmentFields l_oAttachmentsFields = l_oEntity.AttachmentFields;
             IOAdAttachmentField l_oAttachmentField = null;

             for (int i = 0; i < l_oAttachmentsFields.Count; i++)
             {
                 IOAdAttachmentField l_oAttac = l_oAttachmentsFields.item(i);

                 if (l_oAttac.fieldname.ToUpper() == "ATTACHMENTS")
                 {
                     l_oAttachmentField = l_oAttac;
                     break;
                 }
             }
             if (l_oAttachmentField == null) return false;

           
             IOAdAttachments l_oAttachments = l_oAttachmentField.Attachments;

             for (int iattach = 0; iattach < l_oAttachments.Count; iattach++)
             {
                 IOAdAttachment l_oAttachment = l_oAttachments.item(iattach);

                 if ((l_oAttachment.filename.ToString() == ROATTFileName) && (l_oAttachment.Description.ToString() == ROATTDesc))
                 {
                     bIsSuccess = l_oAttachment.Load(RODownloadPath);
                     break;
                 }
                 if (bIsSuccess == false)
                 {
                     return false;
                 }
                 else
                 {
                     continue;
                 }
             }

             Close(cqSession);
             return bIsSuccess;
         }

         public bool CheckFilesExist(string fileName1, string fileName2)
         {
             if (File.Exists(fileName1) && File.Exists(fileName2))
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }

         public bool FileEquals(string fileName1, string fileName2)
         {
             // Check the file size and CRC equality here.. if they are equal...             

             using (var file1 = new FileStream(fileName1, FileMode.Open,FileAccess.Read,FileShare.Read))
             using (var file2 = new FileStream(fileName2, FileMode.Open))
                 return StreamEquals(file1, file2);

         }

         public bool StreamEquals(Stream stream1, Stream stream2)
         {
             const int bufferSize = 2048;
             byte[] buffer1 = new byte[bufferSize]; //buffer size
             byte[] buffer2 = new byte[bufferSize];
             while (true)
             {
                 int count1 = stream1.Read(buffer1, 0, bufferSize);
                 int count2 = stream2.Read(buffer2, 0, bufferSize);

                 if (count1 != count2)
                     return false;

                 if (count1 == 0)
                     return true;

                 // You might replace the following with an efficient "memcmp"
                 //if (!buffer1.Take(count1).SequenceEqual(buffer2.Take(count2)))
                 //    return false;

                 int iterations = (int)Math.Ceiling((double)count1 / sizeof(Int64));
                 for (int i = 0; i < iterations; i++)
                 {

                     if (BitConverter.ToInt64(buffer1, i * sizeof(Int64)) != BitConverter.ToInt64(buffer2, i * sizeof(Int64)))
                     {
                         return false;
                     }
                 }
                 List<string> org = new List<string>();
             }
         }

         public bool LoginToRequestOne(Session cqSession, string sKey, string InterfaceName)
         {

             bool isLoggedOn = true;
             string sConfKey = InterfaceName + INTERFACE_CONFIG_PATTERN;

             string ConfigXMLPath = LoadItemFromBizTalkAppConfig(sConfKey);

             XDocument xConfigXML = LoadConfigurationXML(ConfigXMLPath);

             for (int intCount = 1; intCount <= 4; intCount++)
             {
                 try
                 {

                     XElement xCQNode = xConfigXML.Element("CONFIGURATIONS")
                                                       .Element("REQUESTONE").Element("CQ")
                                                       .Element("SERVERS").Elements("SERVER")
                                                       .Where(n => n.FirstAttribute != null
                                                       && n.FirstAttribute.Value == sKey)
                                                       .Select(n => n).Single();

                     CQUser = xCQNode.Element("LDAPUSER").Value;
                     CQPasword = DecryptString(xCQNode.Element("PASSWORD").Value, "RO");
                     CQRepo = xCQNode.Element("SCHEMAREPO").Value;
                     CQDB = xCQNode.Element("DB").Value;
                     cqSession.UserLogon(CQUser, CQPasword, CQDB, 2, CQRepo);
                 }
                 catch (System.Runtime.InteropServices.COMException ComExp)
                 {
                     if (intCount > 3)
                     {
                         isLoggedOn = false;
                         throw ComExp;
                     }
                     else
                     {
                         continue;
                     }
                 }
             }
             LoggedIn = true;
             return isLoggedOn;
         }

         //public bool LoginToRequestOne(Session cqSession,string sKey)
         //{       

         //    bool isLoggedOn = true;
         //    //setup RO-Connection
         //    CQRepo = System.Text.RegularExpressions.Regex.Replace(sKey, "(.*)@.*", "$1");
         //    CQDB = System.Text.RegularExpressions.Regex.Replace(sKey, ".*@(.*)", "$1");
                         
         //        for (int intCount = 1; intCount <= 4; intCount++)
         //        {
         //            try
         //            {
         //                switch (sKey)
         //                {
         //                    case "CDG_DEV_INTEGRATION@RQ1ML":
         //                        cqSession.UserLogon("BizTalk", "bt4dev01", CQDB, 2, CQRepo);  // 2 means PRIVATE_SESSION, s. API docu
         //                        break;
         //                    case "RQ1_ACCEPTANCE@RQONE":
         //                        cqSession.UserLogon("BizTalk", "EAIServ", CQDB, 2, CQRepo);  // 2 means PRIVATE_SESSION, s. API docu
         //                        break;
         //                    case "RQ1_PRODUCTIVE@RQONE":
         //                        cqSession.UserLogon("BizTalk", "EAIServ", CQDB, 2, CQRepo);  // 2 means PRIVATE_SESSION, s. API docu
         //                        break;
         //                    default:
         //                        cqSession.UserLogon("BizTalk", "EAIServ", CQDB, 2, CQRepo);  // 2 means PRIVATE_SESSION, s. API docu
         //                        break;
         //                }                         
         //            }
         //            catch (System.Runtime.InteropServices.COMException ComExp)
         //            {
         //                if (intCount > 3)
         //                {
         //                    isLoggedOn = false;
         //                    throw ComExp;
         //                }
         //                else
         //                {
         //                    continue;
         //                }
         //            }
         //        }
         //        LoggedIn = true;
             
         //    return isLoggedOn;
         //}

      
         public void Close(Session cqSession)
         {
             try
             {
                 if (cqSession != null)
                 {
                     cqSession.SignOff();
                     LoggedIn = false;
                 }
             }
             catch (Exception e)
             {
                
             }
         }

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

         public static string DecryptString(string Message, string Passphrase)
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

         public static string LoadItemFromBizTalkAppConfig(string strKey)
         {
             string strValue = ConfigurationManager.AppSettings[strKey];
             return strValue;
         }

         public XDocument LoadConfigurationXML(string ConfigXMLPath)
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
                     }
                 }
             }
             catch (Exception ex)
             {
                 xConfigXML = null;
             }
             return xConfigXML;
         }
    }
}
