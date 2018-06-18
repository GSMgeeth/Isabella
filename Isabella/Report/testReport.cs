using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isabella
{
    public partial class testReport : Form
    {
        private DateTime date;

        public testReport(DateTime date)
        {
            this.date = date;
            InitializeComponent();
        }

        private void testReport_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("DeptName", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("BagNo", typeof(int));
            table.Columns.Add("Issued", typeof(bool));
            
            try
            {
                MySqlDataReader reader = DBConnection.getData("select d.deptName, b.date, b.bagNo, b.issued " +
                            "from bag b inner join department d on b.deptNo=d.deptNo where MONTH(b.date)=" + date.Month);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("deptName"), reader.GetDateTime("date"), reader.GetInt32("bagNo"), reader.GetBoolean("issued"));
                    }

                    reader.Close();

                    Report.BagReport rpt = new Report.BagReport();

                    rpt.Database.Tables["Bags"].SetDataSource(table);

                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No records of this date!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records of this date!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
