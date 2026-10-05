namespace RO_TestBed
{
    partial class frmMain
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
            this.btnLogger = new System.Windows.Forms.Button();
            this.cmdValidation = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.TestXml = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogger
            // 
            this.btnLogger.Location = new System.Drawing.Point(55, 33);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(143, 23);
            this.btnLogger.TabIndex = 0;
            this.btnLogger.Text = "Check Logger Class";
            this.btnLogger.UseVisualStyleBackColor = true;
            this.btnLogger.Click += new System.EventHandler(this.btnLogger_Click);
            // 
            // cmdValidation
            // 
            this.cmdValidation.Location = new System.Drawing.Point(55, 75);
            this.cmdValidation.Name = "cmdValidation";
            this.cmdValidation.Size = new System.Drawing.Size(143, 23);
            this.cmdValidation.TabIndex = 1;
            this.cmdValidation.Text = "Check ValidationWarning";
            this.cmdValidation.UseVisualStyleBackColor = true;
            this.cmdValidation.Click += new System.EventHandler(this.cmdValidation_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(52, 114);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(215, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "ValidationWarning in progress please wait ...";
            this.lblProgress.Visible = false;
            // 
            // cmdExecute
            // 
            this.cmdExecute.Location = new System.Drawing.Point(235, 33);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(133, 23);
            this.cmdExecute.TabIndex = 3;
            this.cmdExecute.Text = "Execute";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 16);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "LogError";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "GetLifeToken";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(287, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "TestRestart";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TestXml
            // 
            this.TestXml.Location = new System.Drawing.Point(25, 152);
            this.TestXml.Name = "TestXml";
            this.TestXml.Size = new System.Drawing.Size(75, 23);
            this.TestXml.TabIndex = 12;
            this.TestXml.Text = "TestXml";
            this.TestXml.UseVisualStyleBackColor = true;
            this.TestXml.Click += new System.EventHandler(this.TestXml_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(367, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 194);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.TestXml);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdExecute);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.cmdValidation);
            this.Controls.Add(this.btnLogger);
            this.Name = "frmMain";
            this.Text = "Test form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogger;
        private System.Windows.Forms.Button cmdValidation;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button cmdExecute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button TestXml;
        private System.Windows.Forms.Button button7;
    }
}

