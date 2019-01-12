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
        private bool isArticle = false, isColor = false, isSize = false, isBagNo = false;

        public FromToForm()
        {
            InitializeComponent();
        }

        private void FromToForm_Load(object sender, EventArgs e)
        {
            fillDeptComboBox("received");
        }

        public void fillDeptComboBox(string type)
        {
            DeptCmb.Items.Clear();

            DeptCmb.Items.Add("All");

            if (type.Equals("received"))
            {
                MySqlDataReader reader = DBConnection.getData("select * from department");

                while (reader.Read())
                {
                    DeptCmb.Items.Add(reader.GetString("deptName"));
                }

                reader.Close();
            }
            else if (type.Equals("issued"))
            {
                MySqlDataReader reader = DBConnection.getData("select * from issuedTo");

                while (reader.Read())
                {
                    DeptCmb.Items.Add(reader.GetString("place"));
                }

                reader.Close();
            }
        }

        private void typeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object tmp = typeCmbBox.SelectedItem;

            if (tmp != null)
            {
                string type = tmp.ToString().ToLower();

                fillDeptComboBox(type);
            }
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
            string bagNo = bagNoTxtBox.Text;
            int bn = 0;
            
            DateTime from = fromDatePicker.Value;
            DateTime to = toDatePicker.Value;

            if (!bagNo.Equals(""))
                isBagNo = true;
            else
                isBagNo = false;

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
            else if (isBagNo && (!Int32.TryParse(bagNo, out bn)))
            {
                MessageBox.Show("Please enter a valid number as the Bag No!", "Report Generator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (typeItem.ToString().Equals("Received"))
            {
                if (isBagNo)
                {
                    if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, b.date, i.article;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.deptNo=" + place_id + " and b.bagNo=" + bn + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                }
                else
                {
                    if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, b.date, i.article;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' group by d.deptName, i.article, i.color, i.size, b.bagNo;";
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

                            qry = "select b.date as Received, d.deptName as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "department d on b.deptNo=d.deptNo where b.date>='" + from.ToString("yyyy/M/d") + "' and b.date<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.deptNo=" + place_id + " group by d.deptName, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                }
                
                previewReport(qry);
            }
            else if (typeItem.ToString().Equals("Issued"))
            {
                if (isBagNo)
                {
                    if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, b.date, i.article;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.place_id=" + place_id + " and b.bagNo=" + bn + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                }
                else
                {
                    if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            Console.WriteLine("\nplace : " + place + "      id : " + place_id + "\n");

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.place, b.date, i.article;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and i.size='" + size + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj == null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and i.article='" + article + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.article='" + article + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.size='" + size + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.color='" + color + "' and i.article='" + article + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                    }
                    else if ((tmpPlaceObj != null) && (!color.Equals("")) && (!size.Equals("")) && (!article.Equals("")))
                    {
                        place = DeptCmb.SelectedItem.ToString();

                        if (place.Equals("All"))
                        {
                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
                        else
                        {
                            int place_id = 1;
                            MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                            while (reader.Read())
                            {
                                place_id = reader.GetInt32("place_id");
                            }

                            reader.Close();

                            qry = "select b.issuedDate as Issued, d.place as Department, i.article as Article, i.color as Color, i.size as Size, IFNULL(COUNT(i.item_id), 0) as Qty, b.bagNo as BagNo from item i inner join bag b on i.bag_id=b.bag_id inner join " +
                            "issuedto d on b.place_id=d.place_id where b.Issued = 1 and b.issuedDate>='" + from.ToString("yyyy/M/d") + "' and b.issuedDate<='" + to.ToString("yyyy/M/d") + "' and i.size='" + size + "' and i.article='" + article + "' and i.color='" + color + "' and d.place_id=" + place_id + " group by d.place, i.article, i.color, i.size, b.bagNo;";
                        }
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
            table.Columns.Add("BagNo", typeof(int));

            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (typeItem.ToString().Equals("Issued"))
                            table.Rows.Add(reader.GetDateTime("Issued"), reader.GetString("Department"), reader.GetString("Article"), reader.GetString("Color"), reader.GetString("Size"), reader.GetInt32("Qty"), reader.GetInt32("BagNo"));
                        else if (typeItem.ToString().Equals("Received"))
                            table.Rows.Add(reader.GetDateTime("Received"), reader.GetString("Department"), reader.GetString("Article"), reader.GetString("Color"), reader.GetString("Size"), reader.GetInt32("Qty"), reader.GetInt32("BagNo"));
                    }

                    reader.Close();

                    if (typeItem.ToString().Equals("Issued"))
                    {
                        if (isBagNo)
                        {
                            if (isArticle && !isColor && !isSize)
                            {
                                Report.FromToArticleBagNoReport rpt = new Report.FromToArticleBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && isColor && !isSize)
                            {
                                Report.FromToColorBagNoReport rpt = new Report.FromToColorBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && !isColor && isSize)
                            {
                                Report.FromToSizeBagNoReport rpt = new Report.FromToSizeBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && isColor && !isSize)
                            {
                                Report.FromToArticleColorBagNoReport rpt = new Report.FromToArticleColorBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && !isColor && isSize)
                            {
                                Report.FromToArticleSizeBagNoReport rpt = new Report.FromToArticleSizeBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && isColor && isSize)
                            {
                                Report.FromToColorSizeBagNoReport rpt = new Report.FromToColorSizeBagNoReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && isColor && isSize)
                            {
                                Report.FromToBagNoFormReport rpt = new Report.FromToBagNoFormReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                        }
                        else
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
                    }
                    else if (typeItem.ToString().Equals("Received"))
                    {
                        if (isBagNo)
                        {
                            if (isArticle && !isColor && !isSize)
                            {
                                Report.FromToArticleBagNoRcvReport rpt = new Report.FromToArticleBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && isColor && !isSize)
                            {
                                Report.FromToColorBagNoRcvReport rpt = new Report.FromToColorBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && !isColor && isSize)
                            {
                                Report.FromToSizeBagNoRcvReport rpt = new Report.FromToSizeBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && isColor && !isSize)
                            {
                                Report.FromToArticleColorBagNoRcvReport rpt = new Report.FromToArticleColorBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && !isColor && isSize)
                            {
                                Report.FromToArticleSizeBagNoRcvReport rpt = new Report.FromToArticleSizeBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (!isArticle && isColor && isSize)
                            {
                                Report.FromToColorSizeBagNoRcvReport rpt = new Report.FromToColorSizeBagNoRcvReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                            else if (isArticle && isColor && isSize)
                            {
                                Report.FromToRecievedBagNoFormReport rpt = new Report.FromToRecievedBagNoFormReport();

                                rpt.Database.Tables["Items"].SetDataSource(table);

                                fromToReportViewer.ReportSource = null;
                                fromToReportViewer.ReportSource = rpt;
                            }
                        }
                        else
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
