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
            dbconnect = new MySqlConnection("Server=localhost;Database=silasystemdb;Uid=root;Pwd=root;");
            
            dbconnect.Open();
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
            if(comboBox2.Text != "")
            {
                var dbconnector = new dbConnector();
                using (dbconnect = dbconnector.connector())
                {
                    dbconnect.Open();
                    MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                        "usertable.idemp = employee.empID " +
                        "where usertable.username = '" + txtUsername.Text + "' " +
                        "and usertable.password = '" + txtPassword.Text + "';", dbconnect);
                    MySqlDataAdapter listener = new MySqlDataAdapter(query);
                    DataTable holder = new DataTable();
                    listener.Fill(holder);

                    //MessageBox.Show(perm.Substring(0,1));

                    if (holder.Rows.Count > 0)
                    {
                        string perm = holder.Rows[0]["restrictions"].ToString();
                        //string[] split = perm.Split(' ')
                        if (statusFlag())
                        {
                            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                            MessageBox.Show("WELCOME TO SILA SCHOOL MANAGEMENT SYSTEM!", "WELCOME!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmmain = new frmMain(uname, perm);
                            frmmain.schoolyear = comboBox2.Text;
                            frmmain.Show();
                            frmmain.reference = this;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("This Account is no longer active", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("WRONG CREDENTIALS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("SCHOOLYEAR HAS NOT BEEN SELECTED!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
           
        }

        public Boolean statusFlag()
        {
            var dbconnector = new dbConnector();
            using (dbconnect = dbconnector.connector())
            {
                dbconnect.Open();
                MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                    "usertable.idemp = employee.empID " +
                    "where usertable.username = '" + txtUsername.Text + "' " +
                    "and usertable.password = '" + txtPassword.Text + "' and usertable.status = 1;", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);

                //MessageBox.Show(perm.Substring(0,1));

                if (holder.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.FromArgb(246, 207, 86);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(246, 207, 86);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this application?", "S.I.L.A Enrollment and Accounting System", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("SELECTED SCHOOL YEAR SELECTED IS " + comboBox2.Text, "PLEASE CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {

            }
            else
            {
                comboBox2.SelectedIndex = -1;
            }
        }
    }
}
