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
        //private dbConnector dbconnect = new dbConnector();
        private MySqlConnection dbconnection;
        public string stid;
        
        public EnrollmentConsole()
        {
            InitializeComponent();
            
            //btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = true;
            //label11.Text = counterr().ToString();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void EnrollmentConsole_Load(object sender, EventArgs e)
        {
            loadData();
            dataGridView1.ClearSelection();
        }
        public void loadData()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstudentprofile = studdetails.idstddet WHERE studentprofile.Status = 1;";
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

                dataGridView1.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
               

            }
            dbconnection.Close();
            

        }
        private void fetchID()
        {
            var count = dataGridView1.Rows.Count - 2;
            stid = dataGridView1.Rows[count].Cells[0].Value.ToString();
            label11.Text = stid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            dbconnection.Close();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        public string studid2;

        public IDictionary<string, string> studdetails(string dept, string level, string status)
        {
            IDictionary<string, string> studdet = new Dictionary<string, string>();
            switch(dept)
            {
                case "1":
                    studdet.Add("dept", "Pre-school");
                    break;
                case "2":
                    studdet.Add("dept", "Grade-school");
                    break;
                case "3":
                    studdet.Add("dept", "High-school");
                    break;
            }
            switch (level)
            {
                case "11":
                    studdet.Add("level", "Toddler");
                    break;
                case "12":
                    studdet.Add("level", "Nursery");
                    break;
                case "13":
                    studdet.Add("level", "Kinder");
                    break;
                case "14":
                    studdet.Add("level", "Preparatory");
                    break;
                case "21":
                    studdet.Add("level", "Grade 1");
                    break;
                case "22":
                    studdet.Add("level", "Grade 2");
                    break;
                case "23":
                    studdet.Add("level", "Grade 3");
                    break;
                case "24":
                    studdet.Add("level", "Grade 4");
                    break;
                case "25":
                    studdet.Add("level", "Grade 5");
                    break;
                case "26":
                    studdet.Add("level", "Grade 6");
                    break;
                case "31":
                    studdet.Add("level", "Grade 7");
                    break;
                case "32":
                    studdet.Add("level", "Grade 8");
                    break;
                case "33":
                    studdet.Add("level", "Grade 9");
                    break;
                case "34":
                    studdet.Add("level", "Grade 10");
                    break;
            }
            switch(status)
            {
                case "1":
                    studdet.Add("status", "ACTIVE!");
                    break;
                case "0":
                    studdet.Add("status", "INACTIVE!");
                    break;
            }
            
            return studdet;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            studid2 = dataGridView1.Rows[e.RowIndex].Cells["idstudentprofile"].Value.ToString();
            txtfn.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            txtln.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtmi.Text = dataGridView1.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
            DateTime dt = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString());
            txtbd.Text = dt.ToString("yyyy-MM-dd");
            //txtbd.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
            //txtbd.Text = dt.ToString();
            txtbp.Text = dataGridView1.Rows[e.RowIndex].Cells["PlaceOfBirth"].Value.ToString();
            txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Sex"].Value.ToString();
            txtrel.Text = dataGridView1.Rows[e.RowIndex].Cells["Religion"].Value.ToString();
            txtnn.Text = dataGridView1.Rows[e.RowIndex].Cells["Nickname"].Value.ToString();
            IDictionary<string, string> dic = studdetails(dataGridView1.Rows[e.RowIndex].Cells["department"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["level"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString());
            txtdep.Text = dic["dept"];
            txtlev.Text = dic["level"];
            txtsy.Text = dataGridView1.Rows[e.RowIndex].Cells["school_year"].Value.ToString();
            txtstatus.Text = dic["status"];
            btnEnable();


        }
        private void btnDisable()
        {
            //btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = false;
        }
        private void btnEnable()
        {
            //btnCreate.Enabled = true;
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
        
        public IDictionary<string, string> injector()
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("stno", studid2.ToString());
            dict.Add("fn", txtfn.Text);
            dict.Add("ln", txtln.Text);
            dict.Add("mn", txtmi.Text);
            dict.Add("bd", txtbd.Text);
            dict.Add("bp", txtbp.Text);
            dict.Add("sex", txtsex.Text);
            dict.Add("rel", txtrel.Text);
            dict.Add("nn", txtnn.Text);
            return dict;
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
        public addStudent addstudentform;
        private int counterr()
        {
            var dbconnect = new dbConnector();
            string query = "SELECT COUNT(idstudentprofile) FROM studentprofile;";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                var cmd = new MySqlCommand(query, dbconnection);
                return (int)Convert.ToInt32(cmd.ExecuteScalar());
               
            }

            
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            addstudentform = new addStudent(counterr());
            addstudentform.Show();
            addstudentform.reference = this;
            this.Hide();
            
        }
        public editStudent esform;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            esform = new editStudent(studid2, injector());
            esform.Show();
            esform.reference = this;
            //this.Hide();
        }
        public viewForm vf;
        private void btnView_Click(object sender, EventArgs e)
        {
            vf = new viewForm();
            vf.Show();
            vf.reference = this;
            this.Hide();

        }
    }
}
