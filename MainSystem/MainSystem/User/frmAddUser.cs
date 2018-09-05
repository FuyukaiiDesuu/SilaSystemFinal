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
    public partial class frmAddUser : Form
    {
        public User.frmUser reference { get; set; }
        User.DbQueries dbquery = new User.DbQueries();
        public string id { get; set; }
        public string fullname { get; set; }
        int countUserID;
        public frmAddUser(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            DataTable countEmployeeID = dbquery.countUserID();
            countUserID = countEmployeeID.Rows.Count + 1;
            txtID.Text = countUserID.ToString();
            txtEmployeeID.Text = id;
            txtFullName.Text = fullname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
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
            if (checkRegistration.Checked)
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
            dbquery.addUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, temp, "1");
            MessageBox.Show("Succesfully Added");
            reference.Show();
            reference.dataSearch.ClearSelection();
            reference.loadUsers();
            this.Close();
        }
    }
}
