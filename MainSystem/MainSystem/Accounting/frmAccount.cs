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
    public partial class frmAccount : Form
    {
        public frmMain reference { get; set; }
        public frmAccount()
        {
            InitializeComponent();
        }
        //For Connecting to Database and putting a global varialbe of data adapter and datatable.
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        public void readData()
        {
            //For Reading the Data
            using(MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM students";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            frmAddTransaction addTransaction = new frmAddTransaction();
            //For passing the value of StudentID and StudentName from frmAccount to frmAddTransaction
            for (int i = 0; i < dataSearch.SelectedRows.Count; i++)
            {
                addTransaction.txtStudentID.Text = dataSearch.SelectedRows[i].Cells[1].Value.ToString();
                addTransaction.txtStudentName.Text = dataSearch.SelectedRows[i].Cells[2].Value.ToString()
                                                   + " "
                                                   + dataSearch.SelectedRows[i].Cells[3].Value.ToString()
                                                   + " "
                                                   + dataSearch.SelectedRows[i].Cells[4].Value.ToString();
                
            }
            addTransaction.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            //For Reading the Data.
            readData();

            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();

            //For Renaming the Data Table Columns.
            renameDataTableColumns();

            //For Searching Student
            searchStudent();

            //For Disabling auto-select in datagrid view 
            dataSearch.Rows[0].Selected = false;
        }

        private void disableAddTransactionButton()
        {
            //For Disabling Add Transaction Button when all textboxes are empty.
            btnAddTransaction.Enabled = !string.IsNullOrWhiteSpace(txtStudentID.Text) &&
                                        !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                                        !string.IsNullOrWhiteSpace(txtMiddleName.Text) &&
                                        !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                                        !string.IsNullOrWhiteSpace(txtGender.Text) &&
                                        !string.IsNullOrWhiteSpace(txtSection.Text) &&
                                        !string.IsNullOrWhiteSpace(txtLevel.Text) &&
                                        !string.IsNullOrWhiteSpace(txtDepartment.Text) &&
                                        !string.IsNullOrWhiteSpace(txtStatus.Text);
        }

        private void renameDataTableColumns()
        {
            //for DataGridView Search
            dataSearch.Columns["id"].HeaderText = "ID";
            dataSearch.Columns["student_id_no"].HeaderText = "Student ID No.";
            dataSearch.Columns["student_firstname"].HeaderText = "First Name";
            dataSearch.Columns["student_middlename"].HeaderText = "Middle Name";
            dataSearch.Columns["student_lastname"].HeaderText = "Last Name";
            dataSearch.Columns["student_gender"].HeaderText = "Gender";
            dataSearch.Columns["student_section"].HeaderText = "Section";
            dataSearch.Columns["student_level"].HeaderText = "Level";
            dataSearch.Columns["student_department"].HeaderText = "Department";
            dataSearch.Columns["student_status"].HeaderText = "Status";
        }

        private void searchStudent()
        {
            //For Searching Student
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "SELECT * FROM students";
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When typing first name data grid automatically search that student
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM students WHERE student_firstname LIKE '" + txtSearch.Text + "%'");
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
                txtStudentID.Text = dataSearch.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells[2].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells[3].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells[4].Value.ToString();
                txtGender.Text = dataSearch.SelectedRows[0].Cells[5].Value.ToString();
                txtSection.Text = dataSearch.SelectedRows[0].Cells[6].Value.ToString();
                txtLevel.Text = dataSearch.SelectedRows[0].Cells[7].Value.ToString();
                txtDepartment.Text = dataSearch.SelectedRows[0].Cells[8].Value.ToString();
                txtStatus.Text = dataSearch.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Transaction Button when all textboxes are empty except the Search Texbox.
            disableAddTransactionButton();
        }
    }
}
