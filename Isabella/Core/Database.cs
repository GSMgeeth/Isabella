using Isabella.Role;
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
    }
}
