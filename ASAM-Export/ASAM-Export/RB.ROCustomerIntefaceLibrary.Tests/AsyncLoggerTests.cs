using System;
using System.IO;
using System.Threading.Tasks;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Unit tests for AsyncLogger covering all public methods.
    /// Uses a temp directory that is cleaned up after each test.
    /// </summary>
    public class AsyncLoggerTests : IDisposable
    {
        private readonly string _tempDir;

        public AsyncLoggerTests()
        {
            _tempDir = Path.Combine(Path.GetTempPath(), "AsyncLoggerTests_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_tempDir);
        }

        public void Dispose()
        {
            if (Directory.Exists(_tempDir))
                Directory.Delete(_tempDir, true);
        }

        #region Constructor

        [Fact]
        public void Constructor_CreatesDirectoryIfNotExists()
        {
            string newDir = Path.Combine(Path.GetTempPath(), "AsyncLoggerNew_" + Guid.NewGuid().ToString("N"));
            try
            {
                Assert.False(Directory.Exists(newDir));
                var logger = new AsyncLogger(newDir, "XP1");
                Assert.True(Directory.Exists(newDir));
            }
            finally
            {
                if (Directory.Exists(newDir)) Directory.Delete(newDir, true);
            }
        }

        [Fact]
        public void Constructor_ExistingDirectory_DoesNotThrow()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            Assert.NotNull(logger);
        }

        #endregion

        #region LogInfoAsync

        [Fact]
        public async Task LogInfoAsync_WritesInfoToFile()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            await logger.LogInfoAsync("REC1", "test info message");

            string logFile = Path.Combine(_tempDir, "REC1_log.txt");
            Assert.True(File.Exists(logFile));

            string content = File.ReadAllText(logFile);
            Assert.Contains("INFO", content);
            Assert.Contains("test info message", content);
        }

        [Fact]
        public async Task LogInfoAsync_EmptyRecordId_DoesNotCreateFile()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            await logger.LogInfoAsync("", "should not write");

            // No file should be created for empty recordId
            Assert.Empty(Directory.GetFiles(_tempDir));
        }

        [Fact]
        public async Task LogInfoAsync_NullRecordId_DoesNotCreateFile()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            await logger.LogInfoAsync(null, "should not write");
            Assert.Empty(Directory.GetFiles(_tempDir));
        }

        [Fact]
        public async Task LogInfoAsync_MultipleCalls_AppendsToSameFile()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            await logger.LogInfoAsync("REC1", "first");
            await logger.LogInfoAsync("REC1", "second");

            string content = File.ReadAllText(Path.Combine(_tempDir, "REC1_log.txt"));
            Assert.Contains("first", content);
            Assert.Contains("second", content);
        }

        #endregion

        #region LogExceptionAsync

        [Fact]
        public async Task LogExceptionAsync_WritesErrorAndStackTrace()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            Exception ex;
            try
            {
                throw new InvalidOperationException("async test error");
            }
            catch (Exception caught)
            {
                ex = caught;
            }

            await logger.LogExceptionAsync("REC2", ex);

            string content = File.ReadAllText(Path.Combine(_tempDir, "REC2_log.txt"));
            Assert.Contains("ERROR", content);
            Assert.Contains("async test error", content);
            Assert.Contains("STACKTRACE", content);
        }

        [Fact]
        public async Task LogExceptionAsync_EmptyRecordId_DoesNotCreateFile()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            await logger.LogExceptionAsync("", new Exception("err"));
            Assert.Empty(Directory.GetFiles(_tempDir));
        }

        #endregion

        #region Dispose

        [Fact]
        public void Dispose_CanBeCalledMultipleTimes()
        {
            var logger = new AsyncLogger(_tempDir, "XP1");
            logger.Dispose();
            logger.Dispose(); // Should not throw
        }

        #endregion
    }
}
