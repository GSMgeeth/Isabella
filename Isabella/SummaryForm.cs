﻿using MySql.Data.MySqlClient;
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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            fillDeptComboBox();
        }

        public void fillDeptComboBox()
        {
            DeptCmb.Items.Clear();

            DeptCmb.Items.Add("All");

            MySqlDataReader reader = DBConnection.getData("select * from department");

            while (reader.Read())
            {
                DeptCmb.Items.Add(reader.GetString("deptName"));
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string place = "";
            string qry = "";

            Object tmpPlaceObj = DeptCmb.SelectedItem;
            string color = searchColortxt.Text;
            string size = searchSizeTxt.Text;
            string article = searchArticleTxt.Text;

            if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.article='" + article + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.size='" + size + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.article='" + article + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.article='" + article + "' and i.size='" + size + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
            {
                qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' group by i.article, i.color, i.size;";
            }
            else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.article='" + article + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.article='" + article + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.size='" + size + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.article='" + article + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.color='" + color + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' and i.article='" + article + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }
            else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
            {
                place = DeptCmb.SelectedItem.ToString();

                if (place.Equals("All"))
                {
                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' group by i.article, i.color, i.size;";
                }
                else
                {
                    int place_id = 1;
                    MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + place + "'");

                    while (reader.Read())
                    {
                        place_id = reader.GetInt32("deptNo");
                    }

                    reader.Close();

                    qry = "select i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                    "department d on b.deptNo=d.deptNo where b.Issued = 0 and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by i.article, i.color, i.size;";
                }
            }

            previewReport(qry);
        }

        private void previewReport(string qry)
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = null;

            table.Columns.Add("Article", typeof(string));
            table.Columns.Add("Color", typeof(string));
            table.Columns.Add("Size", typeof(string));
            table.Columns.Add("Qty", typeof(int));

            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("Article"), reader.GetString("Color"), reader.GetString("Size"), reader.GetInt32("Qty"));
                    }

                    reader.Close();

                    Report.SummaryFormReport rpt = new Report.SummaryFormReport();

                    rpt.Database.Tables["Items"].SetDataSource(table);
                    
                    summaryReportViewer.ReportSource = null;
                    summaryReportViewer.ReportSource = rpt;
                }
                else
                {
                    reader.Close();

                    MessageBox.Show("No records!", "Items picker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Items picker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
