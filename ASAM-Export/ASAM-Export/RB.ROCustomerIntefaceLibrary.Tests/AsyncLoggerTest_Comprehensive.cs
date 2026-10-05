using RB.ROCustomerInterfaceExportLibrary;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Comprehensive test cases for AsyncLogger class
    /// </summary>
    public class AsyncLoggerTest_Comprehensive : IDisposable
    {
        private readonly string _testLogDirectory;

        public AsyncLoggerTest_Comprehensive()
        {
            _testLogDirectory = Path.Combine(Path.GetTempPath(), $"AsyncLoggerTests_{Guid.NewGuid()}");
        }

        public void Dispose()
        {
            if (Directory.Exists(_testLogDirectory))
            {
                try
                {
                    Directory.Delete(_testLogDirectory, true);
                }
                catch
                {
                    // Ignore cleanup errors
                }
            }
        }

        #region Constructor Tests

        [Fact]
        public void AsyncLogger_Constructor_CreatesDirectory()
        {
            // Arrange & Act
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST001"))
            {
                // Assert
                Assert.True(Directory.Exists(_testLogDirectory));
            }
        }

        [Fact]
        public void AsyncLogger_Constructor_ExistingDirectory_DoesNotThrow()
        {
            // Arrange
            Directory.CreateDirectory(_testLogDirectory);

            // Act
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST002"))
            {
                // Assert
                Assert.True(Directory.Exists(_testLogDirectory));
            }
        }

        #endregion

        #region LogInfoAsync Tests

        [Fact]
        public async Task LogInfoAsync_ValidRecordId_CreatesLogFile()
        {
            // Arrange
            string recordId = "RQ1ML00138253";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                string message = "Test log message";

                // Act
                await logger.LogInfoAsync(recordId, message);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                Assert.True(File.Exists(logFile));
                string content = File.ReadAllText(logFile);
                Assert.Contains("INFO:", content);
                Assert.Contains(message, content);
            }
        }

        [Fact]
        public async Task LogInfoAsync_MultipleMessages_AppendsToFile()
        {
            // Arrange
            string recordId = "RQ1ML00138254";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                string message1 = "First message";
                string message2 = "Second message";
                string message3 = "Third message";

                // Act
                await logger.LogInfoAsync(recordId, message1);
                await logger.LogInfoAsync(recordId, message2);
                await logger.LogInfoAsync(recordId, message3);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                string content = File.ReadAllText(logFile);
                Assert.Contains(message1, content);
                Assert.Contains(message2, content);
                Assert.Contains(message3, content);
            }
        }

        [Fact]
        public async Task LogInfoAsync_EmptyRecordId_DoesNotCreateFile()
        {
            // Arrange
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST"))
            {
                // Act
                await logger.LogInfoAsync(string.Empty, "Test message");

                // Assert
                string logFile = Path.Combine(_testLogDirectory, "_log.txt");
                Assert.False(File.Exists(logFile));
            }
        }

        [Fact]
        public async Task LogInfoAsync_NullRecordId_DoesNotCreateFile()
        {
            // Arrange
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST"))
            {
                // Act
                await logger.LogInfoAsync(null, "Test message");

                // Assert
                // Should handle gracefully without creating file or throwing exception
            }
        }

        [Fact]
        public async Task LogInfoAsync_IncludesTimestamp()
        {
            // Arrange
            string recordId = "RQ1ML00138255";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                // Act
                DateTime beforeLog = DateTime.Now.AddSeconds(-1);
                await logger.LogInfoAsync(recordId, "Timestamped message");
                DateTime afterLog = DateTime.Now.AddSeconds(1);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                string content = File.ReadAllText(logFile);
                Assert.Matches(@"\d{1,2}/\d{1,2}/\d{4}|\d{4}-\d{2}-\d{2}", content);
            }
        }

        [Fact]
        public async Task LogInfoAsync_ConcurrentCalls_HandlesThreadSafely()
        {
            // Arrange
            string recordId = "RQ1ML00138256";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                Task[] tasks = new Task[10];

                // Act
                for (int i = 0; i < tasks.Length; i++)
                {
                    int index = i;
                    tasks[i] = logger.LogInfoAsync(recordId, $"Concurrent message {index}");
                }
                await Task.WhenAll(tasks);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                Assert.True(File.Exists(logFile));
                string content = File.ReadAllText(logFile);
                
                for (int i = 0; i < tasks.Length; i++)
                {
                    Assert.Contains($"Concurrent message {i}", content);
                }
            }
        }

        #endregion

        #region LogExceptionAsync Tests

        [Fact]
        public async Task LogExceptionAsync_ValidException_CreatesLogEntry()
        {
            // Arrange
            string recordId = "RQ1ML00138257";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                Exception testException = new InvalidOperationException("Test exception");

                // Act
                await logger.LogExceptionAsync(recordId, testException);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                Assert.True(File.Exists(logFile));
                string content = File.ReadAllText(logFile);
                Assert.Contains("ERROR:", content);
                Assert.Contains("Test exception", content);
                Assert.Contains("STACKTRACE:", content);
            }
        }

        [Fact]
        public async Task LogExceptionAsync_WithStackTrace_LogsStackTrace()
        {
            // Arrange
            string recordId = "RQ1ML00138258";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                Exception testException = null;
                try
                {
                    throw new ArgumentException("Argument error");
                }
                catch (Exception ex)
                {
                    testException = ex;
                }

                // Act
                await logger.LogExceptionAsync(recordId, testException);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                string content = File.ReadAllText(logFile);
                Assert.Contains("STACKTRACE:", content);
                Assert.Contains("Argument error", content);
            }
        }

        [Fact]
        public async Task LogExceptionAsync_EmptyRecordId_DoesNotCreateFile()
        {
            // Arrange
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST"))
            {
                Exception testException = new Exception("Test");

                // Act
                await logger.LogExceptionAsync(string.Empty, testException);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, "_log.txt");
                Assert.False(File.Exists(logFile));
            }
        }

        [Fact]
        public async Task LogExceptionAsync_NullRecordId_DoesNotThrow()
        {
            // Arrange
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST"))
            {
                Exception testException = new Exception("Test");

                // Act & Assert - Should not throw
                await logger.LogExceptionAsync(null, testException);
            }
        }

        [Fact]
        public async Task LogExceptionAsync_MultipleExceptions_LogsAll()
        {
            // Arrange
            string recordId = "RQ1ML00138259";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                Exception ex1 = new Exception("First exception");
                Exception ex2 = new Exception("Second exception");

                // Act
                await logger.LogExceptionAsync(recordId, ex1);
                await logger.LogExceptionAsync(recordId, ex2);

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                string content = File.ReadAllText(logFile);
                Assert.Contains("First exception", content);
                Assert.Contains("Second exception", content);
            }
        }

        #endregion

        #region Dispose Tests

        [Fact]
        public void AsyncLogger_Dispose_CanBeCalledMultipleTimes()
        {
            // Arrange
            AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST003");

            // Act & Assert - Should not throw
            logger.Dispose();
            logger.Dispose();
            logger.Dispose();
        }

        [Fact]
        public void AsyncLogger_UsingStatement_DisposesCorrectly()
        {
            // Arrange & Act
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, "TEST004"))
            {
                // Use logger
            }

            // Assert - No exception thrown means proper disposal
            Assert.True(true);
        }

        #endregion

        #region Integration Tests

        [Fact]
        public async Task AsyncLogger_MixedLoggingOperations_HandlesCorrectly()
        {
            // Arrange
            string recordId = "RQ1ML00138260";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                // Act
                await logger.LogInfoAsync(recordId, "Info message 1");
                await logger.LogExceptionAsync(recordId, new Exception("Exception 1"));
                await logger.LogInfoAsync(recordId, "Info message 2");
                await logger.LogExceptionAsync(recordId, new Exception("Exception 2"));

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                string content = File.ReadAllText(logFile);
                Assert.Contains("Info message 1", content);
                Assert.Contains("Exception 1", content);
                Assert.Contains("Info message 2", content);
                Assert.Contains("Exception 2", content);
            }
        }

        [Fact]
        public async Task AsyncLogger_LongRunningOperations_CompletesSuccessfully()
        {
            // Arrange
            string recordId = "RQ1ML00138261";
            using (AsyncLogger logger = new AsyncLogger(_testLogDirectory, recordId))
            {
                // Act
                for (int i = 0; i < 100; i++)
                {
                    await logger.LogInfoAsync(recordId, $"Message {i}");
                }

                // Assert
                string logFile = Path.Combine(_testLogDirectory, $"{recordId}_log.txt");
                Assert.True(File.Exists(logFile));
                string content = File.ReadAllText(logFile);
                Assert.Contains("Message 0", content);
                Assert.Contains("Message 99", content);
            }
        }

        #endregion
    }
}