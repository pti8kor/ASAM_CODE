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
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Xsl;
using Saxon.Api;

namespace RB.ROCustomerIntefaceLibrary
{

    public class ROAttachment
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string FULLPATH { get; set; }
        public string FULLNAME { get; set; }
        public string FILESIZE { get; set; }

    }

    public class IMFROCommonAttachments
    {
        public string IMFATTNAME { get; set; }
        public string IMFATTDESCRIPTION { get; set; }
        public string IMFATTFILESIZE { get; set; }
        //public string IMFTRUNCATTNAME { get; set; }
        public string ROATTNAME { get; set; }
        public string ROATTTRUNCNAME { get; set; }
        public string ROATTDESCRIPTION { get; set; }
        public string ROATTFILESIZE { get; set; }

    }
    public class AttachmentHandler
    {

        //REUBK-2136
        [NonSerialized()]

        private List<int> l_oTruncIds = new List<int>();
        List<ROAttachment> l_oROAttachments = new List<ROAttachment>();



        public void LoadUnImportedAttachments(List<IMFROCommonAttachments> l_oCommonAttachments, string issueid, Logger objlogger)
        {
            //objlogger.LogInfo("Inside LoadUnImportedAttachments");
            if (l_oCommonAttachments.Count > 0)
            {
                objlogger.LogInfo("LoadUnImportedAttachments-issueid" + issueid, GlobalConstants.LOGGERLEVEL1);
                //objlogger.LogInfo("l_oCommonAttachments-Count" + l_oCommonAttachments.Count.ToString());

                int icount = 0;


                foreach (IMFROCommonAttachments att in l_oCommonAttachments)
                {
                    icount++;
                    XDocument xatt = new XDocument();


                    var decl = new XDeclaration("1.0", "utf-8", "no");
                    xatt.Declaration = decl;
                    objlogger.LogInfo("inside  LoadUnImportedAttachments--1", GlobalConstants.LOGGERLEVEL2);

                    //XNamespace ns0 = @"http://RB.BT.ROBinaryComparison.BinaryCompare";
                    XNamespace ns0 = @"http://RB.BT.ROBinaryComparison.BinaryCompare";


                    XElement srcTree = new XElement(ns0 + "BinaryComparison");
                    xatt.Add(srcTree);


                    objlogger.LogInfo("inside  LoadUnImportedAttachments--add ns", GlobalConstants.LOGGERLEVEL2);
                    xatt.Root.Add(new XAttribute(XNamespace.Xmlns + "ns0", ns0));
                    objlogger.LogInfo("inside  LoadUnImportedAttachments--2", GlobalConstants.LOGGERLEVEL2);

                    xatt.Root.Add(new XElement("RQ1System", ""));
                    xatt.Root.Add(new XElement("InterfaceName", ""));
                    xatt.Root.Add(new XElement("XProtID", ""));
                    xatt.Root.Add(new XElement("DownloadTargetPath", ""));
                    xatt.Root.Add(new XElement("ASAMFileName", ""));

                    xatt.Root.Add(new XElement("ORGFileName", att.IMFATTNAME));
                    //xatt.Root.Add(new XElement("ORGTruncFileName", att.IMFTRUNCATTNAME));
                    xatt.Root.Add(new XElement("ORGFileSize", att.IMFATTFILESIZE));
                    xatt.Root.Add(new XElement("IssueID", issueid));
                    xatt.Root.Add(new XElement("RQ1FileName", att.ROATTNAME));
                    xatt.Root.Add(new XElement("RQ1TruncFileName", att.ROATTTRUNCNAME));
                    xatt.Root.Add(new XElement("RQ1FileSize", att.ROATTFILESIZE));
                    xatt.Root.Add(new XElement("RQ1FileDescription", att.ROATTDESCRIPTION));
                    xatt.Root.Add(new XElement("BinaryComparisonStatus", ""));
                    objlogger.LogInfo("XATTACHMENT=" + xatt.ToString(), GlobalConstants.LOGGERLEVEL2);


                    //XmlNamespaceManager nsMgr;
                    ////nsMgr = Utilities.GetBinCompareNameSpace(xatt);

                    //XmlReader xReader = xatt.CreateReader();
                    //XmlNameTable xNameTable = xReader.NameTable;
                    //nsMgr = new XmlNamespaceManager(xNameTable);
                    //nsMgr.AddNamespace("ns0", GlobalConstants.BIN_COMPARE_URI);



                    IMFManager oimfmgr = new IMFManager(null, objlogger);
                    //objlogger.LogInfo("add   skipped attachment--" + icount.ToString());
                    objlogger.LogInfo("add skipped attachment:" + icount.ToString() + "_" + PersistenceDataStores.UNIMPORTEDATTACHMENTS, GlobalConstants.LOGGERLEVEL1);
                    oimfmgr.WriteToIsolatedStorageTest(issueid, icount.ToString() + "_" + PersistenceDataStores.UNIMPORTEDATTACHMENTS, xatt.ToString(), objlogger);
                }
            }
        }

        private void LoadTruncIDList(List<ROAttachment> lstROAttachments, Logger objlogger)
        {
            //objlogger.LogInfo("inside LoadTruncIDList");
            string[] arrnames = new string[2];

            string filebody, fileExtender;
            int ivalue = 0;
            objlogger.LogInfo("inside LoadTruncIDList - lstROAttachments count" + lstROAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
            try
            {
                foreach (ROAttachment roatt in lstROAttachments)
                {
                    objlogger.LogInfo("roatt name:" + roatt.NAME + "  utf8Length:" + Utilities.utf8Length(roatt.NAME).ToString(), GlobalConstants.LOGGERLEVEL1);
                    //objlogger.LogInfo("roatt name Contains" + roatt.NAME.Contains('~').ToString());
                    //objlogger.LogInfo("roatt name utf8Length" + Utilities.utf8Length(roatt.NAME).ToString());

                    if (roatt.NAME.Contains('~') && Utilities.utf8Length(roatt.NAME) >= 49) //REUBK-2330
                    {
                        filebody = System.Text.RegularExpressions.Regex.Replace(roatt.NAME, "(.+)\\.\\w*?$", "$1");
                        fileExtender = System.Text.RegularExpressions.Regex.Replace(roatt.NAME, ".+(\\.\\w*?)$", "$1");

                        arrnames = filebody.Split('~');
                        //take out only inetger value in arrnames[1]                     
                        bool canConvert = int.TryParse(arrnames[1], out ivalue); //check string after ~ is an integer
                        //objlogger.LogInfo("ivalue" + ivalue);
                        if (canConvert == true)
                        {
                            objlogger.LogInfo("add trunc id " + ivalue, GlobalConstants.LOGGERLEVEL2);
                            l_oTruncIds.Add(ivalue);
                        }
                        else
                        {
                            //arrnames[1 is not a valid int"
                        }
                    }
                }

                //foreach (int o in l_oTruncIds)
                //{
                //    objlogger.LogInfo("in trucid foreach");
                //    objlogger.LogInfo(o.ToString());
                //}



            }
            catch (Exception ex)
            {

            }
        }

        private int GetNextAvailableTruncCount()
        {
            int iavailablecount = 1;
            if (l_oTruncIds.Count > 0)
            {
                iavailablecount = Enumerable.Range(1, Int32.MaxValue).Except(l_oTruncIds).First();
            }
            return iavailablecount;
        }

        public string GetIssueID(XDocument IssueIMF)
        {
            string sIssueID = string.Empty;
            try
            {
                sIssueID = IssueIMF.Root.Element(IMFFileTags.RT_ISSUE)
                        .Element(IMFFileTags.ISSUE).Element(IMFFileTags.ID).Value.ToString();

            }
            catch (Exception ex)
            {
                sIssueID = null;
            }
            return sIssueID;
        }

        public XDocument GetROIMFAttachments(XDocument ISSUEIMF, XDocument ROresult, string sextattach, string sROIMFXSLPath, string sxslLongResPath, Logger objlogger)
        {
            XDocument xdocROIMF = new XDocument();
            try
            {
                objlogger.LogInfo("Inside GetROIMFAttachments", GlobalConstants.LOGGERLEVEL1);
                var xmlResolver = new XmlUrlResolver();
                string roresult = ROresult.ToString();
                using (XmlWriter writer = xdocROIMF.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    //xslt.Load("CreateROIMF.xsl", new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                    xslt.Load(sROIMFXSLPath, new XsltSettings { EnableDocumentFunction = true }, xmlResolver);
                    xslt.Transform(ROresult.CreateReader(), writer);
                }
                xdocROIMF = AddExternalAtt(sextattach, xdocROIMF, objlogger);
                xdocROIMF = FillLongNameinROIMFAttachments(xdocROIMF, sxslLongResPath, objlogger);
                l_oROAttachments = GetAttachmentsList(xdocROIMF, objlogger);
                LoadTruncIDList(l_oROAttachments, objlogger);
                objlogger.LogInfo("End GetROIMFAttachments", GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in AddExternalAtt" + ex.Message);
            }
            return xdocROIMF;
        }

        public XDocument AddExternalAtt(string ROExternalAttachments, XDocument ROIMFInitial, Logger objlogger)
        {
            XDocument xdocROIMF = ROIMFInitial;
            try
            {
                objlogger.LogInfo("Inside AddExternalAtt", GlobalConstants.LOGGERLEVEL1);
                string sXPath = "//ns0:ASAMISSUE_EXTRACT/RT_ISSUES/ISSUE";
                XElement oextattach = new XElement("EXTERNALEXCHANGEDATTACH", ROExternalAttachments);

                XmlNamespaceManager nsIMFMgr;
                nsIMFMgr = Utilities.GetIMFNameSpace(xdocROIMF);

                ROExternalAttachments = ROExternalAttachments.Replace("\r\n", "*");
                objlogger.LogInfo("ROExternalAttachments after replace rn :" + ROExternalAttachments, GlobalConstants.LOGGERLEVEL2);

                //added to match &#10; used in exporter
                ROExternalAttachments = ROExternalAttachments.Replace("\n", "*");
                objlogger.LogInfo("ROExternalAttachments after replace n :" + ROExternalAttachments, GlobalConstants.LOGGERLEVEL2);

                ROExternalAttachments = ROExternalAttachments.Replace("**", "*");

                IEnumerable<XElement> xoKeys = xdocROIMF.Root.XPathSelectElements(sXPath, nsIMFMgr);
                foreach (XElement xElement in xoKeys)
                {
                    xElement.SetElementValue("EXTERNALEXCHANGEDATTACH", ROExternalAttachments);
                }

                objlogger.LogInfo("ROExternalAttachments:" + ROExternalAttachments, GlobalConstants.LOGGERLEVEL1);
                //objlogger.LogInfo("End AddExternalAtt");
            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in AddExternalAtt" + ex.Message);

            }
            return xdocROIMF;
        }

        public XDocument FillLongNameinROIMFAttachments(XDocument ROIMF, string sxslLongResPath, Logger objlogger)
        {
            XDocument ROIMFWithLongName = new XDocument();

            try
            {
                objlogger.LogInfo("Inside FillLongNameinROIMFAttachments", GlobalConstants.LOGGERLEVEL1);
                var destination = new DomDestination();

                Processor processor = new Processor();
                //string strxslMarkup = @"D:\Vidhya\XSLTFileLNResolutionxslt.xslt";
                string strxslMarkup = sxslLongResPath;
                XdmNode input = processor.NewDocumentBuilder().Build(ROIMF.CreateReader());
                XsltTransformer transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                transformer.InitialContextNode = input;

                transformer.Run(destination);
                using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                {
                    nodeReader.MoveToContent();
                    ROIMFWithLongName = XDocument.Load(nodeReader);
                }
                //objlogger.LogInfo("End FillLongNameinROIMFAttachments");
            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in FillLongNameinROIMFAttachments" + ex.Message);

            }
            objlogger.LogInfo("End FillLongNameinROIMFAttachments:ROIMFWithLongName= " + ROIMFWithLongName.ToString(), GlobalConstants.LOGGERLEVEL1);
            return ROIMFWithLongName;
        }

        public List<ROAttachment> GetAttachmentsList(XDocument xdoc, Logger objlogger)
        {
            objlogger.LogInfo("inside GetAttachmentsList", GlobalConstants.LOGGERLEVEL1);
            XElement xattachments = xdoc.Root.Elements(IMFFileTags.RT_ISSUE).Elements(IMFFileTags.ISSUE)
                  .Elements(IMFFileTags.ATTACHEMENTS).Single();

            List<ROAttachment> l_oAttachments = new List<ROAttachment>();

            l_oAttachments = xattachments.Elements(IMFFileTags.ATTACHMENT)
                .Where(x => x.Element(IMFFileTags.ATTACHMENT_NAME).Value != string.Empty)
                .Select(n => new ROAttachment
                {
                    NAME = n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                    FULLNAME = n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                    DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,
                    FILESIZE = n.Element(IMFFileTags.ATTACHMENT_FILESIZE).Value,

                })
                  .ToList<ROAttachment>();
            //l_oAttachments = l_oAttachments.GroupBy(i => i.NAME, (key, group) => group.First()).ToList<ROAttachment>(); //no need to group bcoz unique elemenst are prsent after mapping for iMF
            objlogger.LogInfo("l_oAttachments loaded" + l_oAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

            //objlogger.LogInfo("end GetAttachmentsList");
            return l_oAttachments;

        }

        public List<ROAttachment> GetInitialIMFAttachmentsList(XDocument xdoc, Logger objlogger)
        {
            objlogger.LogInfo("inside GetInitialIMFAttachmentsList", GlobalConstants.LOGGERLEVEL1);
            XElement xattachments = xdoc.Root.Elements(IMFFileTags.RT_ISSUE).Elements(IMFFileTags.ISSUE)
                  .Elements(IMFFileTags.ATTACHEMENTS).Single();

            List<ROAttachment> l_oAttachments = new List<ROAttachment>();

            l_oAttachments = xattachments.Elements(IMFFileTags.ATTACHMENT)
                .Where(x => x.Element(IMFFileTags.ATTACHMENT_NAME).Value != string.Empty)
                .Select(n => new ROAttachment
                {
                    NAME = n.Element(IMFFileTags.ATTACHMENT_NAME).Value,
                    FULLNAME = n.Element(IMFFileTags.ATTACHMENT_FULLNAME).Value,
                    DESCRIPTION = n.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value,

                })
                  .ToList<ROAttachment>();
            l_oAttachments = l_oAttachments.GroupBy(i => i.NAME, (key, group) => group.First()).ToList<ROAttachment>();
            objlogger.LogInfo("IMFttachments loaded" + l_oAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL1);

           // objlogger.LogInfo("end GetInitialIMFAttachmentsList");
            return l_oAttachments;

        }

        public List<ROAttachment> GetROCompliments(XDocument ROIMF, XDocument IMF, string XSLPath, Logger objlogger)
        {
            objlogger.LogInfo("inside GetROCompliments", GlobalConstants.LOGGERLEVEL1);
            List<ROAttachment> l_oCOAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oROAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oIMFAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oROAttachmentsComp = new List<ROAttachment>();
            
            try
            {              

                l_oROAttachments = GetAttachmentsList(ROIMF, objlogger);
                l_oIMFAttachments = GetAttachmentsList(IMF, objlogger);

                objlogger.LogInfo("l_oROAttachments count=" + l_oROAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL2);
                objlogger.LogInfo("lstIMFAtt count=" + l_oIMFAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL2);            

                l_oCOAttachments = l_oROAttachments.Where(f => !(l_oIMFAttachments.Any(b => (b.FULLNAME == f.FULLNAME && b.FILESIZE == f.FILESIZE)))).ToList<ROAttachment>();

                objlogger.LogInfo("l_oCOAttachments count=" + l_oCOAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL2);


                if (l_oCOAttachments.Count > 0)
                {

                    //objlogger.LogInfo("framing xROIMFComp");
                    XDocument xROIMFComp = new XDocument(ROIMF);
                    // xROIMFComp.Root.Element("RT-ISSUES").Element("ISSUE").Element("ATTACHMENTS").Elements("ATTACHMENT").Where(f => (l_oCOAttachments.Any(b => (b.FULLNAME == f.Element("FULLNAME").Value && b.FILESIZE == f.Element("SIZE").Value)))).Remove();
                    xROIMFComp.Descendants("ATTACHMENT").Where(f => !(l_oCOAttachments.Any(b => (b.FULLNAME == f.Element("FULL_NAME").Value && b.FILESIZE == f.Element("SIZE").Value)))).Remove();

                    objlogger.LogInfo("framing xROIMFComp=" + xROIMFComp.ToString(), GlobalConstants.LOGGERLEVEL1);

                    XDocument xdocWithDescChanged = new XDocument();
                    var destination = new DomDestination();

                    Processor processor = new Processor();
                    string strxslMarkup = XSLPath;
                    XdmNode input = processor.NewDocumentBuilder().Build(xROIMFComp.CreateReader());
                    XsltTransformer transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                    transformer.InitialContextNode = input;

                    transformer.Run(destination);
                    using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                    {
                        nodeReader.MoveToContent();
                        xdocWithDescChanged = XDocument.Load(nodeReader);
                    }

                    objlogger.LogInfo("After xsl transform", GlobalConstants.LOGGERLEVEL1);
                    l_oROAttachmentsComp = GetAttachmentsList(xdocWithDescChanged, objlogger);
                }
                else
                {
                    objlogger.LogInfo("No results for intersection", GlobalConstants.LOGGERLEVEL1);
                }

                //objlogger.LogInfo("inside GetROCompliments-l_oROAttachmentsComp count=" + l_oROAttachmentsComp.Count.ToString());

            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in GetROCompliments" + ex.Message);
            }
            return l_oROAttachmentsComp;
        }

        public List<ROAttachment> GetROIMFIntersection(XDocument ROIMF, XDocument IMF, string XSLPath, Logger objlogger)
        {
            List<ROAttachment> l_oINAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oIMFAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oROAttachments = new List<ROAttachment>();
            List<ROAttachment> l_oROAttachmentsInt = new List<ROAttachment>();

            objlogger.LogInfo("inside GetROIMFIntersection", GlobalConstants.LOGGERLEVEL1);
            try
            {

                l_oROAttachments = GetAttachmentsList(ROIMF, objlogger);
                l_oIMFAttachments = GetAttachmentsList(IMF, objlogger);

                l_oINAttachments = l_oROAttachments.Where(f => (l_oIMFAttachments.Any(b => (b.FULLNAME == f.FULLNAME && b.FILESIZE == f.FILESIZE)))).ToList<ROAttachment>();

                objlogger.LogInfo("inside GetROIMFIntersection-l_oINAttachments count=" + l_oINAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
                if (l_oINAttachments.Count > 0)
                {
                    //objlogger.LogInfo("Framing xROIMFInt");
                    XDocument xROIMFInt = new XDocument(ROIMF);
                    //objlogger.LogInfo("xROIMFInt=" + xROIMFInt.ToString());
                    xROIMFInt.Descendants("ATTACHMENTS").Elements("ATTACHMENT").Where(f => !(l_oINAttachments.Any(b => (b.FULLNAME == f.Element("FULL_NAME").Value && b.FILESIZE == f.Element("SIZE").Value)))).Remove();


                    objlogger.LogInfo("Framing xROIMFInt=" + xROIMFInt.ToString(), GlobalConstants.LOGGERLEVEL1);

                    XDocument xdocWithDescChanged = new XDocument();
                    var destination = new DomDestination();
                    Processor processor = new Processor();
                    string strxslMarkup = XSLPath;
                    XdmNode input = processor.NewDocumentBuilder().Build(xROIMFInt.CreateReader());
                    XsltTransformer transformer = processor.NewXsltCompiler().Compile(new Uri(strxslMarkup)).Load();
                    transformer.InitialContextNode = input;

                    transformer.Run(destination);
                    using (var nodeReader = new XmlNodeReader(destination.XmlDocument))
                    {
                        nodeReader.MoveToContent();
                        xdocWithDescChanged = XDocument.Load(nodeReader);
                    }
                    objlogger.LogInfo("After xsl transform", GlobalConstants.LOGGERLEVEL1);
                    l_oROAttachmentsInt = GetAttachmentsList(xdocWithDescChanged, objlogger);
                }
                else
                {
                    objlogger.LogInfo("No results for intersection", GlobalConstants.LOGGERLEVEL1);
                }

               // objlogger.LogInfo("inside GetROIMFIntersection-l_oROAttachmentsInt count=" + l_oROAttachmentsInt.Count.ToString());

            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in GetROIMFIntersection" + ex.Message);
            }
            return l_oROAttachmentsInt;
        }


        public XDocument AddROAttachmentsToIMF(XDocument IssueIMF, List<ROAttachment> lstRO, string sOperator, Logger objlogger)
        {
            try
            {

                objlogger.LogInfo("inside AddROAttachmentsToIMF", GlobalConstants.LOGGERLEVEL1);
                List<XElement> lstATTACHMENTS = new List<XElement>();
                XElement IMFAttachments = IssueIMF.Root.Elements("RT_ISSUES").Elements("ISSUE")
                                         .Elements("ATTACHMENTS").Single();
                
                if (sOperator.ToUpper() == RulesFileTags.ADD)
                {
                    objlogger.LogInfo("Inside ADD", GlobalConstants.LOGGERLEVEL1);
                    foreach (ROAttachment roatt in lstRO)
                    {
                        XElement xattach = new XElement("ATTACHMENT");
                        xattach.Add(new XElement("NAME", roatt.NAME), new XElement("DESCRIPTION", roatt.DESCRIPTION), new XElement("FULL_NAME", roatt.FULLNAME), new XElement("SIZE", roatt.FILESIZE));

                        //set ignore to NAME - so only desc change is reqd for attachment
                        XAttribute xattr = new XAttribute("ACTION", "IGNORE");
                        xattach.Element("NAME").Add(xattr);
                        xattach.Element("FULL_NAME").Add(xattr);

                        //lstATTACHMENTS.Add(xattach);
                        IMFAttachments.Add(xattach);
                    }
                }
                else if (sOperator.ToUpper() == RulesFileTags.REPLACE)
                {
                    objlogger.LogInfo("Inside REPLACE", GlobalConstants.LOGGERLEVEL1);
                    foreach (ROAttachment roatt in lstRO)
                    {
                        XElement xattach = IMFAttachments.Elements("ATTACHMENT").Where(f => (f.Element("FULL_NAME").Value == roatt.FULLNAME && f.Element("SIZE").Value == roatt.FILESIZE)).Single();
                       
                        if (xattach != null)
                        {
                            objlogger.LogInfo("roatt:" + roatt.FULLNAME, GlobalConstants.LOGGERLEVEL1);
                            xattach.Element("DESCRIPTION").SetValue(roatt.DESCRIPTION);
                            //set ignore to NAME - so only desc change is reqd for attachment
                            XAttribute xattr = new XAttribute("ACTION", "IGNORE");
                            xattach.Element("NAME").Add(xattr);
                            xattach.Element("FULL_NAME").Add(xattr);
                        }
                       
                    }
                }
                else
                {
                    //no handling
                }

               /* if (IMFAttachments.Elements().Count() > 0)
                {
                    foreach (XElement element in lstATTACHMENTS)
                    {
                        IMFAttachments.Add(element);
                    }
                } */

                //objlogger.LogInfo("AddROAttachmentsToIMF -att in IMF= " + IMFAttachments.Elements().Count().ToString());
                
                //only for log - attachments in imf after element rules
                objlogger.LogInfo("imf att after element rules" + IMFAttachments.Elements().ToString(), GlobalConstants.LOGGERLEVEL1);
                //objlogger.LogInfo("imf after element rules" + IssueIMF.ToString());

            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in AddROAttachmentsToIMF" + ex.Message);
            }
            return IssueIMF;

        }
        public XDocument GetTruncNameInIMF(XDocument IssueIMF, Logger objlogger)
        {
            try
            {
                objlogger.LogInfo("inside GetTruncNameInIMF", GlobalConstants.LOGGERLEVEL1);

                IEnumerable<XElement> xAttachments = from xAttachment in IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).
                                                                 Element(IMFFileTags.ATTACHEMENTS).Elements(IMFFileTags.ATTACHMENT).Where(f => !(f.Element(IMFFileTags.ATTACHMENT_NAME).HasAttributes || f.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes))
                                                     select xAttachment;

                foreach (XElement xattachment in xAttachments)
                {
                    //objlogger.LogInfo("inside imfattachment");
                    string strname = xattachment.Element(IMFFileTags.ATTACHMENT_NAME).Value;
                    string strnewname = string.Empty;
                    int truncid = 0;
                    //if (Utilities.utf8Length(strname) > 50)
                    if (Utilities.utf8Length(strname) > GlobalConstants.MAX_ATTNAMELENGTH)
                    {
                        objlogger.LogInfo("--name-- truncate--" + strname, GlobalConstants.LOGGERLEVEL2);
                        truncid = GetNextAvailableTruncCount();
                        //objlogger.LogInfo("--truncid=--" + truncid.ToString());
                        //add to list to consider for next available trunc id
                        if (!l_oTruncIds.Contains(truncid))
                        {
                            l_oTruncIds.Add(truncid);
                        }
                        strnewname = Utilities.ReduceChar(Utilities.utf8Trunc(strname), truncid);
                        objlogger.LogInfo("--strnewname--" + strnewname, GlobalConstants.LOGGERLEVEL1);
                        xattachment.Element(IMFFileTags.ATTACHMENT_NAME).Value = strnewname;
                    }
                }
            }
            catch (Exception ex)
            {
                objlogger.LogException("Exception in GetTruncNameInIMF" + ex.Message);
            }

            return IssueIMF;

        }

        public XDocument ReNumberATTID(XDocument IssueIMF, Logger objlogger)
        {
            objlogger.LogInfo("inside ReNumberATTID", GlobalConstants.LOGGERLEVEL1);
            IEnumerable<XElement> xAttachments = from xAttachment in IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).
                                                                Element(IMFFileTags.ATTACHEMENTS).Elements(IMFFileTags.ATTACHMENT).Where(f => !(f.Element(IMFFileTags.ATTACHMENT_NAME).HasAttributes || f.Element(IMFFileTags.ATTACHMENT_FULLNAME).HasAttributes))
                                                 select xAttachment;

            IEnumerable<XElement> xExtAttachments = from xAttachment in IssueIMF.Root.Element(IMFFileTags.RT_ISSUE).Element(IMFFileTags.ISSUE).
                                                              Element(IMFFileTags.EXTERNALEXCHANGEDATTACH).Elements()
                                                    select xAttachment;


            int iAttachCount = 0;
            int iExtAttachCount = 0;
            objlogger.LogInfo("ReNumberATTID in Attachments", GlobalConstants.LOGGERLEVEL2);
            foreach (XElement xattachment in xAttachments)
            {
                if (xattachment.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value.Contains("ATT"))
                {
                    objlogger.LogInfo("Re writing descriptions", GlobalConstants.LOGGERLEVEL2);
                    iAttachCount++;
                    string sDescription = xattachment.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value;
                    sDescription = Utilities.LoadATTID(sDescription, iAttachCount);
                    sDescription = sDescription.Trim();                   
                    objlogger.LogInfo(string.Format("Attachment Description value is - {0} ", sDescription), GlobalConstants.LOGGERLEVEL2);
                    xattachment.Element(IMFFileTags.ATTACHMENT_DESCRIPTION).Value = sDescription;
                }
            }

            objlogger.LogInfo("ReNumberATTID in xExtAttachments", GlobalConstants.LOGGERLEVEL2);
            foreach (XElement pnode in xExtAttachments)
            {
                string sptagvalue = pnode.Value;
                if (pnode.Value.Contains("ATT"))
                {
                    objlogger.LogInfo("Re writing xExtAttachment", GlobalConstants.LOGGERLEVEL2);
                    iExtAttachCount++;
                    sptagvalue = Utilities.LoadATTID(sptagvalue, iExtAttachCount);
                }
                pnode.Value = sptagvalue;
            }
            return IssueIMF;
        }

        public void LoadSkippedAttachments(XDocument IssueIMF, XDocument ROIMF, Logger objlogger)
        {
            objlogger.LogInfo("Inside LoadSkippedAttachments", GlobalConstants.LOGGERLEVEL1);
            List<ROAttachment> l_oROAttch = GetAttachmentsList(ROIMF, objlogger);
            List<ROAttachment> l_oIMFAttach = GetAttachmentsList(IssueIMF, objlogger);

            List<IMFROCommonAttachments> lstcommonAttachments = new List<IMFROCommonAttachments>();


            foreach (ROAttachment roatt in l_oROAttch)
            {
                int count = (from f in l_oIMFAttach
                             where f.FULLNAME == roatt.FULLNAME &&
                             f.FILESIZE == roatt.FILESIZE
                             select new IMFROCommonAttachments
                             {
                                 IMFATTNAME = f.FULLNAME,
                                 IMFATTDESCRIPTION = f.DESCRIPTION,
                                 IMFATTFILESIZE = f.FILESIZE,
                                 //IMFTRUNCATTNAME = f.NAME,
                                 ROATTNAME = roatt.FULLNAME,
                                 ROATTTRUNCNAME = roatt.NAME,
                                 ROATTFILESIZE = roatt.FILESIZE,
                                 ROATTDESCRIPTION = roatt.DESCRIPTION,
                             }).Count();
                objlogger.LogInfo("Inside LoadSkippedAttachments -count" + count.ToString(), GlobalConstants.LOGGERLEVEL1);
                if (count > 0)
                {
                    IMFROCommonAttachments attcommon = (from f in l_oIMFAttach
                                                        where f.FULLNAME == roatt.FULLNAME &&
                                                        f.FILESIZE == roatt.FILESIZE
                                                        select new IMFROCommonAttachments
                                                        {
                                                            IMFATTNAME = f.FULLNAME,
                                                            IMFATTDESCRIPTION = f.DESCRIPTION,
                                                            IMFATTFILESIZE = f.FILESIZE,
                                                            //IMFTRUNCATTNAME = f.NAME,
                                                            ROATTNAME = roatt.FULLNAME,
                                                            ROATTTRUNCNAME = roatt.NAME,
                                                            ROATTFILESIZE = roatt.FILESIZE,
                                                            ROATTDESCRIPTION = roatt.DESCRIPTION,
                                                        }).Single();
                    //objlogger.LogInfo("add to lstcommonAttachments");
                    lstcommonAttachments.Add(attcommon);
                }

            }
            objlogger.LogInfo("Inside LoadSkippedAttachments -lstcommonAttachments" + lstcommonAttachments.Count.ToString(), GlobalConstants.LOGGERLEVEL1);
            LoadUnImportedAttachments(lstcommonAttachments, GetIssueID(IssueIMF), objlogger);
        }

    }
}
