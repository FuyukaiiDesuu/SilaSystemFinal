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
    public partial class frmOrderList : Form
    {
        public FormInventory reference { get; set; }
        public MySqlConnection dbconnection;
        public string itemid;
       

        public frmOrderList()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void lblDate2_Click(object sender, EventArgs e)
        {

        }

        private void lbldateReq_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM itemdetails";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataItemCreation.DataSource = dt;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command = new MySqlCommand("INSERT INTO orderlist(date, vendor, quantity, status, item_id) VALUES(@date, @vendor, @quantity, @status, @item_id);", dbconnection))
                {
                    dbconnection.Open();
                    command.Parameters.AddWithValue("@item_name", txtitemname2.Text);
                    command.Parameters.AddWithValue("@date", dateDate.Text);
                    command.Parameters.AddWithValue("@vendor", txtvendor.Text);
                    command.Parameters.AddWithValue("@quantity", txtquantity2.Text);
                    command.Parameters.AddWithValue("@status", 1);
                    command.Parameters.AddWithValue("@item_id", itemid);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Successfully Added");
            readData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataItemCreation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataItemCreation.Rows.Count > 0)
            {
                txtitemname2.Text = dataItemCreation.Rows[e.RowIndex].Cells["itemname"].Value.ToString();
                itemid = dataItemCreation.Rows[e.RowIndex].Cells["itemID"].Value.ToString();
            }
        }
    }
}
