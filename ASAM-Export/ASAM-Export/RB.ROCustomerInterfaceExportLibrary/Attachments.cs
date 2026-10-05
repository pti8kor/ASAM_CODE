using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class Attachments
    {
        public void ProcessAttachments(
            XmlDocument RQ1Extract_data,
            string asamFileName,
            string recordID,
            string recordType,
            string xprotID,
            string p_system,
            string interfaceName,
            AsyncLogger asyncLogger)
        {
            // Log start
            try
            {
                asyncLogger.LogInfoAsync(recordID, "ProcessAttachments Method Starts : ").GetAwaiter().GetResult();
            }
            catch { /* Avoid throwing from logging */ }

            BTHelper btHelper = new BTHelper();
            string stateName = btHelper.GetStateName(RQ1Extract_data, recordType);
            string targetFolder = string.Empty;


            // Track which folders had downloads so we can upload once per folder at the end
            var foldersToUpload = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                using (var client = new HttpClient())
                {
                    // Create OSLC object to fetch config details
                    RO_OSLC_DataInterface obj_oslc = new RO_OSLC_DataInterface(p_system, interfaceName, xprotID, asyncLogger);

                    string folderPath = GlobalConstants.ASAMFile_FolderPath + xprotID + "\\";

                    // Extracting AttachmentMappings and Attachments to map and download required attachments.
                    var attachmentMappings = RQ1Extract_data.GetElementsByTagName("AttachmentMapping");
                    var attachments = RQ1Extract_data.GetElementsByTagName("Attachments");

                    // Prepare Basic Auth header
                    var byteArray = Encoding.ASCII.GetBytes($"{obj_oslc.CQUser}:{obj_oslc.CQPasword}");
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                    if (attachmentMappings.Count == 0)
                    {
                        //if the state is not estimated place them nder ExchangedFiles Folder
                        if (!stateName.ToUpper().Contains("ESTIMATED"))
                        {
                             targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);
                            if(!interfaceName.ToLower().Contains("audi"))
                            {
                                ZipIssueFilesWithAttachments(asamFileName, targetFolder, xprotID, asyncLogger);
                            }
                            
                            obj_oslc.UploadFilesInFolder(targetFolder, xprotID, asyncLogger);
                        }
                        //if the state name is ESTIMATED place the files under CommercialFiles folder only for audi
                        else
                        {
                             targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedCommercialFiles);
                           if(!interfaceName.ToLower().Contains("audi"))
                            {
                                targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);
                                ZipIssueFilesWithAttachments(asamFileName, targetFolder, xprotID, asyncLogger);
                            }
                            obj_oslc.UploadFilesInFolder(targetFolder, xprotID, asyncLogger);
                        }
                    }
                    else
                    {


                        foreach (XmlNode mapping in attachmentMappings)
                        {
                            // Eng_Attachment
                            string engAttachment = mapping["Eng_Attachment"]?.InnerText.Trim();

                            // Sales_Attachment
                            string salesAttachment = mapping["Sales_Attachment"]?.InnerText.Trim();

                            bool isAudi = interfaceName.ToUpper().Contains("AUDI");
                            bool isEstimated = stateName.ToUpper().Contains("ESTIMATED");

                            // =========================
                            // AUDI Logic
                            // =========================
                            if (isAudi)
                            {
                                // Non-Estimated -> Only Engineering attachment to Exchange folder
                                if (!isEstimated)
                                {
                                    if (!string.IsNullOrEmpty(engAttachment))
                                    {
                                         targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);

                                        DownloadAttachment(
                                            RQ1Extract_data,
                                            client,
                                            recordID,
                                            attachments,
                                            engAttachment,
                                            interfaceName,
                                            targetFolder,
                                            asyncLogger);

                                        foldersToUpload.Add(targetFolder);
                                    }
                                }
                                else
                                {
                                    // Estimated -> Sales attachment to Commercial folder
                                    if (!string.IsNullOrEmpty(salesAttachment))
                                    {
                                         targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedCommercialFiles);

                                        DownloadAttachment(
                                            RQ1Extract_data,
                                            client,
                                            recordID,
                                            attachments,
                                            salesAttachment,
                                            interfaceName,
                                            targetFolder,
                                            asyncLogger);

                                        foldersToUpload.Add(targetFolder);
                                    }

                                    // Estimated -> Engineering attachment to Exchange folder
                                    if (!string.IsNullOrEmpty(engAttachment))
                                    {
                                         targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);

                                        DownloadAttachment(
                                            RQ1Extract_data,
                                            client,
                                            recordID,
                                            attachments,
                                            engAttachment,
                                            interfaceName,
                                            targetFolder,
                                            asyncLogger);

                                        foldersToUpload.Add(targetFolder);
                                    }
                                }
                            }
                            // =========================
                            // NON-AUDI Logic
                            // =========================
                            else
                            {
                                // Everything goes to Exchange folder
                                if (!string.IsNullOrEmpty(engAttachment))
                                {
                                     targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);

                                    DownloadAttachment(
                                        RQ1Extract_data,
                                        client,
                                        recordID,
                                        attachments,
                                        engAttachment,
                                        interfaceName,
                                        targetFolder,
                                        asyncLogger);

                                    foldersToUpload.Add(targetFolder);
                                }

                                if (!string.IsNullOrEmpty(salesAttachment))
                                {
                                     targetFolder = Path.Combine(folderPath, GlobalConstants.ExchangedFiles);

                                    DownloadAttachment(
                                        RQ1Extract_data,
                                        client,
                                        recordID,
                                        attachments,
                                        salesAttachment,
                                        interfaceName,
                                        targetFolder,
                                        asyncLogger);

                                    foldersToUpload.Add(targetFolder);
                                }
                            }

                        }

                        // Zip issue files with their related attachments, then upload once per folder
                        foreach (var folder in foldersToUpload)
                        {
                            try
                            {
                                if (!interfaceName.ToLower().Contains("audi"))
                                {
                                    ZipIssueFilesWithAttachments(asamFileName, folder, xprotID, asyncLogger);
                                }
                                obj_oslc.UploadFilesInFolder(folder, xprotID, asyncLogger);
                            }
                            catch (Exception ex)
                            {
                                try { asyncLogger.LogExceptionAsync(recordID, ex).GetAwaiter().GetResult(); } catch { }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                try { asyncLogger.LogExceptionAsync(recordID, ex).GetAwaiter().GetResult(); } catch { }
            }
        }

        /// <summary>
        /// Finds all Issue XML files in the folder, reads their ISSUE-SOLUTIONS/ISSUE-RELATED-DOCUMENT
        /// entries to determine which attachment files belong to each issue, then creates a zip archive
        /// containing the issue file and its related attachments. The original loose files are removed
        /// after successful zipping.
        /// </summary>
        private static void ZipIssueFilesWithAttachments(
            string asamfileName,
            string folderPath,
            string recordID,
            AsyncLogger asyncLogger)
        {
            try
            {
                asyncLogger.LogInfoAsync(recordID, "ZipIssueFilesWithAttachments Method Starts for folder: " + folderPath)
                           .GetAwaiter().GetResult();
            }
            catch { }

            if (!Directory.Exists(folderPath))
                return;

            // Build the full path directly from the passed ASAM file name
            string issueFilePath = Path.Combine(folderPath, asamfileName);

            if (!File.Exists(issueFilePath))
            {
                try
                {
                    asyncLogger.LogInfoAsync(recordID, "ASAM file not found: " + issueFilePath)
                               .GetAwaiter().GetResult();
                }
                catch { }
                return;
            }

            try
            {
                // Parse the issue XML to find related attachments via ISSUE-SOLUTIONS
                var relatedAttachmentNames = GetRelatedAttachmentNames(issueFilePath);

                // Build zip file path (same name as issue file but with .zip extension)
                string zipFileName = Path.GetFileNameWithoutExtension(asamfileName) + ".zip";
                string zipFilePath = Path.Combine(folderPath, zipFileName);

                // Collect files to include in the zip: the issue file + its related attachments
                var filesToZip = new List<string> { issueFilePath };

                foreach (var attachmentName in relatedAttachmentNames)
                {
                    string attachmentPath = Path.Combine(folderPath, attachmentName);
                    if (File.Exists(attachmentPath))
                    {
                        filesToZip.Add(attachmentPath);
                    }
                    else
                    {
                        try
                        {
                            asyncLogger.LogInfoAsync(recordID,
                                "Related attachment not found in folder: " + attachmentName)
                                .GetAwaiter().GetResult();
                        }
                        catch { }
                    }
                }

                // Create the zip archive
                if (File.Exists(zipFilePath))
                    File.Delete(zipFilePath);

                using (var zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                {
                    foreach (var filePath in filesToZip)
                    {
                        zipArchive.CreateEntryFromFile(filePath, Path.GetFileName(filePath), CompressionLevel.Optimal);
                    }
                }

                // Remove the original loose files that were added into the zip
                foreach (var filePath in filesToZip)
                {
                    try { File.Delete(filePath); } catch { }
                }

                try
                {
                    asyncLogger.LogInfoAsync(recordID,
                        "Zipped issue file with " + relatedAttachmentNames.Count +
                        " attachment(s): " + zipFileName)
                        .GetAwaiter().GetResult();
                }
                catch { }
            }
            catch (Exception ex)
            {
                try { asyncLogger.LogExceptionAsync(recordID, ex).GetAwaiter().GetResult(); } catch { }
            }

            try
            {
                asyncLogger.LogInfoAsync(recordID, "ZipIssueFilesWithAttachments Method Ends for folder: " + folderPath)
                           .GetAwaiter().GetResult();
            }
            catch { }
        }

        /// <summary>
        /// Parses an Issue XML file and extracts the related attachment file names from
        /// ISSUE-SOLUTIONS/ISSUE-SOLUTION/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT/URL tags.
        /// Handles all known ASAM namespace versions (issue300, issue310, issue311, issue320, etc.).
        /// </summary>
        private static List<string> GetRelatedAttachmentNames(string issueXmlFilePath)
        {
            var attachmentNames = new List<string>();

            try
            {
                var doc = new XmlDocument();
                doc.Load(issueXmlFilePath);

                // The ASAM issue files always have a namespace on the root element.
                // Register it so XPath queries can match the namespaced elements.
                XmlNamespaceManager nsMgr = new XmlNamespaceManager(doc.NameTable);
                string ns = doc.DocumentElement.NamespaceURI;

                XmlNodeList relatedDocs = null;

                if (!string.IsNullOrEmpty(ns))
                {
                    nsMgr.AddNamespace("iss", ns);

                    // Path: MSR-ISSUE / ISSUES / ISSUE / ISSUE-SOLUTIONS / ISSUE-SOLUTION
                    //       / ISSUE-RELATED-DOCUMENTS / ISSUE-RELATED-DOCUMENT / URL
                    relatedDocs = doc.SelectNodes(
                        "//iss:ISSUE-SOLUTIONS/iss:ISSUE-SOLUTION/iss:ISSUE-RELATED-DOCUMENTS/iss:ISSUE-RELATED-DOCUMENT/iss:URL",
                        nsMgr);

                    // Also check for LABEL as fallback if URL is empty but LABEL has the file name
                    if (relatedDocs == null || relatedDocs.Count == 0)
                    {
                        relatedDocs = doc.SelectNodes(
                            "//iss:ISSUE-SOLUTIONS/iss:ISSUE-SOLUTION/iss:ISSUE-RELATED-DOCUMENTS/iss:ISSUE-RELATED-DOCUMENT/iss:LABEL",
                            nsMgr);
                    }
                }
                else
                {
                    // Non-namespaced fallback (unlikely for ASAM files but kept for safety)
                    relatedDocs = doc.SelectNodes(
                        "//ISSUE-SOLUTIONS/ISSUE-SOLUTION/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT/URL");

                    if (relatedDocs == null || relatedDocs.Count == 0)
                    {
                        relatedDocs = doc.SelectNodes(
                            "//ISSUE-SOLUTIONS/ISSUE-SOLUTION/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT/LABEL");
                    }
                }

                if (relatedDocs != null)
                {
                    foreach (XmlNode node in relatedDocs)
                    {
                        string fileName = node.InnerText?.Trim();
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            attachmentNames.Add(fileName);
                        }
                    }
                }
            }
            catch
            {
                // If parsing fails, return empty list — caller will zip issue file alone
            }

            return attachmentNames;
        }

        /// <summary>
        /// Downloads a single attachment file to the target folder (no upload — upload is batched by caller).
        /// </summary>
        private static void DownloadAttachment(
             XmlDocument RQ1Extract_data,
            HttpClient client,
            string recordID,
            XmlNodeList attachments,
            string fileName,
            string interfaceName,
            string targetFolder,
            AsyncLogger asyncLogger)
        {
            
           asyncLogger.LogInfoAsync(recordID, "DownloadAttachment Method Starts for: " + fileName).GetAwaiter().GetResult();

            string ExternalID = string.Empty;

            


            XmlNode matchedAttachment = attachments
                .Cast<XmlNode>()
                .FirstOrDefault(a =>
                    string.Equals(a["filename"]?.InnerText.Trim(), fileName, StringComparison.OrdinalIgnoreCase));

            if (interfaceName.Contains("AUDI"))
            {
                ExternalID = RQ1Extract_data
                .SelectSingleNode("/RQ1_EXTRACT/Issues/Issue/External_ID")
                ?.InnerText;

                fileName = ExternalID + "_" + fileName;
            }

            if (matchedAttachment != null)
            {
                string fileUrl = matchedAttachment["link"]?.InnerText;


                if (!string.IsNullOrEmpty(fileUrl))
                {
                    if (!Directory.Exists(targetFolder))
                        Directory.CreateDirectory(targetFolder);

                    string localPath = Path.Combine(targetFolder, fileName);

                    try
                    {
                        var fileBytes = client.GetByteArrayAsync(fileUrl).GetAwaiter().GetResult();
                        File.WriteAllBytes(localPath, fileBytes);

                        try
                        {
                            asyncLogger.LogInfoAsync(recordID, "Attachment Saved Successfully : " + fileName)
                                       .GetAwaiter().GetResult();
                        }
                        catch { }
                    }
                    catch (Exception ex)
                    {
                        try { asyncLogger.LogExceptionAsync(recordID, ex).GetAwaiter().GetResult(); } catch { }
                    }
                }
            }

            try
            {
                asyncLogger.LogInfoAsync(recordID, "DownloadAttachment Method Ends for: " + fileName).GetAwaiter().GetResult();
            }
            catch { }
        }
    }
}
