namespace Isabella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.SearchBagButton = new System.Windows.Forms.Button();
            this.GenReportButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.AddDataPanel = new System.Windows.Forms.Panel();
            this.DataTextBox = new System.Windows.Forms.RichTextBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.AddDataPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(467, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isabella (pvt) Ltd.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(423, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiving and Issueing of bags recorder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 82);
            this.panel1.TabIndex = 2;
            // 
            // AddDataButton
            // 
            this.AddDataButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDataButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataButton.ForeColor = System.Drawing.Color.Black;
            this.AddDataButton.Location = new System.Drawing.Point(13, 101);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(266, 56);
            this.AddDataButton.TabIndex = 3;
            this.AddDataButton.Text = "Add Data File";
            this.AddDataButton.UseVisualStyleBackColor = false;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // SearchBagButton
            // 
            this.SearchBagButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBagButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBagButton.ForeColor = System.Drawing.Color.Black;
            this.SearchBagButton.Location = new System.Drawing.Point(13, 164);
            this.SearchBagButton.Name = "SearchBagButton";
            this.SearchBagButton.Size = new System.Drawing.Size(266, 56);
            this.SearchBagButton.TabIndex = 4;
            this.SearchBagButton.Text = "Search Bags";
            this.SearchBagButton.UseVisualStyleBackColor = false;
            this.SearchBagButton.Click += new System.EventHandler(this.SearchBagButton_Click);
            // 
            // GenReportButton
            // 
            this.GenReportButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GenReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenReportButton.ForeColor = System.Drawing.Color.Black;
            this.GenReportButton.Location = new System.Drawing.Point(12, 226);
            this.GenReportButton.Name = "GenReportButton";
            this.GenReportButton.Size = new System.Drawing.Size(266, 56);
            this.GenReportButton.TabIndex = 5;
            this.GenReportButton.Text = "Generate Report";
            this.GenReportButton.UseVisualStyleBackColor = false;
            this.GenReportButton.Click += new System.EventHandler(this.GenReportButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.ForeColor = System.Drawing.Color.Black;
            this.ConfigButton.Location = new System.Drawing.Point(13, 288);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(266, 56);
            this.ConfigButton.TabIndex = 6;
            this.ConfigButton.Text = "Configure";
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // AddDataPanel
            // 
            this.AddDataPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddDataPanel.Controls.Add(this.DataTextBox);
            this.AddDataPanel.Controls.Add(this.AddFileButton);
            this.AddDataPanel.Location = new System.Drawing.Point(291, 102);
            this.AddDataPanel.Name = "AddDataPanel";
            this.AddDataPanel.Size = new System.Drawing.Size(893, 540);
            this.AddDataPanel.TabIndex = 7;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(117, 230);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(676, 250);
            this.DataTextBox.TabIndex = 2;
            this.DataTextBox.Text = "";
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(370, 16);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(123, 27);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 350);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 292);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(257, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(291, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 540);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1196, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.GenReportButton);
            this.Controls.Add(this.SearchBagButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddDataPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Isabella";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddDataPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button SearchBagButton;
        private System.Windows.Forms.Button GenReportButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Panel AddDataPanel;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox DataTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
    }
}

