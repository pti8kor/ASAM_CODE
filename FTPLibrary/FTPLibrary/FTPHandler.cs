using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;  // zB XDocument
using System.Xml.Schema;  // added for Schema-Validation
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using System.Security.Cryptography;
using System.Globalization;
using System.Web; //for decryption
using System.IO.Compression;
using RB.BTLoggerLibrary;
using System.Net.Mail;





// 13.3.2012 - V1.0.4.0 -> 
// Delta zu PROD aufnehmen


namespace RB.FTPLibrary
{


    [Serializable]

    public class retStrBool
    {
        public string rString;
        public bool rSuccess;
        public string rMessage;

        public retStrBool()
        {
            rString = "";
            rSuccess = true;
            rMessage = "";
        }
    }

    [Serializable]

    public class FTPHandler
    {
        public string FTPInterfaceName;
        public string RQ1TargetSystem;
        public string DTFolderName = string.Empty;

        public string FTPServer, FTPUser, FTPPassword, FTPBaseDirectory, FTPSuccessDirectory,
            FTPFilterRegex, canSortFiles, TargetSuccessDir, canShiftFoldersForSuccess,
            FTPFailureDirectory, canShiftForFailure, canShiftFoldersForFailure, ACKFTPUser,
            ACKFTPPswd, canShiftACK, ACKFTPFolder, ACKDelayTime,
            canConvertUTF, canConvertNCR;//REUBK-2959- FTPFileShift for failure variables
        public bool FTPHandlerValid = false;
        public string[,] FTPSchemaAttachments;
        public List<string> lstAttachmentNames = new List<string>();
        // static eliminiated 4.5.11


        //FTPConfigurationHandler CH = new FTPConfigurationHandler();

        public FTPHandler()
        {

        }


        public FTPHandler(string ROInterfaceName, string TargetSystem)
        {
            bool infExists = false; // interface exists           
            FTPInterfaceName = ROInterfaceName;
            RQ1TargetSystem = "CDG_DEV_INTEGRATION@RQ1ML";

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);

            infExists = CH.CheckInterfaceName(ROInterfaceName, RQ1TargetSystem);

            // load FTPSettings to Class variables
            if (infExists)
            {
                FTPServer = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SERVER");
                FTPUser = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "LOGIN");
                FTPPassword = DecryptString((CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "PASSWORD")), "RO");  //REUBK-1741
                FTPBaseDirectory = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "BASEPATH");
                FTPSuccessDirectory = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SUCCESSPATH");
                FTPFilterRegex = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FILTERREGEX");
                canSortFiles = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FILTERREGEX", true, "EnableSort");
                canShiftFoldersForSuccess = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SUCCESSPATH", true, "EnableFolderShift");
                FTPFailureDirectory = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FAILUREPATH");

                canShiftForFailure = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FAILUREPATH", true, "EnableShift");//REUBK-2959
                canShiftFoldersForFailure = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FAILUREPATH", true, "EnableFolderShift"); //REUBK-2959

                //canShiftFileWithFolderForSuccess = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SUCCESSPATH", xConfig, true, "EnableDateTimeFolderShift");//V1.9 Folder convention
                //canShiftFileWithFolderForFailure = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FAILUREPATH", xConfig, true, "EnableDateTimeFolderShift");//V1.9 Folder convention

                ACKFTPFolder = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "ACKPATH");
                canShiftACK = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "ACKPATH", true, "EnableShift");
                ACKFTPUser = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "ACKPATH", true, "LoginUser");
                ACKFTPPswd = DecryptString(CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "ACKPATH", true, "LoginPassword"), "RO");
                ACKDelayTime = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "ACKPATH", true, "DelayTime");

                canConvertUTF = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "CHARREPLACEMENT", true, "EnableUTFToISO"); //REUBK-3705
                canConvertNCR = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "CHARREPLACEMENT", true, "EnableNCRToISO");
                FTPHandlerValid = true;
            }

        }


        public string FTPDirectoryList()
        {

            string ftpFileList = "";

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;

            //check Interface

            if (FTPHandlerValid)
            {

                try
                {

                    //Routine soll Vorhandensein von xml Files checken, Filename darf kein Leerzeichen enthalten.
                    FTPRq = (FtpWebRequest)FtpWebRequest.CreateDefault(new System.Uri(FTPServer));
                    FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;
                    FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);

                    FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                    FTPStream = (Stream)FTPRp.GetResponseStream();

                    ftpFileList = ParseFTPListStream(FTPStream);

                    FTPRp.Close();
                    FTPStream.Close();

                }
                catch (Exception e)
                {
                    return e.Message + "An error occured during ftp directory listing.";
                }
            }

            return ftpFileList;
        }


        public string ParseFTPListStream(System.IO.Stream strm)
        {
            StreamReader FTPStrmRd;
            string tmpStr;
            string ftpLine = "";
            string input = "";

            FTPStrmRd = new StreamReader(strm);

            while ((input = FTPStrmRd.ReadLine()) != null) //REUBK-2023
            {

                // filter out non-xml files like attachments:
                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[\\w-]+\\.xml"))
                {
                    // extract filename from ftp line:
                    //tmpStr = System.Text.RegularExpressions.Regex.Replace(rawLineStr, ".* (\\S+\\.xml)", "$1") + ",";
                    //tmpStr = System.Text.RegularExpressions.Regex.Replace(rawLineStr, ".* (\\S+\\.xml)", "$1");  // tmpStr contains xml-filename only
                    tmpStr = input;
                    //filter out non filename compliant xml files for RO-ASAM-AUDI:

                    //pattern = @"(?<number>\d{5})_(?<text>REQUESTED|ACCEPTED|REJECTED|APPROVED|ACCEPTED_PILOT|REJECTED_PILOT|CLOSED-OK|CLOSED-NOT-OK|CANCELED)_(?<date>(19|20)[0-9]{2}(0[1-9]|1[012])(\d+))_(?<time>(20|21|22|23|[0-1]\d)[0-5]\d[0-5]\d).XML";
                    if (Regex.IsMatch(tmpStr, FTPFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        ftpLine = ftpLine + tmpStr + ",";
                    }
                }
            }

            tmpStr = ftpLine;
            ftpLine = System.Text.RegularExpressions.Regex.Replace(tmpStr, ",$", "");

            return ftpLine;
        }



        public bool CheckSingleFTPFile(string FTPFileName)
        {
            //Routine soll Vorhandensein eines xbeliebigen Files checken, Filename darf auch Leerzeichen enthalten.

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;
            StreamReader FTPStrmRd;

            string input = "";
            bool fExists = false; // file exists


            if (FTPFileName.Length > GlobalConstants.FTP_MAX_FILENAME_LENGTH)
            {
                return false;
            }

            FTPRq = (FtpWebRequest)FtpWebRequest.CreateDefault(new System.Uri(FTPServer));
            FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;
            FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);

            try
            {

                FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                FTPStream = (Stream)FTPRp.GetResponseStream();
                FTPStrmRd = new StreamReader(FTPStream);

                while (((input = FTPStrmRd.ReadLine()) != null) & (fExists == false)) //REUBK-2023            
                {
                    //tmpStr = FTPStrmRd.ReadLine(); // geändert 21.3.2011
                    //tmpStr = System.Text.RegularExpressions.Regex.Replace(FTPStrmRd.ReadLine(), ".* (\\S+)$", "$1");
                    if (input == FTPFileName)
                    {
                        fExists = true;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(DTFolderName) && input == DTFolderName)
                        {
                            fExists = CheckSingleFTPFile(FTPFileName, FTPServer + input + "/");
                        }
                    }

                }

                FTPRp.Close();
                FTPStream.Close();
                FTPStrmRd.Close();

            }
            catch (Exception e)
            {
                return false;
            }

            return fExists;

        }

        public bool CheckSingleFTPFile(string FTPFileName, string sFTPSubFolder)
        {

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;
            StreamReader FTPStrmRd;

            string input = "";
            bool fExists = false; // file exists


            if (FTPFileName.Length > GlobalConstants.FTP_MAX_FILENAME_LENGTH)
            {
                return false;
            }

            FTPRq = (FtpWebRequest)FtpWebRequest.CreateDefault(new System.Uri(sFTPSubFolder));
            FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;
            FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);

            try
            {

                FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                FTPStream = (Stream)FTPRp.GetResponseStream();
                FTPStrmRd = new StreamReader(FTPStream);

                while (((input = FTPStrmRd.ReadLine()) != null) & (fExists == false)) //REUBK-2023            
                {
                    if (input == FTPFileName)
                    {
                        fExists = true;
                    }

                }

                FTPRp.Close();
                FTPStream.Close();
                FTPStrmRd.Close();

            }
            catch (Exception e)
            {
                return false;
            }

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


        public bool TransferSingleFTPFile(string FTPFileName, string localSubDir, bool isValid)
        {
            bool fExists = false; // file exists
            bool downloadOK = false;
            bool result = false;

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;

            // hier fehlt noch der CheckSingleFTPFile

            fExists = CheckSingleFTPFile(FTPFileName);

            if (fExists)
            {
                try
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
                catch (Exception e)
                {
                    return false;
                }
            }

            result = fExists & downloadOK & isValid;

            return result;
        }

        public bool CheckforEmptyFTPFile(string FTPFileName, string localSubDir)
        {
            bool result = true;

            try
            {
                if (new FileInfo(GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName).Length <= 0)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public string SetTAFileName(string FileName, Logger objlogger)
        {
            string sStateNew = "MSG-ACKNOWLEDGE";
            string sReturnFileName = FileName;
            string sStateOld, sDateOld, sTimeOld = string.Empty;

            string sDateNew = DateTime.Now.ToString("yyyyMMdd");
            string sTimeNew = DateTime.Now.ToString("HHmmss");
            objlogger.LogInfo("FileName:" + FileName);


            if (!(string.IsNullOrEmpty(FileName)))
            {
                //string[] sNamearr = FileName.Split('_');
                //sReturnFileName = FileName.Replace(sNamearr[2], statenew);

                if (sReturnFileName.EndsWith("_M.xml")) //REUBK-3705
                {
                    sReturnFileName = sReturnFileName.Replace("_M.xml", ".xml");
                }
                objlogger.LogInfo("FileName after replace:" + sReturnFileName);
                //string fileNameRegex = "(.*)_(?<state>REQUESTED|ACCEPTED|REJECTED|ESTIMATED-ACCEPTED|ESTIMATED-REJECTED|CANCELED|INFO-UPDATE)_(?<date>(19|20)[0-9]{2}\\d{4,})_(?<time>(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d).xml";
                //string fileNameRegex = FTPFilterRegex;
                if (Regex.IsMatch(sReturnFileName, FTPFilterRegex, RegexOptions.Singleline | RegexOptions.IgnoreCase))
                {
                    objlogger.LogInfo("Match detected");

                    MatchCollection matchcoll = Regex.Matches(sReturnFileName, FTPFilterRegex, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match m in matchcoll)
                    {
                        if (!string.IsNullOrEmpty(m.Groups["statename"].Value))
                        {
                            sStateOld = m.Groups["statename"].Value;
                            sReturnFileName = sReturnFileName.Replace(sStateOld, sStateNew);
                            objlogger.LogInfo("sReturnFileName:" + sReturnFileName);
                        }
                        if (!string.IsNullOrEmpty(m.Groups["date"].Value))
                        {
                            sDateOld = m.Groups["date"].Value;
                            sReturnFileName = sReturnFileName.Replace(sDateOld, sDateNew);
                        }
                        if (!string.IsNullOrEmpty(m.Groups["time"].Value))
                        {
                            sTimeOld = m.Groups["time"].Value;
                            sReturnFileName = sReturnFileName.Replace(sTimeOld, sTimeNew);
                        }

                        if (m.Value.StartsWith("BMW"))
                        {
                            string fileName = m.Value;
                            string[] vars = fileName.Remove(0, 3).Split('_');
                            sReturnFileName = vars[0] + "_MSG-ACKNOWLEDGE_" + sDateNew + "_" + sTimeNew + ".xml";
                        }
                    }
                }
            }
            return sReturnFileName;

        }


        public bool VerifyAttachmentNames(string fileName, string localSubDir)
        {
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string filePath = localDownloadPath + "//" + fileName;

            bool result = true;

            XDocument modifiedXml = XDocument.Load(filePath);

            // Define the namespace from the XML
            XNamespace ns = "http://www.asam.net/schemas/issue/issue320";

            // Get all <ISSUE> elements from  file
            
            var Issues = modifiedXml.Descendants(ns + "ISSUE");

            // Iterate through each <ISSUE> in the modified XML
            foreach (var issue in Issues)
            {
                // Get all <ISSUE-RELATED-DOCUMENT> elements within the current <ISSUE>
                var Documents = issue.Descendants(ns + "ISSUE-RELATED-DOCUMENT");

                foreach (var doc in Documents)
                {
                    var url = doc.Element(ns + "URL")?.Value;

                     result = IsValidAttachmentName(url);
                }
            }
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

            string FTPEscFileName;

            // only valid for string files:
            // StreamReader FTPStrmRd; 
            // StreamWriter LocalStrmWr; // local stream writer

            // check if FTPFileName contains a "#" sign, as this will lead to "System.Net.WebException"

            FTPEscFileName = Uri.EscapeDataString(FTPFileName);

            try
            {
                //V1.9 Folder convention
                if (!string.IsNullOrEmpty(DTFolderName))
                {
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + DTFolderName + "/" + FTPEscFileName));
                }
                else
                {
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPEscFileName));
                }
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
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public retStrBool ValidateAIFileByXSD(string AIFileName, string localSubDir)
        {
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string aiPath = localDownloadPath + "\\" + AIFileName;
            string schemaPath;
            string localXSDPath;

            bool aiIsValid = true;

            retStrBool retv1 = new retStrBool();
            retStrBool retv2 = new retStrBool();
            retStrBool retvFin = new retStrBool();

            // read in ai from dldir and parse out schemPath
            retv1 = GetSchemaFilePath(aiPath);
            schemaPath = retv1.rString;

            if (retv1.rSuccess == true)
            {
                retv2 = GetSchemaTag(schemaPath, "LOCAL-SCHEMA-FILEPATH", "TransferSchemata");
                localXSDPath = retv2.rString;

                if (retv2.rSuccess == true)
                {
                    StringBuilder oErrors = new StringBuilder();

                    try
                    {
                        XDocument oASAMDoc = XDocument.Load(aiPath);
                        XmlSchemaSet oSchemas = new XmlSchemaSet();
                        oSchemas.Add(null, XmlReader.Create(localXSDPath));
                        oASAMDoc.Validate(oSchemas, (o, e) =>
                        {
                            oErrors.Append(e.Message + System.Environment.NewLine);
                            aiIsValid = false;
                        });
                    }
                    catch (Exception ex)
                    {
                        retvFin.rSuccess = false;
                        retvFin.rMessage = "Error in loading asam issue file for xsd validation";
                        return retvFin;
                    }

                    if (retvFin.rSuccess != false)
                    {

                        if (aiIsValid)
                        {
                            retvFin.rSuccess = true;
                            retvFin.rMessage = "";
                        }
                        else
                        {
                            retvFin.rSuccess = false;
                            // retvFin.rMessage = "asam issue file could not be validated against xsd";
                            retvFin.rMessage = oErrors.ToString();
                        }
                    }
                }
                else
                {
                    retvFin.rSuccess = retv2.rSuccess;
                    retvFin.rMessage = retv2.rMessage;
                }
            }
            else
            {
                retvFin.rSuccess = retv1.rSuccess;
                retvFin.rMessage = retv1.rMessage;
            }

            return retvFin;
        }


        public retStrBool CheckFile4IsoConformance(string FTPFileName, string localSubDir, bool fileModified = false)
        {
            string fileNameModified, filePathModified = string.Empty;
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;
            string failureMessage;

            string rline;
            int count = 0;
            byte[] utfByteStream;
            byte[] isoByteStream;
            retStrBool retv1 = new retStrBool();

            if (fileModified)
            {
                fileNameModified = GetFileNameWithoutExtn(FTPFileName);
                fileNameModified = fileNameModified + "_M.xml";
                filePathModified = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + fileNameModified;

                if (File.Exists(filePathModified))
                {
                    localDownloadPath = filePathModified;
                }
            }



            //officially ISO-8859-1 is required - as CQ provides MS 1252 encoding and this differs only for "€" from ISO,
            //here we directly check 1252 and thus will not complain about any "€" coming in ;.)
            //Encoding iso = Encoding.GetEncoding("ISO-8859-1", new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding iso = Encoding.GetEncoding(1252, new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding utf8 = Encoding.UTF8;

            FileStream fs = new FileStream(localDownloadPath, FileMode.Open);
            StreamReader r = new StreamReader(fs, Encoding.UTF8);

            while ((rline = r.ReadLine()) != null)
            {
                count++;
                utfByteStream = Encoding.UTF8.GetBytes(rline);

                try
                {
                    isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                }
                catch (EncoderFallbackException e)
                {
                    failureMessage = "failure:a non iso-8859-1 compliant character was found at line " + count.ToString();
                    r.Close();
                    fs.Close();

                    //System.Diagnostics.Debug.Write("a non iso-8859-1 compliant character was found at line: " + count.ToString() + "\n");
                    retv1.rMessage = failureMessage;
                    retv1.rSuccess = false;
                    return retv1;
                }

                //for debug only:
                //iline = iso.GetString(isoByteStream);
                //System.Diagnostics.Debug.Write(iline);
            }

            r.Close();
            fs.Close();

            retv1.rMessage = "o.k.:" + FTPFileName;
            retv1.rSuccess = true;
            return retv1;
        }


        public bool ReplaceCharsInFileForISODeclaration(string FTPFileName, string localSubDir)
        {

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;

            string sfileNameWO = GetFileNameWithoutExtn(FTPFileName);
            string localDownloadPathNew = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + sfileNameWO + "_M.xml";


            string rline, rlineForCheck, rlineDecoded, rlineDecodedForCheck;
            int count = 0;
            byte[] utfByteStream;
            byte[] isoByteStream;
            bool bReplace = false;
            bool NCRReplacmentReqd = false;
            bool UTFReplacmentReqd = false;

            //officially ISO-8859-1 is required - as CQ provides MS 1252 encoding and this differs only for "€" from ISO,
            //here we directly check 1252 and thus will not complain about any "€" coming in ;.)
            //Encoding iso = Encoding.GetEncoding("ISO-8859-1", new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding iso = Encoding.GetEncoding(1252, new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding utf8 = Encoding.UTF8;

            //FileStream fs = new FileStream(localDownloadPath, FileMode.Open);
            //StreamReader reader = new StreamReader(fs, Encoding.UTF8);

            string line = string.Empty;
            //string line1 = string.Empty;
            int line_number = 0;

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CHARMAPPING_FILE, true);

            XDocument CharMappingXMLFile = CH.xCharMappingConfig;

            IEnumerable<XElement> xMappings = CharMappingXMLFile.Root.Elements("MAPPING");

            using (FileStream fs = new FileStream(localDownloadPath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.GetEncoding("iso8859-1"))) //read file as iso for iso declaration
                {
                    while ((rlineForCheck = reader.ReadLine()) != null)
                    {
                        count++;

                        try
                        {
                            if (canConvertNCR == "1")
                            {
                                //rline = HttpUtility.HtmlDecode(rline);
                                rlineDecodedForCheck = HttpUtility.HtmlDecode(rlineForCheck);

                                //handle ampersand correctly as it is invalid in xml
                                if (rlineDecodedForCheck.Contains("&"))
                                {
                                    rlineDecodedForCheck = rlineDecodedForCheck.Replace("&", "&amp;");
                                }

                                foreach (XElement xMapping in xMappings)
                                {
                                    string ncrcode = xMapping.Element("NCR-CODE").Value;
                                    string isoChar = xMapping.Element("ISO-CHAR").Value;

                                    if (rlineDecodedForCheck.Contains(xMapping.Element("NCR-CODE").Value))
                                    {
                                        NCRReplacmentReqd = true;
                                        break;
                                    }
                                }

                                if (NCRReplacmentReqd)
                                {
                                    break;
                                }
                            }

                            if (canConvertUTF == "1")
                            {
                                utfByteStream = Encoding.UTF8.GetBytes(rlineForCheck);
                                isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                            }
                        }
                        catch (EncoderFallbackException e)
                        {
                            UTFReplacmentReqd = true;
                            break;
                        }
                    }
                }
            }


            //reader.Close();
            //fs.Close();

            if (NCRReplacmentReqd == true || UTFReplacmentReqd == true)
            {

                //create modified file only if replacement is reqd
                //FileStream FileStream = new FileStream(localDownloadPathNew, FileMode.Create);

                //FileStream fsRead = new FileStream(localDownloadPath, FileMode.Open);
                //StreamReader r = new StreamReader(fs, Encoding.UTF8);

                using (FileStream fsRead = new FileStream(localDownloadPath, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fsRead, Encoding.GetEncoding("iso8859-1")))
                    {
                        using (FileStream fsWrite = new FileStream(localDownloadPathNew, FileMode.Create))
                        {

                            using (StreamWriter writer = new StreamWriter(fsWrite, Encoding.GetEncoding("iso8859-1")))
                            {
                                line_number++;

                                while ((rline = r.ReadLine()) != null)
                                {
                                    count++;
                                    utfByteStream = Encoding.GetEncoding("iso8859-1").GetBytes(rline);

                                    try
                                    {
                                        if (canConvertNCR == "1")
                                        {
                                            string ReplacedLine = string.Empty, GtPattern = "(?<GreaterThan>>)", LtPattern = "(?<LessThan><)";
                                            bool bNeedGtConversion = false, bNeedLtConversion = false;
                                            //REUBK-4064
                                            if (rline.Contains("&gt;"))
                                            {
                                                ReplacedLine = rline;
                                                //ReplacedLine = Regex.Escape(rline);
                                                ReplacedLine = ReplacedLine.Replace("&gt;", GtPattern);
                                                bNeedGtConversion = true;
                                            }
                                            if (rline.Contains("&lt;"))
                                            {
                                                if (!string.IsNullOrEmpty(ReplacedLine))
                                                {
                                                    ReplacedLine = ReplacedLine.Replace("&lt;", LtPattern);
                                                }
                                                else
                                                {
                                                    //ReplacedLine = Regex.Escape(rline);
                                                    ReplacedLine = rline;
                                                    ReplacedLine = ReplacedLine.Replace("&lt;", LtPattern);
                                                }
                                                bNeedLtConversion = true;
                                            }

                                            if (!string.IsNullOrEmpty(ReplacedLine))
                                            {
                                                ReplacedLine = HttpUtility.HtmlDecode(ReplacedLine);
                                                if (ReplacedLine.Contains("&"))
                                                {
                                                    ReplacedLine = ReplacedLine.Replace("&", "&amp;");
                                                }
                                                ReplacedLine = Regex.Escape(ReplacedLine);
                                                ReplacedLine = ReplacedLine.Replace(Regex.Escape(GtPattern), GtPattern);
                                                ReplacedLine = ReplacedLine.Replace(Regex.Escape(LtPattern), LtPattern);
                                            }

                                            rlineDecoded = HttpUtility.HtmlDecode(rline);
                                            //handle ampersand correctly as it is invalid in xml - used in exec engine for xml handling in tags
                                            if (rlineDecoded.Contains("&"))
                                            {
                                                rlineDecoded = rlineDecoded.Replace("&", "&amp;");
                                            }
                                            //REUBK-4064
                                            if (bNeedGtConversion == true)
                                            {
                                                while (ReplacedLine.Contains(GtPattern))
                                                {
                                                    if (Regex.Match(rlineDecoded, ReplacedLine, RegexOptions.Singleline).Success)
                                                    {
                                                        Match Match = Regex.Match(rlineDecoded, ReplacedLine);
                                                        int FirstIndex = 0;
                                                        FirstIndex = Match.Groups["GreaterThan"].Captures[0].Index;

                                                        rlineDecoded = rlineDecoded.Remove(FirstIndex, Match.Groups["GreaterThan"].Value.Length);
                                                        rlineDecoded = rlineDecoded.Insert(FirstIndex, "&gt;");

                                                        FirstIndex = ReplacedLine.IndexOf(GtPattern);
                                                        ReplacedLine = ReplacedLine.Remove(FirstIndex, GtPattern.Length);
                                                        ReplacedLine = ReplacedLine.Insert(FirstIndex, "&gt;");
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            if (bNeedLtConversion == true)
                                            {
                                                while (ReplacedLine.Contains(LtPattern))
                                                {
                                                    if (Regex.Match(rlineDecoded, ReplacedLine).Success)
                                                    {
                                                        Match Match = Regex.Match(rlineDecoded, ReplacedLine);

                                                        int FirstIndex = 0;
                                                        FirstIndex = Match.Groups["LessThan"].Captures[0].Index;

                                                        rlineDecoded = rlineDecoded.Remove(FirstIndex, Match.Groups["LessThan"].Value.Length);
                                                        rlineDecoded = rlineDecoded.Insert(FirstIndex, "&lt;");

                                                        FirstIndex = ReplacedLine.IndexOf(LtPattern);
                                                        ReplacedLine = ReplacedLine.Remove(FirstIndex, LtPattern.Length);
                                                        ReplacedLine = ReplacedLine.Insert(FirstIndex, "&lt;");
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            foreach (XElement xMapping in xMappings)
                                            {
                                                string ncrcode = xMapping.Element("NCR-CODE").Value;
                                                string isoChar = xMapping.Element("ISO-CHAR").Value;

                                                if (rlineDecoded.Contains(xMapping.Element("NCR-CODE").Value))
                                                {
                                                    StringBuilder encodedValue = new StringBuilder();
                                                    char[] charArray = HttpUtility.HtmlEncode(isoChar).ToCharArray();
                                                    foreach (char c in charArray)
                                                    {
                                                        if ((int)c > 127) // above normal ASCII   
                                                        {
                                                            //encodedValue.Append("&#" + (int)c + ";");
                                                            encodedValue.Append("&#" + (int)c + ";");
                                                        }
                                                        else
                                                        {
                                                            encodedValue.Append(c);
                                                        }
                                                    }

                                                    rlineDecoded = rlineDecoded.Replace(ncrcode, encodedValue.ToString());
                                                    rline = rlineDecoded;
                                                    if (bReplace == false)
                                                    {
                                                        bReplace = true;
                                                    }
                                                }
                                            }


                                        }

                                        if (canConvertUTF == "1")
                                        {
                                            isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                                        }

                                        writer.WriteLine(rline);

                                    }
                                    catch (EncoderFallbackException e)
                                    {
                                        foreach (XElement xMapping in xMappings)
                                        {
                                            if (rline.Contains(xMapping.Element("UTF-CHAR").Value))
                                            {
                                                string utfChar = xMapping.Element("UTF-CHAR").Value;
                                                string isoChar = xMapping.Element("ISO-CHAR").Value;
                                                StringBuilder encodedValue = new StringBuilder();
                                                char[] charArray = HttpUtility.HtmlEncode(isoChar).ToCharArray();
                                                foreach (char c in charArray)
                                                {
                                                    if ((int)c > 127) // above normal ASCII   
                                                    {
                                                        encodedValue.Append("&#" + (int)c + ";");
                                                    }
                                                    else
                                                    {
                                                        encodedValue.Append(c);
                                                    }
                                                }
                                                rline = rline.Replace(utfChar, encodedValue.ToString());
                                            }
                                        }
                                        writer.WriteLine(rline);
                                        if (bReplace == false)
                                        {
                                            bReplace = true;
                                        }
                                    }

                                }


                            }
                        }
                    }
                }
                //r.Close();
                //fsRead.Close();
            }


            return bReplace;

        }

        public bool ReplaceCharsInFile(string FTPFileName, string localSubDir)
        {

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;

            string sfileNameWO = GetFileNameWithoutExtn(FTPFileName);
            string localDownloadPathNew = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + sfileNameWO + "_M.xml";


            string rline, rlineForCheck, rlineDecoded, rlineDecodedForCheck;
            int count = 0;
            byte[] utfByteStream;
            byte[] isoByteStream;
            bool bReplace = false;
            bool NCRReplacmentReqd = false;
            bool UTFReplacmentReqd = false;

            //officially ISO-8859-1 is required - as CQ provides MS 1252 encoding and this differs only for "€" from ISO,
            //here we directly check 1252 and thus will not complain about any "€" coming in ;.)
            //Encoding iso = Encoding.GetEncoding("ISO-8859-1", new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding iso = Encoding.GetEncoding(1252, new EncoderExceptionFallback(), new DecoderExceptionFallback());
            Encoding utf8 = Encoding.UTF8;

            //FileStream fs = new FileStream(localDownloadPath, FileMode.Open);
            //StreamReader reader = new StreamReader(fs, Encoding.UTF8);

            string line = string.Empty;
            //string line1 = string.Empty;
            int line_number = 0;

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CHARMAPPING_FILE, true);

            XDocument CharMappingXMLFile = CH.xCharMappingConfig;
            IEnumerable<XElement> xMappings = CharMappingXMLFile.Root.Elements("MAPPING");

            using (FileStream fs = new FileStream(localDownloadPath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    while ((rlineForCheck = reader.ReadLine()) != null)
                    {
                        count++;

                        try
                        {
                            if (canConvertNCR == "1")
                            {
                                //rline = HttpUtility.HtmlDecode(rline);
                                rlineDecodedForCheck = HttpUtility.HtmlDecode(rlineForCheck);

                                //handle ampersand correctly as it is invalid in xml
                                if (rlineDecodedForCheck.Contains("&"))
                                {
                                    rlineDecodedForCheck = rlineDecodedForCheck.Replace("&", "&amp;");
                                }

                                foreach (XElement xMapping in xMappings)
                                {
                                    string ncrcode = xMapping.Element("NCR-CODE").Value;
                                    string isoChar = xMapping.Element("ISO-CHAR").Value;

                                    if (rlineDecodedForCheck.Contains(xMapping.Element("NCR-CODE").Value))
                                    {
                                        NCRReplacmentReqd = true;
                                        break;
                                    }
                                }

                                if (NCRReplacmentReqd)
                                {
                                    break;
                                }
                            }

                            if (canConvertUTF == "1")
                            {
                                utfByteStream = Encoding.UTF8.GetBytes(rlineForCheck);
                                isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                            }
                        }
                        catch (EncoderFallbackException e)
                        {
                            UTFReplacmentReqd = true;
                            break;
                        }
                    }
                }
            }


            //reader.Close();
            //fs.Close();

            if (NCRReplacmentReqd == true || UTFReplacmentReqd == true)
            {

                //create modified file only if replacement is reqd
                //FileStream FileStream = new FileStream(localDownloadPathNew, FileMode.Create);

                //FileStream fsRead = new FileStream(localDownloadPath, FileMode.Open);
                //StreamReader r = new StreamReader(fs, Encoding.UTF8);

                using (FileStream fsRead = new FileStream(localDownloadPath, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fsRead, Encoding.UTF8))
                    {
                        using (FileStream fsWrite = new FileStream(localDownloadPathNew, FileMode.Create))
                        {

                            using (StreamWriter writer = new StreamWriter(fsWrite, Encoding.UTF8))
                            {
                                line_number++;

                                while ((rline = r.ReadLine()) != null)
                                {
                                    count++;
                                    utfByteStream = Encoding.UTF8.GetBytes(rline);

                                    try
                                    {
                                        if (canConvertNCR == "1")
                                        {
                                            string ReplacedLine = string.Empty, GtPattern = "(?<GreaterThan>>)", LtPattern = "(?<LessThan><)";
                                            bool bNeedGtConversion = false, bNeedLtConversion = false;
                                            //REUBK-4064
                                            if (rline.Contains("&gt;"))
                                            {
                                                // ReplacedLine = Regex.Escape(rline);
                                                ReplacedLine = rline;
                                                ReplacedLine = ReplacedLine.Replace("&gt;", GtPattern);
                                                bNeedGtConversion = true;
                                            }
                                            if (rline.Contains("&lt;"))
                                            {
                                                if (!string.IsNullOrEmpty(ReplacedLine))
                                                {
                                                    ReplacedLine = ReplacedLine.Replace("&lt;", LtPattern);
                                                }
                                                else
                                                {
                                                    // ReplacedLine = Regex.Escape(rline);
                                                    ReplacedLine = rline;
                                                    ReplacedLine = rline.Replace("&lt;", LtPattern);
                                                }
                                                bNeedLtConversion = true;
                                            }
                                            if (!string.IsNullOrEmpty(ReplacedLine))
                                            {
                                                ReplacedLine = HttpUtility.HtmlDecode(ReplacedLine);
                                                if (ReplacedLine.Contains("&"))
                                                {
                                                    ReplacedLine = ReplacedLine.Replace("&", "&amp;");
                                                }
                                                ReplacedLine = Regex.Escape(ReplacedLine);
                                                ReplacedLine = ReplacedLine.Replace(Regex.Escape(GtPattern), GtPattern);
                                                ReplacedLine = ReplacedLine.Replace(Regex.Escape(LtPattern), LtPattern);
                                            }

                                            rlineDecoded = HttpUtility.HtmlDecode(rline);
                                            //handle ampersand correctly as it is invalid in xml - used in exec engine for xml handling in tags
                                            if (rlineDecoded.Contains("&"))
                                            {
                                                rlineDecoded = rlineDecoded.Replace("&", "&amp;");
                                            }
                                            //REUBK-4064
                                            if (bNeedGtConversion == true)
                                            {
                                                while (ReplacedLine.Contains(GtPattern))
                                                {

                                                    if (Regex.Match(rlineDecoded, ReplacedLine, RegexOptions.Singleline).Success)
                                                    {
                                                        Match Match = Regex.Match(rlineDecoded, ReplacedLine);
                                                        int FirstIndex = 0;
                                                        FirstIndex = Match.Groups["GreaterThan"].Captures[0].Index;

                                                        rlineDecoded = rlineDecoded.Remove(FirstIndex, Match.Groups["GreaterThan"].Value.Length);
                                                        rlineDecoded = rlineDecoded.Insert(FirstIndex, "&gt;");

                                                        FirstIndex = ReplacedLine.IndexOf(GtPattern);
                                                        ReplacedLine = ReplacedLine.Remove(FirstIndex, GtPattern.Length);
                                                        ReplacedLine = ReplacedLine.Insert(FirstIndex, "&gt;");

                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }

                                            }
                                            if (bNeedLtConversion == true)
                                            {

                                                while (ReplacedLine.Contains(LtPattern))
                                                {

                                                    if (Regex.Match(rlineDecoded, ReplacedLine).Success)
                                                    {
                                                        Match Match = Regex.Match(rlineDecoded, ReplacedLine);

                                                        int FirstIndex = 0;
                                                        FirstIndex = Match.Groups["LessThan"].Captures[0].Index;

                                                        rlineDecoded = rlineDecoded.Remove(FirstIndex, Match.Groups["LessThan"].Value.Length);
                                                        rlineDecoded = rlineDecoded.Insert(FirstIndex, "&lt;");

                                                        FirstIndex = ReplacedLine.IndexOf(LtPattern);
                                                        ReplacedLine = ReplacedLine.Remove(FirstIndex, LtPattern.Length);
                                                        ReplacedLine = ReplacedLine.Insert(FirstIndex, "&lt;");
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }

                                            }

                                            foreach (XElement xMapping in xMappings)
                                            {
                                                string ncrcode = xMapping.Element("NCR-CODE").Value;
                                                string isoChar = xMapping.Element("ISO-CHAR").Value;

                                                if (rlineDecoded.Contains(xMapping.Element("NCR-CODE").Value))
                                                {
                                                    StringBuilder encodedValue = new StringBuilder();
                                                    char[] charArray = HttpUtility.HtmlEncode(isoChar).ToCharArray();
                                                    foreach (char c in charArray)
                                                    {
                                                        if ((int)c > 127) // above normal ASCII   
                                                        {
                                                            //encodedValue.Append("&#" + (int)c + ";");
                                                            encodedValue.Append("&#" + (int)c + ";");
                                                        }
                                                        else
                                                        {
                                                            encodedValue.Append(c);
                                                        }
                                                    }

                                                    rlineDecoded = rlineDecoded.Replace(ncrcode, encodedValue.ToString());
                                                    rline = rlineDecoded;
                                                    if (bReplace == false)
                                                    {
                                                        bReplace = true;
                                                    }
                                                }
                                            }


                                        }

                                        if (canConvertUTF == "1")
                                        {
                                            isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                                        }

                                        writer.WriteLine(rline);

                                    }
                                    catch (EncoderFallbackException e)
                                    {
                                        foreach (XElement xMapping in xMappings)
                                        {
                                            if (rline.Contains(xMapping.Element("UTF-CHAR").Value))
                                            {
                                                string utfChar = xMapping.Element("UTF-CHAR").Value;
                                                string isoChar = xMapping.Element("ISO-CHAR").Value;
                                                StringBuilder encodedValue = new StringBuilder();
                                                char[] charArray = HttpUtility.HtmlEncode(isoChar).ToCharArray();
                                                foreach (char c in charArray)
                                                {
                                                    if ((int)c > 127) // above normal ASCII   
                                                    {
                                                        encodedValue.Append("&#" + (int)c + ";");
                                                    }
                                                    else
                                                    {
                                                        encodedValue.Append(c);
                                                    }
                                                }
                                                rline = rline.Replace(utfChar, encodedValue.ToString());
                                            }
                                        }
                                        writer.WriteLine(rline);
                                        if (bReplace == false)
                                        {
                                            bReplace = true;
                                        }
                                    }

                                }


                            }
                        }
                    }
                }
                //r.Close();
                //fsRead.Close();
            }


            return bReplace;

        }


        public retStrBool DetectInvalidCharacter(string FTPFileName, string localSubDir)
        {
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;
            string returnMessage, encoding = string.Empty;
            retStrBool retv1 = new retStrBool();
            bool bReplace = false;

            try
            {
                XDocument xDocASAM = XDocument.Load(localDownloadPath);
                encoding = xDocASAM.Declaration.Encoding;
                returnMessage = "o.k : encoding in xml declaration is" + encoding;


                if (canConvertNCR == "1" || canConvertUTF == "1")
                {
                    //use mapping table and convert to equivalent iso  //REUBK-3705 

                    if (encoding.ToUpper() != GlobalConstants.DECLARATION_ISO)
                    {
                        //ReplaceCharsInFile - called for files with utf8 declaration
                        bReplace = ReplaceCharsInFile(FTPFileName, localSubDir);
                    }
                    else if (encoding.ToUpper() == GlobalConstants.DECLARATION_ISO)
                    {
                        //ReplaceCharsInFileForISODeclaration - called for files with iso declaration
                        bReplace = ReplaceCharsInFileForISODeclaration(FTPFileName, localSubDir);
                    }
                    else
                    {

                    }

                    //call CheckFile4IsoConformance only for non ISO declaration in ASAM file
                    if (encoding.ToUpper() != GlobalConstants.DECLARATION_ISO)
                    {
                        retv1 = CheckFile4IsoConformance(FTPFileName, localSubDir, true);
                    }
                    if (bReplace)
                    {
                        retv1.rString = "Chars replaced in asam file";
                    }
                    else
                    {
                        retv1.rString = "asam file not modified";
                    }

                }
                else
                {
                    if (encoding.ToUpper() != GlobalConstants.DECLARATION_ISO)
                    {
                        retv1 = CheckFile4IsoConformance(FTPFileName, localSubDir);
                    }

                }
                return retv1;

            }
            catch (Exception ex)
            {
                retv1.rMessage = "failure:" + "" + ex.Message.ToString();
            }
            return retv1;


        }
        public retStrBool CheckCommercialFiles(string AIFileName, string localSubDir, string comFileList)
        {
            string[,] commercialSpecs;

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string aiPath = localDownloadPath + "\\" + AIFileName;

            string schemaPath = "";
            string statusXPath = "";
            string aiStatus = "";
            string aiAnnotation = "";
            string AnnotationXPath = "";
            string attFileList = "";

            bool bcheckForAnnotation = false;
            retStrBool retv1 = new retStrBool(); // return variables
            retStrBool retv2 = new retStrBool(); // return variables
            retStrBool retv3 = new retStrBool(); // return variables
            retStrBool retv4 = new retStrBool(); // return variables
            retStrBool retvFin = new retStrBool(); // return variables
            retStrBool retv5 = new retStrBool(); // return variables
            retStrBool retv6 = new retStrBool();
            // comFileList contains 1 filename per line

            // read in ai from dldir and parse out schemPath
            retv1 = GetSchemaFilePath(aiPath);
            schemaPath = retv1.rString;

            if (retv1.rSuccess)
            {
                // read commercial stati from config
                retv2 = GetSchemaStatusTag(schemaPath, "STATUS-TAG");
                statusXPath = retv2.rString;

                if (retv2.rSuccess)
                {
                    //>check if ai is commercial file
                    //>>get current state of ASAM ISSUE file
                    retv3 = GetAIStatus(aiPath, statusXPath, schemaPath);
                    aiStatus = retv3.rString;

                    if (retv3.rSuccess)
                    {
                        //>>get commercial states for current schema
                        commercialSpecs = GetSchemaComSpecs(schemaPath);

                        //>>find out if ai is commercial
                        for (int i = 0; i <= commercialSpecs.GetUpperBound(0); i++)
                        {
                            if (aiStatus.ToUpper() == commercialSpecs[i, 0].ToUpper())
                            {
                                if (aiStatus.ToUpper() == "REJECTED") //check for est_rej if annotation is reject_estimate REUBK-1761
                                {
                                    retv5 = GetSchemaAnnotationTag(schemaPath, "ANNOTATIONATTR-TAG");
                                    AnnotationXPath = retv5.rString;

                                    retv6 = GetAIAnnotation(aiPath, AnnotationXPath, schemaPath);
                                    aiAnnotation = retv6.rString;

                                    if (aiAnnotation == commercialSpecs[i, 2])
                                    {
                                        bcheckForAnnotation = true;
                                    }
                                    else
                                    {
                                        bcheckForAnnotation = false;
                                    }
                                }
                                else
                                {
                                    bcheckForAnnotation = true;
                                }
                                if (bcheckForAnnotation)
                                {
                                    //>>>ai is of commercial state, now check if 
                                    //  a) filename validation is needed or
                                    //  b) filename validation succeeds
                                    if (commercialSpecs[i, 1] == "" || (AIFileName.ToUpper().Contains(commercialSpecs[i, 1].ToUpper())))
                                    {
                                        //now we are sure that we have a commercial asam issue file present
                                        //ad filename to comFileNameList

                                        if (comFileList != "")
                                        {
                                            comFileList = comFileList + "\n" + AIFileName;
                                        }
                                        else
                                        {

                                            comFileList = AIFileName;
                                        }
                                        //check for related attachments
                                        retv4 = GetSchemaAttFileNames(aiPath, schemaPath);
                                        if (retv4.rSuccess == true)
                                        {
                                            attFileList = retv4.rString;
                                            //comFileList must be non empty here, so we can simply write:
                                            if (attFileList != "")
                                            {

                                                comFileList = comFileList + "\n" + attFileList;
                                            }
                                        }
                                        else
                                        {
                                            retvFin.rSuccess = false;
                                            retvFin.rMessage = "Attachments could not be parsed in ASAM ISSUE file.";
                                            break;
                                        }
                                    }
                                }
                            }
                            if ((commercialSpecs[i, 1] != "") && (AIFileName.ToUpper().Contains(commercialSpecs[i, 1].ToUpper())) && (aiStatus.ToUpper() != commercialSpecs[i, 0].ToUpper()))
                            {
                                // Filename is commercial but status not --> error
                                retvFin.rSuccess = false;
                                retvFin.rMessage = "asam issue status does not fit to filename";
                                break;
                            }
                        }
                    }
                    else
                    {
                        retvFin.rSuccess = false;
                        retvFin.rMessage = "Status could not be parsed in ASAM ISSUE file.";
                    }
                }
                else
                {
                    retvFin.rSuccess = false;
                    retvFin.rMessage = "Status tag could not be found in ftp config.";
                    // check ai for attachments -> if available include in list
                }


            }
            else
            {
                retvFin.rSuccess = false;
                //retvFin.rMessage = "Schema could not parsed from Asam Issue file."; //REUBK-1932
                retvFin.rMessage = retv1.rMessage;
            }

            // prepare return variable for successfully identified files
            if (retvFin.rSuccess == true)
            {
                retvFin.rString = comFileList;
                retvFin.rMessage = "";
            }

            return retvFin;
        }



        public retStrBool CheckIfStatusTagExists(string AIFileName, string localSubDir)
        {
            retStrBool retv1 = new retStrBool();
            retStrBool retv2 = new retStrBool();
            retStrBool retvFin = new retStrBool();
            string schemaPath = string.Empty;
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string aiPath = localDownloadPath + "\\" + AIFileName;
            retv1 = GetSchemaFilePath(aiPath);

            if (retv1.rSuccess == true)
            {
                schemaPath = retv1.rString;
                retv2 = GetSchemaStatusTag(schemaPath, "STATUS-TAG");
            }
            else
            {
                retvFin.rSuccess = false;
                retvFin.rMessage = retv1.rMessage;
            }
            retvFin.rSuccess = retv2.rSuccess;

            if (retv2.rSuccess == true)
            {
                retvFin.rMessage = "";
            }
            else
            {
                retvFin.rMessage = retv2.rMessage;
            }

            return retvFin;
        }


        public retStrBool GetSchemaFilePath(string aiPath)
        {
            string aiLine, aiSchemaFilepath = ""; // AsamIssueLine ...
            string message = "";
            bool success = true;

            retStrBool retv = new retStrBool();

            try
            {

                //read AIFile to determine schemalocation
                FileStream strm = new FileStream(aiPath, FileMode.Open);
                StreamReader strRd = new StreamReader(strm);

                //scan current asam issue file for following string : 'schemaLocation="'
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
                    success = false;
                    message = "no schema information found in asam issue file";
                }
                else
                {
                    //parse |schemaLocation="|
                    aiSchemaFilepath = Regex.Replace(aiLine, ".*schemaLocation=\"(.+\\.xsd)\".*", "$1", RegexOptions.IgnoreCase);
                }

                if (!aiSchemaFilepath.Contains(".xsd"))
                {
                    success = false;
                    message = "no xsd schema information could be extracted from asam issue file";
                }

                retv.rString = aiSchemaFilepath;
                retv.rSuccess = success;
                retv.rMessage = message;
            }
            catch (Exception ex) //REUBK-1932
            {
                retv.rString = aiSchemaFilepath;
                retv.rSuccess = false;
                // retv.rMessage = ex.InnerException.ToString();
                retv.rMessage = "Import failed due to non availability of asam issue file";
                return retv;
            }
            return retv;
        }

        public retStrBool GetSchemaStatusTag(string schemaPath, string tagName)
        {
            //gives back STATUS-TAG from ftp config for a given schemaPath, e.g. 'http....xls'

            string confTagPath;
            retStrBool retv = new retStrBool();

            //construct tagPath
            // /CONFIGURATIONS/INTERFACE[INTERFACE_NAME="RO-ASAM-AUDI"]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd"]/STATUS-TAG/text()

            confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH=""" + schemaPath + @"""]/STATUS-TAG";
            //confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[@VERSION=""" + schemaPath + @"""]/STATUS-TAG";



            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            //statusPath = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);
            retv = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);


            if ((retv.rSuccess == false) || (!retv.rString.Contains("ISSUE-STATE")))
            {
                retv.rString = "";
                retv.rSuccess = false;
                retv.rMessage = "STATUS-TAG could not be found in FTP config";
            }

            return retv;
        }

        public retStrBool GetSchemaTag(string schemaPath, string tagName, string valSubStr)
        {
            //looks for a tag in SCHEMA-INFO section of FTP config file            
            string confTagPath;
            retStrBool retv = new retStrBool();

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);

            //construct tagPath
            // /CONFIGURATIONS/INTERFACE[INTERFACE_NAME="RO-ASAM-AUDI"]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd"]/STATUS-TAG/text()
            //looks for a SCHEMA-INFO to which belongs a SCHEMA-FILEPATH of 'http....xsd' and gets its tagName = 'LOCAL-SCHEMA-FILEPATH' e.g. -->

            confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH=""" + schemaPath + @"""]/" + tagName;
            //confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[@VERSION = """ + schemaPath + @"""]/" + tagName;

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            retv = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);

            //test if valSubStr is part of resulting tagValue
            if ((retv.rSuccess == false) || (!retv.rString.Contains(valSubStr)))
            {
                retv.rString = "";
                retv.rSuccess = false;
                //retv.rMessage = "Error : ASAM schema " + schemaPath + " is not supported by RQ1." + "configpath=" + confTagPath + "TagValue=" + retv.rString;
                retv.rMessage = "Error : ASAM schema " + schemaPath + " is not supported by RQ1.";
            }

            return retv;
        }

        public retStrBool GetAIStatus(string aiPath, string statusXPath, string schemaPath)
        {
            XmlTextReader reader;
            XmlNamespaceManager nsmanager;
            retStrBool retv1 = new retStrBool();
            retStrBool retv2 = new retStrBool();
            string statusVal = "";
            string aNamespace = ""; //ASAM NAMESPACE


            XDocument xAIFile = null;


            //first get ASAM NAMESPACE, which is different from SCHEMA LOCATION = schemaPath

            retv1 = GetSchemaTag(schemaPath, "ASAM-NAMESPACE", @"http://www.asam.net/schemas/issue");
            aNamespace = retv1.rString;

            try
            {


                if (System.IO.File.Exists(aiPath) == true)
                {
                    //File Exists, start processing
                    reader = new XmlTextReader(aiPath);
                    try
                    {
                        xAIFile = XDocument.Load(reader);
                        nsmanager = new XmlNamespaceManager(reader.NameTable);
                        if (aNamespace != "")
                        {
                            nsmanager.AddNamespace("as", aNamespace);
                            statusXPath = statusXPath.Replace(@"/", @"/as:");
                        }
                        statusVal = xAIFile.XPathSelectElement(statusXPath, nsmanager).Value.ToString();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        reader.Close();
                        retv2.rString = "";
                        retv2.rSuccess = false;
                        retv2.rMessage = "Error in reading asam issue status tag.";
                        return retv2;
                    }
                }
            }
            catch (Exception ex) //REUBK-1932
            {
                retv2.rString = "";
                retv2.rSuccess = false;
                retv2.rMessage = "ASAM Issue File could not be found";
                return retv2;
            }


            if ((statusVal == "") || (retv1.rSuccess == false))
            {
                retv2.rString = "";
                retv2.rSuccess = false;
                retv2.rMessage = "status of asam file could not be determined or ASAM Namespace not available in config";
            }
            else
            {
                retv2.rString = statusVal;
                retv2.rSuccess = true;
                retv2.rMessage = "";
            }
            return retv2;
        }

        public retStrBool GetSchemaAnnotationTag(string schemaPath, string tagName)
        {
            //gives back STATUS-TAG from ftp config for a given schemaPath, e.g. 'http....xls'

            string confTagPath;
            retStrBool retv = new retStrBool();


            //construct tagPath
            // /CONFIGURATIONS/INTERFACE[INTERFACE_NAME="RO-ASAM-AUDI"]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd"]/STATUS-TAG/text()

            confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH=""" + schemaPath + @"""]/ANNOTATIONATTR-TAG";
            //confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[@VERSION=""" + schemaPath + @"""]/ANNOTATIONATTR-TAG";

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            //statusPath = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);

            retv = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);


            if ((retv.rSuccess == false) || (!retv.rString.Contains("ISSUE-ANNOTATION")))
            {
                retv.rString = "";
                retv.rSuccess = false;
                retv.rMessage = "ANNOTATION-TAG could not be found in FTP config";
            }

            return retv;
        }

        public retStrBool GetAIAnnotation(string aiPath, string annotationXPath, string schemaPath)
        {
            XmlTextReader reader;
            XmlNamespaceManager nsmanager;
            retStrBool retv1 = new retStrBool();
            retStrBool retv2 = new retStrBool();
            string statusVal = "";
            string aNamespace = ""; //ASAM NAMESPACE


            XDocument xAIFile = null;


            //first get ASAM NAMESPACE, which is different from SCHEMA LOCATION = schemaPath

            retv1 = GetSchemaTag(schemaPath, "ASAM-NAMESPACE", @"http://www.asam.net/schemas/issue");
            aNamespace = retv1.rString;

            if (System.IO.File.Exists(aiPath) == true)
            {
                reader = new XmlTextReader(aiPath);
                //File Exists, start processing
                try
                {
                    xAIFile = XDocument.Load(reader);
                    nsmanager = new XmlNamespaceManager(reader.NameTable);
                    if (aNamespace != "")
                    {
                        nsmanager.AddNamespace("as", aNamespace);
                        annotationXPath = annotationXPath.Replace(@"/", @"/as:");
                    }

                    statusVal = xAIFile.XPathSelectElement(annotationXPath, nsmanager).FirstAttribute.Value.ToString();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    reader.Close();
                    retv2.rString = "";
                    retv2.rSuccess = false;
                    retv2.rMessage = "Error in reading asam issue annotation tag.";
                    return retv2;
                }
            }


            if ((statusVal == "") || (retv1.rSuccess == false))
            {
                retv2.rString = "";
                retv2.rSuccess = false;
                retv2.rMessage = "annotation attribute of asam file could not be determined or ASAM Namespace not available in config";
            }
            else
            {
                retv2.rString = statusVal;
                retv2.rSuccess = true;
                retv2.rMessage = "";
            }

            return retv2;
        }

        public string[,] GetSchemaComSpecs(string schemaPath)
        {

            string[,] comSpecs;

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);

            comSpecs = CH.GetIFSchemaComSpecs(FTPInterfaceName, schemaPath);

            return comSpecs;
        }

        public retStrBool GetSchemaAttFileNames(string aiPath, string schemaPath)
        {
            retStrBool retv = new retStrBool(); // return variables

            bool success = true;
            string message = "";

            string[,] attTags;
            string labelTag, urlTag;
            string attFileNames = "";


            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,

            FTPConfigurationHandler CH = new FTPConfigurationHandler();
            CH.ReadConfigFile(GlobalConstants.CONF_FILE);
            attTags = CH.GetIFATTTags(FTPInterfaceName, schemaPath);

            //read AIFile to determine schemalocation
            FileStream strm = new FileStream(aiPath, FileMode.Open);

            XPathDocument xdoc = new XPathDocument(strm);
            XPathNavigator nav = xdoc.CreateNavigator();

            //Loop for all AttachmentLocations here
            for (int i = 0; i <= attTags.GetUpperBound(0); i++)
            {
                //attTags[i,0] contains one distinct attachmentpath (..ISSUE/RELATED-DOCS...)
                //advantage: following statement returns all available base tags though i.e. some 
                //issue-solutions lack of an related-doc tag
                XPathNodeIterator nodes = nav.Select(attTags[i, 0]);
                XPathNavigator cnod;

                foreach (XPathNavigator xnod in nodes)
                {
                    //for one distinct attachmentpath (..ISSUE/RELATED-DOCS...) 
                    //all subsequent nodes (= documents) are looped through here

                    //first select Label Tag 
                    //cnod = xnod.SelectChildren(XPathNodeType.All);
                    cnod = xnod.SelectSingleNode(attTags[i, 1]);
                    labelTag = cnod.Value.ToString();
                    cnod = xnod.SelectSingleNode(attTags[i, 2]);
                    urlTag = cnod.Value.ToString();  //this is a new attachment file name
                    if (urlTag != "")
                    {
                        if (attFileNames != "")
                        {
                            attFileNames = attFileNames + "\n" + urlTag;
                        }
                        else
                        {
                            attFileNames = urlTag;
                        }

                        if ((FTPInterfaceName == "RO-ASAM-AUDI") & ((labelTag != "") & (labelTag != urlTag)))
                        {
                            //AUDI convention label=url is hurt --> error
                            success = false;
                            message = "Attachment tags (label url) are different in VWAudi file s. url " + urlTag;
                            break;
                        }
                    }

                }
                if (success == false)
                {
                    break;
                }
            }

            strm.Close();

            if (success == false)
            {
                retv.rString = "";
                retv.rSuccess = false;
                retv.rMessage = message;
            }
            else
            {
                retv.rString = attFileNames;
                retv.rSuccess = true;
                retv.rMessage = "";
            }

            return retv;
        }


        public retStrBool GetAttachmentNames(string AIFileName, string localSubDir, bool bShift)
        {

            XPathDocument xdoc;

            retStrBool retv1 = new retStrBool(); // return variables
            retStrBool retv2 = new retStrBool(); // return variables
            retStrBool retvFin = new retStrBool(); // return variables



            bool failureOccured = false;
            string failureMessage = "";

            string labelTag, urlTag;

            string dlFiles = "";
            string aiSchemaFilepath; // AsamIssueLine ...

            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            if (bShift)
            {
                localDownloadPath = localSubDir;
                if (!(string.IsNullOrEmpty(DTFolderName)))
                {
                    localDownloadPath = localSubDir + "\\" + DTFolderName;
                }
            }
            string AILongFileName = localDownloadPath + "\\" + AIFileName;
            // read in ai from dldir and parse out schemPath
            retv1 = GetSchemaFilePath(AILongFileName);
            aiSchemaFilepath = retv1.rString;

            if (retv1.rSuccess)
            {
                // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations

                FTPConfigurationHandler CH = new FTPConfigurationHandler();
                CH.ReadConfigFile(GlobalConstants.CONF_FILE);
                FTPSchemaAttachments = CH.GetIFATTTags(FTPInterfaceName, aiSchemaFilepath);

                //read AIFile to find AttachmentLocations:
                FileStream strm = new FileStream(AILongFileName, FileMode.Open);
                try
                {
                    xdoc = new XPathDocument(strm);
                }
                catch (Exception ex)
                {
                    strm.Close();
                    retv2.rString = "";
                    retv2.rSuccess = false;
                    retv2.rMessage = "Error in reading asam issue for attachment handling.";
                    return retv2;
                }
                XPathNavigator nav = xdoc.CreateNavigator();

                //Loop for all AttachmentLocations here
                for (int i = 0; i <= FTPSchemaAttachments.GetUpperBound(0); i++)
                {
                    //FTPSchemaAttachments[i,0] contains one distinct attachmentpath (..ISSUE/RELATED-DOCS/RELATED-DOC)
                    //advantage: following statement returns all available base tags though i.e. some 
                    //issue-solutions lack of an related-doc tag
                    XPathNodeIterator nodes = nav.Select(FTPSchemaAttachments[i, 0]);
                    XPathNavigator cnod;

                    foreach (XPathNavigator xnod in nodes)
                    {
                        //for one distinct attachmentpath (..ISSUE/RELATED-DOCS...) 
                        // all subsequent nodes (= documents) are looped through here
                        //first select Label Tag 
                        //cnod = xnod.SelectChildren(XPathNodeType.All);
                        cnod = xnod.SelectSingleNode(FTPSchemaAttachments[i, 1]);
                        labelTag = cnod.Value.ToString();
                        cnod = xnod.SelectSingleNode(FTPSchemaAttachments[i, 2]);
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
                            if (bShift)
                            {
                                lstAttachmentNames.Add(urlTag);
                                dlFiles = dlFiles + "add to list-" + urlTag;
                            }
                            else
                            {
                                retvFin = DownloadFileNames(urlTag, localSubDir);
                                if (retvFin.rSuccess == false)
                                {
                                    failureOccured = true;
                                    failureMessage = retvFin.rMessage;
                                    break;
                                }
                                else
                                {
                                    dlFiles = retvFin.rMessage;
                                }
                            }
                        }
                    }
                    if (failureOccured == true)
                    {
                        break;
                    }
                }

                strm.Close(); //added 27.05.2011

            }
            else
            {
                failureOccured = true;
                failureMessage = retv1.rMessage;
            }

            if (failureOccured)
            {
                retvFin.rSuccess = false;
                retvFin.rMessage = failureMessage;
            }
            else
            {
                if (bShift)
                {
                    retvFin.rSuccess = true;
                    retvFin.rMessage = dlFiles;
                }
                else
                {
                    retvFin.rSuccess = true;
                    retvFin.rMessage = System.Text.RegularExpressions.Regex.Replace(dlFiles, ", $", "");

                }

            }

            return retvFin;
        }

        //This method verifies whether the given attachment is a valid filename or not?
        static bool IsValidAttachmentName(string attachmentName)
        {
            // Get the system's invalid file name characters
            char[] invalidChars = Path.GetInvalidFileNameChars();

            // Add custom invalid characters here
            char[] customInvalidChars = { '–' };  // En dash

            // Combine both arrays
            char[] allInvalidChars = invalidChars.Concat(customInvalidChars).ToArray();

            // Check if the file name contains any invalid character
             bool value = !attachmentName.Any(c => allInvalidChars.Contains(c));

            return value;
        }


        public retStrBool DownloadFileNames(string urlTag, string localSubDir)
        {
            retStrBool retv1 = new retStrBool(); // return variables
            

            if (urlTag != "")
            {
                string Attfilename = urlTag;
                string ext = System.IO.Path.GetExtension(Attfilename);
                if (ext == string.Empty || ext == null)
                {
                    retv1.rSuccess = false;
                    retv1.rMessage = "failure: FTPIssueTransfer Debug DownloadIssueAttachments - missing extension for attachment - stop XProt";

                }

                //if(IsValidAttachmentName(urlTag) == false && (ext != string.Empty || ext != null))
                //{
                //    retv1.rSuccess = false;
                //    retv1.rMessage = "failure: Attachment " + urlTag +" invalid character - stop Xprot";
                //}

                if (retv1.rSuccess)
                {
                    if (CheckSingleFTPFile(urlTag) == true)
                    {
                        //System.Threading.Thread.Sleep(120000);
                        if (DownloadSingleFTPFile(urlTag, localSubDir) == true)
                        {
                            retv1.rSuccess = true;
                            retv1.rMessage = retv1.rMessage + "o.k.:" + urlTag + ", ";
                            //log message : attachment 'urltag' successfully downloaded to local directory
                        }
                        else
                        {
                            retv1.rSuccess = false;
                            retv1.rMessage = "failure:Download of " + urlTag + " has failed.";
                            //error message : attachment 'urltag' could not be downloaded to local directory
                        }
                    }
                    else
                    {
                        retv1.rSuccess = false;
                        retv1.rMessage = "failure:Attachment " + urlTag + " cannot be downloaded.";
                        //error message: either attachment is not available on FTP server or label/url tag are not identical
                    }
                }
            }
            return retv1;

        }


        public string ShiftSourceFile(string ASAMFileName, string xprot, string downloadPath, string downloadTime, string Status)
        {
            bool fExists = false; // file exists
            string shiftResult = "";

            string targetPathForFileShift = "";
            string formattedDateTime = GetFormattedDateTime(downloadTime);

            if (ASAMFileName.EndsWith("_M.xml")) //REUBK-3705
            {
                ASAMFileName = ASAMFileName.Replace("_M.xml", ".xml");
            }

            fExists = CheckSingleFTPFile(ASAMFileName);

            if (fExists)
            {
                if (FTPHandlerValid)
                {
                    if (Status.ToUpper() == "SUCCESS")
                    {
                        targetPathForFileShift = FTPSuccessDirectory;

                        //V1.9 FolderConvention
                        if (!string.IsNullOrEmpty(DTFolderName))
                        {
                            if (canShiftFoldersForSuccess == "1")
                            {
                                targetPathForFileShift = FTPSuccessDirectory + "/" + DTFolderName;
                            }

                            shiftResult = ShiftSingleFTPFile(DTFolderName + "/" + ASAMFileName, targetPathForFileShift);
                        }
                        else
                        {
                            if (canShiftFoldersForSuccess == "1")
                            {
                                targetPathForFileShift = FTPSuccessDirectory + "/" + formattedDateTime + "_" + xprot;
                            }
                            shiftResult = ShiftSingleFTPFile(ASAMFileName, targetPathForFileShift);
                        }

                        if (canShiftFoldersForSuccess == "1") //shift attachments 
                        {
                            shiftResult = shiftResult + ShiftAttachments(ASAMFileName, downloadPath, targetPathForFileShift);
                        }

                    }

                    //REUBK-2959 (for V1.7B)
                    else
                    {
                        targetPathForFileShift = FTPFailureDirectory;

                        if (canShiftFoldersForFailure == "1") //set targetpath to datetime_xprot folder in RBRejected folder
                        {

                            //V1.9 FolderConvention
                            if (!string.IsNullOrEmpty(DTFolderName))
                            {
                                targetPathForFileShift = targetPathForFileShift + "/" + DTFolderName;
                                shiftResult = ShiftSingleFTPFile(DTFolderName + "/" + ASAMFileName, targetPathForFileShift);
                            }
                            else
                            {
                                targetPathForFileShift = FTPFailureDirectory + "/" + formattedDateTime + "_" + xprot;
                                shiftResult = ShiftSingleFTPFile(ASAMFileName, targetPathForFileShift);
                            }

                            shiftResult = shiftResult + ShiftAttachments(ASAMFileName, downloadPath, targetPathForFileShift);  //shift attachments                          
                        }
                        else
                        {
                            if (canShiftForFailure == "1")
                            {
                                targetPathForFileShift = FTPFailureDirectory;

                                //V1.9 FolderConvention
                                if (!string.IsNullOrEmpty(DTFolderName))
                                {
                                    shiftResult = ShiftSingleFTPFile(DTFolderName + "/" + ASAMFileName, targetPathForFileShift);
                                }
                                else
                                {
                                    shiftResult = ShiftSingleFTPFile(ASAMFileName, targetPathForFileShift);

                                }

                            }
                        }


                    }

                }
            }
            else
            {
                return "failure:FTP file not found";
            }


            return shiftResult;
        }


        public XmlDocument SetValuesForError(string xprot, string fileName, string msg)
        {
            XmlDocument xmldoc = new XmlDocument();
            try
            {

                XDocument xACKDocument = new XDocument();
                var decl = new XDeclaration("1.0", "utf-8", "no");
                xACKDocument.Declaration = decl;
                XNamespace ns0 = @"http://www.asam.net/schemas/issue/errormessage";
                XElement srcTree = new XElement(ns0 + "ERROR");
                xACKDocument.Add(srcTree);

                xACKDocument.Root.Add(new XAttribute(XNamespace.Xmlns + "ns0", ns0));

                xACKDocument.Root.Add(new XElement("XPROT", xprot));
                xACKDocument.Root.Add(new XElement("FILENAME", fileName));
                xACKDocument.Root.Add(new XElement("ERRORMESSAGE", msg));


                using (var xmlReader = xACKDocument.CreateReader())
                {
                    xmldoc.Load(xmlReader);
                }
                return xmldoc;


            }
            catch (Exception e)
            {

            }
            return xmldoc;

        }


        public XmlDocument SetValuesForACK(string TID, string msg, string status)
        {

            XmlDocument xmldoc = new XmlDocument();
            try
            {

                XDocument xACKDocument = new XDocument();
                var decl = new XDeclaration("1.0", "utf-8", "no");
                xACKDocument.Declaration = decl;
                XNamespace xns0 = @"http://www.asam.net/schemas/issue/messageacknowledgement";
                XNamespace xsi = @"http://www.w3.org/2001/XMLSchema-instance";
                XNamespace schemaLocation = @"http://www.asam.net/schemas/issue/messageacknowledgement MessageAcknowledge.xsd";
                string ns0 = @"http://www.asam.net/schemas/issue/messageacknowledgement";


                XElement srcTree = new XElement("MESSAGE-ACKNOWLEDGE");
                xACKDocument.Add(srcTree);

                //xACKDocument.Root.Add(new XAttribute(XNamespace.Xmlns + "ns0", ns0));
                xACKDocument.Root.Add(new XAttribute("xmlns", ns0));
                xACKDocument.Root.Add(new XAttribute(XNamespace.Xmlns + "xsi", xsi));
                xACKDocument.Root.Add(new XAttribute(xsi + "schemaLocation", schemaLocation));
                xACKDocument.Root.Add(new XElement("TRANSACTION-ID", TID));
                xACKDocument.Root.Add(new XElement("ERROR-CODES", ""));
                

                if (status.ToUpper() == "SUCCESS")
                {
                    xACKDocument.Root.Element("ERROR-CODES").Add(new XElement("ERROR-CODE"));

                }
                else
                {
                    xACKDocument.Root.Element("ERROR-CODES").Add(new XElement("ERROR-CODE", msg));
                }


                using (var xmlReader = xACKDocument.CreateReader())
                {
                    xmldoc.Load(xmlReader);
                }


                return xmldoc;
            }
            catch (Exception e)
            {

            }
            return xmldoc;

        }

        public string GetFileNameWithoutExtn(string sCompletename)
        {
            string fileBody = string.Empty;
            fileBody = System.Text.RegularExpressions.Regex.Replace(sCompletename, "(.+)\\.\\w*?$", "$1");
            string fileExtender = System.Text.RegularExpressions.Regex.Replace(sCompletename, ".+(\\.\\w*?)$", "$1");
            return fileBody;
        }

        public string TransferACKFile(string ACKFileName, string downloadTime, string xprot)
        {

            string sReturn = string.Empty;
            string dirExport = GetFormattedDateTimeforExport(downloadTime);
            string dirImport = GetFormattedDateTime(downloadTime);
            string FTPFolder = ACKFTPFolder + "\\";
            string localSubDirExport = FTPFolder + xprot + "_" + dirExport;
            string localSubDirImport = dirImport + "_" + xprot;
            //string DestFolderName = GlobalConstants.FTP_ACK_TARGET_DIR + localSubDir;
            string SourceFileName = GlobalConstants.FTP_ACK_BASE_DIR + localSubDirImport + "\\" + ACKFileName;

            sReturn = CreateFTPDir(localSubDirExport);
            //System.Threading.Thread.Sleep(500);
            sReturn = UploadACKFile(SourceFileName, localSubDirExport, ACKFileName);
            return sReturn;
        }

        public bool CheckACKFileExists(string xprot, string downloadTime, string ACKFileName)
        {
            string dirImport = GetFormattedDateTime(downloadTime);
            string localSubDirImport = dirImport + "_" + xprot;
            string SourceFileName = GlobalConstants.FTP_ACK_BASE_DIR + localSubDirImport + "\\" + ACKFileName;
            if (File.Exists(SourceFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CreateFTPDir(string folderName)
        {
            try
            {
                //folderName = "DaimlerExport\\" + folderName;
                //FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPSubDir));

                FtpWebResponse ftpResponse;
                //WebRequest request = WebRequest.Create("ftp://si0vm521//" + folderName);
                WebRequest request = WebRequest.Create(FTPServer + folderName);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                //request.Credentials = new NetworkCredential("RQ1ExporterDEV", "");
                request.Credentials = new NetworkCredential(ACKFTPUser, ACKFTPPswd);
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine(resp.StatusCode);
                }
                //Console.WriteLine("create dir Complete, status =", ftpResponse.StatusDescription);
                //ftpResponse.Close();
                ftpResponse = (FtpWebResponse)request.GetResponse();
                if (ftpResponse != null)
                {
                    ftpResponse.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "created ftp dir - success";

        }
        public string UploadACKFile(string SourceFileName, string ExportDirName, string ACKFileName)
        {
            FtpWebRequest request;

            try
            {
                request = (FtpWebRequest)FtpWebRequest.Create(FTPServer + "/" + ExportDirName + "/" + ACKFileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //request.Credentials = new NetworkCredential("RQ1ExporterDEV", "");
                request.Credentials = new NetworkCredential(ACKFTPUser, ACKFTPPswd);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;


                if (File.Exists(SourceFileName))
                {
                    using (FileStream fs = File.OpenRead(SourceFileName))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();
                        Stream requestStream = request.GetRequestStream();
                        requestStream.Write(buffer, 0, buffer.Length);
                        requestStream.Close();
                        requestStream.Flush();
                    }
                }
                else
                {


                    return "ACK file not found in folder" + DateTime.Now.ToString("hh.mm.ss.ffffff");
                }
                return "upload comp";

                //return "UploadACKFile complete" + ftpResponse.StatusDescription;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }


        public string GetDateTimeFolderForACK(string downloadTime)
        {
            string sReturn = string.Empty;
            sReturn = GetFormattedDateTime(downloadTime);
            return sReturn;
        }

        public string ShiftSingleFTPFile(string FTPFileName, string FTPSubDir, bool isAttachmentFile = false)
        {

            bool DExists = false; // dir exists
            bool shiftOK = false;

            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;
            Stream FTPStream;
            StreamReader FTPStrmRd;
            string respStr;

            // Prüfen, ob Dir existiert
            // Anlegen, falls nicht; Rückgabe Berechtigungsfehler
            // Umbenennen; Rückgabe Berechtigungsfehler         

            if (isAttachmentFile) DExists = true;

            if (!DExists)
            {
                try
                {
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPSubDir));
                    FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                    FTPRq.UseBinary = true;
                    FTPRq.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                    FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                    FTPStream = (Stream)FTPRp.GetResponseStream();
                    FTPStrmRd = new StreamReader(FTPStream);
                    respStr = FTPStrmRd.ReadToEnd();
                    FTPRp.Close();
                    FTPStream.Close();
                    FTPStrmRd.Close();

                    DExists = true;
                }
                catch (Exception e)
                {
                    respStr = e.ToString();
                    /*System.Net.WebException: The remote server returned an error: (550) File unavailable (e.g., file not found, no access).
                           at System.Net.FtpWebRequest.CheckError()
                           at System.Net.FtpWebRequest.SyncRequestCallback(Object obj)
                           at System.IO.Stream.Close()
                           at System.Net.ConnectionPool.Destroy(PooledStream pooledStream)
                           at System.Net.ConnectionPool.PutConnection(PooledStream pooledStream, Object owningObject, Int32 creationTimeout, Boolean canReuse)
                           at System.Net.FtpWebRequest.FinishRequestStage(RequestStage stage)
                           at System.Net.FtpWebRequest.GetResponse()
                           at RB.FTPLibrary.FTPHandler.ShiftSingleFTPFile(String FTPFileName, String FTPSubDir)
                     */
                    if (respStr.IndexOf("File unavailable") == -1)
                    {
                        // exception is different from "File unavailable", so stop execution and return false
                        return "failure:FTP directory could not be identified";
                    }
                }
            }

            if (!DExists)
            {
                //create dir
                try
                {
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPSubDir));
                    FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                    FTPRq.UseBinary = true;
                    FTPRq.Method = WebRequestMethods.Ftp.MakeDirectory;
                    //FTPRq.Method = WebRequestMethods.Ftp.DownloadFile;
                    FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                    FTPStream = (Stream)FTPRp.GetResponseStream();
                    FTPStrmRd = new StreamReader(FTPStream);
                    respStr = FTPStrmRd.ReadToEnd();
                    FTPRp.Close();
                    FTPStream.Close();
                    FTPStrmRd.Close();

                    DExists = true;
                }
                catch (Exception e)
                {
                    respStr = e.ToString();
                    return "failure:FTP directory could not be created";
                }
            }

            //rename file to subdir
            if (DExists)
            {
                try
                {
                    String sFTPFileName = Uri.EscapeDataString(GetFileNameForMovement(FTPFileName));
                    // FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + sFTPFileName));
                    if (!string.IsNullOrEmpty(DTFolderName))
                    {
                        FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + "/" + DTFolderName + "/" + sFTPFileName));
                    }
                    else
                    {
                        FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + sFTPFileName));
                    }
                    FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                    FTPRq.UseBinary = true;
                    FTPRq.Method = WebRequestMethods.Ftp.Rename;

                    if (!string.IsNullOrEmpty(DTFolderName))
                    {
                        // if uri eq ftp/subdir/filename target for rename eq ../RB-IMPORTED/subdir/filename;
                        FTPRq.RenameTo = "../" + FTPSubDir + "/" + GetFileNameForMovement(FTPFileName);
                    }
                    else
                    {
                        // if uri eq ftp/filename target for rename eq RB-IMPORTED/date-time_xprot/filename;
                        FTPRq.RenameTo = FTPSubDir + "/" + GetFileNameForMovement(FTPFileName);
                    }

                    FTPRp = (FtpWebResponse)FTPRq.GetResponse();
                    FTPStream = (Stream)FTPRp.GetResponseStream();
                    FTPStrmRd = new StreamReader(FTPStream);
                    respStr = FTPStrmRd.ReadToEnd();
                    FTPRp.Close();
                    FTPStream.Close();
                    FTPStrmRd.Close();



                    shiftOK = true;
                }
                catch (Exception e)
                {
                    respStr = e.ToString();
                    return "failure:shift to FTP target directory failed" + "file=" + FTPFileName;
                }
            }


            if (shiftOK)
            {
                //handle logic to delete ftp subdir for automized mode
                if (!string.IsNullOrEmpty(DTFolderName))
                {
                    List<string> files = DirectoryListing(DTFolderName);
                    if (files.Count == 0)
                    {
                        DeleteFTPDirectory(DTFolderName);
                    }
                }

                return "ok:shift to FTP target directory succeeded";
            }
            else return "failure:ShiftSingleFTPFile failed.";
        }

        public List<string> DirectoryListing(string folderName)
        {
            FtpWebRequest FTPRq;
            FtpWebResponse FTPRp;

            string respStr;
            List<string> result = new List<string>();

            try
            {
                FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + folderName));
                FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                FTPRq.UseBinary = true;

                FTPRq.Method = WebRequestMethods.Ftp.ListDirectory;

                using (FTPRp = (FtpWebResponse)FTPRq.GetResponse())
                using (StreamReader reader = new StreamReader(FTPRp.GetResponseStream()))
                {
                    result = reader.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                }
            }
            catch (Exception e)
            {
                respStr = "failure:shift to FTP target directory- exception in DirectoryListing" + e.ToString();
                //return "failure:shift to FTP target directory- exception in DirectoryListing" + "file=" + folderName;
            }
            return result;
        }


        public string DeleteFTPDirectory(string folderName)
        {
            FtpWebRequest FTPRq;
            string respStr;

            try
            {
                FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + folderName));
                FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                FTPRq.UseBinary = true;

                FTPRq.Method = WebRequestMethods.Ftp.RemoveDirectory;

                string result = string.Empty;
                FtpWebResponse response = (FtpWebResponse)FTPRq.GetResponse();
                response.Close();

                respStr = "shift to FTP target directory- DeleteFTPDirectory succeeded";
            }
            catch (Exception e)
            {
                respStr = "failure:shift to FTP target directory- exception in DeleteFTPDirectory" + e.ToString();
                //return "failure:shift to FTP target directory- exception in DirectoryListing" + "file=" + folderName;
            }
            return respStr;
        }


        public string ShiftAttachments(string successFileName, string sourcePath, string targetPath)
        {
            string shiftResult = "";
            bool fExists = false;

            List<string> attachmentNames = lstAttachmentNames;
            retStrBool retv1 = GetAttachmentNames(successFileName, sourcePath, true);
            if (retv1.rSuccess == true)
            {
                if (attachmentNames.Count > 0)
                {
                    foreach (string attachment in attachmentNames)
                    {
                        fExists = CheckSingleFTPFile(attachment);
                        if (fExists)
                        {
                            //V1.9 FolderConvention
                            if (!string.IsNullOrEmpty(DTFolderName))
                            {
                                shiftResult = ShiftSingleFTPFile(DTFolderName + "/" + attachment, targetPath, true);
                            }
                            else
                            {
                                shiftResult = ShiftSingleFTPFile(attachment, targetPath, true);
                            }
                            if (shiftResult.Contains("failure"))
                            {
                                shiftResult = "exception in ShiftAttachments";
                                break;
                            }
                        }
                        else
                        {
                            return "failure:FTP file:" + attachment + " not found";
                        }
                    }
                }
            }
            else
            {
                shiftResult = "exception in GetAttachmentNames";
            }

            return shiftResult;
        }



        public string GetFormattedDateTime(string xprotdate)
        {
            DateTime NewDateTime = DateTime.ParseExact(xprotdate, "dd.MM.yyyy-HH.mm.ss", CultureInfo.GetCultureInfo("de-DE"));
            string dateFormat = NewDateTime.ToString("yyyyMMdd-HHmmss");

            return dateFormat;
        }
        public string GetFormattedDateTimeforExport(string xprotdate)
        {
            DateTime NewDateTime = DateTime.ParseExact(xprotdate, "dd.MM.yyyy-HH.mm.ss", CultureInfo.GetCultureInfo("de-DE"));
            string dateFormat = NewDateTime.ToString("yyyyMMdd_HHmmss");

            return dateFormat;
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

            int i = 0;
            string line;


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

            int i;
            string outStr = "";

            using (StringReader reader = new StringReader(inStr))
            {
                for (i = 1; i <= pos; i++)
                {
                    outStr = reader.ReadLine();
                }
            }

            return outStr;
        }

        public static string EncryptString(string Message, string Passphrase)
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
            // Step 3. Setup the encoder 

            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[] 

            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string 

            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }

            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information 

                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string 
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message, string Passphrase) //REUBK-1741
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



        #region character mappings - REUBK-2945

        //public int FindBytes(byte[] src, byte[] find)
        //{
        //    int index = -1;
        //    int matchIndex = 0;
        //    // handle the complete source array
        //    for (int i = 0; i < src.Length; i++)
        //    {
        //        if (src[i] == find[matchIndex])
        //        {
        //            if (matchIndex == (find.Length - 1))
        //            {
        //                index = i - matchIndex;
        //                break;
        //            }
        //            matchIndex++;
        //        }
        //        else
        //        {
        //            matchIndex = 0;
        //        }

        //    }
        //    return index;
        //}

        //public byte[] ReplaceBytes(byte[] src, byte[] search, byte[] repl)
        //{
        //    byte[] dst = null;
        //    int index = FindBytes(src, search);
        //    bool bMatchfound = false;

        //    dst = new byte[src.Length - search.Length + repl.Length];
        //    if (index != -1)
        //    {
        //        // before found array
        //        Buffer.BlockCopy(src, 0, dst, 0, index);
        //        // repl copy
        //        Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
        //        // rest of src array
        //        Buffer.BlockCopy(
        //            src,
        //            index + search.Length,
        //            dst,
        //            index + repl.Length,
        //            src.Length - (index + search.Length));

        //        bMatchfound = true;
        //        dst = ReplaceBytes(dst, search, repl);
        //    }

        //    if (bMatchfound)
        //        return dst;
        //    else
        //        return src;
        //}

        //public List<byte> StringToByteList(string hex)
        //{
        //    return Enumerable.Range(0, hex.Length)
        //                     .Where(x => x % 2 == 0)
        //                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        //                     .ToList<byte>();
        //}


        ///// <summary>
        ///// REUBK-2945 - this method checks for iso chars which cannot be represented in UTF-8 format and replaces with valid chars referring to mapping table
        ///// Teh corresponding UTF-8 chars are of 2 bytes/3 bytes as in mapping table
        ///// </summary>
        ///// <param name="FTPFileName"></param>
        ///// <param name="localSubDir"></param>
        //public string CheckForSpecialISOChars(string FTPFileName, string localSubDir)
        //{
        //    string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;
        //    string mappingFilePath = GlobalConstants.CHARMAPPING_FILE;
        //    string localDownloadPathwox, updatedFilePath = string.Empty;

        //    try
        //    {

        //        if (File.Exists(localDownloadPath))
        //        {

        //            //check whether xml loads first
        //            try
        //            {
        //                XDocument xdoc = XDocument.Load(localDownloadPath);
        //            }
        //            catch (Exception exp)
        //            {
        //                if (exp.Message.ToLower().Contains("invalid character in the given encoding"))
        //                {
        //                    //iso spl char handling
        //                    List<byte> fileBytes = File.ReadAllBytes(localDownloadPath).ToList<byte>();
        //                    List<byte> ReplaceWith, SearchBytes = new List<byte>();
        //                    List<byte> fileBytesUpdated = fileBytes;

        //                    XDocument xmappingtable = XDocument.Load(mappingFilePath);
        //                    IEnumerable<XElement> l_oMappings = xmappingtable.Root.Elements("MAPPING");

        //                    foreach (XElement xMapping in l_oMappings)
        //                    {
        //                        byte biso = byte.Parse(xMapping.Element("ISO-BYTE").Value, NumberStyles.HexNumber, CultureInfo.InvariantCulture);

        //                        if (fileBytes.Contains(biso))
        //                        {
        //                            SearchBytes = StringToByteList(xMapping.Element("ISO-BYTE").Value);
        //                            ReplaceWith = StringToByteList(xMapping.Element("UTF-BYTE").Value);

        //                            fileBytesUpdated = ReplaceBytes(fileBytesUpdated.ToArray(), SearchBytes.ToArray(), ReplaceWith.ToArray()).ToList<byte>();
        //                        }
        //                    }

        //                    if (fileBytes != fileBytesUpdated)
        //                    {
        //                        localDownloadPathwox = GetFilePathWithoutExtn(localDownloadPath);
        //                        //updatedFilePath = localDownloadPathwox + "U.xml";                                
        //                        updatedFilePath = localDownloadPathwox.Remove(localDownloadPathwox.Length - 1) + "M.xml";                               


        //                        if (!(File.Exists(updatedFilePath)))
        //                        {
        //                            //File.Copy(localDownloadPath, updatedFilePath);
        //                            File.WriteAllBytes(updatedFilePath, fileBytesUpdated.ToArray());
        //                        }

        //                    }
        //                    return "charmapping - invalid char in xml" + FTPFileName;
        //                }
        //            }
        //        }
        //        return "charmapping  - no error" + FTPFileName;
        //    }
        //    catch (Exception ex)
        //    {                
        //        return "failure:exception in charmapping" + ex.Message;
        //    }
        //}

        //public string GetUpdatedASAMFileName(string FTPFileName, string localSubDir)
        //{
        //    string fileNameToReturn, updatedFileName , fileNameWithoutExtn = string.Empty;
        //    try
        //    {
        //        fileNameWithoutExtn = GetFileNameWithoutExtn(FTPFileName);
        //        updatedFileName = fileNameWithoutExtn.Remove(fileNameWithoutExtn.Length - 1) + "M.xml";

        //        if (File.Exists(GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + updatedFileName))
        //        {
        //            fileNameToReturn = updatedFileName;
        //        }
        //        else
        //        {
        //            fileNameToReturn = FTPFileName;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return "failure:exception in GetUpdatedASAMFileName" + ex.Message;
        //    }
        //    return fileNameToReturn;
        //}

        //public string GetFilePathWithoutExtn(string sCompletename)
        //{
        //    string fileBody = string.Empty;            
        //    fileBody = System.Text.RegularExpressions.Regex.Replace(sCompletename, "(.+)\\.\\w*?$", "$1");
        //    string fileExtender = System.Text.RegularExpressions.Regex.Replace(sCompletename, ".+(\\.\\w*?)$", "$1");            
        //    return fileBody;
        //}


        //public string GetFileNameWithoutExtn(string sCompletename)
        //{
        //    string fileBody = string.Empty;            
        //    fileBody = System.Text.RegularExpressions.Regex.Replace(sCompletename, "(.+)\\.\\w*?$", "$1");
        //    string fileExtender = System.Text.RegularExpressions.Regex.Replace(sCompletename, ".+(\\.\\w*?)$", "$1");            
        //    return fileBody;
        //}

        #endregion

        public class Details
        {
            public string fileName { get; set; }
            public DateTime DateCreated { get; set; }

        }

        public string GetSortedFiles(string sFileNames)
        {
            List<Details> lstFilesAndDateTime = new List<Details>();
            string sSortedFiles = string.Empty;
            string[] FileNames = sFileNames.Split(',');

            foreach (string sFile in FileNames)
            {
                string date = string.Empty, time = string.Empty;
                MatchCollection matchcoll;
                matchcoll = Regex.Matches(sFile, FTPFilterRegex, RegexOptions.IgnoreCase);
                foreach (Match m in matchcoll)
                {
                    if (m.Groups["date"].Length != 0)
                    {
                        date = m.Groups["date"].Value;
                    }
                    if (m.Groups["time"].Length != 0)
                    {
                        time = m.Groups["time"].Value;
                        time = time.Substring(0, 6);
                    }

                    string strDate = date + "_" + time;
                    DateTime NewDateTime;
                    // NewDateTime = DateTime.ParseExact(strDate, "yyyyMMdd_HHmmss", CultureInfo.GetCultureInfo("de-DE"));
                    DateTime.TryParseExact(strDate, "yyyyMMdd_HHmmss", CultureInfo.GetCultureInfo("de-DE"), DateTimeStyles.None, out NewDateTime);
                    Details FileAndDateTime = new Details() { fileName = sFile, DateCreated = NewDateTime };
                    lstFilesAndDateTime.Add(FileAndDateTime);
                }

            }
            var lstSortedFilesAndDates = lstFilesAndDateTime.OrderBy(x => x.DateCreated).ToList();

            foreach (var FileAndDateTime in lstSortedFilesAndDates)
            {
                if (sSortedFiles == string.Empty)
                {
                    sSortedFiles = FileAndDateTime.fileName;
                }
                else
                {
                    sSortedFiles = sSortedFiles + "," + FileAndDateTime.fileName;
                }
            }
            return sSortedFiles;
        }

        //Validates the input file names 
        public bool IsValid(string fileName, string filteredFlies)
        {
            bool result = true;

            if(!filteredFlies.Contains(fileName))
            {
                result = false;
            }
            return result;
        }

        /* public string GetFolderName(string FilePath)
         {
             string folderName = string.Empty;
             //20150807_153705\25000_70982_REQUESTED_20140731_160428.xml
             //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)\\(?<filename>(.*))";
             string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(?<filename>(.*))";

             if (Regex.IsMatch(FilePath, filePathRegex, RegexOptions.Singleline))
             {
                 MatchCollection matchcoll = Regex.Matches(FilePath, filePathRegex);
                 foreach (Match m in matchcoll)
                 {
                     if (!string.IsNullOrEmpty(m.Groups["datetime"].Value))
                     {
                         folderName = m.Groups["datetime"].Value;
                         break;
                     }

                 }
             }
             return folderName;
         }*/

        public string GetFileNameForMovement(string FTPFileName)
        {
            //20150807_153705/25000_70982_REQUESTED_20140731_160428.xml
            string filename = FTPFileName;
            //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(?<filename>(.*))";

            string filePathRegex = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})/(?<filename>(.*))";

            if (Regex.IsMatch(FTPFileName, filePathRegex, RegexOptions.Singleline))
            {
                MatchCollection matchcoll = Regex.Matches(FTPFileName, filePathRegex);
                foreach (Match m in matchcoll)
                {
                    if (!string.IsNullOrEmpty(m.Groups["filename"].Value))
                    {
                        filename = m.Groups["filename"].Value;
                        break;
                    }

                }
            }

            return filename;
        }

        //public string GetRecordsForExportXPROTCreation(string input)
        //{
        //    string fileName = string.Empty;
        //    //20150807_153705/25000_70982_REQUESTED_20140731_160428.xml

        //    //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(?<filename>(.*))";
        //    string filePathRegex = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})/(?<filename>(.*))";

        //    if (Regex.IsMatch(input, filePathRegex, RegexOptions.Singleline))
        //    {
        //        MatchCollection matchcoll = Regex.Matches(input, filePathRegex);
        //        foreach (Match m in matchcoll)
        //        {
        //            if (!string.IsNullOrEmpty(m.Groups["filename"].Value))
        //            {
        //                fileName = m.Groups["filename"].Value;
        //                break;
        //            }

        //        }
        //    }
        //    else
        //    {
        //        fileName = input;
        //    }
        //    return fileName;
        //}

        public string GetFileNamesForXPROTCreation(string input)
        {
            string fileName = string.Empty;
            //20150807_153705/25000_70982_REQUESTED_20140731_160428.xml

            //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(?<filename>(.*))";
            string filePathRegex = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})/(?<filename>(.*))";

            if (Regex.IsMatch(input, filePathRegex, RegexOptions.Singleline))
            {
                MatchCollection matchcoll = Regex.Matches(input, filePathRegex);
                foreach (Match m in matchcoll)
                {
                    if (!string.IsNullOrEmpty(m.Groups["filename"].Value))
                    {
                        fileName = m.Groups["filename"].Value;
                        break;
                    }

                }
            }
            else
            {
                fileName = input;
            }
            return fileName;
        }

        /*  public string GetDLDirNameForXPROTCreation(string filePath, string systemName, string xprot)
          {
              string DLDirName, folderName = string.Empty;
              string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(.*).xml";

              if (Regex.IsMatch(filePath, filePathRegex, RegexOptions.Singleline))
              {
                  MatchCollection matchcoll = Regex.Matches(filePath, filePathRegex);
                  foreach (Match m in matchcoll)
                  {
                      if (!string.IsNullOrEmpty(m.Groups["datetime"].Value))
                      {
                          folderName = m.Groups["datetime"].Value;
                          DTFolderName = folderName;
                          break;
                      }

                  }
                  //20150820-075326_CDG_DEV_INTEGRATION@RQ1ML_36022172\20150807_153705
                  DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + systemName + "_" + xprot + "\\" + folderName;
              }
              else
              {
                  //20150820-075326_CDG_DEV_INTEGRATION@RQ1ML_36022172
                  DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + systemName + "_" + xprot;
              }

              return DLDirName;

          } */

        public string GetDLDirNameForXPROTCreation(string filePath, string systemName, string xprot)
        {
            string DLDirName, folderName = string.Empty;
            //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(.*).xml";
            string filePathRegex = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})/(.*).xml";

            if (Regex.IsMatch(filePath, filePathRegex, RegexOptions.Singleline))
            {
                MatchCollection matchcoll = Regex.Matches(filePath, filePathRegex);
                foreach (Match m in matchcoll)
                {
                    if (!string.IsNullOrEmpty(m.Groups["DTsubfolder"].Value))
                    {
                        folderName = m.Groups["DTsubfolder"].Value;
                        DTFolderName = folderName;
                        break;
                    }

                }
                //20150820-075326_CDG_DEV_INTEGRATION@RQ1ML_36022172\20150807_153705
                DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + systemName + "_" + xprot + "\\" + folderName;
            }
            else
            {
                //20150820-075326_CDG_DEV_INTEGRATION@RQ1ML_36022172
                DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + systemName + "_" + xprot;
            }

            return DLDirName;


        }




        public bool CheckDateTimeFolderInMode(string mode)
        {
            string foldername = string.Empty;
            bool bAutomizedMode = false;
            //string folderPattern = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)";
            string folderPattern = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})";

            if (Regex.IsMatch(mode, folderPattern, RegexOptions.Singleline))
            {
                MatchCollection matchcoll = Regex.Matches(mode, folderPattern);
                foreach (Match m in matchcoll)
                {
                    if (!string.IsNullOrEmpty(m.Groups["DTsubfolder"].Value))
                    {
                        foldername = m.Groups["DTsubfolder"].Value;
                        DTFolderName = foldername;
                        bAutomizedMode = true;
                        break;
                    }

                }
            }

            return bAutomizedMode;

        }


        public void GetDateTimeFolderBasedOnMode(string downloadTargetPath)
        {
            string foldername = string.Empty;
            foreach (string folder in Directory.GetDirectories(downloadTargetPath))
            {
                foldername = Path.GetFileName(folder);
                break;
            }

            DTFolderName = foldername;
        }

        public string GetTransferMode(string fileName)
        {
            string folderName = string.Empty, mode = string.Empty;
            //string filePathRegex = "(?<datetime>(19|20)[0-9]{2}\\d{4,}_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d)/(.*).xml";
            string filePathRegex = "(?<DTsubfolder>[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12]\\d|3[01])_(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d[0-9]{3}[0-9]{4})/(.*).xml";

            if (Regex.IsMatch(fileName, filePathRegex, RegexOptions.Singleline))
            {
                MatchCollection matchcoll = Regex.Matches(fileName, filePathRegex);
                foreach (Match m in matchcoll)
                {
                    //if (!string.IsNullOrEmpty(m.Groups["datetime"].Value))
                    if (!string.IsNullOrEmpty(m.Groups["DTsubfolder"].Value))
                    {
                        //folderName = m.Groups["datetime"].Value;
                        folderName = m.Groups["DTsubfolder"].Value;
                        DTFolderName = folderName;
                        break;
                    }

                }

                //mode = GlobalConstants.AUTOMIZED_MODE + "," + folderName;
                mode = GlobalConstants.AUTOMIZED_MODE;
            }
            else
            {
                mode = GlobalConstants.NORMAL_MODE;
            }

            return mode;

        }


        public XmlDocument FrameMsgACKREQ(XmlDocument msgAck, string sACKFileName)
        {

            string sMSGACK = string.Empty;
            sMSGACK = msgAck.OuterXml;
            XDocument xTransmitterReq = new XDocument();
            //XNamespace ns0 = "http://www.bosch.com/de/cdgsmt/daimler/transmitter/services";
            XNamespace ns0 = "http://www.bosch.com/edexas/asam/transmitter/services";
            xTransmitterReq.Add(new XElement(ns0 + "transmitterRequest", new XAttribute(XNamespace.Xmlns + "ns0", ns0)));

            /*xTransmitterReq.Root.Add(new XElement("transferData", "sMSGACK"));
              xTransmitterReq.Root.Add(new XElement("transferType", "MESSAGE_ACKNOWLEDGE"));*/

            xTransmitterReq.Root.Add(new XElement("transferData", sMSGACK));//sMSGACK test
            xTransmitterReq.Root.Add(new XElement("transferType", "MsgAckn"));//MsgAckn
            xTransmitterReq.Root.Add(new XElement("transferFile", sACKFileName));//sACKFileName

            return ConvertXDocToXmlDoc(xTransmitterReq);

        }

        public XmlDocument FrameMsgACKREQ(string sACKfolderName, string sACKFileNameWO,string rq1System,string interfaceName,string xProtID, Logger objLogger, string category)
        {

            string sACKfileName = sACKFileNameWO + ".xml";
            string sACKZIPName = sACKFileNameWO + ".zip";
            string sACKZIPfilePath = sACKfolderName + "/" + sACKZIPName;
            int iFileAccessRetries = 0;
            Boolean bIsFileZipped = false;
            do
            {
                try
                {
                    //Create ZIP file
                    using (FileStream fs = new FileStream(sACKZIPfilePath, FileMode.Create))
                    {
                        using (ZipArchive arch = new ZipArchive(fs, ZipArchiveMode.Create))
                        {
                            arch.CreateEntryFromFile(sACKfolderName + "/" + sACKfileName, sACKfileName);
                            bIsFileZipped = true;
                        }
                    }
                }
                catch (IOException ex)
                {
                    objLogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Exception while zipping the MSG-ACK file " + ex.Message);
                    iFileAccessRetries++;
                    //objLogger.LogInfo(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Retry Count: " + iFileAccessRetries);
                    System.Threading.Thread.Sleep(500);
                }


            } while (bIsFileZipped == false && iFileAccessRetries <= 5);

            XDocument xTransmitterReq = new XDocument();

            if (File.Exists(sACKZIPfilePath))
            {
                //Convert zip file to binary data
                byte[] br = File.ReadAllBytes(sACKZIPfilePath);
                string sMsgAck = Convert.ToBase64String(br);

                //XNamespace ns0 = "http://www.bosch.com/de/capsst/esm3/daimler/transmitter/services";
                //XNamespace ns0 = "http://www.bosch.com/edexas/asam/transmitter/services";
                //Namespace changed as there is a mapping before sending the final transmitter request - Part of ALM task - 574607
                XNamespace ns0 = "http://FTPIssueTransfer.InitialTransmitterRequestSchema";

                xTransmitterReq.Add(new XElement(ns0 + "transmitterRequest", new XAttribute(XNamespace.Xmlns + "ns0", ns0)));
                xTransmitterReq.Root.Add(new XElement("transferBinary", sMsgAck));
                xTransmitterReq.Root.Add(new XElement("transferType", "MESSAGE_ACKNOWLEDGE"));
                xTransmitterReq.Root.Add(new XElement("transferFile", sACKZIPName));
                xTransmitterReq.Root.Add(new XElement("RQ1System", rq1System));
                xTransmitterReq.Root.Add(new XElement("InterfaceName", interfaceName));
                xTransmitterReq.Root.Add(new XElement("XProtID", xProtID));
                xTransmitterReq.Root.Add(new XElement("Category", category));
            }

            return ConvertXDocToXmlDoc(xTransmitterReq);

        }

        public XmlDocument ConvertXDocToXmlDoc(XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }
            return xmlDocument;
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


        public XmlDocument AddDummyTagToResponse(XmlDocument msgres)
        {
            try
            {
                XDocument xmsg = new XDocument();
                //XNamespace xftpns = "http://FTPIssueTransfer.Schema1";
                xmsg = ConvertXMLtoXdoc(msgres);
                xmsg.Root.Add(new XElement("Dummy", "test"));
                return ConvertXDocToXmlDoc(xmsg);
            }
            catch (Exception ex)
            {
                return msgres;
            }
        }


        public XmlDocument GetEmptyResponse(XmlDocument msgres)
        {
            XDocument xmsg = new XDocument();
            try
            {

                xmsg = ConvertXMLtoXdoc(msgres);

                xmsg.Root.Elements().ElementAt(2).Remove();
                xmsg.Root.Elements().ElementAt(3).Remove();
                xmsg.Root.Elements().ElementAt(4).Remove();
                // xmsg.Root.Elements().ElementAt(5).Remove();
                // xmsg.Root.Elements().ElementAt(6).Remove();


            }
            catch (Exception ex)
            {
                //return msgres;
            }

            return ConvertXDocToXmlDoc(xmsg);
        }

        /// <summary>
        /// Sends mail to admins on failure of daimler transmitter
        /// </summary>
        /// <param name="sInterface"></param>
        /// <param name="msgACKFileName"></param>
        public bool SendMailToAdmins(string sInterface, string rq1System,string msgACKFileName,string xProtID,Logger roLogger)
        {
            bool returnStatus = false;
            try
            {
                roLogger.LogInfo("Inside SendMailToAdmins method");
                FTPConfigurationHandler configHandler = new FTPConfigurationHandler();
                XElement xProperty = configHandler.GetInterfaceSettingsProp(sInterface, GlobalConstants.EMAILSETTINGS);
                if (xProperty != null)
                {
                    string smtpServerValue = xProperty.Element(GlobalConstants.SMTP).Value;
                    string smtpUser = xProperty.Element("EMAIL_USER").Value;
                    string smtpPassword = xProperty.Element("EMAIL_PASSWORD").Value;
                    string dcryptPassword = DecryptString(smtpPassword, "RO"); 

                    XElement xTransmitter = xProperty.Element(GlobalConstants.TRANSMITTERALERT);
                    string enableAlertValue = xTransmitter.Element(GlobalConstants.ENABLEALERT).Value;
                    roLogger.LogInfo(" Password: " + dcryptPassword);
                    var basicCredential = new NetworkCredential(smtpUser, dcryptPassword);
                    if (!string.IsNullOrEmpty(enableAlertValue) && string.Compare(enableAlertValue,"TRUE",true) == 0)
                    {
                        MailMessage NewMail = new MailMessage(xTransmitter.Element(GlobalConstants.BTEMAIL).Value, xTransmitter.Element(GlobalConstants.ADMINEMAIL).Value);
                        SmtpClient smtpServer = new SmtpClient(smtpServerValue);
                        smtpServer.EnableSsl = true;
                        smtpServer.UseDefaultCredentials = false;
                        smtpServer.Credentials = basicCredential;

                        NewMail.Subject = xTransmitter.Element(GlobalConstants.EMAIL).Element(GlobalConstants.SUBJECT).Value + rq1System;

                        NewMail.Body = xTransmitter.Element(GlobalConstants.EMAIL).Element(GlobalConstants.MESSAGE).Value.Replace(GlobalConstants.MSGACKFILE, msgACKFileName) + System.Environment.NewLine + "ExchangeProtocol : " + xProtID + System.Environment.NewLine + System.Environment.NewLine + xTransmitter.Element(GlobalConstants.EMAIL).Element(GlobalConstants.FOOTER).Value;

                        smtpServer.Send(NewMail);
                        returnStatus = true;
                    }
                    else
                    {
                        System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "ENABLE_ALERT is FALSE..Please set it to TRUE to send alerts related to transmitter");
                        roLogger.LogInfo("Inside SendMailToAdmins - ENABLE_ALERT is FALSE..Please set it to TRUE to send alerts related to transmitter");
                    }
                }
                else
                {
                    System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Config file not loaded");
                    roLogger.LogInfo("Inside SendMailToAdmins - Config file not loaded");
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Error while sending mail " + ex.Message);
                roLogger.LogException(ex,string.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Error while sending mail related to transmitter");
            }
            return returnStatus;
        }
    }
    public static class Testings
        {

            public static int utf8Length(string fileName)
            {
                int len;
                byte[] byteStream;

                byteStream = Encoding.UTF8.GetBytes(fileName);
                len = byteStream.GetUpperBound(0);
                return len + 1;
            }

            public static string utf8Trunc(string fileName)
            {
                int lenFileName = fileName.Length;
                int lenExtender;
                int i;
                string truncTry;
                string fileBody, fileExtender;

                fileBody = System.Text.RegularExpressions.Regex.Replace(fileName, "(.+)\\.\\w*?$", "$1");
                fileExtender = System.Text.RegularExpressions.Regex.Replace(fileName, ".+(\\.\\w*?)$", "$1");
                lenExtender = fileExtender.Length;

                //iteratively compose truncFileName 
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

            public static int utf8Check(string sampleText)
            {
                int len = 0;
                byte[] byteStream;

                try
                {
                    byteStream = Encoding.UTF8.GetBytes(sampleText);
                    len = byteStream.GetUpperBound(0);
                }
                catch
                {
                    len = 0;
                }
                return len + 1;
            }
            public static bool isoCheck(string fileName)
            {
                string rline, iline;
                int count = 0;
                byte[] utfByteStream;
                byte[] isoByteStream;
                //Encoding iso = Encoding.GetEncoding("ISO-8859-1", new EncoderExceptionFallback(), new DecoderExceptionFallback());
                Encoding iso = Encoding.GetEncoding(1252, new EncoderExceptionFallback(), new DecoderExceptionFallback());
                Encoding utf8 = Encoding.UTF8;

                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader r = new StreamReader(fs, Encoding.UTF8);

                while ((rline = r.ReadLine()) != null)
                {
                    count++;
                    utfByteStream = Encoding.UTF8.GetBytes(rline);

                    try
                    {
                        isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                    }
                    catch (EncoderFallbackException e)
                    {
                        System.Diagnostics.Debug.Write("a non iso-8859-1 compliant character was found at line: " + count.ToString() + "\n");
                        return false;
                    }

                    iline = iso.GetString(isoByteStream);
                    //Console.WriteLine(iline);
                    //System.Diagnostics.Debug.Write(iline);
                }

                r.Close();
                fs.Close();

                return true;
            }

            public static bool isoCheckString(string rline)
            {
                string iline;
                byte[] utfByteStream;
                byte[] isoByteStream;
                //Encoding iso = Encoding.GetEncoding("ISO-8859-1", new EncoderExceptionFallback(), new DecoderExceptionFallback());
                Encoding iso = Encoding.GetEncoding(1252, new EncoderExceptionFallback(), new DecoderExceptionFallback());
                Encoding utf8 = Encoding.UTF8;

                utfByteStream = Encoding.UTF8.GetBytes(rline);

                try
                {
                    isoByteStream = Encoding.Convert(utf8, iso, utfByteStream);
                }
                catch (EncoderFallbackException e)
                {
                    System.Diagnostics.Debug.Write("a non iso-8859-1 compatible character was found at line: " + rline + "\n");
                    return false;
                }
                iline = iso.GetString(isoByteStream);
                //Console.WriteLine(iline);
                System.Diagnostics.Debug.Write(iline + "\n");

                return true;

            }

            public static bool XMLValidationBySchema(string aiPath, string xsdSchemaPath)
            {
                bool isValidXML = true;
                StringBuilder oErrors = new StringBuilder();

                XDocument oASAMDoc = XDocument.Load(aiPath);
                XmlSchemaSet oSchemas = new XmlSchemaSet();
                oSchemas.Add(null, XmlReader.Create(xsdSchemaPath));

                oASAMDoc.Validate(oSchemas, (o, e) =>
                {
                    oErrors.Append(e.Message + System.Environment.NewLine);
                    isValidXML = false;
                });

                return isValidXML;
            }

            public static string SetTAFileNamexx(string FileName)
            {
                FileName = "25004_70982_REQUESTED_20140731_160428.xml";
                //string fileNameRegex = "(?<number>^\\d{5})_(?<text>REQUESTED|ACCEPTED|REJECTED|APPROVED|ACCEPTED_PILOT|REJECTED_PILOT|CLOSED-OK|CLOSED-NOT-OK|CANCELED)_(?<date>(19|20)[0-9]{2}\\d{4,})_(?<time>(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d).XML";           

                string fileNameRegex = "(?<number1>^\\d{5})_(?<number2>\\d{5})_(?<date>(19|20)[0-9]{2}(0[1-9]|1[012])(\\d+))_(?<text>REQUESTED|ACCEPTED|REJECTED|APPROVED|ACCEPTED_PILOT|REJECTED_PILOT|CLOSED-OK|CLOSED-NOT-OK|CANCELED)_(?<date>(19|20)[0-9]{2}\\d{4,})_(?<time>(20|21|22|23|[0-1]\\d)[0-5]\\d[0-5]\\d).XML";

                string state = "TRANSFER-ACKNOWLEDGEMENT";
                string stateold = string.Empty;

                string retFileName = FileName;

                if (Regex.IsMatch(FileName, fileNameRegex, RegexOptions.Singleline))
                {
                    MatchCollection matchcoll = Regex.Matches(FileName, fileNameRegex);
                    foreach (Match m in matchcoll)
                    {
                        if (!string.IsNullOrEmpty(m.Groups["text"].Value))
                        {
                            stateold = m.Groups["text"].Value;
                            break;
                        }
                    }
                    retFileName = FileName.Replace(stateold, state);
                }

                return retFileName;

            }
        }
}


