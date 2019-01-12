namespace Isabella
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.issuePlaceCmb = new System.Windows.Forms.ComboBox();
            this.issueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "To where you are issueing?";
            // 
            // issuePlaceCmb
            // 
            this.issuePlaceCmb.FormattingEnabled = true;
            this.issuePlaceCmb.Location = new System.Drawing.Point(211, 10);
            this.issuePlaceCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issuePlaceCmb.Name = "issuePlaceCmb";
            this.issuePlaceCmb.Size = new System.Drawing.Size(149, 21);
            this.issuePlaceCmb.TabIndex = 3;
            // 
            // issueBtn
            // 
            this.issueBtn.Location = new System.Drawing.Point(384, 10);
            this.issueBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Size = new System.Drawing.Size(82, 21);
            this.issueBtn.TabIndex = 4;
            this.issueBtn.Text = "Issue";
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.issueBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 109);
            this.Controls.Add(this.issueBtn);
            this.Controls.Add(this.issuePlaceCmb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Where?";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox issuePlaceCmb;
        private System.Windows.Forms.Button issueBtn;
    }
}