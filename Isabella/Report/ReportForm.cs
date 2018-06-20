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

            string qry = "select d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "inner join issuedto i on i.place_id=b.place_id where MONTH(b.date)=" + date.Month;

            testReport frm = new testReport(date, qry);

            frm.Show();
        }

        private void IssuedSelectedMonth_Click(object sender, EventArgs e)
        {
            DateTime date = reportDatePicker.Value;

            string qry = "select d.deptName, b.date, b.bagNo, b.issued, i.place " +
                            "from bag b inner join department d on b.deptNo=d.deptNo " +
                            "inner join issuedto i on i.place_id=b.place_id " +
                            "where b.issued=1 and MONTH(b.date)=" + date.Month;

            testReport frm = new testReport(date, qry);

            frm.Show();
        }
    }
}
