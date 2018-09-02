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
    public partial class StockOut : Form
    {
        public FormInventory reference { get; set; }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public StockOut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void StockOut_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
        public string invayd;
        public string itmcode;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           invayd = dataGridView1.Rows[e.RowIndex].Cells["invID"].Value.ToString();
            itmcode = dataGridView1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();

        }

        private string subtract()
        {
            Int32 a = 0;
            Int32 b = 0;
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM inventory WHERE invID = '" + invayd + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                //MessageBox.Show(dt.Rows[0]["quantity"].ToString());
                a = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                b = Convert.ToInt32(textBox1.Text);
            }
            return (a - b).ToString();
        }
        private string miscdesc()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE item_code = '" + itmcode + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                
                return dt.Rows[0]["description"].ToString(); ;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var com = new MySqlCommand("INSERT INTO stkout(inventory_id, stockout_date, misc_desc, quantity) VALUES(@inayd, @soutdate, @mdesc, @quant);", dbconnection))
                {
                    com.Parameters.AddWithValue("@inayd", invayd);
                    com.Parameters.AddWithValue("@soutdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@mdesc", miscdesc());
                    com.Parameters.AddWithValue("@quant", textBox1.Text);
                    com.ExecuteNonQuery();
                }
                
                using (var com2 = new MySqlCommand("UPDATE inventory SET stock_out_date = @dtnow, quantity = @quant WHERE invID = @invid", dbconnection))
                {
                    com2.Parameters.AddWithValue("@quant", subtract());
                    string datttu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    com2.Parameters.AddWithValue("@dtnow", datttu);
                    com2.Parameters.AddWithValue("@invid", invayd);
                    com2.ExecuteNonQuery();
                }
            }
            MessageBox.Show("ITEM STOCKED-OUT!");
            readData();

        }
    }
}
