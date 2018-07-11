﻿using System;
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
            renameDataTableColumns();
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
                string query = ("SELECT * FROM employee WHERE first_name LIKE '" + txtSearch.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
        }
    }
}