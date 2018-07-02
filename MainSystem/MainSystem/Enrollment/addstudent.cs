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
        public MySqlConnection connection;
        private void addStudent_Load(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (connection = dbconnect.connector())
            {
                connection.Open(); 
                using (var command = new MySqlCommand("INSERT INTO studentprofile VALUES(null, @FirstName, @LastName, @MiddleName, @DateOfBirth, @PlaceOfBirth, @Sex, @Religion, @Nickname)", connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtfn.Text);
                    command.Parameters.AddWithValue("@LastName", txtln.Text);
                    command.Parameters.AddWithValue("@MiddleName", txtmn.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", txtbd.Text);
                    command.Parameters.AddWithValue("@PlaceOfBirth", txtbp.Text);
                    command.Parameters.AddWithValue("@Sex", txtsex.Text);
                    command.Parameters.AddWithValue("@Religion", txtrel.Text);
                    command.Parameters.AddWithValue("@Nickname", txtnn.Text);

                    command.ExecuteNonQuery();

                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            connection.Close();
        }
    }
}
