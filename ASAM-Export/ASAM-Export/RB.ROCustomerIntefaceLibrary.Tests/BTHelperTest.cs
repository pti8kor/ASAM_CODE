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
    public class BTHelperTest
    {
        private BTHelper bTHelper = new BTHelper();

        /// <summary>
        /// To test GetConfigPathForLogger method.
        /// </summary>
        [Fact]
        public void GetConfigPathForLogger_GivenInterfaceAndXport_ReturnsConfigPath()
        {

            // Generate config Path.
            // ACT
            string configPath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_BMW, BTHelperConstants.xprotID_BMW);

            // Assert
            Assert.Contains(BizTalkConfigParams.RO_ASAM_EXPORT_LOGGER, configPath);
            Assert.Contains(BTHelperConstants.sInterFaceNameExchangeFormat_BMW, configPath);
            Assert.Contains(BTHelperConstants.xprotID_BMW, configPath);
        }


        /// <summary>
        /// To test SetLoggingMode method.
        /// </summary>
        [Fact]
        public void SetLoggingMode_GivenInterfaceAndXport()
        {
            // Arrrange            
            string sInterfaceName = "RO-ASAM-BMW";
            string xPortId = "41517744";

            // Generate config Path.           
            string configPath = bTHelper.GetConfigPathForLogger(sInterfaceName, xPortId);
            Logger objlogger = new Logger(configPath);

            string sExchangeFormat = "RO-ASAM-BMW";

            // Act and Assert
            bTHelper.SetLoggingMode(sExchangeFormat, objlogger);

        }

        /// <summary>
        /// To test GetRecordsCount method.
        /// </summary>
        [Fact]
        public void GetRecordsCount_GivenLifeTokenAndLogger_ReturnsCount()
        {
            // Arrange
            string LifeToken4Files = "RQ1ML00138253: Issue::In Progress||||";
            string sInterfaceName = "RO-ASAM-BMW";
            string xPortId = "41517744";

            // Generate config Path.           
            string configPath = bTHelper.GetConfigPathForLogger(sInterfaceName, xPortId);
            Logger objlogger = new Logger(configPath);

            // Act
            var count = bTHelper.GetRecordsCount(LifeToken4Files, objlogger);

            // Assert
            // To verify count integer and greater than zero
            Assert.IsType<int>(count);
            Assert.True(count > 0);

        }


        /// <summary>
        /// To test GetBatchCount method.
        /// </summary>
        [Fact]
        public void GetBatchCount_GivenRecCountAndLogger_ReturnsCount()
        {
            // Arrange
            string LifeToken4Files = "RQ1ML00138253: Issue::In Progress||||";
            string sInterfaceName = "RO-ASAM-BMW";
            string xPortId = "41517744";

            // Generate config Path.           
            string configPath = bTHelper.GetConfigPathForLogger(sInterfaceName, xPortId);
            Logger objlogger = new Logger(configPath);

            var RecCount = bTHelper.GetRecordsCount(LifeToken4Files, objlogger);

            // Act
            var batchCount = bTHelper.GetBatchCount(RecCount, objlogger);

            // Assert
            // To verify count integer and greater than zero
            Assert.IsType<int>(batchCount);
            Assert.True(batchCount > 0);

        }

        /// <summary>
        /// To test ChangeLifeToken4Xprot method.
        /// </summary>
        [Fact]
        public void ChangeLifeToken4Xprot_GivenLifeTokenAndXportStatus_ReturnsXportStatusOut()
        {
            // Arrange
            // To send dummy for Success/Inprogress/Failure
            string lifeToken4Files = "RQ1ML00138253: Issue::Success||||";
            string xprotStatus = "Incomplete";

            // Act
            var xprotStatusOut = bTHelper.ChangeLifeToken4Xprot(lifeToken4Files, xprotStatus);

            // Assert
            // To verify all status output is Success/Inprogress/Failure.
            Assert.IsType<string>(xprotStatusOut);
            Assert.Equal("Success", xprotStatusOut);
        }


        /// <summary>
        /// To test UpdateExchangeProtocol method.
        /// </summary>
        [Fact]
        public void UpdateExchangeProtocol_GivenXport_ReturnsEmptyString()
        {

            // Act
            var xprotUpdateOut = bTHelper.UpdateExchangeProtocol(BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.recordData_Audi, BTHelperConstants.xprotStatus);

            // Assert TODO: verify Output with dummy
            Assert.IsType<string>(xprotUpdateOut);
            Assert.Equal(string.Empty, xprotUpdateOut);
        }


        //---------- Vaidate Execute orchestration --------------------
        [Fact]
        public void GetRecordNamesFromBatch_GivenLifeToken_BatchAndLogger()
        {
            // Aranage
            int loopIndex = 1;

            // Generate config Path.           
            string configPath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_BMW, BTHelperConstants.xprotID_BMW);
            Logger ROLogger = new Logger(configPath);

            // Act

            var recordNames = bTHelper.GetRecordNamesFromBatch(BTHelperConstants.recordData_BMW + BTHelperConstants.recordData_Audi, loopIndex, ROLogger);

            // Assert TO DO check recordnames
            Assert.IsType<string>(recordNames);
            Assert.Contains(BTHelperConstants.recordID_BMW, recordNames); // BMW
            Assert.Contains(BTHelperConstants.recordID_Audi, recordNames); // Audi

        }

        [Fact]
        public void GetRecordID_GivenRecordName()
        {
            // Aranage and Act
            var recordId = bTHelper.GetRecordID(BTHelperConstants.recordData_BMW + BTHelperConstants.recordData_Audi);

            // Assert TO DO check recordId
            Assert.IsType<string>(recordId);
            Assert.Contains("RQ1ML00138253", recordId); //BMW
            Assert.Contains("Issue", recordId);

        }

        [Fact]
        public void GetEachRecordFromBatch_GivenRecordNamesAndBatch()
        {
            // Aranage
            int parallelAction = 1;

            // Act

            var recordName = bTHelper.GetEachRecordFromBatch(BTHelperConstants.recordData_BMW + BTHelperConstants.recordData_Audi, parallelAction);

            // Assert TO DO check recordname
            Assert.IsType<string>(recordName);
            Assert.Contains("RQ1ML00138253", recordName); //BMW
            Assert.Contains("Issue", recordName);

        }


        // for Construct Rq1Extract
        [Fact]
        public void CreateRQ1DataExtractFile_GivenRecordData_ReturnsXmlDoc()
        {
            // Aranage
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = "RQ1ML00137673"; //Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);

            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act

            var doc = bTHelper.CreateRQ1DataExtractFile(BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);

            // Assert TO DO check recordname
            Assert.IsType<XmlDocument>(doc);
        }


        //  PrettyXml(XmlDocument xmLDoc, string recordData, AsyncLogger async_objLogger, LifeTokenManager tokenManager)

        [Fact]
        public void PrettyXml_GivenXmlDoc_ReturnsFormattedXml()
        {
            // Aranage
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = "RQ1ML00137673"; //Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);

            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act

            var xmLDoc = bTHelper.CreateRQ1DataExtractFile(BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);

            // Act
            var doc = bTHelper.PrettyXml(xmLDoc, BTHelperConstants.recordData_Audi, async_objLogger, tokenManager);

            // Assert check recordname
            Assert.IsType<XmlDocument>(doc);
        }


        [Fact]
        public void UpdateRecords_GivenXmlDoc_returnBool()
        {
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = "RQ1ML00137673"; //Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);

            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act
            XmlDocument XIMF = new XmlDocument();
            XIMF.Load("RQ1ML00138282IMF_Before_Validate.xml");    

            var updateCheck = bTHelper.UpdateRecords(XIMF, BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);
        
            Assert.IsType<bool>(updateCheck);
            Assert.True(updateCheck);
        }

        [Fact]
        public void CreateASAMFile_GivenRq1Data_ReturnsAsamFile()
        {
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = BTHelperConstants.recordData_Audi;//Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);

            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act

            var RQ1Extract_data = bTHelper.CreateRQ1DataExtractFile(BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);


            string asamFileName = bTHelper.CreateASAMFile(RQ1Extract_data, BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);

            Assert.NotEqual(string.Empty, asamFileName);

            Assert.NotEqual("DefaultFileName.xml", asamFileName);

        }


        [Fact]
        public void UpdateIMFAfterValidation_GivenRq1Data_ReturnXmlFile()
        {
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = BTHelperConstants.recordID_Audi;//Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);

            LifeTokenManager tokenManager = new LifeTokenManager();

            // Act

            var RQ1Extract_data = bTHelper.CreateRQ1DataExtractFile(BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);

            XmlDocument XIMF = new XmlDocument();
            XIMF.Load("RQ1ML00138282IMF_Before_Validate.xml");

            var xmlDoc = bTHelper.UpdateIMFAfterValidation(RQ1Extract_data, XIMF, BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, tokenManager);

        Assert.IsType<XmlDocument>(xmlDoc);
        
        }

        [Fact]
        public void ValidateRQ1ExtractFile_GivenRq1Data_ReturnXmlFile()
        {
            // Generate config Path.           
            string sconfigpath = bTHelper.GetConfigPathForLogger(BTHelperConstants.sInterFaceNameExchangeFormat_Audi, BTHelperConstants.xprotID_Audi);
            string sExchangeProtocol = BTHelperConstants.recordID_Audi; //Audi

            AsyncLogger async_objLogger = new AsyncLogger(sconfigpath, sExchangeProtocol);
            LifeTokenManager tokenManager = new LifeTokenManager();

            var RQ1Extract_data = bTHelper.CreateRQ1DataExtractFile(BTHelperConstants.recordData_Audi, BTHelperConstants.xprotID_Audi, BTHelperConstants.p_system, BTHelperConstants.sInterFaceNameExchangeFormat_Audi, async_objLogger, tokenManager);

            var vaidate = bTHelper.ValidateRQ1ExtractFile(RQ1Extract_data, BTHelperConstants.recordData_Audi, async_objLogger, tokenManager);

            Assert.IsType<bool>(vaidate);
            Assert.True(vaidate);

        }

        [Fact]
        public void GetLifeTokenByRecordId_GivenRq1Data_ReturnXmlFile()
        {
            string recordId = string.Empty;
            string lifeTokens = string.Empty;
            var lifeToken = bTHelper.GetLifeTokenByRecordId(recordId, lifeTokens);

        }

        [Fact]
        public void GetConfigPathForFolderCreation_GivenXformatXport()
        {
            string sExchangeFormat = string.Empty;
            string sXPROT = string.Empty;
            string configPath = bTHelper.GetConfigPathForFolderCreation(sExchangeFormat, sXPROT);

        }

        [Fact]
        public void GetConfigpathForAsyncLoggerTest()
        {
            string configPath = bTHelper.GetConfigpathForAsyncLogger();
        }

        [Fact]
        public void VerifyTokenOfRecord_GivenRecIdAndToken()
        {
            string recordID = string.Empty;
            LifeTokenManager tokenManager = new LifeTokenManager();
            tokenManager.Initialize(BTHelperConstants.lifeToken_Failure);
            bool tokenRec = bTHelper.VerifyTokenOfRecord(BTHelperConstants.recordID_BMW, tokenManager);

            Assert.True(tokenRec);
        }

        // bool VerifyTokenOfRecord(string recordID, LifeTokenManager tokenManager)

        //[Fact]
        //public void SimpleAddition_WorksCorrectly()
        //{

        //    int result = 2 + 2;
        //    Assert.Equal(4, result);
        //}
    }
}
