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
        public frmitemmanagement reference { get; set; }
        public MySqlConnection dbconnection;
       

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

        private void btnconfirm_Click(object sender, EventArgs e)
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
