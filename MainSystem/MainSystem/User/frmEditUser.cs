﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.User
{
    public partial class frmEditUser : Form
    {
        public User.frmUser reference { get; set; }
        User.DbQueries dbquery = new User.DbQueries();
        public string id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        int countUserID;
        public frmEditUser(string uname)
        {
            InitializeComponent();
            lblUser.Text = uname;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            DataTable countEmployeeID = dbquery.countUserID();
            countUserID = countEmployeeID.Rows.Count;
            txtID.Text = countUserID.ToString();
            txtEmployeeID.Text = id;
            txtFullName.Text = fullname;
            txtUsername.Text = username;
            txtPassword.Text = password;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //CHECKBOX ACCOUNTING
            if (checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10000", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11000", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10100", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10010", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10001", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11100", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkEmployee.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10110", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkInventory.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10011", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkInventory.Checked && checkUser.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11011", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkInventory.Checked && checkUser.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10111", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkEmployee.Checked && checkUser.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11101", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkInventory.Checked && checkInventory.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            //CHECKBOX REGISTRATION
            else if (checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01000", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11000", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01100", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01010", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01001", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkAccounting.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11100", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkEmployee.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01110", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkInventory.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01101", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkAccounting.Checked && checkEmployee.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkUser.Checked && checkEmployee.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01111", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkAccounting.Checked && checkUser.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11011", "1", txtID.Text);
            }
            else if (checkRegistration.Checked && checkAccounting.Checked && checkEmployee.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11101", "1", txtID.Text);
            }
            //CHECKBOX EMPLOYEE
            else if (checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00100", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10100", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01100", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00110", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00101", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkAccounting.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11100", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkInventory.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01110", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkUser.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01101", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkAccounting.Checked && checkRegistration.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkUser.Checked && checkRegistration.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01111", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkUser.Checked && checkAccounting.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10111", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkUser.Checked && checkRegistration.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11101", "1", txtID.Text);
            }
            else if (checkEmployee.Checked && checkAccounting.Checked && checkRegistration.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            //CHECKBOX INVENTORY
            else if (checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00010", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10010", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01010", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00110", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00011", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkAccounting.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11010", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkEmployee.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01110", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkEmployee.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00111", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkAccounting.Checked && checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkUser.Checked && checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01111", "1", txtID.Text);
            }
            else if (checkInventory.Checked && checkAccounting.Checked && checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11110", "1", txtID.Text);
            }
            //CHECKBOX USER
            else if (checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00001", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10001", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01001", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00101", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkInventory.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00011", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkInventory.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "00111", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkRegistration.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01101", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkRegistration.Checked && checkAccounting.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11001", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkRegistration.Checked && checkAccounting.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11101", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkRegistration.Checked && checkInventory.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "01111", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkAccounting.Checked && checkInventory.Checked && checkEmployee.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "10111", "1", txtID.Text);
            }
            else if (checkUser.Checked && checkAccounting.Checked && checkInventory.Checked && checkRegistration.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11011", "1", txtID.Text);
            }
            else if (checkAccounting.Checked && checkEmployee.Checked && checkRegistration.Checked && checkInventory.Checked && checkUser.Checked)
            {
                dbquery.updatUser(txtUsername.Text, txtPassword.Text, txtEmployeeID.Text, "11111", "1", txtID.Text);
            }
            MessageBox.Show("Succesfully Updated");
            reference.Show();
            reference.dataSearch.ClearSelection();
            reference.dataSearch2.ClearSelection();
            reference.loadUsers();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
    }
}