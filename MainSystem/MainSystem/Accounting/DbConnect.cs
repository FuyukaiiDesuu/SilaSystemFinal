using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MainSystem.Accounting
{
    class DbConnect
    {
        private MySqlConnection connection;

        //Initialize values
        private void Initialize()
        {
            string Server = "localhost";
            string Database = "silasystemdb";
            string Uid = "root";
            string Password = "root";
            string Port = "3306";

            string connectionString;
            connectionString = "SERVER=" + Server + ";" + "DATABASE=" +
            Database + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";" + "PORT=" + Port + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("connection closed");
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void executeQuery(string query)
        {
            Initialize();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        //Select using datatable
        public DataTable Select(string query)
        {
            Initialize();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
