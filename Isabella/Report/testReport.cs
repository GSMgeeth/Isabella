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
            DataTable tableItem = new DataTable();
            //create a second item table and define columns. Then, inside the if statement, initialize the rows
            //Then,  put it on the rpt.Database.Tables["items"].setDataSource(table2);
            MySqlDataReader reader = null;
            MySqlDataReader readerItems = null;

            table.Columns.Add("Bag_id", typeof(int));
            table.Columns.Add("DeptName", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("BagNo", typeof(int));
            table.Columns.Add("Issued", typeof(bool));
            table.Columns.Add("Place", typeof(string));

            tableItem.Columns.Add("Item_id", typeof(int));
            tableItem.Columns.Add("Bag_id", typeof(int));
            tableItem.Columns.Add("Color", typeof(string));
            tableItem.Columns.Add("Size", typeof(string));
            tableItem.Columns.Add("Article", typeof(string));
            
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
                            table.Rows.Add(reader.GetInt32("bag_id"), reader.GetString("deptName"), reader.GetDateTime("date"), reader.GetInt32("bagNo"), reader.GetBoolean("issued"), reader.GetString("place"));
                        else
                            table.Rows.Add(reader.GetInt32("bag_id"), reader.GetString("deptName"), reader.GetDateTime("date"), reader.GetInt32("bagNo"), reader.GetBoolean("issued"), "null");

                        int bag_id = reader.GetInt32("bag_id");

                        readerItems = DBConnection.getDataViaTmpConnection("select item_id, bag_id, color, size, article from item where bag_id=" + bag_id);

                        if (readerItems.HasRows)
                        {
                            while (readerItems.Read())
                            {
                                tableItem.Rows.Add(readerItems.GetString("item_id"), readerItems.GetString("bag_id"), readerItems.GetString("color"), readerItems.GetString("size"), readerItems.GetString("article"));
                            }

                            readerItems.Close();
                            DBConnection.closeTmpConnection();
                        }
                    }

                    reader.Close();
                    
                    if (readerItems != null)
                        if (!readerItems.IsClosed)
                            readerItems.Close();
                            
                    Report.BagReport rpt = new Report.BagReport();

                    rpt.Database.Tables["Bags"].SetDataSource(table);
                    rpt.Database.Tables["Items"].SetDataSource(tableItem);

                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    reader.Close();
                    
                    if (readerItems != null)
                        if (!readerItems.IsClosed)
                            readerItems.Close();
                            
                    MessageBox.Show("No records of this date!", "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {   
                if (readerItems != null)
                    if (!readerItems.IsClosed)
                        readerItems.Close();
                        
                MessageBox.Show("No records of this date!\n" + ex.Message + "\n" + ex.StackTrace, "Bags picker by date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
