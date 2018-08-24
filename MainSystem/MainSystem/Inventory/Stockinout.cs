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
                string query = "SELECT * FROM itemdetails WHERE itemstatus = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
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
            items(dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM stkin WHERE status = 0";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                //dataGridView2.Columns["itemID"].Visible = false;
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {

        }
        
        private string quantityADD()
        {
            Int32 a = 0;
            Int32 b = 0;
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE invID = '"+ invID +"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                MessageBox.Show(dt.Rows[0]["quantity"].ToString());
                a = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                b = Convert.ToInt32(quantity);
            }
            return (a + b).ToString();
        }
        private void btnin_Click(object sender, EventArgs e)
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
                using (var com2 = new MySqlCommand("UPDATE inventory SET stock_in_date = @dtnow, quantity = @quant WHERE invID = @invid", dbconnection))
                {
                    com2.Parameters.AddWithValue("@quant", quantityADD());
                    string datttu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    com2.Parameters.AddWithValue("@dtnow", datttu);
                    com2.Parameters.AddWithValue("@invid", invID);
                    com2.ExecuteNonQuery();
                }
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
    }
}
