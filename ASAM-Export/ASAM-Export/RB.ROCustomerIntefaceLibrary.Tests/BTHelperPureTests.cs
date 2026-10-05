using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Comprehensive unit tests for all pure / locally-testable methods in BTHelper.
    /// These tests do NOT require network, config files, or external servers.
    /// </summary>
    public class BTHelperPureTests
    {
        private readonly BTHelper _helper = new BTHelper();

        #region GetConfigPathForLogger

        [Fact]
        public void GetConfigPathForLogger_ReturnsPathContainingBaseDir()
        {
            string result = _helper.GetConfigPathForLogger("FMT", "XP1");
            Assert.Contains(BizTalkConfigParams.ROASAMLOGGER, result);
        }

        [Fact]
        public void GetConfigPathForLogger_ReturnsPathContainingExchangeFormat()
        {
            string result = _helper.GetConfigPathForLogger("RO-ASAM-BMW", "12345");
            Assert.Contains("RO-ASAM-BMW", result);
        }

        [Fact]
        public void GetConfigPathForLogger_ReturnsPathContainingXProtId()
        {
            string result = _helper.GetConfigPathForLogger("RO-ASAM-BMW", "99999");
            Assert.Contains("99999", result);
        }

        [Fact]
        public void GetConfigPathForLogger_ReturnsPathEndingWithTxt()
        {
            string result = _helper.GetConfigPathForLogger("FMT", "XP");
            Assert.EndsWith(".txt", result);
        }

        [Fact]
        public void GetConfigPathForLogger_DoesNotContainSlashOrColon()
        {
            // The filename portion should have replaced / and : with .
            string result = _helper.GetConfigPathForLogger("FMT", "XP");
            // Extract just the filename at the end
            string fileName = Path.GetFileName(result);
            Assert.DoesNotContain("/", fileName);
            Assert.DoesNotContain(":", fileName);
        }

        #endregion

        #region GetConfigPathForFolderCreation

        [Fact]
        public void GetConfigPathForFolderCreation_ReturnsBasePathPlusXProt()
        {
            string result = _helper.GetConfigPathForFolderCreation("FMT", "XP123");
            Assert.Equal(BizTalkConfigParams.ROASAMLOGGER + "XP123", result);
        }

        [Fact]
        public void GetConfigPathForFolderCreation_EmptyXProt_ReturnsBasePathOnly()
        {
            string result = _helper.GetConfigPathForFolderCreation("FMT", "");
            Assert.Equal(BizTalkConfigParams.ROASAMLOGGER, result);
        }

        #endregion

        #region GetConfigpathForAsyncLogger

        [Fact]
        public void GetConfigpathForAsyncLogger_ReturnsROASAMLOGGER()
        {
            string result = _helper.GetConfigpathForAsyncLogger();
            Assert.Equal(BizTalkConfigParams.ROASAMLOGGER, result);
        }

        #endregion

        #region ChangeLifeToken4Xprot

        [Theory]
        [InlineData("Failure only", "init", "Failure")]
        [InlineData("Success only", "init", "Success")]
        [InlineData("Both Failure and Success here", "init", "Incomplete")]
        [InlineData("NoMatchHere", "init", "init")]  // unchanged
        public void ChangeLifeToken4Xprot_ReturnsExpectedStatus(string lifeToken, string inputStatus, string expected)
        {
            string result = _helper.ChangeLifeToken4Xprot(lifeToken, inputStatus);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ChangeLifeToken4Xprot_SuccessAndFailure_ReturnsIncomplete()
        {
            string result = _helper.ChangeLifeToken4Xprot("Success |||| Failure", "init");
            Assert.Equal("Incomplete", result);
        }

        #endregion

        #region GetEachRecordFromBatch

        [Fact]
        public void GetEachRecordFromBatch_FirstRecord_ReturnsCorrectRecord()
        {
            string records = "RecA: Issue::InProgress||||RecB: Issue::InProgress||||";
            string result = _helper.GetEachRecordFromBatch(records, 1);
            Assert.Equal("RecA: Issue::InProgress", result);
        }

        [Fact]
        public void GetEachRecordFromBatch_SecondRecord_ReturnsCorrectRecord()
        {
            string records = "RecA: Issue::InProgress||||RecB: Issue::Done||||";
            string result = _helper.GetEachRecordFromBatch(records, 2);
            Assert.Equal("RecB: Issue::Done", result);
        }

        [Fact]
        public void GetEachRecordFromBatch_IndexBeyondBatch_ReturnsEmpty()
        {
            string records = "RecA: Issue::InProgress||||";
            string result = _helper.GetEachRecordFromBatch(records, 5);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetEachRecordFromBatch_EmptyInput_ReturnsEmpty()
        {
            string result = _helper.GetEachRecordFromBatch("", 1);
            Assert.Equal(string.Empty, result);
        }

        #endregion

        #region GetRecordID

        [Fact]
        public void GetRecordID_IssueRecord_ReturnsRecordIdPart()
        {
            string input = "RQ1ML00138253: Issue::In Progress||||";
            string result = _helper.GetRecordID(input);
            Assert.Contains("RQ1ML00138253: Issue", result);
        }

        [Fact]
        public void GetRecordID_IssueReleaseMapRecord_ReturnsRecordIdPart()
        {
            string input = "RQ1ML99999: IssueReleaseMap::Done";
            string result = _helper.GetRecordID(input);
            Assert.Contains("issuereleasemap", result.ToLower());
        }

        [Fact]
        public void GetRecordID_NoMatchingType_ReturnsEmpty()
        {
            string input = "SomethingElse::Done";
            string result = _helper.GetRecordID(input);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetRecordID_EmptyInput_ReturnsEmpty()
        {
            string result = _helper.GetRecordID("");
            Assert.Equal(string.Empty, result);
        }

        #endregion

        #region GetLifeTokenByRecordId

        [Fact]
        public void GetLifeTokenByRecordId_FindsMatchingToken()
        {
            string tokens = "RQ1ML001: Issue::Success||||RQ1ML002: Issue::Failure||||";
            string result = _helper.GetLifeTokenByRecordId("RQ1ML002", tokens);
            Assert.Contains("RQ1ML002", result);
        }

        [Fact]
        public void GetLifeTokenByRecordId_NoMatch_ReturnsNull()
        {
            string tokens = "RQ1ML001: Issue::Success||||";
            string result = _helper.GetLifeTokenByRecordId("NOTEXIST", tokens);
            Assert.Null(result);
        }

        [Fact]
        public void GetLifeTokenByRecordId_EmptyRecordId_ReturnsNull()
        {
            string result = _helper.GetLifeTokenByRecordId("", "RQ1ML001: Issue::Success||||");
            Assert.Null(result);
        }

        [Fact]
        public void GetLifeTokenByRecordId_EmptyTokens_ReturnsNull()
        {
            string result = _helper.GetLifeTokenByRecordId("RQ1ML001", "");
            Assert.Null(result);
        }

        [Fact]
        public void GetLifeTokenByRecordId_BothNull_ReturnsNull()
        {
            string result = _helper.GetLifeTokenByRecordId(null, null);
            Assert.Null(result);
        }

        #endregion

        #region IncrementVersion

        [Theory]
        [InlineData("DAI01#RB01", "DAI01#RB02")]
        [InlineData("DAI01#RB09", "DAI01#RB10")]
        [InlineData("DAI01#RB99", "DAI01#RB100")]
        [InlineData("BMW01#RB01", "BMW01#RB02")]
        public void IncrementVersion_IncrementsRBSuffix(string input, string expected)
        {
            string result = BTHelper.IncrementVersion(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("NoRBHere")]
        [InlineData("")]
        [InlineData("DAI01#XX01")]
        public void IncrementVersion_NoMatch_ReturnsUnchanged(string input)
        {
            string result = BTHelper.IncrementVersion(input);
            Assert.Equal(input, result);
        }

        #endregion

        #region ExtractDbid (string overload)

        [Fact]
        public void ExtractDbid_String_FindsDbidAttribute()
        {
            string xml = "<Root><Issue dbid=\"123\"><id>1</id></Issue></Root>";
            string result = BTHelper.ExtractDbid(xml, "Issue");
            Assert.Equal("123", result);
        }

        [Fact]
        public void ExtractDbid_String_NoMatchingTag_ReturnsNull()
        {
            string xml = "<Root><Release dbid=\"456\"/></Root>";
            string result = BTHelper.ExtractDbid(xml, "Issue");
            Assert.Null(result);
        }

        [Fact]
        public void ExtractDbid_String_NoDbidAttribute_ReturnsNull()
        {
            string xml = "<Root><Issue><id>1</id></Issue></Root>";
            string result = BTHelper.ExtractDbid(xml, "Issue");
            Assert.Null(result);
        }

        #endregion

        #region ExtractDbid (XmlDocument overload)

        [Fact]
        public void ExtractDbid_XmlDoc_FindsDbidAttribute()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Commercial dbid=\"789\"/></Root>");
            string result = BTHelper.ExtractDbid(doc, "Commercial");
            Assert.Equal("789", result);
        }

        [Fact]
        public void ExtractDbid_XmlDoc_NoMatchingTag_ReturnsNull()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Other dbid=\"1\"/></Root>");
            string result = BTHelper.ExtractDbid(doc, "Issue");
            Assert.Null(result);
        }

        [Fact]
        public void ExtractDbid_XmlDoc_NoDbidAttribute_ReturnsNull()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Issue name=\"x\"/></Root>");
            string result = BTHelper.ExtractDbid(doc, "Issue");
            Assert.Null(result);
        }

        [Fact]
        public void ExtractDbid_XmlDoc_MultipleElements_ReturnsFirst()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Issue dbid=\"AAA\"/><Issue dbid=\"BBB\"/></Root>");
            string result = BTHelper.ExtractDbid(doc, "Issue");
            Assert.Equal("AAA", result);
        }

        #endregion

        #region ExtractFileNameFromXml

        [Fact]
        public void ExtractFileNameFromXml_WithShortName_ReturnsIt()
        {
            string xml = @"<MSR-ISSUE xmlns='http://www.asam.net/schemas/issue/issue300'>
                             <SHORT-NAME>MyFile.xml</SHORT-NAME>
                           </MSR-ISSUE>";
            string result = BTHelper.ExtractFileNameFromXml(xml);
            Assert.Equal("MyFile.xml", result);
        }

        [Fact]
        public void ExtractFileNameFromXml_NoShortName_ReturnsDefault()
        {
            string xml = @"<MSR-ISSUE xmlns='http://www.asam.net/schemas/issue/issue300'>
                             <OTHER>Something</OTHER>
                           </MSR-ISSUE>";
            string result = BTHelper.ExtractFileNameFromXml(xml);
            Assert.Equal("DefaultFileName.xml", result);
        }

        #endregion

        #region GetStateName

        [Fact]
        public void GetStateName_Issue_ReturnsExternalNextState()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Issue><ExternalNextState>SPECIFIED</ExternalNextState></Issue></Root>");
            string result = _helper.GetStateName(doc, "ISSUE");
            Assert.Equal("SPECIFIED", result);
        }

        [Fact]
        public void GetStateName_IssueReleaseMap_ReturnsExternalNextState()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><IssueReleaseMap><ExternalNextState>ACCEPTED</ExternalNextState></IssueReleaseMap></Root>");
            string result = _helper.GetStateName(doc, "ISSUERELEASEMAP");
            Assert.Equal("ACCEPTED", result);
        }

        [Fact]
        public void GetStateName_NoNode_ReturnsEmpty()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root></Root>");
            string result = _helper.GetStateName(doc, "ISSUE");
            Assert.Equal(string.Empty, result);
        }

        #endregion

        #region PrettyXml

        [Fact]
        public void PrettyXml_ValidXml_ReturnsFormattedDocument()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Child>value</Child></Root>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                var tokenMgr = new LifeTokenManager();

                XmlDocument result = _helper.PrettyXml(doc, "", logger, tokenMgr);

                Assert.NotNull(result);
                Assert.Contains("Child", result.OuterXml);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void PrettyXml_EmptyXmlDoc_ReturnsSameDoc()
        {
            XmlDocument doc = new XmlDocument();
            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                var tokenMgr = new LifeTokenManager();

                // Empty XmlDocument will throw in Save, caught internally
                XmlDocument result = _helper.PrettyXml(doc, "", logger, tokenMgr);
                Assert.NotNull(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void PrettyXml_WithRecordData_ParsesRecordIdAndType()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Root><Child>value</Child></Root>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                var tokenMgr = new LifeTokenManager();

                XmlDocument result = _helper.PrettyXml(doc, "REC1: Issue", logger, tokenMgr);
                Assert.NotNull(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        #endregion

        #region ValidateMappingDerivatives

        [Fact]
        public void ValidateMappingDerivatives_NullDoc_ReturnsFalse()
        {
            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(null, "REC1: Issue", logger);
                Assert.False(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_NoIssueNode_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<RQ1_EXTRACT><Issues></Issues></RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_WorkflowNotFAE_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>VAG</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAEWithMatchingCodes_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap>
                                <MappingToDerivatives>[A] CODE1</MappingToDerivatives>
                            </IssueReleaseMap></IssueReleaseMaps>
                            <Projects><Project>
                                <ExternalDescription>SI = &quot;CODE1&quot;</ExternalDescription>
                            </Project></Projects>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAEWithNonMatchingCodes_ReturnsFalse()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_AFFECTED</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap>
                                <MappingToDerivatives>[A] UNMATCHED</MappingToDerivatives>
                            </IssueReleaseMap></IssueReleaseMaps>
                            <Projects><Project>
                                <ExternalDescription>SI = &quot;CODE1&quot;</ExternalDescription>
                            </Project></Projects>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.False(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAENoProjectNode_ReturnsFalse()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap>
                                <MappingToDerivatives>[A] CODE1</MappingToDerivatives>
                            </IssueReleaseMap></IssueReleaseMaps>
                            <Projects></Projects>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.False(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAEEmptyMappingText_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap>
                                <MappingToDerivatives>  </MappingToDerivatives>
                            </IssueReleaseMap></IssueReleaseMaps>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAENoMappingNode_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap></IssueReleaseMap></IssueReleaseMaps>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        [Fact]
        public void ValidateMappingDerivatives_FAEMappingNoRegexMatch_ReturnsTrue()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<RQ1_EXTRACT>
                            <Issues><Issue>
                                <ExternalExchangeWorkflow>FAE</ExternalExchangeWorkflow>
                                <ExternalNextState>ESTIMATED_PILOT</ExternalNextState>
                            </Issue></Issues>
                            <IssueReleaseMaps><IssueReleaseMap>
                                <MappingToDerivatives>no bracket pattern here</MappingToDerivatives>
                            </IssueReleaseMap></IssueReleaseMaps>
                          </RQ1_EXTRACT>");

            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            try
            {
                var logger = new AsyncLogger(tempDir, "test");
                bool result = _helper.ValidateMappingDerivatives(doc, "REC1: Issue", logger);
                Assert.True(result);
            }
            finally
            {
                Directory.Delete(tempDir, true);
            }
        }

        #endregion

        #region VerifyTokenOfRecord

        [Fact]
        public void VerifyTokenOfRecord_TokenContainsFailure_ReturnsTrue()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateFailure("REC1", "some error");

            bool result = _helper.VerifyTokenOfRecord("REC1", mgr);
            Assert.True(result);
        }

        [Fact]
        public void VerifyTokenOfRecord_TokenContainsSuccess_ReturnsFalse()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateSuccess("REC1");

            bool result = _helper.VerifyTokenOfRecord("REC1", mgr);
            Assert.False(result);
        }

        #endregion
    }
}
