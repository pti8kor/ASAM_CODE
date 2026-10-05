using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class RO_OSLC_DataInterface : RODataInterface
    {
        private string sExchangeFormat;
        private AsyncLogger async_objlogger;
        private Logger obj_ologger;
        public string recordID = string.Empty;

        private static readonly HttpClient client = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMinutes(5)
            };

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

            return httpClient;
        }


        public RO_OSLC_DataInterface(string p_System, string p_sExchangeFormat, string RecordID, AsyncLogger async_ologger = null)
            : base(p_System, p_sExchangeFormat, RecordID, async_ologger)
        {
            sExchangeFormat = p_sExchangeFormat;
            async_objlogger = async_ologger;
            recordID = RecordID;

        }

        public XElement FetchTechnicalAttachments(string recordID, string dbid, string url, AsyncLogger async_objlogger)
        {
            return FetchAttachments(recordID, dbid, url, "Technical", async_objlogger);
        }


        public XElement FetchFinancialAttachments(string recordID, string dbid, string url, AsyncLogger async_objlogger)
        {
            return FetchAttachments(recordID, dbid, url, "Financial", async_objlogger);
        }

        /// <summary>
        /// Shared implementation for fetching attachments (Technical or Financial).
        /// </summary>
        private XElement FetchAttachments(string recordID, string dbid, string url, string attachmentType, AsyncLogger async_objlogger)
        {
            XElement attachmentsRoot = new XElement("Attachmentss");

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}")));

                var response = client.SendAsync(request).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    string atomXmlString = response.Content.ReadAsStringAsync().Result;

                    XNamespace atomNs = "http://www.w3.org/2005/Atom";
                    XNamespace cqNs = "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/";

                    XDocument inputDoc = XDocument.Parse(atomXmlString);

                    foreach (var entry in inputDoc.Descendants(atomNs + "entry"))
                    {
                        var filename = entry.Element(atomNs + "content")?
                                              .Element(cqNs + "attachment")?
                                              .Element(cqNs + "filename")?.Value;

                        var fileLink = entry.Element(atomNs + "id")?.Value;

                        if (!string.IsNullOrEmpty(filename))
                        {
                            attachmentsRoot.Add(new XElement("Attachments",
                                new XAttribute("recordtype", "Attachments"),
                                new XAttribute("dbid", dbid),
                                new XElement("entity_dbid", dbid),
                                new XElement("filename", filename),
                                new XElement("type", attachmentType),
                                new XElement("link", fileLink)
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                async_objlogger?.LogExceptionAsync(recordID, ex);
            }

            return attachmentsRoot;
        }


        public void UploadFilesInFolder(string folderPath, string xprotID, AsyncLogger async_objlogger)
        {
            async_objlogger.LogInfoAsync(recordID, "UploadFilesInFolder Method Starts");

            string url = string.Empty;
            XElement xQueryNode = null;

            
            if (folderPath.Contains("Commercial"))
            {
                xQueryNode = InterfaceConfigFile.Descendants("QUERY")
                    .FirstOrDefault(q => (string)q.Element("NAME") == GlobalConstants.QueryMethods.uploadCommercialFiles);
            }
            else
            {
                xQueryNode = InterfaceConfigFile.Descendants("QUERY")
                    .FirstOrDefault(q => (string)q.Element("NAME") == GlobalConstants.QueryMethods.uploadExchangedFiles);
            }

            url = xQueryNode.Element("baseurl").Value;
            url = url.Replace("recorddbid", xprotID);

            if (!Directory.Exists(folderPath))
            {
                async_objlogger.LogInfoAsync(recordID, folderPath + " Doesn't Exist.");
                return;
            }

            foreach (var filePath in Directory.GetFiles(folderPath))
            {
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, url);

                    // ✅ Per-request headers (SAFE)
                    request.Headers.Authorization =
                        new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}")));

                    using (var fileStream = File.OpenRead(filePath))
                    using (var content = new MultipartFormDataContent())
                    {
                        content.Add(new StreamContent(fileStream), "attachment", Path.GetFileName(filePath));
                        request.Content = content;

                        var response = client.SendAsync(request).GetAwaiter().GetResult();
                        response.EnsureSuccessStatusCode();
                    }

                    async_objlogger.LogInfoAsync(recordID, "Uploaded: " + Path.GetFileName(filePath));
                }
                catch (Exception ex)
                {
                    async_objlogger.LogInfoAsync(recordID, "Exception at UploadFilesInFolder");
                    async_objlogger.LogExceptionAsync(recordID, ex);
                }
            }
        }

        public string InvokeUrl4ReadOperation(string recordID, string url, AsyncLogger async_objlogger)
        {
            async_objlogger.LogInfoAsync(recordID, "InvokeURL Start: " + url);

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}")));

                request.Headers.Add("OSLC-Core-Version", "2.0");
                request.Headers.Add("x-requester", $"toolname={CQToolName};toolversion={CQToolVersion};user={CQWhiteLabelUser}");

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error invoking URL: {ex.Message}", ex);
            }
        }

        public string InvokeUrl4UpdateOperation(string recordID, string sUrlToInvoke, XmlDocument XIMF, string recordType, AsyncLogger async_objlogger)
        {
            async_objlogger.LogInfoAsync(recordID, "ClearQuest::InvokeURL : Starts with URL:\n" + sUrlToInvoke);

            try
            {
               
                var request = new HttpRequestMessage(HttpMethod.Put, sUrlToInvoke);

                var byteArray = Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}");
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                string sRequesterInfo = "toolname=" + CQToolName + ";toolversion=" + CQToolVersion + ";user=" + CQWhiteLabelUser;

                request.Headers.Add("OSLC-Core-Version", "2.0");
                request.Headers.Add("x-requester", sRequesterInfo);

                
                string xmlBody = GenerateBody(XIMF, sUrlToInvoke, recordType);
                sUrlToInvoke = ReBuildUrlFromBody(sUrlToInvoke, xmlBody);

                request.RequestUri = new Uri(sUrlToInvoke);
                request.Content = new StringContent(xmlBody, Encoding.UTF8, "application/xml");

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                async_objlogger.LogInfoAsync(recordID, response.Content.ReadAsStringAsync().Result);
                async_objlogger.LogInfoAsync(recordID, "ClearQuest::InvokeURL : ends");

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                async_objlogger.LogExceptionAsync(recordId, ex);
                async_objlogger.LogInfoAsync(recordID, "RQ1 Updation Failed due to an exception.");
                throw new Exception($"Error while invoking URL: {ex.Message}", ex);
            }
        }

        public string GenerateBody(XmlDocument XIMF, string url, string recordType)
        {
            string xmlbody = string.Empty;

            Match match = Regex.Match(url, @"^([^?]+)");
            url = match.Success ? match.Groups[1].Value : string.Empty;

            try
            {
                string dcTermsType = null;
                string xpathSelector = null;

                if (recordType.ToUpper() == "ISSUE")
                {
                    dcTermsType = "Issue";
                    xpathSelector = "//ISSUE";
                }
                else if (recordType.ToUpper() == "ISSUERELEASEMAP")
                {
                    dcTermsType = "Issuereleasemap";
                    xpathSelector = "//ISSUERELEASEMAP";
                }

                if (dcTermsType != null)
                {
                    XmlNamespaceManager nsManager = new XmlNamespaceManager(XIMF.NameTable);
                    nsManager.AddNamespace("ns0", "http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF");

                    XmlNode targetNode = XIMF.SelectSingleNode(xpathSelector, nsManager);

                    if (targetNode != null)
                    {
                        StringBuilder rdfXml = new StringBuilder();
                        rdfXml.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>");
                        rdfXml.AppendLine("<rdf:RDF ");
                        rdfXml.AppendLine("         xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"");
                        rdfXml.AppendLine("         xmlns:oslc=\"http://open-services.net/ns/core#\"");
                        rdfXml.AppendLine("         xmlns:dcterms=\"http://purl.org/dc/terms/\"");
                        rdfXml.AppendLine("         xmlns:cq=\"http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/\"");
                        rdfXml.AppendLine("         xmlns:oslc_cm=\"http://open-services.net/ns/cm#\"");
                        rdfXml.AppendLine("         xmlns:rdfs=\"http://www.w3.org/2000/01/rdf-schema#\">");
                        rdfXml.AppendLine("    <oslc_cm:ChangeRequest rdf:about=\"https://your-url-here\">");
                        rdfXml.AppendLine($"        <dcterms:type>{dcTermsType}</dcterms:type>");
                        rdfXml.AppendLine("        <cq:OperationMode rdf:ID=\"OperationMode\">ASAM-EXPORT</cq:OperationMode>");
                        rdfXml.AppendLine("        <cq:OperationContext rdf:ID=\"OperationContext\">EDES</cq:OperationContext>");

                        // Dynamically add all child elements
                        foreach (XmlNode child in targetNode.ChildNodes)
                        {
                            string tagName = child.Name;

                            //Special handling for Tags / ExternalTags
                            if (tagName.Equals("Tags", StringComparison.OrdinalIgnoreCase) ||
                                tagName.Equals("ExternalTags", StringComparison.OrdinalIgnoreCase))
                            {
                                // Decode the encoded XML
                                string innerXml = WebUtility.HtmlDecode(child.InnerXml.Trim());

                                if (!string.IsNullOrEmpty(innerXml))
                                {
                                    rdfXml.AppendLine($"        <cq:{tagName} rdf:ID=\"{tagName}\"><![CDATA[{innerXml}]]></cq:{tagName}>");
                                }
                            }
                            else
                            {
                                string tagValue = child.InnerText.Trim();

                                if (!string.IsNullOrEmpty(tagValue))
                                {
                                    rdfXml.AppendLine($"        <cq:{tagName} rdf:ID=\"{tagName}\">{tagValue}</cq:{tagName}>");
                                }
                            }
                        }

                        rdfXml.AppendLine("    </oslc_cm:ChangeRequest>");
                        rdfXml.AppendLine("    <rdf:Statement rdf:about=\"#OperationMode\">");
                        rdfXml.AppendLine("        <cq:fieldOrder>79</cq:fieldOrder>");
                        rdfXml.AppendLine("    </rdf:Statement>");
                        rdfXml.AppendLine("    <rdf:Statement rdf:about=\"#OperationContext\">");
                        rdfXml.AppendLine("        <cq:fieldOrder>78</cq:fieldOrder>");
                        rdfXml.AppendLine("    </rdf:Statement>");
                        rdfXml.AppendLine("</rdf:RDF>");

                        xmlbody = rdfXml.ToString();
                        xmlbody = xmlbody.Replace("https://your-url-here", url);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle as needed; currently matches original silent-catch behavior
            }

            return xmlbody;
        }

        public string InvokeUrl4CreateOperation(string recordID, string sUrlToInvoke, string newTargetReleaseDBID, string queryname, XmlDocument XIMF, string recordType, AsyncLogger async_objlogger)
        {
            async_objlogger.LogInfoAsync(recordID, "ClearQuest::InvokeURL : Starts with URL:\n" + sUrlToInvoke);

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, sUrlToInvoke);

                var byteArray = Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}");
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                string sRequesterInfo = "toolname=" + CQToolName + ";toolversion=" + CQToolVersion + ";user=" + CQWhiteLabelUser;

                request.Headers.Add("OSLC-Core-Version", "2.0");
                request.Headers.Add("x-requester", sRequesterInfo);

                XElement xQueryNode = InterfaceConfigFile.Descendants("QUERY")
                    .FirstOrDefault(q => (string)q.Element("NAME") == queryname);

                var attributes = xQueryNode.Element("attributes")?.Elements("attribute")
                    .Select(attr => attr.Value.Trim())
                    .ToList();

                string xmlBody = GenerateCreateBody(XIMF, newTargetReleaseDBID, attributes, sUrlToInvoke, recordType);

                request.Content = new StringContent(xmlBody, Encoding.UTF8, "application/xml");

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                async_objlogger.LogInfoAsync(recordID, response.Headers.Location.OriginalString);
                async_objlogger.LogInfoAsync(recordID, "ClearQuest::InvokeURL : ends");

                string createdRecord = response.Headers.Location.OriginalString;

                var lastSegment = createdRecord.Split('/').Last();
                var ID = lastSegment.Split('-').Last();

                return ID;
            }
            catch (Exception ex)
            {
                async_objlogger.LogExceptionAsync(recordId, ex);
                async_objlogger.LogInfoAsync(recordID, "RQ1 Updation Failed due to an exception.");
                throw new Exception($"Error while invoking URL: {ex.Message}", ex);
            }
        }

        public string GenerateCreateBody(XmlDocument XIMF,string newTargetReleaseDBID, List<string> attributes, string url, string recordType)
        {
            XNamespace rdf = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";
            XNamespace oslc = "http://open-services.net/ns/core#";
            XNamespace dcterms = "http://purl.org/dc/terms/";
            XNamespace cq = "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/";
            XNamespace oslc_cm = "http://open-services.net/ns/cm#";
            XNamespace rdfs = "http://www.w3.org/2000/01/rdf-schema#";

            var changeRequest = new XElement(oslc_cm + "ChangeRequest",
                new XElement(dcterms + "type", recordType)
            );

            List<XElement> rdfStatements = new List<XElement>();

            int fieldOrder = 70; // starting order (you can adjust)

            foreach (var attr in attributes)
            {
                string value = Utilities.ExtractValueFromXIMF(XIMF, newTargetReleaseDBID, attr);

                if (string.IsNullOrEmpty(value))
                    continue;

                string attrName = attr.Split(':')[1]; // cq:OperationMode → OperationMode

                // Create main element
                var element = new XElement(cq + attrName,
                    new XAttribute(rdf + "ID", attrName),
                    value
                );

                changeRequest.Add(element);

                // Add rdf:Statement for fieldOrder (ONLY for some fields if needed)
                if (attr == "cq:OperationMode" || attr == "cq:OperationContext")
                {
                    rdfStatements.Add(
                        new XElement(rdf + "Statement",
                            new XAttribute(rdf + "about", "#" + attrName),
                            new XElement(cq + "fieldOrder", fieldOrder++)
                        )
                    );
                }
            }

            var rdfRoot = new XElement(rdf + "RDF",
                new XAttribute(XNamespace.Xmlns + "rdf", rdf),
                new XAttribute(XNamespace.Xmlns + "oslc", oslc),
                new XAttribute(XNamespace.Xmlns + "dcterms", dcterms),
                new XAttribute(XNamespace.Xmlns + "cq", cq),
                new XAttribute(XNamespace.Xmlns + "oslc_cm", oslc_cm),
                new XAttribute(XNamespace.Xmlns + "rdfs", rdfs),

                changeRequest,
                rdfStatements
            );

            return new XDocument(new XDeclaration("1.0", "UTF-8", "no"), rdfRoot).ToString();
        }

        public static string ReBuildUrlFromBody(string originalUrl, string rdfBody)
        {
            string MandatoryField = "ExternalNextState";

            if (string.IsNullOrWhiteSpace(originalUrl))
                throw new ArgumentException("URL cannot be null or empty");

            if (string.IsNullOrWhiteSpace(rdfBody))
                throw new ArgumentException("Body cannot be null or empty");

            // Parse RDF body
            var doc = XDocument.Parse(rdfBody);

            XNamespace cqNs = "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/";
            XNamespace oslcCmNs = "http://open-services.net/ns/cm#";

            // Extract cq fields from ChangeRequest
            var cqFields = doc
                .Descendants(oslcCmNs + "ChangeRequest")
                .Elements()
                .Where(e => e.Name.Namespace == cqNs)
                .Select(e => e.Name.LocalName)
                .Distinct()
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            // Always keep ExternalNextState
            cqFields.Add(MandatoryField);

            // Build oslc.properties
            string properties = string.Join(",",
                cqFields
                    .OrderBy(f => f)
                    .Select(f => WebUtility.UrlEncode($"cq:{f}")));

            // Strip existing oslc.properties
            var urlParts = originalUrl.Split('&')
                .Where(p => !p.StartsWith("oslc.properties=", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Ensure rcm.action=modify exists
            if (!urlParts.Any(p => p.StartsWith("rcm.action=", StringComparison.OrdinalIgnoreCase)))
                urlParts.Add("rcm.action=modify");

            // Add final oslc.properties
            urlParts.Add($"oslc.properties={properties}");

            return string.Join("&", urlParts);
        }

        public string InvokeUrl4UpdateXport(string recordID, string sUrlToInvoke, string xprotLog, string xprotStatus, AsyncLogger async_objlogger = null)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, sUrlToInvoke);

                var byteArray = Encoding.ASCII.GetBytes($"{CQUser}:{CQPasword}");
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                string sRequesterInfo = "toolname=" + CQToolName + ";toolversion=" + CQToolVersion + ";user=" + CQWhiteLabelUser;

                request.Headers.Add("OSLC-Core-Version", "2.0");
                request.Headers.Add("x-requester", sRequesterInfo);

                
                string xmlBody = GlobalConstants.QueryBody.XprotBody;
                string cleanedUrl = sUrlToInvoke.Split('?')[0];

                xmlBody = xmlBody.Replace("XprotLog", xprotLog);
                xmlBody = xmlBody.Replace("XprotStatus", xprotStatus);
                xmlBody = xmlBody.Replace("url", cleanedUrl);

                request.Content = new StringContent(xmlBody, Encoding.UTF8, "application/xml");

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while invoking URL: {ex.Message}", ex);
            }
        }
        
        public string CreateQuery(string recordType, string recordID, string queryname, string queryparam, AsyncLogger objLogger = null)
        {
            if (objLogger != null)
            {
                objLogger.LogInfoAsync(recordID, "CreateQuery Started : ");
                objLogger.LogInfoAsync(recordID, "CreateQuery For : " + queryname);
            }

            string oQuery = string.Empty;

            try
            {
                string upperRecordType = recordType.ToUpper();

                // ISSUE, ISSUERELEASEMAP, and XPROT all follow the same pattern — find query node, build URL
                XElement xQueryNode = InterfaceConfigFile.Descendants("QUERY")
                        .FirstOrDefault(q => (string)q.Element("NAME") == queryname);

                if (xQueryNode == null)
                {
                    throw new Exception($"Query with name {queryname} not found.");
                }

                if (objLogger != null)
                {
                    objLogger.LogInfoAsync(recordID, "CreateQuery  : Query Node found");
                }

                string baseUrl = xQueryNode.Element("baseurl").Value;
                string type = xQueryNode.Element("type").Value;

                if (type == "READ")
                {
                    var attributes = xQueryNode.Element("attributes")?.Elements("attribute")
                        .Select(attr => Uri.EscapeDataString(attr.Value)).ToList();

                    if (attributes == null || !attributes.Any())
                    {
                        baseUrl = baseUrl.Replace("recorddbid", queryparam);
                        oQuery = baseUrl;
                    }
                    else
                    {
                        string attributeString = "oslc.properties=" + string.Join(",", attributes);
                        string whereString = "oslc.where=" + xQueryNode.Element("where").Value;
                        whereString = whereString.Replace("value", queryparam);
                        oQuery = baseUrl + "&" + whereString + "&" + attributeString;
                    }

                    if (objLogger != null)
                    {
                        objLogger.LogInfoAsync(recordID, "CreateQuery query generated : " + oQuery);
                    }
                }
                else if (type == "UPDATE")
                {
                    var attributes = xQueryNode.Element("attributes")?.Elements("attribute")
                        .Select(attr => Uri.EscapeDataString(attr.Value)).ToList();

                    if (attributes == null || !attributes.Any())
                    {
                        throw new Exception($"No attributes found for query {queryname}.");
                    }

                    string attributeString = string.Join(",", attributes);
                    baseUrl = baseUrl.Replace("recorddbid", queryparam);
                    baseUrl = baseUrl.Replace("%3A", ":");
                    attributeString = "oslc.properties=" + attributeString;
                    oQuery = baseUrl + "?rcm.action=modify&" + attributeString;

                    if (objLogger != null)
                    {
                        objLogger.LogInfoAsync(recordID, "CreateQuery query generated : " + oQuery);
                    }
                }
            
                else if (type == "CREATE")
                {
                    oQuery = baseUrl;
                    if (objLogger != null)
                    {
                        objLogger.LogInfoAsync(recordID, "CreateQuery query generated : " + oQuery);
                    }
                }
            }
            catch (Exception ex)
            {
                if (objLogger != null)
                {
                    objLogger.LogInfoAsync(recordID, "CreateQuery Execution failed with the exception : " + ex.Message);
                }
            }

            return oQuery;
        }



    }
}
