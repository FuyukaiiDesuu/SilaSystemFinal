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
    public partial class editItemmanagement : Form
    {
        public frmitemmanagement reference { get; set; }
        
        public editItemmanagement()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        private void btnback_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
        private void editData()
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
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void editItemmanagement_Load(object sender, EventArgs e)
        {

        }
    }
}
