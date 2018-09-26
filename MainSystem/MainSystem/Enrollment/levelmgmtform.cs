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
using System.Text.RegularExpressions;

namespace MainSystem.Enrollment
{
    public partial class levelmgmtform : Form
    {
        private MySqlConnection dbconnection;
        public EnrollmentConsole reference { get; set; }
        public levelmgmtform()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn cbclm = new DataGridViewCheckBoxColumn();
            cbclm.HeaderText = "Select";
            dataGridView1.Columns.Add(cbclm);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            loadData2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                case "Junior-Highschool":
                    comboBox2.Items.Add("Grade 7");
                    comboBox2.Items.Add("Grade 8");
                    comboBox2.Items.Add("Grade 9");
                    comboBox2.Items.Add("Grade 10");
                    break;
                case "Senior-Highschool":
                    comboBox2.Items.Add("Grade 11");
                    comboBox2.Items.Add("Grade 12");
                    break;
            }

        }
        public List<string> stdlistid;
        private void idlistgrabber()
        {
            stdlistid = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    stdlistid.Add(row.Cells["idstudentprofile"].Value.ToString());
                }

            }
        }
        public void loadData2()
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
                dataGridView1.Columns["school_year"].Visible = true;
                dataGridView1.Columns["idstddet"].Visible = false;
                dataGridView1.Columns["section"].Visible = true;
                dataGridView1.Columns["image_path"].Visible = false;
                dataGridView1.Columns["sectionid"].Visible = false;

                dataGridView1.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dataGridView1.Columns["level_dummyval"].HeaderText = "Level";

            }
            dbconnection.Close();


        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
        public IDictionary<string, string> studdet;
        public void studdetails(string dept, string level)
        {
            studdet = new Dictionary<string, string>();
            switch (dept)
            {
                case "Pre-school":
                    studdet.Add("dept", "1");
                    break;
                case "Grade-school":
                    studdet.Add("dept", "2");
                    break;
                case "Junior-Highschool":
                    studdet.Add("dept", "3");
                    break;
                case "Senior-Highschool":
                    studdet.Add("dept", "4");
                    break;
            }
            switch (level)
            {
                case "Toddler":
                    studdet.Add("level", "11");
                    studdet.Add("feelevel", "1");
                    break;
                case "Nursery":
                    studdet.Add("level", "12");
                    studdet.Add("feelevel", "2");
                    break;
                case "Kinder":
                    studdet.Add("level", "13");
                    studdet.Add("feelevel", "3");
                    break;
                case "Preparatory":
                    studdet.Add("level", "14");
                    studdet.Add("feelevel", "4");
                    break;
                case "Grade 1":
                    studdet.Add("level", "21");
                    studdet.Add("feelevel", "5");
                    break;
                case "Grade 2":
                    studdet.Add("level", "22");
                    studdet.Add("feelevel", "6");
                    break;
                case "Grade 3":
                    studdet.Add("level", "23");
                    studdet.Add("feelevel", "7");
                    break;
                case "Grade 4":
                    studdet.Add("level", "24");
                    studdet.Add("feelevel", "8");
                    break;
                case "Grade 5":
                    studdet.Add("level", "25");
                    studdet.Add("feelevel", "9");
                    break;
                case "Grade 6":
                    studdet.Add("level", "26");
                    studdet.Add("feelevel", "10");
                    break;
                case "Grade 7":
                    studdet.Add("level", "31");
                    studdet.Add("feelevel", "11");
                    break;
                case "Grade 8":
                    studdet.Add("level", "32");
                    studdet.Add("feelevel", "12");
                    break;
                case "Grade 9":
                    studdet.Add("level", "33");
                    studdet.Add("feelevel", "13");
                    break;
                case "Grade 10":
                    studdet.Add("level", "34");
                    studdet.Add("feelevel", "14");
                    break;
                case "Grade 11":
                    studdet.Add("level", "41");
                    studdet.Add("feelevel", "15");
                    break;
                case "Grade 12":
                    studdet.Add("level", "42");
                    studdet.Add("feelevel", "16");
                    break;
            }

        }
        private void updater()
        {
            studdetails(comboBox1.Text, comboBox2.Text);
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                foreach (string id in stdlistid)
                {
                    string query2 = "UPDATE studdetails SET section = @sec, level = @lvl, department = @dept, level_dummyval = @dum, school_year = @sy, sectionid = @sectionid WHERE idstddet = @idstud;";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@sec", null);
                        command2.Parameters.AddWithValue("@lvl", studdet["level"]);
                        command2.Parameters.AddWithValue("@dept", studdet["dept"]);
                        command2.Parameters.AddWithValue("@dum", comboBox2.Text);
                        command2.Parameters.AddWithValue("@sy", comboBox3.Text);
                        command2.Parameters.AddWithValue("@idstud", id);
                        command2.Parameters.AddWithValue("@sectionid", null);
                        command2.ExecuteNonQuery();
                    }
                    string query = "UPDATE accountdetails SET fid = @fid WHERE spid = @idstud;";
                    using (var command = new MySqlCommand(query, dbconnection))
                    {
                        command.Parameters.AddWithValue("@fid", studdet["feelevel"]);
                        command.Parameters.AddWithValue("@idstud", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        private Boolean checkercheckbox()
        {
            var x = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    x = true;
                }
            }
            if (x)
            {
                return true;
            }
            else
            {
                MessageBox.Show("NO STUDENT/S ARE CURRENTLY SELECTED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(checkercheckbox())
            {
                DialogResult res = MessageBox.Show("Selected Student/s Level Details Will Be Altered! Proceed?", "WARNING!", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    idlistgrabber();
                    updater();
                    MessageBox.Show("STUDENT RECORDS HAVE BEEN ALTERED!");
                    loadData2();
                }
                else
                {

                }
            }
           
            
        }

        private void btnbackhome_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Unconfirmed Changes Will Be Lost, Proceed?", "WARNING!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
                reference.loadData();
            }
        }

        private void levelmgmtform_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b,.-]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("The Text Must Can Only Consist Of Alphabets and Numbers, and The Characters: '-,.'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
           string.Format("FirstName LIKE '%{0}%' " +
           "OR LastName LIKE '%{0}%' " +
           "OR MiddleName LIKE '%{0}%' " +
           "OR level_dummyval LIKE '%{0}' " +
           "OR section LIKE '%{0}%'", textBox1.Text);
            dataGridView1.ClearSelection();
        }

        private void sycombosearch_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
