using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RB.ROCustomerIntefaceLibrary
{
    public class ROConfigurationManager
    {
        #region Variables

        //private LogHelper objLogger = LogHelper.GetLoggerInstance(); 
        Logger objlogger = null;
        #endregion
        /// <summary>
        /// The constructor gets the Path from where the Ineterface configuration file needs to be loaded.
        /// the same is set to the Property ConfigXMLPath .
        /// </summary>
        /// <param name="strConfigFilePath">Path of the configuration file</param>
        public ROConfigurationManager(string strConfigFilePath,Logger l_ologger)
        {
            ConfigXMLPath = strConfigFilePath;
            objlogger = l_ologger;               
        }
        /// <summary>
        /// Path of the Configuration XML file. Passed from the BTHelper Class
        /// </summary>
        public string ConfigXMLPath
        { get; set; }

        
        
        /// <summary>
        /// This proeprty stores the ConfigurationXML file
        /// </summary>
        public XDocument ConfigurationXML
        {
            get;
            set;
            //get { return LoadConfigurationXML(); }
        }

        /// <summary>
        /// LoadConfigurationXML() -> Loads the xml from ConfigXMLPath property based on the ExchangeFormat
        /// </summary>
        /// <remarks>Called when ConfigurationXML is used</remarks>
        /// <returns>Loaded XML Document (LINQ)</returns>
        public XDocument LoadConfigurationXML(string sInterfaceName)
        {

            objlogger.LogInfo("ROConfigurationManager::LoadConfigurationXML - Starts with ConfigXMLPath: " + ConfigXMLPath, GlobalConstants.LOGGERLEVEL1);
            XDocument xConfigXML = null;
            try
            {
               //objlogger.LogInfo("ConfigXMLPath: " + ConfigXMLPath);

                    if (ConfigXMLPath.Length > 0)
                    {
                        if (System.IO.File.Exists(ConfigXMLPath) == true)
                        {
                            //File RecordCount, start processing
                          // objlogger.LogInfo("xConfigXML - ConfigXMLPath: " + ConfigXMLPath);
                            xConfigXML = XDocument.Load(ConfigXMLPath);
                            ConfigurationXML = xConfigXML;
                            if (xConfigXML == null)
                            {
                                objlogger.LogInfo("Log file object Null", GlobalConstants.LOGGERLEVEL1);
                                throw new InterfaceConfigNotFoundException("Log file object Null");
                            }
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("Log file path not found", GlobalConstants.LOGGERLEVEL1);
                        throw new InterfaceConfigNotFoundException("Log file path not found");
                    }                
            }
            catch (InterfaceConfigNotFoundException ex)
            {
               //objlogger.LogInfo("Log file not found");
               objlogger.LogException(ex, "ROConfigurationManager::LoadConfigurationXML");
                xConfigXML = null;
            }
            catch (Exception ex)
            {
               objlogger.LogException(ex, "ROConfigurationManager::LoadConfigurationXML");
                xConfigXML = null;
            }
            finally
            {

            }
           //objlogger.LogInfo("ROConfigurationManager::LoadConfigurationXML - Ends");
            return xConfigXML;
        }

        

        public string GetIMFilePath()
        {
            string strIMFilePath = "";
            try
            {
                //IMFRULESVALIDATIONFILE

            }
            catch (Exception)
            {
                
                strIMFilePath="";
            }
            return strIMFilePath;
        }      
    }
}
