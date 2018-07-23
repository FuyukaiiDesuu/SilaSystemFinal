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
    public partial class viewForm : Form
    {
        public EnrollmentConsole reference { get; set; }
        public viewForm()
        {
            InitializeComponent();
        }

        private void viewForm_Load(object sender, EventArgs e)
        {

        }
        public MySqlConnection dbconnection;
        private void loaddata()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstudentprofile = studdetails.idstddet;";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(query, dbconnection);
                DataSet data = new DataSet();
                ad.Fill(data);
                dataGridView1.DataSource = data.Tables[0];

                dataGridView1.Columns["idstudentprofile"].Visible = true;
                dataGridView1.Columns["FirstName"].Visible = true;
                dataGridView1.Columns["LastName"].Visible = true;
                dataGridView1.Columns["MiddleName"].Visible = true;
                dataGridView1.Columns["DateOfBirth"].Visible = true;
                dataGridView1.Columns["PlaceOfBirth"].Visible = false;
                dataGridView1.Columns["Sex"].Visible = true;
                dataGridView1.Columns["Religion"].Visible = false;
                dataGridView1.Columns["Nickname"].Visible = false;
                dataGridView1.Columns["idstuddet"].Visible = false;
                dataGridView1.Columns["Status"].Visible = false;
                dataGridView1.Columns["department"].Visible = false;
                dataGridView1.Columns["level"].Visible = false;
                dataGridView1.Columns["school_year"].Visible = false;

                dataGridView1.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";


            }
            dbconnection.Close();

        }
    }
}
