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
                string query = "SELECT * FROM inventory WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
            }
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
    }
}
