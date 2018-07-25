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
    public partial class frmEditAccount : Form
    {
        public frmAccount reference { get; set; }
        public frmEditAccount()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            readData();
            Date();
            fetchStudentAccountID();    
        }

        private void readData()
        {
            //For Reading the Data
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studentprofile";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
                dataSearch.Columns["DateOfBirth"].Visible = false;
                dataSearch.Columns["PlaceOfBirth"].Visible = false;
                dataSearch.Columns["Sex"].Visible = false;
                dataSearch.Columns["Religion"].Visible = false;
                dataSearch.Columns["Nickname"].Visible = false;
            }
        }
    
        private void fetchStudentAccountID()
        {
            //Fetching the last autoincremented ID from database
            MySqlConnection conn = connect.connector();
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) + 1 FROM studentaccount ", conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                txtStudentAccountID.Text = data.Tables[0].Rows[0][0].ToString();
            }
            conn.Close();
        }

        private void Date()
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void dataSearch_MouseClick(object sender, MouseEventArgs e)
        {
            //For when clicking cells textbox are autofilled
            if (dataSearch.Rows.Count > 0)
            {
                txtStudentID.Text = dataSearch.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentName.Text = dataSearch.SelectedRows[0].Cells[1].Value.ToString() + " " + dataSearch.SelectedRows[0].Cells[3].Value.ToString() + " " + dataSearch.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //When typing first name data grid automatically search that student
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                string query = ("SELECT idstudentprofile, FirstName, LastName, MiddleName FROM studentprofile WHERE idstudentprofile LIKE '" + txtSearch.Text + "%'");
                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        

        private void insertData()
        {
            
                using (MySqlConnection conn = connect.connector())
                {
                    String query = "INSERT INTO studentaccount() VALUES ()";
                    String query2 = "UPDATE studentaccount SET studentid='" + txtStudentID.Text + "' WHERE idsa='" + txtStudentAccountID.Text + "'";
                String query3 = "INSERT INTO studentaccount(date_creation) VALUES('" + dateDateCreated.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
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
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
        }
    }
}
