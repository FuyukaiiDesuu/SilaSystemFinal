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
    public partial class Stockin_out : Form
    {
        public Int32 quantity_remaining;
        public Int32 quantity_delivered;
        public string orderlistID;
        public string itemid;
        public FormInventory reference { get; set; }
        public Stockin_out()
        {
            InitializeComponent();
        }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        private void btnback2_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("ARE YOU SURE YOU WANT TO GO BACK?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                reference.readData();
                reference.Show();
                this.Close();
            }
          
        }

        private void Stockin_out_Load(object sender, EventArgs e)
        {
            dgvcolorfontformat();
            readData();
            readDataDGV1();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
        private void btnNewEntry_Click(object sender, EventArgs e)
        {

        }
        private void dgvcolorfontformat()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 14f);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM orderlist INNER JOIN itemdetails ON orderlist.item_id = itemdetails.itemID" +
                    " WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["item_id"].Visible = false;
                dataGridView1.Columns["quantity"].Visible = false;
                dataGridView1.Columns["status"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["quantity_delivered"].Visible = false;
                dataGridView1.Columns["date_of_creation"].Visible = false;
                dataGridView1.Columns["itemstatus"].Visible = false;
                dataGridView1.Columns["item_code"].Visible = false;
                dataGridView1.Columns["itemID"].Visible = false;

                dataGridView1.Columns["date"].HeaderText = "Date To Be Delivered";
                dataGridView1.Columns["date_created"].HeaderText = "Date Of Creation";
                dataGridView1.Columns["vendor"].HeaderText = "Vendor";
                dataGridView1.Columns["description"].HeaderText = "Item Desc.";
                dataGridView1.Columns["itemname"].HeaderText = "Item Name.";

            }
        }
       
        IDictionary<string, string> forreturn;
        private void items(string id, string name, string desc)
        {
            forreturn = new Dictionary<string, string>();
            forreturn.Add("ayd", id);
            forreturn.Add("name", name);
            forreturn.Add("desc", desc);
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quantity_remaining = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            itemid = dataGridView1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            orderlistID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            textBox1.Text = textboxsolver().ToString();
            readDataDGV1();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readDataDGV1()
        {
            try
            {
                using (MySqlConnection conn = connect.connector())
                {
                    string query = "SELECT * FROM stkin WHERE orderlistID = '" + orderlistID + "';";
                    dt = new DataTable();
                    adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                    //dataGridView2.Columns["itemID"].Visible = false;
                }
            }
            catch(Exception ee)
            {
                throw ee;
            }
          
        }
        private string adder()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM stkin WHERE status = 0";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dt.Rows[0]["quantity_delivered"].ToString();
                //dataGridView2.Columns["itemID"].Visible = false;
            }
            return "";
        }
        private Int32 inventorycount()
        {
            using (MySqlConnection conn = connect.connector())

            {
                string query = "SELECT COUNT(*) FROM inventory;";
                using (var com = new MySqlCommand(query, dbconnection))
                {
                    return Convert.ToInt32(com.ExecuteScalar());
                }
            }
        }
        private Boolean checkif_in_inventory(string itemid)
        {
           
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE item_id = '" + itemid + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Exisiting Inventory Entry Found!, Records Will Be Updated Accordingly.", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Exisiting Inventory Entry Not Found!, Records Will Be Created Accordingly.", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
        }
        private void insertintoInventory()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {

                dbconnection.Open();
                using (var com = new MySqlCommand("INSERT INTO inventory(item_id, stock_in_date, Quantity, status) VALUES(@item_id, @stock_in_date, @Quantity, @status)", dbconnection))
                {
                    
                    com.Parameters.AddWithValue("@item_id", itemid);
                    com.Parameters.AddWithValue("@stock_in_date",DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@Quantity", txtEnter.Text);
                    com.Parameters.AddWithValue("@status", 1);
                    com.ExecuteNonQuery();
                }
            }
        }
        private Int32 textboxsolver()
        {
            var a = 0;
            var b = 0;
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM orderlist WHERE id = '"+orderlistID+"' AND status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                a = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                b = Convert.ToInt32(dt.Rows[0]["quantity_delivered"].ToString());
                //dataGridView2.Columns["itemID"].Visible = false;
            }
            return a - b;
        }
        private Int32 inventorysolver()
        {
            var a = 0;
            var b = 0;
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE item_id = '" + itemid + "' AND status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                a = Convert.ToInt32(dt.Rows[0]["Quantity"].ToString());
                b = Convert.ToInt32(txtEnter.Text);
                //dataGridView2.Columns["itemID"].Visible = false;
            }
            return a+b;
        }
        private void updateInventory()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {

                dbconnection.Open();
                using (var com = new MySqlCommand("UPDATE inventory SET stock_in_date = @stock_in_date, Quantity = @Quantity, status = @status WHERE item_id = @itemayd", dbconnection))
                {

                    com.Parameters.AddWithValue("@itemayd", itemid);
                    com.Parameters.AddWithValue("@stock_in_date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@Quantity", inventorysolver().ToString());
                    com.Parameters.AddWithValue("@status", 1);
                    com.ExecuteNonQuery();
                }
            }
        }
        private void insertstkin()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {

                dbconnection.Open();
                using (var com = new MySqlCommand("INSERT INTO stkin(inventory_id, date, quantity_delivered, orderlistID) VALUES(@invid, @date, @quantity_delivered, @orderlistID)", dbconnection))
                {
                    com.Parameters.AddWithValue("@invid", inventorycount().ToString());
                    com.Parameters.AddWithValue("@quantity_delivered", txtEnter.Text);
                    //com.Parameters.AddWithValue("@quantity_remaining", quantity_remaining.ToString());
                    //MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@orderlistID", orderlistID);
                    com.ExecuteNonQuery();
                }
            }
        }
        private Int32 solver()
        {
            var a = 0;
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM orderlist WHERE id = '" + orderlistID + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                a = Convert.ToInt32(dt.Rows[0]["quantity_delivered"].ToString());
            }
            
            return a + Convert.ToInt32(txtEnter.Text);
        }
        private void updateorderlist()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var com = new MySqlCommand("UPDATE orderlist SET quantity_delivered = @qdel WHERE id = '"+orderlistID+"';", dbconnection))
                {

                    com.Parameters.AddWithValue("@qdel", solver().ToString());
                    com.Parameters.AddWithValue("@status", 1);
                    com.ExecuteNonQuery();
                }
            }
            
        }
        private void textboxclear()
        {
            textBox1.Clear();
            textBox2.Clear();
            txtEnter.Clear();
        }
        private void flagtoclearorderlist()
        {
            var a = 0;
            var b = 0;
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM orderlist WHERE id = '" + orderlistID + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                a = Convert.ToInt32(dt.Rows[0]["quantity_delivered"].ToString());
                b = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
            }
            if(a == b)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    using (var com = new MySqlCommand("UPDATE orderlist SET status = @stat WHERE id = '" + orderlistID + "';", dbconnection))
                    {
                        com.Parameters.AddWithValue("@stat", 2);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("ORDER DELIVERY HAS BEEN COMPLETED!, PLEASE REFER TO ORDER LIST MANAGEMENT FOR LIST OF COMPELETED ORDERS", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            }
        }
        private Boolean checkquantity_ifnegative()
        {
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(txtEnter.Text);
            if(b > a)
            {
                MessageBox.Show("QUANTITY TO STOCK IN CANNOT EXCEED QUANTITY REMAINING!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnin_Click(object sender, EventArgs e)
        {

            if (!checkquantity_ifnegative())
            {
                DialogResult res = MessageBox.Show("SPECIFIED QUANTITY OF ITEMS WILL BE STOCKED IN, PROCEED?", "CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (!checkif_in_inventory(itemid))
                    {

                        insertintoInventory();
                        solver();
                        updateorderlist();
                        insertstkin();
                        flagtoclearorderlist();
                        dataGridView1.ClearSelection();
                        textboxclear();
                        orderlistID = "0";
                        readDataDGV1();
                        readData();
                    }
                    else
                    {

                        updateInventory();
                        solver();
                        updateorderlist();
                        insertstkin();
                        flagtoclearorderlist();
                        dataGridView1.ClearSelection();
                        textboxclear();
                        orderlistID = "0";
                        readDataDGV1();
                        readData();
                    }
                    MessageBox.Show("ITEM STOCKED-IN!");
                    dataGridView2.ClearSelection();
                }
               
            }
           
        }

        public string stkID;
        public string invID;
        public string quantity;
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stkID = dataGridView2.Rows[e.RowIndex].Cells["stkinID"].Value.ToString();
            invID = dataGridView2.Rows[e.RowIndex].Cells["inventory_id"].Value.ToString();
            quantity = dataGridView2.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
        }

        private void search1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void lblSinoutRecord_Click(object sender, EventArgs e)
        {

        }

        private void calculateQuantity()
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
