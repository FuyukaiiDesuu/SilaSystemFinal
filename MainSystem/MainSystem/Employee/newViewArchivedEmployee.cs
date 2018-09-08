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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            string status;
            if (cmbStatus.Text == "Active")
            {
                status = "1";
            }
            else
            {
                status = "0";
            }
            dbquery.updateEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, txtBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, txtSex.Text, txtReligion.Text, txtMaritalStatus.Text, status, id);
            dbquery.updateAccountStatus(id, status, userID);
            MessageBox.Show("Succesfully Updated");
            reference.Show();
            reference.loadEmployeeDetails();
            reference.dataSearch.ClearSelection();
            reference.clearText();
            this.Close();
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userID = dataSearch.SelectedRows[0].Cells["userID"].Value.ToString();
                id = dataSearch.SelectedRows[0].Cells["empID"].Value.ToString();
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
                if (dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "1")
                {
                    cmbStatus.Text = "Active";
                }
                else if (dataSearch.SelectedRows[0].Cells["status"].Value.ToString() == "0")
                {
                    cmbStatus.Text = "Inactive";
                }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            archivedemployeeDisplay.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
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
