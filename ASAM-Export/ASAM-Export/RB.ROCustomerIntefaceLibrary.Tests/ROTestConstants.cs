using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// General test constants for RO Customer Interface tests
    /// </summary>
    class ROTestConstants
    {
        // Add common constants here as needed
    }

    /// <summary>
    /// Test constants specific to BTHelper testing
    /// </summary>
    public struct BTHelperConstants
    {
        // System Configuration
        public const string p_system = "CDG_DEV_INTEGRATION@RQ1ML";
        public const string xprotStatus = "Success";
        public const string xprotStatusIncomplete = "Incomplete";
        public const string xprotStatusFailure = "Failure";

        // VW Audi Test Data
        public const string sInterFaceNameExchangeFormat_Audi = "RO-ASAM-AUDI";
        public const string xprotID_Audi = "41519234";
        public const string recordData_Audi = "RQ1ML00138282: Issue::In Progress ||||";
        public const string recordData_Audi_Multiple = "RQ1ML00138282: Issue::In Progress|||| RQ1ML00137674: Issue::Specified||||";
        public const string recordID_Audi = "RQ1ML00138282";
        public const string recordType_Audi_Issue = "Issue";

        // BMW Test Data
        public const string sInterFaceNameExchangeFormat_BMW = "RO-ASAM-BMW";
        public const string recordData_BMW = "RQ1ML00138253: Issue::In Progress ||||";
        public const string recordData_BMW_Multiple = "RQ1ML00138253: Issue::In Progress|||| RQ1ML00138254: IssueReleaseMap::Estimated||||";
        public const string xprotID_BMW = "41517744";
        public const string recordID_BMW = "RQ1ML00138253";
        public const string recordType_BMW_Issue = "Issue";

        // Mercedes-Benz Test Data (for future use)
        public const string sInterFaceNameExchangeFormat_MB = "RO-ASAM-MB";
        public const string xprotID_MB = "41520000";
        public const string recordData_MB = "RQ1ML00139000: Issue::In Progress||||";

        // IssueReleaseMap Test Data
        public const string recordData_IRM_Audi = "RQ1ML00137680: IssueReleaseMap::Estimated||||";
        public const string recordData_IRM_BMW = "RQ1ML00138260: IssueReleaseMap::Specified||||";
        public const string recordType_IRM = "IssueReleaseMap";

        // Life Token Test Data
        public const string lifeToken_Success = "RQ1ML00138253: Issue::Success||||";
        public const string lifeToken_Failure = "RQ1ML00138253: Issue::Failure||||";
        public const string lifeToken_InProgress = "RQ1ML00138253: Issue::In Progress||||";
        public const string lifeToken_Multiple_Mixed = "RQ1ML00138253: Issue::Success |||||| RQ1ML00138254: Issue::Failure |||||| RQ1ML00138255: Issue::In Progress||||||";
        public const string lifeToken_Multiple_Mixed_LifeToken = "RQ1ML00138253: Issue::Success |||| RQ1ML00138254: Issue::Failure |||| RQ1ML00138255: Issue::In Progress||||";
        public const string lifeToken_Multiple_AllSuccess = "RQ1ML00138253: Issue::Success|||| RQ1ML00138254: Issue::Success||||";
        public const string lifeToken_Multiple_AllFailure = "RQ1ML00138253: Issue::Failure|||| RQ1ML00138254: Issue::Failure||||";

        // Batch Processing Test Data
        public const string lifeToken_LargeBatch = "RQ1ML00138253: Issue::In Progress |||||| RQ1ML00138254: Issue::In Progress|||||| RQ1ML00138255: Issue::In Progress |||||| RQ1ML00138256: Issue::In Progress |||||| RQ1ML00138257: Issue::In Progress ||||||";

        // Edge Case Test Data
        public const string recordData_Empty = "";
        public const string recordData_Invalid = "InvalidFormat";
        public const string recordData_MissingType = "RQ1ML00138253::::In Progress||||";
        public const string recordData_ExtraDelimiters = "RQ1ML00138253: Issue::In Progress||||||||||";

        // State Names for Validation
        public const string state_Estimated = "ESTIMATED";
        public const string state_EstimatedPilot = "ESTIMATED_PILOT";
        public const string state_EstimatedAffected = "ESTIMATED_AFFECTED";
        public const string state_Specified = "SPECIFIED";
        public const string state_Closed = "CLOSED";
        public const string state_InfoUpdate = "info-update";

        // Workflow Types
        public const string workflow_VAG = "VAG";
        public const string workflow_BMW = "BMW";
        public const string workflow_FAE = "FAE";

        // Version Test Data
        public const string version_RB01 = "1.0.0.RB01";
        public const string version_RB02 = "1.0.0.RB02";
        public const string version_RB99 = "1.0.0.RB99";

        // XML Test Data Samples
        public const string sampleXml_Issue = @"<RQ1_EXTRACT CreationDate=""2026-03-20T10:00:00"">
            <Issues>
                <Issue recordtype=""Issue"" dbid=""12345"">
                    <id>RQ1ML00138253</id>
                    <ExternalNextState>SPECIFIED</ExternalNextState>
                    <ExternalExchangeWorkflow>BMW</ExternalExchangeWorkflow>
                </Issue>
            </Issues>
        </RQ1_EXTRACT>";

        public const string sampleXml_IRM = @"<RQ1_EXTRACT CreationDate=""2026-03-20T10:00:00"">
            <IssueReleaseMaps>
                <IssueReleaseMap recordtype=""IssueReleaseMap"" dbid=""67890"">
                    <id>RQ1ML00138260</id>
                    <ExternalNextState>ESTIMATED</ExternalNextState>
                    <MappingToDerivatives>[P] G01 [S] G02</MappingToDerivatives>
                </IssueReleaseMap>
            </IssueReleaseMaps>
        </RQ1_EXTRACT>";
    }

    /// <summary>
    /// Test constants for Logger testing
    /// </summary>
    public struct LoggerTestConstants
    {
        public const string TestLogMessage = "Test log message";
        public const string TestExceptionMessage = "Test exception occurred";
        public const int LogLevel1 = 1;
        public const int LogLevel2 = 2;
        public const int LogLevel3 = 3;
    }

    /// <summary>
    /// Test constants for RO_OSLC_DataInterface testing
    /// </summary>
    public struct OSLCTestConstants
    {
        public const string QueryMethod_GetIssueById = "getIssueById";
        public const string QueryMethod_GetReleaseByDbId = "getReleaseByDbId";
        public const string QueryMethod_UpdateIssue = "UpdateIssue";
        public const string QueryMethod_UpdateXprot = "UpdateXprot";
        public const string RecordType_Issue = "Issue";
        public const string RecordType_IRM = "IssueReleaseMap";
        public const string RecordType_Release = "Release";
        public const string RecordType_Project = "Project";
    }

    /// <summary>
    /// Test constants for Attachment processing
    /// </summary>
    public struct AttachmentTestConstants
    {
        public const string TechnicalAttachment = "Technical_Document.pdf";
        public const string FinancialAttachment = "Financial_Report.xlsx";
        public const string ExportState_Sent = "SENT";
        public const string ExportState_Received = "RECEIVED";
        public const string Attribute_Technical = "Technical";
        public const string Attribute_Financial = "Financial";
    }
}
