using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;  // zB XDocument
using System.Xml.Schema;  // added for XMLValidationBySchema
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
//using RB.BTLogger;

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


        public bool CheckInterfaceName(string ROInterfaceName, string RQ1TargetSystem)
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

                        // add TargetSystemSettings

                        foreach (var tss in inf.XPathSelectElements("./TARGET-SYSTEM-SETTINGS/SYSTEM-SETTING"))
                        {

                            if (tss.XPathSelectElement("./TARGET-SYSTEM").Value.ToString() == RQ1TargetSystem)
                            {
                                if (tss.XPathSelectElement("./ENABLED").Value.ToString() == "1")
                                {
                                    infValid = true;
                                }

                            }

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


        public string GetIFFTPProp(string ROInterfaceName, string TargetSystem, string FTPPropName)
        {
            string xVal = "";
            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {

                    foreach (var tss in inf.XPathSelectElements("./TARGET-SYSTEM-SETTINGS/SYSTEM-SETTING"))
                    {
                        if (tss.XPathSelectElement("./TARGET-SYSTEM").Value.ToString() == TargetSystem)
                        {
                            foreach (var prop in tss.XPathSelectElements("./FTPSETTINGS/*"))
                            {
                                if (prop.Name.ToString() == FTPPropName)
                                {
                                    xVal = prop.Value.ToString();
                                }
                            }
                        }
                    }
                }
            }
            return xVal;
        }

        public string GetIFTagByUniqueXPath(string ROInterfaceName, string tagPath)
        {

            string xVal = "";

            xVal = XConfig.Root.XPathSelectElement(tagPath).Value.ToString();

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
                            attTags = new string[numberOfAttLocs, 3];  // 0-based array
                            i = 0;
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

        public string[,] GetIFSchemaComSpecs(string ROInterfaceName, string SCPath)
        {
            int numberOfComSpecLocs, i; //number of AttachmentLocations
            string[,] comSpecs = new string[5, 2];
            bool schemaPathFound=false;



            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {
                    foreach (var sci in inf.XPathSelectElements("./SCHEMA-RELATED-INFOS/SCHEMA-INFO"))
                    {
                        if (SCPath == sci.XPathSelectElement("./SCHEMA-FILEPATH").Value.ToString())
                        {
                            schemaPathFound = true;
                            numberOfComSpecLocs = sci.XPathSelectElements("./COMMERCIAL-SPECS/*").Count();
                            comSpecs = new string[numberOfComSpecLocs, 2];  // 0-based array indexing, 1-based array dimensioning
                            i = 0;
                            foreach (var comSpecLoc in sci.XPathSelectElements("./COMMERCIAL-SPECS/*"))
                            {
                                comSpecs[i, 0] = comSpecLoc.XPathSelectElement("./COMMERCIAL-STATE").Value.ToString();
                                comSpecs[i, 1] = comSpecLoc.XPathSelectElement("./COMMERCIAL-FILENAME").Value.ToString();
                                i++;
                            }
                        }
                    }
                }
            }

            if (schemaPathFound == false)
            {
                // if schemapath could not be found, care for comSpecs array to be reduced
                comSpecs = new string[0, 2];  // 0-based array indexing, 1-based array dimensioning
            }


            return comSpecs;
        }
    
    }




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
        public string FTPServer, FTPUser, FTPPassword, FTPBaseDirectory, FTPSuccessDirectory, FTPFilterRegex;
        public bool FTPHandlerValid = false;
        public string[,] FTPSchemaAttachments;
        // static eliminiated 4.5.11

        

        public FTPHandler(string ROInterfaceName, string TargetSystem)
        {
            bool infExists = false; // interface exists
            ConfigurationHandler CH = new ConfigurationHandler();

            FTPInterfaceName = ROInterfaceName;
            RQ1TargetSystem = TargetSystem;

            //load Conf & check Interface

            infExists = CH.CheckInterfaceName(ROInterfaceName, RQ1TargetSystem);

            // load FTPSettings to Class variables
            if (infExists)
            {
                FTPServer = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SERVER");
                FTPUser = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "LOGIN");
                FTPPassword = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "PASSWORD");
                FTPBaseDirectory = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "BASEPATH");
                FTPSuccessDirectory = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "SUCCESSPATH");
                FTPFilterRegex = CH.GetIFFTPProp(ROInterfaceName, RQ1TargetSystem, "FILTERREGEX");
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
                if (System.Text.RegularExpressions.Regex.IsMatch(rawLineStr, "^[\\w-]+\\.xml"))
                {
                    // extract filename from ftp line:
                    //tmpStr = System.Text.RegularExpressions.Regex.Replace(rawLineStr, ".* (\\S+\\.xml)", "$1") + ",";
                    //tmpStr = System.Text.RegularExpressions.Regex.Replace(rawLineStr, ".* (\\S+\\.xml)", "$1");  // tmpStr contains xml-filename only
                    tmpStr = rawLineStr;
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
                //try
                //{
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
                //FTPEscFileName = FTPFileName;

                try
                {
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPEscFileName));
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

            bool aiIsValid=true;

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


                    if (aiIsValid)
                    {
                        retvFin.rSuccess = true;
                        retvFin.rMessage = "";
                    }
                    else
                    {
                        retvFin.rSuccess = false;
                        retvFin.rMessage = "asam issue file could not be validated against xsd";
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


        public string CheckFile4IsoConformance(string FTPFileName, string localSubDir)
        {
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir + "\\" + FTPFileName;
            string failureMessage;

            string rline, iline;
            int count = 0;
            byte[] utfByteStream;
            byte[] isoByteStream;
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
                    return failureMessage;
                }

                //for debug only:
                //iline = iso.GetString(isoByteStream);
                //System.Diagnostics.Debug.Write(iline);
            }

            r.Close();
            fs.Close();

            return "o.k.:" + FTPFileName;        
        }

        public retStrBool CheckCommercialFiles(string AIFileName, string localSubDir, string comFileList)
        {
            string[,] commercialSpecs;
            
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string aiPath = localDownloadPath + "\\" + AIFileName;

            string schemaPath = "";
            string statusXPath = "";
            string aiStatus = "";
            string attFileList = "";

            retStrBool retv1 = new retStrBool(); // return variables
            retStrBool retv2 = new retStrBool(); // return variables
            retStrBool retv3 = new retStrBool(); // return variables
            retStrBool retv4 = new retStrBool(); // return variables
            retStrBool retvFin = new retStrBool(); // return variables

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
                            if ((commercialSpecs[i,1]!="") && (AIFileName.ToUpper().Contains(commercialSpecs[i, 1].ToUpper())) && (aiStatus.ToUpper() != commercialSpecs[i, 0].ToUpper()))
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
                retvFin.rMessage = "Schema could not parsed from Asam Issue file.";
            }

            // prepare return variable for successfully identified files
            if (retvFin.rSuccess == true)
            {
                retvFin.rString = comFileList;
                retvFin.rMessage = "";
            }

            return retvFin;
        }

        public retStrBool GetSchemaFilePath(string aiPath)
        {
            string aiLine, aiSchemaFilepath=""; // AsamIssueLine ...
            string message = "";
            bool success = true;

            retStrBool retv = new retStrBool();

            //read AIFile to determine schemalocation
            FileStream strm = new FileStream(aiPath, FileMode.Open);
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

            return retv;
        }

        public retStrBool GetSchemaStatusTag(string schemaPath, string tagName)
        {
            string confTagPath, statusPath;
            retStrBool retv = new retStrBool();

            //CH needs to be initialized because other tags than in FTPHandler shall be accessed:
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName, RQ1TargetSystem);

            //construct tagPath
            // /CONFIGURATIONS/INTERFACE[INTERFACE_NAME="RO-ASAM-AUDI"]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd"]/STATUS-TAG/text()
            confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH=""" + schemaPath + @"""]/STATUS-TAG";

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            statusPath = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);


            if (!statusPath.Contains("ISSUE-STATE"))
            {
                retv.rString = "";
                retv.rSuccess = false;
                retv.rMessage = "STATUS-TAG could not be found in FTP config";
            }
            else
            {
                retv.rString = statusPath;
                retv.rSuccess = true;
                retv.rMessage = "";
            }

            return retv;
        }

        public retStrBool GetSchemaTag(string schemaPath, string tagName, string valSubStr)
        {
            string confTagPath, tagValue;
            retStrBool retv = new retStrBool();

            //CH needs to be initialized because other tags than in FTPHandler shall be accessed:
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName, RQ1TargetSystem);

            //construct tagPath
            // /CONFIGURATIONS/INTERFACE[INTERFACE_NAME="RO-ASAM-AUDI"]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH="http://www.asam.net/schemas/issue/issue300 issue_v3_0_0.sl.xsd"]/STATUS-TAG/text()
            confTagPath = @"/CONFIGURATIONS/INTERFACE[INTERFACE_NAME=""" + FTPInterfaceName + @"""]/SCHEMA-RELATED-INFOS/SCHEMA-INFO[SCHEMA-FILEPATH=""" + schemaPath + @"""]/" + tagName;

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            tagValue = CH.GetIFTagByUniqueXPath(FTPInterfaceName, confTagPath);

            //test if valSubStr is part of resulting tagValue
            if (!tagValue.Contains(valSubStr))
            {
                retv.rString = "";
                retv.rSuccess = false;
                retv.rMessage = tagName + " could not be found in FTP config";
            }
            else
            {
                retv.rString = tagValue;
                retv.rSuccess = true;
                retv.rMessage = "";
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
            string aNamespace=""; //ASAM NAMESPACE


            XDocument xAIFile = null;


            //first get ASAM NAMESPACE, which is different from SCHEMA LOCATION = schemaPath

            retv1 = GetSchemaTag(schemaPath, "ASAM-NAMESPACE", @"http://www.asam.net/schemas/issue");
            aNamespace = retv1.rString;

            if (System.IO.File.Exists(aiPath) == true)
            {
                //File Exists, start processing
                try
                {
                    reader = new XmlTextReader(aiPath);
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
                    retv2.rString = "";
                    retv2.rSuccess = false;
                    retv2.rMessage = "Error in reading asam issue status tag.";
                    return retv2;
                }
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

        public  string[,] GetSchemaComSpecs(string schemaPath)
        {

            string [,] comSpecs;

            //CH needs to be initialized because other tags than in FTPHandler shall be accessed:
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName, RQ1TargetSystem);

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
            comSpecs = CH.GetIFSchemaComSpecs(FTPInterfaceName, schemaPath);

            return comSpecs;
        }

        public retStrBool GetSchemaAttFileNames(string aiPath, string schemaPath)
        {
            retStrBool retv = new retStrBool(); // return variables

            bool success = true;
            string message = "";

            string [,] attTags;
            string labelTag, urlTag;
            string attFileNames="";

            //CH needs to be initialized because other tags than in FTPHandler shall be accessed:
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName, RQ1TargetSystem);

            // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations; nodeOrderNumber,
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


        public retStrBool DownloadIssueAttachments(string AIFileName, string localSubDir)
        {
            //CH needs to be initialized because other tags than in FTPHandler shall be accessed:
            ConfigurationHandler CH = new ConfigurationHandler();
            CH.CheckInterfaceName(FTPInterfaceName, RQ1TargetSystem);

            retStrBool retv1 = new retStrBool(); // return variables
            retStrBool retvFin = new retStrBool(); // return variables

            bool failureOccured = false;
            string failureMessage = "";
            string localDownloadPath = GlobalConstants.FTP_LOCAL_BASE_DIR + localSubDir;
            string AILongFileName = localDownloadPath + "\\" + AIFileName;
            string              labelTag, urlTag;

            string dlFiles = "";
            string tmpStr="";
            string aiSchemaFilepath; // AsamIssueLine ...


            // read in ai from dldir and parse out schemPath
            retv1 = GetSchemaFilePath(AILongFileName);
            aiSchemaFilepath = retv1.rString;

            if (retv1.rSuccess)
            {
                // get array of AttachmentsLocations[X,Y]; ubound(X):number of different locations
                FTPSchemaAttachments = CH.GetIFATTTags(FTPInterfaceName, aiSchemaFilepath);

                //read AIFile to find AttachmentLocations:
                FileStream strm = new FileStream(AILongFileName, FileMode.Open);
                XPathDocument xdoc = new XPathDocument(strm);
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
                retvFin.rSuccess = true;
                retvFin.rMessage = System.Text.RegularExpressions.Regex.Replace(dlFiles, ", $", "");
            }

            return retvFin;
        }


        public string ShiftSourceFile(string successFileName)
        {
            bool fExists = false; // file exists
            string shiftResult = "";

            fExists = CheckSingleFTPFile(successFileName);

            if (fExists)
            {
                if (FTPHandlerValid)
                {
                    shiftResult = ShiftSingleFTPFile(successFileName, FTPSuccessDirectory);
                }
            }

            else
            {
                return "failure:FTP file not found";
            }

            return shiftResult;
        }

        public string ShiftSingleFTPFile(string FTPFileName, string FTPSubDir)
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
                    FTPRq = (FtpWebRequest)FtpWebRequest.Create(new System.Uri(FTPServer + FTPFileName));
                    FTPRq.Credentials = new NetworkCredential(FTPUser, FTPPassword);
                    FTPRq.UseBinary = true;
                    FTPRq.Method = WebRequestMethods.Ftp.Rename;
                    FTPRq.RenameTo =FTPSubDir + "/" + FTPFileName;
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
                    return "failure:shift to FTP target directory failed";
                }
            }


            if (shiftOK)
            {
                return "ok:shift to FTP target directory succeeded";
            }
            else return "failure:ShiftSingleFTPFile failed.";
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

        public static int utf8Check(string sampleText)
        {
            int len=0;
            byte[] byteStream;
            string res;

            try
            {
                byteStream = Encoding.UTF8.GetBytes(sampleText);
                len = byteStream.GetUpperBound(0);
            }
            catch
            {
                res = "error: input string contains non utf8 characters";
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

    }
}
