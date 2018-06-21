namespace Isabella
{
    partial class ReportForm
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
            this.ReportTabControl = new System.Windows.Forms.TabControl();
            this.receivedReportTab = new System.Windows.Forms.TabPage();
            this.BalanceSelectedMonth = new System.Windows.Forms.Button();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AllSelectedMonth = new System.Windows.Forms.Button();
            this.issuedReportTab = new System.Windows.Forms.TabPage();
            this.dateTimePickerIssued = new System.Windows.Forms.DateTimePicker();
            this.IssuedSelectedMonth = new System.Windows.Forms.Button();
            this.ReportTabControl.SuspendLayout();
            this.receivedReportTab.SuspendLayout();
            this.issuedReportTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportTabControl
            // 
            this.ReportTabControl.Controls.Add(this.receivedReportTab);
            this.ReportTabControl.Controls.Add(this.issuedReportTab);
            this.ReportTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTabControl.Location = new System.Drawing.Point(1, 1);
            this.ReportTabControl.Name = "ReportTabControl";
            this.ReportTabControl.SelectedIndex = 0;
            this.ReportTabControl.Size = new System.Drawing.Size(797, 448);
            this.ReportTabControl.TabIndex = 0;
            // 
            // receivedReportTab
            // 
            this.receivedReportTab.BackColor = System.Drawing.Color.LightGray;
            this.receivedReportTab.Controls.Add(this.BalanceSelectedMonth);
            this.receivedReportTab.Controls.Add(this.reportDatePicker);
            this.receivedReportTab.Controls.Add(this.AllSelectedMonth);
            this.receivedReportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedReportTab.Location = new System.Drawing.Point(4, 29);
            this.receivedReportTab.Name = "receivedReportTab";
            this.receivedReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.receivedReportTab.Size = new System.Drawing.Size(789, 415);
            this.receivedReportTab.TabIndex = 0;
            this.receivedReportTab.Text = "Received Bags";
            // 
            // BalanceSelectedMonth
            // 
            this.BalanceSelectedMonth.Location = new System.Drawing.Point(374, 30);
            this.BalanceSelectedMonth.Name = "BalanceSelectedMonth";
            this.BalanceSelectedMonth.Size = new System.Drawing.Size(98, 30);
            this.BalanceSelectedMonth.TabIndex = 9;
            this.BalanceSelectedMonth.Text = "Balance";
            this.BalanceSelectedMonth.UseVisualStyleBackColor = true;
            this.BalanceSelectedMonth.Click += new System.EventHandler(this.BalanceSelectedMonth_Click);
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDatePicker.Location = new System.Drawing.Point(7, 30);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(299, 27);
            this.reportDatePicker.TabIndex = 7;
            // 
            // AllSelectedMonth
            // 
            this.AllSelectedMonth.Location = new System.Drawing.Point(312, 30);
            this.AllSelectedMonth.Name = "AllSelectedMonth";
            this.AllSelectedMonth.Size = new System.Drawing.Size(56, 30);
            this.AllSelectedMonth.TabIndex = 0;
            this.AllSelectedMonth.Text = "All";
            this.AllSelectedMonth.UseVisualStyleBackColor = true;
            this.AllSelectedMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // issuedReportTab
            // 
            this.issuedReportTab.BackColor = System.Drawing.Color.LightGray;
            this.issuedReportTab.Controls.Add(this.dateTimePickerIssued);
            this.issuedReportTab.Controls.Add(this.IssuedSelectedMonth);
            this.issuedReportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedReportTab.Location = new System.Drawing.Point(4, 29);
            this.issuedReportTab.Name = "issuedReportTab";
            this.issuedReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.issuedReportTab.Size = new System.Drawing.Size(789, 415);
            this.issuedReportTab.TabIndex = 1;
            this.issuedReportTab.Text = "Issued Bags";
            // 
            // dateTimePickerIssued
            // 
            this.dateTimePickerIssued.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssued.Location = new System.Drawing.Point(7, 47);
            this.dateTimePickerIssued.Name = "dateTimePickerIssued";
            this.dateTimePickerIssued.Size = new System.Drawing.Size(299, 27);
            this.dateTimePickerIssued.TabIndex = 10;
            // 
            // IssuedSelectedMonth
            // 
            this.IssuedSelectedMonth.Location = new System.Drawing.Point(312, 47);
            this.IssuedSelectedMonth.Name = "IssuedSelectedMonth";
            this.IssuedSelectedMonth.Size = new System.Drawing.Size(76, 30);
            this.IssuedSelectedMonth.TabIndex = 9;
            this.IssuedSelectedMonth.Text = "Issued";
            this.IssuedSelectedMonth.UseVisualStyleBackColor = true;
            this.IssuedSelectedMonth.Click += new System.EventHandler(this.IssuedSelectedMonth_Click_1);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportTabControl);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.ReportTabControl.ResumeLayout(false);
            this.receivedReportTab.ResumeLayout(false);
            this.issuedReportTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ReportTabControl;
        private System.Windows.Forms.TabPage receivedReportTab;
        private System.Windows.Forms.TabPage issuedReportTab;
        private System.Windows.Forms.Button AllSelectedMonth;
        private System.Windows.Forms.DateTimePicker reportDatePicker;
        private System.Windows.Forms.Button BalanceSelectedMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssued;
        private System.Windows.Forms.Button IssuedSelectedMonth;
    }
}