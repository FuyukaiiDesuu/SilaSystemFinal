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
        IDictionary<string, string> dic;
        public editItemmanagement(IDictionary<string, string> d)
        {
            InitializeComponent();
            dic = d;
            filltextbox();
        }
        dbConnector connect = new dbConnector();
        private void btnback_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
        private void filltextbox()
        {
            txtitemcode.Text = dic["itemcode"];
            txtdesc.Text = dic["description"];
            if(dic["itemstatus"] == "1")
            {
                textBox1.Text = "Active";
            }
            else if(dic["itemstatus"] == "0")
            {
                textBox1.Text = "Inactive";
            }
            txtitemname.Text = dic["itemname"];

        }
        private void editData()
        {
            MySqlConnection conn = connect.connector();
            String query = "UPDATE itemdetails SET item_code ='" + txtitemcode.Text +
                "', description ='" + txtdesc.Text +
                "', itemstatus ='" + dic["itemstatus"] +
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
                reference.dataGridView1.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
            
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
