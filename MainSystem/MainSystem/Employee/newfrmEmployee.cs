using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Employee
{
    public partial class newfrmEmployee : Form
    {
        public frmMain reference { get; set; }
        Employee.DbQueries dbquery = new Employee.DbQueries();
        DataTable employeeDisplay = new DataTable();
        string filterField = "fullname";
        string fullname;
        public string uname;
        public string empID;
        public string userID;
        public newfrmEmployee(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
            loadEmployeeDetails();
        }

        private void newfrmEmployee_Load(object sender, EventArgs e)
        {
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
            dataSearch.Columns["birth_date"].HeaderText = "Birth Date";
            dataSearch.Columns["birth_place"].HeaderText = "Birth Place";
            dataSearch.Columns["contactNo"].HeaderText = "Contact No";
            dataSearch.Columns["sex"].HeaderText = "Sex";
            dataSearch.Columns["religion"].HeaderText = "Religion";
            dataSearch.Columns["marital_status"].HeaderText = "Marital Status";
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

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userID = dataSearch.SelectedRows[0].Cells["userID"].Value.ToString();
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
                if(dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "1")
                {
                    txtStatus.Text = "Active";
                }
                else if (dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "0")
                {
                    txtStatus.Text = "Inactive";
                }
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();

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

        public Employee.newfrmAddEmployee addemp;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addemp = new Employee.newfrmAddEmployee();
            addemp.Show();
            addemp.reference = this;
            this.Hide();
        }

        public Employee.newfrmEditEmployee editemp;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            editemp = new Employee.newfrmEditEmployee();
            editemp.userID = userID;
            editemp.id = empID;
            editemp.firstname = txtFirstName.Text;
            editemp.lastname = txtLastName.Text;
            editemp.middlename = txtMiddleName.Text;
            editemp.birthdate = txtBirthDate.Text;
            editemp.birthplace = txtBirthPlace.Text;
            editemp.contactno = txtContactNo.Text;
            editemp.sex = txtSex.Text;
            editemp.religion = txtReligion.Text;
            editemp.maritalstatus = txtMaritalStatus.Text;
            editemp.status = txtStatus.Text;

            editemp.Show();
            editemp.reference = this;
            this.Hide();
        }

        public void clearText()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtBirthDate.Text = "";
            txtBirthPlace.Text = "";
            txtContactNo.Text = "";
            txtSearch.Text = "";
            txtSex.Text = "";
            txtReligion.Text = "";
            txtMaritalStatus.Text = "";
            txtStatus.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            employeeDisplay.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }

        public Employee.newViewArchivedEmployee viewemp;
        private void btnView_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            viewemp = new Employee.newViewArchivedEmployee(uname);
            viewemp.uname = uname;
            viewemp.id = empID;
            viewemp.Show();
            viewemp.reference = this;
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
