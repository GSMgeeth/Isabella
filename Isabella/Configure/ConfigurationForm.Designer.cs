namespace Isabella.Configure
{
    partial class ConfigurationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newDeptTxtBox = new System.Windows.Forms.TextBox();
            this.addNewDeptBtn = new System.Windows.Forms.Button();
            this.CurrentDeptDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Department : ";
            // 
            // newDeptTxtBox
            // 
            this.newDeptTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDeptTxtBox.Location = new System.Drawing.Point(252, 12);
            this.newDeptTxtBox.Name = "newDeptTxtBox";
            this.newDeptTxtBox.Size = new System.Drawing.Size(204, 27);
            this.newDeptTxtBox.TabIndex = 1;
            // 
            // addNewDeptBtn
            // 
            this.addNewDeptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDeptBtn.Location = new System.Drawing.Point(462, 12);
            this.addNewDeptBtn.Name = "addNewDeptBtn";
            this.addNewDeptBtn.Size = new System.Drawing.Size(83, 28);
            this.addNewDeptBtn.TabIndex = 2;
            this.addNewDeptBtn.Text = "Add";
            this.addNewDeptBtn.UseVisualStyleBackColor = true;
            this.addNewDeptBtn.Click += new System.EventHandler(this.addNewDeptBtn_Click);
            // 
            // CurrentDeptDataGridView
            // 
            this.CurrentDeptDataGridView.AllowUserToAddRows = false;
            this.CurrentDeptDataGridView.AllowUserToDeleteRows = false;
            this.CurrentDeptDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentDeptDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CurrentDeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrentDeptDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CurrentDeptDataGridView.Location = new System.Drawing.Point(13, 185);
            this.CurrentDeptDataGridView.Name = "CurrentDeptDataGridView";
            this.CurrentDeptDataGridView.ReadOnly = true;
            this.CurrentDeptDataGridView.RowTemplate.Height = 24;
            this.CurrentDeptDataGridView.Size = new System.Drawing.Size(193, 253);
            this.CurrentDeptDataGridView.TabIndex = 3;
            this.CurrentDeptDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CurrentDeptDataGridView_RowHeaderMouseDoubleClick);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentDeptDataGridView);
            this.Controls.Add(this.addNewDeptBtn);
            this.Controls.Add(this.newDeptTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeptDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newDeptTxtBox;
        private System.Windows.Forms.Button addNewDeptBtn;
        private System.Windows.Forms.DataGridView CurrentDeptDataGridView;
    }
}