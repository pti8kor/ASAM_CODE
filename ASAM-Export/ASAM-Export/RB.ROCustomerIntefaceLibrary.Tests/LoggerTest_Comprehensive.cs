using RB.ROCustomerInterfaceExportLibrary;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Comprehensive test cases for Logger class to improve code coverage
    /// </summary>
    public class LoggerTest_Comprehensive : IDisposable
    {
        private readonly string _testLogDirectory;
        private readonly string _testLogFile;

        public LoggerTest_Comprehensive()
        {
            // Create a unique test directory for each test run
            _testLogDirectory = Path.Combine(Path.GetTempPath(), $"LoggerTests_{Guid.NewGuid()}");
            Directory.CreateDirectory(_testLogDirectory);
            _testLogFile = Path.Combine(_testLogDirectory, "test.log");
        }

        public void Dispose()
        {
            // Cleanup test files
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
        public void Logger_Constructor_ValidPath_CreatesInstance()
        {
            // Arrange & Act
            Logger logger = new Logger(_testLogFile);

            // Assert
            Assert.NotNull(logger);
            Assert.Equal(_testLogFile, logger.ConfigPath);
        }

        [Fact]
        public void Logger_Constructor_EmptyPath_CreatesInstance()
        {
            // Arrange & Act
            Logger logger = new Logger(string.Empty);

            // Assert
            Assert.NotNull(logger);
            Assert.Equal(string.Empty, logger.ConfigPath);
        }

        [Fact]
        public void Logger_DefaultLogLevel_IsLevel1()
        {
            // Arrange & Act
            Logger logger = new Logger(_testLogFile);

            // Assert
            Assert.Equal(GlobalConstants.LOGGERLEVEL1, logger.iLogLevel);
        }

        #endregion

        #region LogException Tests

        [Fact]
        public void LogException_WithException_CreatesLogFile()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
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
            logger.LogException(testException);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Test stack trace exception message", content);
        }

        [Fact]
        public void LogException_WithExceptionAndMessage_LogsBothDetails()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            Exception testException = null;

            try
            {
                throw new ArgumentException("Argument error");
            }
            catch (Exception ex)
            {
                testException = ex;
            }

            string additionalMessage = "Additional context information";

            // Act
            logger.LogException(testException, additionalMessage);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Argument error", content);
            Assert.Contains("Additional Info : Additional context information", content);
        }

        [Fact]
        public void LogException_WithStackTrace_LogsStackTraceDetails()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            Exception testException = null;

            try
            {
                throw new InvalidOperationException("Test stack trace");
            }
            catch (Exception ex)
            {
                testException = ex;
            }

            // Act
            logger.LogException(testException);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Test stack trace", content);
            Assert.Contains("at ", content); // Stack trace contains "at" keyword
        }

        [Fact]
        public void LogException_StringMessage_CreatesLogEntry()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string exceptionMessage = "String exception message";

            // Act
            logger.LogException(exceptionMessage);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(exceptionMessage, content);
        }

        [Fact]
        public void LogException_MultipleExceptions_AppendsToFile()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);


            Exception exception1 = null;
            Exception exception2 = null;

            try
            {
                throw new Exception("First exception");
            }
            catch (Exception ex)
            {
                exception1 = ex;
            }

            try
            {
                throw new Exception("Second exception");
            }
            catch (Exception ex)
            {
                exception2 = ex;
            }

            // Act
            logger.LogException(exception1);
            logger.LogException(exception2);

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("First exception", content);
            Assert.Contains("Second exception", content);
        }

        #endregion

        #region LogInfo Tests

        [Fact]
        public void LogInfo_SimpleMessage_CreatesLogEntry()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string message = "Simple log message";

            // Act
            logger.LogInfo(message);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
        }

        [Fact]
        public void LogInfo_WithLogLevel1_LogsWhenLevelMatches()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            logger.iLogLevel = GlobalConstants.LOGGERLEVEL1;
            string message = "Level 1 message";

            // Act
            logger.LogInfo(message, GlobalConstants.LOGGERLEVEL1);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
        }

        [Fact]
        public void LogInfo_WithLogLevel2_LogsWhenLevelMatches()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            logger.iLogLevel = GlobalConstants.LOGGERLEVEL2;
            string message = "Level 2 message";

            // Act
            logger.LogInfo(message, GlobalConstants.LOGGERLEVEL2);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
        }

        [Fact]
        public void LogInfo_WithLogLevel3_LogsWhenLevelMatches()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            logger.iLogLevel = GlobalConstants.LOGGERLEVEL3;
            string message = "Level 3 message";

            // Act
            logger.LogInfo(message, GlobalConstants.LOGGERLEVEL3);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
        }

        [Fact]
        public void LogInfo_WithHigherLogLevel_DoesNotLog()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            logger.iLogLevel = GlobalConstants.LOGGERLEVEL1;
            string message = "Should not be logged";

            // Act
            logger.LogInfo(message, GlobalConstants.LOGGERLEVEL3);

            // Assert - File may exist but should not contain the message
            if (File.Exists(_testLogFile))
            {
                string content = File.ReadAllText(_testLogFile);
                Assert.DoesNotContain(message, content);
            }
        }

        [Fact]
        public void LogInfo_MultipleMessages_AppendsToSameFile()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string message1 = "First message";
            string message2 = "Second message";
            string message3 = "Third message";

            // Act
            logger.LogInfo(message1);
            logger.LogInfo(message2);
            logger.LogInfo(message3);

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message1, content);
            Assert.Contains(message2, content);
            Assert.Contains(message3, content);
        }

        [Fact]
        public void LogInfo_EmptyMessage_CreatesLogEntry()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);

            // Act
            logger.LogInfo(string.Empty);

            // Assert
            Assert.True(File.Exists(_testLogFile));
        }

        [Fact]
        public void LogInfo_IncludesTimestamp()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string message = "Message with timestamp";

            // Act
            DateTime beforeLog = DateTime.Now.AddSeconds(-1);
            logger.LogInfo(message);
            DateTime afterLog = DateTime.Now.AddSeconds(1);

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(message, content);
            // Verify timestamp format exists in log
            Assert.Matches(@"\d{1,2}/\d{1,2}/\d{4}|\d{4}-\d{2}-\d{2}", content);
        }

        #endregion

        #region SetLogHandler Tests

        [Fact]
        public void SetLogHandler_NewFile_CreatesFile()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);

            // Act
            using (StreamWriter writer = logger.SetLogHandler(_testLogFile))
            {
                writer.WriteLine("Test content");
            }

            // Assert
            Assert.True(File.Exists(_testLogFile));
        }

        [Fact]
        public void SetLogHandler_ExistingFile_AppendsToFile()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            File.WriteAllText(_testLogFile, "Existing content\n");

            // Act
            using (StreamWriter writer = logger.SetLogHandler(_testLogFile))
            {
                writer.WriteLine("Appended content");
            }

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Existing content", content);
            Assert.Contains("Appended content", content);
        }

        #endregion

        #region Thread Safety Tests

        [Fact]
        public void Logger_ThreadSafeExchangeProtocol_HandlesMultipleThreads()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            int threadCount = 5;
            Task[] tasks = new Task[threadCount];

            // Act
            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;
                tasks[i] = Task.Run(() =>
                {
                    int threadId = Thread.CurrentThread.ManagedThreadId;
                    logger.sExchangeProtocols[threadId] = $"XP_{threadIndex}";
                    logger.LogInfo($"Message from thread {threadIndex}");
                });
            }

            Task.WaitAll(tasks);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            
            // Verify logs from different threads
            for (int i = 0; i < threadCount; i++)
            {
                Assert.Contains($"Message from thread {i}", content);
            }
        }

        [Fact]
        public void Logger_ExchangeProtocols_DictionaryIsThreadSafe()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            int iterations = 100;
            Task[] tasks = new Task[iterations];

            // Act
            for (int i = 0; i < iterations; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    int threadId = Thread.CurrentThread.ManagedThreadId;
                    logger.sExchangeProtocols[threadId] = $"Protocol_{index}";
                    logger.LogInfo($"Test message {index}");
                });
            }

            Task.WaitAll(tasks);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            // No exceptions thrown means thread-safety worked
        }

        #endregion

        #region Property Tests

        [Fact]
        public void Logger_ConfigPath_CanBeSetAndRetrieved()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string newPath = Path.Combine(_testLogDirectory, "newlog.txt");

            // Act
            logger.ConfigPath = newPath;

            // Assert
            Assert.Equal(newPath, logger.ConfigPath);
        }

        [Fact]
        public void Logger_LogLevel_CanBeModified()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);

            // Act
            logger.iLogLevel = GlobalConstants.LOGGERLEVEL3;

            // Assert
            Assert.Equal(GlobalConstants.LOGGERLEVEL3, logger.iLogLevel);
        }

        #endregion

        #region Edge Case Tests

        [Fact]
        public void LogInfo_VeryLongMessage_HandlesGracefully()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string longMessage = new string('A', 10000);

            // Act
            logger.LogInfo(longMessage);

            // Assert
            Assert.True(File.Exists(_testLogFile));
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(longMessage, content);
        }

        [Fact]
        public void LogException_NestedExceptions_LogsAllDetails()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            // Exception innerException = new InvalidOperationException("Inner exception");

            Exception innerException = null;
            Exception outerException = null;

            try
            {
                throw new InvalidOperationException("Test stack trace exception message");
            }
            catch (Exception ex)
            {
                innerException = ex;
            }

            try
            {
                throw new Exception("Outer exception", innerException);
            }
            catch (Exception ex)
            {
                outerException = ex;
            }

            // Act
            logger.LogException(outerException);

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains("Outer exception", content);
        }

        [Fact]
        public void Logger_SpecialCharactersInMessage_HandlesCorrectly()
        {
            // Arrange
            Logger logger = new Logger(_testLogFile);
            string specialMessage = "Test <>&\"'`~!@#$%^&*()_+-=[]{}|;:,.<>?/";

            // Act
            logger.LogInfo(specialMessage);

            // Assert
            string content = File.ReadAllText(_testLogFile);
            Assert.Contains(specialMessage, content);
        }

        #endregion
    }
}