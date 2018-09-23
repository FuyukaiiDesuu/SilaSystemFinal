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
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public EnrollmentConsole reference { get; set; }
        public string syear { get; set; }
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
            lblsy.Text = syear;
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
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname, image_path = @ipath, Status = @stat, idstuddet = @ayd2  WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", studid);
                    command.Parameters.AddWithValue("@fn", txtfn.Text);
                    command.Parameters.AddWithValue("@ln", txtln.Text);
                    command.Parameters.AddWithValue("@mn", txtmn.Text);
                    command.Parameters.AddWithValue("@dof", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pof", txtbp.Text);
                    command.Parameters.AddWithValue("@sex", comboBox3.Text);
                    if (comboBox4.Text == "Others")
                    {
                        command.Parameters.AddWithValue("@rel", txtrel.Text);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@rel", comboBox4.Text);
                    }
                    command.Parameters.AddWithValue("@nickname", txtnn.Text);
                    command.Parameters.AddWithValue("@ipath", imgpath);
                    command.Parameters.AddWithValue("@stat", 1);
                    command.Parameters.AddWithValue("@ayd2", studid);

                    command.ExecuteNonQuery();
                }
                IDictionary<string, string> dic = comboboxpicker();
                using (var command = new MySqlCommand("UPDATE studdetails set level_dummyval = @lvldval, department = @dpt, level = @lvl, school_year = @sy where idstddet = @aydd;", dbconnection))
                {

                    command.Parameters.AddWithValue("@dpt", dic["dept"]);
                    command.Parameters.AddWithValue("@lvl", dic["level"]);
                    Int32 temp = Convert.ToInt32(sygetter().ToString()) + 1;
                    command.Parameters.AddWithValue("@sy", lblsy.Text);
                    command.Parameters.AddWithValue("@aydd", studid);
                    command.Parameters.AddWithValue("@lvldval", comboBox2.Text);
                    command.ExecuteNonQuery();
                }

                string query3 = "INSERT INTO accountdetails(paid_amount, spid, fid) VALUES(@paid_amount, @spid, @fid);";
                using (var command3 = new MySqlCommand(query3, dbconnection))
                {
                    command3.Parameters.AddWithValue("@paid_amount", 0);
                    command3.Parameters.AddWithValue("@spid", studid);
                    command3.Parameters.AddWithValue("@fid", dic["feelevel"]);
                    command3.ExecuteNonQuery();
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
            switch (comboBox2.Text)
            {
                case "Toddler":
                    d1.Add("level", "11");
                    d1.Add("feelevel", "1");
                    break;
                case "Nursery":
                    d1.Add("level", "12");
                    d1.Add("feelevel", "2");
                    break;
                case "Kinder":
                    d1.Add("level", "13");
                    d1.Add("feelevel", "3");
                    break;
                case "Preparatory":
                    d1.Add("level", "14");
                    d1.Add("feelevel", "4");
                    break;
                case "Grade 1":
                    d1.Add("level", "21");
                    d1.Add("feelevel", "5");
                    break;
                case "Grade 2":
                    d1.Add("level", "22");
                    d1.Add("feelevel", "6");
                    break;
                case "Grade 3":
                    d1.Add("level", "23");
                    d1.Add("feelevel", "7");
                    break;
                case "Grade 4":
                    d1.Add("level", "24");
                    d1.Add("feelevel", "8");
                    break;
                case "Grade 5":
                    d1.Add("level", "25");
                    d1.Add("feelevel", "9");
                    break;
                case "Grade 6":
                    d1.Add("level", "26");
                    d1.Add("feelevel", "10");
                    break;
                case "Grade 7":
                    d1.Add("level", "31");
                    d1.Add("feelevel", "11");
                    break;
                case "Grade 8":
                    d1.Add("level", "32");
                    d1.Add("feelevel", "12");
                    break;
                case "Grade 9":
                    d1.Add("level", "33");
                    d1.Add("feelevel", "13");
                    break;
                case "Grade 10":
                    d1.Add("level", "34");
                    d1.Add("feelevel", "14");
                    break;
                case "Grade 11":
                    d1.Add("level", "41");
                    d1.Add("feelevel", "15");
                    break;
                case "Grade 12":
                    d1.Add("level", "42");
                    d1.Add("feelevel", "16");
                    break;
            }
            switch (comboBox1.Text)
            {
                case "Pre-school":
                    d1.Add("dept", "1");
                    break;
                case "Grade-school":
                    d1.Add("dept", "2");
                    break;
                case "Junior-Highschool":
                    d1.Add("dept", "3");
                    break;
                case "Senior-Highschool":
                    d1.Add("dept", "4");
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
        private Boolean doublenamecheck(string fn , string ln, string mn)
        {
            var connect = new dbConnector();
            using (MySqlConnection conn = connect.connector())
            {

                string query = "";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   

                }
            }
            return false;
        }
        private Boolean textboxvalidate()
        {
            if(txtfn.Text == "" || txtln.Text == "" || txtmn.Text == "" || txtbp.Text == "" || txtnn.Text == "" || dateTimePicker1.Value.ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd") || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("PLEASE FILL OUT ALL TEXT FEILDS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            else
            {
                return true;
            }
        }
        private Boolean studentcheck(string fn, string ln, string mn)
        {
            var connect = new dbConnector();
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studentprofile WHERE FirstName = '" + fn + "' AND LastName = '" + ln + "' AND MiddleName = '" + mn + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("A Student Has Already Been Enrolled With The Same Name!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if(textboxvalidate())
            {
                if (!studentcheck(txtfn.Text, txtln.Text, txtmn.Text))
                {
                    DialogResult res = MessageBox.Show("CONFIRM STUDENT CREATION!", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        createfunction();
                        MessageBox.Show("Record Created Successfully!", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = false;
                        reference.loadData();
                        reference.dataGridView1.ClearSelection();
                        reference.textboxClear();
                        reference.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO CANCEL? INFORMATION WILL BE DISCARDED", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
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
                reference.textboxClear();
                reference.dataGridView1.ClearSelection();
                dbconnection.Close();
            }
            
        }
        private void altertable()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                //int a = int.Parse(studid);
                dbconnection.Open();
                using (var command = new MySqlCommand("alter table studentprofile auto_increment =" + studid + ";", dbconnection))
                {
                    //command.Parameters.AddWithValue("@count", studid);
                    command.ExecuteNonQuery();
                }
                using (var command2 = new MySqlCommand("alter table studdetails auto_increment = " + studid + ";", dbconnection))
                {
                    //command2.Parameters.AddWithValue("@count", studid);
                    command2.ExecuteNonQuery();
                }

            }

        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Others")
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
        public string imgpath;
        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                imgpath = open.FileName;
                // image file path  
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
