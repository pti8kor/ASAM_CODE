using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class CounterProposal
    {


        public void ProcessCounterProposal(XmlDocument rq1Doc, string RecordID, string RecordType, string p_system, string sExchangeFormat, AsyncLogger async_objLogger,LifeTokenManager tokenManager)
        {
            
            try
            {
               

                var irms = rq1Doc.SelectNodes("//RQ1_EXTRACT/IssueReleaseMaps/IssueReleaseMap");

                string queryurl = string.Empty;
                string queryResult = string.Empty;

                string queryParam = string.Empty;


                foreach (XmlNode irm in irms)
                {
                    var tagsNode = irm.SelectSingleNode("Tags");

                    if (tagsNode == null)
                        continue;

                    var exportModification = tagsNode.SelectSingleNode("EXPORT-MODIFICATION");
                    var status = tagsNode.SelectSingleNode(".//STATUS")?.InnerText;
                    var newTargetRelease = tagsNode.SelectSingleNode(".//NEWTARGETRELEASE")?.InnerText;

                    bool isEstimated = exportModification?.Attributes?["STATE"]?.Value == "ESTIMATED";
                    bool isRejected = status == "REJECTED";
                    bool hasNewTarget = !string.IsNullOrWhiteSpace(newTargetRelease);

                    if (isEstimated && isRejected && hasNewTarget)
                    {

                        //verify NewTarget Release

                        RO_OSLC_DataInterface obj = new RO_OSLC_DataInterface(p_system, sExchangeFormat, RecordID, async_objLogger);
                        queryParam = newTargetRelease;

                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.getReleaseByExtTitle, queryParam, async_objLogger);

                        queryResult = obj.InvokeUrl4ReadOperation(RecordID, queryurl, async_objLogger);

                        string pattern = @"<cq:dbid>\s*(.*?)\s*</cq:dbid>";
                        Match match = Regex.Match(queryResult, pattern, RegexOptions.Singleline);

                        string newTargetReleaseDBID = match.Success ? match.Groups[1].Value : null;

                        // Step 1: Create IssueReleaseMap
                        queryurl = obj.CreateQuery(RecordType, RecordID, GlobalConstants.QueryMethods.create_IRM, queryParam, async_objLogger);

                        string newIRMID = obj.InvokeUrl4CreateOperation(RecordID, queryurl, newTargetReleaseDBID, GlobalConstants.QueryMethods.create_IRM, rq1Doc, RecordType, async_objLogger);

                        bool completed = WaitForIRMCompletion(newIRMID, obj, async_objLogger);

                        if (!completed)
                        {
                            tokenManager.UpdateFailure(RecordID, "Counter Proposal Failure");
                        }
                        
                    }
                }
            }
            catch(Exception ex)
            {
                tokenManager.UpdateFailure(RecordID, "Counter Proposal Failure : " + ex.Message);
            }
            
        }

        public bool WaitForIRMCompletion(string irmId, RO_OSLC_DataInterface obj ,AsyncLogger async_objLogger)
        {
            int maxWaitMs = 3 * 60 * 1000; // 3 minutes
            int delayMs = 5000; // 5 seconds
            int elapsed = 0;
            string xprotID = string.Empty;

            ASAMStageService stgObj = new ASAMStageService(GlobalConstants.connectionString);

            try
            {
                while (elapsed < maxWaitMs)
                {
                    bool isProcessing = stgObj.IsInProgress(irmId);

                    if (!isProcessing)
                    {
                        var queryurl = obj.CreateQuery("Exchangeprotocol", xprotID, GlobalConstants.QueryMethods.getXprotStatus, xprotID, async_objLogger);

                        var queryResult = obj.InvokeUrl4ReadOperation(xprotID, queryurl, async_objLogger);

                        bool status = IsCQSuccess(queryResult);

                        return status; 
                    }

                    else
                    {
                        xprotID = stgObj.GetXprotIdByAsamId(irmId);
                    }



                    Thread.Sleep(delayMs); 
                    elapsed += delayMs;
                }

                return false; 
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while waiting for IRM completion: {irmId}", ex);
            }
        }

        public bool IsCQSuccess(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
                ns.AddNamespace("cq", "http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/");

                XmlNode node = doc.SelectSingleNode("//cq:Status", ns);

                string status = node?.InnerText?.Trim();

                if (string.IsNullOrEmpty(status))
                    return false;

                // Normalize and compare
                return status.Equals("SUCCESS", StringComparison.OrdinalIgnoreCase)
                    || status.Equals("COMPLETED", StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception ex)
            {
                throw new Exception("Error extracting CQ status", ex);
            }
        }
    }

   
}

