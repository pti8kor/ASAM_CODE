namespace RO_TestBed
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.txtConfiguration = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIMF = new System.Windows.Forms.TextBox();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.lblIMF = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.radAudi = new System.Windows.Forms.RadioButton();
            this.radBMW = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProjectNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExchangeProtocol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttachmentsPath = new System.Windows.Forms.TextBox();
            this.cmdStartTest = new System.Windows.Forms.Button();
            this.chkValidateOnly = new System.Windows.Forms.CheckBox();
            this.grpFiles.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lblIMF);
            this.grpFiles.Controls.Add(this.lblConfiguration);
            this.grpFiles.Controls.Add(this.button1);
            this.grpFiles.Controls.Add(this.txtIMF);
            this.grpFiles.Controls.Add(this.cmdBrowse);
            this.grpFiles.Controls.Add(this.txtConfiguration);
            this.grpFiles.Location = new System.Drawing.Point(19, 23);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(892, 113);
            this.grpFiles.TabIndex = 0;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files Selection";
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // txtConfiguration
            // 
            this.txtConfiguration.Location = new System.Drawing.Point(122, 32);
            this.txtConfiguration.Name = "txtConfiguration";
            this.txtConfiguration.Size = new System.Drawing.Size(658, 20);
            this.txtConfiguration.TabIndex = 0;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(786, 32);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(94, 20);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtIMF
            // 
            this.txtIMF.Location = new System.Drawing.Point(122, 71);
            this.txtIMF.Name = "txtIMF";
            this.txtIMF.Size = new System.Drawing.Size(658, 20);
            this.txtIMF.TabIndex = 2;
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Location = new System.Drawing.Point(10, 34);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(69, 13);
            this.lblConfiguration.TabIndex = 4;
            this.lblConfiguration.Text = "Configuration";
            // 
            // lblIMF
            // 
            this.lblIMF.AutoSize = true;
            this.lblIMF.Location = new System.Drawing.Point(18, 70);
            this.lblIMF.Name = "lblIMF";
            this.lblIMF.Size = new System.Drawing.Size(25, 13);
            this.lblIMF.TabIndex = 5;
            this.lblIMF.Text = "IMF";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.chkValidateOnly);
            this.grpCustomer.Controls.Add(this.radBMW);
            this.grpCustomer.Controls.Add(this.radAudi);
            this.grpCustomer.Location = new System.Drawing.Point(24, 142);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(887, 69);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // radAudi
            // 
            this.radAudi.AutoSize = true;
            this.radAudi.Checked = true;
            this.radAudi.Location = new System.Drawing.Point(17, 32);
            this.radAudi.Name = "radAudi";
            this.radAudi.Size = new System.Drawing.Size(46, 17);
            this.radAudi.TabIndex = 0;
            this.radAudi.TabStop = true;
            this.radAudi.Text = "Audi";
            this.radAudi.UseVisualStyleBackColor = true;
            // 
            // radBMW
            // 
            this.radBMW.AutoSize = true;
            this.radBMW.Location = new System.Drawing.Point(69, 32);
            this.radBMW.Name = "radBMW";
            this.radBMW.Size = new System.Drawing.Size(52, 17);
            this.radBMW.TabIndex = 1;
            this.radBMW.Text = "BMW";
            this.radBMW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAttachmentsPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExchangeProtocol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProjectNumber);
            this.groupBox1.Location = new System.Drawing.Point(24, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Details";
            // 
            // txtProjectNumber
            // 
            this.txtProjectNumber.Location = new System.Drawing.Point(117, 30);
            this.txtProjectNumber.Name = "txtProjectNumber";
            this.txtProjectNumber.Size = new System.Drawing.Size(339, 20);
            this.txtProjectNumber.TabIndex = 0;
            this.txtProjectNumber.Text = "RQ1D00006296";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "XChangeProtocol";
            // 
            // txtExchangeProtocol
            // 
            this.txtExchangeProtocol.Location = new System.Drawing.Point(117, 56);
            this.txtExchangeProtocol.Name = "txtExchangeProtocol";
            this.txtExchangeProtocol.Size = new System.Drawing.Size(339, 20);
            this.txtExchangeProtocol.TabIndex = 6;
            this.txtExchangeProtocol.Text = "33735448";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Attachment Path";
            // 
            // txtAttachmentsPath
            // 
            this.txtAttachmentsPath.Location = new System.Drawing.Point(117, 82);
            this.txtAttachmentsPath.Name = "txtAttachmentsPath";
            this.txtAttachmentsPath.Size = new System.Drawing.Size(758, 20);
            this.txtAttachmentsPath.TabIndex = 8;
            this.txtAttachmentsPath.Text = "D:\\\\Supreet\\\\versions\\\\4.4_Work\\\\Source\\\\ro_TestBed\\\\bin\\\\debug";
            // 
            // cmdStartTest
            // 
            this.cmdStartTest.Location = new System.Drawing.Point(360, 349);
            this.cmdStartTest.Name = "cmdStartTest";
            this.cmdStartTest.Size = new System.Drawing.Size(120, 28);
            this.cmdStartTest.TabIndex = 3;
            this.cmdStartTest.Text = "Start Test";
            this.cmdStartTest.UseVisualStyleBackColor = true;
            this.cmdStartTest.Click += new System.EventHandler(this.cmdStartTest_Click);
            // 
            // chkValidateOnly
            // 
            this.chkValidateOnly.AutoSize = true;
            this.chkValidateOnly.Location = new System.Drawing.Point(146, 32);
            this.chkValidateOnly.Name = "chkValidateOnly";
            this.chkValidateOnly.Size = new System.Drawing.Size(88, 17);
            this.chkValidateOnly.TabIndex = 2;
            this.chkValidateOnly.Text = "Validate Only";
            this.chkValidateOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkValidateOnly.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 393);
            this.Controls.Add(this.cmdStartTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpFiles);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Label lblIMF;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIMF;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TextBox txtConfiguration;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.RadioButton radBMW;
        private System.Windows.Forms.RadioButton radAudi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttachmentsPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExchangeProtocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectNumber;
        private System.Windows.Forms.CheckBox chkValidateOnly;
        private System.Windows.Forms.Button cmdStartTest;
    }
}