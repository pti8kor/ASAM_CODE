using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public static class TagsModificationService
    {

        public static string CreateExternalTags(string inputXml, string xsltContent)
        {
            var xslt = new XslCompiledTransform();

            using (var xsltReader = XmlReader.Create(new StringReader(xsltContent)))
            {
                xslt.Load(xsltReader);
            }

            var args = new XsltArgumentList();

            // Dynamic current time
            args.AddParam(
                "currentTime",
                "",
                DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
            );

            var settings = xslt.OutputSettings.Clone();
            settings.OmitXmlDeclaration = true;

            using (var xmlReader = XmlReader.Create(new StringReader(inputXml)))
            using (var stringWriter = new StringWriter())
            using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
            {
                xslt.Transform(xmlReader, args, xmlWriter);
                return stringWriter.ToString();
            }
        }

        //public static string ExtractNodesAfterExportModification(string tagsXml)
        //{
        //    if (string.IsNullOrWhiteSpace(tagsXml))
        //        return string.Empty;

        //    try
        //    {
                

        //        XmlDocument doc = new XmlDocument();
        //        doc.LoadXml(tagsXml);

        //        XmlNode exportNode = doc.SelectSingleNode("/Tags/EXPORT-MODIFICATION");

        //        if (exportNode == null)
        //            return string.Empty;

        //        StringBuilder result = new StringBuilder();

        //        //  Iterate ALL nodes after EXPORT-MODIFICATION
        //        XmlNode sibling = exportNode.NextSibling;

        //        while (sibling != null)
        //        {
        //            // Skip whitespace/text nodes
        //            if (sibling.NodeType == XmlNodeType.Element)
        //            {
        //                result.AppendLine(sibling.OuterXml);
        //            }

        //            sibling = sibling.NextSibling;
        //        }

        //        return result.ToString().Trim();
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //}


        public static string ExtractNodesAfterExportModification(string tagsXml)
        {
            if (string.IsNullOrWhiteSpace(tagsXml))
                return string.Empty;

            try
            {
                var doc = new XmlDocument();

                //  Wrap once to handle multiple roots
                doc.LoadXml(tagsXml);

                //  Get ALL nodes after EXPORT-MODIFICATION in one XPath
                var nodes = doc.SelectNodes("/Tags/EXPORT-MODIFICATION/following-sibling::*");

                if (nodes == null || nodes.Count == 0)
                    return string.Empty;

                return string.Join(Environment.NewLine,
                    nodes.Cast<XmlNode>().Select(n => n.OuterXml));
            }
            catch
            {
                return string.Empty;
            }
        }
    }

}
