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
        }

        private System.Data.DataTable getReceivedBags()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from bag");

            table.Load(reader);

            return table;
        }

        private void receivedBagDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //receivedBagDataGridView.
            //receivedItemDataGridView.DataSource = getReceivedItems();
            string tmp = receivedBagDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            label3.Text = tmp;
        }

        private System.Data.DataTable getReceivedItems()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            //MySqlDataReader reader = DBConnection.getData("select * from item where bag_id=");

            //table.Load(reader);

            return table;
        }
    }
}
