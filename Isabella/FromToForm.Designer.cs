namespace Isabella
{
    partial class FromToForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fromToReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.searchSizeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchColortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchArticleTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptCmb = new System.Windows.Forms.ComboBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.fromToReportViewer);
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 657);
            this.panel1.TabIndex = 0;
            // 
            // fromToReportViewer
            // 
            this.fromToReportViewer.ActiveViewIndex = -1;
            this.fromToReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromToReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.fromToReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromToReportViewer.Location = new System.Drawing.Point(0, 0);
            this.fromToReportViewer.Name = "fromToReportViewer";
            this.fromToReportViewer.Size = new System.Drawing.Size(809, 657);
            this.fromToReportViewer.TabIndex = 0;
            this.fromToReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Size";
            // 
            // searchSizeTxt
            // 
            this.searchSizeTxt.Location = new System.Drawing.Point(12, 421);
            this.searchSizeTxt.Name = "searchSizeTxt";
            this.searchSizeTxt.Size = new System.Drawing.Size(214, 20);
            this.searchSizeTxt.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Color";
            // 
            // searchColortxt
            // 
            this.searchColortxt.Location = new System.Drawing.Point(12, 333);
            this.searchColortxt.Name = "searchColortxt";
            this.searchColortxt.Size = new System.Drawing.Size(214, 20);
            this.searchColortxt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Article";
            // 
            // searchArticleTxt
            // 
            this.searchArticleTxt.Location = new System.Drawing.Point(12, 245);
            this.searchArticleTxt.Name = "searchArticleTxt";
            this.searchArticleTxt.Size = new System.Drawing.Size(214, 20);
            this.searchArticleTxt.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department";
            // 
            // DeptCmb
            // 
            this.DeptCmb.FormattingEnabled = true;
            this.DeptCmb.Location = new System.Drawing.Point(12, 176);
            this.DeptCmb.Name = "DeptCmb";
            this.DeptCmb.Size = new System.Drawing.Size(214, 21);
            this.DeptCmb.TabIndex = 19;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(12, 55);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(214, 20);
            this.fromDatePicker.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "To";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(12, 110);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(214, 20);
            this.toDatePicker.TabIndex = 30;
            // 
            // FromToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchSizeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchColortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchArticleTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeptCmb);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "FromToForm";
            this.Text = "FromToForm";
            this.Load += new System.EventHandler(this.FromToForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer fromToReportViewer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchSizeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchColortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchArticleTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeptCmb;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker toDatePicker;
    }
}