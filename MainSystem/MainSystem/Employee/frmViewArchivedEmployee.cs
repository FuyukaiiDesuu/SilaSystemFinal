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
    public partial class frmViewArchivedEmployee : Form
    {

        public frmEmployee reference { get; set; }
        public frmViewArchivedEmployee()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private void frmViewArchivedEmployee_Load(object sender, EventArgs e)
        {
            readData();
            disableButton();
            renameDataTableColumns();
            //For Disabling auto-select in datagrid view 
            dataSearch.Rows[0].Selected = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        public void readData()
        {
            //For Reading the Data
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM employee WHERE status = 0";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When typing first name data grid automatically search that employee
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM employee WHERE first_name LIKE '" + txtSearch.Text + "%' AND status = 0");
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
                cmbStatus.Text = dataSearch.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            EnableInactive();
            reference.clearText();
        }

        private void disableButton()
        {
            //Disabling Button when txtStatus is empty
            btnEnable.Enabled = !string.IsNullOrWhiteSpace(cmbStatus.Text);
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            //Disabling Enable Button when TxtStatus is not 0
            if (cmbStatus.Text == "1")
            {
                btnEnable.Enabled = true;
            }
            else
            {
                btnEnable.Enabled = false;
            }
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Disable editing value in datagrid view
            dataSearch.Rows[e.RowIndex].ReadOnly = true;
        }

        private void EnableInactive()
        {
            //Editing Data
            MySqlConnection conn = connect.connector();
            String query = "UPDATE employee SET status='" + cmbStatus.Text +
                "' WHERE empID='" + txtEmployeeID.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Enabled");
                this.Close();
                reference.Show();
                reference.readData();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
            this.Close();
            reference.Show();
            reference.dataSearch.Rows[0].Selected = false;
        }
    }
}
