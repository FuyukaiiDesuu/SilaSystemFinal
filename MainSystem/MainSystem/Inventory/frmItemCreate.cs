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
    public partial class frmItemCreate : Form
    {
        public FormInventory reference { get; set; }
        public MySqlConnection dbconnection;
        
        public frmItemCreate()
        {
            InitializeComponent();
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                dbconnection.Open();
                    using (var command = new MySqlCommand("INSERT INTO itemdetails VALUES(DEFAULT, @item_code, @date_of_creation, @description, @itemstatus, @itemname)", dbconnection))
                    {
                        command.Parameters.AddWithValue("@item_code", txtitemcode.Text);
                        command.Parameters.AddWithValue("@date_of_creation", dateTimePicker.Value.ToString("yyyy-MM-dd")); 
                        command.Parameters.AddWithValue("@description", txtdesc.Text);
                        command.Parameters.AddWithValue("@itemstatus", txtstatus.Text);
                        command.Parameters.AddWithValue("@itemname", txtitemname.Text);
                        
                        command.ExecuteNonQuery();

                    }
                }
            
        }

        private void frmItemCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
