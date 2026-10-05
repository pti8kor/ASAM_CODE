using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RB.ROCustomerIntefaceLibrary;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Xml.Linq;


namespace RO_TestBed
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void cmdStartTest_Click(object sender, EventArgs e)
        {
            //RODataInterface.InterfaceName = "RO-ASAM-AUDI";

            System.Xml.XmlDocument l_oxDoc = new System.Xml.XmlDocument();
            l_oxDoc.Load(txtIMF.Text);
            //RODataInterface.InterfaceConfigFile
                //= XDocument.Load(txtConfiguration.Text);

            BTHelper l_oHelper = new BTHelper();
           // bool bValid = l_oHelper.ValidateIMF(l_oxDoc, "RO-ASAM-AUDI"
            //    ,txtAttachmentsPath.Text,txtProjectNumber.Text,txtExchangeProtocol.Text,, "ADUDI_11_01.xml::In Work||||");

           // bValid = l_oHelper.Execute(l_oxDoc, "RO-ASAM-AUDI", "D:\\Supreet\\versions\\4.4_Work\\Source\\ro_TestBed\\bin\\debug", "RQ1D00006296", "33735448", "ADUDI_11_01.xml");


            //if (bValid)
            //{
            //   MessageBox.Show("Execution successfull");

            //}
            //else
            //{
            //    MessageBox.Show("Execution ValidationWarning");
            //}
        }
    }
}
