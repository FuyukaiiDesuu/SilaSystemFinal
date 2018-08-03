using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MainSystem
{
    public partial class frmNewEntry : Form
    {
        public Stockin_out reference { get; set; }
        public MySqlConnection dbconnection;
        public String ayaya;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public frmNewEntry(IDictionary<string, string> dic)
        {

            InitializeComponent();
            txtitemname.Text = dic["name"];
            txtdesc.Text = dic["desc"];
            ayaya = dic["ayd"];

        }

        private void frmNewEntry_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            create_default();
            txtinvID.Text = getcount();
        }

        private void create_default()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query = "insert into inventory(item_id) values(@ayd);";
                using (var com = new MySqlCommand(query, dbconnection))
                {
                    com.Parameters.AddWithValue("@ayd", ayaya);
                    com.ExecuteNonQuery();
                }

                 
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        public String iiii;
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command = new MySqlCommand("INSERT INTO stkin(inventory_id, date, misc_desc, quantity) VALUES(@inventory_id, @date, @misc_desc, @quantity);", dbconnection))
                {
                    dbconnection.Open();
                    command.Parameters.AddWithValue("@inventory_id", getcount());
                    command.Parameters.AddWithValue("@date", label2.Text);
                    command.Parameters.AddWithValue("@misc_desc", txtdesc.Text);
                    command.Parameters.AddWithValue("@quantity", txtquantity.Text);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Successfully Added");
            this.Close();
            reference.Show();
            reference.readData2();
        }
        private String getcount()
        {
            Int32 iiii;
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command2 = new MySqlCommand("select count(*) from inventory;", dbconnection))
                {
                     iiii = Convert.ToInt32(command2.ExecuteScalar());
                }
            }
            return iiii.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        
    }
}

