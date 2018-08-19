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
        string uname;
        public frmMain(string uname, string perm)
        {
            InitializeComponent();
            lblusername.Text = uname;
            restrictor(perm);
            dbconnect = new MySqlConnection("Server=localhost;Database=silasystemdb;Uid=root;Pwd=root;");
            dbconnect.Open();

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
            if (accp == "1")
            {
                btnAccountForm.Enabled = true;
            }
            if (enrp == "1")
            {
                btnRegistrationForm.Enabled = true;
            }
            if (empp == "1")
            {
                btnEmployeeForm.Enabled = true;
            }
            if (invp == "1")
            {
                btnInventoryForm.Enabled = true;
            }
            if (usrp == "1")
            {
                btnInventoryForm.Enabled = true;
            }
            if (perm == "11111")
            {
                enablebuttons();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEnrollmentForm_Click(object sender, EventArgs e)
        {
            frmEnroll = new EnrollmentConsole();
            frmEnroll.Show();
            frmEnroll.reference = this;
            this.Hide();

        }
        public EnrollmentConsole frmEnroll;

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
                    frmemp = new frmEmployee(uname);
                    frmemp.Show();
                    frmemp.reference = this;
                    this.Hide();
                }
            }
            
        }
        public frmEmployee frmemp;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                    frmacc = new Accounting.newfrmAccount(uname);
                    frmacc.Show();
                    frmacc.reference = this;
                    this.Hide();
                }
            }
        }
    }
}
