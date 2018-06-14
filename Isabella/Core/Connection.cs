using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Isabella
{
    class DBConnection
    {
        private static string connString = string.Format("Server=localhost; database=Isabella; UID=root; password=; SSLMode=none");
        private static MySqlConnection conn = new MySqlConnection(connString);

        private DBConnection() { }

        private static MySqlConnection getConnection()
        {
            if (conn != null)
            {
                if (conn.State.ToString().Equals("closed") || conn.State.ToString().Equals("Closed"))
                    conn.Open();

                return conn;
            }
            else
            {
                return null;
            }
        }
        
        public static MySqlDataReader getData(string qry)
        {
            if (conn != null)
                return new MySqlCommand(qry, getConnection()).ExecuteReader();
            else
                return null;
        }

        public static void updateDB(string qry)
        {
            if (conn != null)
            {
                new MySqlCommand(qry, getConnection()).ExecuteNonQuery();
            }
        }
    }
}
