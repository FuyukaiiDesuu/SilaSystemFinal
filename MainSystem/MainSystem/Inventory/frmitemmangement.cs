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
            btnedit.Enabled = false;    
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        public createitemfrm itemcreate;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            itemcreate = new createitemfrm();
            itemcreate.Show();
            itemcreate.reference = this;
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
            itemedit = new editItemmanagement(dic);
            itemedit.Show();
            itemedit.reference = this;
            this.Hide();
        }
        
        public editItemmanagement itemedit;

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbItemDetails2_Enter(object sender, EventArgs e)
        {

        }

        private void txtitemcode_TextChanged(object sender, EventArgs e)
        {

        }
        public IDictionary<string, string> dic;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            if (dataGridView1.Rows.Count > 0)
            {
                dic = new Dictionary<string, string>();
                dic.Add("itemcode", dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString());
                dic.Add("description", dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString());
                dic.Add("itemstatus", dataGridView1.Rows[e.RowIndex].Cells["itemstatus"].Value.ToString());
                dic.Add("itemname", dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString());


                txtitemcode.Text = dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString();
                txtdesc.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["itemstatus"].Value.ToString() == "1")
                {
                    txtstat.Text = "ACTIVE";
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells["itemstatus"].Value.ToString() == "0")
                {
                    txtstat.Text = "INACTIVE";
                }
                txtitemname.Text = dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString();

                //txtitemid.Text = dgvInventory.SelectedRows[0].Cells[0].Value.ToString();

            }
        }
    }
}
