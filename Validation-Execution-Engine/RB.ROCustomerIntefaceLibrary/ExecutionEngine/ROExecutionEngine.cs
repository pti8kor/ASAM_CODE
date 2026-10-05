using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.IO.IsolatedStorage;
using ClearQuestOleServer;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace RB.ROCustomerIntefaceLibrary
{
    public class NodeInfo
    {
        public string RONAME { get; set; }
        public IEnumerable<XElement> KEYS { get; set; }
        public string XPATH { get; set; }
        public string INSERT { get; set; }
        public string UPDATE { get; set; }
    }

    public class ExecROAttachment
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string FULLPATH { get; set; }
        public string FULLNAME { get; set; }
        public string FILESIZE { get; set; }
        public bool DESCCHANGEONLY { get; set; }

    }

    //public class IMFROCommonAttachments
    //{
    //    public string IMFATTNAME { get; set; }
    //    public string IMFATTDESCRIPTION { get; set; }
    //    public string IMFATTFILESIZE { get; set; }
    //    public string IMFTRUNCATTNAME { get; set; }
    //    public string ROATTNAME { get; set; }
    //    public string ROATTTRUNCNAME { get; set; }
    //    public string ROATTDESCRIPTION { get; set; }
    //    public string ROATTFILESIZE { get; set; }

    //}

    public class ROExecutionEngine
    {
        XDocument IssueIMF = null;
        XDocument oConfiguration = null;
        XmlNamespaceManager nsIMFMgr;
        //string IssueExternalID = string.Empty;
        string IssueExternalState = string.Empty;
        string IssueExternalExchnageWF = string.Empty;
        

        

        //List<string> l_oIgnoreList = new List<string>() { "BELONGSTOPROJECT" };  REUBK-1660 DefaultValuesHandling
        List<string> l_oIgnoreList = new List<string>() { };
        List<string> l_oExecuteBasicList = new List<string>() { "CONTACT", "ISSUE" };
        Dictionary<string, ClearQuestOleServer.IOAdEntity> m_oLockedEntities = new Dictionary<string, IOAdEntity>();
        AffectedRecords m_oAffectedRecords = new AffectedRecords();

        public Dictionary<string, string> OrcParms
        {
            get;
            set;
        }


        Logger objlogger = null;

        public ROExecutionEngine(XDocument xIssueIntermFile, Dictionary<string, string> p_OrcParms, XDocument xConfData, Logger l_ologger)
        {
            objlogger = l_ologger;
            IssueIMF = xIssueIntermFile;
            nsIMFMgr = Utilities.GetIMFNameSpace(xIssueIntermFile);
            oConfiguration = xConfData;
            OrcParms = p_OrcParms;
           // GetIssueExternalID();
            GetIssueState();
            GetIssueWorkflow();
        }

        public void GetIssueState()
        {
            //objlogger.LogInfo("GetIssueState :- Starts");
            try
            {

                IssueExternalState = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO)
                    .Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMEXTERNALSTATE).Value;
                    //IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.OEMEXTERNALSTATE).Value;
                objlogger.LogInfo("IssueExternalState: " + IssueExternalState, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {

                objlogger.LogException(ex, "GetIssueState: Error in getting state values");

            }
           // objlogger.LogInfo("GetIssueState :- Ends");
        }




        public void GetIssueWorkflow()
        {
            //objlogger.LogInfo("GetIssueWorkflow :- Starts");
            try
            {
                if (IssueIMF.Root.Element(IMFFileTags.RT_ISSUE) != null)
                {
                    IssueExternalExchnageWF = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                        .Element(IMFFileTags.ISSUE).Element(IMFFileTags.EXTERNALEXCHANGEWF).Value;
                }
                objlogger.LogInfo("IssueExternalExchnageWF: " + IssueExternalExchnageWF,GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {

                objlogger.LogException(ex, "GetIssueWorkflow: Error in getting IssueWorkflow values");

            }
           // objlogger.LogInfo("GetIssueWorkflow :- Ends");
        }


        //void GetIssueExternalID()
        //{
        //    objlogger.LogInfo("GetIssueExternalID: Starts");
        //    try
        //    {
        //        IssueExternalID = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
        //                .Element(IMFFileTags.ISSUE).Element(IMFFileTags.EXTERNALID).Value.ToString();
        //        objlogger.LogInfo("IssueExternalID: " + IssueExternalID);
        //    }
        //    catch (Exception ex)
        //    {
        //        IssueExternalID = null;
        //        objlogger.LogException(ex, "Execution Engine: Issue External ID not present");
        //    }
        //    objlogger.LogInfo("GetIssueExternalID: Ends");
        //}

        public bool Execute()
        {
            objlogger.LogInfo("ROExecutionEngine::Execute: Starts", GlobalConstants.LOGGERLEVEL1);
            bool isValid = false;

            //objlogger.LogInfo("Getting OSLC");
            RODataInterface l_oReadInterface
                                = Factory.GetInterface(ROAvailableDataInterfaces.OSLC, OrcParms[OrcParameters.EXCHANGEFORMAT], null, OrcParms[OrcParameters.SYSTEM], OrcParms[OrcParameters.ATTACHMENTPATH], objlogger);
           //objlogger.LogInfo("Getting CQ_API");
            RODataInterface l_oWriteInterface
                                    = Factory.GetInterface(ROAvailableDataInterfaces.CQ_API,
                                        OrcParms[OrcParameters.EXCHANGEFORMAT], OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.SYSTEM], OrcParms[OrcParameters.ATTACHMENTPATH], objlogger);

            string sInterfaceName = oConfiguration.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS)
                                       .Element(ConfigurationFileTags.INTERFACE_MODE).Value;

            //objlogger.LogInfo("Trying to get all elements from IMF");
            IEnumerable<XElement> oElementsToProcess = IssueIMF.Root.Elements().Where(e => e.Name.LocalName != IMFFileTags.RT_VALEXCONTROLINFO);
            objlogger.LogInfo(oElementsToProcess.Count().ToString() + " Number of processable elements", GlobalConstants.LOGGERLEVEL1);


            #region Executing stack
            //Addtional Locking safety
            ////comment for debugging
            if (GlobalConstants.isCurrentlyExecuting(OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], objlogger))
            {
                ROErrorLogger.RegisterUserError("Execution engine failed with error - File is currently being imported by another ExchangeProtocol or not registered."
                                   , OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                return false;
            }
            //else
            //{
            //    if (OrcParms[OrcParameters.FIRSTFILE].ToUpper() == "YES")
            //    {
            //        objlogger.LogInfo("first file for valex");                    
            //        GlobalConstants.RegisterForExecution(OrcParms[OrcParameters.XCHANGEPROTOCOLID],OrcParms[OrcParameters.ISSUEFILENAMES],objlogger);
            //    }
            //}
            #endregion

            #region AffectedRecordsConfig
            m_oAffectedRecords.SetConfiguration(oConfiguration);
            #endregion



            try
            {
                //Try to get lock on all the records to process.
                GetLockOnRecords(oElementsToProcess, l_oWriteInterface);
                objlogger.LogInfo("afterlock ", GlobalConstants.LOGGERLEVEL1);

                foreach (XElement oElementInContext in oElementsToProcess)
                {
                    //objlogger.LogInfo("Trying to get elements name from " + oElementInContext.Name.ToString());

                    if (oElementInContext.HasElements)
                    {
                        string sElementName = oElementInContext.Elements().FirstOrDefault().Name.ToString();

                        objlogger.LogInfo("Element to process = " + sElementName, GlobalConstants.LOGGERLEVEL1);

                        if (sInterfaceName == "FULL" || l_oExecuteBasicList.Contains(sElementName))
                        {
                            isValid = ProcessRecords(sElementName, l_oReadInterface, l_oWriteInterface);
                            objlogger.LogInfo(sElementName + ": isValid: " + isValid.ToString(), GlobalConstants.LOGGERLEVEL1);
                            if (!isValid) return false;

                            ROErrorLogger.RegisterUserError(sElementName + " processed - processing rest ", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], true, "Failure");
                        }

                        objlogger.LogInfo("Element processed = " + sElementName, GlobalConstants.LOGGERLEVEL1);
                    }
                }

                objlogger.LogInfo("Writing to IsolatedStorage Starts", GlobalConstants.LOGGERLEVEL1);

                PersistenceDataManager l_oDataManager = new PersistenceDataManager();
                l_oDataManager.WriteData(IssueIMF.ToString(), PersistenceDataStores.ROISSUEIMF, false, OrcParms[OrcParameters.XCHANGEPROTOCOLID]);

                objlogger.LogInfo("Writing to IsolatedStorage ends", GlobalConstants.LOGGERLEVEL1);     
         
              
                //   IOrderedEnumerable<AffectedRecord> test = m_oAffectedRecords.OrderBy(o => o.RecordType);
                //   AffectedRecords newm_oAffectedRecords = m_oAffectedRecords.OrderBy(o => o.RecordType).Cast<AffectedRecord>() as AffectedRecords;              
                //   AffectedRecords newm_oAffectedRecords = m_oAffectedRecords.OrderBy(o => o.RecordType) as AffectedRecords;
                //   AffectedRecords new_oAffectedRecords = m_oAffectedRecords.OrderBy(o => o.RecordType).ToList() as AffectedRecords;

                string sSuccessMessage = "---Success---" + System.Environment.NewLine + m_oAffectedRecords.ToString(); //REUBK-989-display affected records

                ROErrorLogger.RegisterUserError(sSuccessMessage, OrcParms[OrcParameters.XCHANGEPROTOCOLID],
                                                    OrcParms[OrcParameters.ISSUEFILENAME], true, "Success");


            }
            catch(LockRecordException ex)
            {
                objlogger.LogException(ex, "ROExecutionEngine:Execute");
                ROErrorLogger.RegisterUserError(ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                isValid = false;
            }
            catch (Exception ex)
            {
                objlogger.LogException(ex, "ROExecutionEngine:Execute");
                ROErrorLogger.RegisterUserError("Import failed with error -" + ex.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                isValid = false;
            }
            finally
            {
                //if (OrcParms[OrcParameters.LASTFILE].ToUpper() == "YES")
                //{
                //    objlogger.LogInfo("last file for valex");
                //    GlobalConstants.DeRegisterFromExecution(OrcParms[OrcParameters.XCHANGEPROTOCOLID], objlogger);
                //}
                //GlobalConstants.DeRegisterFromExecution(OrcParms[OrcParameters.ISSUEFILENAME]);
                foreach (KeyValuePair<string, IOAdEntity> oEntity in m_oLockedEntities)
                {
                    try
                    {
                        oEntity.Value.Revert();
                    }
                    catch { }
                }
                if (l_oReadInterface != null) l_oReadInterface.Close();
                if (l_oWriteInterface != null) l_oWriteInterface.Close();
            }
            objlogger.LogInfo("ROExecutionEngine::Execute: ends", GlobalConstants.LOGGERLEVEL1);
            return isValid;
        }


        public bool GetLockOnRecords(IEnumerable<XElement> oElements, RODataInterface l_oWriteInterface)
        {
            //Ignore the records with blank DBID becasue they are cases for insert.
            var oElementsToLock = oElements.Elements().Where(n => n.Element(GlobalConstants.DBID) != null
                && n.Element(GlobalConstants.DBID).Value != String.Empty
                 && n.Element(GlobalConstants.DBID).Value != "0")
                                 .Select(n => n);


            objlogger.LogInfo("Starting Lock all", GlobalConstants.LOGGERLEVEL1);
            List<string> oAlreadyLockedRecords = new List<string>();

            foreach (XElement oElementInContext in oElementsToLock)
            {
                QueryParameters l_oQueryParms = new QueryParameters();

                //objlogger.LogInfo("Getting Entity Name");
                string sElementName = oElementInContext.Name.ToString();
                objlogger.LogInfo("Entity Name = " + sElementName, GlobalConstants.LOGGERLEVEL1);
                NodeInfo oNodeInfo = GetNodeInfo(sElementName);

                l_oQueryParms.Add(GlobalConstants.ENTITY, oNodeInfo.RONAME);


                string sDBID = oElementInContext.Element(GlobalConstants.DBID).Value;
                string sID = string.Empty;
                string sDomain = string.Empty;

                if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
                {
                    sDomain = oElementInContext.Element(GlobalConstants.DOMAIN).Value;

                }

                try
                {
                    sID = oElementInContext.Element(GlobalConstants.ID).Value;
                }
                catch { }

                l_oQueryParms.Add(GlobalConstants.DBID, sDBID);

                objlogger.LogInfo("Trying to Get record " + sDBID, GlobalConstants.LOGGERLEVEL1);
                IOAdEntity l_oEntity = l_oWriteInterface.LockRecord(l_oQueryParms, false) as IOAdEntity;

                objlogger.LogInfo("Check if record needs update " + sDBID, GlobalConstants.LOGGERLEVEL1);
                bool bIsLockRequired = IsUpdateRequired(oElementInContext, l_oEntity, new QueryParameters());
                objlogger.LogInfo("Needs update for =" + sDBID + " is " + bIsLockRequired.ToString(), GlobalConstants.LOGGERLEVEL1);

                //Lock only if update is required
                if (bIsLockRequired)
                {
                    if (!oAlreadyLockedRecords.Contains(sDBID))
                    {
                        objlogger.LogInfo("Trying to lock " + sDBID, GlobalConstants.LOGGERLEVEL1);
                        l_oQueryParms = new QueryParameters();
                        l_oQueryParms.AddComplex(GlobalConstants.ENTITYOBJECT, l_oEntity);
                        try
                        {
                            l_oEntity = l_oWriteInterface.LockRecord(l_oQueryParms, true) as IOAdEntity;
                        }
                        catch (LockRecordException ex)
                        {
                            string lockOwnerName = l_oEntity.GetLockOwner();
                            objlogger.LogInfo(string.Format("Editing failed as entity {0} is locked", sDBID), GlobalConstants.LOGGERLEVEL1);
                            throw new LockRecordException(string.Format("The record {0} is locked by {1}. If you suspect the lock has been abandoned, contact that user or your administrator to remove the lock.", sID, lockOwnerName));
                        }
                        if (l_oEntity == null) throw new SystemException("Unable to lock record " + sDBID);
                        objlogger.LogInfo("Locked " + sDBID, GlobalConstants.LOGGERLEVEL1);

                        if (!m_oLockedEntities.Keys.Contains(sDBID))
                        {
                            objlogger.LogInfo("Adding to locked list", GlobalConstants.LOGGERLEVEL1);
                            m_oLockedEntities.Add(sDBID, l_oEntity);
                        }
                        else
                        {
                            //Replace with locked entity if one already exists, this may have been a unlocked version
                            objlogger.LogInfo("Updating the locked list with this entity", GlobalConstants.LOGGERLEVEL1);
                            m_oLockedEntities[sDBID] = l_oEntity;
                        }
                        objlogger.LogInfo("Setting record as already locked", GlobalConstants.LOGGERLEVEL1);
                        oAlreadyLockedRecords.Add(sDBID);
                        //objlogger.LogInfo("after Setting record as already locked" + sDBID);
                    }
                    else
                    {
                        objlogger.LogInfo("Entity was already locked " + sDBID, GlobalConstants.LOGGERLEVEL1);
                    }

                }
                else
                {
                    objlogger.LogInfo("Entity available without Lock " + sDBID, GlobalConstants.LOGGERLEVEL1);

                    if (!m_oLockedEntities.Keys.Contains(sDBID))
                    {
                        m_oLockedEntities.Add(sDBID, l_oEntity);
                    }
                }

                if (sID != string.Empty)
                {
                    if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
                    {
                        objlogger.LogInfo("add affected rec for Issue " + sID, GlobalConstants.LOGGERLEVEL1);
                        m_oAffectedRecords.Add(oNodeInfo.RONAME + ":" + sDomain, sID);
                    }
                    else
                    {
                        m_oAffectedRecords.Add(oNodeInfo.RONAME, sID);
                    }
                    objlogger.LogInfo("add affected rec for Issue-if part " + m_oAffectedRecords.ToString(), GlobalConstants.LOGGERLEVEL1);

                }
                else
                {
                    if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
                    {
                        objlogger.LogInfo("add affected rec for Issue " + sDBID, GlobalConstants.LOGGERLEVEL1);
                        m_oAffectedRecords.Add(oNodeInfo.RONAME + ":" + sDomain, sDBID);
                    }
                    else
                    {
                        m_oAffectedRecords.Add(oNodeInfo.RONAME, sDBID);
                    }
                    objlogger.LogInfo("add affected rec for Issue-else part " + m_oAffectedRecords.ToString(), GlobalConstants.LOGGERLEVEL1);

                }
            }

            return true;
        }


        public string GetModifiedFile()
        {
            PersistenceDataManager l_oDataManager = new PersistenceDataManager();
            return l_oDataManager.ReadData(PersistenceDataStores.ROISSUEIMF, OrcParms[OrcParameters.XCHANGEPROTOCOLID]);
        }

        private bool ProcessRecords(string sRecord, RODataInterface l_oReadInterface, RODataInterface l_oWriteInterface)
        {
            objlogger.LogInfo("ROExecutionEngine::ProcessRecords: Starts", GlobalConstants.LOGGERLEVEL1);
            bool bisValid = true;
            string sDBID = string.Empty;

            objlogger.LogInfo("sRecord: " + sRecord, GlobalConstants.LOGGERLEVEL1);
            //GetEvaluator Node configuration
            NodeInfo oConfig = GetNodeInfo(sRecord);
            //objlogger.LogInfo("sRecord after GetNodeInfo: " + sRecord);
            objlogger.LogInfo("nsIMFMgr: " + nsIMFMgr.ToString(), GlobalConstants.LOGGERLEVEL1);
            //objlogger.LogInfo("IssueExternalExchnageWF: " + IssueExternalExchnageWF);

            //GetEvaluator the Contacts from IMF
            IEnumerable<XElement> l_oRecords
                            = IssueIMF.Root.XPathSelectElements(oConfig.XPATH, nsIMFMgr);

            if (IssueExternalState.ToUpper() == GlobalConstants.ASAMFileTags.STATEREQUESTED)
            {
                if (IssueExternalExchnageWF.ToUpper() == IMFFileTags.HWWORKFLOW)
                {
                    if (sRecord == ConfigurationFileTags.ISSUE_RELEASE_MAPPINGS)
                    {
                        //objlogger.LogInfo("State Requested HWWORKFLOW -Calling ManageHW_IRMAPS");
                        ManageHW_IRMAPS(l_oRecords);
                    }
                }
                else
                {

                    if (sRecord == ConfigurationFileTags.ISSUE_RELEASE_MAPPINGS)
                    {
                        //objlogger.LogInfo("State Requested-Calling ManagePFAM_IRMAPS");
                        ManagePFAM_IRMAPS(l_oRecords);
                    }
                }
            }


            foreach (XElement oRecord in l_oRecords)
            {
                objlogger.LogInfo("Inside l_oRecords", GlobalConstants.LOGGERLEVEL1);
                QueryParameters l_oQueryParams = new QueryParameters();

                sDBID = oRecord.Element(GlobalConstants.DBID).Value;

                if (sDBID == string.Empty || sDBID == "0")
                {
                    bool binsertSuccess = InsertRecord(l_oWriteInterface, oRecord, sRecord, oConfig.RONAME);

                    if (!binsertSuccess) return false;
                }
                else
                {
                    bool bUpdateSuccess = UpdateRecord(l_oReadInterface, l_oWriteInterface,
                                            oRecord, sRecord, oConfig.RONAME, sDBID);

                    if (!bUpdateSuccess) return false;
                }
            }

            objlogger.LogInfo("ROExecutionEngine::ProcessRecords: Ends", GlobalConstants.LOGGERLEVEL1);
            return bisValid;
        }

        private bool InsertRecord(RODataInterface l_oWriteInterface, XElement oRecord, string sRecord,
                                string sEntity)
        {
            objlogger.LogInfo("InsertRecord : Starts() ", GlobalConstants.LOGGERLEVEL1);

            ActionTypes l_oAction;
            bool bInsert = true;

            //REUBK-1886 to check for record type attr
            if (oRecord.HasAttributes)
            {
                l_oAction = GetNodeAction(oRecord);

                objlogger.LogInfo("IsUpdateRequired:attr fo recordtype:" + l_oAction.ToString(), GlobalConstants.LOGGERLEVEL1);

                if (l_oAction == ActionTypes.Ignore)
                {
                    bInsert = false;
                }
            }

            if (bInsert)
            {

                QueryParameters l_oWriteParams = new QueryParameters();

                l_oWriteParams.Add(GlobalConstants.ENTITY, sEntity);

                //Add the default values if applicable --Not Reqd REUBK-1660
                //ManageDefaultValues(sRecord, l_oWriteParams, false);

                foreach (XElement oField in oRecord.Elements())
                {
                    if (IsAttachmentNode(oField))
                    {
                        ManageAttachments(l_oWriteParams, oField);
                    }
                    else
                    {
                        string sField = oField.Name.ToString().ToUpper();

                        if (sField != GlobalConstants.DBID && sField != GlobalConstants.ID
                            && !l_oWriteParams.GetRaw().ContainsKey(sField))
                        {
                            string sValues = FormatValues(oField);
                            objlogger.LogInfo("oField =" + oField.Name.ToString(), GlobalConstants.LOGGERLEVEL1);
                            if (sValues.Trim() != string.Empty)
                            {
                                objlogger.LogInfo("Considering " + oField.Name.ToString() + " for insertion", GlobalConstants.LOGGERLEVEL1);
                                l_oWriteParams.Add(oField.Name.ToString(), sValues.Trim());
                            }
                        }
                    }
                }
                IQueryResult oInsertResult = null;

                try
                {
                    string Entity = l_oWriteParams[GlobalConstants.ENTITY];
                    if(Entity.ToLower() == "contact")
                    {
                        RO_OSLC_DataInterface m_oDataInterface = new RO_OSLC_DataInterface(OrcParms[OrcParameters.SYSTEM], OrcParms[OrcParameters.EXCHANGEFORMAT], objlogger);
                        var param_data = l_oWriteParams.GetRaw();
                        string sQuery = "oslc_cm.query=eMail="+ '"' + param_data["EMAIL"]+ '"' + "&rcm.type=Contact";
                        IQueryResult record = m_oDataInterface.Query(sQuery);
                        if(record.RecordCount == 0)
                        {
                            WriteLog(l_oWriteParams, sEntity, "Insert");
                            oInsertResult = l_oWriteInterface.Insert(l_oWriteParams);
                        }
                        else
                        {
                            objlogger.LogInfo("Insert skipped with error -" + "User Already Exist.", GlobalConstants.LOGGERLEVEL1);
                            ROErrorLogger.RegisterUserError("Warning : Insert for " + sEntity + " skipped with error -" + "User Already Exist.", OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME], true, RulesFileTags.WARNING);
                            return true;
                        }
                    }
                    else
                    {
                        WriteLog(l_oWriteParams, sEntity, "Insert");
                        oInsertResult = l_oWriteInterface.Insert(l_oWriteParams);
                    }
                   
                   
                }
                catch (Exception e)
                {
                    objlogger.LogInfo("Insert failed with error -" + e.Message, GlobalConstants.LOGGERLEVEL1);
                    ROErrorLogger.RegisterUserError("Insert for " + sEntity + " failed with error -" + e.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                    throw e;
                }


                if (oInsertResult == null || !oInsertResult.QuerySuccess) return false;

                UpdateBackMaps(oInsertResult, oRecord);
                objlogger.LogInfo("InsertRecord : ends() ", GlobalConstants.LOGGERLEVEL1);
                return true;
            }
            else
            {
                objlogger.LogInfo("Insert action skipped as action type of record is Ignore", GlobalConstants.LOGGERLEVEL1);
                return true;
            }



        }

        private string FormatValues(XElement oField)
        {
            string sFinalValue = string.Empty;

            if (oField.Elements().Count() > 0)
            {
                foreach (XElement oVal in oField.Elements())
                {
                    if (oVal.HasElements)
                    {//recursion
                        sFinalValue = FormatValues(oVal);
                    }
                    else
                    {
                        sFinalValue = sFinalValue + System.Environment.NewLine + oVal.Value;
                    }
                }
            }
            else
            {
                sFinalValue = oField.Value;
            }
            return sFinalValue.Trim();
        }

        private bool IsAttachmentNode(XElement oField)
        {
            try
            {
                if (oField.Attribute(IMFFileTags.ATTR_TYPE).Value.ToUpper() == IMFFileTags.TYPEATTACHMENT)
                {
                    return true;
                }
            }
            catch { }
            return false;

        }

        private ActionTypes GetNodeAction(XElement oField)
        {
            ActionTypes l_oAction = ActionTypes.Overwrite;

            try
            {
                if (oField.Attribute(IMFFileTags.ATTR_ACTION).Value == IMFFileTags.ACTIONAPPEND)
                {
                    l_oAction = ActionTypes.Append;
                }
                else if (oField.Attribute(IMFFileTags.ATTR_ACTION).Value == IMFFileTags.ACTIONMERGE)
                {
                    l_oAction = ActionTypes.Merge;
                }
                else if (oField.Attribute(IMFFileTags.ATTR_ACTION).Value == IMFFileTags.ACTIONIGNORE)
                {
                    l_oAction = ActionTypes.Ignore;
                }
                else if (oField.Attribute(IMFFileTags.ATTR_ACTION).Value == IMFFileTags.ACTIONINIT)
                {
                    l_oAction = ActionTypes.Init;
                }
                else if (oField.Attribute(IMFFileTags.ATTR_ACTION).Value == IMFFileTags.ACTIONDELETE)
                {
                    l_oAction = ActionTypes.Delete;
                }
            }
            catch { }

            return l_oAction;

        }

        private void ManageDefaultValues(string sRecord, QueryParameters l_oWriteParams, bool bUpdate)
        {
            //REUBK-1660 (This method is not reqd as default values are handled in mapping, code not removed as it could be helpful in future)
            try
            {
                objlogger.LogInfo("ManageDefaultValues- Starts", GlobalConstants.LOGGERLEVEL1);



                var l_oDefaultValues
                    = oConfiguration.Root.Element(ConfigurationFileTags.REQUESTONE)
                                    .Element(sRecord)
                                    .Elements(ConfigurationFileTags.DEFAULT_FIELD_VALUES)
                                    .Elements(ConfigurationFileTags.DEFAULT_FIELD)
                                    .Select(n => new
                                    {
                                        FieldName = n.Element(ConfigurationFileTags.DEFAULT_FIELD_NAME).Value,
                                        Value = n.Element(ConfigurationFileTags.VALUE).Value
                                    });


                if (!bUpdate)
                {
                    foreach (var oDefaultValue in l_oDefaultValues)
                    {
                        //This is a runtime default
                        string sValue = string.Empty;
                        if (oDefaultValue.Value.Contains("#"))
                        {
                            string[] strArray = oDefaultValue.Value.Split('#');
                            string sKey = strArray[1];
                            // string sKey = oDefaultValue.Value.Replace("#","");

                            if (strArray[0] == string.Empty)
                            {
                                sValue = OrcParms[sKey.ToUpper()];
                            }
                            else
                            {
                                sValue = strArray[0] + OrcParms[sKey.ToUpper()];
                            }
                            l_oWriteParams.Add(oDefaultValue.FieldName.ToUpper(), sValue);

                        }
                        else
                        {
                            l_oWriteParams.Add(oDefaultValue.FieldName.ToUpper(), oDefaultValue.Value);
                        }
                    }
                }
                else
                {
                    foreach (var oDefaultValue in l_oDefaultValues)
                    {
                        if (l_oWriteParams.GetRaw().ContainsKey(oDefaultValue.FieldName.ToUpper()))
                            l_oWriteParams.Remove(oDefaultValue.FieldName.ToUpper());
                    }
                }
                objlogger.LogInfo("ManageDefaultValues- Ends", GlobalConstants.LOGGERLEVEL1);

            }
            catch (Exception ex)
            {
                objlogger.LogInfo("ManageDefaultValues- Exception" + ex.Message.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
        }


        private void ManageAttachments(QueryParameters l_oWriteParams, XElement oField)
        {
           // objlogger.LogInfo("ManageAttachments - Starts----0");
            try
            {
                //objlogger.LogInfo("ManageAttachments - Starts---1");

                objlogger.LogInfo("ManageAttachments starts-" + oField.Name.ToString(), GlobalConstants.LOGGERLEVEL1);
                string sfieldName = oField.Name.ToString();

                //objlogger.LogInfo("ManageAttachments - Starts----2");

                List<ExecROAttachment> l_oAttachments = new List<ExecROAttachment>();
                List<ExecROAttachment> l_oAttachmentsFinal = new List<ExecROAttachment>();
                //objlogger.LogInfo("ManageAttachments - Starts----3");

                objlogger.LogInfo("OrcParms ATTACHMENTPATH" + OrcParms[OrcParameters.ATTACHMENTPATH].ToString(), GlobalConstants.LOGGERLEVEL1);

                if (OrcParms[OrcParameters.ATTACHMENTPATH] == null || OrcParms[OrcParameters.ATTACHMENTPATH] == string.Empty)
                {
                    objlogger.LogInfo("ManageAttachments---1", GlobalConstants.LOGGERLEVEL1);
                    l_oAttachments
                        = oField.Elements(IMFFileTags.ATTACHMENT)
                            .Where(x => x.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value != string.Empty && x.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes == false)
                        .Select(n => new ExecROAttachment
                        {
                            NAME = oConfiguration.Root.Elements(ConfigurationFileTags.INTERFACE_SETTINGS)
                            .Elements(ConfigurationFileTags.ATTACHMENTS)
                                .Elements(ConfigurationFileTags.ATTACHMENTSLOCALPATH).Single().Value
                                + "\\" + n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                            DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,
                            FULLNAME = oConfiguration.Root.Elements(ConfigurationFileTags.INTERFACE_SETTINGS)
                           .Elements(ConfigurationFileTags.ATTACHMENTS)
                               .Elements(ConfigurationFileTags.ATTACHMENTSLOCALPATH).Single().Value
                               + "\\" + n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                            FILESIZE = n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value,
                            DESCCHANGEONLY = false,


                        })
                          .ToList<ExecROAttachment>();
                    l_oAttachmentsFinal.AddRange(l_oAttachments); //add att for upload

                    objlogger.LogInfo("ManageAttachments---2", GlobalConstants.LOGGERLEVEL1);

                    l_oAttachments
                       = oField.Elements(IMFFileTags.ATTACHMENT)
                           .Where(x => x.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value != string.Empty && x.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes == true)
                       .Select(n => new ExecROAttachment
                       {
                           NAME = oConfiguration.Root.Elements(ConfigurationFileTags.INTERFACE_SETTINGS)
                           .Elements(ConfigurationFileTags.ATTACHMENTS)
                               .Elements(ConfigurationFileTags.ATTACHMENTSLOCALPATH).Single().Value
                               + "\\" + n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                           DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,
                           FULLNAME = oConfiguration.Root.Elements(ConfigurationFileTags.INTERFACE_SETTINGS)
                          .Elements(ConfigurationFileTags.ATTACHMENTS)
                              .Elements(ConfigurationFileTags.ATTACHMENTSLOCALPATH).Single().Value
                              + "\\" + n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                           FILESIZE = n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value,
                           DESCCHANGEONLY = true,


                       })
                         .ToList<ExecROAttachment>();
                    l_oAttachmentsFinal.AddRange(l_oAttachments); //add att for desc change

                    objlogger.LogInfo("ManageAttachments---3", GlobalConstants.LOGGERLEVEL1);
                }
                else
                {
                    objlogger.LogInfo("ManageAttachments - att path not null", GlobalConstants.LOGGERLEVEL1);

                    //REUBK-773 
                    l_oAttachments
                       = oField.Elements(IMFFileTags.ATTACHMENT)
                       .Where(x => x.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value != string.Empty && x.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes == false)
                       .Select(n => new ExecROAttachment
                       {
                           NAME = n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                           FULLNAME = n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                           DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,
                           FILESIZE = n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value,
                           DESCCHANGEONLY = false,

                       })
                         .ToList<ExecROAttachment>();
                    objlogger.LogInfo("ManageAttachments - l_oAttachments for upload  count" + l_oAttachments.Count, GlobalConstants.LOGGERLEVEL1);

                    l_oAttachmentsFinal.AddRange(l_oAttachments); //add att for upload
                    objlogger.LogInfo("ManageAttachments - l_oAttachmentsFinal count" + l_oAttachmentsFinal.Count, GlobalConstants.LOGGERLEVEL1);

                    l_oAttachments
                     = oField.Elements(IMFFileTags.ATTACHMENT)
                     .Where(x => x.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value != string.Empty && x.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes == true)
                     .Select(n => new ExecROAttachment
                     {
                         NAME = n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                         FULLNAME = n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                         DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,
                         FILESIZE = n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value,
                         DESCCHANGEONLY = true,

                     })
                       .ToList<ExecROAttachment>();

                    objlogger.LogInfo("ManageAttachments - l_oAttachments for desc change" + l_oAttachments.Count, GlobalConstants.LOGGERLEVEL1);

                    l_oAttachmentsFinal.AddRange(l_oAttachments); //add att for desc change

                    objlogger.LogInfo("ManageAttachments - l_oAttachmentsFinal br grouping" + l_oAttachmentsFinal.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

                    //handled in writeinterface REUBK-2121
                    //foreach (ROAttachment oAttach in l_oAttachments)
                    //{
                    //    //OrcParms[OrcParameters.ATTACHMENTPATH] + "\\" +
                    //    string strNewFileName = oAttach.NAME;
                    //    objlogger.LogInfo("Attachments Name is " + strNewFileName);
                    //    string strExtension = Path.GetExtension(strNewFileName);
                    //    string strFileNameNoExtension = strNewFileName.Substring(0, (strNewFileName.Length - 4));
                    //    //file name along with extension cannot be > 50 characters
                    //    //if (strNewFileName.Length > 40)
                    //    //{ // rename file 
                    //    //    strNewFileName = Utilities.utf8Trunc(strNewFileName);
                    //    //    Utilities.objLogger.LogInfo("Attachments reNamed file is " + strNewFileName);
                    //    //}
                    //    //REUBK-1859
                    //   
                    //    objlogger.LogInfo("add to l_oAttachments");
                    //    oAttach.FULLPATH = OrcParms[sOrcParameters.ATTACHMENTPATH] + "\\" + strNewFileName;
                    //    oAttach.NAME = strNewFileName;
                    //}





                    //l_oAttachments = l_oAttachments.GroupBy(i => i.NAME,(key, group) => group.First()).ToList<ROAttachment>();                    

                    l_oAttachmentsFinal = l_oAttachmentsFinal.GroupBy(i => new { i.NAME, i.FILESIZE, i.DESCCHANGEONLY }, (key, group) => group.First()).ToList<ExecROAttachment>();
                    objlogger.LogInfo("ManageAttachments - group by DESCCHANGEONLY " + l_oAttachmentsFinal.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
                }
               // objlogger.LogInfo("ManageAttachments - l_oAttachments" + l_oAttachments.Count.ToString());
                l_oWriteParams.AddComplex(sfieldName.ToUpper(), l_oAttachmentsFinal);
                l_oWriteParams.Add(sfieldName.ToUpper(), "");
            }
            catch (Exception e)
            {
                objlogger.LogException(e, "Exception - Error parsing attachments" + e.Message);
            }

            objlogger.LogInfo("ManageAttachments - Ends", GlobalConstants.LOGGERLEVEL1);
        }

        private bool UpdateRecord(RODataInterface l_oReadInterface,
            RODataInterface l_oWriteInterface, XElement oRecord, string sRecord,
            string sEntity, string sDBID)
        {
            objlogger.LogInfo("UpdateRecord: Starts", GlobalConstants.LOGGERLEVEL1);
            bool bUpdateRequired = false;

            IOAdEntity l_oEntity = m_oLockedEntities[sDBID];

            QueryParameters l_oWriteParams = new QueryParameters();

            bUpdateRequired = IsUpdateRequired(oRecord, l_oEntity, l_oWriteParams);


            //ManageDefaultValues(sRecord, l_oWriteParams, true);            //-Not Reqd REUBK-1660
            objlogger.LogInfo("bUpdateRequired: " + bUpdateRequired.ToString(), GlobalConstants.LOGGERLEVEL1);
            if (bUpdateRequired)
            {
                l_oWriteParams.AddComplex(GlobalConstants.ENTITYOBJECT, l_oEntity);
                l_oWriteParams.Add(GlobalConstants.ENTITY, sEntity);
                WriteLog(l_oWriteParams, sEntity, "Update");

                IQueryResult l_oUpdateResult = null;

                try
                {
                    l_oUpdateResult = l_oWriteInterface.Update(l_oWriteParams);
                }
                catch (Exception e)
                {
                    objlogger.LogInfo("Update failed with error -" + e.Message, GlobalConstants.LOGGERLEVEL1);
                    ROErrorLogger.RegisterUserError("Update for " + sEntity + " failed with error -" + e.Message, OrcParms[OrcParameters.XCHANGEPROTOCOLID], OrcParms[OrcParameters.ISSUEFILENAME]);
                    throw e;
                }

                if (l_oUpdateResult == null ||
                    !l_oUpdateResult.QuerySuccess) return false;

                try
                {
                    UpdateBackMaps(l_oUpdateResult, oRecord);
                }
                catch (Exception e)
                {
                    objlogger.LogInfo("Error updating backmappings " + e.Message, GlobalConstants.LOGGERLEVEL1);
                }
            }
            else
            {
                CQAPI_QueryResult l_oQueryResult = new CQAPI_QueryResult();
                l_oQueryResult.SetRaw(l_oEntity);
                UpdateBackMaps(l_oQueryResult, oRecord);
            }
            objlogger.LogInfo("UpdateRecord: ends", GlobalConstants.LOGGERLEVEL1);
            return true;
        }

        private bool IsUpdateRequired(XElement oRecord, IOAdEntity l_oEntity, QueryParameters l_oWriteParams)
        {
            bool bUpdateRequired = false;
            ActionTypes l_oAction;

            //REUBK-1886 to check for record type attr

            bool bIsRecordTypeIgnore = false;

            if (oRecord.HasAttributes)
            {
                l_oAction = GetNodeAction(oRecord);

                objlogger.LogInfo("IsUpdateRequired:attr fo recordtype:" + l_oAction.ToString(), GlobalConstants.LOGGERLEVEL1);

                if (l_oAction == ActionTypes.Ignore)
                {
                    bIsRecordTypeIgnore = true;
                }
                else
                {
                    bIsRecordTypeIgnore = false;
                }
            }

            if (!(bIsRecordTypeIgnore))
            {
                foreach (IOAdFieldInfo oField in l_oEntity.GetAllFieldValues())
                {
                    try
                    {
                        //added for delay reduction
                        string sFieldName = oField.GetName().ToUpper();
  
                        string sIMFValue = oRecord.Element(sFieldName).Value;
                        XElement xIMFElement = oRecord.Element(sFieldName);
                        //objlogger.LogInfo("inside IsUpdateRequired: field=" + oRecord.Element(oField.GetName().ToUpper())+"value="+sIMFValue);
                        if (IsAttachmentNode(oRecord.Element(sFieldName)))
                        {
                            ManageAttachments(l_oWriteParams, oRecord.Element(sFieldName));
                            bUpdateRequired = true;
                        }
                        else
                        {
                            if (sFieldName != GlobalConstants.DBID
                                && sFieldName != GlobalConstants.ID
                                //&& oField.GetName().ToUpper() != GlobalConstants.OPERATIONMODE
                                //&& oField.GetName().ToUpper() != GlobalConstants.OPERATIONCONTEXT
                                && FormatValues(xIMFElement) != GetTrimmedValue(oField.GetValue())
                                && FormatValues(xIMFElement).Replace(System.Environment.NewLine, "\n") != GetTrimmedValue(oField.GetValue()).Replace("\r\n", "\n") //
                                && !l_oIgnoreList.Contains(sFieldName))
                            {
                                objlogger.LogInfo("oField=" + sFieldName, GlobalConstants.LOGGERLEVEL1);

                                //TEST
                               /* if (sFieldName == "OPERATIONMODE" || sFieldName == "OPERATIONCONTEXT")
                                {
                                    objlogger.LogInfo("FormatValues(xIMFElement):" + FormatValues(xIMFElement));
                                    objlogger.LogInfo("GetTrimmedValue(oField.GetValue()):" + GetTrimmedValue(oField.GetValue()));
                                }*/


                                if (sIMFValue.Trim() != string.Empty || isActionDelete(oRecord, sFieldName))
                                {
                                    objlogger.LogInfo("imf value not empty or action is delete", GlobalConstants.LOGGERLEVEL1);
                                    sIMFValue = FormatValues(xIMFElement);

                                    l_oAction = GetNodeAction(oRecord.Element(sFieldName));

                                    //REUBK-1858
                                    if (!((l_oAction == ActionTypes.Init) || (l_oAction == ActionTypes.Ignore)))
                                    {
                                        //objlogger.LogInfo("add to writeparams" + oField.GetName().ToUpper() + "--"+ sIMFValue);
                                        l_oWriteParams.Add(sFieldName, sIMFValue, l_oAction);
                                        if (sFieldName != GlobalConstants.OPERATIONMODE && sFieldName != GlobalConstants.OPERATIONCONTEXT)
                                        {
                                            bUpdateRequired = true;
                                        }
                                    }
                                }
                            }
                            else if (sFieldName == GlobalConstants.DBID
                                || sFieldName == GlobalConstants.ID)
                            {
                                //objlogger.LogInfo("add to writeparams" + oField.GetName().ToUpper() + "--" + oField.GetValue().Trim());
                                l_oWriteParams.Add(sFieldName, oField.GetValue().Trim());
                            }
                        }
                    }
                    catch
                    { //just ignore
                    }


                }
            }
            return bUpdateRequired;
        }

        public bool isActionDelete(XElement oRecord, string fieldName)
        {
            bool bReturn = false;
            objlogger.LogInfo("inside isActionDelete--" + fieldName, GlobalConstants.LOGGERLEVEL1);
            if (oRecord.Element(fieldName).HasAttributes)
            {
               // objlogger.LogInfo("inside isActionDelete- attribute present");
                if (GetNodeAction(oRecord.Element(fieldName)) == ActionTypes.Delete)
                {
                   // objlogger.LogInfo("inside isActionDelete- attribute ACTIONDELETE present");
                    bReturn = true;                    
                }
            }
            objlogger.LogInfo("inside isActionDelete-bReturn" + bReturn.ToString(), GlobalConstants.LOGGERLEVEL1);
            return bReturn;

        }

        private void WriteLog(QueryParameters l_oParms, string sEntity, string sOperation)
        {
            try
            {
                string s = string.Format("Tyring to {0} {1} with values", sOperation, sEntity);
                objlogger.LogInfo(s, GlobalConstants.LOGGERLEVEL1);
                objlogger.LogInfo(l_oParms.ToString(), GlobalConstants.LOGGERLEVEL1);

            }
            catch { }
        }

        private string GetTrimmedValue(string oValue)
        {
            if (oValue != null)
            {
                return oValue.Trim();
            }
            else
            {
                return string.Empty;
            }

        }

        private NodeInfo GetNodeInfo(string sMainConfigurationTag)
        {
            objlogger.LogInfo("GetNodeInfo : Starts", GlobalConstants.LOGGERLEVEL1);
            try
            {
                //objlogger.LogInfo("Getting XPATH value from configuration xml");
                //Process contacts
                NodeInfo l_oNode = oConfiguration.Root
                               .Element(ConfigurationFileTags.REQUESTONE)
                               .Elements(sMainConfigurationTag)
                               .Select(n => new NodeInfo
                                           {
                                               RONAME = n.Element(ConfigurationFileTags.RONAME).Value,
                                               XPATH = n.Element(ConfigurationFileTags.XPATH).Value,
                                           }).SingleOrDefault();
                objlogger.LogInfo(l_oNode.XPATH, GlobalConstants.LOGGERLEVEL2);
               // objlogger.LogInfo("GetNodeInfo : Ends");
                return l_oNode;
            }
            catch (Exception e)
            {
                string s = string.Format("Error reading {0} information from configuration file, Exception {1}"
                    , sMainConfigurationTag, e.StackTrace);
                objlogger.LogInfo(s, GlobalConstants.LOGGERLEVEL1);
            }
            objlogger.LogInfo("GetNodeInfo : Ends", GlobalConstants.LOGGERLEVEL1);
            return null;
        }

        private void UpdateBackMaps(IQueryResult l_oQueryResult, XElement oRecord)
        {
            objlogger.LogInfo("UpdateBackMaps: Starts() for" + oRecord.Name.ToString(), GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo(oRecord.ToString(), GlobalConstants.LOGGERLEVEL1);
            string sDBID = l_oQueryResult.FieldValues[GlobalConstants.DBID.ToLower()];
            objlogger.LogInfo("sDBID: " + sDBID, GlobalConstants.LOGGERLEVEL1);
            string sIDRef = string.Empty;
            string sID = string.Empty;
            string sDomain = string.Empty;

            //objlogger.LogInfo("Getting Entity Name");
            string sElementName = oRecord.Name.ToString();
            //objlogger.LogInfo("Entity Name = " + sElementName);
            NodeInfo oNodeInfo = GetNodeInfo(sElementName);

            if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
            {
                sDomain = oRecord.Element(GlobalConstants.DOMAIN).Value;
            }

            try
            {
                sID = l_oQueryResult.FieldValues[GlobalConstants.ID.ToLower()];
                objlogger.LogInfo("sID : " + sID, GlobalConstants.LOGGERLEVEL1);
                oRecord.Element(GlobalConstants.ID).Value = sID;
            }
            catch (Exception ex)
            {
                //Do not log this error
                // objlogger.LogException(ex, "UpdateBackMaps()- Exception while getting ID value");
            }

            try
            {
                sIDRef = oRecord.Attribute(GlobalConstants.ID).Value;
                objlogger.LogInfo("sIDRef : " + sIDRef, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                //Do not log this error
                //objlogger.LogException(ex, "UpdateBackMaps()- Exception while getting IDREF value");
            }

            oRecord.Element(GlobalConstants.DBID).Value = sDBID;

            if (!m_oLockedEntities.Keys.Contains(sDBID))
            {
                m_oLockedEntities.Add(sDBID, l_oQueryResult.GetRaw() as IOAdEntity);
            }

            //Update the latest IDs in IMF
            if (sIDRef != string.Empty)
            {

                IEnumerable<XElement> l_oMappableIssue
                    = IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE)
                    .Elements(IMFFileTags.ISSUE).Elements();

                foreach (XElement oElement in l_oMappableIssue)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {   //Do not log this error
                        //objlogger.LogException(ex, "UpdateBackMaps()- Exception while setting backref values in Issues");
                    }
                }

                IEnumerable<XElement> l_oMappableRelease
               = IssueIMF.Root.Elements(IMFFileTags.RT_RELEASES)
               .Elements(IMFFileTags.RELEASE).Elements();

                foreach (XElement oElement in l_oMappableRelease)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {//Do not log this error
                        //objlogger.LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

                IEnumerable<XElement> l_oMappableReleaseMap
                 = IssueIMF.Root.Elements(IMFFileTags.RT_IRMAPS)
                 .Elements(IMFFileTags.IRMAP).Elements();

                foreach (XElement oElement in l_oMappableReleaseMap)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {//Do not log this error
                        //objlogger.LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

                IEnumerable<XElement> l_oCommercial
                = IssueIMF.Root.Elements(IMFFileTags.RT_COMMERCIALS)
                .Elements(IMFFileTags.COMMERCIAL).Elements();

                foreach (XElement oElement in l_oCommercial)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Do not log this error
                        //objlogger.LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

            }

            //Just update the affected objects for final display
            if (sID != string.Empty)
            {
                if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
                {
                    objlogger.LogInfo("add affected rec for Issue if part" + sID, GlobalConstants.LOGGERLEVEL1);
                    m_oAffectedRecords.Add(oNodeInfo.RONAME + "(" + sDomain + ")", sID);
                }
                else
                {
                    m_oAffectedRecords.Add(oNodeInfo.RONAME, sID);
                }
                objlogger.LogInfo("add affected rec for Issue if part " + m_oAffectedRecords.ToString(), GlobalConstants.LOGGERLEVEL1);
            }
            else
            {
                if (oNodeInfo.RONAME.ToUpper() == GlobalConstants.ASAMFileTags.ISSUE)
                {
                    objlogger.LogInfo("add affected rec for Issue else part " + sID, GlobalConstants.LOGGERLEVEL1);
                    m_oAffectedRecords.Add(oNodeInfo.RONAME + "(" + sDomain + ")", sDBID);
                }
                else
                {
                    m_oAffectedRecords.Add(oNodeInfo.RONAME, sDBID);
                }
                objlogger.LogInfo("add affected rec for Issue else part" + m_oAffectedRecords.ToString(), GlobalConstants.LOGGERLEVEL1);
            }

            objlogger.LogInfo("UpdateBackMaps: ends() ", GlobalConstants.LOGGERLEVEL1);
        }

        #region HWIRMHandling

        private void ManageHW_IRMAPS(IEnumerable<XElement> xIRMaps)
        {
            objlogger.LogInfo("Starting ManageHW_IRMAPS", GlobalConstants.LOGGERLEVEL1);
            foreach (XElement xIRMap in xIRMaps)
            {
                string sHasMappedRelease = xIRMap.Element(IMFFileTags.IR_HASMAPPEDRELEASE).Value;

                IEnumerable<XElement> l_oDuplicate = xIRMaps
                                                    .Where(n => n.Element(IMFFileTags.IR_HASMAPPEDRELEASE).Value == sHasMappedRelease)
                                                    .Select(n => n);

                List<XElement> lstmappingElements = new List<XElement>();

                objlogger.LogInfo("ManageHW_IRMAPS:l_oDuplicate count=" + l_oDuplicate.Count().ToString(), GlobalConstants.LOGGERLEVEL1);

                if (l_oDuplicate.Count() > 1)
                {
                    foreach (XElement xIRM in l_oDuplicate)
                    {
                        XElement oxMElement = new XElement("P");

                        string sTemp = xIRM.Element(IMFFileTags.IR_MAPPINGTODERIVATES).Element("P").Value;
                        oxMElement.Value = sTemp;

                        lstmappingElements.Add(oxMElement);
                    }

                    xIRMap.Element(IMFFileTags.IR_MAPPINGTODERIVATES).Elements().Remove();

                    foreach (XElement element in lstmappingElements)
                    {
                        xIRMap.Element(IMFFileTags.IR_MAPPINGTODERIVATES).Add(element);
                    }

                    l_oDuplicate.Where(n => n != xIRMap).Remove();

                }
            }
            objlogger.LogInfo("End ManageHW_IRMAPS", GlobalConstants.LOGGERLEVEL1);
        }
        #endregion
        #region PFAMHAndling

        private void ManagePFAM_IRMAPS(IEnumerable<XElement> xIRMaps)
        {
            objlogger.LogInfo("Starting manage IRMAPS",GlobalConstants.LOGGERLEVEL1);
            foreach (XElement xIRMap in xIRMaps)
            {
                //objlogger.LogInfo("Getting Hasmapped Issue");
                string sHasMappedIssue = xIRMap.Element(IMFFileTags.IR_HASMAPPEDISSUE).Value;
                objlogger.LogInfo("Hasmapped Issue = " + sHasMappedIssue, GlobalConstants.LOGGERLEVEL1);

               // objlogger.LogInfo("Getting Hasmapped Release");


                string sHasMappedRelease = xIRMap.Element(IMFFileTags.IR_HASMAPPEDRELEASE).Value;
                objlogger.LogInfo("Hasmapped Release = " + sHasMappedRelease, GlobalConstants.LOGGERLEVEL1);

                //method to  get project PFAM dbid:
                string spjtDBID = GetPFAMProject(sHasMappedRelease);

                objlogger.LogInfo("Getting duplicate IRMAPS", GlobalConstants.LOGGERLEVEL1);
                IEnumerable<XElement> l_oDuplicate = xIRMaps
                                                    .Where(n => n.Element(IMFFileTags.IR_HASMAPPEDRELEASE).Value == sHasMappedRelease
                                                            && n.Element(IMFFileTags.IR_HASMAPPEDISSUE).Value == sHasMappedIssue)
                                                    .Select(n => n);

                objlogger.LogInfo("Number of duplicates = " + l_oDuplicate.Count().ToString(), GlobalConstants.LOGGERLEVEL1);

                //proceed irrespective of pjt id null
                if (l_oDuplicate.Count() > 1)
                {
                    //Update current node for combination
                    //Adding new tag pending
                    string sMTags = string.Empty;
                    string sPtags = string.Empty;

                    XElement xDerivate = new XElement(IMFFileTags.IR_MAPPINGTODERIVATES);

                    //Checking is Pilot
                    objlogger.LogInfo("Checking IsPilot", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> l_oIsPilotYes = l_oDuplicate.Where(n => n.Element(IMFFileTags.IR_ISPILOT).Value == "Yes");
                    objlogger.LogInfo("Count for Ispilot=yes:" + l_oIsPilotYes.Count().ToString(), GlobalConstants.LOGGERLEVEL1);

                    //below lines are commented, xIRMap - ispilot should be set only after [P] tags formation, else l_oIsPilotYes count will increase
                    //if (l_oIsPilotYes.Count() > 0)
                    //{
                    //    objlogger.LogInfo("Updating Pilot to Yes");
                    //    xIRMap.Element(IMFFileTags.IR_ISPILOT).Value = "Yes";
                    //}                    
                    //objlogger.LogInfo("Forming P tags");
                    objlogger.LogInfo("Forming P tags: loop Count for Ispilot=yes:" + l_oIsPilotYes.Count().ToString(), GlobalConstants.LOGGERLEVEL2);
                    foreach (XElement xPilotYes in l_oIsPilotYes)
                    {
                        try
                        {
                            objlogger.LogInfo("loop pilot = y", GlobalConstants.LOGGERLEVEL2);
                            string sTemp = xPilotYes.Element(IMFFileTags.IR_EXTERNALTAGS).Element(IMFFileTags.IR_EXTERNALTAG).Value;
                            XElement oxMElement = new XElement("P");
                            sTemp = sTemp.Replace("<P>", "");
                            string[] arrSchene = sTemp.Split(':');
                            string arrScheneInternal = string.Empty;
                            //call func to get newly modified arr sciene value by pass arrsch,pjt dbid)
                            if (!(string.IsNullOrEmpty(spjtDBID)))
                            {
                                arrScheneInternal = GetProjectInternalDesc(spjtDBID, arrSchene[0]);
                                oxMElement.Value = "[P] " + arrScheneInternal; //REUBK-1034
                                xDerivate.Add(oxMElement);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch { }
                    }
                    //objlogger.LogInfo("P tags are done ");
                    objlogger.LogInfo("xDerivate tags Value " + xDerivate.Value, GlobalConstants.LOGGERLEVEL1);
                    if (l_oIsPilotYes.Count() > 0)
                    {
                        //objlogger.LogInfo("Updating Pilot to Yes");
                        xIRMap.Element(IMFFileTags.IR_ISPILOT).Value = "Yes";
                    }

                    //objlogger.LogInfo("Forming M tags");
                    IEnumerable<XElement> l_oIsPilotNo = l_oDuplicate.Where(n => n.Element(IMFFileTags.IR_ISPILOT).Value != "Yes");
                    objlogger.LogInfo("Forming M tags: Count for Ispilot=no:" + l_oIsPilotNo.Count().ToString(), GlobalConstants.LOGGERLEVEL2);

                    foreach (XElement xPilotNo in l_oIsPilotNo)
                    {
                        try
                        {
                            objlogger.LogInfo("loop pilot = n", GlobalConstants.LOGGERLEVEL2);
                            string sTemp = xPilotNo.Element(IMFFileTags.IR_EXTERNALTAGS).Element(IMFFileTags.IR_EXTERNALTAG).Value;
                            XElement oxMElement = new XElement("P");
                            sTemp = sTemp.Replace("<P>", "");
                            string[] arrSchene = sTemp.Split(':');
                            string arrScheneInternal = string.Empty;
                            if (!(string.IsNullOrEmpty(spjtDBID)))
                            {
                                arrScheneInternal = GetProjectInternalDesc(spjtDBID, arrSchene[0]);
                                oxMElement.Value = "[M] " + arrScheneInternal; //REUBK-1034
                                xDerivate.Add(oxMElement);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch { }
                    }
                   // objlogger.LogInfo("M tags are done ");
                    objlogger.LogInfo("xDerivate tags Value " + xDerivate.Value, GlobalConstants.LOGGERLEVEL1);

                    xIRMap.Add(xDerivate);

                    //External Tags
                    objlogger.LogInfo("Combining External tags", GlobalConstants.LOGGERLEVEL1);
                    IEnumerable<XElement> l_oExternalTags = l_oDuplicate.Elements(IMFFileTags.IR_EXTERNALTAGS)
                                                        .Elements(IMFFileTags.IR_EXTERNALTAG);
                    objlogger.LogInfo("External tags count" + l_oExternalTags.Count(), GlobalConstants.LOGGERLEVEL1);
                    string sExternalTags = string.Empty;

                    List<XElement> lstExternalTag = new List<XElement>();

                    foreach (XElement l_oExternal in l_oExternalTags)
                    {
                        if (l_oExternal.Elements().Count() > 0)
                        {
                            foreach (XElement oxSub in l_oExternal.Elements())
                            {
                                XElement oxMElement = new XElement("P");
                                if (oxSub.Value.Trim() != string.Empty)
                                {
                                    oxMElement.Value = oxSub.Value;
                                    lstExternalTag.Add(oxMElement);
                                }
                            }

                        }
                        else
                        {
                            XElement oxMElement = new XElement("P");
                            if (l_oExternal.Value.Trim() != string.Empty)
                            {
                                oxMElement.Value = l_oExternal.Value;
                                lstExternalTag.Add(oxMElement);
                            }
                        }
                    }

                    xIRMap.Element(IMFFileTags.IR_EXTERNALTAGS)
                              .Element(IMFFileTags.IR_EXTERNALTAG).Elements().Remove();

                    foreach (XElement element in lstExternalTag)
                    {
                        xIRMap.Element(IMFFileTags.IR_EXTERNALTAGS)
                              .Element(IMFFileTags.IR_EXTERNALTAG).Add(element);
                    }

                    objlogger.LogInfo("External tags Value " + xIRMap.Element(IMFFileTags.IR_EXTERNALTAGS).Element(IMFFileTags.IR_EXTERNALTAG).Value, GlobalConstants.LOGGERLEVEL1);

                    //External Coversation
                    //objlogger.LogInfo("Combining External Conversation");
                    IEnumerable<XElement> l_oExternalCoversation = l_oDuplicate.Elements(IMFFileTags.IR_EXTERNALCONVERSATION);

                    objlogger.LogInfo("External Conversation count" + l_oExternalCoversation.Count(), GlobalConstants.LOGGERLEVEL1);
                    string sExternalCoversation = string.Empty;

                    List<XElement> lstExternalCoversation = new List<XElement>();

                    foreach (XElement l_oExternal in l_oExternalCoversation)
                    {
                        if (l_oExternal.Elements().Count() > 0)
                        {
                            foreach (XElement oxSub in l_oExternal.Elements())
                            {
                                XElement oxMElement = new XElement("P");
                                if (oxSub.Value.Trim() != string.Empty)
                                {
                                    oxMElement.Value = oxSub.Value;
                                    lstExternalCoversation.Add(oxMElement);
                                }
                            }
                        }
                        else
                        {
                            XElement oxMElement = new XElement("P");
                            if (l_oExternal.Value.Trim() != string.Empty)
                            {
                                oxMElement.Value = l_oExternal.Value;
                                lstExternalCoversation.Add(oxMElement);
                            }
                        }
                    }
                    xIRMap.Element(IMFFileTags.IR_EXTERNALCONVERSATION).Elements().Remove();
                    foreach (XElement element in lstExternalCoversation)
                    {
                        xIRMap.Element(IMFFileTags.IR_EXTERNALCONVERSATION).Add(element);
                    }


                    objlogger.LogInfo("Removing Duplicates ", GlobalConstants.LOGGERLEVEL1);
                    l_oDuplicate.Where(n => n != xIRMap).Remove();

                }
                else
                {

                    if (!(string.IsNullOrEmpty(spjtDBID)))
                    {
                        //do mappingtoderivatives
                        string sMTags = string.Empty;
                        string sPtags = string.Empty;
                        XElement xDerivate = new XElement(IMFFileTags.IR_MAPPINGTODERIVATES);

                        //Checking is Pilot
                        objlogger.LogInfo("Checking IsPilot", GlobalConstants.LOGGERLEVEL1);

                        //one ome irmap.. xirmap, check if pilot yes

                        if (xIRMap.Element(IMFFileTags.IR_ISPILOT).Value.ToLower() == "yes")
                        {
                            try
                            {
                                string sTemp = xIRMap.Element(IMFFileTags.IR_EXTERNALTAGS).Element(IMFFileTags.IR_EXTERNALTAG).Value;
                                XElement oxMElement = new XElement("P");
                                sTemp = sTemp.Replace("<P>", "");
                                string[] arrSchene = sTemp.Split(':');
                                //call func to get newly modified arr sciene value by pass arrsch,pjt dbid)
                                string arrScheneInternal = string.Empty;

                                arrScheneInternal = GetProjectInternalDesc(spjtDBID, arrSchene[0]);
                                oxMElement.Value = "[P] " + arrScheneInternal; //REUBK-1034
                                xDerivate.Add(oxMElement);

                            }
                            catch { }
                        }
                        objlogger.LogInfo("M tags are done, Forming P tags", GlobalConstants.LOGGERLEVEL2);

                        //objlogger.LogInfo("Forming P tags");
                        if (xIRMap.Element(IMFFileTags.IR_ISPILOT).Value.ToLower() != "yes")
                        {
                            try
                            {
                                string sTemp = xIRMap.Element(IMFFileTags.IR_EXTERNALTAGS).Element(IMFFileTags.IR_EXTERNALTAG).Value;
                                XElement oxMElement = new XElement("P");
                                sTemp = sTemp.Replace("<P>", "");
                                string[] arrSchene = sTemp.Split(':');
                                //call func to get newly modified arr sciene value by pass arrsch,pjt dbid)
                                string arrScheneInternal = string.Empty;

                                arrScheneInternal = GetProjectInternalDesc(spjtDBID, arrSchene[0]);
                                oxMElement.Value = "[M] " + arrScheneInternal; //REUBK-1034
                                xDerivate.Add(oxMElement);
                            }
                            catch { }
                        }
                        objlogger.LogInfo("P tags are done", GlobalConstants.LOGGERLEVEL2);
                        xIRMap.Add(xDerivate);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }


        private string GetPFAMProject(string sRelease)
        {
            objlogger.LogInfo("Inside GetPFAMProject", GlobalConstants.LOGGERLEVEL1);
            string PjtDBID = string.Empty;
            bool PFAMRELEASE = false;
            XElement l_oRelease = null;

            IEnumerable<XElement> l_oReleases = IssueIMF.Root.Elements(IMFFileTags.RT_RELEASES).Elements(IMFFileTags.RELEASE)
                                                .Where(n => n.Element(GlobalConstants.ID).Value == sRelease)
                                                .Select(n => n);

            foreach (XElement oxRelease in l_oReleases)
            {
                l_oRelease = oxRelease;
                break;
            }

            if (l_oRelease != null)
            {
                //objlogger.LogInfo("release not null");
                string sDescriptionROValue = string.Empty;
                objlogger.LogInfo("release DBID" + l_oRelease.Element(GlobalConstants.DBID).Value, GlobalConstants.LOGGERLEVEL1);
                XElement l_oProject = null;
                if (!(string.IsNullOrEmpty(l_oRelease.Element(GlobalConstants.DBID).Value)))
                {
                    IEnumerable<XElement> l_oProjects = IssueIMF.Root.Elements(IMFFileTags.RT_PROJECTS).Elements(IMFFileTags.PROJECT)
                                                  .Where(n => n.Element(GlobalConstants.ID).Value == l_oRelease.Element(IMFFileTags.RELEASE_BELONGSTOPROJECT).Value
                                                      && n.Element(IMFFileTags.EXTERNALID).Value == string.Empty)
                                                      .Select(n => n);
                    foreach (XElement oxProject in l_oProjects)
                    {
                        l_oProject = oxProject;
                        break;
                    }
                    if (l_oProject != null)
                    {
                        objlogger.LogInfo("get entity obj", GlobalConstants.LOGGERLEVEL1);
                        IOAdEntity l_oEntity = m_oLockedEntities[l_oRelease.Element(GlobalConstants.DBID).Value];

                        objlogger.LogInfo("got entity obj", GlobalConstants.LOGGERLEVEL1);
                        if (l_oEntity != null)
                        {
                            foreach (IOAdFieldInfo oField in l_oEntity.GetAllFieldValues())
                            {
                                if ((oField.GetName().ToUpper() == GlobalConstants.RELEASETYPE))
                                {
                                    if (oField.GetValue().ToUpper() == GlobalConstants.PFAMRELEASETYPE)
                                    {
                                        objlogger.LogInfo("Release type = pvar/pfam", GlobalConstants.LOGGERLEVEL1);
                                        PFAMRELEASE = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (PFAMRELEASE == true)
                        {
                            objlogger.LogInfo("PFAM project found", GlobalConstants.LOGGERLEVEL1);
                            PjtDBID = l_oProject.Element(GlobalConstants.DBID).Value;
                        }
                    }
                }
            }

            return PjtDBID;
        }
        private string GetProjectInternalDesc(string DBID, string Description)
        {
            objlogger.LogInfo("Inside GetProjectInternalDesc-- DBID:" + DBID + "Desc:" + Description, GlobalConstants.LOGGERLEVEL1);
            //get ext desc with dbid and with desc
            Dictionary<string, string> oValues = new Dictionary<string, string>();
            string sInternalROValue = string.Empty;
            string sDescriptionROValue = string.Empty;
            IOAdEntity l_oEntity = m_oLockedEntities[DBID];
            l_oEntity.GetAllFieldValues();
            foreach (IOAdFieldInfo oField in l_oEntity.GetAllFieldValues())
            {
                if ((oField.GetName().ToUpper() == GlobalConstants.EXTERNALDESCRIPTION) && (oField.GetValue().Contains(Description)))
                {
                    //added for delay reduction
                    string sFieldValue = oField.GetValue();
                    objlogger.LogInfo("ro desc value:" + sFieldValue.ToString(), GlobalConstants.LOGGERLEVEL1);
                    oValues = Utilities.GetProjectInternalValue(sFieldValue.Trim(), Description);//match string befoer "="

                    objlogger.LogInfo("oValues[OrcPFAM.DESCRIPTION]:" + oValues[OrcPFAM.DESCRIPTION].ToString(), GlobalConstants.LOGGERLEVEL2);
                    objlogger.LogInfo("oValues[OrcPFAM.INTERNALVALUE]:" + oValues[OrcPFAM.INTERNALVALUE].ToString(), GlobalConstants.LOGGERLEVEL2);

                    if (Description.Trim() == oValues[OrcPFAM.DESCRIPTION].ToString())
                    {
                        sInternalROValue = oValues[OrcPFAM.INTERNALVALUE].ToString();
                        objlogger.LogInfo("sInternalROValue:" + sInternalROValue, GlobalConstants.LOGGERLEVEL2);

                        break;
                    }
                }
            }

            return sInternalROValue;
        }


        #endregion
    }
}
