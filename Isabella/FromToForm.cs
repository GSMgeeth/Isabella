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
    public partial class FromToForm : Form
    {
        private Object typeItem;
        private bool isArticle = false, isColor = false, isSize = false;

        public FromToForm()
        {
            InitializeComponent();
        }

        private void FromToForm_Load(object sender, EventArgs e)
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
            typeItem = typeCmbBox.SelectedItem;
            string color = searchColortxt.Text;
            string size = searchSizeTxt.Text;
            string article = searchArticleTxt.Text;
            
            DateTime from = fromDatePicker.Value;
            DateTime to = toDatePicker.Value;

            if (color.Equals("") && size.Equals("") && article.Equals(""))
            {
                isArticle = true;
                isColor = true;
                isSize = true;
            }
            else if (!color.Equals("") && size.Equals("") && article.Equals(""))
            {
                isArticle = false;
                isColor = true;
                isSize = false;
            }
            else if (color.Equals("") && !size.Equals("") && article.Equals(""))
            {
                isArticle = false;
                isColor = false;
                isSize = true;
            }
            else if (color.Equals("") && size.Equals("") && !article.Equals(""))
            {
                isArticle = true;
                isColor = false;
                isSize = false;
            }
            else if (!color.Equals("") && !size.Equals("") && article.Equals(""))
            {
                isArticle = false;
                isColor = true;
                isSize = true;
            }
            else if (!color.Equals("") && size.Equals("") && !article.Equals(""))
            {
                isArticle = true;
                isColor = true;
                isSize = false;
            }
            else if (color.Equals("") && !size.Equals("") && !article.Equals(""))
            {
                isArticle = true;
                isColor = false;
                isSize = true;
            }
            else if (!color.Equals("") && !size.Equals("") && !article.Equals(""))
            {
                isArticle = true;
                isColor = true;
                isSize = true;
            }

            if (typeItem == null)
            {
                MessageBox.Show("Please set the type to Received or Issued!", "Report Generator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (typeItem.ToString().Equals("Received"))
            {
                if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }

                previewReport(qry);
            }
            else if (typeItem.ToString().Equals("Issued"))
            {
                if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "issuedto d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }
                else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                {
                    place = DeptCmb.SelectedItem.ToString();

                    if (place.Equals("All"))
                    {
                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size;";
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

                        qry = "select b.issuedDate as Issued, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                        "department d on b.deptNo=d.deptNo where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size;";
                    }
                }

                previewReport(qry);
            }
        }

        private void previewReport(string qry)
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = null;
            
            table.Columns.Add("Issued", typeof(DateTime));
            table.Columns.Add("Department", typeof(string));
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
                        if (typeItem.ToString().Equals("Issued"))
                            table.Rows.Add(reader.GetDateTime("Issued"), reader.GetString("Department"), reader.GetString("Article"), reader.GetString("Color"), reader.GetString("Size"), reader.GetInt32("Qty"));
                        else if (typeItem.ToString().Equals("Received"))
                            table.Rows.Add(reader.GetDateTime("Received"), reader.GetString("Department"), reader.GetString("Article"), reader.GetString("Color"), reader.GetString("Size"), reader.GetInt32("Qty"));
                    }

                    reader.Close();

                    if (typeItem.ToString().Equals("Issued"))
                    {
                        if (isArticle && !isColor && !isSize)
                        {
                            Report.FromToArticleReport rpt = new Report.FromToArticleReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && isColor && !isSize)
                        {
                            Report.FromToColorReport rpt = new Report.FromToColorReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && !isColor && isSize)
                        {
                            Report.FromToSizeReport rpt = new Report.FromToSizeReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && isColor && !isSize)
                        {
                            Report.FromToArticleColorReport rpt = new Report.FromToArticleColorReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && !isColor && isSize)
                        {
                            Report.FromToArticleSizeReport rpt = new Report.FromToArticleSizeReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && isColor && isSize)
                        {
                            Report.FromToColorSizeReport rpt = new Report.FromToColorSizeReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && isColor && isSize)
                        {
                            Report.FromToFormReport rpt = new Report.FromToFormReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                    }
                    else if (typeItem.ToString().Equals("Received"))
                    {
                        if (isArticle && !isColor && !isSize)
                        {
                            Report.FromToArticleRcvReport rpt = new Report.FromToArticleRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && isColor && !isSize)
                        {
                            Report.FromToColorRcvReport rpt = new Report.FromToColorRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && !isColor && isSize)
                        {
                            Report.FromToSizeRcvReport rpt = new Report.FromToSizeRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && isColor && !isSize)
                        {
                            Report.FromToArticleColorRcvReport rpt = new Report.FromToArticleColorRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && !isColor && isSize)
                        {
                            Report.FromToArticleSizeRcvReport rpt = new Report.FromToArticleSizeRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (!isArticle && isColor && isSize)
                        {
                            Report.FromToColorSizeRcvReport rpt = new Report.FromToColorSizeRcvReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                        else if (isArticle && isColor && isSize)
                        {
                            Report.FromToRecievedFormReport rpt = new Report.FromToRecievedFormReport();

                            rpt.Database.Tables["Items"].SetDataSource(table);

                            fromToReportViewer.ReportSource = null;
                            fromToReportViewer.ReportSource = rpt;
                        }
                    }
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
