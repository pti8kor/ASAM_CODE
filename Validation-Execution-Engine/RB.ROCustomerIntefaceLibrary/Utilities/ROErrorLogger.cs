using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public class ROErrorLogger
    {
        //static StringBuilder m_oUserErrors = new StringBuilder(); //REUBK-1916

        //static StringBuilder m_oAdminErrors = new StringBuilder(); //REUBK-1916

        //static string sInitialValue = null; //REUBK-1916
        
        public static void RegisterUserError(string sMessage, bool bTop, string sExchangeProtocolId, string sIssueFileName,
            bool bLifeToken = true, string sStatus = "Failure")
        {
            try
            {
                if (bLifeToken)
                {
                    PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                    string sData = l_oDataManager.ReadData(PersistenceDataStores.LIFETOKEN, sExchangeProtocolId);
                    sData = LifeTokenHandler.SetTokenStatus(sData, sIssueFileName, sStatus, sMessage);
                    l_oDataManager.WriteData(sData, PersistenceDataStores.LIFETOKEN, false, sExchangeProtocolId);
                }
                else
                {
                    if (bTop)
                    {
                        PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                        string sData = l_oDataManager.ReadData(PersistenceDataStores.USERERROR, sExchangeProtocolId);
                        l_oDataManager.WriteData("", PersistenceDataStores.USERERROR, false, sExchangeProtocolId);
                        sMessage = System.Environment.NewLine + sMessage + System.Environment.NewLine + sData;
                        l_oDataManager.WriteData(sMessage, PersistenceDataStores.USERERROR, true, sExchangeProtocolId);
                    }
                    else { RegisterUserError(sMessage, sExchangeProtocolId, sIssueFileName); }
                }
            }
            catch (Exception ex)
            {
                // Utilities.objLogger.LogException(ex);
            }
        }

        public static void RegisterUserError(string sMessage, string sExchangeProtocolId, string sIssueFileName,
            bool bLifeToken = true, string sStatus = "Failure")
        {
            try
            {
                if (!bLifeToken)
                {
                    PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                    sMessage = System.Environment.NewLine + sMessage;
                    l_oDataManager.WriteData(sMessage, PersistenceDataStores.USERERROR, true, sExchangeProtocolId);
                }
                else
                {
                    PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                    string sData = l_oDataManager.ReadData(PersistenceDataStores.LIFETOKEN, sExchangeProtocolId);
                    sData = LifeTokenHandler.SetTokenStatus(sData, sIssueFileName, sStatus, sMessage);
                    l_oDataManager.WriteData(sData, PersistenceDataStores.LIFETOKEN, false, sExchangeProtocolId);
                }
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogException(ex);
            }
        }

        public static void RegisterAdminError(string sMessage, string sExchangeProtocolId)
        {
            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                sMessage = sMessage + System.Environment.NewLine;
                l_oDataManager.WriteData(sMessage, PersistenceDataStores.ADMINERROR, false, sExchangeProtocolId);
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogException(ex);
            }
        }

        public static void RegisterAdminError(Exception ex, string sExchangeProtocolId)
        {
            try
            {
                StringBuilder sError = new StringBuilder();
                sError.Append(ex.Message);
                sError.Append(System.Environment.NewLine);
                sError.Append(ex.StackTrace);
                sError.Append(System.Environment.NewLine);

                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                l_oDataManager.WriteData(sError.ToString(), PersistenceDataStores.ADMINERROR, false, sExchangeProtocolId);
            }
            catch (Exception e)
            {
                //Utilities.objLogger.LogException(e);
            }
        }

        public void WriteUserErrors(string sExchangeFormat, string sExchangeProtocolId
                                        , string sEntity,
                                         string sField, bool bAppend, Dictionary<string, string> sAddtionalFields, string sSystem, string sattpath, Logger objlogger)
        {
            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                string sErr = l_oDataManager.ReadData(PersistenceDataStores.USERERROR, sExchangeProtocolId);
                UpdateRecord(sExchangeFormat, sExchangeProtocolId, sEntity, sField, bAppend, sErr, sAddtionalFields, sSystem, sattpath, "", objlogger);
                l_oDataManager.WriteData("", PersistenceDataStores.USERERROR, false, sExchangeProtocolId);
            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }
        }

        public void WriteLifeToken(string sExchangeFormat, string sExchangeProtocolId
                                        , string sEntity,
                                         string sField, bool bAppend, string sLifeToken,
                                          Dictionary<string, string> sAddtionalFields, string sSystem, Logger objlogger, string sattpath, string slog, bool bConcat = true)
        {
            try
            {
                UpdateRecord(sExchangeFormat, sExchangeProtocolId, sEntity, sField, bAppend, sLifeToken, sAddtionalFields, sSystem, sattpath, slog, objlogger, bConcat);

            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }
        }

        public void WriteInitialLifeToken(string sExchangeFormat, string sExchangeProtocolId
                                        , string sEntity,
                                         string sField, bool bAppend, string sLifeToken,
                                          Dictionary<string, string> sAddtionalFields, string sSystem, string sattpath, bool bConcat, Logger objlogger)
        {
            try
            {
                objlogger.LogInfo("WriteInitialLifeToken : Starts ", GlobalConstants.LOGGERLEVEL1);
                UpdateRecord(sExchangeFormat, sExchangeProtocolId, sEntity, sField, bAppend, sLifeToken, sAddtionalFields, sSystem, sattpath, "", objlogger, bConcat);

            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }
        }

        public void AdminUserErrors(string sExchangeFormat, string sExchangeProtocolId
                                        , string sEntity,
                                         string sField, bool bAppend, string sSystem, Logger objlogger)
        {
            try
            {
                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                string sErr = l_oDataManager.ReadData(PersistenceDataStores.ADMINERROR, sExchangeProtocolId);
                UpdateRecord(sExchangeFormat, sExchangeProtocolId, sEntity, sField, bAppend, sErr, null, sSystem, null, null, objlogger);
                l_oDataManager.WriteData("", PersistenceDataStores.ADMINERROR, false, sExchangeProtocolId);
            }
            catch (Exception e)
            {
                objlogger.LogException(e);
            }
        }

        private static void UpdateRecordOld(string sExchangeFormat, string sExchangeProtocolId, string sEntity,
            string sField, bool bAppend, string sData, Dictionary<string, string> sAddtionalFields, string sSystem, Logger objlogger)
        {
            objlogger.LogInfo("inside UpdateRecord", GlobalConstants.LOGGERLEVEL1);
            RODataInterface l_oWriteInterface
                                        = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        sExchangeFormat, sExchangeProtocolId, sSystem, "",  objlogger);

            try
            {
                QueryParameters l_oParams = new QueryParameters();

                l_oParams.Add(GlobalConstants.ENTITY, sEntity);
                l_oParams.Add(GlobalConstants.DBID, sExchangeProtocolId);
               // objlogger.LogInfo("calling LockRecord");
                ClearQuestOleServer.IOAdEntity oEntity = l_oWriteInterface.LockRecord(l_oParams, true) as ClearQuestOleServer.IOAdEntity;
               // objlogger.LogInfo("after calling LockRecord");

                l_oParams = new QueryParameters();
                //objlogger.LogInfo("inside update-add fields");
                l_oParams.Add(sField, sData, ActionTypes.Append);
                if (sAddtionalFields != null)
                {
                    objlogger.LogInfo("inside update-add addnl fields", GlobalConstants.LOGGERLEVEL1);
                    foreach (var AddtionalField in sAddtionalFields)
                    {
                        l_oParams.Add(AddtionalField.Key, AddtionalField.Value);
                    }
                }

                l_oParams.AddComplex(GlobalConstants.ENTITYOBJECT, oEntity);
                //objlogger.LogInfo("calling Update");
                l_oWriteInterface.Update(l_oParams);
                objlogger.LogInfo("after Updating exprot:" + l_oParams.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
            catch
            {
                throw;
            }
            finally
            {
                l_oWriteInterface.Close();
            }
        }

        public string GetInitialVal(string sExchangeFormat, string sExchangeProtocolId, string sEntity, string sSystem, string sField, Logger objlogger)
        {
            objlogger.LogInfo("inside GetInitialVal", GlobalConstants.LOGGERLEVEL1);
            string sInitialValue = "";
            RODataInterface l_oWriteInterface
                                        = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        sExchangeFormat, sExchangeProtocolId, sSystem, null,  objlogger);
            try
            {
                sInitialValue = l_oWriteInterface.GetInitialVal(sExchangeProtocolId);
            }

            catch (Exception e)
            {
                objlogger.LogException("GetInitialVal exception:" + e.Message);
            }
            finally
            {

                l_oWriteInterface.Close();
            }
            return sInitialValue;

        }

        public string GetInitialValOld(string sExchangeFormat, string sExchangeProtocolId, string sEntity, string sSystem, string sField, Logger objlogger)
        {
            objlogger.LogInfo("inside GetInitialVal", GlobalConstants.LOGGERLEVEL1);
            string sInitialValue = "";
            RODataInterface l_oWriteInterface
                                        = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        sExchangeFormat, sExchangeProtocolId, sSystem, null, objlogger);
            try
            {
                QueryParameters l_oParams = new QueryParameters();

                l_oParams.Add(GlobalConstants.ENTITY, sEntity);
                l_oParams.Add(GlobalConstants.DBID, sExchangeProtocolId);
                ClearQuestOleServer.IOAdEntity oEntity = l_oWriteInterface.LockRecord(l_oParams, true) as ClearQuestOleServer.IOAdEntity;
                //ClearQuestOleServer.IOAdEntity oEntity = l_oParams.GetRawComplex()[GlobalConstants.ENTITYOBJECT] as ClearQuestOleServer.IOAdEntity;

                //objlogger.LogInfo("after calling LockRecord");
                sInitialValue = oEntity.GetFieldStringValue(sField);
                objlogger.LogInfo("initial value of xprot log: " + sInitialValue, GlobalConstants.LOGGERLEVEL1);
                oEntity.UnlockRecord();
            }

            catch (Exception e)
            {
                objlogger.LogException("GetInitialVal exception:" + e.Message);
            }
            finally
            {

                l_oWriteInterface.Close();
            }
            return sInitialValue;

        }

        public void UnlockRecord(string sExchangeFormat, string sExchangeProtocolId, string sEntity, string sSystem, Logger objlogger)
        {
            objlogger.LogInfo("inside UnlockRecord", GlobalConstants.LOGGERLEVEL1);
         
            RODataInterface l_oWriteInterface
                                        = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        sExchangeFormat, sExchangeProtocolId, sSystem, null, objlogger);
            try
            {
                QueryParameters l_oParams = new QueryParameters();

                l_oParams.Add(GlobalConstants.ENTITY, sEntity);
                l_oParams.Add(GlobalConstants.DBID, sExchangeProtocolId);

                
                ClearQuestOleServer.IOAdEntity oEntity = l_oWriteInterface.LockRecord(l_oParams, true) as ClearQuestOleServer.IOAdEntity;       
                //objlogger.LogInfo("after calling LockRecord");

                string sLockOwner = oEntity.GetLockOwner();
                objlogger.LogInfo("LockOwner=" + sLockOwner + "-unlocking Record", GlobalConstants.LOGGERLEVEL1);
                //objlogger.LogInfo("calling unlock record");
                oEntity.UnlockRecord();
                //objlogger.LogInfo("after unlocking Record"); 
            }

            catch (Exception e)
            {
                objlogger.LogException("UnlockRecord exception:" + e.Message);
            }
            finally
            {

                l_oWriteInterface.Close();
            }          
        }

        private void UpdateRecord(string sExchangeFormat, string sExchangeProtocolId, string sEntity,
            string sField, bool bAppend, string sData, Dictionary<string, string> sAddtionalFields, string sSystem, string sattpath, string slog, Logger objlogger, bool bConcat = true)
        {
            objlogger.LogInfo("inside UpdateRecord", GlobalConstants.LOGGERLEVEL1);
            RODataInterface l_oWriteInterface
                                        = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        sExchangeFormat, sExchangeProtocolId, sSystem, sattpath, objlogger);

            // string sInitialValue = null; //REUBK-1916
            try
            {
                QueryParameters l_oParams = new QueryParameters();

                l_oParams.Add(GlobalConstants.ENTITY, sEntity);
                l_oParams.Add(GlobalConstants.DBID, sExchangeProtocolId);


                //objlogger.LogInfo("calling LockRecord");
                ClearQuestOleServer.IOAdEntity oEntity = l_oWriteInterface.LockRecord(l_oParams, true) as ClearQuestOleServer.IOAdEntity;

                string LockOwner = oEntity.GetLockOwner();
                objlogger.LogInfo("LockOwner=" + LockOwner, GlobalConstants.LOGGERLEVEL1);

                //objlogger.LogInfo("after calling LockRecord");
                //objlogger.LogInfo("bConcat=" + bConcat.ToString());

               // if (bConcat) //concatenate value of existing and current - only for first time
                //{
                   // objlogger.LogInfo("initial value=: " + slog);
                    //objlogger.LogInfo("--first file- concatenate present and existing--");
                    //sInitialValue = oEntity.GetFieldStringValue(sField);
                    //objlogger.LogInfo("initial value of xprot log: " + sInitialValue);

               // }

                ////update final status of xprot -- lifetoken blank
                
                if (!(string.IsNullOrEmpty(sData)))
                {
                    l_oParams = new QueryParameters();
                    objlogger.LogInfo("inside update-add fields", GlobalConstants.LOGGERLEVEL1);

                    l_oParams.Add(sField, sData + System.Environment.NewLine + System.Environment.NewLine +
                            slog, ActionTypes.Overwrite);

                }
                else
                {
                    //add initial  to every xprot log update -belwo code commented
                    //if (!(string.IsNullOrEmpty(slog)))
                    //{
                       
                    //    //write initail data if any to xprot - log along with status info
                    //    l_oParams = new QueryParameters();
                    //    objlogger.LogInfo("inside update-add initial value att to log");
                    //    // l_oParams.Add(sField, sInitialValue, ActionTypes.Append);

                    //    string svalue = oEntity.GetFieldStringValue(sField);
                    //    l_oParams.Add(sField, svalue + System.Environment.NewLine + System.Environment.NewLine +
                    //        slog, ActionTypes.Overwrite);
                    //}
                }
                if (sAddtionalFields != null)
                {
                    objlogger.LogInfo("inside update-add addnl fields", GlobalConstants.LOGGERLEVEL1);
                    foreach (var AddtionalField in sAddtionalFields)
                    {
                        l_oParams.Add(AddtionalField.Key, AddtionalField.Value);
                    }
                }

                //Add OPMODE and OPCONTEXT
                l_oParams.Add(GlobalConstants.OPERATIONMODE, "ASAM-IMPORT");
                l_oParams.Add(GlobalConstants.OPERATIONCONTEXT, "BizTalk");

                l_oParams.AddComplex(GlobalConstants.ENTITYOBJECT, oEntity);
                //objlogger.LogInfo("calling Update");
                l_oWriteInterface.Update(l_oParams);
                objlogger.LogInfo("after Updating exprot:" + l_oParams.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
            catch
            {
                throw;
            }
            finally
            {
                l_oWriteInterface.Close();
            }
        }
    }
}
