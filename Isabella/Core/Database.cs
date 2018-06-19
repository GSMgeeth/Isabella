using Isabella.Role;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isabella
{
    class Database
    {
        public static void saveDepartment(Department dept)
        {
            int deptNo = dept.getDeptNo();
            string deptName = dept.getDeptName();

            DBConnection.updateDB("insert into department (deptNo, deptName) values (" + deptNo + ", '" + deptName + "')");
        }

        public static bool isBagExists(Bag bag)
        {
            bool exists = false;

            try
            {
                DateTime date = bag.getDate();
                int qty = bag.getQty();
                int bagNo = bag.getBagNo();
                bool issued = bag.isIssued();
                int deptNo = bag.getDept().getDeptNo();

                MySqlDataReader reader = DBConnection.getData("select * from bag where deptNo=" + deptNo + " and date='" + date.ToString("yyyy/M/d") + "' and bagNo=" + bagNo);

                while (reader.Read())
                {
                    exists = true;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                throw;
            }

            return exists;
        }

        public static void saveBag(Bag bag)
        {
            try
            {
                DateTime date = bag.getDate();
                int qty = bag.getQty();
                int bagNo = bag.getBagNo();
                bool issued = bag.isIssued();
                int deptNo = bag.getDept().getDeptNo();

                DBConnection.updateDB("insert into bag (deptNo, date, bagNo) values (" + deptNo + ", '" + date.ToString("yyyy/M/d") + "', " + bagNo + ")");

                MySqlDataReader reader = DBConnection.getData("select MAX(bag_id) as bag_id from bag where deptNo=" + deptNo + " and date='" + date.ToString("yyyy/M/d") + "' and issued=0 and bagNo=" + bagNo);
                int bag_id = -1;

                while (reader.Read())
                {
                    bag_id = reader.GetInt32("bag_id");
                }

                reader.Close();

                if (bag_id != -1)
                {
                    Item[] items = bag.getItems();

                    foreach (Item item in items)
                    {
                        string color = item.getColor();
                        string size = item.getSize();
                        string article = item.getArticle();

                        DBConnection.updateDB("insert into item (bag_id, color, size, article) values (" + bag_id + ", '" + color + "', '" + size + "', '" + article + "')");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void issueBag(Bag bag)
        {
            int bag_id = bag.getBag_id();
            int place_id = bag.getPlace_id();

            DBConnection.updateDB("update bag set issued=1, place_id=" + place_id + " where bag_id=" + bag_id);

            DBConnection.backupDB();
        }
    }
}
