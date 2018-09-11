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
    public partial class frmMain : Form
    {
        private MySqlConnection dbconnect;
        public FormLogin reference { get; set; }
        public frmMain(string uname, string perm)
        {
            InitializeComponent();
            lblusername.Text = uname;
            disablebuttons();
            //MessageBox.Show(string.Join("\n", arr));
            restrictor(perm);
           
        }
        
        public void disablebuttons()
        {
            btnAccountForm.Enabled = false;
            btnEmployeeForm.Enabled = false;
            btnInventoryForm.Enabled = false;
            btnRegistrationForm.Enabled = false;
            btnUserForm.Enabled = false;
        }
        public void enablebuttons()
        {
            btnAccountForm.Enabled = true;
            btnEmployeeForm.Enabled = true;
            btnInventoryForm.Enabled = true;
            btnRegistrationForm.Enabled = true;
            btnUserForm.Enabled = true;
        }
        
        public void restrictor(string perm)
        {
           
            var accp = perm.Substring(0, 1);
            var enrp = perm.Substring(1, 1);
            var empp = perm.Substring(2, 1);
            var invp = perm.Substring(3, 1);
            var usrp = perm.Substring(4, 1);
            if(accp == "1")
            {
                btnAccountForm.Enabled = true;
            }
            if(enrp == "1")
            {
                btnRegistrationForm.Enabled = true;
            }
            if(empp == "1")
            {
                btnEmployeeForm.Enabled = true;
            }
            if(invp == "1")
            {
                btnInventoryForm.Enabled = true;
            }
            if(usrp == "1")
            {
                btnUserForm.Enabled = true;
            }
            if(perm == "11111")
            {
                enablebuttons();
            }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEnrollmentForm_Click(object sender, EventArgs e)
        {
            frmEnroll = new EnrollmentConsole(lblusername.Text);
            frmEnroll.Show();
            frmEnroll.reference = this;
            this.Hide();

        }
        public EnrollmentConsole frmEnroll;
        public string uname;
        private void btnEmployeeForm_Click(object sender, EventArgs e)
        {
            var dbconnector = new dbConnector();
            using (dbconnect = dbconnector.connector())
            {
                dbconnect.Open();
                MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                    "usertable.idemp = employee.empID ", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);
                if (holder.Rows.Count > 0)
                {

                    uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                    frmemp = new Employee.newfrmEmployee(uname);
                    frmemp.Show();
                    frmemp.reference = this;
                    this.Hide();
                }
            }
            
        }
        public Employee.newfrmEmployee frmemp;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.clearTxtBoxes();
            reference.Show();
        }
        public FormInventory frminv;
        private void btnInventoryForm_Click(object sender, EventArgs e)
        {
            frminv = new FormInventory();
            frminv.Show();
            frminv.reference = this;
            this.Hide();
            
        }
        public Accounting.newfrmAccount frmacc;
        private void btnAccountForm_Click(object sender, EventArgs e)
        {
            var dbconnector = new dbConnector();
            using (dbconnect = dbconnector.connector())
            {
                dbconnect.Open();
                MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                    "usertable.idemp = employee.empID ", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);
                if (holder.Rows.Count > 0)
                {

                    uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString() +" "+ holder.Rows[0]["middle_name"].ToString();
                    frmacc = new Accounting.newfrmAccount(uname, holder.Rows[0]["empID"].ToString());
                    frmacc.Show();
                    frmacc.reference = this;
                    this.Hide();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
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

        public User.frmUser user;
        private void btnUserForm_Click(object sender, EventArgs e)
        {
            var dbconnector = new dbConnector();
            using (dbconnect = dbconnector.connector())
            {
                dbconnect.Open();
                MySqlCommand query = new MySqlCommand("SELECT * from usertable inner join employee on " +
                    "usertable.idemp = employee.empID ", dbconnect);
                MySqlDataAdapter listener = new MySqlDataAdapter(query);
                DataTable holder = new DataTable();
                listener.Fill(holder);
                if (holder.Rows.Count > 0)
                {

                    uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                    user = new User.frmUser(uname);
                    user.Show();
                    user.reference = this;
                    this.Hide();
                }
            }
        }
    }
}
