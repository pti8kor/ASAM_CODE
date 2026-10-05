using RB.ROCustomerInterfaceExportLibrary;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Comprehensive test cases for ROConfigurationManager class
    /// </summary>
    public class ROConfigurationManagerTest_Comprehensive : IDisposable
    {
        private readonly string _testConfigDirectory;
        private readonly string _testConfigFile;
        private readonly string _testLogFile;

        public ROConfigurationManagerTest_Comprehensive()
        {
            _testConfigDirectory = Path.Combine(Path.GetTempPath(), $"ConfigTests_{Guid.NewGuid()}");
            Directory.CreateDirectory(_testConfigDirectory);
            _testConfigFile = Path.Combine(_testConfigDirectory, "test_config.xml");
            _testLogFile = Path.Combine(_testConfigDirectory, "test.log");
        }

        public void Dispose()
        {
            if (Directory.Exists(_testConfigDirectory))
            {
                try
                {
                    Directory.Delete(_testConfigDirectory, true);
                }
                catch
                {
                    // Ignore cleanup errors
                }
            }
        }

        #region Constructor Tests

        [Fact]
        public void ROConfigurationManager_Constructor_WithLogger_SetsProperties()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);

            // Act
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);

            // Assert
            Assert.NotNull(manager);
            Assert.Equal(_testConfigFile, manager.ConfigXMLPath);
        }

        [Fact]
        public void ROConfigurationManager_Constructor_WithAsyncLogger_SetsProperties()
        {
            // Arrange
            AsyncLogger asyncLogger = new AsyncLogger(_testConfigDirectory, "TEST001");
            string recordId = "RQ1ML00138253";

            // Act
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, asyncLogger, recordId);

            // Assert
            Assert.NotNull(manager);
            Assert.Equal(_testConfigFile, manager.ConfigXMLPath);
        }

        [Fact]
        public void ROConfigurationManager_DefaultConstructor_CreatesInstance()
        {
            // Act
            ROConfigurationManager manager = new ROConfigurationManager();

            // Assert
            Assert.NotNull(manager);
        }

        #endregion

        #region LoadConfigurationXML Tests

        [Fact]
        public void LoadConfigurationXML_ValidConfigFile_LoadsSuccessfully()
        {
            // Arrange
            CreateSampleConfigFile();
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.NotNull(config);
            Assert.NotNull(config.Root);
        }

        [Fact]
        public void LoadConfigurationXML_NonExistentFile_ReturnsNull()
        {
            // Arrange
            string nonExistentFile = Path.Combine(_testConfigDirectory, "nonexistent.xml");
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(nonExistentFile, logger);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.Null(config);
        }

        [Fact]
        public void LoadConfigurationXML_EmptyPath_ReturnsNull()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(string.Empty, logger);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.Null(config);
        }

        [Fact]
        public void LoadConfigurationXML_InvalidXML_ReturnsNull()
        {
            // Arrange
            File.WriteAllText(_testConfigFile, "Invalid XML Content");
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.Null(config);
        }

        [Fact]
        public void LoadConfigurationXML_SetsConfigurationXMLProperty()
        {
            // Arrange
            CreateSampleConfigFile();
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.NotNull(manager.ConfigurationXML);
            Assert.Equal(config, manager.ConfigurationXML);
        }

        [Fact]
        public void LoadConfigurationXML_WithAsyncLogger_LoadsSuccessfully()
        {
            // Arrange
            CreateSampleConfigFile();
            AsyncLogger asyncLogger = new AsyncLogger(_testConfigDirectory, "TEST002");
            string recordId = "RQ1ML00138253";
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, asyncLogger, recordId);

            // Act
            XDocument config = manager.LoadConfigurationXML();

            // Assert
            Assert.NotNull(config);
        }

        #endregion

        #region VerifyLoggerandSet Tests

        [Fact]
        public void VerifyLoggerandSet_WithLogger_LogsInfo()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);
            string message = "Test info message";

            // Act
            manager.VerifyLoggerandSet(message, string.Empty, null);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
        }

        [Fact]
        public void VerifyLoggerandSet_WithLogger_LogsException()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, logger);
            string message = "Test exception context";

            // Simulate an exception to generate a stack trace
            Exception testException = null;

            try
            {
                throw new InvalidOperationException("Test stack trace exception message");
            }
            catch (Exception ex)
            {
                testException = ex;
            }

            // Act
            manager.VerifyLoggerandSet(message, string.Empty, testException);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Test stack trace exception message", content);
        }       

        [Fact]
        public async Task VerifyLoggerandSet_WithAsyncLogger_LogsInfo()
        {
            // Arrange
            AsyncLogger asyncLogger = new AsyncLogger(_testConfigDirectory, "TEST003");
            string recordId = "RQ1ML00138253";
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, asyncLogger, recordId);
            string message = "Async test message";

            // Act
            manager.VerifyLoggerandSet(message, recordId, null);
            await Task.Delay(100); // Allow async operation to complete

            // Assert
            string logFile = Path.Combine(_testConfigDirectory, $"{recordId}_log.txt");
            Assert.True(File.Exists(logFile));
        }

        [Fact]
        public async Task VerifyLoggerandSet_WithAsyncLogger_LogsException()
        {
            // Arrange
            AsyncLogger asyncLogger = new AsyncLogger(_testConfigDirectory, "TEST004");
            string recordId = "RQ1ML00138254";
            ROConfigurationManager manager = new ROConfigurationManager(_testConfigFile, asyncLogger, recordId);
            Exception testException = new Exception("Async exception");

            // Act
            manager.VerifyLoggerandSet("Context", recordId, testException);
            await Task.Delay(100); // Allow async operation to complete

            // Assert
            string logFile = Path.Combine(_testConfigDirectory, $"{recordId}_log.txt");
            Assert.True(File.Exists(logFile));
        }

        [Fact]
        public void VerifyLoggerandSet_WithNullLogger_DoesNotThrow()
        {
            // Arrange
            ROConfigurationManager manager = new ROConfigurationManager();
            manager.ConfigXMLPath = _testConfigFile;

            // Act & Assert - Should not throw
            manager.VerifyLoggerandSet("Test message", string.Empty, null);
        }

        #endregion

        #region Property Tests

        [Fact]
        public void ConfigXMLPath_CanBeSetAndRetrieved()
        {
            // Arrange
            ROConfigurationManager manager = new ROConfigurationManager();
            string testPath = @"C:\Test\Config.xml";

            // Act
            manager.ConfigXMLPath = testPath;

            // Assert
            Assert.Equal(testPath, manager.ConfigXMLPath);
        }

        [Fact]
        public void ConfigurationXML_CanBeSetAndRetrieved()
        {
            // Arrange
            ROConfigurationManager manager = new ROConfigurationManager();
            XDocument testDoc = XDocument.Parse("<root><test>value</test></root>");

            // Act
            manager.ConfigurationXML = testDoc;

            // Assert
            Assert.Equal(testDoc, manager.ConfigurationXML);
        }

        #endregion

        #region Helper Methods

        private void CreateSampleConfigFile()
        {
            string xmlContent = @"<?xml version=""1.0"" encoding=""utf-8""?>
<CONFIGURATIONS>
    <INTERFACE_SETTINGS>
        <LOGGER_SETTINGS>
            <LOGGINGLEVEL ENABLE=""TRUE"" LEVEL=""1""/>
        </LOGGER_SETTINGS>
        <SERVERS>
            <SERVER Key=""CDG_DEV_INTEGRATION@RQ1ML"">
                <FORMAT Key=""AUDI"">
                    <REMOTE_EXPORT_DESTPATH>\\server\path\audi</REMOTE_EXPORT_DESTPATH>
                </FORMAT>
                <FORMAT Key=""BMW"">
                    <REMOTE_EXPORT_DESTPATH>\\server\path\bmw</REMOTE_EXPORT_DESTPATH>
                </FORMAT>
            </SERVER>
        </SERVERS>
    </INTERFACE_SETTINGS>
</CONFIGURATIONS>";

            File.WriteAllText(_testConfigFile, xmlContent);
        }

        #endregion
    }
}