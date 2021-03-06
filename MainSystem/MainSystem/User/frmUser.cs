﻿using System;
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
        DataTable employeeDisplay = new DataTable();
        string filterField = "fullname";
        string fullname;
        public string uname;
        public string userID;
        public string empID;
        public string empID2;
        public string checkExisting;

        public frmUser(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
            loadEmployeeDetails();
            loadUsers();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            dataSearch.DefaultCellStyle.ForeColor = Color.Black;
            dataSearch.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataSearch2.DefaultCellStyle.ForeColor = Color.Black;
            dataSearch2.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataSearch2.ClearSelection();
            dataSearch.ClearSelection();
        }

        public void loadEmployeeDetails()
        {
            employeeDisplay = dbquery.EmployeeDisplay();
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

            dataSearch.Columns["userID"].Visible = false;
            dataSearch.Columns["username"].Visible = false;
            dataSearch.Columns["password"].Visible = false;
            dataSearch.Columns["idemp"].Visible = false;
            dataSearch.Columns["restrictions"].Visible = false;
            dataSearch.Columns["status1"].Visible = false;

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

        private Boolean checker()
        {
            DataTable userExisting = dbquery.checkExisting(empID);
            if(userExisting.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                empID = dataSearch.SelectedRows[0].Cells["empID"].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells["last_name"].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells["middle_name"].Value.ToString();
                DateTime dt = DateTime.Parse(dataSearch.SelectedRows[0].Cells["birth_date"].Value.ToString());
                txtBirthDate.Text = dt.ToString("yyyy/MM/dd");
                txtBirthPlace.Text = dataSearch.SelectedRows[0].Cells["birth_place"].Value.ToString();
                txtContactNo.Text = dataSearch.SelectedRows[0].Cells["contactNo"].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells["sex"].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells["religion"].Value.ToString();
                txtMaritalStatus.Text = dataSearch.SelectedRows[0].Cells["marital_status"].Value.ToString();
                txtStatus.Text = dataSearch.SelectedRows[0].Cells["status"].Value.ToString();
                if(txtStatus.Text == "1")
                {
                    txtStatus.Text = "Active";
                }
                else
                {
                    txtStatus.Text = "Inactive";
                }
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();
                txtPosition.Text = dataSearch.SelectedRows[0].Cells["position"].Value.ToString();
                btnAdd.Enabled = true;
            }
            else
            { return; }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            employeeDisplay.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }

        public User.frmAddUser adduser;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!checker())
            {
                DataTable holder = dbquery.User(uname);
                uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
                adduser = new User.frmAddUser(uname);
                adduser.id = empID;
                adduser.fullname = fullname;

                adduser.Show();
                adduser.reference = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("This employee has already an existing user account");
            }
            
        }

        public User.frmEditUser edituser;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            edituser = new User.frmEditUser(uname);
            edituser.empID = empID2;
            edituser.fullname = txtFullName.Text;
            edituser.restriction = dataSearch2.SelectedRows[0].Cells["restrictions"].Value.ToString();
            edituser.username = txtUsername.Text;
            edituser.userID = userID;
            edituser.password = txtPassword.Text;
            edituser.Show();
            edituser.reference = this;
            this.Hide();
        }

        private void dataSearch2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userID = dataSearch2.SelectedRows[0].Cells["userID"].Value.ToString();
                txtFullName.Text = dataSearch2.SelectedRows[0].Cells["fullname"].Value.ToString();
                txtUsername.Text = dataSearch2.SelectedRows[0].Cells["username"].Value.ToString();
                txtPassword.Text = dataSearch2.SelectedRows[0].Cells["password"].Value.ToString();
                empID2 = dataSearch2.SelectedRows[0].Cells["idemp"].Value.ToString();
                btnEdit.Enabled = true;
            }
            else
            { return; }
        }

        private void dataSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
