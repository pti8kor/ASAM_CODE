using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearQuestOleServer;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using RB.ROCustomerIntefaceLibrary;

namespace TestBinaryComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CQUser { get; set; }
        public string CQPasword { get; set; }
        public string CQRepo { get; set; }
        public string CQDB { get; set; }
        public string CQWebURL { get; set; }
        public string CQOSLCServer { get; set; }
        public string CQWebRecordFormat { get; set; }
        public string CQOSLCCOREVersion { get; set; }
        public string RODownloadPath { get; set; }
        string ROAttachmentPath = "D:\\ASAM-IF-IMPORT\\Import\\090 - TemporaryFiles\\BINARYCOMPARISON\\";
        public int CQ_AD_PRIVATE_SESSION = 2;

        Session roSession = new Session();

        private void button1_Click(object sender, EventArgs e)
        {
            bool isMatch = false;
            DirectoryInfo di = new DirectoryInfo("D:\\ASAM-IF-IMPORT\\Import\\070 - BinaryComparisonInput");
            FileInfo[] rgFiles = di.GetFiles("*.xml");
            foreach (FileInfo fi in rgFiles)
            {
                XDocument BinCompareDoc = XDocument.Load(fi.FullName);
                string IMFdownloadpath = BinCompareDoc.Root.Element("DownloadTargetPath").Value;
                string IMFfilename = BinCompareDoc.Root.Element("ORGFileName").Value;
                string RQ1TruncFileName = BinCompareDoc.Root.Element("RQ1TruncFileName").Value;
                string IssueID = BinCompareDoc.Root.Element("IssueID").Value;

                IMFdownloadpath = IMFdownloadpath + IMFfilename;
                RODownloadPath = ROAttachmentPath + RQ1TruncFileName;

                bool bIsAttLoaded = LoadROAttachments(IssueID, RQ1TruncFileName);
                if (bIsAttLoaded && !(string.IsNullOrEmpty(RODownloadPath)))
                {
                    isMatch = FileEquals(IMFdownloadpath, RODownloadPath);
                    if (isMatch)
                    {
                        MessageBox.Show("Files are Equal");
                    }
                    else
                    {
                        MessageBox.Show("Files are UnEqual");
                    }
                }
            }
        }


        public bool LoadROAttachments(string IssueID, string ROATTFileName)
        {
           // setParams();
            if (!LoggedIn) LoginToRequestOne();
            bool bIsSuccess = true;
            QueryParameters l_oQueryParams = new QueryParameters();
            l_oQueryParams.Add("ENTITY", "ISSUE");
            l_oQueryParams.Add("ID", IssueID);
            //l_oQueryParams.AddComplex("ENTITYOBJECT", l_oEntity);
            //l_oEntity = l_oQueryParams.GetRawComplex()["ENTITYOBJECT"] as IOAdEntity;


            IOAdEntity l_oEntity = null;
            string sEntity = l_oQueryParams["ENTITY"];

            //l_oEntity = roSession.LoadEntityByDbId(sEntity, int.Parse(IssueID.Trim()));     
            l_oEntity = roSession.GetEntity(sEntity, IssueID);

            IOAdAttachmentFields l_oAttachmentsFields = l_oEntity.AttachmentFields;
            IOAdAttachmentField l_oAttachmentField = null;

            for (int i = 0; i < l_oAttachmentsFields.Count; i++)
            {
                IOAdAttachmentField l_oAttac = l_oAttachmentsFields.item(i);

                if (l_oAttac.fieldname.ToUpper() == "ATTACHMENTS")
                {
                    l_oAttachmentField = l_oAttac;
                    break;
                }
            }
            if (l_oAttachmentField == null) return false;

            //if (l_oAttachmentField == null) return "";
            IOAdAttachments l_oAttachments = l_oAttachmentField.Attachments;

            for (int iattach = 0; iattach < l_oAttachments.Count; iattach++)
            {
                IOAdAttachment l_oAttachment = l_oAttachments.item(iattach);

                if (l_oAttachment.filename.ToString() == ROATTFileName)
                {
                    bIsSuccess = l_oAttachment.Load(RODownloadPath);
                    break;
                }
                if (bIsSuccess == false)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }

            return bIsSuccess;
        }
        public bool FileEquals(string fileName1, string fileName2)
        {
            // Check the file size and CRC equality here.. if they are equal...    
            using (var file1 = new FileStream(fileName1, FileMode.Open))
            using (var file2 = new FileStream(fileName2, FileMode.Open))
                return StreamEquals(file1, file2);
        }

        public bool StreamEquals(Stream stream1, Stream stream2)
        {
            const int bufferSize = 2048;
            byte[] buffer1 = new byte[bufferSize]; //buffer size
            byte[] buffer2 = new byte[bufferSize];
            while (true)
            {
                int count1 = stream1.Read(buffer1, 0, bufferSize);
                int count2 = stream2.Read(buffer2, 0, bufferSize);

                if (count1 != count2)
                    return false;

                if (count1 == 0)
                    return true;

                // You might replace the following with an efficient "memcmp"
                //if (!buffer1.Take(count1).SequenceEqual(buffer2.Take(count2)))
                //    return false;

                int iterations = (int)Math.Ceiling((double)count1 / sizeof(Int64));
                for (int i = 0; i < iterations; i++)
                {

                    if (BitConverter.ToInt64(buffer1, i * sizeof(Int64)) != BitConverter.ToInt64(buffer2, i * sizeof(Int64)))
                    {
                        return false;
                    }
                }
                List<string> org = new List<string>();
            }
        }

        public bool LoggedIn
        {
            get;
            set;
        }

        public bool LoginToRequestOne()
        {


            this.CQUser = this.CQUser ?? "";
            this.CQPasword = this.CQPasword ?? "";
            this.CQRepo = this.CQRepo ?? "";
            this.CQDB = this.CQDB ?? "";



            bool isLoggedOn = true;


            if (string.IsNullOrWhiteSpace(this.CQUser)
                || (string.IsNullOrWhiteSpace(this.CQRepo)) || (string.IsNullOrWhiteSpace(this.CQDB)))
            {
                //throw new CQLoginExcption();
            }
            else
            {
                for (int intCount = 1; intCount <= 4; intCount++)
                {
                    try
                    {
                        roSession.UserLogon(this.CQUser, this.CQPasword, this.CQDB, this.CQ_AD_PRIVATE_SESSION, this.CQRepo);
                        break;
                    }
                    catch (System.Runtime.InteropServices.COMException ComExp)
                    {
                        if (intCount > 3)
                        {
                            isLoggedOn = false;
                            throw ComExp;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                LoggedIn = true;
            }
            return isLoggedOn;
        }

       
    }
}
