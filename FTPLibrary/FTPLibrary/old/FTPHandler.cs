using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;  // zB XDocument
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;

namespace RB.FTPLibrary
{

    public class ConfigurationHandler
    {
        public XDocument XConfig
        {
            get;
            set;
            //get { return LoadConfigurationXML(); }
        }

        public bool ReadConfigFile()
        {
            string configXMLFile;
            bool result = false;

            XDocument xConfigDoc = null;
            try
            {
                //Utilities.objLogger.LogInfo("ConfigXMLPath: " + ConfigXMLPath);

                configXMLFile = GlobalConstants.CONF_FILE;

                if (configXMLFile.Length > 0)
                {
                    if (System.IO.File.Exists(configXMLFile) == true)
                    {
                        //File Exists, start processing
                        xConfigDoc = XDocument.Load(configXMLFile);
                        XConfig = xConfigDoc;
                        result = true;
                    }
                }
                else
                {
                    result = false;
                    //throw new InterfaceConfigNotFoundException();
                }

            }
            /*
            catch (InterfaceConfigNotFoundException ex)
            {
                //Utilities.objLogger.LogInfo("Log file not found");
                //Utilities.objLogger.LogException(ex, "ROConfigurationManager::LoadConfigurationXML");
                XConfig = null;
            }
            */
            catch (Exception ex)
            {
                result = false;
                //Utilities.objLogger.LogException(ex, "ROConfigurationManager::LoadConfigurationXML");
                XConfig = null;
            }
            finally
            {

            }
            //Utilities.objLogger.LogInfo("ROConfigurationManager::LoadConfigurationXML - Ends");

            return result;

        }


        public bool CheckInterfaceName(string ROInterfaceName)
        {

            bool confValid = false;
            bool infValid = false;


            //ConfigurationHandler CH = new ConfigurationHandler();

            confValid = ReadConfigFile(); 

            //scan config for project

            if (confValid)
            {
                foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
                {

                    if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                    {
                        if (inf.XPathSelectElement("./ENABLED").Value.ToString() == "1")
                        {
                            infValid = true;
                        }
                    }

                }
            }

            /* sample for xml exploration with LinQ :
            foreach (var inf in CH.XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {

                foreach(var prj in inf.XPathSelectElements("./PROJECT_MAPPINGS/ROPROJECTID"))
                {
                    if (ROProjectID == prj.Value.ToString())
                    {
                        AIInterface = inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString();
                    }
                }
            }
            */  

            return (confValid & infValid);
        }


        public string GetIFFTPProp(string ROInterfaceName, string FTPPropName)
        {
            string xVal = "";
            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {
                    foreach (var prop in inf.XPathSelectElements("./FTPSETTINGS/*"))
                    {
                        if (prop.Name.ToString() == FTPPropName)
                        {
                            xVal = prop.Value.ToString();
                        }
                    }
                }
            }
            return xVal;
        }


        public string[,] GetIFATTTags(string ROInterfaceName, string SCPath)
        {
            int numberOfAttLocs, i; //number of AttachmentLocations
            string[,] attTags = new string[5,3];
            

            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {
                    foreach (var sci in inf.XPathSelectElements("./SCHEMA-RELATED-INFOS/SCHEMA-INFO"))
                    {
                        if (SCPath == sci.XPathSelectElement("./SCHEMA-FILEPATH").Value.ToString())
                        {
                            numberOfAttLocs = sci.XPathSelectElements("./ATTACHMENT-INFOS/*").Count();
                            attTags = new string[numberOfAttLocs,3];  // 0-based array
                            i=0;
                            foreach (var attLoc in sci.XPathSelectElements("./ATTACHMENT-INFOS/*"))
                            {
                                attTags[i, 0] = attLoc.XPathSelectElement("./ATTACHMENT-BASETAG").Value.ToString();
                                attTags[i, 1] = attLoc.XPathSelectElement("./ATTACHMENT-LABELTAG").Value.ToString();
                                attTags[i, 2] = attLoc.XPathSelectElement("./ATTACHMENT-URLTAG").Value.ToString();
                                i++;
                            }
                        }
                    }
                }
            }

            return attTags;
        }
    }




    [Serializable]

    public class FTPHandler
    {
        public string FTPInterfaceName;
        public string FTPServer, FTPUser, FTPPassword, FTPDirectory;
        public bool FTPHandlerValid = false;
        public string[,] FTPSchemaAttachments;
        // static eliminiated 4.5.11

        public FTPHandler(string ROInterfaceName)
        {
            bool infExists = false; // interface exists
            ConfigurationHandler CH = new ConfigurationHandler();

            FTPInterfaceName = ROInterfaceName;

            //load Conf & check Interface

            infExists = CH.CheckInterfaceName(ROInterfaceName);

            // load FTPSettings to Class variables
            if (infExists)
            {
                FTPServer = CH.GetIFFTPProp(ROInterfaceName, "SERVER");
                FTPUser = CH.GetIFFTPProp(ROInterfaceName, "LOGIN");
                FTPPassword = CH.GetIFFTPProp(ROInterfaceName, "PASSWORD");
                FTPDirectory = CH.GetIFFTPProp(ROInterfaceName, "PATH");
                FTPHandlerValid = true;
            }

        }


        public string FTPDirectoryList()
        {

            string ftpFileList="";

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;

            //check Interface

            if (FTPHandlerValid)
            {

                //Routine soll Vorhandensein von xml Files checken, Filename darf kein Leerzeichen enthalten.
                FTPRq = (FtpWebRequest)FtpWebRequest.CreateDefault(new System.Uri(FTPServer));
                FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;
                FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);

                FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                FTPStream = (Stream)FTPRp.GetResponseStream();

                ftpFileList = ParseFTPListStream(FTPStream);
                
            }

            return ftpFileList;
        }


        public string ParseFTPListStream(System.IO.Stream strm)
        {
            StreamReader FTPStrmRd;
            string rawLineStr = "";
            string tmpStr;
            string ftpLine = "";


            FTPStrmRd = new StreamReader(strm);

            while (FTPStrmRd.Peek() >= 0)
            {
                rawLineStr = FTPStrmRd.ReadLine();

                // filter out non-xml files like attachments:
                if (System.Text.RegularExpressions.Regex.IsMatch(rawLineStr, "\\S+\\.xml"))
                {
                    // extract filename from ftp line:
                    tmpStr = System.Text.RegularExpressions.Regex.Replace(rawLineStr, ".* (\\S+\\.xml)", "$1") + ",";
                    ftpLine = ftpLine + tmpStr;
                }
            }

            tmpStr = ftpLine;

            ftpLine = System.Text.RegularExpressions.Regex.Replace(tmpStr, ",$", "");

            return ftpLine;
        }


        public bool CheckSingleFTPFile(string FTPFileName)
        {
            //Routine soll Vorhandensein eines xbeliebigen Files checken, Filename darf auch Leerzeichen enthalten.

            FtpWebRequest   FTPRq;
            FtpWebResponse  FTPRp;
            Stream          FTPStream;
            StreamReader    FTPStrmRd;

            string      tmpStr;
            bool        fExists = false; // file exists


            if (FTPFileName.Length > GlobalConstants.FTP_MAX_FILENAME_LENGTH)
            {
                return false;
            }
            
            FTPRq = (FtpWebRequest)FtpWebRequest.CreateDefault(new System.Uri(FTPServer));
            FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;
            FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
             

            FTPRp = (FtpWebResponse)FTPRq.GetResponse();
            FTPStream = (Stream)FTPRp.GetResponseStream();
            FTPStrmRd = new StreamReader(FTPStream);

            while ((FTPStrmRd.Peek() >= 0) & (fExists == false))
            {
                tmpStr = FTPStrmRd.ReadLine(); // geändert 21.3.2011
                //tmpStr = System.Text.RegularExpressions.Regex.Replace(FTPStrmRd.ReadLine(), ".* (\\S+)$", "$1");
                if (tmpStr == FTPFileName)
                {
                    fExists = true;
                }
            }

            FTPRp.Close();
            FTPStream.Close();

            return fExists;

        }

        /*
        public bool SetupFTPInterface(string ROInterfaceName)
        {
            //will be replaced by constructor

            bool infExists = false; // interface exists

            ConfigurationHandler CH = new ConfigurationHandler();

            //load Conf & check Interface

            infExists = CH.CheckInterfaceName(ROInterfaceName);

            // load FTPSettings to Class variables
            if (infExists)
            {
                FTPServer = CH.GetIFFTPProp(ROInterfaceName, "SERVER");
                FTPUser = CH.GetIFFTPProp(ROInterfaceName, "LOGIN");
                FTPPassword = CH.GetIFFTPProp(ROInterfaceName, "PASSWORD");
                FTPDirectory = CH.GetIFProp(ROInterfaceName, "PATH");
                FTPHandlerValid = true;
            }

            return infExists;
        }
        */

        public bool TransferSingleFTPFile(string FTPFileName, string localSubDir)
        {
            bool fExists = false; // file exists
            bool downloadOK = false;
            bool result = false;

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;

            // hier fehlt noch der CheckSingleFTPFile

            fExists = CheckSingleFTPFile(FTPFileName);

            if (fExists)
            {

                if (FTPHandlerValid)
                {
                    if (Directory.Exists(localDownloadPath) == false)
                    {
                        Directory.CreateDirectory(localDownloadPath);
                    }

                    // downloadOK is not yet valid:
                    downloadOK = DownloadSingleFTPFile(FTPFileName, localSubDir);
                }
            }

            result = fExists & downloadOK;

            return result;
        }

        public bool DownloadSingleFTPFile(string FTPFileName, string localSubDir)
        {
            // Class FTPProperty-Strings shall be set already
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;
            BinaryWriter LocalBinWriter;


            // only valid for string files:
            // StreamReader FTPStrmRd; 
            // StreamWriter LocalStrmWr; // local stream writer


            FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPFileName));
            FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
            FTPRq.UseBinary = true;
            FTPRq.Method = WebRequestMethods.Ftp.DownloadFile;
            FTPRp = (FtpWebResponse)FTPRq.GetResponse();
            FTPStream = (Stream)FTPRp.GetResponseStream();

            //LocalBinReader = new BinaryReader(FTPStream);
            LocalBinWriter = new BinaryWriter(System.IO.File.Open(localDownloadPath + "\\" + FTPFileName, FileMode.Create));

            //LocalBinWriter.Write(LocalBinReader.ReadBytes((int)FTPStream.Length));

            int bufferSize = 4096;
            byte[] buffer = new byte[bufferSize];

            int readCount = FTPStream.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                LocalBinWriter.Write(buffer, 0, readCount);
                readCount = FTPStream.Read(buffer, 0, bufferSize);
            }

            LocalBinWriter.Flush();
            LocalBinWriter.Close();

            FTPRp.Close();
            FTPStream.Close();

            /*
            FTPStrmRd = new StreamReader(FTPStream);

            LocalStrmWr = new StreamWriter(localDownloadPath + "\\" + FTPFileName);
            LocalStrmWr.Write(FTPStrmRd.ReadToEnd());
            LocalStrmWr.Close();
            */
              
              
            // urgent : exception handling ...

            return true;
        }

        public string DownloadIssueAttachments(string AIFileName, string localSubDir)
        {
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName);

            bool failureOccured = false;
            string failureMessage = "";
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string AILongFileName = localDownloadPath + "\\" + AIFileName;
            string              labelTag, urlTag;

            string dlFiles = "";
            string tmpStr="";
            string aiLine, aiSchemaFilepath; // AsamIssueLine ...

            //read AIFile to determine schemalocation
            FileStream   strm = new FileStream(AILongFileName, FileMode.Open);
            StreamReader strRd = new StreamReader(strm);

            do
            {
                aiLine = strRd.ReadLine();
            }
            while ((aiLine != null) && (aiLine.IndexOf("schemaLocation=\"", 0, StringComparison.CurrentCultureIgnoreCase) == -1));

            strRd.Close();
            strm.Close();


            //error if no schema info found
            if (aiLine == null)
            {
                failureOccured = true;
                failureMessage = "failure:no schema information found in asam issue file ";
                return failureMessage;
                //noch in liveToken zu übernehmen, Abbruch der weiteren Bearbeitung sicherstellen
            }

            if (failureOccured == false)
            {
                //parse |schemaLocation="|
                aiSchemaFilepath = Regex.Replace(aiLine, ".*schemaLocation=\"(.+\\.xsd)\".*", "$1", RegexOptions.IgnoreCase);
                //add error handling in aiSchemaFilePath is empty ...
                //now assuem aiSchemaFilePath is valid: 

                // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations
                FTPSchemaAttachments = CH.GetIFATTTags(FTPInterfaceName, aiSchemaFilepath);

                //read AIFile again to find AttachmentLocations:
                strm = new FileStream(AILongFileName, FileMode.Open);
                XPathDocument xdoc = new XPathDocument(strm);
                XPathNavigator nav = xdoc.CreateNavigator();

                //Loop for all AttachmentLocations here
                for (int i=0; i <= FTPSchemaAttachments.GetUpperBound(0); i++)
                {
                    //FTPSchemaAttachments[i,0] contains one distinct attachmentpath (..ISSUE/RELATED-DOCS...)

                    //advantage: following statement returns all available base tags though i.e. some 
                    //issue-solutions lack of an related-doc tag
                    XPathNodeIterator nodes = nav.Select(FTPSchemaAttachments[i,0]);
                    XPathNavigator cnod;

                    foreach (XPathNavigator xnod in nodes)
                    {

                        //for one distinct attachmentpath (..ISSUE/RELATED-DOCS...) 
                        // all subsequent nodes (= documents) are looped through here

                        //first select Label Tag 
                        //cnod = xnod.SelectChildren(XPathNodeType.All);
                        cnod = xnod.SelectSingleNode(FTPSchemaAttachments[i,1]);
                        labelTag = cnod.Value.ToString();
                        cnod = xnod.SelectSingleNode(FTPSchemaAttachments[i,2]);
                        urlTag = cnod.Value.ToString();

                        if ((FTPInterfaceName == "RO-ASAM-AUDI") & ((labelTag != "") & (labelTag != urlTag)))
                        {
                            //AUDI convention label=url is hurt --> error
                            failureOccured = true;
                            failureMessage = "failure:Attachment tags (label url) are different in Audi file s. url " + urlTag;
                            break;
                        }

                        //AI contains attachment reference

                        if (urlTag != "")
                        {

                            if (CheckSingleFTPFile(urlTag) == true)
                            {
                                if (DownloadSingleFTPFile(urlTag, localSubDir) == true)
                                {
                                    dlFiles = dlFiles + "o.k.:" + urlTag + ", ";
                                    //log message : attachment 'urltag' successfully downloaded to local directory
                                }
                                else
                                {
                                    failureOccured = true;
                                    failureMessage = "failure:Download of " + urlTag + " has failed.";
                                    break;
                                    //error message : attachment 'urltag' could not be downloaded to local directory
                                }
                            }
                            else
                            {
                                failureOccured = true;
                                failureMessage = "failure:Attachment " + urlTag + " cannot be downloaded.";
                                break;
                                //error message: either attachment is not available on FTP server or label/url tag are not identical
                            }

                        }
                    }
                    if (failureOccured == true)
                    {
                        break;
                    }

                }

                strm.Close(); //added 27.05.2011

                if (failureMessage != "")
                {
                    tmpStr = failureMessage;
                }
                else
                {
                    // delete final comma&space:
                    tmpStr = System.Text.RegularExpressions.Regex.Replace(dlFiles, ", $", "");

                }
            }
            return tmpStr;
        }

        public string ConvertToLines(string inStr, string sepStr)
        {
 
            string outStr;


            //ConvertToLines

            outStr = System.Text.RegularExpressions.Regex.Replace(inStr, sepStr, "\n");

            //outStr = inStr.Replace(sepStr, System.Environment.NewLine);

            return outStr;
        }

        public int CountStringLines(string inStr)
        {
            // returns 1-based number of lines in string

            int     i = 0;
            string  line;


            using (StringReader reader = new StringReader(inStr))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                }
            }

            return i;
        }

        public string ReadStringLine(string inStr, int pos)
        {

            int     i;
            string  outStr="";

            using (StringReader reader = new StringReader(inStr))
            {
                for (i = 1; i <= pos; i++)
                {
                    outStr = reader.ReadLine();
                }
            }

            return outStr;
        }
    }

    public static class Testings
    {
        public static string checkSchema(string AILongFileName, string IFName)
        {
            string labelTag, urlTag;
            string dlFiles = "";
            string tmpStr = "";
            string aiLine, aiSchemaFilepath; // AsamIssueLine

            FileStream strm = new FileStream(AILongFileName, FileMode.Open);
            StreamReader strRd = new StreamReader(strm);

            do
            {
                aiLine = strRd.ReadLine();
            }
            while ((aiLine != null) && (aiLine.IndexOf("schemaLocation=\"",0,StringComparison.CurrentCultureIgnoreCase) == -1));


            aiSchemaFilepath = Regex.Replace(aiLine, ".*schemaLocation=\"(.+\\.xsd)\".*", "$1", RegexOptions.IgnoreCase);


            XPathDocument xdoc = new XPathDocument(strm);
            XPathNavigator nav = xdoc.CreateNavigator();
            //nav.

            // Array von XPI anlegen und mit allen relevanten tags füllen:
            XPathNodeIterator nodes = nav.Select(GlobalConstants.ASAM_ISSUE_ATTACHMENT_TAG);
            XPathNodeIterator cnod;

            //            while (cnod.MoveNext())
            //            Console.WriteLine(cnod.Current.Value);

            foreach (XPathNavigator xnod in nodes)
            {

                cnod = xnod.SelectChildren(XPathNodeType.All);

                cnod.MoveNext();
                labelTag = cnod.Current.Value.ToString();
                cnod.MoveNext();
                urlTag = cnod.Current.Value.ToString();


                //labelTag = xnod.Evaluate("string(/*[name()='MSR-ISSUE']/*[name()='ISSUES']/*[name()='ISSUE']/*[name()='ISSUE-RELATED-DOCUMENTS']/*[name()='ISSUE-RELATED-DOCUMENT'][2]/*[name()='LABEL'])").ToString();
                //urlTag = xnod.Evaluate("string(/*[name()='MSR-ISSUE']/*[name()='ISSUES']/*[name()='ISSUE']/*[name()='ISSUE-RELATED-DOCUMENTS']/*[name()='ISSUE-RELATED-DOCUMENT'][2]/*[name()='URL'])").ToString();

            }

            // delete final comma:
            tmpStr = System.Text.RegularExpressions.Regex.Replace(dlFiles, ",$", "");



            strm.Close();

            return aiSchemaFilepath;

        }

        public static int utf8Length(string fileName)
        {
            int len;
            byte[] byteStream;

            byteStream = Encoding.UTF8.GetBytes(fileName);
            len = byteStream.GetUpperBound(0);
            return len+1;
        }

        public static string utf8Trunc(string fileName)
        {
            int lenFileName = fileName.Length;
            int lenExtender;
            int i;
            string truncTry;
            string fileBody,fileExtender;

            fileBody = System.Text.RegularExpressions.Regex.Replace(fileName, "(.+)\\.\\w*?$", "$1");
            fileExtender = System.Text.RegularExpressions.Regex.Replace(fileName, ".+(\\.\\w*?)$", "$1");
            lenExtender = fileExtender.Length;

            //iteratively compose truncFileName 
            i = 0; // how many chars shall be removed
            do
            {
                i++;
                truncTry = fileBody.Substring(0, fileBody.Length - i) + fileExtender; //subtract chars
            } while (utf8Length(truncTry) > 50);

            truncTry = fileBody.Substring(0, fileBody.Length - i - 1) + "~" + fileExtender;

            return truncTry;
        }

    }
}
