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
    public partial class addStudent : Form
    {

        public EnrollmentConsole reference { get; set; }
        public string studid;
        public addStudent(int id)
        {
            InitializeComponent();
            studid = (id + 1).ToString();
        }

        //private dbConnector dbconnect = new dbConnector();
        public MySqlConnection dbconnection;
        private void addStudent_Load(object sender, EventArgs e)
        {
            createdefault();
            gboxEnabler();
            txtstno.Text = studid;
            txtrel.Enabled = false;
            //ph.Text = sygetter();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }
        private void createdefault()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query = "INSERT INTO studentprofile(idstuddet) VALUES(@ayd);";
                string query2 = "INSERT INTO studdetails VALUES();";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.ExecuteNonQuery();
                }

                using (var command = new MySqlCommand(query, dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
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
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname, Status = @stat, idstuddet = @ayd2  WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.Parameters.AddWithValue("@fn", txtfn.Text);
                    command.Parameters.AddWithValue("@ln", txtln.Text);
                    command.Parameters.AddWithValue("@mn", txtmn.Text);
                    command.Parameters.AddWithValue("@dof", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pof", txtbp.Text);
                    command.Parameters.AddWithValue("@sex", comboBox3.Text);
                    if(comboBox4.Text == "Others")
                    {
                        command.Parameters.AddWithValue("@rel", txtrel.Text);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@rel", comboBox4.Text);
                    }
                    command.Parameters.AddWithValue("@nickname", txtnn.Text);
                    command.Parameters.AddWithValue("@stat", 1);
                    command.Parameters.AddWithValue("@ayd2", studid);

                    command.ExecuteNonQuery();
                }
                using (var command = new MySqlCommand("UPDATE studdetails set department = @dpt, level = @lvl, school_year = @sy where idstddet = @aydd;", dbconnection))
                {
                    IDictionary<string, string> dic = comboboxpicker();
                    command.Parameters.AddWithValue("@dpt", dic["dept"]);
                    command.Parameters.AddWithValue("@lvl", dic["level"]);
                    Int32 temp = Convert.ToInt32(sygetter().ToString()) + 1;
                    command.Parameters.AddWithValue("@sy", sygetter().ToString() + "-" + temp.ToString());
                    command.Parameters.AddWithValue("@aydd", studid);
                    command.ExecuteNonQuery();
                }
            }




        }
        
        private string sygetter()
        {
            return DateTime.Now.Year.ToString();
            
        }
        private IDictionary<string, string> comboboxpicker()
        {
            IDictionary<string, string> d1 = new Dictionary<string, string>();
            switch(comboBox2.Text)
            {
                case "Toddler":
                    d1.Add("level", "11");
                    break;
                case "Nursery":
                    d1.Add("level", "12");
                    break;
                case "Kinder":
                    d1.Add("level", "13");
                    break;
                case "Preparatory":
                    d1.Add("level", "14");
                    break;
                case "Grade 1":
                    d1.Add("level", "21");
                    break;
                case "Grade 2":
                    d1.Add("level", "22");
                    break;
                case "Grade 3":
                    d1.Add("level", "23");
                    break;
                case "Grade 4":
                    d1.Add("level", "24");
                    break;
                case "Grade 5":
                    d1.Add("level", "25");
                    break;
                case "Grade 6":
                    d1.Add("level", "26");
                    break;
                case "Grade 7":
                    d1.Add("level", "31");
                    break;
                case "Grade 8":
                    d1.Add("level", "32");
                    break;
                case "Grade 9":
                    d1.Add("level", "33");
                    break;
                case "Grade 10":
                    d1.Add("level", "34");
                    break;
            }
            switch(comboBox1.Text)
            {
                case "Pre-school":
                    d1.Add("dept", "1");
                    break;
                case "Grade-school":
                    d1.Add("dept", "2");
                    break;
                case "High-school":
                    d1.Add("dept", "3");
                    break;
            }
            return d1;

        }
        private void gboxEnabler()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }
        private void gboxDisabler()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            createfunction();
            MessageBox.Show("Record Created Successfully!");
            //connection.Close();
            btnSave.Enabled = false;
            //gboxDisabler();
            reference.loadData();
            reference.Show();
            this.Close();
        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("DELETE from studentprofile WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.ExecuteNonQuery();
                }
                using (var command2 = new MySqlCommand("DELETE from studdetails WHERE idstddet = @ayd;", dbconnection))
                {
                    command2.Parameters.AddWithValue("@ayd", studid);
                    command2.ExecuteNonQuery();
                }
                
            }
            
            altertable();
            this.Close();
            reference.Show();
            reference.loadData();
            dbconnection.Close();
            
        }
        private void altertable()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                //int a = int.Parse(studid);
                dbconnection.Open();
                using (var command = new MySqlCommand("alter table studentprofile auto_increment ="+studid+";", dbconnection))
                {
                    //command.Parameters.AddWithValue("@count", studid);
                    command.ExecuteNonQuery();
                }
                using (var command2 = new MySqlCommand("alter table studdetails auto_increment = "+studid+";", dbconnection))
                {
                    //command2.Parameters.AddWithValue("@count", studid);
                    command2.ExecuteNonQuery();
                }

            }
           
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox4.Text == "Others")
            {
                txtrel.Enabled = true;
            }
            else
            {
                txtrel.Enabled = false;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.Text)
            {
               case "Pre-school":
                    comboBox2.Items.Add("Nursery");
                    comboBox2.Items.Add("Kinder");
                    comboBox2.Items.Add("Preparatory");
                    break;
                case "Grade-school":
                    comboBox2.Items.Add("Grade 1");
                    comboBox2.Items.Add("Grade 2");
                    comboBox2.Items.Add("Grade 3");
                    comboBox2.Items.Add("Grade 4");
                    comboBox2.Items.Add("Grade 5");
                    comboBox2.Items.Add("Grade 6");
                    break;
                case "High-school":
                    comboBox2.Items.Add("Grade 7");
                    comboBox2.Items.Add("Grade 8");
                    comboBox2.Items.Add("Grade 9");
                    comboBox2.Items.Add("Grade 10");
                    break;
            }
 
                    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}