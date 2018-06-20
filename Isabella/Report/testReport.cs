using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Isabella
{
    public partial class testReport : Form
    {
        private string qry;

        public testReport(string qry)
        {
            this.qry = qry;
            InitializeComponent();
        }

        private void testReport_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            //create a second item table and define columns. Then, inside the if statement, initialize the rows
            //Then,  put it on the rpt.Database.Tables["items"].setDataSource(table2);
            MySqlDataReader reader = null;

            table.Columns.Add("DeptName", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("BagNo", typeof(int));
            table.Columns.Add("Issued", typeof(bool));
            table.Columns.Add("Place", typeof(string));
            
            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Object o;

                        try
                        {
                            o = reader.GetString("place");
                        }
                        catch (Exception)
                        {
                            o = null;
                        }

                        if (o != null)
                            table.Rows.Add(reader.GetString("deptName"), reader.GetDateTime("date"), reader.GetInt32("bagNo"), reader.GetBoolean("issued"), reader.GetString("place"));
                        else
                            table.Rows.Add(reader.GetString("deptName"), reader.GetDateTime("date"), reader.GetInt32("bagNo"), reader.GetBoolean("issued"), "null");
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
            catch (Exception ex)
            {
                reader.Close();
                MessageBox.Show("No records of this date!\n" + ex.Message, "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
