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
    public partial class frmEmployee : Form
    {
        public frmMain reference { get; set; }

        public frmEmployee()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            readData();
            renameDataTableColumns();
            disableEditButton();

            //"Status" Row in DataSearch is disabled
            dataSearch.Rows[0].Selected = false;

            //For Disabling auto-select in datagrid view 
            dataSearch.Rows[0].Selected = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmaddemp = new frmAddEmployee();
            frmaddemp.Show();
            frmaddemp.reference = this;
            this.Hide();
            readData();
        }
        public frmAddEmployee frmaddemp;

        private void btnView_Click(object sender, EventArgs e)
        {
            frmviewemp = new frmViewArchivedEmployee();
            frmviewemp.Show();
            frmviewemp.reference = this;
            this.Hide();
            readData();
        }
        public frmViewArchivedEmployee frmviewemp;
        
        public void readData()
        {
            //For Reading the Data
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM employee WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
                dataSearch.Columns["status"].Visible = false;
            }
        }

        private void renameDataTableColumns()
        {
            //for DataGridView Search
            dataSearch.Columns["empID"].HeaderText = "ID";
            dataSearch.Columns["first_name"].HeaderText = "First Name";
            dataSearch.Columns["last_name"].HeaderText = "Last Name";
            dataSearch.Columns["middle_name"].HeaderText = "Middle Name";
            dataSearch.Columns["birth_date"].HeaderText = "Birth Date";
            dataSearch.Columns["birth_place"].HeaderText = "Birth Place";
            dataSearch.Columns["contactNo"].HeaderText = "Contact #";
            dataSearch.Columns["sex"].HeaderText = "Sex";
            dataSearch.Columns["religion"].HeaderText = "Religion";
            dataSearch.Columns["marital_status"].HeaderText = "Marital Status";
            dataSearch.Columns["status"].HeaderText = "Status";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void editData()
        {
            //Passing Value from DataSearch to Textboxes
            frmaddemp = new frmAddEmployee();
            for (int i = 0; i < dataSearch.SelectedRows.Count; i++)
            {
                frmaddemp.txtEmployeeID.Text = dataSearch.SelectedRows[i].Cells[0].Value.ToString();
                frmaddemp.txtFirstName.Text = dataSearch.SelectedRows[i].Cells[1].Value.ToString();
                frmaddemp.txtLastName.Text = dataSearch.SelectedRows[i].Cells[2].Value.ToString();
                frmaddemp.txtMiddleName.Text = dataSearch.SelectedRows[i].Cells[3].Value.ToString();
                frmaddemp.dateBirthDate.Text = dataSearch.SelectedRows[i].Cells[4].Value.ToString();
                frmaddemp.txtBirthPlace.Text = dataSearch.SelectedRows[i].Cells[5].Value.ToString();
                frmaddemp.txtContactNo.Text = dataSearch.SelectedRows[i].Cells[6].Value.ToString();
                frmaddemp.cmbSex.Text = dataSearch.SelectedRows[i].Cells[7].Value.ToString();
                frmaddemp.txtReligion.Text = dataSearch.SelectedRows[i].Cells[8].Value.ToString();
                frmaddemp.txtMaritalStatus.Text = dataSearch.SelectedRows[i].Cells[9].Value.ToString();
                frmaddemp.cmbStatus.Text = dataSearch.SelectedRows[i].Cells[10].Value.ToString();
            }
            frmaddemp.Show();
            frmaddemp.reference = this;
            this.Hide();
            readData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When typing first name data grid automatically search that employee
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM employee WHERE first_name LIKE '" + txtSearch.Text + "%' AND status = 1");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
        }

        private void dataSearch_MouseClick(object sender, MouseEventArgs e)
        {
            //For when clicking cells textbox are autofilled
            if (dataSearch.Rows.Count > 0)
            {
                txtEmployeeID.Text = dataSearch.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells[2].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells[3].Value.ToString();
                txtBirthDate.Text = dataSearch.SelectedRows[0].Cells[4].Value.ToString();
                txtBirthPlace.Text = dataSearch.SelectedRows[0].Cells[5].Value.ToString();
                txtContactNo.Text = dataSearch.SelectedRows[0].Cells[6].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells[7].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells[8].Value.ToString();
                txtMaritalStatus.Text = dataSearch.SelectedRows[0].Cells[9].Value.ToString();
                txtStatus.Text = dataSearch.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void disableEditButton()
        {
            //For Disabling Edit Button when all textboxes are empty.
            btnEdit.Enabled = !string.IsNullOrWhiteSpace(txtEmployeeID.Text) &&
                              !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                              !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                              !string.IsNullOrWhiteSpace(txtMiddleName.Text) &&
                              !string.IsNullOrWhiteSpace(txtBirthDate.Text) &&
                              !string.IsNullOrWhiteSpace(txtBirthPlace.Text) &&
                              !string.IsNullOrWhiteSpace(txtContactNo.Text) &&
                              !string.IsNullOrWhiteSpace(txtSex.Text) &&
                              !string.IsNullOrWhiteSpace(txtReligion.Text) &&
                              !string.IsNullOrWhiteSpace(txtMaritalStatus.Text) &&
                              !string.IsNullOrWhiteSpace(txtStatus.Text);
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtBirthPlace_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void txtMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Edit Button when all textboxes are empty except the Search Texbox.
            disableEditButton();
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Disable editing value in datagrid view
            dataSearch.Rows[e.RowIndex].ReadOnly = true;
        }
    }
}
