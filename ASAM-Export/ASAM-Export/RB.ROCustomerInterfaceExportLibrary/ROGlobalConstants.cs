using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RB.ROCustomerInterfaceExportLibrary
{

   

    public struct BizTalkConfigParams
    {
        public const string ROASAMLOGGER = "D:\\ASAM-IF-EXPORT\\Export\\950 - BTLogs";
        public const string RO_ASAM_EXPORT_LOGGER = "D:\\ASAM-IF-EXPORT\\Export\\950 - BTLogs";
        public const string EX_RO_INTERFACE_CONFIG = "D:\\ASAM-IF-EXPORT\\Export\\910 - BTConfigurations\\Export_RO_Interface_Config.xml";
        public const string BT_MESSAGES = "D:\\ASAM-IF-EXPORT\\Export\\050 - BTMessages\\";
    }





   





    public struct IMFFileTags
    {
        public const string Root_Node = "EXPORT_IMF";
        public const string Issue = "ISSUE";
        public const string Irmap = "ISSUERELEASEMAP";
        public const string ExternalLastExportedDate = "ExternalLastExportedDate";
        public const string ExternalCommentAuthor = "ExternalCommentAuthor";
        public const string ExternalConversation = "ExternalConversation";
        public const string ExternalHistory = "ExternalHistory";
        public const string ExternalNextState = "ExternalNextState";
        public const string ExternalState_Parallel1 = "ExternalState_Parallel1";
        public const string ExternalState_Parallel2 = "ExternalState_Parallel2";
        public const string IRMAP = "ISSUERELEASEMAP";
        public const string COMMERCIAL = "COMMERCIAL";
        public const string ExternalExchangedAttach = "ExternalExchangedAttach";
        public const string ExternalUpdateVersion = "ExternalUpdateVersion";
        public const string CommercialQuotationReq = "CommercialQuotationReq";
        public const string Tags = "Tags";
        public const string ExternalTags = "ExternalTags";
    }


    public struct XsltConfig
    {
        public const string ASAM_Templates = "D:\\ASAM-IF-EXPORT\\Export\\910 - BTConfigurations\\ASAM_Templates.xsl";
        public const string xslFilePath = "D:\\ASAM-IF-EXPORT\\Export\\910 - BTConfigurations\\xsl_mappings\\";
        public const string Audi_Validator = "D:\\ASAM-IF-EXPORT\\Export\\910 - BTConfigurations\\AUDI_Validator.xsl";
    }

   

    public struct ConfigurationFileTags
    {
        public const string ROOT_NODE = "CONFIGURATIONS";
        public const string REMOTE_EXPORT_DESTPATH = "REMOTE_EXPORT_DESTPATH";
        public const string REMOTE_PATH = "REMOTE_PATH";
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

    

    

    public static class GlobalConstants
    {
        public static List<string> g_CurrentlyExecuting = new List<string>();
        public static DataTable g_CurrentlyExecutingTable;


        public static readonly string[] AllowedPrefixes =
        {
            "TEST1RB-",
            "P7RB-"
        };


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

        public const string connectionString = "Server=SI0VM08132;Database=ExportDb;Integrated Security=True;";


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
        public const string LOGGER_KEY = "RO-ASAM-EXPORT-LOGGER";
        public const string ASAMFile_FolderPath = "D:\\ASAM-IF-EXPORT\\Export\\030 - ASAMFiles\\";
        public const string ExchangedCommercialFiles = "ExchangedCommercialFiles";
        public const string ExchangedFiles = "ExchangedFiles";
        public const int LOGGERLEVEL1 = 1;
        public const int LOGGERLEVEL2 = 2;
        public const int LOGGERLEVEL3 = 3;

        public const int BatchSize = 5; //batch size to execute the records parallely

        public const string INTERFACE_CONFIG_PATTERN = "EX_RO_INTERFACE_CONFIG";
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


        public static class XsltConstants
        {
            public const string ExternalTagsTransformation = @"
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" version=""1.0"">

  <xsl:output method=""xml"" indent=""yes""/>

  <!-- Dynamic TIME from C# -->
  <xsl:param name=""currentTime""/>

  <!-- Root -->
  <xsl:template match=""/EXPORT-MODIFICATION"">
    <EXPORT>
      <xsl:attribute name=""STATE"">
        <xsl:value-of select=""@STATE""/>
      </xsl:attribute>

      <xsl:attribute name=""TIME"">
        <xsl:value-of select=""$currentTime""/>
      </xsl:attribute>

      <APSKS>
        <xsl:for-each select=""APSKS/APSK"">
          <xsl:variable name=""apskIndex"" select=""position()""/>

          <APSK ID="""">
            <STATE><xsl:value-of select=""STATUS""/></STATE>

            <SHORT-NAME><xsl:value-of select=""SHORT-NAME""/></SHORT-NAME>

            <RQ1-TITLE><xsl:value-of select=""SHORT-NAME""/></RQ1-TITLE>

            <RB-ID>APSK<xsl:value-of select=""$apskIndex""/></RB-ID>

            <COMMENT>
              <xsl:apply-templates select=""COMMENT/*""/>
            </COMMENT>

            <ATTS>
              <xsl:copy-of select=""ATTS/node()""/>
            </ATTS>

            <xsl:if test=""normalize-space(CLARIFICATION-STATUS) != ''"">
              <CLARIFICATION-STATUS>
                <xsl:value-of select=""CLARIFICATION-STATUS""/>
              </CLARIFICATION-STATUS>
            </xsl:if>

            <APSMS>
              <xsl:for-each select=""APSMS/APSM"">
                <xsl:variable name=""apsmIndex"" select=""position()""/>

                <APSM ID="""">
                  <STATE><xsl:value-of select=""STATUS""/></STATE>

                  <SHORT-NAME><xsl:value-of select=""SHORT-NAME""/></SHORT-NAME>

                  <RQ1-TITLE><xsl:value-of select=""SHORT-NAME""/></RQ1-TITLE>

                  <RB-ID>
                    APSM<xsl:value-of select=""$apskIndex""/>-<xsl:value-of select=""$apsmIndex""/>
                  </RB-ID>

                  <COMMENT>
                    <xsl:apply-templates select=""COMMENT/*""/>
                  </COMMENT>

                  <ATTS>
                    <xsl:copy-of select=""ATTS/node()""/>
                  </ATTS>

                  <xsl:if test=""normalize-space(CLARIFICATION-STATUS) != ''"">
                    <CLARIFICATION-STATUS>
                      <xsl:value-of select=""CLARIFICATION-STATUS""/>
                    </CLARIFICATION-STATUS>
                  </xsl:if>

                </APSM>
              </xsl:for-each>
            </APSMS>

          </APSK>
        </xsl:for-each>
      </APSKS>
    </EXPORT>
  </xsl:template>

  <!-- Convert <p> → <P> -->
  <xsl:template match=""p"">
    <P>
      <xsl:value-of select="".""/>
    </P>
  </xsl:template>

</xsl:stylesheet>";
        }




        public struct QueryMethods
        {
            public const string checkRecordLock = "checkRecordLock";
            public const string getIssueByIdForIssueEntrypoint = "getIssueById";
            public const string getIssueReleaseMapByRQ1Id = "getIssueReleaseMapByRQ1Id";
            public const string getContactsByDbId = "getContactsByDbId";
            public const string getAttachmentMappingsByDbId = "getAttachmentMappingsByDbId";
            public const string getIssueAttachments = "getIssueAttachments";
            public const string getIssueCommercialAttachments = "getIssueCommercialAttachments";
            public const string getCommercialByDbId = "getCommercialByDbId";
            public const string getUsersByLoginName = "getUsersByLoginName";
            public const string getXprotStatus = "getXprotStatus";
            public const string UpdateIssue = "updateIssue";
            public const string UpdateIssueReleaseMap = "UpdateIssueReleaseMap";
            public const string updateIssue_IRM = "updateIssue_IRM";
            public const string UpdateXprot = "updateExchangeProtocol";
            public const string uploadCommercialFiles = "uploadCommercialFiles";
            public const string uploadExchangedFiles = "uploadExchangedFiles";
            public const string getIssueByDBId = "getIssueByDBId";
            public const string getReleaseByDBId = "getReleaseByDBId";
            public const string getProjectByDbId = "getProjectByDbId";
            public const string getReleaseByExtTitle = "getReleaseByExtTitle";
            public const string create_IRM = "create_IRM";


        }

        public struct QueryBody
        {
            public const string XprotBody = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>
                                             <rdf:RDF
                                             xmlns:rdf=""http://www.w3.org/1999/02/22-rdf-syntax-ns#""
                                             xmlns:oslc=""http://open-services.net/ns/core#""
                                             xmlns:dcterms=""http://purl.org/dc/terms/""
                                             xmlns:cq=""http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/""
                                             xmlns:oslc_cm=""http://open-services.net/ns/cm#""
                                             xmlns:rdfs=""http://www.w3.org/2000/01/rdf-schema#"">
                                             <oslc_cm:ChangeRequest rdf:about=""url"">
                                                  <dcterms:type>ExchangeProtocol</dcterms:type>
                                                  <cq:OperationMode rdf:ID=""OperationMode""> Test</cq:OperationMode>
                                                  <cq:OperationContext rdf:ID=""OperationContext""> Test</cq:OperationContext>
                                                  <cq:Log rdf:ID=""Log"">XprotLog</cq:Log>
                                                  <cq:Status rdf:ID=""Status""> XprotStatus</cq:Status>
                                                    </oslc_cm:ChangeRequest>
                                                    <rdf:Statement rdf:about=""#OperationMode"" >
                                                        <cq:fieldOrder>23</cq:fieldOrder>
                                                    </rdf:Statement>
                                                    <rdf:Statement rdf:about=""#OperationContext"" >
                                                        <cq:fieldOrder>22</cq:fieldOrder>
                                                    </rdf:Statement>
                                            </rdf:RDF>";
        }


        





       



    }



}
