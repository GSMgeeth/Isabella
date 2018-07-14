using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isabella.Role
{
    class IssuedTo
    {
        private int place_id;
        private string place;

        public IssuedTo(int place_id, string place)
        {
            this.place_id = place_id;
            this.place = place;
        }

        public IssuedTo(string place)
        {
            this.place = place;
        }

        public int getPlace_id()
        {
            return place_id;
        }

        public string getPlace()
        {
            return place;
        }
    }
}
