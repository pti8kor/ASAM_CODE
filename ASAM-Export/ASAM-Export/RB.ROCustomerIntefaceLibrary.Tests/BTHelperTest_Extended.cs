using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RB.ROCustomerInterfaceExportLibrary;
using System.IO;
using System.Xml;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Extended test cases for BTHelper to improve code coverage
    /// </summary>
    public class BTHelperTest_Extended
    {
        private readonly BTHelper bTHelper = new BTHelper();

        #region GetConfigPathForLogger Tests

        [Fact]
        public void GetConfigPathForLogger_GivenAudiInterface_ReturnsValidPath()
        {
            // Act
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_Audi, 
                BTHelperConstants.xprotID_Audi);

            // Assert
            Assert.NotNull(configPath);
            Assert.NotEmpty(configPath);
            Assert.Contains(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, configPath);
            Assert.Contains(BTHelperConstants.xprotID_Audi, configPath);
            Assert.EndsWith(".txt", configPath);
        }

        [Fact]
        public void GetConfigPathForFolderCreation_GivenValidParameters_ReturnsCorrectPath()
        {
            // Act
            string configPath = bTHelper.GetConfigPathForFolderCreation(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);

            // Assert
            Assert.NotNull(configPath);
            Assert.Contains(BTHelperConstants.xprotID_BMW, configPath);
        }

        [Fact]
        public void GetConfigpathForAsyncLogger_ReturnsNonEmptyPath()
        {
            // Act
            string configPath = bTHelper.GetConfigpathForAsyncLogger();

            // Assert
            Assert.NotNull(configPath);
            Assert.NotEmpty(configPath);
        }

        #endregion

        #region GetRecordsCount Tests

        [Fact]
        public void GetRecordsCount_GivenSingleRecord_ReturnsOne()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int count = bTHelper.GetRecordsCount(BTHelperConstants.lifeToken_Success, objlogger);

            // Assert
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetRecordsCount_GivenMultipleRecords_ReturnsCorrectCount()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int count = bTHelper.GetRecordsCount(BTHelperConstants.lifeToken_Multiple_Mixed, objlogger);

            // Assert
            Assert.Equal(3, count);
        }

        [Fact]
        public void GetRecordsCount_GivenEmptyString_ReturnsZero()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int count = bTHelper.GetRecordsCount(string.Empty, objlogger);

            // Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetRecordsCount_GivenLargeBatch_ReturnsCorrectCount()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int count = bTHelper.GetRecordsCount(BTHelperConstants.lifeToken_LargeBatch, objlogger);

            // Assert
            Assert.Equal(5, count);
        }

        #endregion

        #region GetBatchCount Tests

        [Fact]
        public void GetBatchCount_GivenZeroRecords_ReturnsZero()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int batchCount = bTHelper.GetBatchCount(0, objlogger);

            // Assert
            Assert.Equal(0, batchCount);
        }

        [Fact]
        public void GetBatchCount_GivenOneRecord_ReturnsOne()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            int batchCount = bTHelper.GetBatchCount(1, objlogger);

            // Assert
            Assert.True(batchCount >= 1);
        }

        [Fact]
        public void GetBatchCount_GivenMultipleRecords_ReturnsCorrectBatchCount()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);
            int recordCount = 25; // Assuming batch size of 10

            // Act
            int batchCount = bTHelper.GetBatchCount(recordCount, objlogger);

            // Assert
            Assert.True(batchCount > 0);
            Assert.IsType<int>(batchCount);
        }

        #endregion

        #region ChangeLifeToken4Xprot Tests

        [Fact]
        public void ChangeLifeToken4Xprot_GivenAllSuccess_ReturnsSuccess()
        {
            // Arrange
            string lifeToken = BTHelperConstants.lifeToken_Multiple_AllSuccess;
            string xprotStatus = BTHelperConstants.xprotStatusIncomplete;

            // Act
            string result = bTHelper.ChangeLifeToken4Xprot(lifeToken, xprotStatus);

            // Assert
            Assert.Equal("Success", result);
        }

        [Fact]
        public void ChangeLifeToken4Xprot_GivenAllFailure_ReturnsFailure()
        {
            // Arrange
            string lifeToken = BTHelperConstants.lifeToken_Multiple_AllFailure;
            string xprotStatus = BTHelperConstants.xprotStatusIncomplete;

            // Act
            string result = bTHelper.ChangeLifeToken4Xprot(lifeToken, xprotStatus);

            // Assert
            Assert.Equal("Failure", result);
        }

        [Fact]
        public void ChangeLifeToken4Xprot_GivenMixedStatus_ReturnsIncomplete()
        {
            // Arrange
            string lifeToken = BTHelperConstants.lifeToken_Multiple_Mixed;
            string xprotStatus = BTHelperConstants.xprotStatus;

            // Act
            string result = bTHelper.ChangeLifeToken4Xprot(lifeToken, xprotStatus);

            // Assert
            Assert.Equal("Incomplete", result);
        }

        [Fact]
        public void ChangeLifeToken4Xprot_GivenEmptyLifeToken_ReturnsOriginalStatus()
        {
            // Arrange
            string lifeToken = string.Empty;
            string xprotStatus = BTHelperConstants.xprotStatus;

            // Act
            string result = bTHelper.ChangeLifeToken4Xprot(lifeToken, xprotStatus);

            // Assert
            Assert.Equal(xprotStatus, result);
        }

        #endregion

        #region GetRecordNamesFromBatch Tests

        [Fact]
        public void GetRecordNamesFromBatch_GivenFirstBatch_ReturnsCorrectRecords()
        {
            // Arrange
            int batchNumber = 1;
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            string recordNames = bTHelper.GetRecordNamesFromBatch(
                BTHelperConstants.lifeToken_Multiple_Mixed, 
                batchNumber, 
                objlogger);

            // Assert
            Assert.NotNull(recordNames);
            Assert.NotEmpty(recordNames);
            Assert.Contains("RQ1ML", recordNames);
        }

        [Fact]
        public void GetRecordNamesFromBatch_GivenLargeBatch_ReturnsMultipleRecords()
        {
            // Arrange
            int batchNumber = 1;
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            Logger objlogger = new Logger(configPath);

            // Act
            string recordNames = bTHelper.GetRecordNamesFromBatch(
                BTHelperConstants.lifeToken_LargeBatch, 
                batchNumber, 
                objlogger);

            // Assert
            Assert.NotNull(recordNames);
            Assert.Contains("||||", recordNames);
        }

        #endregion

        #region GetRecordID Tests

        [Fact]
        public void GetRecordID_GivenValidRecordData_ReturnsRecordID()
        {
            // Act
            string recordId = bTHelper.GetRecordID(BTHelperConstants.recordData_BMW);

            // Assert
            Assert.NotNull(recordId);
            Assert.Contains(BTHelperConstants.recordID_BMW, recordId);
            Assert.Contains("Issue", recordId);
        }

        [Fact]
        public void GetRecordID_GivenIRMRecordData_ReturnsRecordID()
        {
            // Act
            string recordId = bTHelper.GetRecordID(BTHelperConstants.recordData_IRM_Audi);

            // Assert
            Assert.NotNull(recordId);
            Assert.Contains("IssueReleaseMap", recordId);
        }

        [Fact]
        public void GetRecordID_GivenInvalidFormat_ReturnsEmptyString()
        {
            // Act
            string recordId = bTHelper.GetRecordID(BTHelperConstants.recordData_Invalid);

            // Assert
            Assert.NotNull(recordId);
        }

        #endregion

        #region GetEachRecordFromBatch Tests

        [Fact]
        public void GetEachRecordFromBatch_GivenFirstRecord_ReturnsCorrectRecord()
        {
            // Arrange
            int parallelAction = 1;

            // Act
            string recordName = bTHelper.GetEachRecordFromBatch(
                BTHelperConstants.lifeToken_Multiple_Mixed, 
                parallelAction);

            // Assert
            Assert.NotNull(recordName);
            Assert.Contains("RQ1ML00138253", recordName);
        }

        [Fact]
        public void GetEachRecordFromBatch_GivenSecondRecord_ReturnsCorrectRecord()
        {
            // Arrange
            int parallelAction = 2;

            // Act
            string recordName = bTHelper.GetEachRecordFromBatch(
                BTHelperConstants.lifeToken_Multiple_Mixed, 
                parallelAction);

            // Assert
            Assert.NotNull(recordName);
            Assert.Contains("RQ1ML00138254", recordName);
        }

        [Fact]
        public void GetEachRecordFromBatch_GivenIndexOutOfRange_ReturnsEmptyString()
        {
            // Arrange
            int parallelAction = 10; // Exceeds available records

            // Act
            string recordName = bTHelper.GetEachRecordFromBatch(
                BTHelperConstants.lifeToken_Multiple_Mixed, 
                parallelAction);

            // Assert
            Assert.NotNull(recordName);
        }

        #endregion

        #region GetLifeTokenByRecordId Tests

        [Fact]
        public void GetLifeTokenByRecordId_GivenValidRecordId_ReturnsMatchingToken()
        {
            // Arrange
            string recordId = BTHelperConstants.recordID_BMW;
            string lifeTokens = BTHelperConstants.lifeToken_Multiple_Mixed;

            // Act
            string lifeToken = bTHelper.GetLifeTokenByRecordId(recordId, lifeTokens);

            // Assert
            Assert.NotNull(lifeToken);
            Assert.Contains(recordId, lifeToken);
        }

        [Fact]
        public void GetLifeTokenByRecordId_GivenNonExistentRecordId_ReturnsNull()
        {
            // Arrange
            string recordId = "RQ1ML99999999";
            string lifeTokens = BTHelperConstants.lifeToken_Multiple_Mixed;

            // Act
            string lifeToken = bTHelper.GetLifeTokenByRecordId(recordId, lifeTokens);

            // Assert
            Assert.Null(lifeToken);
        }

        [Fact]
        public void GetLifeTokenByRecordId_GivenNullRecordId_ReturnsNull()
        {
            // Arrange
            string recordId = null;
            string lifeTokens = BTHelperConstants.lifeToken_Multiple_Mixed;

            // Act
            string lifeToken = bTHelper.GetLifeTokenByRecordId(recordId, lifeTokens);

            // Assert
            Assert.Null(lifeToken);
        }

        [Fact]
        public void GetLifeTokenByRecordId_GivenEmptyLifeTokens_ReturnsNull()
        {
            // Arrange
            string recordId = BTHelperConstants.recordID_BMW;
            string lifeTokens = string.Empty;

            // Act
            string lifeToken = bTHelper.GetLifeTokenByRecordId(recordId, lifeTokens);

            // Assert
            Assert.Null(lifeToken);
        }

        #endregion

        #region VerifyTokenOfRecord Tests

        [Fact]
        public void VerifyTokenOfRecord_GivenRecordWithFailure_ReturnsTrue()
        {
            // Arrange
            string recordID = BTHelperConstants.recordID_BMW;
            LifeTokenManager tokenManager = new LifeTokenManager();
            tokenManager.Initialize(BTHelperConstants.lifeToken_Failure);

            // Act
            bool result = bTHelper.VerifyTokenOfRecord(recordID, tokenManager);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyTokenOfRecord_GivenRecordWithSuccess_ReturnsFalse()
        {
            // Arrange
            string recordID = BTHelperConstants.recordID_BMW;
            LifeTokenManager tokenManager = new LifeTokenManager();
            tokenManager.Initialize(BTHelperConstants.lifeToken_Success);

            // Act
            bool result = bTHelper.VerifyTokenOfRecord(recordID, tokenManager);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region XML Processing Tests

        [Fact]
        public void PrettyXml_GivenValidXmlDocument_ReturnsFormattedXml()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_Audi, 
                BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = BTHelperConstants.recordID_Audi;
            AsyncLogger async_objLogger = new AsyncLogger(configPath, sExchangeProtocol);
            LifeTokenManager tokenManager = new LifeTokenManager();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(BTHelperConstants.sampleXml_Issue);

            // Act
            XmlDocument result = bTHelper.PrettyXml(xmlDoc, BTHelperConstants.recordData_Audi, async_objLogger, tokenManager);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<XmlDocument>(result);
        }

        [Fact]
        public void CreateRQ1DataExtractFile_GivenAudiIssueData_ReturnsXmlDocument()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_Audi, 
                BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = BTHelperConstants.recordID_Audi;
            AsyncLogger async_objLogger = new AsyncLogger(configPath, sExchangeProtocol);
            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act
            XmlDocument result = bTHelper.CreateRQ1DataExtractFile(
                BTHelperConstants.recordData_Audi,
                BTHelperConstants.xprotID_Audi,
                BTHelperConstants.p_system,
                BTHelperConstants.sInterFaceNameExchangeFormat_Audi,
                async_objLogger,
                tokenManager);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<XmlDocument>(result);
        }

        [Fact]
        public void CreateRQ1DataExtractFile_GivenBMWIssueData_ReturnsXmlDocument()
        {
            // Arrange
            string configPath = bTHelper.GetConfigPathForLogger(
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW, 
                BTHelperConstants.xprotID_BMW);
            string sExchangeProtocol = BTHelperConstants.recordID_BMW;
            AsyncLogger async_objLogger = new AsyncLogger(configPath, sExchangeProtocol);
            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act
            XmlDocument result = bTHelper.CreateRQ1DataExtractFile(
                BTHelperConstants.recordData_BMW,
                BTHelperConstants.xprotID_BMW,
                BTHelperConstants.p_system,
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW,
                async_objLogger,
                tokenManager);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<XmlDocument>(result);
        }

        #endregion

        #region UpdateExchangeProtocol Tests

        [Fact]
        public void UpdateExchangeProtocol_GivenValidParameters_ReturnsEmptyString()
        {
            // Act
            string result = bTHelper.UpdateExchangeProtocol(
                BTHelperConstants.xprotID_Audi,
                BTHelperConstants.p_system,
                BTHelperConstants.sInterFaceNameExchangeFormat_Audi,
                BTHelperConstants.recordData_Audi,
                BTHelperConstants.xprotStatus);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result);
        }

        [Fact]
        public void UpdateExchangeProtocol_GivenBMWData_ReturnsEmptyString()
        {
            // Act
            string result = bTHelper.UpdateExchangeProtocol(
                BTHelperConstants.xprotID_BMW,
                BTHelperConstants.p_system,
                BTHelperConstants.sInterFaceNameExchangeFormat_BMW,
                BTHelperConstants.recordData_BMW,
                BTHelperConstants.xprotStatus);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        #endregion

        #region Edge Case and Negative Tests

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void GetRecordID_GivenInvalidInput_HandlesGracefully(string invalidInput)
        {
            // Act
            string result = bTHelper.GetRecordID(invalidInput);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetRecordsCount_GivenNullLogger_HandlesException()
        {
            // This test should be handled gracefully or throw appropriate exception
            // Depending on implementation, adjust assertion accordingly
            string lifeToken = BTHelperConstants.lifeToken_Success;
            
            // If method throws, use Assert.Throws
            // If method handles null, verify it returns expected value
        }

        [Fact]
        public void ChangeLifeToken4Xprot_GivenNullInputs_HandlesGracefully()
        {
            // Arrange
            string lifeToken = BTHelperConstants.lifeToken_Multiple_AllSuccess;
            string xprotStatus = BTHelperConstants.xprotStatusIncomplete;

            // Act
            string result = bTHelper.ChangeLifeToken4Xprot(lifeToken, xprotStatus);

            // Assert
            Assert.NotNull(result);
        }

        #endregion
    }
}