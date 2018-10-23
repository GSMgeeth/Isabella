namespace Isabella
{
    partial class ArticleSegregationForm
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
            this.catReportViewerPanel = new System.Windows.Forms.Panel();
            this.categoryReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.searchArticleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.catReportViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // catReportViewerPanel
            // 
            this.catReportViewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catReportViewerPanel.Controls.Add(this.categoryReportViewer);
            this.catReportViewerPanel.Location = new System.Drawing.Point(243, 12);
            this.catReportViewerPanel.Name = "catReportViewerPanel";
            this.catReportViewerPanel.Size = new System.Drawing.Size(809, 657);
            this.catReportViewerPanel.TabIndex = 1;
            // 
            // categoryReportViewer
            // 
            this.categoryReportViewer.ActiveViewIndex = -1;
            this.categoryReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryReportViewer.Location = new System.Drawing.Point(0, 0);
            this.categoryReportViewer.Name = "categoryReportViewer";
            this.categoryReportViewer.Size = new System.Drawing.Size(809, 657);
            this.categoryReportViewer.TabIndex = 0;
            this.categoryReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Article";
            // 
            // searchArticleTxt
            // 
            this.searchArticleTxt.Location = new System.Drawing.Point(12, 104);
            this.searchArticleTxt.Name = "searchArticleTxt";
            this.searchArticleTxt.Size = new System.Drawing.Size(214, 20);
            this.searchArticleTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department";
            // 
            // DeptCmb
            // 
            this.DeptCmb.FormattingEnabled = true;
            this.DeptCmb.Location = new System.Drawing.Point(12, 35);
            this.DeptCmb.Name = "DeptCmb";
            this.DeptCmb.Size = new System.Drawing.Size(214, 21);
            this.DeptCmb.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArticleSegregationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchArticleTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeptCmb);
            this.Controls.Add(this.catReportViewerPanel);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "ArticleSegregationForm";
            this.Text = "ArticleSegregationForm";
            this.Load += new System.EventHandler(this.ArticleSegregationForm_Load);
            this.catReportViewerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel catReportViewerPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer categoryReportViewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchArticleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeptCmb;
        private System.Windows.Forms.Button button1;
    }
}