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
    public partial class newViewArchivedEmployee : Form
    {
        public newfrmEmployee reference { get; set; }
        Employee.DbQueries dbquery = new Employee.DbQueries();
        DataTable archivedemployeeDisplay = new DataTable();
        string filterField = "fullname";
        public string uname;
        public string id;
        string fullname;
        public string userID;
        public string firstname;
        public string middlename;
        public string lastname;
        public newViewArchivedEmployee(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
            loadArchivedEmployee();
        }

        private void newViewArchivedEmployee_Load(object sender, EventArgs e)
        {
            dataSearch.ClearSelection();
        }

        public void loadArchivedEmployee()
        {
            archivedemployeeDisplay = dbquery.ArchiveEmployeeDisplay();
            this.dataSearch.DataSource = archivedemployeeDisplay;
            dataSearch.Columns["empID"].Visible = false;
            dataSearch.Columns["first_name"].HeaderText = "First Name";
            dataSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dataSearch.Columns["last_name"].HeaderText = "Last Name";
            dataSearch.Columns["fullname"].Visible = false;
            dataSearch.Columns["birth_date"].Visible = false;
            dataSearch.Columns["birth_place"].Visible = false;
            dataSearch.Columns["contactNo"].Visible = false;
            dataSearch.Columns["sex"].Visible = false;
            dataSearch.Columns["religion"].Visible = false;
            dataSearch.Columns["marital_status"].Visible = false;
            dataSearch.Columns["status"].Visible = false;
            dataSearch.Columns["position"].Visible = false;

            dataSearch.Columns["userID"].Visible = false;
            dataSearch.Columns["username"].Visible = false;
            dataSearch.Columns["password"].Visible = false;
            dataSearch.Columns["idemp"].Visible = false;
            dataSearch.Columns["restrictions"].Visible = false;
            dataSearch.Columns["status1"].Visible = false;

            this.dataSearch.Columns["first_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataSearch.Columns["middle_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataSearch.Columns["last_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataSearch.ReadOnly = true;
            this.dataSearch.Refresh();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Dispose();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save your changes?", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string status;
            if (cmbStatus.Text == "Active")
            {
                status = "1";
            }
            else
            {
                status = "0";
            }
            if (result.Equals(DialogResult.OK))
            {
                dbquery.updateEmployee(firstname, lastname, middlename, txtBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, txtSex.Text, txtReligion.Text, txtMaritalStatus.Text, status, txtPosition.Text, id);
                dbquery.updateAccountStatus(id, status, userID);
                MessageBox.Show("Succesfully Updated");
                reference.Show();
                reference.loadEmployeeDetails();
                reference.dataSearch.ClearSelection();
                reference.clearText();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Changes has not been made");
            }
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userID = dataSearch.SelectedRows[0].Cells["userID"].Value.ToString();
                id = dataSearch.SelectedRows[0].Cells["empID"].Value.ToString();
                firstname = dataSearch.SelectedRows[0].Cells["first_name"].Value.ToString();
                lastname = dataSearch.SelectedRows[0].Cells["last_name"].Value.ToString();
                middlename = dataSearch.SelectedRows[0].Cells["middle_name"].Value.ToString();
                txtFullName.Text = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();
                DateTime dt = DateTime.Parse(dataSearch.SelectedRows[0].Cells["birth_date"].Value.ToString());
                txtBirthDate.Text = dt.ToString("yyyy/MM/dd");
                txtBirthPlace.Text = dataSearch.SelectedRows[0].Cells["birth_place"].Value.ToString();
                txtContactNo.Text = dataSearch.SelectedRows[0].Cells["contactNo"].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells["sex"].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells["religion"].Value.ToString();
                txtMaritalStatus.Text = dataSearch.SelectedRows[0].Cells["marital_status"].Value.ToString();
                if (dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "1")
                {
                    cmbStatus.Text = "Active";
                }
                else if (dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "0")
                {
                    cmbStatus.Text = "Inactive";
                }
                txtPosition.Text = dataSearch.SelectedRows[0].Cells["position"].Value.ToString();
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();

            }
            else
            { return; }
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "Active")
            {
                btnEnable.Enabled = true;
            }
            else
            {
                btnEnable.Enabled = false;
            }
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            archivedemployeeDisplay.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }

        private void newViewArchivedEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
