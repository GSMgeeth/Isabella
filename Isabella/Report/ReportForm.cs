using Isabella.Report;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = reportDatePicker.Value;
            Object tmpDeptNameObj = DeptCmbMonthly.SelectedItem;
            string qry = "";

            if (tmpDeptNameObj == null)
            {
                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo where MONTH(b.date)=" + date.Month;
            }
            else
            {
                string deptName = tmpDeptNameObj.ToString();

                if (deptName.Equals("All"))
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo where MONTH(b.date)=" + date.Month;
                }
                else
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo " +
                            "where d.deptName='" + deptName + "' and MONTH(b.date)=" + date.Month;
                }
            }
            
            testReport frm = new testReport(qry);

            frm.Show();
        }
        
        private void BalanceSelectedMonth_Click(object sender, EventArgs e)
        {
            DateTime date = reportDatePicker.Value;
            Object tmpDeptNameObj = DeptCmbMonthly.SelectedItem;
            string qry = "";

            if (tmpDeptNameObj == null)
            {
                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and MONTH(b.date)=" + date.Month;
            }
            else
            {
                string deptName = tmpDeptNameObj.ToString();

                if (deptName.Equals("All"))
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and MONTH(b.date)=" + date.Month;
                }
                else
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and d.deptName='" + deptName + "' and MONTH(b.date)=" + date.Month;
                }
            }
            
            testReport frm = new testReport(qry);

            frm.Show();
        }

        private void IssuedSelectedMonth_Click_1(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIssued.Value;

            string qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "inner join issuedto i on i.place_id=b.place_id " +
                            "where b.issued=1 and MONTH(b.date)=" + date.Month;

            testReport frm = new testReport(qry);

            frm.Show();
        }

        private void allSelectedDay_Click(object sender, EventArgs e)
        {
            DateTime date = dailyReportDateTimePicker.Value;
            Object tmpDeptNameObj = DeptCmbMonthly.SelectedItem;
            string qry = "";

            if (tmpDeptNameObj == null)
            {
                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo where b.date<='" + date.ToString("yyyy/M/d") + "'";
            }
            else
            {
                string deptName = tmpDeptNameObj.ToString();

                if (deptName.Equals("All"))
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo where b.date='" + date.ToString("yyyy/M/d") + "'";
                }
                else
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b left join issuedto i on b.place_id=i.place_id " +
                            "inner join department d on b.deptNo=d.deptNo " +
                            "where d.deptName='" + deptName + "' and b.date='" + date.ToString("yyyy/M/d") + "'";
                }
            }
            
            testReport frm = new testReport(qry);

            frm.Show();
        }

        private void balanceSelectedDay_Click(object sender, EventArgs e)
        {
            DateTime date = dailyReportDateTimePicker.Value;
            Object tmpDeptNameObj = DeptCmbMonthly.SelectedItem;
            string qry = "";

            if (tmpDeptNameObj == null)
            {
                qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and b.date<='" + date.ToString("yyyy/M/d") + "'";
            }
            else
            {
                string deptName = tmpDeptNameObj.ToString();

                if (deptName.Equals("All"))
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and b.date='" + date.ToString("yyyy/M/d") + "'";
                }
                else
                {
                    qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "left join issuedto i on b.place_id=i.place_id " +
                            "where b.issued=0 and d.deptName='" + deptName + "' and b.date='" + date.ToString("yyyy/M/d") + "'";
                }
            }
            
            testReport frm = new testReport(qry);

            frm.Show();
        }

        private void issuedSelectedDay_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerIssuedDaily.Value;

            string qry = "select b.bag_id, d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "inner join issuedto i on i.place_id=b.place_id " +
                            "where b.issued=1 and b.date='" + date.ToString("yyyy/M/d") + "'";

            testReport frm = new testReport(qry);

            frm.Show();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            fillDeptCmb();
        }

        public void fillDeptCmb()
        {
            MySqlDataReader reader = DBConnection.getData("select * from department");

            DeptCmbMonthly.Items.Add("All");
            DeptCmbDaily.Items.Add("All");

            while (reader.Read())
            {
                DeptCmbMonthly.Items.Add(reader.GetString("deptName"));
                DeptCmbDaily.Items.Add(reader.GetString("deptName"));
            }

            reader.Close();
        }

        private void summaryRepBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SummaryIssuedBtn_Click(object sender, EventArgs e)
        {
            string qry = "SELECT COUNT(i.item_id) as itemQty, t.place as place FROM bag b " +
                            "LEFT JOIN issuedto t ON b.place_id=t.place_id " +
                            "INNER JOIN item i on b.bag_id=i.bag_id " +
                            "WHERE issued=1 " +
                            "GROUP BY i.bag_id;";

            summaryReportForm frm = new summaryReportForm(qry);

            frm.Show();
        }
    }
}
