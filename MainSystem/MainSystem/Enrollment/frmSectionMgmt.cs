﻿using System;
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
    public partial class frmSectionMgmt : Form
    {
        public EnrollmentConsole reference { get; set; }
        private MySqlConnection dbconnection;
        public frmSectionMgmt()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn cbclm = new DataGridViewCheckBoxColumn();
            cbclm.HeaderText = "Select";
            dataGridView1.Columns.Add(cbclm);
            loadData();
            
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
                dataGridView1.Columns["level"].Visible = true;
                dataGridView1.Columns["school_year"].Visible = false;
                dataGridView1.Columns["idstddet"].Visible = false;
                dataGridView1.Columns["section"].Visible = true;

                dataGridView1.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";

            }
            dbconnection.Close();


        }
        private void frmSectionMgmt_Load(object sender, EventArgs e)
        {

        }
        public List<string> stdlistid;
        private void idlistgrabber()
        {
            stdlistid = new List<string>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(Convert.ToBoolean(row.Cells[0].Value))
                {
                    stdlistid.Add(row.Cells["idstudentprofile"].Value.ToString());
                }
                
            }
        }
        public sectioninput secinput;
        public string sectionname;
        private void button5_Click(object sender, EventArgs e)
        {
            secinput = new sectioninput();
            if (secinput.ShowDialog() == DialogResult.OK)
            {
                sectionname = secinput.sectioninputt;
            }
            idlistgrabber();
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                foreach (string id in stdlistid)
                {
                    string query2 = "UPDATE studdetails SET section = @sec WHERE idstddet = @idstud;";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@sec", sectionname);
                        command2.Parameters.AddWithValue("@idstud", id);
                        command2.ExecuteNonQuery();
                    }
                }
            }
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idlistgrabber();
            foreach(string id in stdlistid)
            {
                Console.WriteLine(id);
            }
        }
    }
}
