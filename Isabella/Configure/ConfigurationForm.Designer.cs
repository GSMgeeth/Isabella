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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.newDeptTxtBox = new System.Windows.Forms.TextBox();
            this.addNewDeptBtn = new System.Windows.Forms.Button();
            this.CurrentDeptDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.currentIssueDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewIssuePlaceBtn = new System.Windows.Forms.Button();
            this.newIssuePlaceTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentIssueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Department : ";
            // 
            // newDeptTxtBox
            // 
            this.newDeptTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDeptTxtBox.Location = new System.Drawing.Point(13, 140);
            this.newDeptTxtBox.Name = "newDeptTxtBox";
            this.newDeptTxtBox.Size = new System.Drawing.Size(243, 27);
            this.newDeptTxtBox.TabIndex = 1;
            // 
            // addNewDeptBtn
            // 
            this.addNewDeptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDeptBtn.Location = new System.Drawing.Point(262, 139);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentDeptDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CurrentDeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrentDeptDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CurrentDeptDataGridView.Location = new System.Drawing.Point(13, 185);
            this.CurrentDeptDataGridView.Name = "CurrentDeptDataGridView";
            this.CurrentDeptDataGridView.ReadOnly = true;
            this.CurrentDeptDataGridView.RowTemplate.Height = 24;
            this.CurrentDeptDataGridView.Size = new System.Drawing.Size(332, 253);
            this.CurrentDeptDataGridView.TabIndex = 3;
            this.CurrentDeptDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CurrentDeptDataGridView_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add New Issue Place : ";
            // 
            // currentIssueDataGridView
            // 
            this.currentIssueDataGridView.AllowUserToAddRows = false;
            this.currentIssueDataGridView.AllowUserToDeleteRows = false;
            this.currentIssueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentIssueDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.currentIssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentIssueDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.currentIssueDataGridView.Location = new System.Drawing.Point(410, 184);
            this.currentIssueDataGridView.Name = "currentIssueDataGridView";
            this.currentIssueDataGridView.ReadOnly = true;
            this.currentIssueDataGridView.RowTemplate.Height = 24;
            this.currentIssueDataGridView.Size = new System.Drawing.Size(332, 253);
            this.currentIssueDataGridView.TabIndex = 7;
            // 
            // addNewIssuePlaceBtn
            // 
            this.addNewIssuePlaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewIssuePlaceBtn.Location = new System.Drawing.Point(659, 138);
            this.addNewIssuePlaceBtn.Name = "addNewIssuePlaceBtn";
            this.addNewIssuePlaceBtn.Size = new System.Drawing.Size(83, 28);
            this.addNewIssuePlaceBtn.TabIndex = 6;
            this.addNewIssuePlaceBtn.Text = "Add";
            this.addNewIssuePlaceBtn.UseVisualStyleBackColor = true;
            this.addNewIssuePlaceBtn.Click += new System.EventHandler(this.addNewIssuePlaceBtn_Click);
            // 
            // newIssuePlaceTxtBox
            // 
            this.newIssuePlaceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIssuePlaceTxtBox.Location = new System.Drawing.Point(410, 139);
            this.newIssuePlaceTxtBox.Name = "newIssuePlaceTxtBox";
            this.newIssuePlaceTxtBox.Size = new System.Drawing.Size(243, 27);
            this.newIssuePlaceTxtBox.TabIndex = 5;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentIssueDataGridView);
            this.Controls.Add(this.addNewIssuePlaceBtn);
            this.Controls.Add(this.newIssuePlaceTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentDeptDataGridView);
            this.Controls.Add(this.addNewDeptBtn);
            this.Controls.Add(this.newDeptTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentIssueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newDeptTxtBox;
        private System.Windows.Forms.Button addNewDeptBtn;
        private System.Windows.Forms.DataGridView CurrentDeptDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView currentIssueDataGridView;
        private System.Windows.Forms.Button addNewIssuePlaceBtn;
        private System.Windows.Forms.TextBox newIssuePlaceTxtBox;
    }
}