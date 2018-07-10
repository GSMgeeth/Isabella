using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Isabella.Role;
using Isabella.Report;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using _Excel = Microsoft.Office.Interop.Excel;
using Isabella.Configure;

namespace Isabella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            AddDataPanel.Visible = true;
        }
        
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            AddDataPanel.Visible = true;
            AddDataPanel.ResetText();
        }

        private void SearchBagButton_Click(object sender, EventArgs e)
        {
            AddDataPanel.Visible = false;
            panel2.Visible = true;
        }

        private void GenReportButton_Click(object sender, EventArgs e)
        {
            ReportForm repFrm = new ReportForm();

            repFrm.Show();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configFrm = new ConfigurationForm();
            
            configFrm.Show();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Workbook|*.xlsx|Excel Workbook 2003|*.xls";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string name = openFileDialog1.SafeFileName;

                if (name.Contains(".xlsx"))
                {
                    _Application excel = new _Excel.Application();
                    Workbook wb;
                    Worksheet ws;

                    string path = "D:/SecondQuality/" + name;

                    wb = excel.Workbooks.Open(path);
                    ws = wb.Worksheets[2];

                    if (ws.Cells[2, 1].Value2 != null)
                    {
                        string deptTmp = "";

                        deptTmp = ws.Cells[2, 1].Value2.ToString();

                        int deptNo = 1;

                        MySqlDataReader readerDept = DBConnection.getData("select * from department where deptName='" + deptTmp + "'");

                        if (readerDept.HasRows)
                        {
                            while (readerDept.Read())
                                deptNo = readerDept.GetInt32("deptNo");

                            readerDept.Close();

                            int row = 3;

                            double tmpD = ws.Cells[3, 2].Value2;
                            double dayBagNo = ws.Cells[row, 3].Value2;

                            DateTime d = DateTime.FromOADate(tmpD);
                            double qty = 1;
                            int q = (int)qty;
                            int bNo = (int)dayBagNo;
                            Department dept = new Department((int)deptNo);

                            Bag bag = new Bag(d, q, dept, bNo);

                            if (Database.isBagExists(bag))
                            {
                                MessageBox.Show("Bag already exists!", "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                            while (ws.Cells[row, 5].Value2 != null)
                            {
                                if ((ws.Cells[row, 2].Value2 != null) && (tmpD != ws.Cells[row, 2].Value2))
                                {
                                    tmpD = ws.Cells[row, 2].Value2;
                                }

                                if ((ws.Cells[row, 3].Value2 != null) && (dayBagNo != ws.Cells[row, 3].Value2))
                                {
                                    try
                                    {
                                        Database.saveBag(bag);

                                        setProgress();
                                    }
                                    catch (Exception exc)
                                    {
                                        MessageBox.Show("Error in saving the bag in DB!\n" + exc, "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    dayBagNo = ws.Cells[row, 3].Value2;

                                    d = DateTime.FromOADate(tmpD);
                                    qty = 1;
                                    q = (int)qty;
                                    bNo = (int)dayBagNo;
                                    dept = new Department((int)deptNo);

                                    bag = new Bag(d, q, dept, bNo);

                                    if (Database.isBagExists(bag))
                                    {
                                        MessageBox.Show("Bag already exists!", "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                string article = ws.Cells[(row), 5].Value2.ToString();
                                string color = ws.Cells[(row), 6].Value2.ToString();
                                string size = ws.Cells[(row), 7].Value2.ToString();

                                double qtyTmpSame = ws.Cells[(row), 8].Value2;
                                int qtySame = (int)qtyTmpSame;

                                for (int j = 0; j < qtySame; j++)
                                {
                                    bag.addItem(0, color, size, article);
                                }
                                
                                row++;
                            }

                            try
                            {
                                Database.saveBag(bag);

                                setProgress();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("Error in saving the bag in DB!\n" + exc, "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            receivedBagDataGridView.DataSource = getReceivedBags();
                            setProgress();

                            notifyIcon1.Icon = SystemIcons.Application;
                            notifyIcon1.BalloonTipText = "The data has been added to the DB successfully!";
                            notifyIcon1.ShowBalloonTip(1000);

                            wb.Close();
                            excel.Quit();

                            Marshal.ReleaseComObject(wb);
                            Marshal.ReleaseComObject(excel);
                        }
                        else
                        {
                            MessageBox.Show("Wrong Department name in the Excel file!", "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Department name error in the Excel file!", "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something wrong with the excel file!\n" + exception.StackTrace, "File reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Isabella_Load(object sender, EventArgs e)
        {
            receivedBagDataGridView.DataSource = getReceivedBags();
            issuedBagDataGridView.DataSource = getIssuedBags();
            
            receivedBagDataGridView.Columns[0].Visible = false;
            issuedBagDataGridView.Columns[0].Visible = false;

            setProgress();
            fillDeptComboBox();
        }

        private void setProgress()
        {
            uint total = 0;
            uint balance = 0;

            MySqlDataReader readerTotal = DBConnection.getData("select COUNT(item_id) AS itemCount from item");

            if (readerTotal.HasRows)
            {
                while (readerTotal.Read())
                {
                    total = readerTotal.GetUInt32("itemCount");
                }

                readerTotal.Close();

                MySqlDataReader readerBal = DBConnection.getData("select COUNT(i.item_id) AS itemBal from item i " +
                    "inner join bag b on i.bag_id=b.bag_id where b.issued=0");

                while (readerBal.Read())
                {
                    balance = readerBal.GetUInt32("itemBal");
                }

                readerBal.Close();

                double percent = 0;

                if (total != 0)
                    percent = (balance / (double)total) * 100;

                progressBar.Value = (int)percent;

                TotalRcvLbl.Text = "" + total;
                BalanceLbl.Text = "" + balance;
            }
            else
            {
                double percent = 0;

                progressBar.Value = (int)percent;

                TotalRcvLbl.Text = "" + total;
                BalanceLbl.Text = "" + balance;
            }
        }

        public void fillDeptComboBox()
        {
            MySqlDataReader reader = DBConnection.getData("select * from department");

            while (reader.Read())
            {
                DeptCmb.Items.Add(reader.GetString("deptName"));
            }

            reader.Close();
        }

        private System.Data.DataTable getIssuedBags()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select b.bag_id, d.deptName, b.date, b.bagNo, t.place from bag b inner join department d on b.deptNo=d.deptNo inner join issuedTo t on b.place_id=t.place_id where b.issued=1");

            table.Load(reader);

            return table;
        }

        private System.Data.DataTable getReceivedBags()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select b.bag_id, d.deptName, b.date, b.bagNo, b.issued from bag b inner join department d on b.deptNo=d.deptNo");

            table.Load(reader);

            return table;
        }

        private void receivedBagDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tmp = receivedBagDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            receivedItemDataGridView.DataSource = getReceivedItems(Int32.Parse(tmp));

            receivedItemDataGridView.RowHeadersVisible = false;
            receivedItemDataGridView.Columns[0].Visible = false;
            receivedItemDataGridView.Columns[1].Visible = false;
        }

        private System.Data.DataTable getReceivedItems(int bag_id)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from item where bag_id=" + bag_id);

            table.Load(reader);

            MySqlDataReader readerCount = DBConnection.getData("select COUNT(bag_id) as itemCount from item where bag_id=" + bag_id + " group by bag_id;");

            while (readerCount.Read())
            {
                bagQty.Text = "Total items : " + readerCount.GetInt32("itemCount");
            }

            readerCount.Close();

            return table;
        }

        private System.Data.DataTable getIssuedItems(int bag_id)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from item where bag_id=" + bag_id);

            table.Load(reader);

            MySqlDataReader readerCount = DBConnection.getData("select COUNT(bag_id) as itemCount from item where bag_id=" + bag_id + " group by bag_id;");

            while (readerCount.Read())
            {
                bagQtyIssued.Text = "Total items : " + readerCount.GetInt32("itemCount");
            }

            readerCount.Close();

            return table;
        }

        private void receivedBagDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tmp = receivedBagDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            Form2 f2 = new Form2(Int32.Parse(tmp));

            f2.ShowDialog(this);

            receivedBagDataGridView.DataSource = getReceivedBags();
            issuedBagDataGridView.DataSource = getIssuedBags();
            setProgress();
        }

        private void issuedBagDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tmp = issuedBagDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            issuedItemDataGridView.DataSource = getIssuedItems(Int32.Parse(tmp));

            issuedItemDataGridView.RowHeadersVisible = false;
            issuedItemDataGridView.Columns[0].Visible = false;
            issuedItemDataGridView.Columns[1].Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string deptName = "Die";
            int deptNo = 1;
            DateTime date = receivedDatePicker.Value;
            string qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued " +
                    "from bag b inner join department d " +
                    "on b.deptNo=d.deptNo " +
                    "where b.date='" + date.ToString("yyyy/M/d") + "'";
            
            Object tmpDeptNameObj = DeptCmb.SelectedItem;
            string tmpBagNo = bagNoTxtBox.Text;

            if ((tmpDeptNameObj == null) && (tmpBagNo.Equals("")))
            {
                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued " +
                    "from bag b inner join department d " +
                    "on b.deptNo=d.deptNo " +
                    "where b.date='" + date.ToString("yyyy/M/d") + "'";
            }
            else if ((tmpDeptNameObj != null) && (tmpBagNo.Equals("")))
            {
                deptName = DeptCmb.SelectedItem.ToString();

                MySqlDataReader readerDept = DBConnection.getData("select * from department " +
                                                            "where deptName='" + deptName + "'");

                while (readerDept.Read())
                {
                    deptNo = readerDept.GetInt32("deptNo");
                }

                readerDept.Close();

                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued " +
                    "from bag b inner join department d " +
                    "on b.deptNo=d.deptNo " +
                    "where d.deptNo=" + deptNo + " and b.date='" + date.ToString("yyyy/M/d") + "'";
            }
            else if ((tmpDeptNameObj == null) && (!tmpBagNo.Equals("")))
            {
                try
                {
                    int bagNo = Int32.Parse(bagNoTxtBox.Text);

                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued " +
                    "from bag b inner join department d " +
                    "on b.deptNo=d.deptNo " +
                    "where b.bagNo=" + bagNo + " and b.date='" + date.ToString("yyyy/M/d") + "'";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid data!\nCheck Bag No value", "Bags finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((tmpDeptNameObj != null) && (!tmpBagNo.Equals("")))
            {
                deptName = DeptCmb.SelectedItem.ToString();

                MySqlDataReader readerDept = DBConnection.getData("select * from department " +
                                                            "where deptName='" + deptName + "'");

                while (readerDept.Read())
                {
                    deptNo = readerDept.GetInt32("deptNo");
                }

                readerDept.Close();

                try
                {
                    int bagNo = Int32.Parse(bagNoTxtBox.Text);

                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued " +
                    "from bag b inner join department d " +
                    "on b.deptNo=d.deptNo " +
                    "where d.deptNo=" + deptNo + " and b.bagNo=" + bagNo + " and b.date='" + date.ToString("yyyy/M/d") + "'";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid data!\nCheck Bag No value", "Bags finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*
            try
            {
                deptName = DeptCmb.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a department!", "Bags finder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            MySqlDataReader readerDept = DBConnection.getData("select * from department where deptName='" + deptName + "'");

            while (readerDept.Read())
            {
                deptNo = readerDept.GetInt32("deptNo");
            }

            readerDept.Close();
            */
            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table = new System.Data.DataTable();

                    table.Load(reader);

                    receivedBagDataGridView.DataSource = table;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No records for this data!", "Bags finder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data!", "Bags finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private System.Data.DataTable getReceivedBagsByDept(string deptName)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            int deptNo = 1;

            MySqlDataReader readerDept = DBConnection.getData("select * from department where deptName='" + deptName + "'");

            while (readerDept.Read())
            {
                deptNo = readerDept.GetInt32("deptNo");
            }

            readerDept.Close();

            MySqlDataReader reader = DBConnection.getData("select b.bag_id, d.deptName, b.date, b.bagNo, b.issued from bag b inner join department d on b.deptNo=d.deptNo where d.deptNo=" + deptNo);

            table.Load(reader);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptCmb.SelectedIndex = 0;
            bagNoTxtBox.Clear();
            receivedBagDataGridView.DataSource = getReceivedBags();
        }

        private void receivedDatePicker_ValueChanged(object sender, EventArgs e)
        {/*
            DateTime date = receivedDatePicker.Value;

            System.Data.DataTable table = getReceivedBagsByDate(date);

            if (table != null)
            {
                receivedBagDataGridView.DataSource = table;
            }
            else
            {
                MessageBox.Show("No records of this date!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private System.Data.DataTable getReceivedBagsByDate(DateTime date)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select b.bag_id, d.deptName, b.date, b.bagNo, b.issued from bag b inner join department d on b.deptNo=d.deptNo where b.date='" + date.ToString("yyyy/M/d") + "'");

            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            else
            {
                table.Load(reader);

                return table;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.backupDB();
        }
    }
}
