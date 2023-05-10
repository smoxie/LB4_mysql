using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
     class DBUtils
    {
       

        public static MySqlConnection GetDBConnection()
        {
            string host = "D7HLK8T";
            int port = 3306;
            string database = "dental_hospital";
            string username = "xxxxxS";
            string password = "xxxxxXk";
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
      
       
    }
}