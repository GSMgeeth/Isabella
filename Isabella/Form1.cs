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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using _Excel = Microsoft.Office.Interop.Excel;

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

        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {

        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Workbook|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = openFileDialog1.SafeFileName;

            if (name.Contains(".xlsx"))
            {
                _Application excel = new _Excel.Application();
                Workbook wb;
                Worksheet ws;

                string path = "C:/Users/Geeth Sandaru/Downloads/" + name;

                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[1];

                double deptNo = ws.Cells[1, 1].Value2;
                string date = ws.Cells[1, 2].Value2.ToString();
                double qty = ws.Cells[1, 3].Value2;

                string day = date.Substring(1, date.IndexOf('/') - 1);
                string tmpMonth = date.Substring(date.IndexOf('/') + 1);
                string month = tmpMonth.Substring(0, tmpMonth.IndexOf('/'));
                string year = tmpMonth.Substring((tmpMonth.IndexOf('/') + 1), 4);

                DateTime d = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                int q = (int)qty;
                Department dept = new Department((int)deptNo);

                Bag bag = new Bag(d, q, dept);

                DataTextBox.Text = "Bag deptNo : " + deptNo + "\nBag sent date : " + date + "\nQuantity : " + qty + "\n";
                DataTextBox.AppendText("\nyear : " + year + "  " + d.Year);
                DataTextBox.AppendText("\nmonth : " + month + "  " + d.Month);
                DataTextBox.AppendText("\nday : " + day + "  " + d.Day + "\n\n");
                
                for (int i = 0; i < (int)qty; i++)
                {
                    string color = ws.Cells[(i + 2), 1].Value2;
                    string size = ws.Cells[(i + 2), 2].Value2;
                    string article = ws.Cells[(i + 2), 3].Value2;

                    string tmp = "\nItem " + (i + 1) + " : " + color + " " + size + " " + article;

                    DataTextBox.AppendText(tmp);

                    bag.addItem(i, color, size, article);
                }
                
                try
                {
                    MySqlDataReader reader = DBConnection.getData("select * from department");

                    while (reader.Read())
                    {
                        int dNo = reader.GetInt32("deptNo");
                        string deptName = reader.GetString("deptName");

                        string tmp2 = "\nDept : " + dNo + " " + deptName;

                        DataTextBox.AppendText(tmp2);
                    }

                    reader.Close();

                    Database.saveBag(bag);

                    receivedBagDataGridView.DataSource = getReceivedBags();
                }
                catch (Exception exc)
                {
                    DataTextBox.AppendText("\n" + exc.Message);
                    DataTextBox.AppendText("\n\n" + exc.StackTrace);
                }
                finally
                {
                    wb.Close();
                    excel.Quit();

                    Marshal.ReleaseComObject(wb);
                    Marshal.ReleaseComObject(excel);
                }
            }
        }

        private void Isabella_Load(object sender, EventArgs e)
        {
            receivedBagDataGridView.DataSource = getReceivedBags();
            issuedBagDataGridView.DataSource = getIssuedBags();

            receivedBagDataGridView.Columns[0].Visible = false;
            issuedBagDataGridView.Columns[0].Visible = false;

            fillDeptComboBox();
        }

        private void fillDeptComboBox()
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

            MySqlDataReader reader = DBConnection.getData("select * from bag where issued=1");

            table.Load(reader);

            return table;
        }

        private System.Data.DataTable getReceivedBags()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select b.bag_id, d.deptName, b.date, b.issued from bag b inner join department d on b.deptNo=d.deptNo");

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

            return table;
        }

        private System.Data.DataTable getIssuedItems(int bag_id)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from item where bag_id=" + bag_id);

            table.Load(reader);

            return table;
        }

        private void receivedBagDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tmp = receivedBagDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            Bag bag = new Bag(Int32.Parse(tmp));

            bag.issue();

            Database.issueBag(bag);

            receivedBagDataGridView.DataSource = getReceivedBags();
            issuedBagDataGridView.DataSource = getIssuedBags();
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
            string deptName = DeptCmb.SelectedItem.ToString();

            receivedBagDataGridView.DataSource = getReceivedBagsByDept(deptName);
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

            MySqlDataReader reader = DBConnection.getData("select * from bag where deptNo=" + deptNo);

            table.Load(reader);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptCmb.SelectedIndex = 0;
            receivedBagDataGridView.DataSource = getReceivedBags();
        }

        private void receivedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = receivedDatePicker.Value;

            System.Data.DataTable table = getReceivedBagsByDate(date);

            if (table != null)
            {
                receivedBagDataGridView.DataSource = table;
            }
            else
            {
                MessageBox.Show("No records of this date!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private System.Data.DataTable getReceivedBagsByDate(DateTime date)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from bag where date='" + date.ToString("yyyy/M/d") + "'");

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
    }
}
