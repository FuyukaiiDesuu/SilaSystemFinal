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
    public partial class frmEditEmployee : Form
    {
        public frmEmployee reference { get; set; }
        public frmEditEmployee()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        private void frmEditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
            reference.dataSearch.Rows[0].Selected = false;
            reference.clearText();
        }

        private void editData()
        {
            //Editing Data
            MySqlConnection conn = connect.connector();
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
                "' WHERE empID='" + txtEmployeeID.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
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
            reference.dataSearch.Rows[0].Selected = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editData();
            reference.clearText();
        }
    }
}
