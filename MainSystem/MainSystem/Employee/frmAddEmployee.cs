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
        public MySqlConnection dbconnection;

        public frmAddEmployee()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            fetchID();
            //defaultValue();
            enableButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            //deleteData();
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
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    String query = "INSERT INTO employee(first_name, last_name, middle_name, birth_date, birth_place, contactNo, sex, religion, marital_status, status) VALUES (@fn, @ln, @mn, @bd, @bp, @cn, @sex, @religion, @ms, @status);";
                    using (var cmd = new MySqlCommand(query, dbconnection))
                    {
                        cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@mn", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@bd", dateBirthDate.Text);
                        cmd.Parameters.AddWithValue("@bp", txtBirthPlace.Text);
                        cmd.Parameters.AddWithValue("@cn", txtContactNo.Text);
                        cmd.Parameters.AddWithValue("@sex", cmbSex.Text);
                        if(cmbReligion.Text == "Others")
                        {
                            cmd.Parameters.AddWithValue("@religion", txtSpecify.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@religion", cmbReligion.Text);
                        }
                        cmd.Parameters.AddWithValue("@ms", cmbMaritalStatus.Text);
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Inserted");
                    this.Close();
                    reference.Show();
                    reference.readData();
                    reference.dataSearch.Rows[0].Selected = false;
                }
            }
        }
        private void fetchID()
        {
            //Fetching the last autoincremented ID from database
            MySqlConnection conn = connect.connector();
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) + 1 FROM employee ", conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                txtEmployeeID.Text = data.Tables[0].Rows[0][0].ToString();
            }
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
                   !string.IsNullOrWhiteSpace(cmbReligion.Text) &&
                   !string.IsNullOrWhiteSpace(cmbMaritalStatus.Text) &&
                   !string.IsNullOrWhiteSpace(txtStatus.Text);
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

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbReligion_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
            if(cmbReligion.Text == "Others")
            {
                txtSpecify.Enabled = true;
            }
            else
            {
                txtSpecify.Enabled = false;
            }
        }

        private void cmbMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            //For enabling 
            enableButton();
        }
    }
}
