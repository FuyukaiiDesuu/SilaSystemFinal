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
            loaddata1();
            loaddata2();
            btnEnabler();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

        }
        public void btnEnabler()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
        public MySqlConnection dbconnection;
        private void loaddata1()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstudentprofile = studdetails.idstddet where studentprofile.Status = 1;";
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
                dataGridView1.Columns["idstddet"].Visible = false;
                dataGridView1.Columns["image_path"].Visible = false;
                dataGridView1.Columns["level_dummyval"].Visible = false;
                dataGridView1.Columns["sectionid"].Visible = false;

                dataGridView1.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Date of Birth";


            }
            //dbconnection.Close();

        }
        private void loaddata2()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstudentprofile = studdetails.idstddet WHERE studentprofile.Status = 0;";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(query, dbconnection);
                DataSet data = new DataSet();
                ad.Fill(data);
                dataGridView2.DataSource = data.Tables[0];

                dataGridView2.Columns["idstudentprofile"].Visible = true;
                dataGridView2.Columns["FirstName"].Visible = true;
                dataGridView2.Columns["LastName"].Visible = true;
                dataGridView2.Columns["MiddleName"].Visible = true;
                dataGridView2.Columns["PlaceOfBirth"].Visible = false;
                dataGridView2.Columns["Sex"].Visible = true;
                dataGridView2.Columns["Religion"].Visible = false;
                dataGridView2.Columns["Nickname"].Visible = false;
                dataGridView2.Columns["idstuddet"].Visible = false;
                dataGridView2.Columns["Status"].Visible = false;
                dataGridView2.Columns["department"].Visible = false;
                dataGridView2.Columns["level"].Visible = false;
                dataGridView2.Columns["school_year"].Visible = false;
                dataGridView2.Columns["idstddet"].Visible = false;
                dataGridView2.Columns["image_path"].Visible = false;
                dataGridView2.Columns["level_dummyval"].Visible = false;
                dataGridView2.Columns["sectionid"].Visible = false;

                dataGridView2.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView2.Columns["FirstName"].HeaderText = "First Name";
                dataGridView2.Columns["LastName"].HeaderText = "Last Name";
                dataGridView2.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridView2.Columns["DateOfBirth"].HeaderText = "Date of Birth";


            }
            //dbconnection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string chkstatus(string stat)
        {
            switch(stat)
            {
                case "1":
                    return "ACTIVE!";
                case "0":
                    return "DEACTIVATED!";
            }
            return "";
            
        }
        private void buttonEnable(string stat)
        {
            switch(stat)
            {
                case "0":
                   button1.Enabled = true;
                    break;
                case "1":
                    button2.Enabled = true;
                    break;
            }
            
        }
        string ayd;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ayd = dataGridView1.Rows[e.RowIndex].Cells["idstudentprofile"].Value.ToString();
                txtstatus.Text = chkstatus(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                buttonEnable(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                dataGridView2.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("UPDATE studentprofile set Status = @stat WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@stat", 0);
                    command.Parameters.AddWithValue("@ayd", ayd);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("STUDENT DEACTIVATED!");
            txtstatus.Clear();
            loaddata1();
            loaddata2();
            btnEnabler();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
            reference.loadData();
            dbconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("UPDATE studentprofile set Status = @stat WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@stat", 1);
                    command.Parameters.AddWithValue("@ayd", ayd);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("STUDENT ACTIVATED!");
            txtstatus.Clear();
            loaddata1();
            loaddata2();
            btnEnabler();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ayd = dataGridView2.Rows[e.RowIndex].Cells["idstudentprofile"].Value.ToString();
                txtstatus.Text = chkstatus(dataGridView2.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                buttonEnable(dataGridView2.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                dataGridView1.ClearSelection();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
