using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Xsl;
using Saxon.Api;
using System.Net;

namespace RB.ROCustomerInterfaceExportLibrary
{
    [Serializable]
    public class BTHelper
    {
        // Static record templates - avoids recreating this dictionary on every CreateRQ1DataExtractFile call
        private static readonly Dictionary<string, List<string>> s_recordTemplates = new Dictionary<string, List<string>>
        {
            { "users", new List<string> { "dbid", "email", "fullname", "login_name", "phone" } },
            { "Contact", new List<string> { "dbid", "eMail", "Department", "FirstName", "LastName", "PhoneNumbers" } },
            { "Issue", new List<string> { "dbid","id","Assignee","Attachments","CommercialAssignee","Domain","Description","ExternalDescription","ExternalAssignee","ExternalComment",
                                          "ExternalConversation","ExternalExchangedAttach","ExternalExchangeWorkflow","ExternalHistory","ExternalNextState",
                                          "ExternalOrganisation","ExternalState_Parallel1","ExternalSubmitter","ExternalTitle","External_ID","hasAttachmentMappings",
                                          "hasMappedReleases","hasCommercialData","OEMProposalAdopted","Tags","Type","ExternalState_Parallel2","ExternalUpdateVersion",
                                          "Category","hasSuccessor","Title"} },
            { "Release", new List<string> { "dbid","id","belongsToProject","ExternalTitle","External_ID","PlannedDate","Category","ExternalTags","Title","Type"} },
            { "Project", new List<string> { "dbid","id","ExternalDescription","External_ID","ExternalTitle"} },
            { "IssueReleaseMap", new List<string> { "dbid","id","Assignee","ExternalAssignee","ExternalComment","ExternalConversation","ExternalNextState","External_ID",
                                                    "hasMappedIssue","hasMappedRelease","hasCommercialData","hasAttachmentMappings","MappingToDerivatives","isPilot",
                                                    "ExternalState_Parallel1","LifeCycleState","Tags","Scope","QualificationStatus","ExternalTags",
                                                    "ExternalExchangeWorkflow","ExternalHistory","ExternalUpdateVersion"} },
            { "AttachmentMapping", new List<string> { "dbid","Attribute","ExportState","Eng_Attachment","Sales_Attachment"} },
            { "Commercial", new List<string> { "dbid","CommercialAmount","CommercialAmountDetails","CommercialAmountUnit","CommercialAttachments","CommercialComment","CommercialConversation","CommercialTags"} },
        };

        // Add all fields that may contain escaped XML
        private static readonly HashSet<string> EscapedXmlFields = new HashSet<string>
        {
            "Tags",
            "ExternalTags"
        };

        private static void LogAndFail(AsyncLogger async_objLogger, LifeTokenManager tokenManager, string recordID, string methodName, Exception ex)
        {
            if (async_objLogger != null)
            {
                async_objLogger.LogInfoAsync(recordID, methodName + " failed.");
                async_objLogger.LogInfoAsync(recordID, ex.Message);
            }

            if (tokenManager != null)
            {
                tokenManager.UpdateFailure(recordID, ex.Message);
            }
        }

        #region Logger

        public string GetConfigPathForLogger(string sExchangeFormat, string sXPROT)
        {
            string configPath = BizTalkConfigParams.ROASAMLOGGER;
            string strdatetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            strdatetime = strdatetime.Replace('/', '.');
            strdatetime = strdatetime.Replace(':', '.');
            string sPath = strdatetime + "_" + sExchangeFormat + "_" + sXPROT + ".txt";
            configPath = configPath + "\\" + sXPROT + "\\" + sPath;
            return configPath;
        }

        public string GetConfigPathForFolderCreation(string sExchangeFormat, string sXPROT)
        {
            string configPath = BizTalkConfigParams.ROASAMLOGGER;
            string sPath = sXPROT;
            configPath = configPath + "\\" + sPath;
            return configPath;
        }

        public string GetConfigpathForAsyncLogger()
        {
            return BizTalkConfigParams.ROASAMLOGGER;
        }

        public void SetLoggingMode(string sExchangeFormat, Logger objlogger)
        {
            try
            {
                string strConfigFilePath = BizTalkConfigParams.EX_RO_INTERFACE_CONFIG;
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML();

                string sLogLevel = string.Empty;

                foreach (XElement xe in l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element("LOGGER_SETTINGS")
                    .Elements("LOGGINGLEVEL").Where(e => e.Attribute("ENABLE").Value == "TRUE"))
                {
                    sLogLevel = xe.Attribute("LEVEL").Value;
                }

                objlogger.LogInfo("Setting Log Level value", GlobalConstants.LOGGERLEVEL1);

                switch (sLogLevel)
                {
                    case "1":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL1;
                        break;
                    case "2":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL2;
                        break;
                    case "3":
                        objlogger.iLogLevel = GlobalConstants.LOGGERLEVEL3;
                        break;
                    default:
                        objlogger.LogException("Please enable atleast one Logger level");
                        break;
                }

                objlogger.LogInfo("Log Level Value: " + objlogger.iLogLevel, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex);
            }
        }

        #endregion

        #region Updation of RQ1 Records

        public bool UpdateRecords(XmlDocument XIMF, string recordData, string xprotID, string p_system, string sExchangeFormat, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;
            string RecordType = string.Empty;
            string queryParam = string.Empty;

            bool result = false;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
                RecordType = recordDetails[1].Trim();
            }

            async_objLogger.LogInfoAsync(RecordID, "UpdateRecords Started : ");

            try
            {
                if (sExchangeFormat.Contains("BMW"))
                {
                    string ExternalID = TransmitterResponseValidate(BizTalkConfigParams.BT_MESSAGES + xprotID + "_" + RecordID + "_" + "TransmitterResponse.xml", RecordID, async_objLogger, tokenManager);
                    if (!string.IsNullOrEmpty(ExternalID))
                    {
                        XmlNode externalIdNode = XIMF.SelectSingleNode("//*[local-name()='ISSUE']/*[local-name()='External_ID']");
                        if (externalIdNode != null)
                        {
                            externalIdNode.InnerText = ExternalID;
                        }
                    }
                }

                if (RecordType.ToUpper() == "ISSUE")
                {
                    XDocument xIssuedoc;
                    using (var nodeReader = new XmlNodeReader(XIMF))
                    {
                        nodeReader.MoveToContent();
                        xIssuedoc = XDocument.Load(nodeReader);
                    }

                    string dbid = xIssuedoc.Root.Element(IMFFileTags.Issue).Attribute("dbid").Value;
                    async_objLogger.LogInfoAsync(RecordID, "Started Executing Update Issue Entry Point Methods: ");

                    RO_OSLC_DataInterface obj = new RO_OSLC_DataInterface(p_system, sExchangeFormat, RecordID, async_objLogger);
                    queryParam = dbid;

                    var queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.UpdateIssue, queryParam, async_objLogger);
                    async_objLogger.LogInfoAsync(RecordID, "Query Created Succesfully.");

                    var queryResult = obj.InvokeUrl4UpdateOperation(RecordID, queryurl, XIMF, RecordType, async_objLogger);
                    async_objLogger.LogInfoAsync(RecordID, queryResult);
                    async_objLogger.LogInfoAsync(RecordID, "Record Updated Succesfully.");

                    result = true;
                }
                else if (RecordType.ToUpper() == "ISSUERELEASEMAP")
                {
                    XDocument xIRMDoc;
                    using (var nodeReader = new XmlNodeReader(XIMF))
                    {
                        nodeReader.MoveToContent();
                        xIRMDoc = XDocument.Load(nodeReader);
                    }

                    string dbid = xIRMDoc.Root.Element(IMFFileTags.Irmap).Attribute("dbid").Value;
                    async_objLogger.LogInfoAsync(RecordID, "Started Executing Update ISSUERELEASEMAP Entry Point Methods: ");

                    RO_OSLC_DataInterface obj = new RO_OSLC_DataInterface(p_system, sExchangeFormat, RecordID, async_objLogger);
                    queryParam = dbid;

                    var queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.UpdateIssueReleaseMap, queryParam, async_objLogger);
                    async_objLogger.LogInfoAsync(RecordID, "Query Created Succesfully.");

                    var queryResult = obj.InvokeUrl4UpdateOperation(RecordID, queryurl, XIMF, RecordType, async_objLogger);

                    async_objLogger.LogInfoAsync(RecordID, "Started Executing Update Issue for IRM Entry Point Methods: ");

                    queryParam = xIRMDoc.Root.Element(IMFFileTags.Issue).Attribute("dbid").Value;
                    queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.updateIssue_IRM, queryParam, async_objLogger);

                    async_objLogger.LogInfoAsync(RecordID, "Query Created Succesfully.");

                    queryResult = obj.InvokeUrl4UpdateOperation(RecordID, queryurl, XIMF, "issue", async_objLogger);

                    async_objLogger.LogInfoAsync(RecordID, queryResult);
                    async_objLogger.LogInfoAsync(RecordID, "Record Updated Succesfully.");

                    result = true;
                }
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.UpdateRecords", ex);
            }

            return result;
        }

        public string UpdateExchangeProtocol(string xprotID, string p_system, string interfaceName, string lifeToken4Files, string xprotStatus, Logger logger)
        {
            string result = string.Empty;

            try
            {
                string queryParam = xprotID;
                lifeToken4Files = lifeToken4Files.Replace(" |||| ", Environment.NewLine);

                RO_OSLC_DataInterface obj = new RO_OSLC_DataInterface(p_system, interfaceName, xprotID);
                var queryurl = obj.CreateQuery("xprot", xprotID, GlobalConstants.QueryMethods.UpdateXprot, queryParam);
                obj.InvokeUrl4UpdateXport(xprotID, queryurl, lifeToken4Files, xprotStatus);

                return result;
            }
            catch (Exception ex)
            {
                logger.LogInfo(ex.Message);
                return result;
            }
        }

        #endregion

        #region Validate & Execute Orchestration's methods

        public string CreateASAMFile(XmlDocument RQ1Extract_data, string recordData, string XprotID, string sSystem, string sExchangeFormat, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;
            string RecordType = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
                RecordType = recordDetails[1].Trim();
            }

            async_objLogger.LogInfoAsync(RecordID, "Create ASAM File Method Started: ");

            string transformedXml = string.Empty;
            string asamFileName = string.Empty;
            string folderPath = GlobalConstants.ASAMFile_FolderPath + XprotID + "\\";

            try
            {
                string stateName = GetStateName(RQ1Extract_data, RecordType, RecordID, async_objLogger, tokenManager);

                if (stateName.ToUpper().Contains("ESTIMATED") && sExchangeFormat.Contains("AUDI"))
                {
                    folderPath = folderPath + "ExchangedCommercialFiles" + "\\";
                }
                else
                {
                    folderPath = folderPath + "ExchangedFiles" + "\\";
                }

                string transition_file = sExchangeFormat + "_" + stateName + ".xsl";
                async_objLogger.LogInfoAsync(RecordID, "Transforming RQ1 Data to ASAM Data for " + stateName);

                string xsltPath = string.Empty;
                if (sExchangeFormat.Contains("BMW"))
                {
                    xsltPath = XsltConfig.xslFilePath + sExchangeFormat + "\\" + RecordType.ToUpper() + "\\" + transition_file;
                }
                else
                {
                    xsltPath = XsltConfig.xslFilePath + sExchangeFormat + "\\" + transition_file;
                }

                Processor processor = new Processor();
                XsltCompiler compiler = processor.NewXsltCompiler();
                XsltExecutable executable = compiler.Compile(new Uri(xsltPath));

                using (MemoryStream inputStream = new MemoryStream(Encoding.UTF8.GetBytes(RQ1Extract_data.OuterXml)))
                using (XmlReader xmlReader = XmlReader.Create(inputStream))
                {
                    XdmNode input = processor.NewDocumentBuilder().Build(xmlReader);
                    XsltTransformer transformer = executable.Load();
                    transformer.InitialContextNode = input;

                    using (StringWriter outputWriter = new StringWriter())
                    {
                        Serializer serializer = processor.NewSerializer(outputWriter);
                        serializer.SetOutputProperty(Serializer.INDENT, "yes");
                        transformer.Run(serializer);
                        transformedXml = outputWriter.ToString();
                    }
                }

                async_objLogger.LogInfoAsync(RecordID, "Transformed Xml generated");

                Directory.CreateDirectory(folderPath);
                asamFileName = ExtractFileNameFromXml(transformedXml);

                if (!string.IsNullOrEmpty(asamFileName))
                {
                    string fullPath = Path.Combine(folderPath, asamFileName);
                    File.WriteAllText(fullPath, transformedXml);

                    //GUID creation for DAIMLER IRM
                    AddGuidToTransactionId(asamFileName, fullPath, sExchangeFormat);



                    async_objLogger.LogInfoAsync(RecordID, "ASAM File Name : " + asamFileName);
                    async_objLogger.LogInfoAsync(RecordID, "Attachment Process Started");



                    Attachments attch = new Attachments();
                    attch.ProcessAttachments(RQ1Extract_data, asamFileName, RecordID, RecordType, XprotID, sSystem, sExchangeFormat, async_objLogger);

                    TransmitterResponse transmitterResponse_obj = new TransmitterResponse();
                    if (sExchangeFormat.Contains("DAIMLER") || sExchangeFormat.Contains("BMW"))
                    {
                        string url = GetTransmitterPath(sSystem, sExchangeFormat, async_objLogger, RecordID, tokenManager);
                        TransmitterService transmitter = new TransmitterService(url);

                        string zippath = GetZipFileFromSubFolders(XprotID, asamFileName, RecordID, async_objLogger, tokenManager);
                        transmitterResponse_obj = transmitter.SendZipFile(XprotID, RecordID, zippath, "SUPPLIER_DATA");

                        if (transmitterResponse_obj.IsSuccess == false)
                        {
                            tokenManager.UpdateFailure(RecordID, "ASAM File Transmition to OEM System Failed. Please contact Adminstrator.");
                            return string.Empty;
                        }
                    }

                    CopyFilesToRemoteServer(XprotID, RecordID, sSystem, sExchangeFormat, async_objLogger, tokenManager);
                    tokenManager.UpdateSuccess(RecordID);
                }
                else
                {
                    tokenManager.UpdateFailure(RecordID, "ASAM File Creation Failed. Please Contact Administrator.");
                }
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.CreateASAMFile", ex);
            }

            return asamFileName;
        }

        public XmlDocument CreateRQ1DataExtractFile(string recordData, string xprotID, string p_system, string sExchangeFormat, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;
            string RecordType = string.Empty;
            string queryParam = string.Empty;
            string queryurl = string.Empty;
            string queryResult = string.Empty;

            XDocument inputXml = null;
            XmlDocument xDoc = new XmlDocument();
            XElement root = null;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
                RecordType = recordDetails[1].Trim();
            }

            RO_OSLC_DataInterface obj = new RO_OSLC_DataInterface(p_system, sExchangeFormat, RecordID, async_objLogger);

            try
            {
                async_objLogger.LogInfoAsync(RecordID, "CreateRQ1DataExtractFile Started : ");

                var recordTemplates = s_recordTemplates;

                if (RecordType.ToUpper() == "ISSUE")
                {
                    async_objLogger.LogInfoAsync(RecordID, "Started Executing Issue Entry Point Methods: ");

                    queryParam = RecordID;
                    queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getIssueByIdForIssueEntrypoint, queryParam, async_objLogger);
                    queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                    inputXml = XDocument.Parse(queryResult);

                    async_objLogger.LogInfoAsync(RecordID, "method ProcessRecordsDynamically started : ");
                    root = ProcessRecordsDynamically(inputXml, recordTemplates, root);

                    var releaseIds = root.Descendants("IssueReleaseMaps").Descendants("hasMappedRelease")
                        .Select(x => x.Value.Trim().Split('-').Last())
                        .ToList();

                    foreach (var id in releaseIds)
                    {
                        queryParam = id;
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getReleaseByDBId, queryParam, async_objLogger);
                        queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                        inputXml = XDocument.Parse(queryResult);
                        root = ProcessRecordsDynamically(inputXml, recordTemplates, root);
                    }

                    var projectIds = root.Descendants("Releases").Descendants("belongsToProject")
                        .Select(x => x.Value.Trim().Split('-').Last())
                        .ToList();

                    foreach (var id in projectIds)
                    {
                        queryParam = id;
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getProjectByDbId, queryParam, async_objLogger);
                        queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                        inputXml = XDocument.Parse(queryResult);
                        root = ProcessRecordsDynamically(inputXml, recordTemplates, root);
                    }

                    using (var reader = root.CreateReader())
                    {
                        xDoc.Load(reader);
                    }

                    xDoc = FormatXmlDocument(xDoc);

                    XElement finAtchmtElement = null;
                    XElement techAtchmtElement = null;

                    string IssueDBId = ExtractDbid(xDoc, RecordType);
                    if (!string.IsNullOrEmpty(IssueDBId))
                    {
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getIssueAttachments, IssueDBId, async_objLogger);
                        techAtchmtElement = obj.FetchTechnicalAttachments(RecordID, IssueDBId, queryurl, async_objLogger);
                    }

                    string commercialDbid = ExtractDbid(xDoc, "Commercial");
                    if (!string.IsNullOrEmpty(commercialDbid))
                    {
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getIssueCommercialAttachments, commercialDbid, async_objLogger);
                        finAtchmtElement = obj.FetchFinancialAttachments(RecordID, commercialDbid, queryurl, async_objLogger);
                    }

                    XElement mergedAttchs = new XElement("Attachmentss",
                        techAtchmtElement?.Elements("Attachments") ?? Enumerable.Empty<XElement>(),
                        finAtchmtElement?.Elements("Attachments") ?? Enumerable.Empty<XElement>());

                    XmlDocument tempDoc = new XmlDocument();
                    tempDoc.LoadXml(mergedAttchs.ToString());
                    XmlNode importedNode = xDoc.ImportNode(tempDoc.DocumentElement, true);
                    xDoc.DocumentElement.AppendChild(importedNode);
                }
                else if (RecordType.ToUpper() == "ISSUERELEASEMAP")
                {
                    async_objLogger.LogInfoAsync(RecordID, "Started Executing IRM Entry Point Methods: ");

                    queryParam = RecordID;
                    queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getIssueReleaseMapByRQ1Id, queryParam, async_objLogger);
                    queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                    inputXml = XDocument.Parse(queryResult);

                    async_objLogger.LogInfoAsync(RecordID, "method ProcessRecordsDynamically started : ");
                    root = ProcessRecordsDynamically(inputXml, recordTemplates, root);

                    var hasMappedIssueElement = root.Descendants("hasMappedIssue").FirstOrDefault();
                    string dbid = null;

                    if (hasMappedIssueElement != null && !string.IsNullOrWhiteSpace(hasMappedIssueElement.Value))
                    {
                        string hasMappedIssueUrl = hasMappedIssueElement.Value.Trim();
                        if (hasMappedIssueUrl.Contains("-"))
                        {
                            dbid = hasMappedIssueUrl.Split('-').Last();
                        }
                    }

                    queryParam = dbid;
                    queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getIssueByDBId, queryParam, async_objLogger);
                    queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                    inputXml = XDocument.Parse(queryResult);

                    async_objLogger.LogInfoAsync(RecordID, "method ProcessRecordsDynamically started : ");
                    root = ProcessRecordsDynamically(inputXml, recordTemplates, root);

                    var hasMappedReleaseElement = root.Descendants("hasMappedRelease").FirstOrDefault();

                    if (hasMappedReleaseElement != null && !string.IsNullOrWhiteSpace(hasMappedReleaseElement.Value))
                    {
                        string hasMappedReleaseUrl = hasMappedReleaseElement.Value.Trim();
                        if (hasMappedReleaseUrl.Contains("-"))
                        {
                            dbid = hasMappedReleaseUrl.Split('-').Last();
                        }
                    }

                    queryParam = dbid;
                    queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getReleaseByDBId, queryParam, async_objLogger);
                    queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                    inputXml = XDocument.Parse(queryResult);

                    async_objLogger.LogInfoAsync(RecordID, "method ProcessRecordsDynamically started : ");
                    root = ProcessRecordsDynamically(inputXml, recordTemplates, root);

                    var projectIds = root.Descendants("Releases").Descendants("belongsToProject")
                        .Select(x => x.Value.Trim().Split('-').Last())
                        .ToList();

                    foreach (var id in projectIds)
                    {
                        queryParam = id;
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getProjectByDbId, queryParam, async_objLogger);
                        queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);
                        inputXml = XDocument.Parse(queryResult);
                        root = ProcessRecordsDynamically(inputXml, recordTemplates, root);
                    }

                    using (var reader = root.CreateReader())
                    {
                        xDoc.Load(reader);
                    }

                    xDoc = FormatXmlDocument(xDoc);
                }

                xDoc = ConvertEscapedFields(xDoc, RecordID, async_objLogger, tokenManager);

                if (RecordType.ToUpper() == "ISSUERELEASEMAP" && sExchangeFormat.Contains("DAI"))
                {
                    CounterProposal cp = new CounterProposal();
                    cp.ProcessCounterProposal(xDoc, RecordID, RecordType, p_system, sExchangeFormat, async_objLogger, tokenManager);
                }
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.CreateRQ1DataExtractFile", ex);
            }

            return xDoc;
        }

        static XElement ProcessRecordsDynamically(XDocument inputXml, Dictionary<string, List<string>> recordTemplates, XElement root)
        {
            if (root == null)
            {
                root = new XElement("RQ1_EXTRACT", new XAttribute("CreationDate", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")));
            }

            XNamespace oslcCmNs = "http://open-services.net/ns/cm#";
            XNamespace dctermsNs = "http://purl.org/dc/terms/";
            XNamespace cqNs = "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/";

            foreach (var recordType in recordTemplates.Keys)
            {
                var records = inputXml.Descendants(oslcCmNs + "ChangeRequest")
                    .Where(cr => cr.Element(dctermsNs + "type")?.Value.ToLower() == recordType.ToLower() && cr.Parent?.Name.LocalName != "hasSuccessor")
                    .Select(cr => new
                    {
                        RecordType = cr.Element(dctermsNs + "type")?.Value ?? "Unknown",
                        Attributes = recordTemplates[recordType].ToDictionary(
                            attr => attr,
                            attr =>
                            {
                                object result = null;
                                var element = cr.Element(cqNs + attr);

                                if (recordType.ToLower() == "issue")
                                {
                                    if ((attr.Contains("Assignee") || attr.Contains("hasCommercialData") || attr.Contains("Submitter")) && element != null)
                                    {
                                        var dbidElement = element.Element(oslcCmNs + "ChangeRequest")?.Element(cqNs + "dbid");
                                        return dbidElement?.Value ?? "";
                                    }

                                    if (attr.Contains("hasAttachmentMappings"))
                                    {
                                        var mappings = cr.Elements(cqNs + "hasAttachmentMappings")
                                            .Elements(oslcCmNs + "ChangeRequest")
                                            .Select(crElem => crElem.Element(cqNs + "dbid")?.Value ?? string.Empty)
                                            .Where(val => !string.IsNullOrEmpty(val))
                                            .Distinct()
                                            .ToList();

                                        result = new XElement("hasAttachmentMappings", mappings.Select(id => new XElement("dbid", id)));
                                        return result;
                                    }

                                    if (attr.Contains("hasMappedReleases"))
                                    {
                                        var mappings = cr.Elements(cqNs + "hasMappedReleases")
                                            .Elements(oslcCmNs + "ChangeRequest")
                                            .Select(crElem => crElem.Element(cqNs + "dbid")?.Value ?? string.Empty)
                                            .Where(val => !string.IsNullOrEmpty(val))
                                            .Distinct()
                                            .ToList();

                                        result = new XElement("hasMappedReleases", mappings.Select(id => new XElement("dbid", id)));
                                        return result;
                                    }

                                    if (attr.Contains("hasSuccessor"))
                                    {
                                        var successors = cr.Elements(cqNs + "hasSuccessor")
                                            .Elements(oslcCmNs + "ChangeRequest")
                                            .Select(x => x.Element(cqNs + "dbid")?.Value ?? "")
                                            .Where(x => !string.IsNullOrEmpty(x))
                                            .Distinct()
                                            .ToList();

                                        result = new XElement("hasSuccessor", successors.Select(dbid => new XElement("dbid", dbid)));
                                        return result;
                                    }
                                }

                                if (recordType.ToLower() == "issuereleasemap")
                                {
                                    if (attr.Contains("Assignee") && element != null)
                                    {
                                        var dbidElement = element.Element(oslcCmNs + "ChangeRequest")?.Element(cqNs + "dbid");
                                        return dbidElement?.Value ?? "";
                                    }
                                }

                                if (recordType.ToLower() == "release")
                                {
                                    if (attr.Contains("belongsToProject") && element != null)
                                    {
                                        var resourceAttr = element.Attribute(XName.Get("resource", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"));
                                        return resourceAttr?.Value ?? "";
                                    }
                                }

                                if ((attr.Contains("Attachments") || attr.Contains("hasMappedIssue") || attr.Contains("hasMappedRelease")) && element != null)
                                {
                                    var resourceAttr = element.Attribute(XName.Get("resource", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"));
                                    return resourceAttr?.Value ?? "";
                                }

                                return element?.Value ?? "";
                            })
                    });

                string containerName = recordType + "s";
                var recordTypeElement = root.Element(containerName);
                if (recordTypeElement == null)
                {
                    recordTypeElement = new XElement(containerName);
                    root.Add(recordTypeElement);
                }

                foreach (var record in records)
                {
                    string dbidValue = record.Attributes.ContainsKey("dbid") ? record.Attributes["dbid"]?.ToString() ?? "" : "";

                    bool alreadyExists = recordTypeElement.Elements(recordType)
                        .Any(x => (string)x.Attribute("dbid") == dbidValue);

                    if (alreadyExists)
                    {
                        continue;
                    }

                    XElement recordElement = new XElement(recordType,
                        new XAttribute("recordtype", record.RecordType),
                        new XAttribute("dbid", dbidValue));

                    foreach (var attr in record.Attributes)
                    {
                        if (attr.Value is XElement elementValue)
                        {
                            recordElement.Add(elementValue);
                        }
                        else
                        {
                            recordElement.Add(new XElement(attr.Key, attr.Value?.ToString() ?? ""));
                        }
                    }

                    recordTypeElement.Add(recordElement);
                }
            }

            var successorCRs = inputXml
                .Descendants(cqNs + "hasSuccessor")
                .Elements(oslcCmNs + "ChangeRequest");

            var successorContainer = new XElement("hasSuccessorss");

            foreach (var cr in successorCRs)
            {
                string dbid = cr.Element(cqNs + "dbid")?.Value ?? "";
                if (string.IsNullOrEmpty(dbid))
                {
                    continue;
                }

                string id = cr.Element(cqNs + "id")?.Value ?? "";
                string externalId = cr.Element(cqNs + "External_ID")?.Value ?? "";
                string title = cr.Element(cqNs + "ExternalTitle")?.Value ?? "";

                var successor = new XElement("hasSuccessors",
                    new XAttribute("dbid", dbid),
                    new XElement("id", id),
                    new XElement("External_ID", externalId),
                    new XElement("ExternalTitle", title));

                successorContainer.Add(successor);
            }

            if (successorContainer.HasElements)
            {
                root.Add(successorContainer);
            }

            return root;
        }

        public static XmlDocument ConvertEscapedFields(XmlDocument doc, string recordID = "", AsyncLogger async_objLogger = null, LifeTokenManager tokenManager = null)
        {
            if (doc == null)
            {
                return null;
            }

            try
            {
                var allNodes = doc.SelectNodes("//*");

                foreach (XmlNode node in allNodes)
                {
                    if (EscapedXmlFields.Contains(node.Name))
                    {
                        ConvertEscapedXml(node, recordID, async_objLogger, tokenManager);
                    }
                }

                return doc;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.ConvertEscapedFields", ex);
                return doc;
            }
        }

        private static void ConvertEscapedXml(XmlNode node, string recordID = "", AsyncLogger async_objLogger = null, LifeTokenManager tokenManager = null)
        {
            if (node == null || string.IsNullOrWhiteSpace(node.InnerText))
            {
                return;
            }

            try
            {
                var decoded = WebUtility.HtmlDecode(node.InnerText);
                var wrapped = "<root>" + decoded + "</root>";

                XmlDocument tempDoc = new XmlDocument();
                tempDoc.LoadXml(wrapped);

                node.RemoveAll();

                foreach (XmlNode child in tempDoc.DocumentElement.ChildNodes)
                {
                    XmlNode importedNode = node.OwnerDocument.ImportNode(child, true);
                    node.AppendChild(importedNode);
                }
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.ConvertEscapedXml", ex);
            }
        }

        public XmlDocument UpdateIMFAfterValidation(XmlDocument RQ1Extract_data, XmlDocument XIMF, string recordData, string Exchnageprotocol, LifeTokenManager tokenManager, AsyncLogger async_objLogger = null)
        {
            string RecordID = string.Empty;
            string RecordType = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
                RecordType = recordDetails[1].Trim();
            }

            XDocument xIssuedoc;
            string strHistory = string.Empty;
            string strENS = string.Empty;
            string strESP1 = string.Empty;
            string strExternalConv = string.Empty;
            string strExternalExchangedAttach = string.Empty;
            string tags = string.Empty;
            string externalTags = string.Empty;
            string new_tags = string.Empty;

            string workflow = string.Empty;
            string version = string.Empty;
            XmlNode node = RQ1Extract_data.SelectSingleNode("/RQ1_EXTRACT/Issues/Issue/ExternalExchangeWorkflow");
            if (node != null)
            {
                workflow = node.InnerText;
            }

            node = RQ1Extract_data.SelectSingleNode("/RQ1_EXTRACT/IssueReleaseMaps/IssueReleaseMap/Tags/EXPORT-MODIFICATION");
            if (node != null)
            {
                tags = node.OuterXml;
            }

            using (var nodeReader = new XmlNodeReader(XIMF))
            {
                nodeReader.MoveToContent();
                xIssuedoc = XDocument.Load(nodeReader);
            }

            if (RecordType.ToUpper() == "ISSUE")
            {
                try
                {
                    strHistory = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalHistory).Value.Trim();
                    strENS = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalNextState).Value.Trim();
                    strExternalConv = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalConversation).Value.Trim();
                    strExternalExchangedAttach = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalExchangedAttach).Value.Trim();
                    strESP1 = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel1).Value.Trim();

                    XmlNodeList mappingNodes = RQ1Extract_data.SelectNodes("//AttachmentMapping");
                    StringBuilder sb = new StringBuilder();

                    foreach (XmlNode mapping in mappingNodes)
                    {
                        string attribute = mapping.SelectSingleNode("Attribute")?.InnerText ?? "";
                        string exportState = mapping.SelectSingleNode("ExportState")?.InnerText ?? "";

                        string attachment;
                        if (attribute.ToLower().Contains("technical"))
                        {
                            attachment = mapping.SelectSingleNode("Eng_Attachment")?.InnerText ?? "";
                        }
                        else
                        {
                            attachment = mapping.SelectSingleNode("Sales_Attachment")?.InnerText ?? "";
                        }

                        string formattedTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

                        if (!strExternalExchangedAttach.Contains(exportState) && !strExternalExchangedAttach.Contains(attachment))
                        {
                            sb.AppendLine("### " + exportState + " " + formattedTime + " ### " + attachment + " \n ");
                        }
                    }

                    version = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalUpdateVersion).Value.Trim();

                    strHistory = strENS + " - " + GetFormattedDateTime() + " -  ExchangeProtocol:" + Exchnageprotocol + "\n\n" + strHistory;
                    strExternalConv = "### " + GetFormattedDateTime() + " " + strENS + " FFM3FE ### \n\n" + strExternalConv;

                    if (workflow.Contains("VAG"))
                    {
                        if (strENS.Contains("SPECIFIED") || strENS.Contains("CLOSED"))
                        {
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel2).Value = strENS;
                        }
                        else if (strENS.ToLower() == "info-update")
                        {
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel1).Value = strESP1;
                        }
                        else
                        {
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel1).Value = strENS;
                        }

                        if (strENS.ToUpper() == "ESTIMATED")
                        {
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.CommercialQuotationReq).Value = "Quoted";
                        }
                    }
                    else if (workflow.Contains("BMW"))
                    {
                        if (strENS.ToLower() == "info-update")
                        {
                            version = IncrementVersion(version);
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalUpdateVersion).Value = version;
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel1).Value = strESP1;
                        }
                        else
                        {
                            xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalState_Parallel1).Value = strENS;
                        }
                    }

                    xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalNextState).Value = "";
                    xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalConversation).Value = strExternalConv;
                    xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalHistory).Value = strHistory;
                    xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalExchangedAttach).Value = sb + "\n\n" + strExternalExchangedAttach;
                    xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalLastExportedDate).Value = "";

                    using (var xmlReader = xIssuedoc.CreateReader())
                    {
                        XIMF.Load(xmlReader);
                    }
                }
                catch (Exception ex)
                {
                    LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.UpdateIMFAfterValidation.Issue", ex);
                }
            }
            else if (RecordType.ToUpper() == "ISSUERELEASEMAP")
            {
                try
                {
                    strHistory = xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalHistory).Value.Trim();
                    string strHistoryIrmap = xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalHistory).Value.Trim();
                    strENS = xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalNextState).Value.Trim();
                    strExternalConv = xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalConversation).Value.Trim();

                    strExternalConv = "### " + GetFormattedDateTime() + " " + strENS + " FFM3FE ### \n\n" + strExternalConv;
                    strESP1 = xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalState_Parallel1).Value.Trim();

                    if (workflow.Contains("DAI"))
                    {
                        externalTags = TagsModificationService.CreateExternalTags(tags, GlobalConstants.XsltConstants.ExternalTagsTransformation);
                        externalTags = externalTags + "\n\n\n" + xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalTags).Value.Trim();

                        node = RQ1Extract_data.SelectSingleNode("/RQ1_EXTRACT/IssueReleaseMaps/IssueReleaseMap/Tags");
                        if (node != null)
                        {
                            tags = node.OuterXml;
                        }

                        new_tags = TagsModificationService.ExtractNodesAfterExportModification(tags);
                        strHistoryIrmap = strENS + " - " + GetFormattedDateTime() + " -  ExchangeProtocol:" + Exchnageprotocol + "\n\n" + strHistoryIrmap;

                        if (strENS.ToLower() == "info-update")
                        {
                            version = xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalUpdateVersion).Value.Trim();
                            version = IncrementVersion(version);
                            xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalUpdateVersion).Value = version;
                            xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalState_Parallel1).Value = strESP1;
                        }
                        else
                        {
                            xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalState_Parallel1).Value = strENS;
                        }

                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.Tags).Value = new_tags;
                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalNextState).Value = "";
                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalConversation).Value = strExternalConv;
                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalTags).Value = externalTags;
                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalHistory).Value = strHistoryIrmap;

                    }
                    else
                    {
                        strHistory = strENS + " - " + GetFormattedDateTime() + " -  ExchangeProtocol:" + Exchnageprotocol + "\n\n" + strHistory;

                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalNextState).Value = "";
                        xIssuedoc.Root.Element(IMFFileTags.IRMAP).Element(IMFFileTags.ExternalConversation).Value = strExternalConv;
                        xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalHistory).Value = strHistory;
                        xIssuedoc.Root.Element(IMFFileTags.Issue).Element(IMFFileTags.ExternalLastExportedDate).Value = "";
                    }

                    using (var xmlReader = xIssuedoc.CreateReader())
                    {
                        XIMF.Load(xmlReader);
                    }
                }
                catch (Exception ex)
                {
                    LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.UpdateIMFAfterValidation.IssueReleaseMap", ex);
                }
            }

            return XIMF;
        }

        public string ChangeLifeToken4Xprot(string lifeToken4Files, string xprotStatus, Logger objlogger)
        {
            try
            {
                if (lifeToken4Files.Contains("Failure") && lifeToken4Files.Contains("Success"))
                {
                    xprotStatus = "Incomplete";
                }
                else if (lifeToken4Files.Contains("Failure"))
                {
                    xprotStatus = "Failure";
                }
                else if (lifeToken4Files.Contains("Success"))
                {
                    xprotStatus = "Success";
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo(ex.Message);
            }

            return xprotStatus;
        }

        public bool ValidateRQ1ExtractFile(XmlDocument RQ1Extract_data, string recordData, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;
            string RecordType = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
                RecordType = recordDetails[1].Trim();
            }

            bool is_MappedDerivative = ValidateMappingDerivatives(RQ1Extract_data, recordData, async_objLogger, tokenManager);

            async_objLogger.LogInfoAsync(RecordID, "BTHelper::ValidateRQ1ExtractFile:Starts");

            try
            {
                var xslt = new XslCompiledTransform();
                xslt.Load(XsltConfig.Audi_Validator);

                using (var writer = new StringWriter())
                using (var reader = new XmlNodeReader(RQ1Extract_data))
                {
                    xslt.Transform(reader, null, writer);
                    string result = writer.ToString();
                    return result.Contains("Validation Successful.") && is_MappedDerivative;
                }
            }
            catch (XsltException ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.ValidateRQ1ExtractFile", ex);
                return true;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.ValidateRQ1ExtractFile", ex);
                return true;
            }
        }

        public int GetRecordsCount(string LifeToken4Files, Logger objlogger)
        {
            int recordsCount = 0;
            objlogger.LogInfo("GetReordsCount Started : ");

            try
            {
                string[] recordsArray = LifeToken4Files.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                List<string> recordsList = recordsArray.Select(record => record.Trim()).Where(record => !string.IsNullOrEmpty(record)).ToList();
                recordsCount = recordsList.Count;
                objlogger.LogInfo("Total Records Count : " + recordsCount);
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Exception Occured in GetRecordsCount method");
                objlogger.LogException(ex);

            }

            objlogger.LogInfo("GetReordsCount Ended : ");
            return recordsCount;
        }

        public int GetBatchCount(int recordsCount, Logger objLogger)
        {
            objLogger.LogInfo("GetBatchCount Started : ");
            int batchCount = 0;

            try
            {
                batchCount = (recordsCount + GlobalConstants.BatchSize - 1) / GlobalConstants.BatchSize;
                objLogger.LogInfo("Batch Size : " + batchCount);
            }
            catch (Exception ex)
            {
                objLogger.LogInfo("Exception Occured in GetBatchCount method");
                objLogger.LogException(ex);
            }

            return batchCount;
        }

        public string GetEachRecordFromBatch(string recordNames, int parallelAction)
        {
            string recordName = string.Empty;

            string[] recordsArray = recordNames.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
            int batchSize = recordsArray.Count();

            if (batchSize >= parallelAction)
            {
                recordName = recordsArray[parallelAction - 1].Trim();
            }

            return recordName;
        }

        public string GetRecordID(string recordNames)
        {
            string parsedRecordId = string.Empty;

            try
            {
                string[] record_parts = recordNames.Split(new string[] { "::" }, StringSplitOptions.None);

                if (record_parts[0].ToLower().Contains("issue") || record_parts[0].ToLower().Contains("issuereleasemap"))
                {
                    parsedRecordId = record_parts[0].Trim();
                }
            }
            catch (Exception ex)
            {

            }

            return parsedRecordId;
        }

        public string GetRecordNamesFromBatch(string LifeToken4Files, int batchNumber, Logger objLogger)
        {
            objLogger.LogInfo("GetRecordNamesFromBatch Started : ");
            string recordNames = string.Empty;

            try
            {
                string[] recordsArray = LifeToken4Files.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                int startIndex = (batchNumber - 1) * GlobalConstants.BatchSize;

                if (startIndex >= recordsArray.Length)
                {
                    throw new ArgumentOutOfRangeException("The batch number exceeds the total number of records.");
                }

                int endIndex = Math.Min(startIndex + GlobalConstants.BatchSize, recordsArray.Length);
                string[] batchRecords = recordsArray.Skip(startIndex).Take(endIndex - startIndex).ToArray();

                recordNames = string.Join(" |||| ", batchRecords).Trim();
                objLogger.LogInfo("Record Names : " + recordNames);
            }
            catch (Exception ex)
            {
                objLogger.LogException(ex);

            }

            objLogger.LogInfo("GetRecordNamesFromBatch Ended : ");
            return recordNames;
        }

        public string GetLifeTokenByRecordId(string recordId, string lifeTokens)
        {
            if (string.IsNullOrWhiteSpace(recordId) || string.IsNullOrWhiteSpace(lifeTokens))
            {
                return null;
            }

            var tokens = lifeTokens
                .Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim());

            return tokens.FirstOrDefault(t => t.StartsWith(recordId, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Token Manager

        public bool VerifyTokenOfRecord(string recordID, LifeTokenManager tokenManager)
        {
            string lifetoken = tokenManager.GetLifeToken(recordID);
            return lifetoken.Contains("Failure");
        }

        public void UpdateTokenManager(string recordData, string xprotID, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
            }

            tokenManager.UpdateFailure(RecordID, "Issue/IRM is already beeing executed. Please contact administrator");
        }

        #endregion

        #region miscellineous




        public void AddGuidToTransactionId(
            string fileName,
            string fullPath,
            string exchangeFormat)
        {
            // Only apply this logic for DAIMLER
            if (string.IsNullOrWhiteSpace(exchangeFormat) ||
                !exchangeFormat.Contains("DAIMLER"))
            {
                return;
            }

            // Build the complete file path
            string filePath = fullPath;

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    $"ASAM file was not found: {filePath}",
                    filePath);
            }

            // Load XML
            XDocument document = XDocument.Load(filePath);

            // ASAM Issue 3.2.0 namespace
            XNamespace ns = "http://www.asam.net/schemas/issue/issue320";

            // Find TRANSACTION-ID
            XElement transactionIdElement = document.Descendants(ns + "TRANSACTION-ID").FirstOrDefault();

            if (transactionIdElement == null)
            {
                throw new InvalidOperationException(
                    $"TRANSACTION-ID element was not found in file: {fileName}");
            }

            // Generate new GUID
            string guid = Guid.NewGuid().ToString();

            // Existing value
            string currentTransactionId = transactionIdElement.Value.Trim();

            // Add GUID after '-'
            if (currentTransactionId.EndsWith("-"))
            {
                transactionIdElement.Value = currentTransactionId + guid;
            }
            else
            {
                transactionIdElement.Value = currentTransactionId + "-" + guid;
            }

            // Save the modified XML
            document.Save(filePath);
        }

        public XmlDocument PrettyXml(XmlDocument xmLDoc, string recordData, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string RecordID = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
            }

            try
            {
                async_objLogger.LogInfoAsync(RecordID, "BTHelper::PrettyXml:Starts");

                StringBuilder stringBuilder = new StringBuilder();
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = true
                };

                using (XmlWriter writer = XmlWriter.Create(stringBuilder, settings))
                {
                    xmLDoc.Save(writer);
                }

                xmLDoc.LoadXml(stringBuilder.ToString());
                async_objLogger.LogInfoAsync(RecordID, "BTHelper::PrettyXml:Ends");
                return xmLDoc;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.PrettyXml", ex);
                return xmLDoc;
            }
        }

        static XmlDocument FormatXmlDocument(XmlDocument xmlDoc)
        {
            XmlDocument formattedDoc = new XmlDocument();
            using (MemoryStream ms = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  ",
                    NewLineChars = "\n",
                    NewLineHandling = NewLineHandling.Replace
                };

                using (XmlWriter writer = XmlWriter.Create(ms, settings))
                {
                    xmlDoc.Save(writer);
                }

                ms.Position = 0;
                formattedDoc.Load(ms);
            }

            return formattedDoc;
        }

        static string GetFormattedDateTime()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public string GetStateName(XmlDocument RQ1Extract_data, string RecordType, string recordID = "", AsyncLogger async_objLogger = null, LifeTokenManager tokenManager = null)
        {
            string stateName = string.Empty;

            try
            {
                XmlNode externalNextStateNode;
                if (RecordType.ToUpper() == "ISSUE")
                {
                    externalNextStateNode = RQ1Extract_data.SelectSingleNode("//Issue/ExternalNextState");
                }
                else
                {
                    externalNextStateNode = RQ1Extract_data.SelectSingleNode("//IssueReleaseMap/ExternalNextState");
                }

                stateName = externalNextStateNode.InnerText;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.GetStateName", ex);
            }

            return stateName;
        }

        public static string ExtractDbid(XmlDocument xmlDoc, string tagName)
        {
            XmlNodeList nodes = xmlDoc.GetElementsByTagName(tagName);
            if (nodes.Count > 0)
            {
                XmlAttribute attr = nodes[0].Attributes?["dbid"];
                return attr?.Value;
            }

            return null;
        }

        public static string ExtractDbid(string xmlString, string tagName)
        {
            XDocument doc = XDocument.Parse(xmlString);
            var dbid = doc.Descendants(tagName).FirstOrDefault()?.Attribute("dbid")?.Value;
            return dbid;
        }

        public static string ExtractFileNameFromXml(string xmlContent)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlContent);

            string ns = doc.DocumentElement.NamespaceURI;

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("iss", ns);

            XmlNode shortNameNode = doc.SelectSingleNode("/iss:MSR-ISSUE/iss:SHORT-NAME", nsmgr);
            return shortNameNode?.InnerText ?? "DefaultFileName.xml";
        }

        public static string IncrementVersion(string input)
        {
            var match = Regex.Match(input, @"(RB)(\d+)$");

            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                int number = int.Parse(match.Groups[2].Value);
                number++;
                string newSuffix = prefix + number.ToString("D2");
                return Regex.Replace(input, @"(RB\d+)$", newSuffix);
            }

            return input;
        }

        public bool ValidateMappingDerivatives(XmlDocument RQ1Extract_data, string recordData, AsyncLogger async_objLogger, LifeTokenManager tokenManager = null)
        {
            string RecordID = string.Empty;

            if (!string.IsNullOrEmpty(recordData))
            {
                var recordDetails = recordData.Split(':');
                RecordID = recordDetails[0].Trim();
            }

            async_objLogger.LogInfoAsync(RecordID, "BTHelper::ValidateMappingDerivatives:Starts");

            try
            {
                if (RQ1Extract_data == null)
                {
                    throw new ArgumentNullException(nameof(RQ1Extract_data));
                }

                XmlNode issueNode = RQ1Extract_data.SelectSingleNode("//RQ1_EXTRACT/Issues/Issue");
                if (issueNode == null)
                {
                    return true;
                }

                string workflow = issueNode.SelectSingleNode("ExternalExchangeWorkflow")?.InnerText?.Trim();
                string nextState = issueNode.SelectSingleNode("ExternalNextState")?.InnerText?.Trim();

                if (workflow != "FAE" || !(nextState == "ESTIMATED_PILOT" || nextState == "ESTIMATED_AFFECTED"))
                {
                    return true;
                }

                XmlNode mappingNode = RQ1Extract_data.SelectSingleNode("//RQ1_EXTRACT/IssueReleaseMaps/IssueReleaseMap/MappingToDerivatives");
                if (mappingNode == null || string.IsNullOrWhiteSpace(mappingNode.InnerText))
                {
                    return true;
                }

                string mappingText = mappingNode.InnerText.Trim();

                var regex = new Regex(@"\[\w\]\s*(\S+)");
                var mappingCodes = regex.Matches(mappingText).Cast<Match>().Select(m => m.Groups[1].Value.Trim()).ToList();

                if (mappingCodes.Count == 0)
                {
                    return true;
                }

                XmlNode projectNode = RQ1Extract_data.SelectSingleNode("//RQ1_EXTRACT/Projects/Project/ExternalDescription");
                if (projectNode == null)
                {
                    return false;
                }

                string projectDescription = projectNode.InnerXml;

                var siRegex = new Regex(@"SI\s*=\s*""([^""]+)""");
                var projectCodes = siRegex.Matches(projectDescription).Cast<Match>().Select(m => m.Groups[1].Value.Trim()).ToList();

                foreach (var code in mappingCodes)
                {
                    if (!projectCodes.Contains(code))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, RecordID, "BTHelper.ValidateMappingDerivatives", ex);
                return false;
            }
        }

        public static string TransmitterResponseValidate(string filePath, string recordID = "", AsyncLogger async_objLogger = null, LifeTokenManager tokenManager = null)
        {
            try
            {
                var resultValue = XDocument.Load(filePath)
                    .Descendants()
                    .FirstOrDefault(x => x.Name.LocalName == "result")
                    ?.Value;

                return GlobalConstants.AllowedPrefixes.Any(prefix =>
                    resultValue?.StartsWith(prefix, StringComparison.OrdinalIgnoreCase) == true)
                    ? resultValue
                    : null;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.TransmitterResponseValidate", ex);
                return null;
            }
        }

        #endregion

        #region Staging

        public bool VerifyStageLock(string recordData, string xprotId, AsyncLogger async_objLogger = null, LifeTokenManager tokenManager = null)
        {
            try
            {
                if (string.IsNullOrEmpty(recordData))
                {
                    return false;
                }

                string processId = Guid.NewGuid().ToString();

                var stageService = new ASAMStageService(GlobalConstants.connectionString);
                bool created = stageService.TryCreateStage(processId, xprotId, recordData);

                return created;
            }
            catch (Exception ex)
            {
                string recordID = GetRecordID(recordData);
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.VerifyStageLock", ex);
                return false;
            }
        }

        public void DeleteStageLock(string xprotId, Logger logger)
        {
            try
            {
                var stageService = new ASAMStageService(GlobalConstants.connectionString);
                stageService.DeleteByXprot(xprotId);
            }
            catch (Exception ex)
            {
                logger.LogInfo(ex.Message);
            }
        }

        #endregion

        #region File Transfer to RemoteServer

        public string GetRemoteExportDestPath(string sSystemKey, string sExchangeFormat, AsyncLogger async_objLogger, string recordID, LifeTokenManager tokenManager = null)
        {
            string destPath = string.Empty;

            try
            {
                string strConfigFilePath = BizTalkConfigParams.EX_RO_INTERFACE_CONFIG;
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, async_objLogger, recordID);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML();

                if (l_oConfig != null)
                {
                    var serverNode = l_oConfig.Root
                        .Element(ConfigurationFileTags.INTERFACE_SETTINGS)
                        .Element("SERVERS")
                        .Elements("SERVER")
                        .FirstOrDefault(s => (string)s.Attribute("Key") == sSystemKey);

                    if (serverNode != null)
                    {
                        var formatNode = serverNode.Elements("FORMAT").FirstOrDefault(f => (string)f.Attribute("Key") == sExchangeFormat);
                        if (formatNode != null)
                        {
                            var element = formatNode.Element(ConfigurationFileTags.REMOTE_EXPORT_DESTPATH);
                            if (element != null)
                            {
                                destPath = element.Value.Trim();
                            }
                        }
                    }
                }

                async_objLogger.LogInfoAsync(recordID, "Remote Export Destination Path: " + destPath);
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.GetRemoteExportDestPath", ex);
            }

            return destPath;
        }

        public string GetTransmitterPath(string sSystemKey, string sExchangeFormat, AsyncLogger async_objLogger, string recordID, LifeTokenManager tokenManager = null)
        {
            string destPath = string.Empty;

            try
            {
                string strConfigFilePath = BizTalkConfigParams.EX_RO_INTERFACE_CONFIG;
                ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, async_objLogger, recordID);
                XDocument l_oConfig = rConfigMgr.LoadConfigurationXML();

                if (l_oConfig != null)
                {
                    var serverNode = l_oConfig.Root
                        .Element(ConfigurationFileTags.INTERFACE_SETTINGS)
                        .Element("TRANSMITTERS")
                        .Elements("TRANSMITTER")
                        .FirstOrDefault(s => (string)s.Attribute("Key") == sSystemKey);

                    if (serverNode != null)
                    {
                        var formatNode = serverNode.Elements("FORMAT").FirstOrDefault(f => (string)f.Attribute("Key") == sExchangeFormat);
                        if (formatNode != null)
                        {
                            var element = formatNode.Element(ConfigurationFileTags.REMOTE_PATH);
                            if (element != null)
                            {
                                destPath = element.Value.Trim();
                            }
                        }
                    }
                }

                async_objLogger.LogInfoAsync(recordID, "Remote Export Destination Path: " + destPath);
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.GetTransmitterPath", ex);
            }

            return destPath;
        }

        public static string GetZipFileFromSubFolders(
    string xprotID,
    string asamFileName,
    string recordID = "",
    AsyncLogger async_objLogger = null,
    LifeTokenManager tokenManager = null)
        {
            try
            {
                string parentPath = Path.Combine(
                    @"D:\ASAM-IF-EXPORT\Export\030 - ASAMFiles",
                    xprotID);

                if (!Directory.Exists(parentPath))
                {
                    throw new DirectoryNotFoundException("Parent folder not found: " + parentPath);
                }

                // Convert .xml to .zip
                string zipFileName = Path.ChangeExtension(asamFileName, ".zip");

                // Search all subfolders for the ZIP file
                string zipFilePath = Directory
                    .GetFiles(parentPath, zipFileName, SearchOption.AllDirectories)
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(zipFilePath))
                {
                    throw new FileNotFoundException(
                        $"ZIP file '{zipFileName}' not found under '{parentPath}'.");
                }

                return zipFilePath;
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.GetZipFileFromSubFolders", ex);
                throw;
            }
        }

        public void CopyFilesToRemoteServer(string xprotID, string recordID, string sSystemKey, string sExchangeFormat, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            string sourceFolderPath = Path.Combine(GlobalConstants.ASAMFile_FolderPath, xprotID);
            string remoteBasePath = GetRemoteExportDestPath(sSystemKey, sExchangeFormat, async_objLogger, recordID, tokenManager);

            if (string.IsNullOrEmpty(remoteBasePath))
            {
                async_objLogger.LogInfoAsync(recordID, "CopyFilesToRemoteServer: REMOTE_EXPORT_DESTPATH not configured for " + sExchangeFormat + ". Skipping copy.");
                return;
            }

            string destinationFolderPath = Path.Combine(remoteBasePath, xprotID);
            async_objLogger.LogInfoAsync(recordID, "CopyFilesToRemoteServer Started. Source: " + sourceFolderPath + " Destination: " + destinationFolderPath);

            try
            {
                if (!Directory.Exists(sourceFolderPath))
                {
                    async_objLogger.LogInfoAsync(recordID, "CopyFilesToRemoteServer: Source folder does not exist - " + sourceFolderPath);
                    return;
                }

                CopyFilesFlattened(sourceFolderPath, destinationFolderPath, recordID, async_objLogger, tokenManager);
                async_objLogger.LogInfoAsync(recordID, "CopyFilesToRemoteServer Completed Successfully.");
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.CopyFilesToRemoteServer", ex);
            }
        }

        private void CopyFilesFlattened(string sourceDir, string destinationDir, string recordID, AsyncLogger async_objLogger, LifeTokenManager tokenManager)
        {
            try
            {
                Directory.CreateDirectory(destinationDir);

                var allFiles = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);

                foreach (string filePath in allFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    string destFilePath = Path.Combine(destinationDir, fileName);

                    try
                    {
                        if (File.Exists(destFilePath))
                        {
                            string uniqueName = Guid.NewGuid() + "_" + fileName;
                            destFilePath = Path.Combine(destinationDir, uniqueName);
                        }

                        const int bufferSize = 64 * 1024;

                        using (var sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                        using (var destStream = new FileStream(destFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize))
                        {
                            sourceStream.CopyTo(destStream, bufferSize);
                        }

                        async_objLogger.LogInfoAsync(recordID, "Copied file: " + Path.GetFileName(destFilePath));
                    }
                    catch (Exception ex)
                    {
                        LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.CopyFilesFlattened.FileCopy", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                LogAndFail(async_objLogger, tokenManager, recordID, "BTHelper.CopyFilesFlattened", ex);
            }
        }

        #endregion


    }
}