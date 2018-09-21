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
    public partial class editStudent : Form
    {
        
        public EnrollmentConsole reference { get; set; }
        public string syear { get; set; }
        public string idstud;
        public string imgpath;
        public editStudent(string idstudent, IDictionary<string, string> dic, string imgpth)
        {
            InitializeComponent();
            idstud = idstudent;
            txtboxfill(dic);
            combochanger();
            txtboxfill(dic);
            imgpath = imgpth;
            pictureBox1.ImageLocation = imgpth;
        }
        public IDictionary<string, string> studdet;
        public MySqlConnection dbconnection;
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
        private void updatevalue()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                studdetails(comboBox3.Text, comboBox2.Text);
                //MessageBox.Show(studdet["dept"]);
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname, image_path = @imgpt WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", idstud);
                    command.Parameters.AddWithValue("@fn", txtfn.Text);
                    command.Parameters.AddWithValue("@ln", txtln.Text);
                    command.Parameters.AddWithValue("@mn", txtmn.Text);
                    command.Parameters.AddWithValue("@dof", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pof", txtbp.Text);
                    command.Parameters.AddWithValue("@sex", comboBox1.Text);
                    if (comboBox4.Text == "Others")
                    {
                        command.Parameters.AddWithValue("@rel", textBox1.Text);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@rel", comboBox4.Text);
                    }
                    command.Parameters.AddWithValue("@nickname", txtnn.Text);
                    command.Parameters.AddWithValue("@imgpt", imgpath);
                    command.ExecuteNonQuery();
                }
                using (var command = new MySqlCommand("UPDATE studdetails SET level_dummyval = @lvldval, department = @dept, level = @lvl WHERE idstddet = @ayd", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", idstud);
                    command.Parameters.AddWithValue("@dept", studdet["dept"]);
                    command.Parameters.AddWithValue("@lvl", studdet["level"]);
                    //command.Parameters.AddWithValue("@sy", lblsy.Text);
                    command.Parameters.AddWithValue("@lvldval", comboBox2.Text);
                    //need to update query to insert department integer value
                    command.ExecuteNonQuery();
                }
                using (var command = new MySqlCommand("UPDATE accountdetails SET fid = @fid WHERE spid = @ayd", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", idstud);
                    command.Parameters.AddWithValue("@fid", studdet["feelevel"]);
                    command.ExecuteNonQuery();
                }
            }

        }
        public string sygetter()
        {
            DateTime dt = DateTime.Now;
            int a = Convert.ToInt32(dt.ToString("yyyy"));
            return dt.ToString("yyyy") + "-" + (a + 1).ToString();
        }
        public Boolean a;
        public void txtboxfill(IDictionary<string, string> dic)
        {
            DateTime dt = DateTime.Parse(dic["bd"]);
            dateTimePicker1.Value = dt;
            txtstno.Text = idstud;
            txtfn.Text = dic["fn"];
            txtln.Text = dic["ln"];
            txtmn.Text = dic["mn"];
            txtbp.Text = dic["bp"];
            comboBox1.Text = dic["sex"];
            
            if(dic["rel"] == "Born-again" || dic["rel"] == "Roman Catholic" || dic["rel"] == "Iglesia Ni Cristo" || dic["rel"] == "Islam" || dic["rel"] == "Seventh Day Adventist")
            { 
                comboBox4.Text = dic["rel"];
            }
            else
            {
                textBox1.Enabled = true;
                comboBox4.Text = "Others";
                textBox1.Text = dic["rel"];
            }
            txtnn.Text = dic["nn"];
            comboBox3.Text = dic["dept"];
            comboBox2.Text = dic["lvl"];
            

        }

        private void editStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO EXIT?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                this.Close();
                reference.dataGridView1.ClearSelection();
                reference.textboxClear();
                reference.Show();
                
            }
           
        }
        private Boolean textboxvalidate()
        {
            if (txtfn.Text == "" || txtln.Text == "" || txtmn.Text == "" || txtbp.Text == "" || txtnn.Text == "" || dateTimePicker1.Value.ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd") || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("PLEASE FILL OUT ALL TEXT FEILDS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textboxvalidate())
            {
                DialogResult res = MessageBox.Show("CONFIRM STUDENT UPDATE!", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    updatevalue();
                    MessageBox.Show("Records Succesfully Altered!");
                    reference.loadData();
                    reference.dataGridView1.ClearSelection();
                    reference.textboxClear();
                    this.Close();
                }
            }
        }
        private void combochanger()
        {
            comboBox2.Items.Clear();
            switch (comboBox3.Text)
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
        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            combochanger();
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
    }
}
