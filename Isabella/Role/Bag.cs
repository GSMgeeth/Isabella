using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isabella.Role
{
    class Bag
    {
        private int bag_id;
        private DateTime date;
        private int qty;
        private bool issued;
        private Department dept;

        Item[] items;

        public Bag(DateTime date, int qty, Department dept)
        {
            this.date = date;
            this.qty = qty;
            this.issued = false;
            this.dept = dept;
            items = new Item[qty];
        }

        public bool addItem(int index, string color, string size, string article)
        {
            if (index >= 0 && index < qty)
            {
                if (items[index] == null)
                {
                    items[index] = new Item(color, size, article);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void setBag_id(int bag_id)
        {
            this.bag_id = bag_id;
        }

        public int getBag_id()
        {
            return bag_id;
        }
    }
}
