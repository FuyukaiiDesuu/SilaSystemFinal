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
using System.Text.RegularExpressions;

namespace MainSystem
{
    public partial class itemview : Form
    {
        private MySqlConnection dbconnection;
        public frmitemmanagement reference { get; set; }
        public itemview()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void itemview_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Inactive";
            dataGridView1.ClearSelection();
            readData();
            disablebtn();
            btnconfirm.Enabled = false;
        }
        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE itemstatus = 0;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
                dataGridView1.Columns["itemstatus"].Visible = false;
                dataGridView1.Columns["date_modified"].HeaderText = "Date Modified";
                dataGridView1.Columns["item_code"].HeaderText = "Item Code";
                dataGridView1.Columns["date_of_creation"].HeaderText = "Date of Creation";
            }
        }
        public void readData2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE itemstatus = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
                dataGridView1.Columns["itemstatus"].Visible = false;
            }
        }

        private void disablebtn()
        {
           
        }

        private void cmbstatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM itemdetails where itemname like '%" + txtsearch.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               id = dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString();
            }
        }
        private void activator()
        {
            DialogResult res = MessageBox.Show("Confirm Item Activation?", "Confirm Action!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string query2 = "UPDATE itemdetails SET itemstatus = @istatus WHERE itemID = @ayd;";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@istatus", 1);
                        command2.Parameters.AddWithValue("@ayd", id);
                        command2.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("ITEM/S ACTIVATED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readData();
            }
        }
        private void deactivator()
        {
            DialogResult res = MessageBox.Show("Confirm Item Deactivation?", "Confirm Action!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string query2 = "UPDATE itemdetails SET itemstatus = @istatus WHERE itemID = @ayd;";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@istatus", 0);
                        command2.Parameters.AddWithValue("@ayd", id);
                        command2.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("ITEM/S DEACTIVATED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readData2();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                    activator();
            }
            else
            {
                MessageBox.Show("There Are No Selected Item/s!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Inactive")
            {
                button1.Enabled = true;
                button2.Enabled = false;
                readData();
                dataGridView1.ClearSelection();
            }
            else
            {
                button2.Enabled = true;
                button1.Enabled = false;
                readData2();
                dataGridView1.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                deactivator();
            }
            else
            {
                MessageBox.Show("There Are No Selected Item/s!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b,.-]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("The Text Must Can Only Consist Of Alphabets and Numbers, and The Characters: '-,.'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
