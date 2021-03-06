﻿using System;
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
        public string syear { get; set; }
        //private dbConnector dbconnect = new dbConnector();
        private MySqlConnection dbconnection;
        public string stid;

        public EnrollmentConsole(string uname)
        {
            InitializeComponent();
            label8.Text = uname;
            //btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = true;
            timer1.Enabled = true;
            //label11.Text = counterr().ToString();
            
        }
        private void EnrollmentConsole_Load(object sender, EventArgs e)
        {
            loadData();
            lblsy.Text = syear;
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ClearSelection();
        }
        public void loadData()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstuddet = studdetails.idstddet WHERE studentprofile.Status = 1;";
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
                dataGridView1.Columns["section"].Visible = true;
                dataGridView1.Columns["image_path"].Visible = false;
                dataGridView1.Columns["sectionid"].Visible = false;


                dataGridView1.Columns["level_dummyval"].HeaderText = "Student Level";
                dataGridView1.Columns["section"].HeaderText = "Student Section";
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
            //label11.Text = stid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO GO BACK TO THE DASHBOARD?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                reference.Show();
                dbconnection.Close();
                this.Dispose();
            }
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
                    studdet.Add("dept", "Junior-Highschool");
                    break;
                case "4":
                    studdet.Add("dept", "Senior-Highschool");
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
                case "41":
                    studdet.Add("level", "Grade 11");
                    break;
                case "42":
                    studdet.Add("level", "Grade 12");
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
        public string status;
        public string imgpath;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studid2 = dataGridView1.Rows[e.RowIndex].Cells["idstudentprofile"].Value.ToString();
                txtfn.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtln.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtmi.Text = dataGridView1.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
                DateTime dt = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString());
                txtbd.Text = dt.ToString("yyyy-MM-dd");
                //txtbd.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
                //txtbd.Text = dt.ToString();
                txtbp.Text = dataGridView1.Rows[e.RowIndex].Cells["PlaceOfBirth"].Value.ToString();
                txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Sex"].Value.ToString();
                txtrel.Text = dataGridView1.Rows[e.RowIndex].Cells["Religion"].Value.ToString();
                //txtrel.Text = dataGridView1.Rows[e.RowIndex].Cells["Religion"].Value.ToString();
                txtnn.Text = dataGridView1.Rows[e.RowIndex].Cells["Nickname"].Value.ToString();
                imgpath = dataGridView1.Rows[e.RowIndex].Cells["image_path"].Value.ToString();
                IDictionary<string, string> dic = studdetails(dataGridView1.Rows[e.RowIndex].Cells["department"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["level"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                txtdep.Text = dic["dept"];
                txtlev.Text = dic["level"];
                txtsy.Text = dataGridView1.Rows[e.RowIndex].Cells["school_year"].Value.ToString();
                txtstatus.Text = dic["status"];
                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells["image_path"].Value.ToString();
                btnEnable();
            }
            catch(Exception ee)
            {
                var temp = ee;
                textboxClear();
            }
           


        }
        private void btnDisable()
        {
            //btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            //btnView.Enabled = false;
        }
        private void btnEnable()
        {
            //btnCreate.Enabled = true;
            btnUpdate.Enabled = true;
            btnView.Enabled = true;
        }
        public void textboxClear()
        {
            txtfn.Clear();
            txtln.Clear();
            txtmi.Clear();
            txtbd.Clear();
            txtbp.Clear();
            txtsex.Clear();
            txtrel.Clear();
            txtnn.Clear();
            txtdep.Clear();
            txtlev.Clear();
            txtstatus.Clear();
            txtsy.Clear();
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
            dict.Add("dept", txtdep.Text);
            dict.Add("lvl", txtlev.Text);
            dict.Add("stat", status);
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
        private Int32 counterr()
        {
            var dbconnect = new dbConnector();
            string query = "SELECT COUNT(idstddet) FROM studdetails;";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                var cmd = new MySqlCommand(query, dbconnection);
                return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
               
            }

            
        }
        string sprofid;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            addstudentform = new addStudent(counterr().ToString());
            addstudentform.syear = lblsy.Text;
            addstudentform.Show();
            addstudentform.reference = this;
        }
        public editStudent esform;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                esform = new editStudent(studid2, injector(), imgpath);
                esform.syear = lblsy.Text;
                esform.Show();
                esform.reference = this;
            }
            else
            {
                MessageBox.Show("There Are No Students Currently Selected!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void label15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this application?", "S.I.L.A Enrollment and Accounting System", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("MMMM-dd-yyyy hh:mm:ss ");
            timer1.Start();
        }

        private void btnUpdate_EnabledChanged(object sender, EventArgs e)
        {

        }
        public frmSectionMgmt fsm;
        private void btnsmgmt_Click(object sender, EventArgs e)
        {
            fsm = new frmSectionMgmt();
            fsm.reference = this;
            fsm.Show();
            
        }
        public Enrollment.levelmgmtform lform;
        private void button2_Click(object sender, EventArgs e)
        {
            lform = new Enrollment.levelmgmtform();
            lform.reference = this;
            lform.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void EnrollmentConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
          string.Format("FirstName LIKE '%{0}%' " +
          "OR LastName LIKE '%{0}%' " +
          "OR MiddleName LIKE '%{0}%' " +
          "OR level_dummyval LIKE '%{0}' " +
          "OR section LIKE '%{0}%'", search.Text);
            dataGridView1.ClearSelection();
        }
    }
}
