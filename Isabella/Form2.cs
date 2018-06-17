using Isabella.Role;
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
    }
}
