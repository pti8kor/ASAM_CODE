using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;
//using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.Unity;
using System.Diagnostics;
using System.Xml.Schema;
using System.Configuration;
using System.Threading;

namespace RB.ROCustomerIntefaceLibrary
{
    public sealed class LogHelper
    {
        private static LogHelper LogHelperInstance = null;


        private static readonly object padlock = new object();
                    

        public Dictionary<int, string> sExchangeProtocols = new Dictionary<int, string>();
        private LogWriter lwWriter = null;       


        public LogHelper(string sConfigPath)
        {
            ConfigPath = sConfigPath;
            SetLogHandler(sConfigPath);
            //  LWHandle = SetLogHandler(sConfigPath);
        }
        public string ConfigPath { get; set; }


        private LogWriter LWHandle
        {
            get { return lwWriter; }
            set { lwWriter = value; }
            // set { SetLogHandler(ConfigPath); }
        }

        public void LogException(Exception ex)
        {
            //Create an object of LogEntry
            LogEntry l_oLogEntry = new LogEntry();
            //Assign properties to LogEntry object.
            l_oLogEntry.Message = ex.StackTrace.ToString();
            l_oLogEntry.Message = l_oLogEntry.Message + ex.ToString();
            l_oLogEntry.Priority = 1;
            l_oLogEntry.TimeStamp = DateTime.Now;
            LWHandle.Write(l_oLogEntry);
        }
        public void LogException(Exception ex, string strMessage)
        {
            //Create an object of LogEntry
            LogEntry l_oLogEntry = new LogEntry();
            //Assign properties to LogEntry object.            
            l_oLogEntry.Message = ex.StackTrace.ToString();
            l_oLogEntry.Message = l_oLogEntry.Message + ex.ToString();
            l_oLogEntry.Message = l_oLogEntry.Message + "Additional Info : " + strMessage;
            l_oLogEntry.TimeStamp = DateTime.Now;
            //Do the Log entry.
            LWHandle.Write(l_oLogEntry);
        }

        public void LogInfo(string strMessage)
        {
            try
            {
                LogEntry l_oLogEntry = new LogEntry();
                l_oLogEntry.Message = " [XP:" + sExchangeProtocols[Thread.CurrentThread.ManagedThreadId] + "] " + strMessage;
                LWHandle.Write(l_oLogEntry);
            }
            catch
            { }

        }

        public void LogException(string strMessage)
        {
            try
            {
                LogEntry l_oLogEntry = new LogEntry();
                l_oLogEntry.Message = " [XP:" + sExchangeProtocols[Thread.CurrentThread.ManagedThreadId] + "] " + strMessage;
                l_oLogEntry.TimeStamp = DateTime.Now;
                LWHandle.Write(l_oLogEntry);
            }
            catch { }
        }

        private void SetLogHandler(string sConfigPath)
        {
            FileConfigurationSource source = new FileConfigurationSource(sConfigPath);           

            LogWriterFactory factory = new LogWriterFactory(source);
            LogWriter writer = factory.Create();
                       
            LWHandle = writer;
        }


        public void CloseHandler()
        {
            LWHandle.Dispose();
            LWHandle = null;
        }

        //REUBK-1916  
        public static LogHelper GetLoggerInstance(string sInterfaceName)
        {
            if (LogHelperInstance == null)
            {
                lock (padlock)
                {
                    if (LogHelperInstance == null)
                    {
                        //GetEvaluator the config path   
                        string sConfigPath = Utilities.LoadItemFromBizTalkAppConfig(sInterfaceName + GlobalConstants.LOG_FILE_CONFIG_PATTERN);
                        LogHelperInstance = new LogHelper(sConfigPath);
                    }

                }
            }
            return LogHelperInstance;
        }

        //public static LogHelper GetLoggerInstance(string sInterfaceName)
        //{
        //    if (LogHelperInstance == null)
        //    {
        //        string sConfigPath = Utilities.LoadItemFromBizTalkAppConfig(sInterfaceName + GlobalConstants.LOG_FILE_CONFIG_PATTERN);
        //        //string sConfigPath = "D:\\RB-ASAM-Interface\\Import\\910 - BTConfigurations\\" + sInterfaceName + "_RB.ROCustomerInterface.Logger.config";
        //        LogHelperInstance = new LogHelper(sConfigPath);
        //        LogHelperInstance.ConfigPath = sConfigPath;
        //    }
        //    else
        //    {
        //        if (LogHelperInstance.ConfigPath.Contains(sInterfaceName.ToUpper()))
        //        {
        //            return LogHelperInstance;
        //        }
        //        else
        //        {
        //            string sConfigPath = Utilities.LoadItemFromBizTalkAppConfig(sInterfaceName + GlobalConstants.LOG_FILE_CONFIG_PATTERN);
        //            //string sConfigPath = "D:\\RB-ASAM-Interface\\Import\\910 - BTConfigurations\\" + sInterfaceName + "_RB.ROCustomerInterface.Logger.config";
        //            LogHelperInstance = new LogHelper(sConfigPath);
        //            LogHelperInstance.ConfigPath = sConfigPath;
        //        }
        //    }

        //    return LogHelperInstance;
        //}



        ~LogHelper()
        {
            CloseHandler();
        }

    }
}
