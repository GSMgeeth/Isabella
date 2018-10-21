namespace Isabella
{
    partial class CategoryForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchSizeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchColortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchArticleTxt = new System.Windows.Forms.TextBox();
            this.catReportViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // catReportViewerPanel
            // 
            this.catReportViewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catReportViewerPanel.Controls.Add(this.categoryReportViewer);
            this.catReportViewerPanel.Location = new System.Drawing.Point(243, 13);
            this.catReportViewerPanel.Name = "catReportViewerPanel";
            this.catReportViewerPanel.Size = new System.Drawing.Size(809, 656);
            this.catReportViewerPanel.TabIndex = 0;
            // 
            // categoryReportViewer
            // 
            this.categoryReportViewer.ActiveViewIndex = -1;
            this.categoryReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryReportViewer.Location = new System.Drawing.Point(0, 0);
            this.categoryReportViewer.Name = "categoryReportViewer";
            this.categoryReportViewer.Size = new System.Drawing.Size(809, 656);
            this.categoryReportViewer.TabIndex = 0;
            this.categoryReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Department";
            // 
            // DeptCmb
            // 
            this.DeptCmb.FormattingEnabled = true;
            this.DeptCmb.Location = new System.Drawing.Point(12, 49);
            this.DeptCmb.Name = "DeptCmb";
            this.DeptCmb.Size = new System.Drawing.Size(214, 21);
            this.DeptCmb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Size";
            // 
            // searchSizeTxt
            // 
            this.searchSizeTxt.Location = new System.Drawing.Point(12, 294);
            this.searchSizeTxt.Name = "searchSizeTxt";
            this.searchSizeTxt.Size = new System.Drawing.Size(214, 20);
            this.searchSizeTxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Color";
            // 
            // searchColortxt
            // 
            this.searchColortxt.Location = new System.Drawing.Point(12, 206);
            this.searchColortxt.Name = "searchColortxt";
            this.searchColortxt.Size = new System.Drawing.Size(214, 20);
            this.searchColortxt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Article";
            // 
            // searchArticleTxt
            // 
            this.searchArticleTxt.Location = new System.Drawing.Point(12, 118);
            this.searchArticleTxt.Name = "searchArticleTxt";
            this.searchArticleTxt.Size = new System.Drawing.Size(214, 20);
            this.searchArticleTxt.TabIndex = 13;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchSizeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchColortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchArticleTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeptCmb);
            this.Controls.Add(this.catReportViewerPanel);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "CategoryForm";
            this.Text = "Category Form";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.catReportViewerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel catReportViewerPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer categoryReportViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeptCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchSizeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchColortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchArticleTxt;
    }
}