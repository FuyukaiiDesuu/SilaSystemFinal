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

namespace MainSystem.Employee
{
    public partial class newfrmAddEmployee : Form
    {
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public MySqlConnection dbconnection;
        public Employee.newfrmEmployee reference { get; set; }
        Employee.DbQueries dbquery = new Employee.DbQueries();
        
        public newfrmAddEmployee()
        {
            InitializeComponent();
        }

        private void newfrmAddEmployee_Load(object sender, EventArgs e)
        {
            enableButton();
        }
        private Boolean empcheck(string fn, string ln, string mn)
        {
            var connect = new dbConnector();
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM employee WHERE first_name = '" + fn + "' AND last_name = '" + ln + "' AND middle_name = '" + mn + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("An Employee Has Already Been Added With The Same Name!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!empcheck(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text))
            {
                if (cmbReligion.Text == "Others")
                {
                    dbquery.addEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, txtSpecify.Text, cmbMaritalStatus.Text, "1", cmbPosition.Text);
                }
                else
                {
                    dbquery.addEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, cmbReligion.Text, cmbMaritalStatus.Text, "1", cmbPosition.Text);
                }

                MessageBox.Show("Succesfully Added");
                reference.Show();
                reference.loadEmployeeDetails();
                reference.dataSearch.ClearSelection();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            reference.dataSearch.ClearSelection();
            this.Close();
        }

        private void cmbReligion_TextChanged(object sender, EventArgs e)
        {
            if(cmbReligion.Text == "Others")
            {
                txtSpecify.Enabled = true;
                enableButton();
            }
            else
            {
                txtSpecify.Enabled = false;
                enableButton();
            }
        }


        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(txtFirstName, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (txtMiddleName.Text == string.Empty)
            {
                errorProvider1.SetError(txtMiddleName, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(txtMiddleName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                errorProvider1.SetError(txtLastName, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void cmbPosition_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPosition.Text == string.Empty)
            {
                errorProvider1.SetError(cmbPosition, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(cmbPosition, "");
            }
        }

        private void dateBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (dateBirthDate.Text == string.Empty)
            {
                errorProvider1.SetError(dateBirthDate, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(dateBirthDate, "");            }
        }

        private void txtBirthPlace_Validating(object sender, CancelEventArgs e)
        {
            if (txtBirthPlace.Text == string.Empty)
            {
                errorProvider1.SetError(txtBirthPlace, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(txtBirthPlace, "");
            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtContactNo.Text == string.Empty)
            {
                errorProvider1.SetError(txtContactNo, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(txtContactNo, "");
            }
        }

        private void cmbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSex.Text == string.Empty)
            {
                errorProvider1.SetError(cmbSex, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(cmbSex, "");
            }
        }

        private void cmbReligion_Validating(object sender, CancelEventArgs e)
        {
            if (cmbReligion.Text == string.Empty)
            {
                errorProvider1.SetError(cmbReligion, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(cmbReligion, "");
            }
        }

        private void cmbMaritalStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMaritalStatus.Text == string.Empty)
            {
                errorProvider1.SetError(cmbMaritalStatus, "Please fill out this field");
            }
            else
            {
                errorProvider1.SetError(cmbMaritalStatus, "");
            }
        }
        private void enableButton()
        {
            btnSave.Enabled = !string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtMiddleName.Text)
                && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(cmbPosition.Text)
                && !string.IsNullOrEmpty(dateBirthDate.Text) && !string.IsNullOrEmpty(txtBirthPlace.Text)
                && !string.IsNullOrEmpty(txtContactNo.Text) && !string.IsNullOrEmpty(cmbSex.Text)
                && !string.IsNullOrEmpty(cmbReligion.Text) && !string.IsNullOrEmpty(cmbMaritalStatus.Text);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
           enableButton();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
           enableButton();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void cmbPosition_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void dateBirthDate_ValueChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void txtBirthPlace_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void cmbSex_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void cmbMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
    }
}
