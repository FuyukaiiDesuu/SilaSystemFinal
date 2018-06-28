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
    public partial class EnrollmentConsole : Form
    {
        
        public frmMain reference { get; set; }
        public MySqlConnection dbconnect;
        public EnrollmentConsole()
        {
            InitializeComponent();
            loadData();
            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EnrollmentConsole_Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            dbconnect = new MySqlConnection("Server=localhost;Database=silasystemdb;Uid=root;Pwd=root;");
            dbconnect.Open();
            string query = "SELECT * from studentprofile";
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(query, dbconnect);
                DataSet data = new DataSet();
                ad.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Columns["idSP"].Visible = true;
                dataGridView1.Columns["PlaceOfBirth"].Visible = false;
                dataGridView1.Columns["DateOfBirth"].Visible = false;
                dataGridView1.Columns["Sex"].Visible = false;
                dataGridView1.Columns["Religion"].Visible = false;
                dataGridView1.Columns["Nickname"].Visible = true;

                dataGridView1.Columns["idSP"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";




            }
            catch(Exception ee)
            {
                MessageBox.Show("ERROR" + ee);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfn.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            txtln.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtmi.Text = dataGridView1.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
            txtbd.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
            txtbp.Text = dataGridView1.Rows[e.RowIndex].Cells["PlaceOfBirth"].Value.ToString();
            txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Sex"].Value.ToString();
            txtrel.Text = dataGridView1.Rows[e.RowIndex].Cells["Religion"].Value.ToString();
            txtnn.Text = dataGridView1.Rows[e.RowIndex].Cells["Nickname"].Value.ToString();
                btnEnable();


        }
        private void btnDisable()
        {
            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = false;
        }
        private void btnEnable()
        {
            btnCreate.Enabled = true;
            btnUpdate.Enabled = true;
            btnView.Enabled = true;
        }
        private void textboxClear()
        {
            txtfn.Clear();
            txtln.Clear();
            txtmi.Clear();
            txtbd.Clear();
            txtbp.Clear();
            txtsex.Clear();
            txtrel.Clear();
            txtnn.Clear();
        }

        private void txtfn_TextChanged(object sender, EventArgs e)
        {
            

        }
        

        private void EnrollmentConsole_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
                textboxClear();
                    btnDisable();
           
        }
      
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
