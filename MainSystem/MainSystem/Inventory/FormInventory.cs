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
    public partial class FormInventory : Form
    {
        public frmMain reference { get; set; }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public FormInventory()
        {
            InitializeComponent();
        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT stock_in_date, stock_out_date, Quantity, Status, item_code FROM inventory INNER JOIN itemdetails ON inventory.item_id = itemdetails.itemID;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
             
            }
            dgvInventory.Columns["Status"].Visible = false;
            dgvInventory.Columns["stock_in_date"].HeaderText = "Stock In Date";
            dgvInventory.Columns["stock_out_date"].HeaderText = "Stock Out Date";
            dgvInventory.Columns["item_code"].HeaderText = "Item Code";
        } 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormInventory_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        public frmOrderList frmol;
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            frmol = new frmOrderList();
            frmol.Show();
            frmol.reference = this;
            this.Hide();
        }

        public Stockin_out frmsinout;
        private void btnStockInOut_Click(object sender, EventArgs e)
        {
            frmsinout = new Stockin_out();
            frmsinout.Show();
            frmsinout.reference = this;
            this.Hide();
        }

        public frmitemmanagement frmic;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmic = new frmitemmanagement();
            frmic.Show();
            frmic.reference = this;
            this.Hide();
        }

        private void lblsodate_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
        public StockOut stout;
        private void button1_Click(object sender, EventArgs e)
        {
            stout = new StockOut();
            stout.Show();
            stout.reference = this;
            this.Hide();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM itemdetails where itemname like '" + search.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dgvInventory.Rows.Count > 0)
                {
                    txtsidate.Text = dgvInventory.Rows[e.RowIndex].Cells["stock_in_date"].Value.ToString();
                    txtsodate.Text = dgvInventory.Rows[e.RowIndex].Cells["stock_out_date"].Value.ToString();
                    txtQuantity.Text = dgvInventory.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                    if (dgvInventory.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "1")
                    {
                        txtstatus.Text = "ACTIVE";
                    }
                    else if (dgvInventory.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "0")
                    {
                        txtstatus.Text = "INACTIVE";
                    }
                    txtItemCode.Text = dgvInventory.Rows[e.RowIndex].Cells["item_code"].Value.ToString();

                    //txtitemid.Text = dgvInventory.SelectedRows[0].Cells[0].Value.ToString();

                }
            
           
        }
    }
}
