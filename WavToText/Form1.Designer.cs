namespace WavToText
{
    partial class Form1
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
            this.m_lblWavFileLocaltion = new System.Windows.Forms.Label();
            this.m_txtBoxWavFileURL = new System.Windows.Forms.TextBox();
            this.m_btnSelectFile = new System.Windows.Forms.Button();
            this.m_txtBoxLoopTime = new System.Windows.Forms.TextBox();
            this.m_lblLoopTime = new System.Windows.Forms.Label();
            this.m_txtBoxWriteToTextURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblLanguage = new System.Windows.Forms.Label();
            this.m_cmbxLanguage = new System.Windows.Forms.ComboBox();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_lblWavFileLocaltion
            // 
            this.m_lblWavFileLocaltion.AutoSize = true;
            this.m_lblWavFileLocaltion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblWavFileLocaltion.Location = new System.Drawing.Point(30, 34);
            this.m_lblWavFileLocaltion.Name = "m_lblWavFileLocaltion";
            this.m_lblWavFileLocaltion.Size = new System.Drawing.Size(236, 21);
            this.m_lblWavFileLocaltion.TabIndex = 0;
            this.m_lblWavFileLocaltion.Text = "Read from wave file location(url)";
            // 
            // m_txtBoxWavFileURL
            // 
            this.m_txtBoxWavFileURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtBoxWavFileURL.Location = new System.Drawing.Point(33, 58);
            this.m_txtBoxWavFileURL.Multiline = true;
            this.m_txtBoxWavFileURL.Name = "m_txtBoxWavFileURL";
            this.m_txtBoxWavFileURL.Size = new System.Drawing.Size(281, 64);
            this.m_txtBoxWavFileURL.TabIndex = 1;
            // 
            // m_btnSelectFile
            // 
            this.m_btnSelectFile.Location = new System.Drawing.Point(320, 75);
            this.m_btnSelectFile.Name = "m_btnSelectFile";
            this.m_btnSelectFile.Size = new System.Drawing.Size(75, 30);
            this.m_btnSelectFile.TabIndex = 2;
            this.m_btnSelectFile.Text = "...";
            this.m_btnSelectFile.UseVisualStyleBackColor = true;
            this.m_btnSelectFile.Click += new System.EventHandler(this.m_btnSelectFile_Click);
            // 
            // m_txtBoxLoopTime
            // 
            this.m_txtBoxLoopTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_txtBoxLoopTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtBoxLoopTime.Location = new System.Drawing.Point(33, 149);
            this.m_txtBoxLoopTime.Name = "m_txtBoxLoopTime";
            this.m_txtBoxLoopTime.Size = new System.Drawing.Size(281, 29);
            this.m_txtBoxLoopTime.TabIndex = 4;
            this.m_txtBoxLoopTime.Text = "5";
            // 
            // m_lblLoopTime
            // 
            this.m_lblLoopTime.AutoSize = true;
            this.m_lblLoopTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblLoopTime.Location = new System.Drawing.Point(30, 125);
            this.m_lblLoopTime.Name = "m_lblLoopTime";
            this.m_lblLoopTime.Size = new System.Drawing.Size(228, 21);
            this.m_lblLoopTime.TabIndex = 3;
            this.m_lblLoopTime.Text = "Read wav file loop time(sec/10)";
            // 
            // m_txtBoxWriteToTextURL
            // 
            this.m_txtBoxWriteToTextURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtBoxWriteToTextURL.Location = new System.Drawing.Point(33, 220);
            this.m_txtBoxWriteToTextURL.Multiline = true;
            this.m_txtBoxWriteToTextURL.Name = "m_txtBoxWriteToTextURL";
            this.m_txtBoxWriteToTextURL.Size = new System.Drawing.Size(281, 62);
            this.m_txtBoxWriteToTextURL.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Write to text file location(url)";
            // 
            // m_lblLanguage
            // 
            this.m_lblLanguage.AutoSize = true;
            this.m_lblLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblLanguage.Location = new System.Drawing.Point(30, 295);
            this.m_lblLanguage.Name = "m_lblLanguage";
            this.m_lblLanguage.Size = new System.Drawing.Size(78, 21);
            this.m_lblLanguage.TabIndex = 7;
            this.m_lblLanguage.Text = "Language";
            // 
            // m_cmbxLanguage
            // 
            this.m_cmbxLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmbxLanguage.FormattingEnabled = true;
            this.m_cmbxLanguage.Items.AddRange(new object[] {
            "Chinese (China)",
            "Chinese (Taiwan)",
            "English (United Kingdom)",
            "English (United States)",
            "French (France)",
            "German (Germany)",
            "Japanese (Japan)",
            "Spanish (Spain)"});
            this.m_cmbxLanguage.Location = new System.Drawing.Point(34, 325);
            this.m_cmbxLanguage.Name = "m_cmbxLanguage";
            this.m_cmbxLanguage.Size = new System.Drawing.Size(280, 29);
            this.m_cmbxLanguage.Sorted = true;
            this.m_cmbxLanguage.TabIndex = 0;
            this.m_cmbxLanguage.SelectedIndexChanged += new System.EventHandler(this.m_cmbxLanguage_SelectedIndexChanged);
            // 
            // m_btnSave
            // 
            this.m_btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnSave.Location = new System.Drawing.Point(320, 398);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(75, 30);
            this.m_btnSave.TabIndex = 9;
            this.m_btnSave.Text = "Ok";
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.m_btnSave);
            this.Controls.Add(this.m_cmbxLanguage);
            this.Controls.Add(this.m_lblLanguage);
            this.Controls.Add(this.m_txtBoxWriteToTextURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_txtBoxLoopTime);
            this.Controls.Add(this.m_lblLoopTime);
            this.Controls.Add(this.m_btnSelectFile);
            this.Controls.Add(this.m_txtBoxWavFileURL);
            this.Controls.Add(this.m_lblWavFileLocaltion);
            this.Name = "Form1";
            this.Text = " Speech-To-Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lblWavFileLocaltion;
        private System.Windows.Forms.TextBox m_txtBoxWavFileURL;
        private System.Windows.Forms.Button m_btnSelectFile;
        private System.Windows.Forms.TextBox m_txtBoxLoopTime;
        private System.Windows.Forms.Label m_lblLoopTime;
        private System.Windows.Forms.TextBox m_txtBoxWriteToTextURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lblLanguage;
        private System.Windows.Forms.ComboBox m_cmbxLanguage;
        private System.Windows.Forms.Button m_btnSave;
    }
}

