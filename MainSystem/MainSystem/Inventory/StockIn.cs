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
            reference.readData();
            reference.Show();
            this.Hide();
        }

        private void Stockin_out_Load(object sender, EventArgs e)
        {
            readData();
            readData2();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            newent = new frmNewEntry(forreturn);
            newent.Show();
            newent.reference = this;
            this.Hide();
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
            }
        }
        public frmNewEntry newent;
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
            itemid = dataGridView1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            orderlistID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM stkin WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                //dataGridView2.Columns["itemID"].Visible = false;
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
        /*
        private void btnout_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var com = new MySqlCommand("UPDATE stkin SET status = 1 WHERE stkinID = @ayyd", dbconnection))
                {
                    com.Parameters.AddWithValue("@ayyd", stkID);
                    com.ExecuteNonQuery();
                }
                using (var com2 = new MySqlCommand("UPDATE inventory SET stock_out_date = @dtnow, quantity = @quant WHERE invID = @invid", dbconnection))
                {
                    com2.Parameters.AddWithValue("@quant", quantitySUB());
                    string datttu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    com2.Parameters.AddWithValue("@dtnow", datttu);
                    com2.Parameters.AddWithValue("@invid", invID);
                    com2.ExecuteNonQuery();
                }
            }
            MessageBox.Show("ITEM STOCKED-OUT!");
            readData2();
            dataGridView2.ClearSelection();
        }*/
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
                string query = "SELECT * FROM inventory WHERE invID = '" + invID + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
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
                    com.Parameters.AddWithValue("@status", 0);
                    com.ExecuteNonQuery();
                }
            }
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
                    com.Parameters.AddWithValue("@Quantity", txtEnter.Text);
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
                using (var com = new MySqlCommand("INSERT INTO stkin(inventory_id, date, quantity_delivered, status, orderlistID) VALUES(@invid, @date, @quantity_delivered, @status, @orderlistID)", dbconnection))
                {
                    com.Parameters.AddWithValue("@invid", inventorycount().ToString());
                    com.Parameters.AddWithValue("@quantity_delivered", txtEnter.Text);
                    //com.Parameters.AddWithValue("@quantity_remaining", quantity_remaining.ToString());
                    //MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@status", 1);
                    com.Parameters.AddWithValue("@orderlistID", orderlistID);
                    com.ExecuteNonQuery();
                }
            }
        }
        private void updateorderlist()
        {
          
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var com = new MySqlCommand("UPDATE orderlist SET quantity_delivered = @qdel", dbconnection))
                {

                    com.Parameters.AddWithValue("@itemayd", itemid);
                    com.Parameters.AddWithValue("@stock_in_date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@Quantity", txtEnter.Text);
                    com.Parameters.AddWithValue("@status", 1);
                    com.ExecuteNonQuery();
                }
            }
            
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            if(!checkif_in_inventory(itemid))
            {
                insertintoInventory();
                insertstkin();
            }
            else
            {
                updateInventory();
                insertstkin();
            }
            MessageBox.Show("ITEM STOCKED-IN!");
            readData2();
            dataGridView2.ClearSelection();
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
    }
}
