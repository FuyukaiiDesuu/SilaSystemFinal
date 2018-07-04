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
        public addStudent()
        {
            InitializeComponent();
        }
        //private dbConnector dbconnect = new dbConnector();
        public MySqlConnection dbconnection;
        private void addStudent_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void createfunction()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                //connection.Open();
                using (var command = new MySqlCommand("INSERT INTO studentprofile VALUES(DEFAULT, @FirstName, @LastName, @MiddleName, @DateOfBirth, @PlaceOfBirth, @Sex, @Religion, @Nickname)", dbconnection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtfn.Text);
                    command.Parameters.AddWithValue("@LastName", txtln.Text);
                    command.Parameters.AddWithValue("@MiddleName", txtmn.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@PlaceOfBirth", txtbp.Text);
                    command.Parameters.AddWithValue("@Sex", txtsex.Text);
                    command.Parameters.AddWithValue("@Religion", txtrel.Text);
                    command.Parameters.AddWithValue("@Nickname", txtnn.Text);

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
            this.Close();
        }
    }
}
