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
using System.Configuration;

namespace RB.FTPLibrary
{
    [Serializable]
    public class FTPConfigurationHandler
    {
        public XDocument XConfig, xCharMappingConfig = null;
        XDocument xdocConfig = null;
        string strConfigXMLPath = string.Empty;
        public void ReadConfigFile(string filePath, bool isCharMappingConfig = false)
        {
            string XMLFilePath;         
            try
            {

                XMLFilePath = filePath;

                if (XMLFilePath.Length > 0)
                {
                    if (System.IO.File.Exists(XMLFilePath) == true)
                    {
                        //File Exists, start processing
                        if (isCharMappingConfig)
                        {
                            xCharMappingConfig = XDocument.Load(XMLFilePath);
                        }
                        else
                        {
                            XConfig = XDocument.Load(XMLFilePath);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
               
            }
            finally
            {
            }                     
        }


        public bool CheckInterfaceName(string ROInterfaceName, string RQ1TargetSystem)
        {

            bool confValid = false;
            bool infValid = false;


            if (XConfig != null) confValid = true;

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


        public string GetIFFTPProp(string ROInterfaceName, string TargetSystem, string FTPPropName, bool bAttribute=false, string sAttr = "")
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
                                    if (bAttribute)
                                    {
                                        xVal = prop.Attribute(sAttr).Value.ToString();
                                    }                                   
                                    else
                                    {
                                        xVal = prop.Value.ToString();
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return xVal;
        }

        public retStrBool GetIFTagByUniqueXPath(string ROInterfaceName, string tagPath)
        {
            retStrBool retv1 = new retStrBool();

            string xVal = "";

            //REUBK-1377; error handling neccessary if tagPath is not available in BT_FTP_CONF
            //e.g. incoming 3.0.1 schemas

            try
            {                
                xVal = XConfig.Root.XPathSelectElement(tagPath).Value.ToString();
                retv1.rString = xVal;
                retv1.rSuccess = true;

            }
            catch (Exception e)
            {
                retv1.rSuccess = false;
                retv1.rMessage = "Error in getting ftp config data by XPath";
            }

            return retv1;

        }

        public string[,] GetIFATTTags(string ROInterfaceName, string SCPath)
        {
            int numberOfAttLocs, i; //number of AttachmentLocations
            string[,] attTags = new string[5, 3];

           
            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {
                    foreach (var sci in inf.XPathSelectElements("./SCHEMA-RELATED-INFOS/SCHEMA-INFO"))
                    {
                        if (SCPath == sci.XPathSelectElement("./SCHEMA-FILEPATH").Value.ToString())
                        //if (SCPath == sci.Attribute("VERSION").Value.ToString())
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
            string[,] comSpecs = new string[5, 3];
            bool schemaPathFound = false;



            foreach (var inf in XConfig.Root.XPathSelectElements("/CONFIGURATIONS/INTERFACE"))
            {
                if (ROInterfaceName == inf.XPathSelectElement("./INTERFACE_NAME").Value.ToString())
                {
                    foreach (var sci in inf.XPathSelectElements("./SCHEMA-RELATED-INFOS/SCHEMA-INFO"))
                    {
                        if (SCPath == sci.XPathSelectElement("./SCHEMA-FILEPATH").Value.ToString())
                        //if (SCPath == sci.Attribute("VERSION").Value.ToString())
                        {
                            schemaPathFound = true;
                            numberOfComSpecLocs = sci.XPathSelectElements("./COMMERCIAL-SPECS/*").Count();
                            comSpecs = new string[numberOfComSpecLocs, 3];  // 0-based array indexing, 1-based array dimensioning
                            i = 0;
                            foreach (var comSpecLoc in sci.XPathSelectElements("./COMMERCIAL-SPECS/*"))
                            {
                                comSpecs[i, 0] = comSpecLoc.XPathSelectElement("./COMMERCIAL-STATE").Value.ToString();
                                comSpecs[i, 1] = comSpecLoc.XPathSelectElement("./COMMERCIAL-FILENAME").Value.ToString();
                                comSpecs[i, 2] = comSpecLoc.XPathSelectElement("./COMMERCIAL-ANNOTATION").Value.ToString();
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

        public XElement GetInterfaceSettingsProp(string strInterface, string sPropName)
        {
            XElement xProp = null;
            try
            {
                if (LoadConfigxml(strInterface))
                {
                    xProp = xdocConfig.Root.Element("INTERFACE_SETTINGS").Element(sPropName);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Error in getting property from config file");
            }

            return xProp;
        }

        public bool LoadConfigxml(string strInterfaceName)
        {
            bool bResult = false;

            if (xdocConfig == null)
            {
                try
                {
                    System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "In Load config xml strInterfaceName: " + strInterfaceName);
                    strConfigXMLPath = LoadItemFromBizTalkAppConfig(strInterfaceName + GlobalConstants.INTERFACE_CONFIG_PATTERN);
                    System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer","strConfigXMLPath:" + strConfigXMLPath);
                    if (strConfigXMLPath.Length > 0)
                    {
                        if (System.IO.File.Exists(strConfigXMLPath) == true)
                        {
                            xdocConfig = XDocument.Load(strConfigXMLPath);
                            System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "After loading config file");
                            if (xdocConfig == null)
                            {
                                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Log file object is null");
                                throw new Exception("Log file object Null");
                            }
                            else
                            {
                                bResult = true;
                            }
                        }
                    }
                    else
                    {
                        System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Log file path not found");
                        throw new Exception("Log file path not found");
                    }
                }
                catch (Exception ex)
                {
                    bResult = false;
                    System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Error in loading interface config file" + ex.Message);
                    xdocConfig = null;
                }

            }
            else
            {
                bResult = true;
            }
            System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "LoadConfigxml ends, bResult :" + bResult);
            return bResult;
        }

        public static string LoadItemFromBizTalkAppConfig(string strKey)
        {
            string strValue = ConfigurationManager.AppSettings[strKey];
            return strValue;
        }
    }
}
