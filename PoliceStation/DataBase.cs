using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConn
{
    class DataBase
    {
        
        public static MySqlConnection
GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
            + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
        public static MySqlConnection GetDBConnection()
        {
            string host = "q6vlad8t.beget.tech";
            int port = 3306;
            string database = "q6vlad8t_police";
            string username = "q6vlad8t_police";
            string password = "2Nrhpyve";

            return GetDBConnection(host, port, database, username, password);
        }



    }
}
