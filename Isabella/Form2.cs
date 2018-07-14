using Isabella.Role;
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
    public partial class Form2 : Form
    {
        private int bag_id;

        public Form2(int bag_id)
        {
            InitializeComponent();
            this.bag_id = bag_id;
        }

        private void ydBtn_Click(object sender, EventArgs e)
        {
            Bag bag = new Bag(bag_id);

            bag.issue(1);

            Database.issueBag(bag);

            closeForm();
        }

        private void ethBtn_Click(object sender, EventArgs e)
        {
            Bag bag = new Bag(bag_id);

            bag.issue(2);

            Database.issueBag(bag);

            closeForm();
        }

        private void closeForm()
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = DBConnection.getData("select * from issuedTo");

            while (reader.Read())
            {
                issuePlaceCmb.Items.Add(reader.GetString("place"));
            }

            reader.Close();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            object tmpPlaceObj = issuePlaceCmb.SelectedItem;

            if (tmpPlaceObj != null)
            {
                string place = tmpPlaceObj.ToString();

                MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + place + "'");

                if (reader.HasRows)
                {
                    Bag bag = new Bag(bag_id);

                    while (reader.Read())
                    {
                        int place_id = reader.GetInt32("place_id");

                        bag.issue(place_id);
                    }

                    reader.Close();

                    Database.issueBag(bag);

                    closeForm();
                }
            }
        }
    }
}
