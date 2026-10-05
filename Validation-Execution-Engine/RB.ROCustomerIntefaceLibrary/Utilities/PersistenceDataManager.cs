using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.IsolatedStorage;

namespace RB.ROCustomerIntefaceLibrary
{
    public struct PersistenceDataStores
    {
        public const string LIFETOKEN = "LIFETOKEN.txt";
        public const string ROISSUEIMF = "ROISSUEIMF.txt";
        public const string USERERROR = "USERERROR.txt";
        public const string ADMINERROR = "ADMINERROR.txt";
        public const string ROISSUEIMFRESET = "RESET_ROISSUEIMF.txt";
        public const string UNIMPORTEDATTACHMENTS = "UNIMPORTEDATTACHMENTS.txt";
    }
    public class PersistenceDataManager
    {

        public void Clear(string sPersistenceDataStore, string sExchangeProtocolId)
        {
            string sPersistenceDataStoreComplete = sExchangeProtocolId + "_" + sPersistenceDataStore;

            try
            {
                using (IsolatedStorageFile isoStore
                                      = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.FileExists(sPersistenceDataStoreComplete))
                    {
                        isoStore.DeleteFile(sPersistenceDataStoreComplete);
                    }
                }
            }
            catch (Exception e)
            {
                //Utilities.objLogger.LogInfo("Isolated Storage file " + sPersistenceDataStoreComplete + " could not be deleted -" + e.Message);
            }
        }

        public void WriteData(string sData, string sPersistenceDataStore, bool bAppend, string sExchangeProtocolId)
        {
            //Write the modified file to an isolated storage
            IsolatedStorageFileStream oStream = null;
            StreamWriter writeStream = null;
            string sPersistenceDataStoreComplete = sExchangeProtocolId + "_" + sPersistenceDataStore;

            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (!bAppend)
                    {
                        oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Create, isoStore);
                    }
                    else
                    {
                        oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Append, isoStore);
                    }
                    // create a writer to the stream...
                    writeStream = new StreamWriter(oStream);
                    // write strings to the Isolated Storage file...
                    writeStream.Write(sData);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                // the streams...
                if (writeStream != null)
                {
                    writeStream.Flush();
                    writeStream.Close();
                }
                if (oStream != null) oStream.Close();
            }
        }

        public string ReadData(string sPersistenceDataStore, string sExchangeProtocolId)
        {           
            string strData = string.Empty;
            string sPersistenceDataStoreComplete = sExchangeProtocolId + "_" + sPersistenceDataStore;

            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.FileExists(sPersistenceDataStoreComplete))
                    {
                        using (IsolatedStorageFileStream oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Open, isoStore))
                        {
                            using (StreamReader ReadStream = new StreamReader(oStream))
                            {                              
                                strData = ReadStream.ReadToEnd();
                                // the streams...
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }            

            return strData;
        }

        public void WriteDataTest(string sData, string sPersistenceDataStore, bool bAppend, string sExchangeProtocolId, Logger objlogger)
        {
            //Write the modified file to an isolated storage
            IsolatedStorageFileStream oStream = null;
            StreamWriter writeStream = null;
            string sPersistenceDataStoreComplete = sExchangeProtocolId + "_" + sPersistenceDataStore;

            objlogger.LogInfo("inside WriteDataTest", GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("sPersistenceDataStoreComplete=" + sPersistenceDataStoreComplete, GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo("sData=" + sData, GlobalConstants.LOGGERLEVEL1);


            try
            {
                using (IsolatedStorageFile isoStore
                                  = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (!bAppend)
                    {
                        oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Create, isoStore);
                    }
                    else
                    {
                        oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Append, isoStore);
                    }
                    // create a writer to the stream...
                    writeStream = new StreamWriter(oStream);
                    // write strings to the Isolated Storage file...
                    writeStream.Write(sData);
                    objlogger.LogInfo("after write data", GlobalConstants.LOGGERLEVEL1);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                // the streams...
                if (writeStream != null)
                {
                    writeStream.Flush();
                    writeStream.Close();
                }
                if (oStream != null) oStream.Close();
                //objlogger.LogInfo("end WriteDataTest");
            }

        }
        public string ReadDataTest(string sPersistenceDataStore, string sExchangeProtocolId, Logger objlogger)
        {           
            string strData = string.Empty;
            string sPersistenceDataStoreComplete = sExchangeProtocolId + "_" + sPersistenceDataStore;
            //objlogger.LogInfo("inside ReadDataTest");
            objlogger.LogInfo("inside ReadDataTest - sPersistenceDataStoreComplete=" + sPersistenceDataStoreComplete, GlobalConstants.LOGGERLEVEL1);

            
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.FileExists(sPersistenceDataStoreComplete))
                    {
                        using (IsolatedStorageFileStream oStream = new IsolatedStorageFileStream(sPersistenceDataStoreComplete, FileMode.Open, isoStore))
                        {
                            using (StreamReader ReadStream = new StreamReader(oStream))
                            {
                                //objlogger.LogInfo("get data" + strData);                                    
                                strData = ReadStream.ReadToEnd();
                                objlogger.LogInfo("after getting data" + strData, GlobalConstants.LOGGERLEVEL1);
                            }
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("file " + sPersistenceDataStoreComplete + "does not exist in iso store ", GlobalConstants.LOGGERLEVEL1);
                    }
                }
            }
            catch (Exception e)
            {
                objlogger.LogException("inside catch" + e.Message);
                throw;
            }          

            //objlogger.LogInfo("end ReadDataTest return = strData=" + strData);
            return strData;
        }

        public void ClearStoreForAttachments(string sPersistenceDataStore, Logger objlogger)
        {
            objlogger.LogInfo("inside ClearStoreForAttachments", GlobalConstants.LOGGERLEVEL1);
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.GetFileNames().Count() > 0)
                    {
                        string[] ArrNames = isoStore.GetFileNames();
                        foreach (string s in ArrNames)
                        {
                            if (s.Contains(sPersistenceDataStore))
                                isoStore.DeleteFile(s);

                        }
                    }
                    else
                    {
                        objlogger.LogInfo("iso store get filenames count=0 ", GlobalConstants.LOGGERLEVEL1);
                    }
                }
            }
            catch (Exception e)
            {
                objlogger.LogException("inside catch" + e.Message);
            }
        }

        public int GetFileCountofIS(string sPersistenceDataStore, string sExchangeProtocolId)
        {
            //Utilities.objLogger.LogInfo("inside GetFileCountofIS");
            int iCount = 0;
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.FileExists(sExchangeProtocolId + "_" + sPersistenceDataStore))
                    {
                        // Utilities.objLogger.LogInfo("file name match found --> reset occured once");
                        iCount = 1;
                    }
                }
            }
            catch (Exception e)
            {
                //Utilities.objLogger.LogInfo("GetFileCountofIS- excep " + e.Message);
            }

            //Utilities.objLogger.LogInfo("End-GetFileCountofIS" + iCount.ToString());
            return iCount;
        }

        public int GetFileCountofATT(string sPersistenceDataStore, string ID, Logger objlogger)
        {
            //objlogger.LogInfo("inside GetFileCountofATT" + sPersistenceDataStore);
            //objlogger.LogInfo("inside GetFileCountofATT" + ID);
            int iCount = 0;
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                {
                    if (isoStore.GetFileNames().Count() > 0)
                    {
                        string[] ArrNames = isoStore.GetFileNames();
                        foreach (string s in ArrNames)
                        {
                            if ((s.Contains(sPersistenceDataStore)) && (s.Contains(ID)))
                                iCount++;
                        }
                    }
                    else
                    {
                        objlogger.LogInfo("iso store get filenames count=0 ", GlobalConstants.LOGGERLEVEL1);
                    }
                }
            }
            catch (Exception e)
            {
                objlogger.LogException("GetFileCountofATT- excep " + e.Message);
            }

            objlogger.LogInfo("end GetFileCountofATT" + iCount.ToString(), GlobalConstants.LOGGERLEVEL1);
            return iCount;
        }

    }
}
