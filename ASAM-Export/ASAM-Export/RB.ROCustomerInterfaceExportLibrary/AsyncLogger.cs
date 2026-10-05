using System;
using System.IO;
using System.Threading.Tasks;


namespace RB.ROCustomerInterfaceExportLibrary
{
    [Serializable]
    public class AsyncLogger : IDisposable
    {
        private readonly string _logDirectory;

        private bool _disposed = false;

        // Constructor that takes the log directory (sconfigpath) as a parameter
        public AsyncLogger(string sconfigpath, string sExchangeProtocol)
        {
            _logDirectory = sconfigpath;

            // Ensure the directory exists
            if (!Directory.Exists(_logDirectory))
            {
                Directory.CreateDirectory(_logDirectory);
            }
        }

        // Method to log general information asynchronously
        public async Task LogInfoAsync(string recordId, string logContent)
        {
            if(!string.IsNullOrEmpty(recordId))
            {
                string logFileName = Path.Combine(_logDirectory, $"{recordId}_log.txt");

                try
                {
                    // Asynchronously write the log content to the file
                    using (StreamWriter writer = new StreamWriter(logFileName, append: true))
                    {
                        await writer.WriteLineAsync($"{DateTime.Now}: INFO: {logContent}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions during logging
                    await LogExceptionAsync(recordId, ex);
                }
            }
            
        }

        // Method to log exceptions asynchronously
        public async Task LogExceptionAsync(string recordId, Exception ex)
        {
            if (!string.IsNullOrEmpty(recordId))
            {
                string logFileName = Path.Combine(_logDirectory, $"{recordId}_log.txt");

                try
                {
                    // Asynchronously write the exception details to the log file
                    using (StreamWriter writer = new StreamWriter(logFileName, append: true))
                    {
                        await writer.WriteLineAsync($"{DateTime.Now}: ERROR: {ex.Message}");
                        await writer.WriteLineAsync($"{DateTime.Now}: STACKTRACE: {ex.StackTrace}");
                    }
                }
                catch (Exception innerEx)
                {
                    // Log any exceptions that occur during logging
                    Console.WriteLine($"Failed to log exception: {innerEx.Message}");
                }
            }
        }

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Dispose managed resources if necessary
            }

            // Free any unmanaged resources if necessary
            _disposed = true;
        }

        ~AsyncLogger()
        {
            Dispose(false);
        }

        #endregion
    }
}

