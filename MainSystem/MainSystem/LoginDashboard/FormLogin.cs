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
    public partial class FormLogin : Form
    {
        public MySqlConnection dbconnect;
        public FormLogin()
        {
            InitializeComponent();
            dbconnect = new MySqlConnection("Server=localhost;Database=silasystemdb;Uid=root;Pwd=1234;");
            dbconnect.Open();
        }
        public frmMain frmmain;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        string uname;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlCommand query = new MySqlCommand("SELECT * FROM usertable WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);

                if(holder.Rows.Count > 0)
                {
                    //uname = holder.Rows[0]["LastName"].ToString() + ", " + holder.Rows[0]["FirstName"].ToString();
                    MessageBox.Show("Succesful Login!");
                    frmmain = new frmMain("admin");
                    frmmain.Show();
                    frmmain.reference = this;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Credentials!");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("ERROR: " + ee);
                dbconnect.Close();
            }
        }
        Char chr;
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
