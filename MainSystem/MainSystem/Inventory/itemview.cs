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
                string query = "SELECT * FROM itemdetails WHERE itemstatus = 0";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
            }
        }

        private void disablebtn()
        {
            btnconfirm.Enabled = !string.IsNullOrWhiteSpace(cmbstatus.Text);
        }

        private void cmbstatus_TextChanged(object sender, EventArgs e)
        {
            if (cmbstatus.Text == "1")
            {
                btnconfirm.Enabled = true;
            }
            else
            {
                btnconfirm.Enabled = false;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtitemid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtitemcode.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtdesc.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cmbstatus.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtitemname.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
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
    }
}
