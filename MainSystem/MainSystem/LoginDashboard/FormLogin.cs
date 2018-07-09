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
        //public MySqlConnection dbconnect;
        private MySqlConnection dbconnect;
        public FormLogin()
        {
            InitializeComponent();
            //dbconnect = new MySqlConnection("Server=localhost;Database=silasystemdb;Uid=root;Pwd=root;");
            
            //dbconnect.Open();
        }
        public frmMain frmmain;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void clearTxtBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
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
            var dbconnector = new dbConnector();
            using (dbconnect = dbconnector.connector())
            {
                dbconnect.Open();
                MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                    "usertable.idemp = employee.empID " +
                    "where usertable.username = '"+ txtUsername.Text +"' " +
                    "and usertable.password = '"+ txtPassword.Text +"';", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);
               
                //MessageBox.Show(perm.Substring(0,1));

                if (holder.Rows.Count > 0)
                {
                    string perm = holder.Rows[0]["restrictions"].ToString();
                    string[] split = perm.Split(' ');
                   
                        uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                        MessageBox.Show("Succesful Login!");
                        frmmain = new frmMain(uname, split);
                        frmmain.Show();
                        frmmain.reference = this;
                        this.Hide();
                  
                }
                else
                {
                    MessageBox.Show("Wrong Credentials!");
                }
            }
           
        }
        //Char chr;
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
