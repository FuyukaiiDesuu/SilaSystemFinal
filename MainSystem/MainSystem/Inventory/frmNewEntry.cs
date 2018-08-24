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
            
        }

        private Boolean flag()
        {
            Int32 i;
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query = "SELECT COUNT(*) FROM inventory WHERE item_id = @itm";
                using (var com = new MySqlCommand(query, dbconnection))
                {
                    com.Parameters.AddWithValue("@itm", ayaya);
                    i = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            if(i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private string getInventoryID()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE item_id = '" + ayaya + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                return dt.Rows[0]["invID"].ToString();  
            }
        }

        private void create_default()
        {
            if(!flag())
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string query = "insert into inventory(item_id, quantity, status) values(@ayd, @quant, @status);";
                    using (var com = new MySqlCommand(query, dbconnection))
                    {
                        com.Parameters.AddWithValue("@ayd", ayaya);
                        com.Parameters.AddWithValue("@quant", 0);
                        com.Parameters.AddWithValue("@status", 1);
                        com.ExecuteNonQuery();
                    }
                    
                }
                txtinvID.Text = getcount();
            }
            else
            {
                MessageBox.Show("WARNING ITEM ALREADY IN INVENTORY!");
                txtinvID.Text = getInventoryID();
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
            //CREATE FLAG HERE!
            if (!flag())
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    using (var command = new MySqlCommand("INSERT INTO stkin(inventory_id, date, misc_desc, quantity, status) VALUES(@inventory_id, @date, @misc_desc, @quantity, @status);", dbconnection))
                    {
                        dbconnection.Open();
                        command.Parameters.AddWithValue("@inventory_id", getcount());
                        command.Parameters.AddWithValue("@date", label2.Text);
                        command.Parameters.AddWithValue("@misc_desc", txtdesc.Text);
                        command.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        command.Parameters.AddWithValue("@status", 0);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Successfully Added");
                this.Close();
                reference.Show();
                reference.readData2();
            }
            else
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    using (var command = new MySqlCommand("INSERT INTO stkin(inventory_id, date, misc_desc, quantity, status) VALUES(@inventory_id, @date, @misc_desc, @quantity, @status);", dbconnection))
                    {
                        dbconnection.Open();
                        command.Parameters.AddWithValue("@inventory_id", getInventoryID());
                        command.Parameters.AddWithValue("@date", label2.Text);
                        command.Parameters.AddWithValue("@misc_desc", txtdesc.Text);
                        command.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        command.Parameters.AddWithValue("@status", 0);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Successfully Added");
                this.Close();
                reference.Show();
                reference.readData2();
            }
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

        private void gboxentry_Enter(object sender, EventArgs e)
        {

        }
    }
}

