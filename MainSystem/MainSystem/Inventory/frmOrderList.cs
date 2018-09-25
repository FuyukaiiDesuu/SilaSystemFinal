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
using System.Text.RegularExpressions;

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
        private void dgvformaters()
        {
            dataOrderList.DefaultCellStyle.ForeColor = Color.Black;
            dataOrderList.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcancelled.DefaultCellStyle.ForeColor = Color.Black;
            dgvcancelled.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dgvcancelled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcompleted.DefaultCellStyle.ForeColor = Color.Black;
            dgvcompleted.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dgvcompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataItemCreation.DefaultCellStyle.ForeColor = Color.Black;
            dataItemCreation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataItemCreation.DefaultCellStyle.Font = new Font("Tahoma", 14f);
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
                dataItemCreation.Columns["itemID"].Visible = false;
                dataItemCreation.Columns["itemstatus"].Visible = false;
                dataItemCreation.Columns["item_code"].HeaderText = "Item Code";
                dataItemCreation.Columns["date_of_creation"].HeaderText = "Date Created";
                dataItemCreation.Columns["description"].HeaderText = "Item Description";
                dataItemCreation.Columns["itemname"].HeaderText = "Item Name";
                dataItemCreation.Columns["date_modified"].HeaderText = "Date Modified";
            }
        }
        public void readDataOrderList()
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM itemdetails INNER JOIN orderlist ON itemdetails.itemID = orderlist.item_id WHERE orderlist.status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataOrderList.DataSource = dt;
                dataOrderList.Columns["itemID"].Visible = false;
                dataOrderList.Columns["itemstatus"].Visible = false;
                dataOrderList.Columns["id"].Visible = false;
                dataOrderList.Columns["item_id"].Visible = false;
                dataOrderList.Columns["status"].Visible = false;
                dataOrderList.Columns["status"].Visible = false;
                dataOrderList.Columns["item_code"].HeaderText = "Item Code";
                dataOrderList.Columns["date_of_creation"].HeaderText = "Date Created";
                dataOrderList.Columns["date"].HeaderText = "Date Delivery Due";
                dataOrderList.Columns["description"].HeaderText = "Item Description";
                dataOrderList.Columns["itemname"].HeaderText = "Item Name";
                dataOrderList.Columns["date_modified"].HeaderText = "Date Modified";
                dataOrderList.Columns["quantity_delivered"].HeaderText = "Quantity Delivered";
                dataOrderList.Columns["date_created"].HeaderText = "Date Created";
            }
        }
        public void readDataOrderListCompl()
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM itemdetails INNER JOIN orderlist ON itemdetails.itemID = orderlist.item_id WHERE orderlist.status = 2;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvcompleted.DataSource = dt;
                dgvcompleted.Columns["itemID"].Visible = false;
                dgvcompleted.Columns["itemstatus"].Visible = false;
                dgvcompleted.Columns["id"].Visible = false;
                dgvcompleted.Columns["item_id"].Visible = false;
                dgvcompleted.Columns["status"].Visible = false;
                dgvcompleted.Columns["status"].Visible = false;
                dgvcompleted.Columns["item_code"].HeaderText = "Item Code";
                dgvcompleted.Columns["date_of_creation"].HeaderText = "Date Created";
                dgvcompleted.Columns["date"].HeaderText = "Date Delivery Due";
                dgvcompleted.Columns["description"].HeaderText = "Item Description";
                dgvcompleted.Columns["itemname"].HeaderText = "Item Name";
                dgvcompleted.Columns["date_modified"].HeaderText = "Date Modified";
                dgvcompleted.Columns["quantity_delivered"].HeaderText = "Quantity Delivered";
                dgvcompleted.Columns["date_created"].HeaderText = "Date Created";
            }
        }
        public void readDataOrderListCanceled()
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM itemdetails INNER JOIN orderlist ON itemdetails.itemID = orderlist.item_id WHERE orderlist.status = 0;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvcancelled.DataSource = dt;
                dgvcancelled.Columns["itemID"].Visible = false;
                dgvcancelled.Columns["itemstatus"].Visible = false;
                dgvcancelled.Columns["id"].Visible = false;
                dgvcancelled.Columns["item_id"].Visible = false;
                dgvcancelled.Columns["status"].Visible = false;
                dgvcancelled.Columns["status"].Visible = false;
                dgvcancelled.Columns["item_code"].HeaderText = "Item Code";
                dgvcancelled.Columns["date_of_creation"].HeaderText = "Date Created";
                dgvcancelled.Columns["date"].HeaderText = "Date Delivery Due";
                dgvcancelled.Columns["description"].HeaderText = "Item Description";
                dgvcancelled.Columns["itemname"].HeaderText = "Item Name";
                dgvcancelled.Columns["date_modified"].HeaderText = "Date Modified";
                dgvcancelled.Columns["quantity_delivered"].HeaderText = "Quantity Delivered";
                dgvcancelled.Columns["date_created"].HeaderText = "Date Created";
            }
        }
        private void txtboxdeleter()
        {
            txtitemname.Clear();
            txtquantity2.Clear();
            txtvendor.Clear();
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm Order Creation!", "CONFIRM ACTION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(res == DialogResult.OK)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    using (var command = new MySqlCommand("INSERT INTO orderlist(date_created, date, vendor, quantity, quantity_delivered, status, item_id) VALUES(@date_created, @date, @vendor, @quantity, @quantity_delivered, @status, @item_id);", dbconnection))
                    {
                        dbconnection.Open();
                        command.Parameters.AddWithValue("@item_name", itemname);
                        command.Parameters.AddWithValue("@date_created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@date", dateDate.Value.Date.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@vendor", txtvendor.Text);
                        command.Parameters.AddWithValue("@quantity", txtquantity2.Text);
                        command.Parameters.AddWithValue("@quantity_delivered", 0);
                        command.Parameters.AddWithValue("@status", 1);
                        command.Parameters.AddWithValue("@item_id", itemid);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order Succssesfully Created!");
                txtboxdeleter();
                readData();
                readDataOrderList();
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            readData();
            dgvformaters();
            readDataOrderList();
            readDataOrderListCompl();
            readDataOrderListCanceled();
        }
        private string ordid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataOrderList.Rows.Count > 0)
            {
                ordid = dataOrderList.Rows[e.RowIndex].Cells["id"].Value.ToString();
            }
        }
        public string itemname;
        private void dataItemCreation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 itemname = dataItemCreation.Rows[e.RowIndex].Cells["itemname"].Value.ToString();
                itemid = dataItemCreation.Rows[e.RowIndex].Cells["itemID"].Value.ToString();
                txtitemname.Text = itemname;
                btnAdd2.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm Order Cancellation!", "CONFIRM ACTION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    using (var command = new MySqlCommand("UPDATE orderlist SET status = @stat WHERE id = @ayd;", dbconnection))
                    {
                        dbconnection.Open();
                        command.Parameters.AddWithValue("@stat", 0);
                        command.Parameters.AddWithValue("@ayd", ordid);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order Succssesfully Cancelled!");
                readData();
                readDataOrderList();
            }
        }

        private void dataItemCreation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvendor_KeyPress(object sender, KeyPressEventArgs e)
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
