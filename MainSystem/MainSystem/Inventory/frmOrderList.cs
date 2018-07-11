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
    public partial class frmOrderList : Form
    {
        public FormInventory reference { get; set; }

        public frmOrderList()
        {
            InitializeComponent();
        }
        /*dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;*/
        private void lblDate2_Click(object sender, EventArgs e)
        {

        }

        private void lbldateReq_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
       /* public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM oder_list";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }*/

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            //readData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
