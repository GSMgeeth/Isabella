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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBagTabControl = new System.Windows.Forms.TabControl();
            this.receivedTab = new System.Windows.Forms.TabPage();
            this.receivedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.DeptCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receivedItemDataGridView = new System.Windows.Forms.DataGridView();
            this.receivedBagDataGridView = new System.Windows.Forms.DataGridView();
            this.issuedTab = new System.Windows.Forms.TabPage();
            this.issuedItemDataGridView = new System.Windows.Forms.DataGridView();
            this.issuedBagDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.AddDataPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchBagTabControl.SuspendLayout();
            this.receivedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBagDataGridView)).BeginInit();
            this.issuedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuedItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBagDataGridView)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.searchBagTabControl);
            this.panel2.Location = new System.Drawing.Point(291, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 540);
            this.panel2.TabIndex = 8;
            // 
            // searchBagTabControl
            // 
            this.searchBagTabControl.Controls.Add(this.receivedTab);
            this.searchBagTabControl.Controls.Add(this.issuedTab);
            this.searchBagTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBagTabControl.Location = new System.Drawing.Point(4, 17);
            this.searchBagTabControl.Name = "searchBagTabControl";
            this.searchBagTabControl.SelectedIndex = 0;
            this.searchBagTabControl.Size = new System.Drawing.Size(886, 520);
            this.searchBagTabControl.TabIndex = 0;
            // 
            // receivedTab
            // 
            this.receivedTab.Controls.Add(this.receivedDatePicker);
            this.receivedTab.Controls.Add(this.resetButton);
            this.receivedTab.Controls.Add(this.searchButton);
            this.receivedTab.Controls.Add(this.DeptCmb);
            this.receivedTab.Controls.Add(this.label3);
            this.receivedTab.Controls.Add(this.receivedItemDataGridView);
            this.receivedTab.Controls.Add(this.receivedBagDataGridView);
            this.receivedTab.Location = new System.Drawing.Point(4, 38);
            this.receivedTab.Name = "receivedTab";
            this.receivedTab.Padding = new System.Windows.Forms.Padding(3);
            this.receivedTab.Size = new System.Drawing.Size(878, 478);
            this.receivedTab.TabIndex = 0;
            this.receivedTab.Text = "Received";
            this.receivedTab.UseVisualStyleBackColor = true;
            // 
            // receivedDatePicker
            // 
            this.receivedDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDatePicker.Location = new System.Drawing.Point(442, 11);
            this.receivedDatePicker.Name = "receivedDatePicker";
            this.receivedDatePicker.Size = new System.Drawing.Size(287, 27);
            this.receivedDatePicker.TabIndex = 6;
            this.receivedDatePicker.ValueChanged += new System.EventHandler(this.receivedDatePicker_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(795, 9);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(77, 28);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(298, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 28);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DeptCmb
            // 
            this.DeptCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCmb.FormattingEnabled = true;
            this.DeptCmb.ItemHeight = 20;
            this.DeptCmb.Location = new System.Drawing.Point(120, 11);
            this.DeptCmb.Name = "DeptCmb";
            this.DeptCmb.Size = new System.Drawing.Size(159, 28);
            this.DeptCmb.TabIndex = 3;
            this.DeptCmb.Text = "All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search By:";
            // 
            // receivedItemDataGridView
            // 
            this.receivedItemDataGridView.AllowUserToAddRows = false;
            this.receivedItemDataGridView.AllowUserToDeleteRows = false;
            this.receivedItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receivedItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receivedItemDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.receivedItemDataGridView.Location = new System.Drawing.Point(547, 70);
            this.receivedItemDataGridView.Name = "receivedItemDataGridView";
            this.receivedItemDataGridView.ReadOnly = true;
            this.receivedItemDataGridView.RowTemplate.Height = 24;
            this.receivedItemDataGridView.Size = new System.Drawing.Size(325, 402);
            this.receivedItemDataGridView.TabIndex = 1;
            // 
            // receivedBagDataGridView
            // 
            this.receivedBagDataGridView.AllowUserToAddRows = false;
            this.receivedBagDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedBagDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.receivedBagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receivedBagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receivedBagDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.receivedBagDataGridView.Location = new System.Drawing.Point(7, 70);
            this.receivedBagDataGridView.Name = "receivedBagDataGridView";
            this.receivedBagDataGridView.ReadOnly = true;
            this.receivedBagDataGridView.RowTemplate.Height = 24;
            this.receivedBagDataGridView.Size = new System.Drawing.Size(534, 402);
            this.receivedBagDataGridView.TabIndex = 0;
            this.receivedBagDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.receivedBagDataGridView_RowHeaderMouseClick);
            this.receivedBagDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.receivedBagDataGridView_RowHeaderMouseDoubleClick);
            // 
            // issuedTab
            // 
            this.issuedTab.Controls.Add(this.issuedItemDataGridView);
            this.issuedTab.Controls.Add(this.issuedBagDataGridView);
            this.issuedTab.Location = new System.Drawing.Point(4, 38);
            this.issuedTab.Name = "issuedTab";
            this.issuedTab.Padding = new System.Windows.Forms.Padding(3);
            this.issuedTab.Size = new System.Drawing.Size(878, 478);
            this.issuedTab.TabIndex = 1;
            this.issuedTab.Text = "Issued";
            this.issuedTab.UseVisualStyleBackColor = true;
            // 
            // issuedItemDataGridView
            // 
            this.issuedItemDataGridView.AllowUserToAddRows = false;
            this.issuedItemDataGridView.AllowUserToDeleteRows = false;
            this.issuedItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuedItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.issuedItemDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.issuedItemDataGridView.Location = new System.Drawing.Point(546, 70);
            this.issuedItemDataGridView.Name = "issuedItemDataGridView";
            this.issuedItemDataGridView.ReadOnly = true;
            this.issuedItemDataGridView.RowTemplate.Height = 24;
            this.issuedItemDataGridView.Size = new System.Drawing.Size(325, 402);
            this.issuedItemDataGridView.TabIndex = 3;
            // 
            // issuedBagDataGridView
            // 
            this.issuedBagDataGridView.AllowUserToAddRows = false;
            this.issuedBagDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBagDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.issuedBagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuedBagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.issuedBagDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.issuedBagDataGridView.Location = new System.Drawing.Point(6, 70);
            this.issuedBagDataGridView.Name = "issuedBagDataGridView";
            this.issuedBagDataGridView.ReadOnly = true;
            this.issuedBagDataGridView.RowTemplate.Height = 24;
            this.issuedBagDataGridView.Size = new System.Drawing.Size(534, 402);
            this.issuedBagDataGridView.TabIndex = 2;
            this.issuedBagDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.issuedBagDataGridView_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1196, 654);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.GenReportButton);
            this.Controls.Add(this.SearchBagButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddDataPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Isabella";
            this.Load += new System.EventHandler(this.Isabella_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddDataPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.searchBagTabControl.ResumeLayout(false);
            this.receivedTab.ResumeLayout(false);
            this.receivedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBagDataGridView)).EndInit();
            this.issuedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuedItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBagDataGridView)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl searchBagTabControl;
        private System.Windows.Forms.TabPage receivedTab;
        private System.Windows.Forms.TabPage issuedTab;
        private System.Windows.Forms.DataGridView receivedBagDataGridView;
        private System.Windows.Forms.DataGridView receivedItemDataGridView;
        private System.Windows.Forms.DataGridView issuedItemDataGridView;
        private System.Windows.Forms.DataGridView issuedBagDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeptCmb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DateTimePicker receivedDatePicker;
    }
}

