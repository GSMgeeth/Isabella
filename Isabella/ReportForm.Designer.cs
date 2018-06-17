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
            this.issuedReportTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ReportTabControl.SuspendLayout();
            this.receivedReportTab.SuspendLayout();
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
            this.receivedReportTab.Controls.Add(this.button1);
            this.receivedReportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedReportTab.Location = new System.Drawing.Point(4, 29);
            this.receivedReportTab.Name = "receivedReportTab";
            this.receivedReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.receivedReportTab.Size = new System.Drawing.Size(789, 415);
            this.receivedReportTab.TabIndex = 0;
            this.receivedReportTab.Text = "Received Bags";
            // 
            // issuedReportTab
            // 
            this.issuedReportTab.BackColor = System.Drawing.Color.LightGray;
            this.issuedReportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedReportTab.Location = new System.Drawing.Point(4, 29);
            this.issuedReportTab.Name = "issuedReportTab";
            this.issuedReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.issuedReportTab.Size = new System.Drawing.Size(789, 415);
            this.issuedReportTab.TabIndex = 1;
            this.issuedReportTab.Text = "Issued Bags";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportTabControl);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ReportTabControl.ResumeLayout(false);
            this.receivedReportTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ReportTabControl;
        private System.Windows.Forms.TabPage receivedReportTab;
        private System.Windows.Forms.TabPage issuedReportTab;
        private System.Windows.Forms.Button button1;
    }
}