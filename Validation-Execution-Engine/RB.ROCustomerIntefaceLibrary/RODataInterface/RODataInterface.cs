using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RB.ROCustomerIntefaceLibrary
{
    public abstract class RODataInterface
    {

        private XDocument xInterfacConfig;

        //REUBK 1916 do not use static
        //public static XDocument InterfaceConfigFile 
        //{
        //    get { return xInterfacConfig; }
        //    set { xInterfacConfig = value; }
        //}

        public XDocument InterfaceConfigFile
        {
            get { return xInterfacConfig; }
            set { xInterfacConfig = value; }
        }

        Logger objlogger = null;
        //REUBK 1916 do not use static
        //public static string InterfaceName { get; set; }



        //added by Karthik, 28-03-2011.
        /// <summary>
        /// Stores the project ID from the FTPTransferMessage. This varaible should be used instead of ProjectId from Config XML
        /// </summary>
        //public static string ROProjectId { get; set; }


        public string CQUser { get; set; }
        public string CQPasword { get; set; }
        public string CQRepo { get; set; }
        public string CQDB { get; set; }
        public string CQWebURL { get; set; }
        public string CQOSLCServer { get; set; }
        public string CQWebRecordFormat { get; set; }
        public string CQOSLCCOREVersion { get; set; }
        public string CQToolName { get; set; }
        public string CQToolVersion { get; set; }
        public string CQToolTesting { get; set; }

        public RODataInterface(string sSystemKey, string strExchangeFormat, Logger l_ologger)
        {
            objlogger = l_ologger;
            LoadConfigurations(sSystemKey, strExchangeFormat);
        }

        void LoadConfigurations(string sSystemKey, string strExchangeFormat)
        {
            try
            {
                objlogger.LogInfo("LoadConfigurations : starts" + strExchangeFormat, GlobalConstants.LOGGERLEVEL1);
                string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(strExchangeFormat + GlobalConstants.INTERFACE_CONFIG_PATTERN);

                objlogger.LogInfo("strConfigFilePath : " + strConfigFilePath, GlobalConstants.LOGGERLEVEL2);
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                InterfaceConfigFile = rConfigMgr.LoadConfigurationXML(strExchangeFormat);

                if (InterfaceConfigFile == null)
                {
                    //commented by Karthik
                    //InterfaceConfigFile = XDocument.Load("RO_Interface_Config.xml");
                    throw new Exception("LoadConfigurations(): Configration file missing ");
                }
                XElement xCQNode = InterfaceConfigFile.Element("CONFIGURATIONS")
                                                      .Element("REQUESTONE").Element("CQ")
                                                      .Element("SERVERS").Elements("SERVER")
                                                      .Where(n => n.FirstAttribute != null
                                                      && n.FirstAttribute.Value == sSystemKey)
                                                      .Select(n => n).Single();

                CQUser = xCQNode.Element("LDAPUSER").Value;
                CQPasword = Encryption.DecryptString(xCQNode.Element("PASSWORD").Value, "RO");
                CQDB = xCQNode.Element("DB").Value;
                CQRepo = xCQNode.Element("SCHEMAREPO").Value;
                CQWebURL = xCQNode.Element("CQWEB").Value;
                CQWebRecordFormat = xCQNode.Element("CQWEB_FORMAT").Value;
                CQOSLCCOREVersion = xCQNode.Element("OSLC_CORE_VERSION").Value;
                CQOSLCServer = xCQNode.Element("OSLCSERVER").Value;
                CQToolName = xCQNode.Element("TOOLNAME").Value;
                CQToolVersion = xCQNode.Element("TOOLVERSION").Value;
                CQToolTesting = xCQNode.Element("TOOLTESTING").Value;

            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "From LoadConfigurations() ");
            }
        }

        string GetProjectIDFromConfigXML()
        {
            string sProjectID = string.Empty;
            try
            {
                try
                {
                    XElement xProject = InterfaceConfigFile.Element("CONFIGURATIONS").Element("REQUESTONE").Element("PROJECTS").Element("PROJECT");
                    sProjectID = xProject.Element("ID").Value;
                }
                catch (Exception ex)
                {
                    //Utilities.objLogger.LogException(ex, "From GetProjectID()");
                }
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogException(ex, "From GetProjectID()");

            }
            return sProjectID;
        }

        //public virtual IQueryResult Query(string strQuery)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual object LockRecord(QueryParameters p_oQueryParameters, bool bLock)
        {
            return false;
        }

        public abstract IQueryResult Query(string strQuery);

        public abstract string Query(QueryParameters p_oQueryParameters, string sElement, string sAttribute);

        public abstract XDocument QueryAttachments(string strQuery);        


        public abstract IQueryResult Query(QueryParameters p_oQueryParameters, bool bMultipleRecChanges = false, XElement XROIDRule = null, string ExchangeProtocol = null);

        public abstract List<object> Query(QueryParameters p_oQueryParameters, bool bMultipleRecords);

        public abstract IQueryResult Insert(QueryParameters p_oQueryParameters);

        public abstract IQueryResult Update(QueryParameters p_oQueryParamaters);

        public abstract IQueryResult Delete(QueryParameters p_oQueryParameters);

        /// <summary>
        /// Returns the number records based on the query
        /// </summary>
        public abstract int RecordCount(QueryParameters p_oQueryParameters);

        public abstract Boolean RecordEditable(QueryParameters p_oQueryParameters);

        public virtual void Close() { }

        public abstract string GetInitialVal(string xprot);


    }
}
