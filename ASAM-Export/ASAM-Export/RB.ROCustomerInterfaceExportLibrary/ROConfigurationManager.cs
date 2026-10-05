using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class ROConfigurationManager
    {
        #region Variables
        /// <summary>
        /// Path of the Configuration XML file. Passed from the BTHelper Class
        /// </summary>
        public string ConfigXMLPath
        { get; set; }

        //private LogHelper objLogger = LogHelper.GetLoggerInstance(); 
        Logger objlogger = null;
        AsyncLogger async_objlogger = null;
        string recordID = string.Empty;

        /// <summary>
        /// This proeprty stores the ConfigurationXML file
        /// </summary>
        public XDocument ConfigurationXML
        {
            get;
            set;
        }

        #endregion

        #region constructor
        /// <summary>
        /// The constructor gets the Path from where the Ineterface configuration file needs to be loaded.
        /// the same is set to the Property ConfigXMLPath .
        /// </summary>
        /// <param name="strConfigFilePath">Path of the configuration file</param>
        /// /// <param name="l_ologger">logger instace to log the file</param>
        public ROConfigurationManager(string strConfigFilePath, Logger l_ologger)
        {
            ConfigXMLPath = strConfigFilePath;
            objlogger = l_ologger;
        }

        /// <summary>
        /// The constructor gets the Path from where the Ineterface configuration file needs to be loaded.
        /// the same is set to the Property ConfigXMLPath .
        /// </summary>
        /// <param name="strConfigFilePath">Path of the configuration file</param>
        /// /// <param name="async_ologger">logger instace to log the file</param>
        ///  <param name="Record">recordID</param>
        public ROConfigurationManager(string strConfigFilePath, AsyncLogger async_ologger, string Record)
        {
            ConfigXMLPath = strConfigFilePath;
            async_objlogger = async_ologger;
            recordID = Record;
        }

        public ROConfigurationManager()
        {
            
        }
        #endregion 



        /// <summary>
        /// LoadConfigurationXML() -> Loads the xml from ConfigXMLPath property based on the ExchangeFormat
        /// </summary>
        /// <remarks>Called when ConfigurationXML is used</remarks>
        /// <returns>Loaded XML Document (LINQ)</returns>
        public XDocument LoadConfigurationXML()
        {

            Exception excpt = null;
            VerifyLoggerandSet("ROConfigurationManager::LoadConfigurationXML - Starts with ConfigXMLPath: " + ConfigXMLPath, recordID, excpt);
             
           
            XDocument xConfigXML = null;

            try
            {
               
                if (ConfigXMLPath.Length > 0)
                {
                    if (System.IO.File.Exists(ConfigXMLPath) == true)
                    {
                        xConfigXML = XDocument.Load(ConfigXMLPath);
                        VerifyLoggerandSet("Config file Loaded Successfully", recordID, excpt);
                        ConfigurationXML = xConfigXML;
                        if (xConfigXML == null)
                        {
                            VerifyLoggerandSet("Log file object Null", recordID, excpt); 
                            throw new InterfaceConfigNotFoundException("Log file object Null");
                        }
                    }
                }
                else
                {
                    VerifyLoggerandSet("Log file path not found", recordID, excpt);
                    throw new InterfaceConfigNotFoundException("Log file path not found");
                }
            }
            catch (InterfaceConfigNotFoundException ex)
            {
                //objlogger.LogInfo("Log file not found");
                VerifyLoggerandSet("ROConfigurationManager::LoadConfigurationXML", recordID, ex);
                
                xConfigXML = null;
            }
            catch (Exception ex)
            {
                VerifyLoggerandSet("ROConfigurationManager::LoadConfigurationXML", recordID, ex);
                
                xConfigXML = null;
            }
            finally
            {

            }
            //objlogger.LogInfo("ROConfigurationManager::LoadConfigurationXML - Ends");
            return xConfigXML;

        }

        /// <summary>
        /// call the logger methods based on object type.
        /// </summary>
        /// <param name="message">message string</param>
        ///  <param name="recordID">recordID</param>
        ///  <param name="ex">exception</param>
        public void VerifyLoggerandSet(string message, string recordID, Exception ex)
        {
            if (objlogger != null)
            {
                if(ex != null)
                {
                    objlogger.LogException(ex, message);
                }
                else
                {
                    objlogger.LogInfo(message, GlobalConstants.LOGGERLEVEL1);
                }
                
            }
            else
            {
                if (ex != null)
                {
                    if(async_objlogger != null)
                    {
                        async_objlogger.LogExceptionAsync(recordID, ex);
                    }
                     
                }
                else
                {
                    if (async_objlogger != null)
                    {
                        async_objlogger.LogInfoAsync(recordID, message);
                    }
                }
                
            }

            
        }
    }
}
