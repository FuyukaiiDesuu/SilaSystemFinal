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
    public partial class frmAddTransaction : Form
    {
        public frmAccount reference { get; set; }
        

        public frmAddTransaction()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        private void grpNewPayment_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddTransaction_Load(object sender, EventArgs e)
        {
            //For Disabling Cheque Textbox if text in Payment to is empty or doesnt match with the word CHEQUE
            disableTextbox();
            readempData();
            renameDataTableColumns();
            fetchID();
            fetchPaymentID();
        }


        private void cmbPaymentType_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Cheque Textbox if text in Payment to doesnt match with the word CHEQUE
            if (cmbPaymentType.Text == "2")
            {
                txtChequeNo.Enabled = true;
            }
            else
            {
                txtChequeNo.Enabled = false;
            }
        }

        private void disableTextbox()
        {
            txtChequeNo.Enabled = !string.IsNullOrWhiteSpace(cmbPaymentType.Text);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void readempData()
        {
            //For Reading the Employee Data
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM employee WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataEmployeeDetails.DataSource = dt;
                dataEmployeeDetails.Columns["birth_date"].Visible = false;
                dataEmployeeDetails.Columns["birth_place"].Visible = false;
                dataEmployeeDetails.Columns["contactNo"].Visible = false;
                dataEmployeeDetails.Columns["sex"].Visible = false;
                dataEmployeeDetails.Columns["religion"].Visible = false;
                dataEmployeeDetails.Columns["marital_status"].Visible = false;
                dataEmployeeDetails.Columns["status"].Visible = false;
            }
        }

        private void renameDataTableColumns()
        {
            //for DataGridView Search
            dataEmployeeDetails.Columns["empID"].HeaderText = "ID";
            dataEmployeeDetails.Columns["first_name"].HeaderText = "First Name";
            dataEmployeeDetails.Columns["last_name"].HeaderText = "Last Name";
            dataEmployeeDetails.Columns["middle_name"].HeaderText = "Middle Name";
            dataEmployeeDetails.Columns["birth_date"].HeaderText = "Birth Date";
            dataEmployeeDetails.Columns["birth_place"].HeaderText = "Birth Place";
            dataEmployeeDetails.Columns["contactNo"].HeaderText = "Contact #";
            dataEmployeeDetails.Columns["sex"].HeaderText = "Sex";
            dataEmployeeDetails.Columns["religion"].HeaderText = "Religion";
            dataEmployeeDetails.Columns["marital_status"].HeaderText = "Marital Status";
            dataEmployeeDetails.Columns["status"].HeaderText = "Status";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When typing first name data grid automatically search that employee
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT * FROM employee WHERE empID LIKE '" + txtSearch.Text + "%' AND status = 1");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataEmployeeDetails.DataSource = dt;
            }
        }

        private void dataEmployeeDetails_MouseClick(object sender, MouseEventArgs e)
        {
            //For when clicking cells textbox are autofilled
            if (dataEmployeeDetails.Rows.Count > 0)
            {
                txtEmployeeID.Text = dataEmployeeDetails.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void insertData()
        {
            if (txtTransactionNo.Text == txtTransactionNo.Text)
            {
                using (MySqlConnection conn = connect.connector())
                {
                    String query = "INSERT INTO payment_details() VALUES ()";
                    String query2 = "UPDATE payment_details SET amount='" + txtAmount.Text + "',payment_type='" + cmbPaymentType.Text + "' WHERE paydetailsID='" + txtPaymentID.Text + "'";
                    String query3 = "INSERT INTO studenttransaction(account_id, transaction_datetime, additional_details, transaction_type, employee_id, payment_id) " +
                        "VALUES ('" + txtStudentID.Text +
                        "','" + datePaymentDate.Text +
                        "','" + txtAdditionalDetails.Text +
                        "','" + cmbPaymentType.Text +
                        "','" + txtEmployeeID.Text +
                        "','" + txtPaymentID.Text +
                        "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Successfully Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                    this.Close();
                    reference.Show();
                    reference.readData();
                }
            }
        }
        private void fetchID()
        {
            //Fetching the last autoincremented ID from database
            MySqlConnection conn = connect.connector();
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) + 1 FROM studenttransaction ", conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                txtTransactionNo.Text = data.Tables[0].Rows[0][0].ToString();
            }
            conn.Close();
        }

        private void fetchPaymentID()
        {
            //Fetching the last autoincremented ID from database
            MySqlConnection conn = connect.connector();
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) + 1 FROM payment_details ", conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                txtPaymentID.Text = data.Tables[0].Rows[0][0].ToString();
            }
            conn.Close();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
