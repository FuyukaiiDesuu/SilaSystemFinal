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
    public partial class frmAddEmployee : Form
    {
        public frmEmployee reference { get; set; }

        public frmAddEmployee()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            fetchID();
            enableButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
            reference.dataSearch.Rows[0].Selected = false;
            reference.clearText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
            reference.clearText();
        }

        public void insertData()
        {
            //Inserting Data
            if(txtEmployeeID.Text == txtEmployeeID.Text)
            {
                MySqlConnection conn = connect.connector();
                String query = "INSERT INTO employee(first_name, last_name, middle_name, birth_date, birth_place, contactNo, sex, religion, marital_status, status) " +
                    "VALUES('" + txtFirstName.Text + 
                    "','" + txtLastName.Text + 
                    "','" + txtMiddleName.Text + 
                    "','" + dateBirthDate.Text + 
                    "','" + txtBirthPlace.Text + 
                    "','" + txtContactNo.Text + 
                    "','" + cmbSex.Text +
                    "','" + txtReligion.Text + 
                    "','" + txtMaritalStatus.Text + 
                    "','" + cmbStatus.Text + 
                    "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
                reference.dataSearch.Rows[0].Selected = false;
            }
            //FOR WHEN USING DEFAULTVALUE
            /*using (MySqlConnection conn = connect.connector())
            {
                //Inserting Data
                String query = "UPDATE employee SET first_name='" + txtFirstName.Text + 
                    "',last_name='" + txtLastName.Text + 
                    "',middle_name='" + txtMiddleName.Text +
                    "',birth_date='" + dateBirthDate.Text + 
                    "',birth_place='" + txtBirthPlace.Text + 
                    "',contactNo='" + txtContactNo.Text + 
                    "',sex='" + cmbSex.Text +
                    "',religion='" + txtReligion.Text + 
                    "',marital_status='" + txtMaritalStatus.Text + 
                    "',status='" + cmbStatus.Text +
                    "' WHERE empID='" + reference.dataSearch.Rows.Count + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted");
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
            }
            */
        }

        /*private void defaultValue()
        {
            //Adding EmpID Value to Database even other values are null
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = "INSERT INTO employee VALUES();";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }*/

        private void fetchID()
        {
            MySqlConnection conn = connect.connector();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) + 1 FROM employee ", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            txtEmployeeID.Text = data.Tables[0].Rows[0][0].ToString();
            conn.Close();
        }

        private void enableButton()
        {
            btnSave.Enabled =
                   !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtMiddleName.Text) &&
                   !string.IsNullOrWhiteSpace(dateBirthDate.Text) &&
                   !string.IsNullOrWhiteSpace(txtBirthPlace.Text) &&
                   !string.IsNullOrWhiteSpace(txtContactNo.Text) &&
                   !string.IsNullOrWhiteSpace(cmbSex.Text) &&
                   !string.IsNullOrWhiteSpace(txtReligion.Text) &&
                   !string.IsNullOrWhiteSpace(txtMaritalStatus.Text) &&
                   !string.IsNullOrWhiteSpace(cmbStatus.Text);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtBirthPlace_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void cmbSex_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

        private void txtMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }

    }
}
