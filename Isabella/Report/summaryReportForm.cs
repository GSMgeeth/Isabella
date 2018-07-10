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

namespace Isabella.Report
{
    public partial class summaryReportForm : Form
    {
        private string qry;

        public summaryReportForm(string qry)
        {
            this.qry = qry;
            InitializeComponent();
        }

        private void summaryReportForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            table.Columns.Add("ItemCount", typeof(uint));
            table.Columns.Add("IssuedPlace", typeof(string));

            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetUInt32("itemQty"), reader.GetString("place"));
                    }

                    reader.Close();
                    
                    SummaryReport rpt = new SummaryReport();

                    rpt.Database.Tables["SummaryDataTable"].SetDataSource(table);

                    crystalReportViewerSummary.ReportSource = null;
                    crystalReportViewerSummary.ReportSource = rpt;
                }
                else
                {
                    reader.Close();
                    
                    MessageBox.Show("Sorry, no Issues yet!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, no Issues yet!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
