﻿namespace Isabella
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
            this.ydBtn = new System.Windows.Forms.Button();
            this.ethBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ydBtn
            // 
            this.ydBtn.Location = new System.Drawing.Point(334, 71);
            this.ydBtn.Name = "ydBtn";
            this.ydBtn.Size = new System.Drawing.Size(117, 42);
            this.ydBtn.TabIndex = 0;
            this.ydBtn.Text = "YarnDye";
            this.ydBtn.UseVisualStyleBackColor = true;
            this.ydBtn.Click += new System.EventHandler(this.ydBtn_Click);
            // 
            // ethBtn
            // 
            this.ethBtn.Location = new System.Drawing.Point(457, 71);
            this.ethBtn.Name = "ethBtn";
            this.ethBtn.Size = new System.Drawing.Size(117, 42);
            this.ethBtn.TabIndex = 1;
            this.ethBtn.Text = "Ethiopia";
            this.ethBtn.UseVisualStyleBackColor = true;
            this.ethBtn.Click += new System.EventHandler(this.ethBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "To where you are issueing?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ethBtn);
            this.Controls.Add(this.ydBtn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Where?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ydBtn;
        private System.Windows.Forms.Button ethBtn;
        private System.Windows.Forms.Label label1;
    }
}