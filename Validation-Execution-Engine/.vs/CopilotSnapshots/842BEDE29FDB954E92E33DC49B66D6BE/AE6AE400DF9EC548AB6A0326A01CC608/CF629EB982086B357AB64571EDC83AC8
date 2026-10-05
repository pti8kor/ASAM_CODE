using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Xml.Schema;
using System.Configuration;
using System.Threading;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace RB.ROCustomerIntefaceLibrary
{
    [Serializable]

    public class Logger
    {
        //public bool bDebugMode = false;
        public int iLogLevel = GlobalConstants.LOGGERLEVEL1;
        

        public Logger(string sConfigPath)
        {
            ConfigPath = sConfigPath;
        }

        public string ConfigPath { get; set; }

        public Dictionary<int, string> sExchangeProtocols = new Dictionary<int, string>();

        public void LogException(Exception ex)
        {
            try
            {
                string strStackTrace = ex.StackTrace.ToString();
                string sDetail = strStackTrace + ex.ToString();

                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                }
            }
            catch { }
        }
        public void LogException(Exception ex, string strMessage)
        {
            try
            {
                string strStackTrace = ex.StackTrace.ToString();
                string sDetail = strStackTrace + ex.Message.ToString();
                sDetail = sDetail + "Additional Info : " + strMessage;

                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                }
            }
            catch { }
        }

        public void LogInfo(string strMessage)
        {
            try
            {
                string sDetail = " [XP:" + sExchangeProtocols[Thread.CurrentThread.ManagedThreadId] + "] " + strMessage;

                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                }
            }
            catch
            { }

        }

        public void LogInfo(string strMessage, int iLevel)
        {
            try
            {
                if (iLogLevel - iLevel >= 0)
                {
                    string sDetail = " [XP:" + sExchangeProtocols[Thread.CurrentThread.ManagedThreadId] + "] " + strMessage;

                    using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                    {
                        LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                    }
                }
            }
            catch
            { }

        }

        // This is as good as single if condition
        /*  public void LogInfo(string strMessage, int iLevel)
          {
              try
              {
                  switch (iLogLevel - iLevel >= 0)
                  {
                      case true: LogInfo(strMessage);
                          break;
                      case false:
                      default:
                          break;
                  }
              }
              catch
              { }

          }*/

        public void LogException(string strMessage)
        {
            try
            {
                string sDetail = " [XP:" + sExchangeProtocols[Thread.CurrentThread.ManagedThreadId] + "] " + strMessage;
                using (StreamWriter LWHandle = SetLogHandler(ConfigPath))
                {
                    LWHandle.WriteLine(DateTime.Now.ToString() + sDetail + System.Environment.NewLine);
                }
            }
            catch { }
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


    }
}
