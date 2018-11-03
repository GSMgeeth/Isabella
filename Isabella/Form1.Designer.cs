namespace Isabella
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.SearchBagButton = new System.Windows.Forms.Button();
            this.GenReportButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.AddDataPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartIssued = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBalance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.TotalRcvLbl = new System.Windows.Forms.Label();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBagTabControl = new System.Windows.Forms.TabControl();
            this.receivedTab = new System.Windows.Forms.TabPage();
            this.deptTotalQtyLbl = new System.Windows.Forms.Label();
            this.bagQty = new System.Windows.Forms.Label();
            this.bagNoTxtBox = new System.Windows.Forms.TextBox();
            this.receivedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.DeptCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receivedItemDataGridView = new System.Windows.Forms.DataGridView();
            this.receivedBagDataGridView = new System.Windows.Forms.DataGridView();
            this.issuedTab = new System.Windows.Forms.TabPage();
            this.bagQtyIssued = new System.Windows.Forms.Label();
            this.issuedItemDataGridView = new System.Windows.Forms.DataGridView();
            this.issuedBagDataGridView = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataSet2 = new Isabella.Report.DataSet2();
            this.summaryDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AddDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBalance)).BeginInit();
            this.panel2.SuspendLayout();
            this.searchBagTabControl.SuspendLayout();
            this.receivedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBagDataGridView)).BeginInit();
            this.issuedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuedItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(350, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isabella (pvt) Ltd.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(371, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Quality Stock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 67);
            this.panel1.TabIndex = 2;
            // 
            // AddDataButton
            // 
            this.AddDataButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDataButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataButton.ForeColor = System.Drawing.Color.Black;
            this.AddDataButton.Location = new System.Drawing.Point(10, 82);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(200, 46);
            this.AddDataButton.TabIndex = 3;
            this.AddDataButton.Text = "Add Data File";
            this.AddDataButton.UseVisualStyleBackColor = false;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // SearchBagButton
            // 
            this.SearchBagButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBagButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBagButton.ForeColor = System.Drawing.Color.Black;
            this.SearchBagButton.Location = new System.Drawing.Point(10, 133);
            this.SearchBagButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBagButton.Name = "SearchBagButton";
            this.SearchBagButton.Size = new System.Drawing.Size(200, 46);
            this.SearchBagButton.TabIndex = 4;
            this.SearchBagButton.Text = "Search Bags";
            this.SearchBagButton.UseVisualStyleBackColor = false;
            this.SearchBagButton.Click += new System.EventHandler(this.SearchBagButton_Click);
            // 
            // GenReportButton
            // 
            this.GenReportButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GenReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenReportButton.ForeColor = System.Drawing.Color.Black;
            this.GenReportButton.Location = new System.Drawing.Point(9, 184);
            this.GenReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenReportButton.Name = "GenReportButton";
            this.GenReportButton.Size = new System.Drawing.Size(200, 46);
            this.GenReportButton.TabIndex = 5;
            this.GenReportButton.Text = "Generate Report";
            this.GenReportButton.UseVisualStyleBackColor = false;
            this.GenReportButton.Click += new System.EventHandler(this.GenReportButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.ForeColor = System.Drawing.Color.Black;
            this.ConfigButton.Location = new System.Drawing.Point(10, 234);
            this.ConfigButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(200, 46);
            this.ConfigButton.TabIndex = 6;
            this.ConfigButton.Text = "Configure";
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // AddDataPanel
            // 
            this.AddDataPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddDataPanel.Controls.Add(this.label7);
            this.AddDataPanel.Controls.Add(this.label6);
            this.AddDataPanel.Controls.Add(this.chartIssued);
            this.AddDataPanel.Controls.Add(this.chartBalance);
            this.AddDataPanel.Controls.Add(this.label5);
            this.AddDataPanel.Controls.Add(this.label4);
            this.AddDataPanel.Controls.Add(this.BalanceLbl);
            this.AddDataPanel.Controls.Add(this.TotalRcvLbl);
            this.AddDataPanel.Controls.Add(this.AddFileButton);
            this.AddDataPanel.Location = new System.Drawing.Point(218, 83);
            this.AddDataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AddDataPanel.Name = "AddDataPanel";
            this.AddDataPanel.Size = new System.Drawing.Size(670, 439);
            this.AddDataPanel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Issued";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Balance";
            // 
            // chartIssued
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIssued.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIssued.Legends.Add(legend1);
            this.chartIssued.Location = new System.Drawing.Point(332, 53);
            this.chartIssued.Margin = new System.Windows.Forms.Padding(2);
            this.chartIssued.Name = "chartIssued";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIssued.Series.Add(series1);
            this.chartIssued.Size = new System.Drawing.Size(308, 286);
            this.chartIssued.TabIndex = 7;
            this.chartIssued.Text = "chart2";
            // 
            // chartBalance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBalance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBalance.Legends.Add(legend2);
            this.chartBalance.Location = new System.Drawing.Point(17, 53);
            this.chartBalance.Margin = new System.Windows.Forms.Padding(2);
            this.chartBalance.Name = "chartBalance";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBalance.Series.Add(series2);
            this.chartBalance.Size = new System.Drawing.Size(300, 286);
            this.chartBalance.TabIndex = 6;
            this.chartBalance.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.Location = new System.Drawing.Point(490, 375);
            this.BalanceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(59, 17);
            this.BalanceLbl.TabIndex = 3;
            this.BalanceLbl.Text = "Balance";
            // 
            // TotalRcvLbl
            // 
            this.TotalRcvLbl.AutoSize = true;
            this.TotalRcvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRcvLbl.Location = new System.Drawing.Point(93, 376);
            this.TotalRcvLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalRcvLbl.Name = "TotalRcvLbl";
            this.TotalRcvLbl.Size = new System.Drawing.Size(40, 17);
            this.TotalRcvLbl.TabIndex = 2;
            this.TotalRcvLbl.Text = "Total";
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(278, 13);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(92, 22);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.searchBagTabControl);
            this.panel2.Location = new System.Drawing.Point(218, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 439);
            this.panel2.TabIndex = 8;
            // 
            // searchBagTabControl
            // 
            this.searchBagTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBagTabControl.Controls.Add(this.receivedTab);
            this.searchBagTabControl.Controls.Add(this.issuedTab);
            this.searchBagTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBagTabControl.Location = new System.Drawing.Point(3, 14);
            this.searchBagTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.searchBagTabControl.Name = "searchBagTabControl";
            this.searchBagTabControl.SelectedIndex = 0;
            this.searchBagTabControl.Size = new System.Drawing.Size(664, 422);
            this.searchBagTabControl.TabIndex = 0;
            // 
            // receivedTab
            // 
            this.receivedTab.Controls.Add(this.deptTotalQtyLbl);
            this.receivedTab.Controls.Add(this.bagQty);
            this.receivedTab.Controls.Add(this.bagNoTxtBox);
            this.receivedTab.Controls.Add(this.receivedDatePicker);
            this.receivedTab.Controls.Add(this.resetButton);
            this.receivedTab.Controls.Add(this.searchButton);
            this.receivedTab.Controls.Add(this.DeptCmb);
            this.receivedTab.Controls.Add(this.label3);
            this.receivedTab.Controls.Add(this.receivedItemDataGridView);
            this.receivedTab.Controls.Add(this.receivedBagDataGridView);
            this.receivedTab.Location = new System.Drawing.Point(4, 31);
            this.receivedTab.Margin = new System.Windows.Forms.Padding(2);
            this.receivedTab.Name = "receivedTab";
            this.receivedTab.Padding = new System.Windows.Forms.Padding(2);
            this.receivedTab.Size = new System.Drawing.Size(656, 387);
            this.receivedTab.TabIndex = 0;
            this.receivedTab.Text = "Received";
            this.receivedTab.UseVisualStyleBackColor = true;
            // 
            // deptTotalQtyLbl
            // 
            this.deptTotalQtyLbl.AutoSize = true;
            this.deptTotalQtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTotalQtyLbl.Location = new System.Drawing.Point(5, 38);
            this.deptTotalQtyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deptTotalQtyLbl.Name = "deptTotalQtyLbl";
            this.deptTotalQtyLbl.Size = new System.Drawing.Size(81, 13);
            this.deptTotalQtyLbl.TabIndex = 9;
            this.deptTotalQtyLbl.Text = "Total items : ";
            // 
            // bagQty
            // 
            this.bagQty.AutoSize = true;
            this.bagQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagQty.Location = new System.Drawing.Point(533, 38);
            this.bagQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bagQty.Name = "bagQty";
            this.bagQty.Size = new System.Drawing.Size(81, 13);
            this.bagQty.TabIndex = 8;
            this.bagQty.Text = "Total items : ";
            // 
            // bagNoTxtBox
            // 
            this.bagNoTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagNoTxtBox.Location = new System.Drawing.Point(442, 9);
            this.bagNoTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.bagNoTxtBox.Name = "bagNoTxtBox";
            this.bagNoTxtBox.Size = new System.Drawing.Size(48, 23);
            this.bagNoTxtBox.TabIndex = 7;
            // 
            // receivedDatePicker
            // 
            this.receivedDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDatePicker.Location = new System.Drawing.Point(214, 9);
            this.receivedDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.receivedDatePicker.Name = "receivedDatePicker";
            this.receivedDatePicker.Size = new System.Drawing.Size(225, 23);
            this.receivedDatePicker.TabIndex = 6;
            this.receivedDatePicker.ValueChanged += new System.EventHandler(this.receivedDatePicker_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(596, 7);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(58, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(528, 7);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DeptCmb
            // 
            this.DeptCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCmb.FormattingEnabled = true;
            this.DeptCmb.ItemHeight = 17;
            this.DeptCmb.Location = new System.Drawing.Point(90, 9);
            this.DeptCmb.Margin = new System.Windows.Forms.Padding(2);
            this.DeptCmb.Name = "DeptCmb";
            this.DeptCmb.Size = new System.Drawing.Size(120, 25);
            this.DeptCmb.TabIndex = 3;
            this.DeptCmb.Text = "All";
            this.DeptCmb.SelectedIndexChanged += new System.EventHandler(this.DeptCmb_SelectedIndexChanged);
            this.DeptCmb.SelectedValueChanged += new System.EventHandler(this.DeptCmb_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search By:";
            // 
            // receivedItemDataGridView
            // 
            this.receivedItemDataGridView.AllowUserToAddRows = false;
            this.receivedItemDataGridView.AllowUserToDeleteRows = false;
            this.receivedItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receivedItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receivedItemDataGridView.Location = new System.Drawing.Point(410, 57);
            this.receivedItemDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.receivedItemDataGridView.Name = "receivedItemDataGridView";
            this.receivedItemDataGridView.ReadOnly = true;
            this.receivedItemDataGridView.RowTemplate.Height = 24;
            this.receivedItemDataGridView.Size = new System.Drawing.Size(244, 327);
            this.receivedItemDataGridView.TabIndex = 1;
            // 
            // receivedBagDataGridView
            // 
            this.receivedBagDataGridView.AllowUserToAddRows = false;
            this.receivedBagDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedBagDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.receivedBagDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.receivedBagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receivedBagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receivedBagDataGridView.Location = new System.Drawing.Point(5, 57);
            this.receivedBagDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.receivedBagDataGridView.Name = "receivedBagDataGridView";
            this.receivedBagDataGridView.ReadOnly = true;
            this.receivedBagDataGridView.RowTemplate.Height = 24;
            this.receivedBagDataGridView.Size = new System.Drawing.Size(400, 327);
            this.receivedBagDataGridView.TabIndex = 0;
            this.receivedBagDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.receivedBagDataGridView_RowHeaderMouseClick);
            this.receivedBagDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.receivedBagDataGridView_RowHeaderMouseDoubleClick);
            // 
            // issuedTab
            // 
            this.issuedTab.Controls.Add(this.bagQtyIssued);
            this.issuedTab.Controls.Add(this.issuedItemDataGridView);
            this.issuedTab.Controls.Add(this.issuedBagDataGridView);
            this.issuedTab.Location = new System.Drawing.Point(4, 31);
            this.issuedTab.Margin = new System.Windows.Forms.Padding(2);
            this.issuedTab.Name = "issuedTab";
            this.issuedTab.Padding = new System.Windows.Forms.Padding(2);
            this.issuedTab.Size = new System.Drawing.Size(656, 387);
            this.issuedTab.TabIndex = 1;
            this.issuedTab.Text = "Issued";
            this.issuedTab.UseVisualStyleBackColor = true;
            // 
            // bagQtyIssued
            // 
            this.bagQtyIssued.AutoSize = true;
            this.bagQtyIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagQtyIssued.Location = new System.Drawing.Point(533, 38);
            this.bagQtyIssued.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bagQtyIssued.Name = "bagQtyIssued";
            this.bagQtyIssued.Size = new System.Drawing.Size(34, 13);
            this.bagQtyIssued.TabIndex = 9;
            this.bagQtyIssued.Text = "Qty :";
            // 
            // issuedItemDataGridView
            // 
            this.issuedItemDataGridView.AllowUserToAddRows = false;
            this.issuedItemDataGridView.AllowUserToDeleteRows = false;
            this.issuedItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuedItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuedItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedItemDataGridView.Location = new System.Drawing.Point(410, 57);
            this.issuedItemDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.issuedItemDataGridView.Name = "issuedItemDataGridView";
            this.issuedItemDataGridView.ReadOnly = true;
            this.issuedItemDataGridView.RowTemplate.Height = 24;
            this.issuedItemDataGridView.Size = new System.Drawing.Size(244, 327);
            this.issuedItemDataGridView.TabIndex = 3;
            // 
            // issuedBagDataGridView
            // 
            this.issuedBagDataGridView.AllowUserToAddRows = false;
            this.issuedBagDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBagDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.issuedBagDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.issuedBagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuedBagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedBagDataGridView.Location = new System.Drawing.Point(4, 57);
            this.issuedBagDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.issuedBagDataGridView.Name = "issuedBagDataGridView";
            this.issuedBagDataGridView.ReadOnly = true;
            this.issuedBagDataGridView.RowTemplate.Height = 24;
            this.issuedBagDataGridView.Size = new System.Drawing.Size(400, 327);
            this.issuedBagDataGridView.TabIndex = 2;
            this.issuedBagDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.issuedBagDataGridView_RowHeaderMouseClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summaryDataTableBindingSource
            // 
            this.summaryDataTableBindingSource.DataMember = "SummaryDataTable";
            this.summaryDataTableBindingSource.DataSource = this.dataSet2;
            // 
            // summBtn
            // 
            this.summBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.summBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summBtn.ForeColor = System.Drawing.Color.Black;
            this.summBtn.Location = new System.Drawing.Point(9, 284);
            this.summBtn.Margin = new System.Windows.Forms.Padding(2);
            this.summBtn.Name = "summBtn";
            this.summBtn.Size = new System.Drawing.Size(200, 46);
            this.summBtn.TabIndex = 9;
            this.summBtn.Text = "Summary";
            this.summBtn.UseVisualStyleBackColor = false;
            this.summBtn.Click += new System.EventHandler(this.summBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtn.ForeColor = System.Drawing.Color.Black;
            this.catBtn.Location = new System.Drawing.Point(9, 334);
            this.catBtn.Margin = new System.Windows.Forms.Padding(2);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(200, 46);
            this.catBtn.TabIndex = 10;
            this.catBtn.Text = "Category";
            this.catBtn.UseVisualStyleBackColor = false;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Article Segregation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(9, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "From/To Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(897, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.summBtn);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.GenReportButton);
            this.Controls.Add(this.SearchBagButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddDataPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(913, 570);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isabella";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Isabella_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddDataPanel.ResumeLayout(false);
            this.AddDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBalance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.searchBagTabControl.ResumeLayout(false);
            this.receivedTab.ResumeLayout(false);
            this.receivedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBagDataGridView)).EndInit();
            this.issuedTab.ResumeLayout(false);
            this.issuedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuedItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button SearchBagButton;
        private System.Windows.Forms.Button GenReportButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Panel AddDataPanel;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl searchBagTabControl;
        private System.Windows.Forms.TabPage receivedTab;
        private System.Windows.Forms.TabPage issuedTab;
        private System.Windows.Forms.DataGridView receivedBagDataGridView;
        private System.Windows.Forms.DataGridView receivedItemDataGridView;
        private System.Windows.Forms.DataGridView issuedItemDataGridView;
        private System.Windows.Forms.DataGridView issuedBagDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeptCmb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DateTimePicker receivedDatePicker;
        private System.Windows.Forms.TextBox bagNoTxtBox;
        private System.Windows.Forms.Label bagQty;
        private System.Windows.Forms.Label bagQtyIssued;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.Label TotalRcvLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBalance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIssued;
        private System.Windows.Forms.BindingSource summaryDataTableBindingSource;
        private Report.DataSet2 dataSet2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label deptTotalQtyLbl;
        private System.Windows.Forms.Button summBtn;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

