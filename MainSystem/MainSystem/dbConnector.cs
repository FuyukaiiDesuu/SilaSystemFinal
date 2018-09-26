using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MainSystem
{
    class dbConnector
    {
        public MySqlConnection connector()
        {
            String connecttodb = "server=169.254.182.2;username=dominic;password=root;database=silasystemdb";
            //String connecttodb = "server=192.168.254.108;username=user_test;password=123456789;database=silasystemdb";
            MySqlConnection conn = new MySqlConnection(connecttodb);
            return conn;
        }
    }
}
