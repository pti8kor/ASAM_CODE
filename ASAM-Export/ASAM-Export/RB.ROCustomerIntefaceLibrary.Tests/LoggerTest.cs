using RB.ROCustomerInterfaceExportLibrary;
using System.IO;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    using Moq;
    using System;
    using Xunit;

    // Assume you have a logger interface for dependency injection
    public interface ILogger
    {
        void Log(string message);
    }

    public class LoggerTest
    {
        private BTHelper bTHelper = new BTHelper();
        
        [Fact]
        public void LoggerConstructor()
        {
         
            //Act
            var _loggerConst = new Logger("SConfigPath");

            //Assert
            Assert.IsType<Logger>(_loggerConst);

        }

        [Fact]
        public void LogException_CreatesLogFileWithContent()
        {
            // Arrange
            string dummyTrace = "at MyNamespace.MyClass.MyMethod() in C:\\Test\\File.cs:line 42";
            string exceptionMessage = "Direct File Test";
            string expectedPath = "path_from_your_config.log"; 

            // Mock the exception to provide a custom StackTrace
            var mockException = new Mock<Exception>(exceptionMessage);
            mockException.Setup(e => e.StackTrace).Returns(dummyTrace);

            // Mock ToString() because the original code calls ex.ToString()
            mockException.Setup(e => e.ToString()).Returns($"System.Exception: {exceptionMessage}\n{dummyTrace}");

            // Generate config Path.   
            Logger objlogger = new Logger(expectedPath);

            // Act
            // Pass the mocked exception object
            objlogger.LogException(mockException.Object);

            // Assert
            Assert.True(File.Exists(expectedPath));
            string content = File.ReadAllText(expectedPath);

            // Verify the mock stack trace was actually written to the file
            Assert.Contains(exceptionMessage, content);
            Assert.Contains(dummyTrace, content);

            // Clean up
            if (File.Exists(expectedPath)) File.Delete(expectedPath);
        }

    }
}
