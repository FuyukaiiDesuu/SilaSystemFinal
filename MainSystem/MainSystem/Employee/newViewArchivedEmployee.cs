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
        public string uname;
        string fullname;

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
            DataTable archivedemployeeDisplay = dbquery.ArchiveEmployeeDisplay();
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
            dbquery.updateEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, txtSex.Text, txtReligion.Text, txtMaritalStatus.Text, cmbStatus.Text, txtEmployeeID.Text);
            MessageBox.Show("Succesfully Updated");
            reference.Show();
            reference.loadEmployeeDetails();
            reference.dataSearch.Rows[0].Selected = false;
            reference.clearText();
            this.Close();
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEmployeeID.Text = dataSearch.SelectedRows[0].Cells["empID"].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells["last_name"].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells["middle_name"].Value.ToString();
                dateBirthDate.Text = dataSearch.SelectedRows[0].Cells["birth_date"].Value.ToString();
                txtBirthPlace.Text = dataSearch.SelectedRows[0].Cells["birth_place"].Value.ToString();
                txtContactNo.Text = dataSearch.SelectedRows[0].Cells["contactNo"].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells["sex"].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells["religion"].Value.ToString();
                txtMaritalStatus.Text = dataSearch.SelectedRows[0].Cells["marital_status"].Value.ToString();
                cmbStatus.Text = dataSearch.SelectedRows[0].Cells["status"].Value.ToString();
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();

            }
            else
            { return; }
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "1")
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
            string last_name = txtSearch.Text;
            DataTable holder = dbquery.searcArchivedhEmployee(last_name);
            dataSearch.DataSource = holder;
        }
    }
}
