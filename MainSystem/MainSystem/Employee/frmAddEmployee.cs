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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
        }

        public void insertData()
        {
            //Inserting Data
            if (txtEmployeeID.Text == "")
            {
                MySqlConnection conn = connect.connector();
                String query = "INSERT INTO employee(first_name, last_name, middle_name, birth_date, birth_place, contactNo, sex, religion, marital_status, status) " +
                    "VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtMiddleName.Text + "','" + dateBirthDate.Text 
                    + "','" + txtBirthPlace.Text + "','" + txtContactNo.Text + "','" + cmbSex.Text
                    + "','" + txtReligion.Text + "','" + txtMaritalStatus.Text + "','" + cmbStatus.Text + "')";
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
            }
            else
            {
                //Editing Data
                MySqlConnection conn = connect.connector();
                String query = "UPDATE employee SET first_name='" + txtFirstName.Text + "',last_name='" + txtLastName.Text + "',middle_name='" + txtMiddleName.Text + 
                    "',birth_date='" + dateBirthDate.Text + "',birth_place='" + txtBirthPlace.Text + "',contactNo='" + txtContactNo.Text + "',sex='" + cmbSex.Text +
                    "',religion='" + txtReligion.Text + "',marital_status='" + txtMaritalStatus.Text + "',status='" + cmbStatus.Text + 
                    "' WHERE empID='" + txtEmployeeID.Text + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    this.Close();
                    reference.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid");
                }
                this.Close();
                reference.Show();
            }

        }
    }
}
