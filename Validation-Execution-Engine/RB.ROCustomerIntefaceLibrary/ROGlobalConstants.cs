using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;

namespace RB.ROCustomerIntefaceLibrary
{

    public struct OrcParameters
    {
        public const string BELONGSTOPROJECT = "BELONGSTOPROJECT";
        public const string XCHANGEPROTOCOLID = "XCHANGEPROTOCOLID";
        public const string ATTACHMENTPATH = "ATTACHMENTPATH";
        public const string BELONGSTOPOOLPROJECT = "BELONGSTOPOOLPROJECT";//added for Release mapping changes
        public const string ISSUEFILENAME = "ISSUEFILENAME";
        public const string EXCHANGEFORMAT = "EXCHANGEFORMAT";
        public const string CONFIGURATIONFILE = "CONFIGURATIONFILE";
        public const string SYSTEM = "SYSTEM";
        public const string INITIALLIFETOKEN = "INITIALLIFETOKEN";

        public const string FIRSTFILE = "FIRSTFILE";
        public const string LASTFILE = "LASTFILE";
        public const string ISSUEFILENAMES = "ISSUEFILENAMES";


    }



    public struct OrcLogger
    {
        public const string LOGGER = "LOGGER";
    }


    public struct OrcPFAM
    {
        public const string INTERNALVALUE = "INTERNALVALUE";
        public const string DESCRIPTION = "DESCRIPTION";
    }

    public struct ROAttachmentTags
    {
        public const string ENTRY = "entry";
        public const string CONTENT = "content";
        public const string ISSUE = "Issue";
        public const string ATTACHMENTS = "Attachments";
        public const string ROFILENAME = "filename";
        public const string RODESCRIPTION = "description";
        public const string ROFILESIZE = "filesize";
    }

    public struct IMFFileTags
    {
        public const string ROOT_NODE = "ASAMISSUE_EXTRACT";
        public const string RT_VALEXCONTROLINFO = "RT_VALEX_CONTROLINFO";
        public const string VALEXCONTROLINFO = "VALEX_CONTROLINFO";
        public const string RT_ISSUE = "RT_ISSUES";
        public const string ISSUE = "ISSUE";
        public const string RT_IRMAPS = "RT_IRMAPS";
        public const string RT_RELEASES = "RT_RELEASES";
        public const string RT_PROJECTS = "RT_PROJECTS";
        public const string RELEASE_BELONGSTOPROJECT = "BELONGSTOPROJECT";
        public const string RT_COMMERCIALS = "RT_COMMERCIALS";
        public const string EXTERNALID = "EXTERNAL_ID";
        public const string STATE = "STATE";
        public const string OEMEXTERNALSTATE = "OEMEXTERNALSTATE";
        public const string ISSUE_TYPE = "TYPE";
        public const string ISSUE_DOMAIN = "DOMAIN";
        public const string ISSUE_SCOPE = "SCOPE";
        public const string ISSUE_BELONGSTOPROJECT = "BELONGSTOPROJECT";
        public const string PROJECT_BELONGSTOPOOLPROJECT = "BELONGSTOPOOLPROJECT";
        public const string ID_REF = "ID-REF";
        public const string ID = "ID";
        public const string DBID = "DBID";
        public const string DESCRIPTION = "DESCRIPTION";
        public const string EXTERNALEXCHANGEDATTACH = "EXTERNALEXCHANGEDATTACH";
        public const string ATTACHEMENTS = "ATTACHMENTS";
        public const string ATTACHMENT = "ATTACHMENT";
        /*public const string PATH = "PATH";
        public const string LABEL = "LABEL";
        public const string CONTENT = "CONTENT";*/
        public const string ATTACHMENT_NAME = "NAME";
        public const string ATTACHMENT_DESCRIPTION = "DESCRIPTION";
        public const string ATTACHMENT_FULLNAME = "FULL_NAME";
        public const string ATTACHMENT_FILESIZE = "SIZE";
        public const string ATTR_TYPE = "TYPE";
        public const string TYPEATTACHMENT = "ATTACHMENT";
        public const string ATTR_FIELDNAME = "FIELDNAME";
        public const string RELEASE = "RELEASE";
        public const string PROJECT = "PROJECT";
        public const string COMMERCIAL = "COMMERCIAL";
        public const string IRMAP = "IRMAP";
        public const string ATTR_ACTION = "ACTION";
        public const string ACTIONAPPEND = "APPEND";
        public const string ACTIONMERGE = "MERGE";
        public const string ACTIONIGNORE = "IGNORE";
        public const string ACTIONDELETE = "DELETE";
        public const string ACTIONINIT = "INIT"; //REUBK-1660
        public const string EXTERNALHISTORY = "EXTERNALHISTORY";
        public const string EXTERNALDESCRIPTION = "EXTERNALDESCRIPTION";
        public const string EXTERNALORGANISATION = "EXTERNALORGANISATION";
        public const string IR_HASMAPPEDISSUE = "HASMAPPEDISSUE";
        public const string IR_HASMAPPEDRELEASE = "HASMAPPEDRELEASE";
        public const string IR_ISPILOT = "ISPILOT";
        public const string IR_EXTERNALNEXTSTATE = "EXTERNALNEXTSTATE";
        public const string IR_EXTERNALTAGS = "EXTERNALTAGS";
        public const string IR_EXTERNALTAG = "EXTERNALTAG";
        public const string IR_EXTERNALEXCHANGEWORKFLOW = "EXTERNALEXCHANGEWORKFLOW";
        public const string IR_EXTERNALREVIEW = "EXTERNALREVIEW";
        public const string IR_EXTERNAL_ID = "EXTERNAL_ID";
        public const string IR_EXTERNALTITLE = "EXTERNALTITLE";
        public const string IR_EXTERNALSTATE_PARALLEL1 = "EXTERNALSTATE_PARALLEL1";
        public const string IR_EXTERNALCONVERSATION = "EXTERNALCONVERSATION";
        public const string IR_MAPPINGTODERIVATES = "MAPPINGTODERIVATIVES";
        public const string IR_LIFECYCLESTATE = "LIFECYCLESTATE";

        public const string EXTERNALEXCHANGEWF = "EXTERNALEXCHANGEWORKFLOW";//REUBK 1884
        public const string OEMWORKFLOW = "OEMWORKFLOW";//REUBK 1884

        public const string HWWORKFLOW = "VAG_ASAM300_HWRQ";
    }

    public struct RulesFileTags
    {
        public const string INTERFACE = "INTERFACE";
        public const string EXTERNAL_STATE_BASED_RULE = "EXTERNAL_STATE_BASED_RULE";
        public const string IMF_RULES_VALIDATIONS = "IMF_RULES_VALIDATIONS";
        public const string COMMON_RULES = "COMMON_RULES";
        public const string IMF_RULES = "IMF_RULES";
        public const string RO_RULES = "RO_RULES";
        public const string XPATH = "XPATH";
        public const string IDRULE = "IDRULE";
        public const string ROPREPROCESSING = "ROPREPROCESSING";
        public const string FIELDRULES = "FIELDRULES";
        public const string ELEMENTRULE = "ELEMENTRULE";
        public const string FETCHROVALUES = "FETCHROVALUES";
        public const string COUNT = "COUNT";
        public const string DELIMITER = "DELIMITER";
        public const string VALUE = "VALUE";
        public const string OPERATOR = "OPERATOR";
        public const string FIELDRULE = "FIELDRULE";
        public const string FIELDVALUE = "FIELDVALUE";
        public const string FIELDNAME = "FIELDNAME";
        public const string ISREFFIELD = "ISREFFIELD";
        public const string KEY = "KEY";
        public const string ERR_MESSAGE = "ERRORMESSAGE";
        public const string VIOLATIONMESSAGE = "VIOLATIONMESSAGE";
        public const string VIOLATIONHANDLER = "VIOLATIONHANDLER";
        public const string WARNING = "WARNING";
        public const string ROFIELD = "$RO.";
        public const string IMFFIELD = "$IMF.";
        public const string RUNTIMEFIELD = "$RT.";
        public const string KEYIMF = "IMF";
        public const string KEYRO = "RO";
        public const string KEYRUNTIME = "RT";
        public const string ATTR_NAME = "name";
        public const string KEYS = "KEYS";
        public const string IDQUERY = "IDQUERY";
        public const string ADDITIONALQUERIES = "ADDITIONAL-QUERIES";
        public const string CNTRES = "CNTRES";
        public const string OPERAND1 = "OPERAND1";
        public const string OPERAND2 = "OPERAND2";
        public const string OPTCONDITION = "OPTCONDITION";
        public const string MUSTCONDITION = "MUSTCONDITION";
        public const string FIELDCHANGE = "FIELDCHANGE";
        public const string STRUCTURECHANGE = "STRUCTURECHANGE";
        public const string RESET = "RESET";
        public const string CHANGE = "CHANGE";
        public const string ADD = "ADD";
        public const string REMOVE = "REMOVE";
        public const string DELETE = "DELETE";
        public const string REPLACE = "REPLACE";
        public const string ADDATTR = "ADDATTR";
        public const string REMOVEATTR = "REMOVEATTR";
        public const string IMFUPDATEFIELD = "VAR";
        public const string IMFUPDATEVALUE = "VALUE";
        public const string AND = "AND";
        public const string OR = "OR";
        public const string QUERY = "QUERY"; //REUBK-1411
        public const string QUERYSTRING = "QUERYSTRING";
        public const string COUNTRECORDS = "COUNTRECORDS()";
        public const string MULTIPLETIMES = "MULTIPLETIMES"; //REUBK-3603
        public const string LOOPQUERYRESULTS = "LOOPQUERYRESULTS";
        public const string ADD_BRACKETELEMENT = "ADD_BRACKETELEMENT";//REUBK-3603
        public const string CAN_VALIDATE = "CAN_VALIDATE";//REUBK-3603
        public const string FILTER = "FILTER";
        public const string LOOP = "LOOP";
        public const string LOOPSTRUCTUREQUERY = "LOOPSTRUCTUREQUERY";
        public const string LOOPSTRUCTUREQUERYRESULTS = "LOOPSTRUCTUREQUERYRESULTS";
        public const string STRUCTUREQUERY = "STRUCTUREQUERY";
        public const string LOOP_VARIABLE = "LOOP-VARIABLE";
        public const string VAR_NAME = "VAR-NAME";
        public const string VAR_VALUE = "VAR-VALUE";
        public const string SETHANDLER = "SETHANDLER";
        public const string EMAIL = "EMAIL";
        public const string SENDER = "SENDER";
        public const string RECEPIENT = "RECEPIENT";
        public const string EMAILSUBJECT = "SUBJECT";
        public const string EMAILBODY = "BODY";


        public const string WFLVALIDATION = "WFL-VALIDATION"; //REUBK-1884
        public const string WFLTYPES = "WFL-TYPES"; //REUBK-1884
        public const string VALIDATIONRULES = "VALIDATION-RULES"; //REUBK-1884

        public const string IMFKEYELEMENTNAME = "IMFKEYELEMENTNAME";
        public const string ROKEYELEMENTNAME = "ROKEYELEMENTNAME";
        public const string ELEMENTRULES = "ELEMENTRULES";

    }

    public struct ConfigurationFileTags
    {
        public const string ROOT_NODE = "CONFIGURATIONS";
        public const string INTERFACE_SETTINGS = "INTERFACE_SETTINGS";
        public const string INTERFACE_MODE = "INTERFACE_MODE";
        public const string INTERFACE_TIMEOUT = "INTERFACE_TIMEOUT";
        public const string INTERFACE_NEWSTART = "INTERFACE_NEWSTART";
        public const string AFFECTEDRECORDS = "AFFECTEDRECORDS";
        public const string REQUESTONE = "REQUESTONE";
        public const string PROJECTS = "PROJECTS";
        public const string PROJECT = "PROJECT";
        public const string PROJECTS_PROJECT = "PROJECT";
        public const string PROJECT_NAME = "NAME";
        public const string PROJECT_ID = "ID";
        public const string REQUESTONE_ISSUES = "ISSUE";
        public const string ISSUES_DEF_FIELD_VALS_ROOT = "DEFAULT_FIELD_VALUES";
        public const string ISSUES_DEF_FIELD = "FIELD";
        public const string ISSUES_DEF_FIELD_NAME = "NAME";
        public const string ISSUES_DEF_FIELD_VALUE = "VALUE";
        public const string KEY = "KEY";
        public const string KEYS = "KEYS";
        public const string XPATH = "XPATH";
        public const string INSERTACTION = "INSERTACTION";
        public const string UPDATEACTION = "UPDATEACTION";
        public const string RONAME = "RONAME";
        public const string CONTACTS = "CONTACT";
        public const string RELEASES = "RELEASE";
        public const string ISSUE_RELEASE_MAPPINGS = "IRMAP";
        public const string COMMERCIAL = "COMMERCIAL";
        public const string ISSUES = "ISSUE";
        public const string DEFAULT_FIELD_VALUES = "DEFAULT_FIELD_VALUES";
        public const string DEFAULT_FIELD = "FIELD";
        public const string DEFAULT_FIELD_NAME = "NAME";
        public const string VALUE = "VALUE";
        public const string ATTR_SOURCE = "SOURCE";
        public const string ATTR_STATE = "STATE";
        public const string ATTACHMENTSLOCALPATH = "ATTACHMENTSLOCALPATH";
        public const string ATTACHMENTS = "ATTACHMENTS";
        public const string DESTPATH = "DESTPATH";
        public const string WARNING_SIZE = "WARNING_SIZE";
        public const string EMAIL_SETTINGS = "EMAIL_SETTINGS";
        public const string EMAIL_ADDRESS = "EMAIL_ADDRESS";
        public const string SMTP = "SMTP";

        public const string IMPORT_SETTINGS = "IMPORT_SETTINGS";
        public const string SKIPPARALLELIMPORTS = "SKIPPARALLELIMPORTS";
        public const string QCRITERIUM = "QCRITERIUM";
        public const string QDELAY = "QDELAY";
        public const string ENABLED = "ENABLED";

        public const string DOMAIN_NAME_VALUE = "Domain";
        public const string TYPE_NAME_VALUE = "Type";
        public const string SCOPE_NAME_VALUE = "Scope";

        public const string IMF_RULES_FILE_XPATH = "/CONFIGURATIONS/INTERFACE_SETTINGS/IMPORT_SETTINGS/IMFRULESVALIDATIONFILE";
        public const string CHARMAPPING_FILE_XPATH = "/CONFIGURATIONS/INTERFACE_SETTINGS/IMPORT_SETTINGS/CHARACTERMAPPINGFILE";
        public const string ROPREPROCESSINGXSLTXPATH = "/CONFIGURATIONS/INTERFACE_SETTINGS/IMPORT_SETTINGS/ROPREPROCESSING";
        public const string LOG_FILE_XPATH = "/CONFIGURATIONS/INTERFACE_SETTINGS/IMPORT_SETTINGS/LOGFILEPATH";
        //ADDED BY KARTHIK, 25-03-2011, To check if the IMF file to be used. In some cases, there is no need for usage of 
        public const string IMF_RULES_USEAGE_ATTRIBUTE = "userulefile";
        public const string ISSUE = "ISSUE";
        public const string ISSUERELEASEMAP = "ISSUERELEASEMAP";
        public const string MAPS = "MAPS";
        public const string STATE = "STATE";
        public const string STATENAME = "STATENAME";
        public const string MAPNAME = "MAPNAME";
        public const string ENRICHMENTORCH = "ENRICHMENTORCH";
        public const string XMLINVALIDCHAR = "XMLINVALIDCHAR";
        public const string WORKFLOW = "WORKFLOW";

        public const string IMF_LOG_USAGE_ATTRIBUTE = "uselogfile";
        public const string CHARACTERMAPPING_USAGE_ATTRIBUTE = "usemappingtable";
        public const string IMF_LOG_FILE_XPATH = "/CONFIGURATIONS/INTERFACE_SETTINGS/IMPORT_SETTINGS/IMFRULESVALIDATIONFILE";

        //mapping table constants
        public const string CHARACTERMAPPING_MAPPING = "MAPPING";
        public const string CHARACTERMAPPING_NCRCODE = "NCR-CODE";
        public const string CHARACTERMAPPING_ISOCHAR = "ISO-CHAR";
    }

    public struct IssueFileHandling
    {
        public const string ISSUE_CONSUMED = "CONSUMED";
        public const string ISSUE_FAILED = "FAILED";
    }

    public struct RuntimeDefaultKeys
    {
        public const string PROJECTID = "BELONGSTOPROJECT";
        public const string ISSUEPROJECTID = "HASMAPPEDISSUE.BELONGSTOPROJECT";

    }

    public static class GlobalConstants
    {
        public static List<string> g_CurrentlyExecuting = new List<string>();
        public static DataTable g_CurrentlyExecutingTable;

        static GlobalConstants()
        {
            g_CurrentlyExecutingTable = new DataTable();
            g_CurrentlyExecutingTable.Columns.Add("XPROT", typeof(string));
            g_CurrentlyExecutingTable.Columns.Add("FileName", typeof(string));
            g_CurrentlyExecutingTable.Columns.Add("QCRITERIUM", typeof(string));
            g_CurrentlyExecutingTable.Columns.Add("QDELAY", typeof(int));
        }

       // private static Dictionary<string, string> Runtime_Defaults = new Dictionary<string, string>();
       // public const string GC_DEFAULT_CATEGORY = "Default Category";
        public const string GC_APPCONFIG = "ConfigFile";
        public const int CQ_AD_PRIVATE_SESSION = 2;
        public const string RECORDTYPE = "RECORDTYPE";
        public const string ENTITYOBJECT = "ENTITYOBJECT";
        public const string TITLE = "TITLE";
        public const string PFAMRELEASETYPE = "PVAR/PFAM";
        public const string DBID = "DBID";
        public const string RELEASETYPE = "TYPE";
        public const string DOMAIN = "DOMAIN";
        public const string OPERATIONMODE = "OPERATIONMODE";
        public const string OPERATIONCONTEXT = "OPERATIONCONTEXT";
        public const string DESCRIPTION = "Description";


        public const char COLON = ':';
        public const string EXTERNALDESCRIPTION = "EXTERNALDESCRIPTION";
        public const string ISAFFECTEDBYDEFECTISSUE = "isAffectedByDefectIssue";
        public const string ID = "ID";
        public const string DcType = "http://purl.org/dc/terms/type";
        public const string TAGS = "Tags";
        public const string SOURCEIMF = "IMF";
        public const string ENTITY = "ENTITY";
        public const string SOURCECONFIG = "CONFIG";
        public const string SOURCERUNTIME = "RUNTIME";
        public const string YES = "YES";
        public const string NO = "NO";
        public const char ATTR = '@';
        public const string LCSMessage = "Warning in RequestOne: Lifecyclestate of proposed Release is not valid.";


        public const string LOG_FILE_PATTERN = "_ROCQASAMInt.log"; //ex: ASAM_BT_RO_INTERFACE_LOG_CONFIG
        public const string LOG_FILE_PATH = "_ROCQASAMInt.log"; //ex: ASAM_BT_RO_INTERFACE_LOG_CONFIG
        public const string LOG_FILE_CONFIG_PATTERN = "_BT_RO_INTERFACE_LOG_CONFIG"; //ex: ASAM_BT_RO_INTERFACE_LOG_CONFIG
        public const string LOGGER_KEY = "RO-ASAM-LOGGER";
        public const int LOGGERLEVEL1 = 1;
        public const int LOGGERLEVEL2 = 2;
        public const int LOGGERLEVEL3 = 3;

        public const string INTERFACE_CONFIG_PATTERN = "_BT_RO_INTERFACE_CONFIG";//EX: ASAM_BT_RO_INTERFACE_CONFIG
        public const string OSLC_DUMMY_XML = @"<feed xmlns:rdf=""http://www.w3.org/1999/02/22-rdf-syntax-ns#"" xmlns=""http://www.w3.org/2005/Atom""><title>External_ID=""8765432""</title><id>http://fe0vm221.de.bosch.com/oslc/cqrest/repo/CDG_ASAM_PROTOTYPE/db/TDB2/record/?oslc_cm.query=External_ID=%228765432%22&amp;rcm.type=Issue</id><author><name>IBM Rational ClearQuest</name></author><link rel=""self"" href=""http://fe0vm221.de.bosch.com/oslc/cqrest/repo/CDG_ASAM_PROTOTYPE/db/TDB2/record/?oslc_cm.query=External_ID=%228765432%22&amp;rcm.type=Issue"" /><updated>2010-12-22T08:55:10Z</updated><oslc_cm:totalCount xmlns:oslc_cm=""http://open-services.net/xmlns/cm/1.0/"">0</oslc_cm:totalCount></feed>";

        public const string IMF_NAMESPACE_URI = "http://RB.ROCustomerInterface.RB";
        public const string BIN_COMPARE_URI = "http://RB.BT.ROBinaryComparison.BinaryCompare";

        public const string ASAM_URI = "http://www.asam.net/schemas/issue/issue300";

        public const string FTPRESULTURI = "http://FTPIssueTransfer.FTPFileInformation";
        public const string DBMAPPERURI = "http://DBMapper.Schema";
        public const string TARGETPROJECTS = "TargetProjects";
        public const string TARGETPROJECT = "TargetProject";
        public const string PROJECTID = "ProjectID";
        public const string PROJECTDOMAIN = "ProjectDomain";

        public const string REGEX_MATCHVERSION = "DAI(?'Match1'[0-9]+)#RB(.*)";
        public const string REGEX_MATCHVERSIONBMW = "BMW(?'Match1'[0-9]+)#RB(.*)";
        public const string REGEX_MATCHOEMVERSIONBMW = "BMW(?'Match1'[0-9]+)";
        public const string INCREMENTVERSION = "/$1++";

        public const string SUB = "SUB";

        public const int MAX_ATTNAMELENGTH = 137; //142;

        private static object lockerRegister = new object();
        private static object lockerDeregister = new object();

        public enum RORecordTypes
        {
            COMMERCIAL,
            EMAIL_RULE,
            CQ_CONDITION,
            RELEASE,
            ISSUESHADOW,
            IRMAP,
            RELEASESHADOW,
            RELEASERELEASEMAPSHADOW,
            ATTACHMENTMAPPING,
            GROUPS,
            EXCHANGEPROTOCOL,
            HISTORY,
            ISSUE,
            RELEASERELEASEMAP,
            WORKITEM,
            METADATA,
            XML_EXCHANGE,
            ATTACHMENTS,
            PROJECT,
            USERS,
            MILESTONE,
            CONTACT
        }
        public enum RODataInsertType
        {
            INSERT,
            UPDATE,
            NONE
        }
        public enum Operation
        {
            EQ,
            NE,
            LT,
            LE,
            LTE,
            GT,
            GTE,
            IN,
            NAV,
            MLEQ,
            IN_CS,
            VC,
            NOT_IN
        }



        public struct OrcParamPackage
        {
            public const string BELONGSTOPROJECT = "BELONGSTOPROJECT";
            public const string XCHANGEPROTOCOLID = "XCHANGEPROTOCOLID";
            public const string ATTACHMENTPATH = "ATTACHMENTPATH";
            public const string BELONGSTOPOOLPROJECT = "BELONGSTOPOOLPROJECT";//added for Release mapping changes
            public const string ISSUEFILENAME = "ISSUEFILENAME";
            public const string EXCHANGEFORMAT = "EXCHANGEFORMAT";
            public const string CONFIGURATIONFILE = "CONFIGURATIONFILE";
            public const string IMFFILE = "IMFFILE";
            public const string PARENT = "PARENT";
            public const string RULETYPE = "RULETYPE";
            public const string RULESTYPE = "RULESTYPE";
            public const string RORULE = "RORULES";
            public const string IMFRULE = "IMFRULES";
            public const string IDRULE = "IDRULE";
            public const string FIELDRULE = "FIELDRULE";
            public const string XPATH = "XPATH";
            public const string UPDATEIMF = "NO";
        }


        public struct ASAMFileTags
        {
            public const string ISSUES = "ISSUES";
            public const string ISSUEID = "ISSUE-ID";
            public const string DELIVERYMILESTONES = "DELIVERY-MILESTONES";
            public const string ISSUE = "ISSUE";
            public const string ISSUEPROPERTIES = "ISSUE-PROPERTIES";
            public const string ISSUECURRENTSTATE = "ISSUE-CURRENT-STATE";
            public const string ISSUESTATE = "ISSUE-STATE";
            public const string ISSUEANNOTATIONS = "ISSUE-ANNOTATIONS";
            public const string ISSUEANNOTATION = "ISSUE-ANNOTATION";
            public const string COMPANYISSUEINFOS = "COMPANY-ISSUE-INFOS";
            public const string COMPANYISSUEINFO = "COMPANY-ISSUE-INFO";
            public const string STATEREQUESTED = "REQUESTED";
            public const string STATEREJECTED = "REJECTED";
            public const string REJECT_SPECIFIED = "REJECT_SPECIFIED";
            public const string REJECT_ESTIMATED = "REJECT_ESTIMATED";
            public const string PILOT = "PILOT";
            public const string SI = "SI";
            public const string ORIGIN = "ORIGIN";
            public const string STATESPECIFIED = "SPECIFIED";
            public const string STATEAPPROVED = "APPROVED";
            public const string STATEACCEPTED = "ACCEPTED";
            public const string STATECANCELLED = "CANCELED";
            public const string ISSUEINITIATOR = "ISSUE-INITIATOR";
            /*public const string PATH = "PATH";
            public const string LABEL = "LABEL";
            public const string CONTENT = "CONTENT";*/
            public const string STATECLOSEDNOTOK = "CLOSED-NOT-OK";
            public const string STATECLOSEDOK = "CLOSED-OK";
            public const string STATEINFOUPDATE = "INFORMATIONAL-UPDATE";
            public const string STATEPROPOSED = "PROPOSED";
            public const string STATEMSGACK = "MESSAGE-ACKNOWLEDGE";
            public const string CATEGORY = "CATEGORY";
            public const string LEVEL = "LEVEL";
            public const string ASAM_URI = "http://www.asam.net/schemas/issue/issue300";
            public const string ASAM_310MODIFIEDURI = "http://www.asam.net/schemas/issue/issue310-DaiModV1";
            public const string ASAM_311MODIFIEDURI = "http://www.asam.net/schemas/issue/issue311-DaiModV2";
            public const string ASAM_BMW310URI = "http://www.asam.net/schemas/issue/issue310";
            public const string ASAM_BMW320URI = "http://www.asam.net/schemas/issue/issue320";
            public const string ASAM_MSGACK = "http://www.asam.net/schemas/issue/messageacknowledgement";

            public const string PROJECT_ID = "PROJECT-ID";
            public const string AUDI = "AUDI";
            public const string BMW = "BMW";
            public const string DAIMLER = "DAIMLER";


            public const string SETSTATECLOSEDNOTOK = "CLOSED NOT OK";
            public const string SETSTATECLOSEDOK = "CLOSED OK";
            public const string SETSTATECANCELLED = "CANCELED";
            public const string SETSTATESPECIFIEDREJECTED = "SPECIFIED REJECTED";
            public const string SETSTATEESTIMATEDPILOTREJECTED = "ESTIMATED PILOT REJECTED";
            public const string SETSTATEESTIMATEDREJECTED = "ESTIMATED REJECTED";
            public const string SETSTATESPECIFIEDAPPROVED = "SPECIFIED APPROVED";
            public const string SETSTATESPECIFIEDAPPROVED320 = "SPECIFIED-APPROVED320";
            public const string SETSTATEESTIMATEDPILOTACCEPTED = "ESTIMATED PILOT ACCEPTED";
            public const string SETSTATEESTIMATEDACCEPTED = "ESTIMATED ACCEPTED";
            public const string SETSTATEINFOUPDATE = "INFORMATIONAL UPDATE";
            public const string SETSTATEINFOUPDATE320 = "INFORMATIONAL-UPDATE320";
            public const string SETSTATEPROPOSED = "PROPOSED";
            public const string SETSTATE301ACCEPTED = "REQUESTED301";
            public const string SETSTATE301REQUESTED = "ACCEPTED301";
            public const string SETSTATE320REQUESTED = "REQUESTED320";
            public const string SETSTATE320REJECTED = "REJECTED320";
            public const string SETSTATE320ACCEPTED = "ACCEPTED320";
            public const string SETSTATE320CANCELLED = "CANCELED320";
            public const string SETSTATEPROPOSED_PROSPR = "PROPOSED_PROSPR";
            public const string SETSTATEINFOUPDATE_PROSPR = "INFORMATIONAL-UPDATE_PROSPR";
            public const string SETSTATEINFOUPDATE_PROSPR_SPL = "INFORMATIONAL-UPDATE_PROSPR_SPL";
            public const string SETSTATE320CLOSEDOK = "PROSPR_CLOSED";
            public const string SETSTATE320PROSPR_REQUESTED = "PROSPR_REQUESTED";
            public const string SETSTATE320PROSPR_REJECTED = "PROSPR_REJECTED";
            public const string SETSTATE320PROSPR_ACCEPTED = "PROSPR_ACCEPTED";
            public const string SETSTATE320PROSPR_CANCELLED = "PROSPR_CANCELED";


            public const string ISSUECATEGORY = "CATEGORY";
            public const string ISSUECATEGORYVALUE = "CHANGE-REQUEST";
            public const string TRANSACTIONID = "TRANSACTION-ID";
            public const string COMPANYDATAREF = "COMPANY-DATA-REF";
            public const string RB = "RB";
            
        }





        public static bool isCurrentlyExecuting(string xprot, string filename, Logger objlogger)
        {
            objlogger.LogInfo("inside  isCurrentlyExecuting" + xprot + ":" + filename, GlobalConstants.LOGGERLEVEL1);
            bool bReturn = true;
            DataTable g_CurrentlyExecutingTable_copy = new DataTable();
            g_CurrentlyExecutingTable_copy = g_CurrentlyExecutingTable;

            int icount = 0;

            try
            {
                if (g_CurrentlyExecutingTable_copy.Rows.Count > 0)
                {
                    objlogger.LogInfo("g_CurrentlyExecutingTable count" + g_CurrentlyExecutingTable_copy.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
                    foreach (DataRow dr in g_CurrentlyExecutingTable_copy.Rows)
                    {
                        objlogger.LogInfo("xprot" + dr["XPROT"] + ":" + "value" + dr["FileName"].ToString(),GlobalConstants.LOGGERLEVEL1);

                        if (dr["XPROT"].ToString().Contains(xprot))
                        {
                            if (dr["FileName"].ToString().Contains(filename))
                            {
                                bReturn = false;
                                break;
                            }
                        }

                    }

                }
            }

            catch (Exception ex)
            {
                objlogger.LogInfo(ex.Message, LOGGERLEVEL1);
            }
            return bReturn;

        }

        /// <summary>
        /// This method verifies the first file of the cascaded files is present in the datatable or not
        /// </summary>
        /// <param name="xprot"></param>
        /// <param name="filename"></param>
        /// <param name="objlogger"></param>
        /// <returns></returns>
        public static bool CheckFirstFileforDaimler(string xprot,string sInterface, string filename, Logger objlogger)
        {
            objlogger.LogInfo("inside  CheckFirstFileforDaimler" + xprot + ":" + filename, GlobalConstants.LOGGERLEVEL1);
            bool bReturn = false;

            string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sInterface + GlobalConstants.INTERFACE_CONFIG_PATTERN);
            ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
            XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sInterface);
            string RegexOfQCRITERIUM = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.QCRITERIUM).Value;
            
            try
            {
                MatchCollection IMFissueID = Regex.Matches(filename, RegexOfQCRITERIUM, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (g_CurrentlyExecutingTable.Rows.Count > 1)
                {
                    //atchCollection matches1 = Regex.Matches(filename, sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);




                    objlogger.LogInfo("g_CurrentlyExecutingTable count " + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
                    foreach (DataRow dr in g_CurrentlyExecutingTable.Rows)
                    {
                        
                        if (filename.Trim() != dr["FileName"].ToString().Trim())
                        {
                            if (IMFissueID[0].Value.Trim() == dr["QCRITERIUM"].ToString().Trim())
                            {
                                if (Convert.ToInt32(dr["QDELAY"]) == 0)
                                {
                                    objlogger.LogInfo("The First File Exists in the g_CurrentlyExecutingTable", GlobalConstants.LOGGERLEVEL1);
                                    bReturn = true;
                                    break;
                                }
                            }
                        }
                        
                    }

                }
            }

            catch (Exception ex)
            {
                objlogger.LogInfo("Exception inside  CheckFirstFileforDaimler " + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
            return bReturn;

        }






        public static void RegisterForExecution(string xprot, string sInterface, string sFileNames, Logger objlogger, string sFilterRegex = "")
        {


            objlogger.LogInfo("inside  RegisterForExecution", GlobalConstants.LOGGERLEVEL1);

            if (System.Threading.Monitor.TryEnter(lockerRegister, 6000)) //timeout of 6sec
            {

                try
                {

                    string[] sFileNamearr = sFileNames.Split('|');

                    //string sFilter = @"(?<filenamematch>.*)_(?<date>(19|20)[0-9]{2}(0[1-9]|1[012])(\d+))_(?<time>(20|21|22|23|[0-1]\d)[0-5]\d[0-5]\d).XML";

                    bool bRowexists = false;

                    foreach (string sFileName in sFileNamearr)
                    {


                        for (int i = g_CurrentlyExecutingTable.Rows.Count - 1; i >= 0; --i)
                        {
                            DataRow dr = g_CurrentlyExecutingTable.Rows[i];
                            bRowexists = false;
                            objlogger.LogInfo("filename in table" + dr["FileName"].ToString(), GlobalConstants.LOGGERLEVEL2);
                            if (!string.IsNullOrEmpty(sFilterRegex))
                            {
                                MatchCollection matches1 = Regex.Matches(sFileName, sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                                MatchCollection matches2 = Regex.Matches(dr["FileName"].ToString(), sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                                if ((matches1.Count > 0) && (matches2.Count > 0))
                                {

                                    if (matches1[0].Groups["filenamematch"].Value.Equals(matches2[0].Groups["filenamematch"].Value))
                                    {
                                        bRowexists = true;
                                        break;
                                    }
                                }

                            }
                            if (dr["FileName"].ToString() == sFileName)
                            {
                                bRowexists = true;
                                break;
                            }

                        }

                        if (bRowexists == false)
                        {
                            objlogger.LogInfo("Inserting the file into Executing table : " + sFileName + " XprotID : " + xprot, LOGGERLEVEL1);
                            g_CurrentlyExecutingTable.Rows.Add(new object[] { xprot, sFileName });
                        }
                    }
                }
                finally
                {
                    //Releasing lock
                    System.Threading.Monitor.Exit(lockerRegister);
                }
            }
            else
            {
                objlogger.LogInfo("Time out obtaining lock", LOGGERLEVEL1);
            }


            objlogger.LogInfo("tabelcount" + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

        }

        //public static void RegisterForExecution(string xprot, string sInterface, string sFileNames, Logger objlogger, string sFilterRegex = "")
        //{


        //    objlogger.LogInfo("inside  RegisterForExecution", GlobalConstants.LOGGERLEVEL1);

        //    if (System.Threading.Monitor.TryEnter(lockerRegister, 6000)) //timeout of 6sec
        //    {

        //        try
        //        {

        //            string[] sFileNamearr = sFileNames.Split('|');

        //            string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sInterface + GlobalConstants.INTERFACE_CONFIG_PATTERN);
        //            ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
        //            XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sInterface);
        //            string RegexOfQCRITERIUM = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.QCRITERIUM).Value;

        //            string QDelay = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.QDELAY).Value;

        //            bool bRowexists = false;
        //            objlogger.LogInfo("table count before entering the file : " + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
        //            if (sInterface.ToUpper().Contains("DAIMLER") && sFileNamearr.Count() == 1)
        //            {
        //                foreach (string sFileName in sFileNamearr)
        //                {
        //                    bool QCriteriumExists = false;
        //                    int Delay = 0;
        //                    MatchCollection IMFissueID = Regex.Matches(sFileName, RegexOfQCRITERIUM, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //                    for (int i = g_CurrentlyExecutingTable.Rows.Count - 1; i >= 0; --i)
        //                    {
        //                        DataRow dr = g_CurrentlyExecutingTable.Rows[i];
        //                        bRowexists = false;
        //                        string Qcriterium = string.Empty;
        //                        objlogger.LogInfo("filename in table" + dr["FileName"].ToString(), GlobalConstants.LOGGERLEVEL1);
        //                        if (!string.IsNullOrEmpty(sFilterRegex))
        //                        {
        //                            MatchCollection matches1 = Regex.Matches(sFileName, sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //                            MatchCollection matches2 = Regex.Matches(dr["FileName"].ToString(), sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //                            if ((matches1.Count > 0) && (matches2.Count > 0))
        //                            {
        //                                //verifies for the QCRITERIUM in the data table and if its present with same CR it will add that particular file with delay as 20s
        //                                if(matches1[0].Groups["filenamematch"].Value.Trim() != matches2[0].Groups["filenamematch"].Value.Trim())
        //                                {
        //                                    if (IMFissueID[0].Value == dr["QCRITERIUM"].ToString())
        //                                    {
        //                                        if(Convert.ToInt32(dr["QDELAY"]) == 0)
        //                                        {
        //                                            Delay = Convert.ToInt32(QDelay);
        //                                            QCriteriumExists = true;
        //                                            g_CurrentlyExecutingTable.Rows.Add(new object[] { xprot, sFileName, IMFissueID[0].Value, Delay });
        //                                            objlogger.LogInfo(sFileName + " file added with 20sec delay." , GlobalConstants.LOGGERLEVEL1);
        //                                        }

        //                                    }
        //                                }

        //                            }

        //                        }

        //                        if (dr["FileName"].ToString() == sFileName)
        //                        {
        //                            bRowexists = true;
        //                            break;
        //                        }

        //                    }

        //                    if (bRowexists == false && QCriteriumExists == false)
        //                    {
        //                        Delay = 0;
        //                        g_CurrentlyExecutingTable.Rows.Add(new object[] { xprot, sFileName, IMFissueID[0].Value, Delay });
        //                        objlogger.LogInfo(sFileName + " file added with 0sec delay.", GlobalConstants.LOGGERLEVEL1);

        //                    }

        //                }
        //            }

        //            else
        //            {
        //                foreach (string sFileName in sFileNamearr)
        //                {

        //                    for (int i = g_CurrentlyExecutingTable.Rows.Count - 1; i >= 0; --i)
        //                    {
        //                        DataRow dr = g_CurrentlyExecutingTable.Rows[i];
        //                        bRowexists = false;
        //                        objlogger.LogInfo("filename in table" + dr["FileName"].ToString(), GlobalConstants.LOGGERLEVEL2);
        //                        if (!string.IsNullOrEmpty(sFilterRegex))
        //                        {
        //                            MatchCollection matches1 = Regex.Matches(sFileName, sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //                            MatchCollection matches2 = Regex.Matches(dr["FileName"].ToString(), sFilterRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //                            if ((matches1.Count > 0) && (matches2.Count > 0))
        //                            {

        //                                if (matches1[0].Groups["filenamematch"].Value.Equals(matches2[0].Groups["filenamematch"].Value))
        //                                {
        //                                    bRowexists = true;
        //                                    break;
        //                                }
        //                            }

        //                        }
        //                        if (dr["FileName"].ToString() == sFileName)
        //                        {
        //                            bRowexists = true;
        //                            break;
        //                        }

        //                    }

        //                    if (bRowexists == false)
        //                    {
        //                        g_CurrentlyExecutingTable.Rows.Add(new object[] { xprot, sFileName, "", 0 });
        //                    }
        //                }
        //            }

        //        }
        //        finally
        //        {
        //            //Releasing lock
        //            System.Threading.Monitor.Exit(lockerRegister);
        //        }
        //    }
        //    else
        //    {
        //        objlogger.LogInfo("Time out obtaining lock", LOGGERLEVEL1);
        //    }


        //    objlogger.LogInfo("tabelcount : " + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);


        //}



        public static void DeRegisterFromExecution(string xprot, Logger objlogger)
        {
            objlogger.LogInfo("inside  DeRegisterFromExecution" + xprot, GlobalConstants.LOGGERLEVEL1);
            if (System.Threading.Monitor.TryEnter(lockerDeregister, 6000)) //timeout of 6sec
            {
                try
                {
                    if (g_CurrentlyExecutingTable.Rows.Count > 0)
                    {
                        List<DataRow> rowsToDelete = new List<DataRow>();

                        objlogger.LogInfo("inside  DeRegisterFromExecution g_CurrentlyExecutingTablerow count" + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

                        foreach (DataRow dr in g_CurrentlyExecutingTable.Rows)
                        {

                            objlogger.LogInfo("from tabel xprot" + dr["XPROT"].ToString(), GlobalConstants.LOGGERLEVEL2);

                            if (dr["XPROT"].ToString() == xprot)
                            {
                                objlogger.LogInfo("Deletig the following Xprot : " + xprot, GlobalConstants.LOGGERLEVEL1);
                                rowsToDelete.Add(dr);
                            }
                        }

                        objlogger.LogInfo("count-rowsToDelete" + rowsToDelete.Count().ToString(), GlobalConstants.LOGGERLEVEL1);

                        foreach (DataRow row in rowsToDelete)
                        {
                            
                            g_CurrentlyExecutingTable.Rows.Remove(row);
                        }
                        
                        g_CurrentlyExecutingTable.AcceptChanges();
                        objlogger.LogInfo("inside  DeRegisterFromExecution g_CurrentlyExecutingTablerow count" + g_CurrentlyExecutingTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

                    }

                }
                catch { }
                finally
                {
                    //Releasing lock
                    System.Threading.Monitor.Exit(lockerDeregister);
                }
            }
            else
            {
                objlogger.LogInfo("Time out obtaining lock", LOGGERLEVEL1);
            }
        }

        ///// <summary>
        ///// Modifies the Delay value for the cascading Xprots based on the status of the First Import File
        ///// </summary>
        ///// <param name="xprot"></param>
        ///// <param name="sInterface"></param>
        ///// <param name="sFileNames"></param>
        ///// <param name="objlogger"></param>
        //public static void ModifyDelayForDaimlerFiles(string xprot, string sInterface, string sFileNames, Logger objlogger)
        //{
        //    objlogger.LogInfo("inside  ModifyDelayForDaimlerFiles", GlobalConstants.LOGGERLEVEL1);
        //    string[] sFileNamearr = sFileNames.Split('|');

        //    string strConfigFilePath = Utilities.LoadItemFromBizTalkAppConfig(sInterface + GlobalConstants.INTERFACE_CONFIG_PATTERN);
        //    ROConfigurationManager rConfigMgr = new ROConfigurationManager(strConfigFilePath, objlogger);
        //    XDocument l_oConfig = rConfigMgr.LoadConfigurationXML(sInterface);
        //    string RegexOfQCRITERIUM = l_oConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.QCRITERIUM).Value;
        //    try
        //    {
        //        if (sFileNamearr.Count() == 1 && sInterface.Contains("DAIMLER"))
        //        {
        //            foreach (var sFileName in sFileNamearr)
        //            {
        //                MatchCollection IMFissueID = Regex.Matches(sFileName, RegexOfQCRITERIUM, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //                for (int i = g_CurrentlyExecutingTable.Rows.Count - 1; i >= 0; --i)
        //                {
        //                    DataRow dr = g_CurrentlyExecutingTable.Rows[i];
        //                    if (sFileName != dr["FileName"].ToString())
        //                    {
        //                        if (IMFissueID[0].Value == dr["QCRITERIUM"].ToString() && Convert.ToInt32(dr["QDELAY"]) != 0)
        //                        {
        //                            dr["QDELAY"] = 0;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        objlogger.LogInfo("Exception inside ModifyDelayForDaimlerFiles  : " + ex.Message, GlobalConstants.LOGGERLEVEL1);
        //    }
            
        //}



    }



}
