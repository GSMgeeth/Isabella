namespace Isabella.Report
{
    partial class summaryReportForm
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
            this.crystalReportViewerSummary = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerSummary
            // 
            this.crystalReportViewerSummary.ActiveViewIndex = -1;
            this.crystalReportViewerSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSummary.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSummary.Name = "crystalReportViewerSummary";
            this.crystalReportViewerSummary.Size = new System.Drawing.Size(1169, 645);
            this.crystalReportViewerSummary.TabIndex = 0;
            this.crystalReportViewerSummary.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // summaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 645);
            this.Controls.Add(this.crystalReportViewerSummary);
            this.Name = "summaryReportForm";
            this.Text = "summaryReportForm";
            this.Load += new System.EventHandler(this.summaryReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSummary;
    }
}