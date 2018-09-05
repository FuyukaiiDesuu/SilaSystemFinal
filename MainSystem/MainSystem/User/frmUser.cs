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
    public partial class frmUser : Form
    {
        public frmMain reference { get; set; }
        User.DbQueries dbquery = new User.DbQueries();
        string fullname;
        public string uname;
        public string uid;
        public string eid;
        public string fn;
        public string un;
        public string pw;
        public frmUser(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
            loadEmployeeDetails();
            loadUsers();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            dataSearch.ClearSelection();
            dataSearch2.ClearSelection();
        }

        public void loadEmployeeDetails()
        {
            DataTable employeeDisplay = dbquery.EmployeeDisplay();
            this.dataSearch.DataSource = employeeDisplay;

            dataSearch.Columns["empID"].Visible = false;
            dataSearch.Columns["first_name"].Visible = false;
            dataSearch.Columns["middle_name"].Visible = false;
            dataSearch.Columns["last_name"].Visible = false;
            dataSearch.Columns["fullname"].HeaderText = "Full Name";
            dataSearch.Columns["birth_date"].Visible = false;
            dataSearch.Columns["birth_place"].Visible = false;
            dataSearch.Columns["contactNo"].Visible = false;
            dataSearch.Columns["sex"].Visible = false;
            dataSearch.Columns["religion"].Visible = false;
            dataSearch.Columns["marital_status"].Visible = false;
            dataSearch.Columns["status"].Visible = false;

            dataSearch.Columns["fullname"].DisplayIndex = 4;
            this.dataSearch.Columns["fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataSearch.ReadOnly = true;
            this.dataSearch.Refresh();
        }

        public void loadUsers()
        {
            DataTable UserDisplay = dbquery.UserDisplay();
            this.dataSearch2.DataSource = UserDisplay;

            dataSearch2.Columns["UserID"].Visible = false;
            dataSearch2.Columns["idemp"].Visible = false;
            dataSearch2.Columns["username"].HeaderText = "Username";
            dataSearch2.Columns["password"].Visible = false;
            dataSearch2.Columns["restrictions"].Visible = false;
            dataSearch2.Columns["status"].Visible = false;
            dataSearch2.Columns["empID"].Visible = false;
            dataSearch2.Columns["first_name"].Visible = false;
            dataSearch2.Columns["middle_name"].Visible = false;
            dataSearch2.Columns["last_name"].Visible = false;
            dataSearch2.Columns["fullname"].Visible = false;
            dataSearch2.Columns["birth_date"].Visible = false;
            dataSearch2.Columns["birth_place"].Visible = false;
            dataSearch2.Columns["contactNo"].Visible = false;
            dataSearch2.Columns["sex"].Visible = false;
            dataSearch2.Columns["religion"].Visible = false;
            dataSearch2.Columns["marital_status"].Visible = false;
            dataSearch2.Columns["status"].Visible = false;
            dataSearch2.Columns["status1"].Visible = false;
            dataSearch.Columns["fullname"].DisplayIndex = 0;
            dataSearch2.ReadOnly = true;
            this.dataSearch2.Refresh();
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEmployeeID.Text = dataSearch.SelectedRows[0].Cells["empID"].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells["last_name"].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells["middle_name"].Value.ToString();
                txtBirthDate.Text = dataSearch.SelectedRows[0].Cells["birth_date"].Value.ToString();
                txtBirthPlace.Text = dataSearch.SelectedRows[0].Cells["birth_place"].Value.ToString();
                txtContactNo.Text = dataSearch.SelectedRows[0].Cells["contactNo"].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells["sex"].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells["religion"].Value.ToString();
                txtMaritalStatus.Text = dataSearch.SelectedRows[0].Cells["marital_status"].Value.ToString();
                txtStatus.Text = dataSearch.SelectedRows[0].Cells["status"].Value.ToString();
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            { return; }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string lastname = txtSearch.Text;
            DataTable holder = dbquery.searchEmployee(lastname);
            dataSearch.DataSource = holder;
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

        public User.frmAddUser adduser;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            adduser = new User.frmAddUser(uname);
            adduser.id = txtEmployeeID.Text;
            adduser.fullname = fullname;

            adduser.Show();
            adduser.reference = this;
            this.Hide();
        }

        public User.frmEditUser edituser;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            edituser = new User.frmEditUser(uname);
            edituser.id = txtEmployeeID.Text = dataSearch2.SelectedRows[0].Cells["empID"].Value.ToString();
            edituser.fullname = txtFullName.Text = dataSearch2.SelectedRows[0].Cells["fullname"].Value.ToString();
            edituser.restriction = dataSearch2.SelectedRows[0].Cells["restrictions"].Value.ToString();
            edituser.username = txtUsername.Text;
            edituser.userID = txtUserID.Text;
            edituser.password = txtPassword.Text;
            edituser.Show();
            edituser.reference = this;
            this.Hide();
        }

        private void dataSearch2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUserID.Text = dataSearch2.SelectedRows[0].Cells["userID"].Value.ToString();
                txtFullName.Text = dataSearch2.SelectedRows[0].Cells["fullname"].Value.ToString();
                txtUsername.Text = dataSearch2.SelectedRows[0].Cells["username"].Value.ToString();
                txtPassword.Text = dataSearch2.SelectedRows[0].Cells["password"].Value.ToString();

                btnEdit.Enabled = true;
            }
            else
            { return; }
        }
    }
}
