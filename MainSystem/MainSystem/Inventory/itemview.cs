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
    public partial class itemview : Form
    {
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
            MySqlConnection conn = connect.connector();
            String query = "UPDATE itemdetails SET item_code ='" + txtitemcode.Text +
                "', description ='" + txtdesc.Text +
                "', itemstatus ='" + cmbstatus.Text +
                "', itemname ='" + txtitemname.Text +
                "' WHERE itemID ='" + txtitemid.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                this.Close();
                reference.Show();
                reference.readData();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
            this.Close();
            reference.Show();
            reference.dataGridView1.Rows[0].Selected = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails;";
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
            btnconfirm.Enabled = !string.IsNullOrWhiteSpace(cmbstatus.Text);
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
                string query = ("SELECT * FROM itemdetails where itemname like '" + txtsearch.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                txtitemcode.Text = dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString();
                txtdesc.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["itemstatus"].Value.ToString() == "1")
                {
                    cmbstatus.Text = "ACTIVE";
                    
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells["itemstatus"].Value.ToString() == "0")
                {
                    
                }
                txtitemname.Text = dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString();
            }
        }
    }
}
