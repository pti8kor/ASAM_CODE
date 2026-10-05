using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class ConfigClass
    {
        public string recordId = string.Empty;

        public XDocument xInterfacConfig;
        public XDocument InterfaceConfigFile
        {
            get { return xInterfacConfig; }
            set { xInterfacConfig = value; }
        }


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

        public void LoadConfigurations(string sSystemKey, string strExchangeFormat, string recordId, AsyncLogger asyn_objlogger)
        {
            try
            {
                if (asyn_objlogger != null)
                    asyn_objlogger.LogInfoAsync(recordId, "LoadConfigurations : starts" + strExchangeFormat);
                string strConfigFilePath = BizTalkConfigParams.EX_RO_INTERFACE_CONFIG;
                if (asyn_objlogger != null)
                    asyn_objlogger.LogInfoAsync(recordId, "strConfigFilePath : " + strConfigFilePath);

                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, asyn_objlogger, recordId);
                InterfaceConfigFile = rConfigMgr.LoadConfigurationXML();

                if (InterfaceConfigFile == null)
                {

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
                if (asyn_objlogger != null)
                    asyn_objlogger.LogExceptionAsync(recordId, ex);
            }
        }
    }
}
