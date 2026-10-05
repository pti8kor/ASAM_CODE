using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using RB.ROCustomerIntefaceLibrary;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using Saxon.Api;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using System.Reflection;
using ClearQuestOleServer;
using System.Net.Http;


namespace RO_TestBed
{
    public partial class frmMain : Form
    {
        //int GroupValue;
        //string compare = "", returnval1 = "", returnval2 = "";
        List<string> MatchParams = new List<string>();
        Regex PatternForReplace;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {
            //LogHelper lgHelp = LogHelper.GetLoggerInstance("RO-ASAM-BMW");
            //lgHelp.LogInfo("Test 1");

            //LogHelper lHelp = LogHelper.GetLoggerInstance("RO-ASAM-BMW");
            //lgHelp.LogInfo("TEST 2");



        }

        private void cmdValidation_Click(object sender, EventArgs e)
        { }

        //private void cmdValidation_Click(object sender, EventArgs e)
        //{
        //    lblProgress.Visible = true;

        //    this.Refresh();

        //    //XDocument l_oIMFDoc = XDocument.Load("RO_IMF.xml");
        //    //RODataInterface.ROProjectId = "RQ1D00004939";
        //    //RODataInterface.InterfaceName = "RO-ASAM-AUDI";
        //    //RODataInterface.InterfaceConfigFile = XDocument.Load("RO_Interface_Config.xml");
        //    //XDocument l_oIMFDoc = XDocument.Load("AUDI_IMF.xml");
        //    //ROValidationEngineManager l_oValidationManager
        //    //         = new ROValidationEngineManager("ASAM_AUDI_IMF-Rules_Validation.xml", l_oIMFDoc);
        //    //PersistenceDataManager.sExchangeProtocolId = "33715311";


        //    Dictionary<string, string> Orc_parms = new Dictionary<string, string>();
        //    Orc_parms.Add(OrcParameters.BELONGSTOPROJECT, "RQ1ML00026734");
        //    Orc_parms.Add(OrcParameters.BELONGSTOPOOLPROJECT, "RQ1ML00026734");
        //    Orc_parms.Add(OrcParameters.XCHANGEPROTOCOLID, "35813928");
        //    Orc_parms.Add(OrcParameters.SYSTEM, "CDG_DEV_INTEGRATION@RQ1ML");
        //    Orc_parms.Add(OrcParameters.EXCHANGEFORMAT, "RO-ASAM-DAIMLER");


        //    // RODataInterface.InterfaceName = "RO-ASAM-BMW";
        //    //RODataInterface.InterfaceConfigFile = XDocument.Load("RO-ASAM-BMW_RO_Interface_Config.xml");    
        //    Orc_parms.Add(OrcParameters.ATTACHMENTPATH, "D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug");

        //    //XDocument l_oIMFDoc = XDocument.Load("BMWValidateIMF.xml");

        //    //XDocument l_oIMFDoc = XDocument.Load("RQ1ML_35103421_030_IMF_Before_Validate{97B3A776-985F-40E1-9C27-10CC0530A9EB}.xml");
        //    XDocument l_oIMFDoc = XDocument.Load("RQ1ML_35813928_030_IMF_Before_Validate{FB5076B9-1F2D-4D97-90D8-37C73BD6F8CE}.xml");
        //    Logger objlogger = new Logger("D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug\\Test.txt");


        //    //ROValidationEngineManager l_oValidationManager
        //    // = new ROValidationEngineManager("ASAM_AUDI_IMF-Rules_Validation.xml", l_oIMFDoc);20110525 VRF Extension V1.1.xml
        //    Orc_parms.Add(OrcParameters.ISSUEFILENAME, "BMWRE600800_CP500800_20130128_182200_RQDV310.xml::InProgress||");

        //    string svrfPath = "D:\\RB-ASAM-Interface\\Import\\910 - BTConfigurations\\ASAM_DAIMLER_ValidationRuleFile.xml";
        //    ROValidationEngineManager l_oValidationManager = new ROValidationEngineManager(svrfPath, l_oIMFDoc, Orc_parms, objlogger);

        //    //ROErrorLogger.sIssueFileName = "BMW_IMF.xml";
        //    //PersistenceDataManager l_odm = new PersistenceDataManager();
        //    //l_odm.WriteData("RQ1ML_35102822_030_IMF_Before_Validate{23B350B0-1FEE-48C5-875C-2C9E1B91EF95}::In Work||||", PersistenceDataStores.LIFETOKEN, false, "34025330");                                

        //    bool bValid = l_oValidationManager.ValidateIMF();


        //    if (bValid)
        //    {
        //        lblProgress.Visible = false;
        //        MessageBox.Show("ValidationWarning successfull");

        //        //l_oValidationManager.SaveResultSet("C:\\temp\\ROResult.xml");

        //        //MessageBox.Show("Restult set saved in C:\temp");
        //    }
        //    else
        //    {
        //        lblProgress.Visible = false;
        //        MessageBox.Show("ValidationWarning ValidationWarning");
        //    }


        //}

        private void cmdExecute_Click(object sender, EventArgs e)
        {
            lblProgress.Visible = true;
            lblProgress.Text = "Execution in progress please wait ...";

            this.Refresh();
            //RODataInterface.InterfaceName = "RO-ASAM-AUDI_DEV";

            Dictionary<string, string> Orc_parms = new Dictionary<string, string>();
            //Orc_parms.Add(OrcParameters.BELONGSTOPROJECT, "RQ1ML00001049");
            Orc_parms.Add(OrcParameters.BELONGSTOPOOLPROJECT, "RQ1ML00001180");
            //Orc_parms.Add(OrcParameters.BELONGSTOPOOLPROJECT, "RQ1ML00001049");
            System.Xml.XmlDocument l_oxDoc = new System.Xml.XmlDocument();
            //l_oxDoc.Load("RB.RO_ASAM_ISSUE_IMF_MAP_output.xml");
            //l_oxDoc.Load("RQ1ML_35103420_030_IMF_Before_Validate{97B3A776-985F-40E1-9C27-10CC0530A9EB}.xml");
            l_oxDoc.Load("RQ1ML_35254087_035_IMF_After_Validate{9E87C8F6-2DC0-4271-9F52-24E935BCE7B7}.xml");

            //XDocument l_oIMFDoc = XDocument.Load("RQ1ML_35254087_035_IMF_After_Validate{9E87C8F6-2DC0-4271-9F52-24E935BCE7B7}.xml");
            //RODataInterface.InterfaceConfigFile
            //    = XDocument.Load("D:\\Project\\RO-ASAM-AUDI-Interface\\Source\\RB.ROCustInterface_Files\\CONFIG\\RO-ASAM-BMW_RO_Interface_Config.xml");
            Orc_parms.Add(OrcParameters.ATTACHMENTPATH, "D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug");

            BTHelper l_oHelper = new BTHelper();
            //bool bValid = l_oHelper.ValidateIMF(l_oxDoc, "RO-ASAM-AUDI"
            // , "D:\\Supreet\\versions\\4.5_Work\\Source\\ro_TestBed\\bin\\debug", "RQ1D00007038", "33735448", "RB.RO_ASAM_ISSUE_IMF_MAP_output.xml", "RB.RO_ASAM_ISSUE_IMF_MAP_output::In Work||||","CDG_DEV_INTEGRATION@RQ1ML");

            /*bool bValid = l_oHelper.ValidateIMF(l_oxDoc, "RO-ASAM-AUDI"
                , @"D:\Supreet\D4.15_InWork\Source\RO_TestBed\bin\Debug", "RQ1ML00001108", "33635744"
                , "RQONE_33917789_030_IMF_ValEngineTest.xml",
                "RQONE_33917789_030_IMF_ValEngineTest.xml::In Work||||");*/

            Logger objlogger = null;
            //l_oHelper..GetLogger("RO-ASAM-AUDI", "35254087");

            //bool bValid = l_oHelper.Execute(l_oxDoc, "RO-ASAM-BMW", @"D:\RB-ASAM-Interface\Import\960 - Sources\VMA4KOR\960 - BTImportSoftware\Validation-Execution-Engine\RO_TestBed\bin\Debug", "RQ1ML00001049", "35007294", "RQ1ML_35103420_030_IMF_Before_Validate{97B3A776-985F-40E1-9C27-10CC0530A9EB}.xml","CDG_DEV_INTEGRATION@RQ1ML");

            bool bValid = l_oHelper.Execute(l_oxDoc, "RO-ASAM-AUDI", @"D:\RB-ASAM-Interface\Import\960 - Sources\VMA4KOR\960 - BTImportSoftware\Validation-Execution-Engine\RO_TestBed\bin\Debug", "RQ1ML00001180", "35254087", "RQ1ML_35254087_035_IMF_After_Validate{9E87C8F6-2DC0-4271-9F52-24E935BCE7B7}.xml", "CDG_DEV_INTEGRATION@RQ1ML", "", objlogger);


            // bool bValid = false;

            if (bValid)
            {
                lblProgress.Visible = false;
                MessageBox.Show("Execution successfull");

                // Form1 frm1 = new Form1();

                //frm1.Data = oExecute.GetModifiedFile();
                //frm1.Show();

            }
            else
            {
                lblProgress.Visible = false;
                MessageBox.Show("Execution ValidationWarning");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Orc_parms = new Dictionary<string, string>();
            //Orc_parms.Add(OrcParameters.BELONGSTOPROJECT, "RQ1ML00001049");
            //Orc_parms.Add(OrcParameters.BELONGSTOPOOLPROJECT, "RQ1ML00001049");
            //Orc_parms.Add(OrcParameters.XCHANGEPROTOCOLID, "35101108");
            Orc_parms.Add(OrcParameters.SYSTEM, "CDG_DEV_INTEGRATION@RQ1ML");
            Orc_parms.Add(OrcParameters.EXCHANGEFORMAT, "RO-ASAM-DAIMLER");
            Orc_parms.Add(OrcParameters.ATTACHMENTPATH, "D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug");
            //Orc_parms.Add(OrcParameters.ISSUEFILENAME, "BMWRE600800_CP500800_20130128_182200_RQDV310.xml::InProgress||");

            //XDocument l_oIMFDoc = XDocument.Load("RQ1ML_35103420_030_IMF_Before_Validate{97B3A776-985F-40E1-9C27-10CC0530A9EB}.xml");
            Logger objlogger = new Logger("D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug\\Test.txt");


            RODataInterface l_oDataInterface = new RO_OSLC_DataInterface("CDG_DEV_INTEGRATION@RQ1ML", "RO-ASAM-DAIMLER", objlogger);
            //l_oDataInterface =
            //Factory.GetInterface((ROAvailableDataInterfaces.OSLC), Orc_parms[OrcParameters.EXCHANGEFORMAT], null, Orc_parms[OrcParameters.SYSTEM], Orc_parms[OrcParameters.ATTACHMENTPATH], null);
            //https://rb-dgsrq1-oslc-p.de.bosch.com/cqweb/oslc/repo/RQ1_PRODUCTIVE/db/RQONE/record/?oslc_cm.query=id=%22RQONE00680361%22&rcm.type=Issue&oslc_cm.properties=id,Attachments{filesize,filename,description}&rcm.contentType=application/xml
            //https://rb-dgsrq1-development.de.bosch.com:443/cqweb/oslc/repo/CDG_DEV_INTEGRATION/db/RQ1ML/record/?oslc_cm.query=hasMappedReleases.dbid="36022240" and belongsToProject="RQ1ML00026734"&rcm.type=Issue&rcm.contentType=application/xml
            //oslc_cm.query=hasMappedReleases.dbid="36022240" and belongsToProject="RQ1ML00026734"&rcm.type=Issue
            //https://rb-dgsrq1-development.de.bosch.com/cqweb/oslc/repo/CDG_DEV_INTEGRATION/db/RQ1ML/record/16777243-36023266?rcm.contentType=application/xml
            XDocument xdoc = null;

            string sUrlToInvoke = textBox1.Text;
            xdoc = InvokeURL(sUrlToInvoke);
            
            IQueryResult l_oQueryRes = new OSLC_QueryResult();
            //OSLC_QueryResult l_oQueryResult = new OSLC_QueryResult();
            l_oQueryRes.SetRaw(xdoc);
            //l_oQueryResult.DataInterface = (RODataInterface)l_oDataInterface;
            

            //IQueryResult l_oQueryResult = l_oDataInterface.Query(textBox1.Text);

            if (l_oQueryRes.RecordCount > 0)
            {
                //MessageBox.Show("Record counf >0");
                if (l_oQueryRes.RecordCount == 1)
                {
                    // MessageBox.Show("Record counf 1");
                    QueryParameters l_oParameters = new QueryParameters();
                    l_oParameters.AddComplex(OSLCComplexType.MAINRECORD, l_oQueryRes.GetRaw());
                    //MessageBox.Show("Second level query starts");
                    IQueryResult l_oQueryResultField = Query(l_oParameters,l_oDataInterface);
                    // Utilities.MessageBox.Show("Second level query results = " + l_oQueryResultField.RecordCount.ToString());

                }
            }
            xdoc = XDocument.Load(@"D:\Vidhya\ROAttachmentsinIMFFormat.XML");
            xdoc = FillLongNameinROIMFAttachments(xdoc);

            //string sQuery = "oslc_cm.query=id=%2522RQ1ML00016574%2522&rcm.type=Issue&oslc_cm.properties=id,Attachments{filesize,filename,description}";

            string sQuery = "oslc_cm.query=id=%2522RQ1ML00016574%2522&rcm.type=Issue&oslc_cm.properties=id,Domain,Scope";

            xdoc = l_oDataInterface.QueryAttachments(sQuery);
            // xdoc = XDocument.Load("ROAttachmentsinIMFFormat.xml");
            //l_oIMFDoc = XDocument.Load("RQ1ML_35103420_030_IMF_Before_Validate{97B3A776-985F-40E1-9C27-10CC0530A9EB}.xml");

            string sextattach = textBox1.Text;
            //xdoc = GetROIMFAttachments(l_oIMFDoc, xdoc, sextattach, objlogger);

            //xdoc = FillLongNameinROIMFAttachments(xdoc);

            // TestTransformation(@"D:\Vidhya\ROAttachmentsinIMFFormat.xml", @"D:\Vidhya\XSLTFileLNResolutionxslt.xslt");

        }

        public CookieContainer l_oSessionCookie = new CookieContainer();


        public void BuildQuery(string sKey, string sValue, string roRecType)
        {
            StringBuilder sQuery = null;

            if (sQuery == null)
            {
                sQuery = new StringBuilder();
                sQuery.Append("oslc_cm.query=");

                sQuery.Append(sKey);
                sQuery.Append("=");
                sQuery.Append("\"");
                sQuery.Append(sValue);
                sQuery.Append("\"");
            }
            else if (roRecType == null)
            {
                sQuery.Append(" and ");
                sQuery.Append(sKey);
                sQuery.Append("=");
                sQuery.Append("\"");
                sQuery.Append(sValue);
                sQuery.Append("\"");
            }
            else
            {
                sQuery.Append("&rcm.type=" + roRecType);
            }

        }

        public XDocument ExecuteOSLCQuery(string sQuery, bool bRecordQuery)
        {
            XDocument xResultFromCQ = null;
            string CQWebURL = "https://rb-dgsrq1-oslc-q.de.bosch.com/cqweb/oslc/repo/RQ1_ACCEPTANCE/db/RQONE/record/";
            string CQWebRecordFormat = "rcm.contentType=application/xml";
            try
            {
                string sURL = string.Empty;

                if (!bRecordQuery)
                {
                    sURL = CQWebURL + "?" + sQuery + "&" + CQWebRecordFormat;
                }
                else
                {

                    sURL = sQuery + "?" + CQWebRecordFormat;
                    sURL = sURL.Replace(":12080", "");
                }
                //MessageBox.Show("ExecuteOSLCQuery::URL : " + sURL);
                xResultFromCQ = InvokeURL(sURL);
                //Process the RSS FEED 
            }
            catch (System.Net.WebException exp) //REUBK-1610
            {
                //objlogger.LogException(exp, "ExecuteOSLCQuery::WebException");
                throw;
            }
            catch (Exception ex)
            {
                //objlogger.LogException(ex, "ExecuteOSLCQuery::InvokeURLException");
                throw;
            }
            return xResultFromCQ;
        }

        public IQueryResult Query(QueryParameters p_oQueryParameters, RODataInterface l_oDataInterface)
        {

           // MessageBox.Show("OSLC Query : starts");

            OSLC_QueryResult l_oQueryResult = new OSLC_QueryResult();
            try
            {
              string  sQuery = null;

                if (!p_oQueryParameters.IsComplex)
                {
                    foreach (var l_oParameter in p_oQueryParameters.GetRaw())
                    {
                        if (l_oParameter.Key != GlobalConstants.RECORDTYPE)
                            BuildQuery(l_oParameter.Key, l_oParameter.Value, null);
                        else
                            BuildQuery(l_oParameter.Key, null, l_oParameter.Value);
                    }

                    //MessageBox.Show("OSLC Query as follows :" + sQuery.ToString());

                    XDocument xDoc = ExecuteOSLCQuery(sQuery.ToString(), false);

                    l_oQueryResult.SetRaw(xDoc);
                }
                else
                {
                    XDocument xDoc = p_oQueryParameters.GetRawComplex()
                                     .Where(n => n.Key == OSLCComplexType.MAINRECORD)
                                     .Select(n => n.Value).Single() as XDocument;


                    if (xDoc == null) return null;


                    XDocument xResponse = GetLinkedRecord(xDoc);

                    l_oQueryResult.SetRaw(xResponse);
                }
            }
            catch (System.Net.WebException exp)
            {
                //objlogger.LogException(exp, "OSLC Query WebException");
                throw;
            }
            catch (Exception ex)
            {
                //objlogger.LogException(ex, "OSLC Query");
                throw;
            }

            //MessageBox.Show("OSLC Query : ends");

            l_oQueryResult.DataInterface = (RO_OSLC_DataInterface)l_oDataInterface;
            return l_oQueryResult;
        }

        public XNamespace nsoslc = XNamespace.Get("http://open-services.net/xmlns/cm/1.0/"); //OSLC XML Namespace
        public XNamespace nsFeed = XNamespace.Get("http://www.w3.org/1999/02/22-rdf-syntax-ns#"); //FEED XML Namespace
        public XNamespace nsAtom = XNamespace.Get("http://www.w3.org/2005/Atom"); //ATOM FEED Namespace 
        public XNamespace nsDC = XNamespace.Get("http://purl.org/dc/terms/"); // DC NameSpace   
        public XNamespace nsresults = XNamespace.Get("http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/");        


        public XDocument GetLinkedRecord(XDocument xDocFeed)
        {
            XDocument xFromCQ = null;
            string strURL = "";

            //string nsoslc = "";
            //string nsAtom = "";

            XElement xLink = xDocFeed.Descendants(nsoslc + "totalCount").Single();
            if (Convert.ToInt16(xLink.Value.ToString()) > 0)
            {
                //GetEvaluator IssueDBID
                var Entry = xDocFeed.Element(nsAtom + "feed").Element(nsAtom + "entry");
                if (Entry != null)
                {
                    var Link = Entry.Element(nsAtom + "link");
                    if (Link != null)
                    {
                        strURL = Link.Attribute("href").Value;
                        strURL = strURL + "?rcm.contentType=application/xml";
                        strURL = strURL.Replace(":12080", "");
                    }
                    else
                    {
                        strURL = "";
                    }
                }
                else
                {
                    strURL = "";
                }

                if (String.IsNullOrWhiteSpace(strURL)
                    == false)
                {
                    xFromCQ = InvokeURL(strURL);
                }
                else
                { xFromCQ = null; }
            }
            else
            { xFromCQ = null; }

            return xFromCQ;
        }
        public XDocument InvokeURL(string sUrlToInvoke)
        {

            XDocument xDoc = null;
            try
            {
                HttpWebRequest httpWebReq = WebRequest.Create(sUrlToInvoke) as HttpWebRequest;
                httpWebReq.Credentials = new NetworkCredential("nja5kor", "november@2018");
                //if (l_oSessionCookie.Count == 0)
                //{
                //    Cookie l_oCookie = new Cookie("ExProtocol", PersistenceDataManager.sExchangeProtocolId);
                //    l_oSessionCookie.Add(l_oCookie); 
                //}
                httpWebReq.CookieContainer = l_oSessionCookie;
                using (HttpWebResponse resp = httpWebReq.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    xDoc = XDocument.Load(reader);
                }

            }
            catch (System.Net.WebException exp)
            {
                //objlogger.LogException(exp, "ClearQuest::InvokeURLWebException");
                // xDoc = XDocument.Load(GlobalConstants.OSLC_DUMMY_XML); REUBK-1610
                MessageBox.Show("In webex:" + exp.Message);
            }
            catch (Exception ex)
            {
                //objlogger.LogException(ex, "ClearQuest::InvokeURLException");
                //Set dummy XML
                // xDoc = XDocument.Load(GlobalConstants.OSLC_DUMMY_XML);
                MessageBox.Show("In ex:" + ex.Message);
            }
            finally{
                var baseAddress = new Uri("https://rb-dgsrq1-development.de.bosch.com:443");
                var cookieContainer = new CookieContainer();
                var credentials = new NetworkCredential("nja5kor", "november@2018");
                using (var handler = new HttpClientHandler() { Credentials = credentials, CookieContainer = cookieContainer })
                using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
                {
                    //client.DefaultRequestHeaders.Add("x-requester", sRequesterInfo);
                    client.DeleteAsync("/cqweb/oslc/session/");
                }

            }
            //MessageBox.Show("ClearQuest::InvokeURL : ends");
            return xDoc;
        }

        public XDocument AddExternalAtt(string ROExternalAttachments, XDocument ROIMFInitial)
        {
            XDocument roimf = ROIMFInitial;
            string sXPath = "//ns0:ASAMISSUE_EXTRACT/RT_ISSUES/ISSUE";
            XElement oextattach = new XElement("EXTERNALEXCHANGEDATTACH", ROExternalAttachments);

            XmlNamespaceManager nsIMFMgr;
            nsIMFMgr = Utilities.GetIMFNameSpace(roimf);
            IEnumerable<XElement> xoKeys = roimf.Root.XPathSelectElements(sXPath, nsIMFMgr);
            foreach (XElement xElement in xoKeys)
            {
                xElement.SetElementValue("EXTERNALEXCHANGEDATTACH", ROExternalAttachments);
            }
            return roimf;
        }



        public XDocument FillLongNameinROIMFAttachments(XDocument ROIMF)
        {
            XDocument ROIMFWithLongName = new XDocument();

            try
            {
                var destination = new DomDestination();
                using (XmlWriter writer = ROIMFWithLongName.CreateWriter())
                {
                    Processor processor = new Processor();
                    string strxslMarkup = @"D:\Vidhya\XSLTFileLNResolutionxslt.xslt";
                    XdmNode input = processor.NewDocumentBuilder().Build(ROIMF.CreateReader());
                    XsltTransformer transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                    transformer.InitialContextNode = input;
                    transformer.Run(destination);
                    destination.XmlDocument.Save("D:\\Vidhya\\XSLOPLongName.xml");
                    using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                    {
                        nodeReader.MoveToContent();
                        ROIMFWithLongName = XDocument.Load(nodeReader);
                    }
                }
            }
            catch (Exception e)
            {

            }
            return ROIMFWithLongName;
        }


        public XDocument GetROIMFAttachments(XDocument ISSUEIMF, XDocument ROresult, string extattach, Logger objlogger)
        {
            XDocument ROIMF = new XDocument();
            try
            {

                var xmlResolver = new XmlUrlResolver();
                string roresult = ROresult.ToString();
                using (XmlWriter writer = ROIMF.CreateWriter())
                {
                    // Load the style sheet.
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load("CreateROIMF.xsl", new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                    xslt.Transform(ROresult.CreateReader(), writer);
                }
                ROIMF = AddExternalAtt(extattach, ROIMF);
                ROIMF = FillLongNameinROIMFAttachments(ROIMF);
            }
            catch (Exception ex)
            {

            }

            return ROIMF;
        }




        public XDocument GetROMIMFWithLongName(XDocument ROIMF)
        {
            XDocument ROIMFWithLongName = new XDocument();
            try
            {
                var xmlResolver = new XmlUrlResolver();
                string strxslMarkup = textBox2.Text;

                string sROIMF = ROIMF.ToString();
                using (XmlWriter writer = ROIMFWithLongName.CreateWriter())
                {
                    // Load the style sheet.
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(new StringReader(strxslMarkup)), new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                    //xslt.Load("CreateROIMF.xsl", new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                    xslt.Transform(ROIMF.CreateReader(), writer);
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
            return ROIMFWithLongName;

        }
        public XDocument GetIMFAttachmentsT(XDocument ISSUEIMF, XDocument ROresult, Logger objlogger)
        {
            XDocument xIssueDocument = null;

            try
            {
                XmlDocument ROresultxml = new XmlDocument();
                var xmlResolver = new XmlUrlResolver();

                using (var xmlReader = ROresult.CreateReader())
                {
                    ROresultxml.Load(xmlReader);
                }

                ROresultxml.Save("ROResult.xml");
                var myXslTrans = new XslCompiledTransform(true);

                myXslTrans.Load("CreateROIMF.xsl", new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                myXslTrans.Transform("ROResult.xml", "ROIMF.xml");

                XmlDocument roimfxml = new XmlDocument();
                roimfxml.Load("ROIMF.xml");

                using (var nodeReader = new XmlNodeReader(roimfxml))
                {
                    nodeReader.MoveToContent();
                    xIssueDocument = XDocument.Load(nodeReader);
                }
            }
            catch (Exception ex)
            {

            }
            return xIssueDocument;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //PersistenceDataManager.sExchangeProtocolId = "33724739";
            BTHelper l_oHelp = new BTHelper();
            //l_oHelp.WriteUserInformation("33724739", "Testing - NewTesting Message", true);

            MessageBox.Show("Log Completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BTHelper l_oHelper = new BTHelper();
            //MessageBox.Show(l_oHelper.GetLifeTokenString("33724739","RO-ASAM-BMW"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Encryption.EncryptString("BizTalk001","RO"));
            //textBox1.Text = Encryption.EncryptString("BizTalk001", "RO");
            //MessageBox.Show(Encryption.DecryptString("eeleH31bRAjeRFho5kqu1w==","RO"));



            string tokenStr = DateTime.Now.ToString();
            //DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + tmp_str1 + "_" + tmp_str2;11.04.2014 11.28.21 

            tokenStr = System.String.Format("{0:dd.MM.yyyy HH.mm.ss}", System.DateTime.Now);


            MessageBox.Show(tokenStr);


            string sfn = "20900_REQUESTED_20100723_132723.xml|30682_REQUESTED_20100611_135826.xml|30921_REQUESTED_20100827_131005.xml";
            string x = sfn.Replace("20900_REQUESTED_20100723_132723.xml", "Processes");
            MessageBox.Show(x);

        }

        public string GetTokenStatusForFile(string tokenStr, string filename)
        {
            string statusStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            //string pattern = filename + @"::([^\|]+)\|\|[^\|]*\|\|·";["\\s]"
            // string pattern = filename + @"::([^\ >> ]+)\|\|[^\|]*\|\|·";
            string pattern = filename + @"::([^\ >]+)\s>>([0-9a-zA-Z\.\-\s]+)<<\|\|(.*)\|\|";



            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern);
            if (match.Success)
            {
                statusStr = match.Groups[1].Value;

            }
            else
            {
                statusStr = "failure:status not found";
            }


            //Utilities.MessageBox.Show("GetTokenStatusForFile ends" + statusStr);
            return statusStr;
        }

        public string GetTokenMessageForFile(string tokenStr, string filename)
        {
            string messageStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            //string pattern = filename + @"::[^\|]+\|\|([^\|]*)\|\|,"; //REUBK-1884
            //string pattern = filename + @"::([^\ >]+)\|\|[^\|]*\|\|·";    string s = filename + @"::([^\ >]+)";//var pattern = @"^.*\( *(\d+) */ *(\d+) *\)\D*?From +(-?\d+)°C +to +(-?\d+)°C$";
            //string pattern = filename + @"::([^\ >>]+)([^\<<]+)\|\|[^\|]*\|\|·";//+([^\<]*)";([^a-zA-Z0-9]|^\s)
            // string pattern = filename + @"::[^\ >>]+[^0-9A-Za- ]+<<";  44444_REQUESTED_20110715_134552.xml::Success >>06.05.2014 20.07.35 - CQUSER<<||---Success---
            //¬Affected Records:¬ISSUE(Software) : RQ1ML00037851¬||
            ////string patternq = filename + @"::([^\ >]+)\s>>([0-9a-zA-Z\.\-\s]+)<<\|\|(.*)\|\|·";

            ////string patternw = filename + @"::([^\ >]+)\s([0-9a-zA-Z\.\-\s\>\|\<]+)\|\|(.*)\|\|·";
            ////string patternz = filename + @"::([^\ >]+)\s([0-9a-zA-Z\.\-\s\>\|\<]+)\|\|([^\|])\|\|·";

            ////string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.\|\|(.*)\|\|";
            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*)\|\|·";


            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);
            if (match.Success)
            {
                messageStr = match.Groups[3].Value;
                messageStr = match.Groups[1].Value;
                messageStr = match.Groups[2].Value;
            }
            else
            {
                messageStr = "failure:message not found";
            }

            return messageStr;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //string s = ShiftAttachments("44444_REQUESTED_20110715_134659.xml", "35677992", "D:\\RB-ASAM-Interface\\Import\\010 - TransferedFiles\\20140617-072202_CDG_DEV_INTEGRATION@RQ1ML_35677992");


            string s1 = "44444_REQUESTED_20110715_134553.xml::Failure |>06.05.2014 09.24.32 - CQUSER<|||E: Validation failed Error in RequestOne (E-0120): There is already an Issue with same ExternalID for same Project.||";
            //s1 = "44444_REQUESTED_20110715_134553.xml::Success >>06.05.2014 20.07.35 - CQUSER<<||---Success---¬Affected Records:¬ISSUE(Software) : RQ1ML00037851¬||";
            s1 = "44444_REQUESTED_20110715_134553.xml::Success >>06.05.2014 20.07.35 - CQUSER<<" + System.Environment.NewLine + "---Success---" + System.Environment.NewLine + "Affected Records:" + System.Environment.NewLine + "ISSUE(Software) : RQ1ML00037851¬||";

            //44444_REQUESTED_20110715_134552.xml::Success |>07.05.2014 07.40.32 - BizTalk<|
            //---Success---

            //Affected Records:
            //ISSUE(Software) : RQ1ML00037856
            string s2 = "44444_REQUESTED_20110715_134553.xml";
            s1 = GetTokenMessageForFile(s1, s2);

            s1 = GetTokenStatusForFile(s1, s2);
            // Utilities.MessageBox.Show("GetTokenMessageForFile ends"+messageStr);

            System.Xml.XmlDocument l_oxDoc = new System.Xml.XmlDocument();
            //// l_oxDoc.Load("30682_REQUESTED_20100611_135826.xml");
            l_oxDoc.Load("RQ1ML_33896326_030_IMF_Before_Validate{5951FA3A-77AE-44A4-B938-B41151E3CE6A}.xml");
            //RODataInterface.InterfaceConfigFile = XDocument.Load("RO-ASAM-BMW_RO_Interface_Config.xml");  
            //BTHelper l_oHelper = new BTHelper();
            //string strstate = l_oHelper.GetIssueStateForMapping(l_oxDoc);
            //string strcat = l_oHelper.GetIssueCategoryForMapping(l_oxDoc);

            ////check:

            string strType = string.Empty;
            string strDomain = string.Empty;
            string strScope = string.Empty;

            //string strBelongsToProject = string.Empty;

            XElement xIssuesNode = null;
            //= RODataInterface.InterfaceConfigFile.Element(ConfigurationFileTags.ROOT_NODE).Element(ConfigurationFileTags.REQUESTONE).Element(ConfigurationFileTags.REQUESTONE_ISSUES);
            XElement xIssueDefValue = xIssuesNode.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALS_ROOT);
            var DomainValue = from domain in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
                              where (string)domain.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.DOMAIN_NAME_VALUE
                              select domain.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
            foreach (var item in DomainValue)
            {
                strDomain = item.ToString();
            }

            var TypeValue = from typeval in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
                            where (string)typeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.TYPE_NAME_VALUE
                            select typeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
            foreach (var item in TypeValue)
            {
                strType = item.ToString();
            }

            var ScopeValue = from scopeval in xIssueDefValue.Elements(ConfigurationFileTags.ISSUES_DEF_FIELD)
                             where (string)scopeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_NAME).Value == ConfigurationFileTags.SCOPE_NAME_VALUE
                             select scopeval.Element(ConfigurationFileTags.ISSUES_DEF_FIELD_VALUE).Value;
            foreach (var item in ScopeValue)
            {
                strScope = item.ToString();
            }

            //strBelongsToProject = RODataInterface.InterfaceConfigFile.Element(ConfigurationFileTags.ROOT_NODE).Element(ConfigurationFileTags.REQUESTONE).Element(ConfigurationFileTags.PROJECTS).Element(ConfigurationFileTags.PROJECTS_PROJECT).Element(ConfigurationFileTags.PROJECT_ID).Value;
            //l_oxDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_TYPE).Value = strType;
            //l_oxDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_DOMAIN).Value = strDomain;
            //l_oxDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_SCOPE).Value = strScope;
            //l_oxDoc.Element(nsIMFMgr + IMFFileTags.ROOT_NODE).Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).Element(IMFFileTags.ISSUE_BELONGSTOPROJECT).Value = Orc_Parameters[OrcParameters.BELONGSTOPROJECT];


        }

        private void button6_Click(object sender, EventArgs e)
        {
            BTHelper l_oHelp = new BTHelper();
            Logger objlogger = new Logger("D:\\RB-ASAM-Interface\\Import\\960 - Sources\\VMA4KOR\\960 - BTImportSoftware\\Validation-Execution-Engine\\RO_TestBed\\bin\\Debug\\Test1.txt");
            l_oHelp.UpdateXPROTLog("35682752", textBox2.Text, "", "", objlogger);

            MatchCollection matchcoll = Regex.Matches(textBox2.Text, "ATTID(?'Match1'(.*))");


            l_oHelp.AddXProtForLogger("35682752", objlogger);
            l_oHelp.UnlockRecord("35682752", "RO-ASAM-AUDI", "CDG_DEV_INTEGRATION@RQ1ML", objlogger);
        }

        private void TestXml_Click(object sender, EventArgs e)
        {
            //XDocument xdoc = XDocument.Load("C:\\Users\\nja5kor\\Desktop\\Test.xml");
            try
            {
                //IEnumerable<XElement> xkeys = xdoc.Elements("VIOLATIONHANDLER").Elements("STRUCTURECHANGE").Elements("CHANGE");
                //MessageBox.Show("Done try");
                //if (xdoc.Root.Element(RulesFileTags.OPTCONDITION).Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPQUERYRESULTS) != null)
                //{
                //    if (xdoc.Root.Element(RulesFileTags.OPTCONDITION).Element(RulesFileTags.VIOLATIONHANDLER).Element(RulesFileTags.STRUCTURECHANGE).Attribute(RulesFileTags.LOOPQUERYRESULTS).Value == "TRUE")
                //    {
                //        //bLoopQueryResults = true;
                //        MessageBox.Show("bLoopQueryResults: true");
                //    }
                //}
                bool bex = true;
                MessageBox.Show("bex:" + bex);
                if(bex==true)
                {
                    MessageBox.Show("True");
                }
                else
                {
                    MessageBox.Show("False");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Entered catch:"+ex.Message);
            }
        }
        public class ROAttachment
        {
            public string NAME { get; set; }
            public string DESCRIPTION { get; set; }
            public string FULLPATH { get; set; }
            public string FULLNAME { get; set; }
            public string FILESIZE { get; set; }

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

        private void CheckMultipleCData()
        {
            XDocument xdoc = XDocument.Load(@"D:\z_Nikhila\ASAM_BMW_ValidationRuleFile.xml");
            XElement xOperand = xdoc.Root.Element("OPERAND1");
            if (xOperand.DescendantNodes().Count() > 0
                && xOperand.DescendantNodes().First().NodeType == System.Xml.XmlNodeType.CDATA)
            {
                int count = xOperand.DescendantNodes().Count();
                MessageBox.Show("Count:" + count);
               // MessageBox.Show("value:" + xOperand.Value);
                string sToReturn = "";
                foreach(XNode node in xOperand.DescendantNodes())
                {
                    string sNode = node.ToString();
                    MessageBox.Show("Node:" + sNode);
                   

                    string sOperand = Regex.Replace(sNode, "<!\\[CDATA\\[(.*?)\\]\\]>", "$1");
                    MessageBox.Show("sOperand:" + sOperand);

                    sOperand = DecodeOperandforstring(sOperand);

                    MessageBox.Show("Getting function name");
                    string[] sFunNames = sOperand.Split('(');
                    string sFunName = sFunNames[0];
                    MessageBox.Show("Function is =" + sFunName);

                    //Get parameters now
                    MessageBox.Show("Getting parameters ");
                    sOperand = sOperand.Replace(sFunName + "(", "");
                    sOperand = sOperand.Remove(sOperand.Length - 1, 1);
                    string[] Params = sOperand.Split('§');


                    List<object> l_oparams = new List<object>();
                    int iGrpPram = 0;

                    if (sFunName == "Match")
                    {
                        iGrpPram = int.Parse(Params[Params.Length - 1]);
                    }

                    foreach (object o in Params)
                    {
                        if (o.ToString().Contains("RegexOptions"))
                        {
                            System.Type l_oType = typeof(RegexOptions);
                            System.Reflection.FieldInfo l_oField = l_oType.GetField(o.ToString().Replace("RegexOptions.", ""));
                            l_oparams.Add(l_oField.GetValue(null));
                        }
                        else
                        {
                            l_oparams.Add(o);
                        }
                    }

                    MessageBox.Show("No of parameters =" + l_oparams.Count.ToString());

                    if (!(xOperand.DescendantNodes().First()==node))
                    {
                        //Output of first execution is input for next execution

                        l_oparams.Remove(l_oparams.First());
                        l_oparams.Insert(0, sToReturn);
                    }

                    Type t = typeof(System.Text.RegularExpressions.Regex);
                    MessageBox.Show("Invoking function");
                    object oResult = t.InvokeMember(sFunName, System.Reflection.BindingFlags.InvokeMethod, null, t, l_oparams.ToArray());

                    if (oResult is string || oResult is bool)
                    {
                        MessageBox.Show("String or bool result");
                        MessageBox.Show(oResult.ToString());
                        sToReturn = oResult.ToString();

                    }
                    else if (oResult is Match)
                    {
                        MessageBox.Show("Match result");
                        Match oResultm = oResult as Match;
                        if (oResultm.Success)
                        {
                            MessageBox.Show("Group " + iGrpPram.ToString());
                            MessageBox.Show(oResultm.Groups[iGrpPram].Value);
                            sToReturn = oResultm.Groups[iGrpPram].Value;
                        }
                        else
                        {
                            MessageBox.Show("NULL case1");
                            sToReturn = "NULL";
                        }
                    }
                    else
                    {
                        MessageBox.Show("NULL case2");
                        sToReturn = "NULL";
                    }



                }


                File.WriteAllText(@"D:\z_Nikhila\TestInputUpdated.txt",sToReturn);

            }
            
        }


        private string DecodeOperandforstring(string sinput)
        {
            return sinput.Replace("$RO.ExternalDescription¶", File.ReadAllText(@"D:\z_Nikhila\TestInput.txt"));
        }

        private void CheckRegexMethod()
        {
            string sOperand = File.ReadAllText(@"D:\z_Nikhila\TestInput.txt");
            string spattern = "m\\s*=>\\s*\\(m.Groups\\[([\\d])\\]\\.Value==\"(.*?)\"\\)\\?\"(.*?)\":\"(.*?)\"";
           
            

            sOperand = "Replace("+sOperand+ "§REQUIREMENT-SPEC:.*?\r\n\r\n|&amp;§RegexPattern(m\\s*=>\\s*\\(m.Groups\\[([\\d])\\]\\.Value==\"(.*?)\"\\)\\?\"(.*?)\":\"(.*?)\")§m=> (m.Groups[0].Value==\"&amp;\")?\"&\":\"\"§RegexOptions.Singleline)";
            //Get the function Name
            MessageBox.Show("Getting function name");
            string[] sFunNames = sOperand.Split('(');
            string sFunName = sFunNames[0];
            MessageBox.Show("Function is =" + sFunName);

            //Get parameters now
            MessageBox.Show("Getting parameters ");
            sOperand = sOperand.Replace(sFunName + "(", "");
            sOperand = sOperand.Remove(sOperand.Length - 1, 1);
            string[] Params = sOperand.Split('§');


            List<object> l_oparams = new List<object>();
            int iGrpPram = 0;

            if (sFunName == "Match")
            {
                iGrpPram = int.Parse(Params[Params.Length - 1]);
            }

            

            foreach (object o in Params)
            {
                if (o.ToString().Contains("RegexOptions"))
                {
                    System.Type l_oType = typeof(RegexOptions);
                    System.Reflection.FieldInfo l_oField = l_oType.GetField(o.ToString().Replace("RegexOptions.", ""));
                    l_oparams.Add(l_oField.GetValue(null));
                }
                else if (o.ToString().Contains("RegexPattern"))
                {
                    string Pattern = Regex.Replace(o.ToString(), "RegexPattern\\((.*)\\)","$1");
                    PatternForReplace = new Regex(Pattern);
                }
                //else if (Regex.IsMatch(o.ToString(),spattern))
                else if (PatternForReplace!=null && PatternForReplace.IsMatch(o.ToString()))
                {
                   // Match m = Regex.Match(o.ToString(), spattern);
                    Match m = PatternForReplace.Match(o.ToString());

                    //MessageBox.Show(m.Groups[0].Value);
                    //MessageBox.Show(m.Groups[1].Value);
                    //MessageBox.Show(m.Groups[2].Value);
                    //MessageBox.Show(m.Groups[3].Value);
                    //MessageBox.Show(m.Groups[4].Value);                  

                    foreach (Group g in m.Groups)
                    {
                        if (g.Index > 0)
                        {
                            MatchParams.Add(g.Value);
                        }
                    }                    

                    MatchEvaluator myEvaluator = new MatchEvaluator(ReplaceValues);
                    l_oparams.Add(myEvaluator);
                }
                else
                {
                    l_oparams.Add(o);
                }
            }
            MessageBox.Show("No of parameters =" + l_oparams.Count.ToString());
            

            Type t = typeof(System.Text.RegularExpressions.Regex);
            MessageBox.Show("Invoking function");
            object oResult = t.InvokeMember(sFunName, System.Reflection.BindingFlags.InvokeMethod, null, t, l_oparams.ToArray());

            if (oResult is string || oResult is bool)
            {
                MessageBox.Show("String or bool result");
                MessageBox.Show(oResult.ToString());
            }
            else if (oResult is Match)
            {
                MessageBox.Show("Match result");
                Match oResultm = oResult as Match;
                if (oResultm.Success)
                {
                    MessageBox.Show("Group " + iGrpPram.ToString());
                    MessageBox.Show(oResultm.Groups[iGrpPram].Value);
                }
                else
                {
                    MessageBox.Show("NULL case1");
                    MessageBox.Show("NULL");
                }
            }
            else
            {
                MessageBox.Show("NULL case2");
                MessageBox.Show("NULL");
            }


        }

        private string ReplaceValues(Match m)
        {
            return (m.Groups[Convert.ToInt32(MatchParams.ElementAt(0))].Value == MatchParams.ElementAt(1)) ? MatchParams.ElementAt(2) : MatchParams.ElementAt(3);
        }
       
        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                UpdateIssueInCQ();

             /*   XDocument xdocu = InvokeURL("https://rb-dgsrq1-development.de.bosch.com/cqweb/oslc/repo/CDG_DEV_INTEGRATION/db/RQ1ML/record/16777232-33680507?rcm.contentType=application/xml");

                MessageBox.Show("xdoc:" + xdocu.ToString());
                XNamespace cq = XNamespace.Get("http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/");
               string sRODesc = xdocu.Root.Element(cq + "Description").Value;
               File.WriteAllText("D:\\Temp\\Issue33680507_RODesc.txt", sRODesc);
                MessageBox.Show("RO:\n" + sRODesc);
                string sRODesc_replaced = "";
                sRODesc_replaced = sRODesc.Replace("\r\n", "$");
                sRODesc_replaced = sRODesc_replaced.Replace("\n\r", "#");
                sRODesc_replaced = sRODesc_replaced.Replace("\r", "*");
                sRODesc_replaced = sRODesc_replaced.Replace("\n", "@");

              MessageBox.Show("RO after replace:\n" + sRODesc_replaced);*/

               // XDocument xConfig = XDocument.Load(@"D:\RB-ASAM-Interface\Import\910 - BTConfigurations\RO-ASAM-DAIMLER_RO_Interface_Config.xml");
              //  string sFilterRegex = xConfig.Root.Element(ConfigurationFileTags.INTERFACE_SETTINGS).Element(ConfigurationFileTags.IMPORT_SETTINGS).Element(ConfigurationFileTags.SKIPPARALLELIMPORTS).Value;
               // MessageBox.Show("sFilterRegex:\n" + sFilterRegex);

               //// string input = @"Die &amp; Systemkonstante > < HAS_FEPM soll ersetzt &amp; werden durch die Systemkonstante BMW_FEPM_GEN_SC" + "\n" + "Test &amp; end\n" + "REQUIREMENT-SPEC:" + "Test test test \n" + "New new new \n\n" + "CALIBATATION-DATA:" + "\ndesc\n" + "TESTSPECIFICATION:\ntestspec";

               // XDocument xIMF = XDocument.Load(@"D:\\z_Nikhila\\PRODBMWtest\\Dev\\TestIMFInput.xml");

               // string sIMFExtDesc = FormatValues(xIMF.Root.Element("EXTERNALDESCRIPTION"));
               // MessageBox.Show("IMF:\n" + sIMFExtDesc);
               // File.WriteAllText("D:\\z_Nikhila\\PRODBMWtest\\Dev\\IMFExtDesc.txt", sIMFExtDesc);
               // string sIMFExtDesc_replaced = sIMFExtDesc.Replace("\r\n", "@");
               // MessageBox.Show("IMF:\n" + sIMFExtDesc_replaced);

               // if (sROExtDesc == sIMFExtDesc)
               // {
               //     MessageBox.Show("Same");

               // }
               // else
               // {
               //     MessageBox.Show("Different");
               // }

               // //sIMFExtDesc_replaced = sIMFExtDesc.Replace("\r\n", "\n");
               // File.WriteAllText("D:\\z_Nikhila\\PRODBMWtest\\Dev\\sIMFExtDesc_replaced.txt", sIMFExtDesc_replaced);
               // File.WriteAllText("D:\\z_Nikhila\\PRODBMWtest\\Dev\\sROExtDesc_replaced.txt", sROExtDesc_replaced);
               // if (sROExtDesc_replaced == sIMFExtDesc_replaced)
               // {
               //     MessageBox.Show("Same after replacement");

               // }
               // else
               // {
               //     MessageBox.Show("Different after replacement");
               // }


               // CheckMultipleCData();
                
                               
               // MessageBox.Show("End");

               // string tmp_str2 = "failure:'', hexadecimal value 0x0B, is an invalid character. Line 3, position 145.";//"failure:Invalid character in the given encoding. \n Line 58, position 29."; 
               // //"failure:'', hexadecimal value 0x0B, is an invalid character. Line 3, position 145.";
               // string tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str2, ".*failure:(.*)", "$1");
               // MessageBox.Show(tmp_str3);
               // tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str2, ".*?,(.*)", "$1");

               // tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str3, @".*(invalid character.*)", "$1", RegexOptions.IgnoreCase);

               //// string tmp_str3 = System.Text.RegularExpressions.Regex.Match(tmp_str2, ".*failure:([^,]+).*").Value;

               // System.Text.RegularExpressions.Regex.Replace(tmp_str2, ".*failure:([^,]+).*", "$1");
               // MessageBox.Show(tmp_str3);

               // if (Regex.IsMatch(tmp_str2, ".*invalid character.*", RegexOptions.Singleline | RegexOptions.IgnoreCase))
               // {
               //     MessageBox.Show("Match found");

               // }
               

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }          

        }


        public void UpdateIssueInCQ()
        {
            Session roSession = new Session();
            try
            {
                
                //roSession.UserLogon("BizTalk", "bt4dev01", "RQ1ML", GlobalConstants.CQ_AD_PRIVATE_SESSION, "CDG_DEV_INTEGRATION");
                roSession.UserLogon("nja5kor_DA", "nikhila135", "RQ1ML", GlobalConstants.CQ_AD_PRIVATE_SESSION, "CDG_DEV_INTEGRATION");
                IOAdEntity l_oEntity = roSession.LoadEntityByDbId("Issuereleasemap", 38999229);   //Issue 33681204
                //if (l_oEntity.IsEditable())
                {
                    MessageBox.Show("Calling Edit Entity");
                    roSession.EditEntity(l_oEntity, "Modify");

                    MessageBox.Show("After Edit Entity, start set value");
                    l_oEntity.SetFieldValue("Description", "Test");

                    MessageBox.Show("After set value, start validate");
                    string sError = l_oEntity.Validate();

                    MessageBox.Show("After validate:"+sError);

                    if (string.IsNullOrEmpty(sError))
                    {
                        sError = l_oEntity.Commit();

                        MessageBox.Show("After Commit:" + sError);
                    }
                    //else 
                    //{
                    //    MessageBox.Show("Error during validate:"+sError);
                    //}
                    

                }
               // else
                {
                   // MessageBox.Show("Entity not editable");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                roSession.SignOff();
            }

            MessageBox.Show("End");
        }

        



    }
}
