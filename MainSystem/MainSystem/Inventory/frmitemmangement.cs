using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class frmitemmanagement : Form
    {
        public FormInventory reference { get; set; }
        public MySqlConnection dbconnection;
        
        public frmitemmanagement()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                dbconnection.Open();
                    using (var command = new MySqlCommand("INSERT INTO itemdetails VALUES(DEFAULT, @item_code, @date_of_creation, @description, @itemstatus, @itemname)", dbconnection))
                    {
                        
                        command.Parameters.AddWithValue("@item_code", txtitemcode.Text);
                        command.Parameters.AddWithValue("@date_of_creation", System.DateTime.Now.ToString("yyyyMMdd")); 
                        command.Parameters.AddWithValue("@description", txtdesc.Text);
                        command.Parameters.AddWithValue("@itemstatus", txtstatus.Text);
                        command.Parameters.AddWithValue("@itemname", txtitemname.Text);
                        command.ExecuteNonQuery();
                    }

                }
            readData();
            
        }

        private void frmItemCreate_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM itemdetails where itemname like '" + txtsearch.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = connect.connector();
            string query = "update itemdetails set item_code" + txtitemcode.Text + "itemname" + txtitemname.Text + "description" + txtdesc.Text + "status" + txtstatus.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                reference.Show();
                readData();
            }
            catch(Exception)
            {

            }
            
        }
    }
}
