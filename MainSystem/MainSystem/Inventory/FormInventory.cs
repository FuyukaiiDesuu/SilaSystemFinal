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
                string query = "SELECT invID, item_code, itemname, description, stock_in_date, stock_out_date, Quantity, Status FROM inventory INNER JOIN itemdetails ON inventory.item_id = itemdetails.itemID WHERE inventory.status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
             
            }
            dgvInventory.Columns["invID"].Visible = false;
            dgvInventory.Columns["Status"].Visible = false;
            dgvInventory.Columns["stock_in_date"].HeaderText = "Stock In Date";
            dgvInventory.Columns["stock_out_date"].HeaderText = "Stock Out Date";
            dgvInventory.Columns["item_code"].HeaderText = "Item Code";
            dgvInventory.Columns["itemname"].HeaderText = "Item Name";
            dgvInventory.Columns["description"].HeaderText = "Item Description";
        }
        public void readData2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT invID, item_code, itemname, description, stock_in_date, stock_out_date, Quantity, Status FROM inventory INNER JOIN itemdetails ON inventory.item_id = itemdetails.itemID WHERE inventory.status = 0;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;

            }
            dgvInventory.Columns["invID"].Visible = false;
            dgvInventory.Columns["Status"].Visible = false;
            dgvInventory.Columns["stock_in_date"].HeaderText = "Stock In Date";
            dgvInventory.Columns["stock_out_date"].HeaderText = "Stock Out Date";
            dgvInventory.Columns["item_code"].HeaderText = "Item Code";
            dgvInventory.Columns["itemname"].HeaderText = "Item Name";
            dgvInventory.Columns["description"].HeaderText = "Item Description";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormInventory_Load(object sender, EventArgs e)
        {
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            readData();
            dgvInventory.ClearSelection();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Dispose();
        }

        public frmOrderList frmol;
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            frmol = new frmOrderList();
            frmol.reference = this;
            frmol.Show();
            
        }

        public Stockin_out frmsinout;
        private void btnStockInOut_Click(object sender, EventArgs e)
        {
            frmsinout = new Stockin_out();
            frmsinout.reference = this;
            frmsinout.Show();
        }

        public frmitemmanagement frmic;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmic = new frmitemmanagement();
            frmic.reference = this;
            frmic.Show();
           
        }

        private void lblsodate_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
        private Int32 quantityadder()
        {
            var a = 0;
            if(Convert.ToInt32(quantity) >= 0)
            {
                a = Convert.ToInt32(quantity) - Convert.ToInt32(textBox2.Text);
                return a;
            }
            else
            {
                return -1;
            }
        }
        private void updateinv()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command = new MySqlCommand("UPDATE inventory SET quantity = @quantity, stock_out_date = @sod WHERE invID = @ayd;", dbconnection))
                {
                    dbconnection.Open();
                    command.Parameters.AddWithValue("@quantity", quantityadder());
                    command.Parameters.AddWithValue("@sod", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@ayd", invid);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void deactivator()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command = new MySqlCommand("UPDATE inventory SET status = 0, invID = @ayd;", dbconnection))
                {
                    dbconnection.Open();
                    command.Parameters.AddWithValue("@ayd", invid);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void insertstkout()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {

                dbconnection.Open();
                using (var com = new MySqlCommand("INSERT INTO stkout(inventory_id, stockout_date, quantity, statusout) VALUES(@invid, @date, @quan, @sout)", dbconnection))
                {
                    com.Parameters.AddWithValue("@invid", invid);
                    com.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@quan", textBox2.Text);
                    com.Parameters.AddWithValue("@sout", comboBox1.Text);

                    com.ExecuteNonQuery();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "" && textBox2.Text != "0")
            {
                if(comboBox1.SelectedIndex != -1)
                {
                    if (quantityadder() >= 0)
                    {
                        DialogResult res = MessageBox.Show("CONFIRM STOCK-OUT OF ITEMS?", "CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            updateinv();
                            insertstkout();
                            readData();
                            textBox2.Clear();
                            dgvInventory.ClearSelection();
                            MessageBox.Show("SUCCESSFULLY STOCKED-OUT QUANTITY OF ITEMS!", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("QUANTITY OF ITEMS TO BE STOCKED OUT CANNOT BE MORE THAN QUANTITY ON-HAND!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A STOCK-OUT TYPE SHOULD BE SELECTED", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("QUANTITY MUST NOT BE LEFT EMPTY, OR SET TO ZERO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("item_code LIKE '%{0}%' OR description LIKE '%{0}%' OR itemname LIKE '%{0}%'", search.Text);
           
        }
        public string invid;
        public string quantity;
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
           if (e.RowIndex >= 0)
           {
                button2.Enabled = true;
                textBox2.Enabled = true;
                if(!checkBox1.Checked)
                {
                    button1.Enabled = true;
                }
                button3.Enabled = true;
                invid = dgvInventory.Rows[e.RowIndex].Cells["invID"].Value.ToString();
                quantity = dgvInventory.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }
        public Inventory.stkoutlist stklist;
        private void button2_Click(object sender, EventArgs e)
        {
            stklist = new Inventory.stkoutlist(invid);
            stklist.reference = this;
            stklist.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("CONFIRM DEACTIVATION OF INVENTORY RECORD?", "CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                deactivator();
                readData();
                MessageBox.Show("THE INVENTORY RECORD HAS BEEN SUCCESSFULLY DEACTIVATED!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                readData2();
                dgvInventory.ClearSelection();
                button1.Enabled = false;
            }
            else
            {
                readData();
                dgvInventory.ClearSelection();
            }
        }

        private void FormInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
