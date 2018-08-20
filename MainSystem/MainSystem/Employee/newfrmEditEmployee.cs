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
        public newfrmEditEmployee()
        {
            InitializeComponent();
        }

        private void newfrmEditEmployee_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = id;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbReligion.Text == "Others")
            {
                dbquery.updateEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, txtSpecify.Text, cmbMaritalStatus.Text, cmbStatus.Text, txtEmployeeID.Text);
            }
            else
            {
                dbquery.updateEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, cmbReligion.Text, cmbMaritalStatus.Text, cmbStatus.Text, txtEmployeeID.Text);
            }
            MessageBox.Show("Succesfully Updated");
            reference.Show();
            reference.loadEmployeeDetails();
            reference.dataSearch.Rows[0].Selected = false;
            reference.clearText();
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
    }
}
