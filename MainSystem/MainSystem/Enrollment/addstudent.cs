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
                string query = "INSERT INTO studentprofile VALUES();";
                using (var command = new MySqlCommand(query, dbconnection))
                {
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
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname WHERE idstudentprofile = @ayd;", dbconnection))
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
    }
}
