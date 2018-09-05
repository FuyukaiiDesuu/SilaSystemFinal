using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.User
{
    public partial class frmEditUser : Form
    {
        public User.frmUser reference { get; set; }
        User.DbQueries dbquery = new User.DbQueries();
        public string empID { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string restriction { get; set; }
        
        public string userID { get; set; }
        public frmEditUser(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = empID;
            txtFullName.Text = fullname;
            txtUsername.Text = username;
            txtPassword.Text = password;
            restrictor(restriction);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
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

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        IDictionary<string, string> dict;
        private void btnSave_Click(object sender, EventArgs e)
        {
            dict = new Dictionary<string, string>();
            dict.Add("acc", "0");
            dict.Add("reg", "0");
            dict.Add("emp", "0");
            dict.Add("inv", "0");
            dict.Add("user", "0");
           
            if (checkAccounting.Checked)
            {
                dict["acc"] = "1";
            }
            if(checkRegistration.Checked)
            {
                dict["reg"] = "1";
            }
            if (checkEmployee.Checked)
            {
                dict["emp"] = "1";
            }
            if (checkInventory.Checked)
            {
                dict["inv"] = "1";
            }
            if (checkUser.Checked)
            {
                dict["user"] = "1";
            }
            string temp = dict["acc"] + dict["reg"] + dict["emp"] + dict["inv"] + dict["user"];
            dbquery.updatUser(txtUsername.Text, txtPassword.Text, temp, "1", userID);
            MessageBox.Show("Succesfully Updated");
            reference.Show();
            reference.dataSearch2.ClearSelection();
            reference.dataSearch.ClearSelection();
            reference.loadUsers();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
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
                checkAccounting.Checked = true;
            }
            if (enrp == "1")
            {
                checkRegistration.Checked = true;
            }
            if (empp == "1")
            {
                checkEmployee.Checked = true;
            }
            if (invp == "1")
            {
                checkInventory.Checked = true;
            }
            if (usrp == "1")
            {
                checkUser.Checked = true;
            }
            if (perm == "11111")
            {
                checkAccounting.Checked = true;
                checkRegistration.Checked = true;
                checkEmployee.Checked = true;
                checkInventory.Checked = true;
                checkUser.Checked = true;
            }
        }
    }
}
