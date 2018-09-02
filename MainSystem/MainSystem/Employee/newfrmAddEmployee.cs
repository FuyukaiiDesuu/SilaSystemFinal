﻿using System;
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
        int countPayment;
        
        public newfrmAddEmployee()
        {
            InitializeComponent();
        }

        private void newfrmAddEmployee_Load(object sender, EventArgs e)
        {
            DataTable countEmployeeID = dbquery.countEmployeeID();
            countPayment = countEmployeeID.Rows.Count + 1;
            txtEmployeeID.Text = countPayment.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbReligion.Text == "Others")
            {
                dbquery.addEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, txtSpecify.Text, cmbMaritalStatus.Text, txtStatus.Text);
            }
            else
            {
                dbquery.addEmployee(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dateBirthDate.Text, txtBirthPlace.Text, txtContactNo.Text, cmbSex.Text, cmbReligion.Text, cmbMaritalStatus.Text, txtStatus.Text);
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
    }
}