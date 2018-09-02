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
    public partial class frmitemmanagement : Form
    {
        public FormInventory reference { get; set; }
        public MySqlConnection dbconnection;
        
        public frmitemmanagement()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
        public createItem crt;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
            dbconnection.Open();
                using (var command = new MySqlCommand("INSERT INTO itemdetails VALUES()", dbconnection))
                {
                    command.ExecuteNonQuery();
                }
            }
            crt = new createItem();
            crt.Show();
            crt.reference = this;
            this.Hide();
        }

        private void frmItemCreate_Load(object sender, EventArgs e)
        {
            readData();
        }

        public itemview iview;
        private void button2_Click(object sender, EventArgs e)
        {
            iview = new itemview();
            iview.Show();
            iview.reference = this;
            this.Hide();

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

        private void button3_Click(object sender, EventArgs e)
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            editData();
        }
        private void editData()
        {
            itemedit = new editItemmanagement();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                itemedit.txtitemid.Text = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                itemedit.txtitemcode.Text = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                itemedit.txtdesc.Text = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();
                itemedit.cmbstatus.Text = dataGridView1.SelectedRows[i].Cells[4].Value.ToString();
                itemedit.txtitemname.Text = dataGridView1.SelectedRows[i].Cells[5].Value.ToString();
            }
            itemedit.Show();
            itemedit.reference = this;
            this.Hide();
            readData();
            dataGridView1.Rows[0].Selected = false;
        }
        public editItemmanagement itemedit;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
