using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;
using System.Xml;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class Utilities
    {
        /// <summary>
        /// This method will load BizTalk's AppConfig and get the Value for the KEY given
        /// </summary>
        /// <param name="strKey">Key against which the search will be performed</param>
        /// <returns>VALUE for the given KEY</returns>
        public static string LoadItemFromBizTalkAppConfig(string strKey)
        {

            string strValue = ConfigurationManager.AppSettings[strKey];
            return strValue;
        }

        public static string ExtractValueFromXIMF(XmlDocument ximf, string newTargetReleaseDBID, string attribute)
        {
            switch (attribute)
            {
                case "cq:OperationMode":
                    return "ASAM-EXPORT";

                case "cq:OperationContext":
                    return "EDES";

                case "cq:hasMappedIssue":
                    return ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/hasMappedIssue")?.InnerText;

                case "cq:hasMappedRelease":
                    string oldMappedRelease = ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/hasMappedRelease")?.InnerText;
                    int lastDashIndex = oldMappedRelease.LastIndexOf('-');
                    return oldMappedRelease.Substring(0, lastDashIndex + 1) + newTargetReleaseDBID;

                case "cq:ExternalComment":
                    return ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/ExternalComment")?.InnerText;

                case "cq:ExternalExchangeWorkflow":
                    return ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/ExternalExchangeWorkflow")?.InnerText;

                case "cq:ExternalNextState":
                    string ENS = ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/ExternalNextState")?.InnerText;
                    if (ENS.ToUpper() == "ESTIMATED")
                    {
                        return "PROPOSED";
                    }
                    else
                    {
                        return "REQUESTED";
                    }

                case "cq:ExternalUpdateVersion":
                    return "DAI00#RB00";


                case "cq:Tags":
                    XmlNode tagsNode = ximf.SelectSingleNode(".//IssueReleaseMaps/IssueReleaseMap/Tags");
                    string tagsXml = tagsNode?.InnerXml;

                    tagsXml = ConvertEstimatedToProposed(tagsXml);

                    return tagsXml;

                default:
                    return null;
            }
        }

        public static string ConvertEstimatedToProposed(string xmlInput)
        {
            // ✅ Fix: Wrap input
            xmlInput = $"<Root>{xmlInput}</Root>";

            var doc = XDocument.Parse(xmlInput);

            // 1. Change STATE
            var exportNode = doc.Descendants("EXPORT-MODIFICATION").FirstOrDefault();
            if (exportNode != null)
            {
                exportNode.Attribute("STATE")?.SetValue("PROPOSED");
            }

            // 2. Process all APSK + APSM nodes
            var nodes = doc.Descendants()
                           .Where(x => x.Name == "APSK" || x.Name == "APSM");

            foreach (var node in nodes)
            {
                node.Element("STATUS")?.SetValue("REQUESTED");

                node.Element("CLARIFICATION-STATUS")?.SetValue("Daimler klärt");

                // Handle NEWTARGETRELEASE
                var releaseNode = node.Element("NEWTARGETRELEASE");
                if (releaseNode != null)
                    releaseNode.Value = "";
                else
                    node.Add(new XElement("NEWTARGETRELEASE"));

                // Remove DESCRIPTION
                node.Element("DESCRIPTION")?.Remove();

                // Clean COMMENT
                var comment = node.Element("COMMENT");
                if (comment != null)
                {
                    string text = comment.Value;
                    comment.RemoveNodes();
                    comment.Value = text.Trim();
                }
            }

            // ✅ Return inner XML (remove wrapper)
            return string.Concat(doc.Root.Nodes());
        }

    }
}
