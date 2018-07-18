using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class addStudent : Form
    {

        public EnrollmentConsole reference { get; set; }
        public string studid;
        public addStudent(string id)
        {
            InitializeComponent();
            studid = id;
        }

        //private dbConnector dbconnect = new dbConnector();
        public MySqlConnection dbconnection;
        private void addStudent_Load(object sender, EventArgs e)
        {
            createdefault();
            txtstno.Text = studid;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
        private void createdefault()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query = "INSERT INTO studentprofile(idstuddet) VALUES(@ayd);";
                string query2 = "INSERT INTO studdetails VALUES();";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.ExecuteNonQuery();
                }

                using (var command = new MySqlCommand(query, dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void createfunction()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname, Status = @stat, idstuddet = @ayd2  WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.Parameters.AddWithValue("@fn", txtfn.Text);
                    command.Parameters.AddWithValue("@ln", txtln.Text);
                    command.Parameters.AddWithValue("@mn", txtmn.Text);
                    command.Parameters.AddWithValue("@dof", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pof", txtbp.Text);
                    command.Parameters.AddWithValue("@sex", txtsex.Text);
                    command.Parameters.AddWithValue("@rel", txtrel.Text);
                    command.Parameters.AddWithValue("@nickname", txtnn.Text);
                    command.Parameters.AddWithValue("@stat", 1);
                    command.Parameters.AddWithValue("@ayd2", studid);

                    command.ExecuteNonQuery();
                }
            }



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            createfunction();
            MessageBox.Show("Record Created Successfully!");
            //connection.Close();
            reference.Show();
            reference.loadData();
            dbconnection.Close();
            this.Close();
        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("DELETE from studentprofile WHERE idstudentprofile = @ayd", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.ExecuteNonQuery();
                }
                using (var command2 = new MySqlCommand("DELETE from studdetails WHERE idstddet = @ayd", dbconnection))
                {
                    command2.Parameters.AddWithValue("@ayd", studid);
                    command2.ExecuteNonQuery();
                }
                
            }
            this.Close();
            dbconnection.Clone();
            
        }
        private void altertable()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                int a = int.Parse(studid);
                dbconnection.Open();
                using (var command = new MySqlCommand("alter table studentprofile auto_increment = @count", dbconnection))
                {
                    command.Parameters.AddWithValue("@count", a);
                    command.ExecuteNonQuery();
                }
                using (var command2 = new MySqlCommand("alter table studdetails auto_increment = @count", dbconnection))
                {
                    command2.Parameters.AddWithValue("@count", a);
                    command2.ExecuteNonQuery();
                }

            }
            this.Close();
        }
    }
}
