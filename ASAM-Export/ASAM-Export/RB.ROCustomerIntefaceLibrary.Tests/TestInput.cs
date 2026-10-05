using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    public class TestInput
    {

    
        public string XProtID { get; set; }
        public string InterfaceName { get; set; }
        public string RQ1System { get; set; }
        public string LifeTokenForFiles { get; set; }
        public string LifeTokenForXProt { get; set; }

        public static TestInput FromXml(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            var nsMgr = new XmlNamespaceManager(doc.NameTable);
            nsMgr.AddNamespace("ns0", "http://FTPIssueTransfer.FTPFileInformation");

            return new TestInput
            {
                XProtID = doc.SelectSingleNode("//ns0:XProtID", nsMgr)?.InnerText,
                InterfaceName = doc.SelectSingleNode("//ns0:InterfaceName", nsMgr)?.InnerText,
                RQ1System = doc.SelectSingleNode("//ns0:RQ1System", nsMgr)?.InnerText,
                LifeTokenForFiles = doc.SelectSingleNode("//ns0:LifeToken4Files", nsMgr)?.InnerText,
                LifeTokenForXProt = doc.SelectSingleNode("//ns0:LifeToken4XProt", nsMgr)?.InnerText,
            };
        }
    }

}
