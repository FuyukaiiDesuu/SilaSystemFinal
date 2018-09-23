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
    public partial class createitemfrm : Form
    {
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public MySqlConnection dbconnection;
        public frmitemmanagement reference { get; set; }
       

        public createitemfrm()
        {
            InitializeComponent();
        }

        private void createitemfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbak_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private Boolean itemcheck(string itemname, string description)
        {
            var connect = new dbConnector();
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE itemname = '" + itemname + "' AND description = '" + description + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("An Item Has Already Been Added With The Same Item!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if(!itemcheck(txtitemname.Text, txtdesc.Text))
            {
                DialogResult res = MessageBox.Show("CONFIRM ITEM CREATION!", "CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var dbconnect = new dbConnector();
                    using (dbconnection = dbconnect.connector())
                    {
                        using (var command = new MySqlCommand("INSERT INTO itemdetails(item_code, date_of_creation, description, itemstatus, itemname) VALUES(@item_code, @date_of_creation, @description, @itemstatus, @itemname);", dbconnection))
                        {
                            dbconnection.Open();
                            command.Parameters.AddWithValue("@item_code", txtitemcode.Text);
                            command.Parameters.AddWithValue("@date_of_creation", DateTime.Now.ToString("yyyy-MM-dd"));
                            command.Parameters.AddWithValue("@description", txtdesc.Text);
                            command.Parameters.AddWithValue("@itemstatus", 1);
                            command.Parameters.AddWithValue("@itemname", txtitemname.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Item Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    reference.Show();
                    reference.readData();
                }
            }
        }
    }
}
