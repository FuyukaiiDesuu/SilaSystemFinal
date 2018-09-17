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
    public partial class newfrmEditEmployee : Form
    {
        public Employee.newfrmEmployee reference { get; set; }
        Employee.DbQueries dbquery = new Employee.DbQueries();
        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string birthdate { get; set; }
        public string birthplace { get; set; }
        public string contactno { get; set; }
        public string sex { get; set; }
        public string religion { get; set; }
        public string maritalstatus { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string userID { get; set; }
        public newfrmEditEmployee()
        {
            InitializeComponent();
        }

        private void newfrmEditEmployee_Load(object sender, EventArgs e)
        {
            txtUserAccountID.Text = userID;
            txtFirstName.Text = firstname; 
            txtLastName.Text = lastname; 
            txtMiddleName.Text = middlename; 
            dateBirthDate.Text = birthdate; 
            txtBirthPlace.Text = birthplace; 
            txtContactNo.Text = contactno; 
            cmbSex.Text = sex; 
            cmbReligion.Text = religion; 
            cmbMaritalStatus.Text = maritalstatus;
            cmbStatus.Text = status;
            cmbPosition.Text = position;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            reference.dataSearch.ClearSelection();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save your changes?", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string status, religion;
            if(cmbStatus.Text == "Active")
            {
                status = "1";
            }
            else
            {
                status = "0";
            }

            if(cmbReligion.Text == "Others")
            {
                religion = txtSpecify.Text;
            }
            else
            {
                religion = cmbReligion.Text;
            }
            if (result.Equals(DialogResult.OK))
            {
                dbquery.updateEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, religion, cmbMaritalStatus.Text, status, cmbPosition.Text, id);
                dbquery.updateAccountStatus(id, status, userID);
                MessageBox.Show("Succesfully Updated");
                reference.Show();
                reference.loadEmployeeDetails();
                reference.dataSearch.ClearSelection();
                reference.clearText();
                this.Close();
            }
            else
            {
                MessageBox.Show("Changes has not been made");
            }
            
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
    }
}
