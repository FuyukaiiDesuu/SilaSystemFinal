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
using System.Text.RegularExpressions;


namespace MainSystem
{
    public partial class editItemmanagement : Form
    {
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public MySqlConnection dbconnection;
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
            txtitemname.Text = dic["itemname"];

        }
        private Boolean itemchecker(string itemname, string item_description)
        {
            var connect = new dbConnector();
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE itemname = '" + itemname + "' " +
                    "AND itemID <> '" + dic["ayd"] + "' " +
                    "AND description = '" + item_description + "' " +
                    "AND itemID <> '" + dic["ayd"] + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("An Item Has Already Been Added With The Same Item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void editData()
        {
            if(!itemchecker(txtitemname.Text, txtdesc.Text))
            {
                MySqlConnection conn = connect.connector();
                String query = "UPDATE itemdetails SET item_code ='" + txtitemcode.Text +
                    "', description ='" + txtdesc.Text +
                    "', itemname ='" + txtitemname.Text +
                    "', date_modified = '" + DateTime.Now.ToString("yyyy-MM-dd") +
                    "' WHERE itemID ='" + dic["ayd"] + "'";
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
        }
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void editItemmanagement_Load(object sender, EventArgs e)
        {

        }

        private void txtitemcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b,.-]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("The Text Must Can Only Consist Of Alphabets and Numbers, and The Characters: '-,.'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
