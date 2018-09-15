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
    public partial class newfrmAddEmployee : Form
    {
        public Employee.newfrmEmployee reference { get; set; }
        Employee.DbQueries dbquery = new Employee.DbQueries();
        
        public newfrmAddEmployee()
        {
            InitializeComponent();
        }

        private void newfrmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbReligion.Text == "Others")
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
            }
            else
            {
                txtSpecify.Enabled = false;
            }
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

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Please enter the first name");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, null);
            }
        }
    }
}
