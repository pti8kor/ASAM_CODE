using System;
using System.IO;
using System.Threading;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Unit tests for Logger covering all public methods.
    /// Uses temp files to avoid depending on production paths.
    /// </summary>
    public class LoggerTests : IDisposable
    {
        private readonly string _tempFile;
        private readonly Logger _logger;

        public LoggerTests()
        {
            _tempFile = Path.GetTempFileName();
            _logger = new Logger(_tempFile);
        }

        public void Dispose()
        {
            if (File.Exists(_tempFile))
                File.Delete(_tempFile);
        }

        #region Constructor

        [Fact]
        public void Constructor_SetsConfigPath()
        {
            Assert.Equal(_tempFile, _logger.ConfigPath);
        }

        [Fact]
        public void Constructor_DefaultLogLevel_IsLevel1()
        {
            Assert.Equal(GlobalConstants.LOGGERLEVEL1, _logger.iLogLevel);
        }

        #endregion

        #region LogInfo(string)

        [Fact]
        public void LogInfo_String_WritesToFile()
        {
            _logger.LogInfo("Test message");
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("Test message", content);
        }

        #endregion

        #region LogInfo(string, int)

        [Fact]
        public void LogInfo_WithLevel_AtOrBelowLogLevel_Writes()
        {
            _logger.iLogLevel = GlobalConstants.LOGGERLEVEL2;
            _logger.LogInfo("Level 1 message", GlobalConstants.LOGGERLEVEL1);
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("Level 1 message", content);
        }

        [Fact]
        public void LogInfo_WithLevel_AboveLogLevel_DoesNotWrite()
        {
            _logger.iLogLevel = GlobalConstants.LOGGERLEVEL1;
            _logger.LogInfo("Level 3 message", GlobalConstants.LOGGERLEVEL3);

            string content = File.ReadAllText(_tempFile);
            Assert.DoesNotContain("Level 3 message", content);
        }

        [Fact]
        public void LogInfo_WithLevel_EqualToLogLevel_Writes()
        {
            _logger.iLogLevel = GlobalConstants.LOGGERLEVEL2;
            _logger.LogInfo("Exact level", GlobalConstants.LOGGERLEVEL2);
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("Exact level", content);
        }

        #endregion

        #region LogException(Exception)

        [Fact]
        public void LogException_Exception_WritesStackTraceAndMessage()
        {
            try
            {
                throw new InvalidOperationException("test exception");
            }
            catch (Exception ex)
            {
                _logger.LogException(ex);
            }

            string content = File.ReadAllText(_tempFile);
            Assert.Contains("test exception", content);
            Assert.Contains("InvalidOperationException", content);
        }

        #endregion

        #region LogException(Exception, string)

        [Fact]
        public void LogException_ExceptionWithMessage_WritesAdditionalInfo()
        {
            try
            {
                throw new Exception("base error");
            }
            catch (Exception ex)
            {
                _logger.LogException(ex, "extra context");
            }

            string content = File.ReadAllText(_tempFile);
            Assert.Contains("base error", content);
            Assert.Contains("extra context", content);
        }

        #endregion

        #region LogException(string)

        [Fact]
        public void LogException_StringMessage_Writes()
        {
            _logger.LogException("string error message");
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("string error message", content);
        }

        #endregion

        #region SetLogHandler

        [Fact]
        public void SetLogHandler_NewFile_CreatesWriter()
        {
            string newPath = Path.GetTempFileName();
            File.Delete(newPath); // ensure it doesn't exist

            try
            {
                using (var writer = _logger.SetLogHandler(newPath))
                {
                    Assert.NotNull(writer);
                    writer.WriteLine("test");
                }

                Assert.True(File.Exists(newPath));
            }
            finally
            {
                if (File.Exists(newPath)) File.Delete(newPath);
            }
        }

        [Fact]
        public void SetLogHandler_ExistingFile_AppendsText()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "existing content\n");

            try
            {
                using (var writer = _logger.SetLogHandler(path))
                {
                    writer.WriteLine("appended");
                }

                string content = File.ReadAllText(path);
                Assert.Contains("existing content", content);
                Assert.Contains("appended", content);
            }
            finally
            {
                File.Delete(path);
            }
        }

        #endregion

        #region Thread-safe exchange protocol

        [Fact]
        public void LogInfo_WithExchangeProtocol_IncludesProtocolInOutput()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            lock (_logger.sExchangeProtocols)
            {
                _logger.sExchangeProtocols[threadId] = "XP_12345";
            }

            _logger.LogInfo("protocol test");
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("XP_12345", content);
        }

        [Fact]
        public void LogInfo_WithoutExchangeProtocol_StillWrites()
        {
            _logger.LogInfo("no protocol");
            string content = File.ReadAllText(_tempFile);
            Assert.Contains("no protocol", content);
        }

        #endregion
    }
}
