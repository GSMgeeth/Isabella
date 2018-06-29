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
            this.DeptCmbDaily = new System.Windows.Forms.ComboBox();
            this.DeptCmbMonthly = new System.Windows.Forms.ComboBox();
            this.balanceSelectedDay = new System.Windows.Forms.Button();
            this.allSelectedDay = new System.Windows.Forms.Button();
            this.dailyReportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceSelectedMonth = new System.Windows.Forms.Button();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AllSelectedMonth = new System.Windows.Forms.Button();
            this.issuedReportTab = new System.Windows.Forms.TabPage();
            this.issuedSelectedDay = new System.Windows.Forms.Button();
            this.dateTimePickerIssuedDaily = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.receivedReportTab.Controls.Add(this.DeptCmbDaily);
            this.receivedReportTab.Controls.Add(this.DeptCmbMonthly);
            this.receivedReportTab.Controls.Add(this.balanceSelectedDay);
            this.receivedReportTab.Controls.Add(this.allSelectedDay);
            this.receivedReportTab.Controls.Add(this.dailyReportDateTimePicker);
            this.receivedReportTab.Controls.Add(this.label4);
            this.receivedReportTab.Controls.Add(this.label1);
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
            // DeptCmbDaily
            // 
            this.DeptCmbDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCmbDaily.FormattingEnabled = true;
            this.DeptCmbDaily.ItemHeight = 20;
            this.DeptCmbDaily.Location = new System.Drawing.Point(336, 149);
            this.DeptCmbDaily.Name = "DeptCmbDaily";
            this.DeptCmbDaily.Size = new System.Drawing.Size(159, 28);
            this.DeptCmbDaily.TabIndex = 18;
            this.DeptCmbDaily.Text = "All";
            // 
            // DeptCmbMonthly
            // 
            this.DeptCmbMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCmbMonthly.FormattingEnabled = true;
            this.DeptCmbMonthly.ItemHeight = 20;
            this.DeptCmbMonthly.Location = new System.Drawing.Point(336, 42);
            this.DeptCmbMonthly.Name = "DeptCmbMonthly";
            this.DeptCmbMonthly.Size = new System.Drawing.Size(159, 28);
            this.DeptCmbMonthly.TabIndex = 17;
            this.DeptCmbMonthly.Text = "All";
            // 
            // balanceSelectedDay
            // 
            this.balanceSelectedDay.Location = new System.Drawing.Point(579, 149);
            this.balanceSelectedDay.Name = "balanceSelectedDay";
            this.balanceSelectedDay.Size = new System.Drawing.Size(98, 30);
            this.balanceSelectedDay.TabIndex = 16;
            this.balanceSelectedDay.Text = "Balance";
            this.balanceSelectedDay.UseVisualStyleBackColor = true;
            this.balanceSelectedDay.Click += new System.EventHandler(this.balanceSelectedDay_Click);
            // 
            // allSelectedDay
            // 
            this.allSelectedDay.Location = new System.Drawing.Point(517, 149);
            this.allSelectedDay.Name = "allSelectedDay";
            this.allSelectedDay.Size = new System.Drawing.Size(55, 27);
            this.allSelectedDay.TabIndex = 15;
            this.allSelectedDay.Text = "All";
            this.allSelectedDay.UseVisualStyleBackColor = true;
            this.allSelectedDay.Click += new System.EventHandler(this.allSelectedDay_Click);
            // 
            // dailyReportDateTimePicker
            // 
            this.dailyReportDateTimePicker.Location = new System.Drawing.Point(8, 149);
            this.dailyReportDateTimePicker.Name = "dailyReportDateTimePicker";
            this.dailyReportDateTimePicker.Size = new System.Drawing.Size(322, 27);
            this.dailyReportDateTimePicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Daily Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Monthly Report";
            // 
            // BalanceSelectedMonth
            // 
            this.BalanceSelectedMonth.Location = new System.Drawing.Point(578, 42);
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
            this.reportDatePicker.Location = new System.Drawing.Point(7, 42);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(323, 27);
            this.reportDatePicker.TabIndex = 7;
            // 
            // AllSelectedMonth
            // 
            this.AllSelectedMonth.Location = new System.Drawing.Point(516, 42);
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
            this.issuedReportTab.Controls.Add(this.issuedSelectedDay);
            this.issuedReportTab.Controls.Add(this.dateTimePickerIssuedDaily);
            this.issuedReportTab.Controls.Add(this.label3);
            this.issuedReportTab.Controls.Add(this.label2);
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
            // issuedSelectedDay
            // 
            this.issuedSelectedDay.Location = new System.Drawing.Point(336, 152);
            this.issuedSelectedDay.Name = "issuedSelectedDay";
            this.issuedSelectedDay.Size = new System.Drawing.Size(75, 27);
            this.issuedSelectedDay.TabIndex = 14;
            this.issuedSelectedDay.Text = "Issued";
            this.issuedSelectedDay.UseVisualStyleBackColor = true;
            this.issuedSelectedDay.Click += new System.EventHandler(this.issuedSelectedDay_Click);
            // 
            // dateTimePickerIssuedDaily
            // 
            this.dateTimePickerIssuedDaily.Location = new System.Drawing.Point(7, 152);
            this.dateTimePickerIssuedDaily.Name = "dateTimePickerIssuedDaily";
            this.dateTimePickerIssuedDaily.Size = new System.Drawing.Size(322, 27);
            this.dateTimePickerIssuedDaily.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Daily Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Monthly Report";
            // 
            // dateTimePickerIssued
            // 
            this.dateTimePickerIssued.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssued.Location = new System.Drawing.Point(7, 47);
            this.dateTimePickerIssued.Name = "dateTimePickerIssued";
            this.dateTimePickerIssued.Size = new System.Drawing.Size(322, 27);
            this.dateTimePickerIssued.TabIndex = 10;
            // 
            // IssuedSelectedMonth
            // 
            this.IssuedSelectedMonth.Location = new System.Drawing.Point(335, 44);
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
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ReportTabControl.ResumeLayout(false);
            this.receivedReportTab.ResumeLayout(false);
            this.receivedReportTab.PerformLayout();
            this.issuedReportTab.ResumeLayout(false);
            this.issuedReportTab.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dailyReportDateTimePicker;
        private System.Windows.Forms.Button balanceSelectedDay;
        private System.Windows.Forms.Button allSelectedDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssuedDaily;
        private System.Windows.Forms.Button issuedSelectedDay;
        private System.Windows.Forms.ComboBox DeptCmbDaily;
        private System.Windows.Forms.ComboBox DeptCmbMonthly;
    }
}