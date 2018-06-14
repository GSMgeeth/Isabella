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

                DataTextBox.Text = "Bag deptNo : " + deptNo + "\nBag sent date : " + date + "\nQuantity : " + qty + "\n";

                for (int i = 0; i < (int)qty; i++)
                {
                    string color = ws.Cells[(i + 2), 1].Value2;
                    string size = ws.Cells[(i + 2), 2].Value2;
                    string article = ws.Cells[(i + 2), 3].Value2;

                    string tmp = "\nItem " + (i + 1) + " : " + color + " " + size + " " + article;

                    DataTextBox.AppendText(tmp);
                }

                MySqlDataReader reader = null;
                string tmp2;

                try
                {
                    reader = DBConnection.getData("select * from department");

                    while (reader.Read())
                    {
                        int dNo = reader.GetInt32("deptNo");
                        string deptName = reader.GetString("deptName");

                        tmp2 = "\nDept : " + dNo + " " + deptName;

                        DataTextBox.AppendText(tmp2);
                    }

                    reader.Close();

                    //Department dept = new Department(4, "Knitting");

                    //Database.saveDepartment(dept);
                }
                catch (Exception exc)
                {
                    DataTextBox.AppendText("\n" + exc.Message);
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
    }
}
