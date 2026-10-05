using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RB.ROCustomerInterfaceExportLibrary
{
    [Serializable]
    public class Logger
    {
        #region variables
        public int iLogLevel = GlobalConstants.LOGGERLEVEL1;

        public string ConfigPath { get; set; }

        public Dictionary<int, string> sExchangeProtocols = new Dictionary<int, string>();

        #endregion

        public Logger(string sConfigPath)
        {
            ConfigPath = sConfigPath;
        }

        public void LogException(Exception ex)
        {
            string strStackTrace = ex.StackTrace.ToString();
            string sDetail = strStackTrace + ex.ToString();

            using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
            {
                LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + Environment.NewLine);
            }
        }
        public void LogException(Exception ex, string strMessage)
        {
            string strStackTrace = ex.StackTrace.ToString();
            string sDetail = strStackTrace + ex.Message.ToString();
            sDetail = sDetail + "Additional Info : " + strMessage;

            using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
            {
                LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + Environment.NewLine);
            }
        }

        public void LogInfo(string strMessage)
        {
            try
            {
                string sDetail = " [XP:" + GetThreadSafeExchangeProtocol() + "] " + strMessage;

                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + Environment.NewLine);
                }
                
            }
            catch (Exception ex)
            { 

            }

        }

        public void LogInfo(string strMessage, int iLevel)
        {
            try
            {
                if (iLogLevel - iLevel >= 0)
                {
                    string sDetail = " [XP:" + GetThreadSafeExchangeProtocol() + "] " + strMessage;

                    using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                    {
                        LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        

        public void LogException(string strMessage)
        {
            try
            {
                string sDetail = " [XP:" + GetThreadSafeExchangeProtocol() + "] " + strMessage;
                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public StreamWriter SetLogHandler(string sConfigPath)
        {
            StreamWriter logwriter;

            if (!File.Exists(sConfigPath))
            {
                logwriter = new StreamWriter(sConfigPath);
            }
            else
            {
                logwriter = File.AppendText(sConfigPath);
            }

            return logwriter;

        }

        private string GetThreadSafeExchangeProtocol()
        {
            string protocol = string.Empty;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            lock (sExchangeProtocols)
            {
                if (sExchangeProtocols.ContainsKey(threadId))
                {
                    protocol = sExchangeProtocols[threadId];
                }
            }

            return protocol;
        }
    }
}
