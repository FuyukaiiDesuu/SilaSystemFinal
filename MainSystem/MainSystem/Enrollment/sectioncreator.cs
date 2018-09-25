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
    public partial class sectioncreator : Form
    {
        public frmSectionMgmt reference { get; set; }
        public int checker = 0;
        public List<string> x;
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public sectioncreator(int a, List<string> b)
        {
            InitializeComponent();
            x = b;
            checker = a;
        }
        private void loader()
        {
            switch(x[2])
            {
                case "1":
                {
                    comboBox1.Text = "Pre-School";
                    break;
                }
                case "2":
                    {
                        comboBox1.Text = "Grade-School";
                        break;
                    }
                case "3":
                    {
                        comboBox1.Text = "Junior-Highchool";
                        break;
                    }
                case "4":
                    {
                        comboBox1.Text = "Senior-Highschool";
                        break;
                    }
            }
            comboBox2.Text = x[3];
            textBox1.Text = x[1];
        }
        private void sectioncreator_Load(object sender, EventArgs e)
        {
            if(checker == 2)
            {
                loader();
                button1.Text = "UPDATE";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //private MySqlConnection dbconnection;
        private void creator()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "INSERT INTO sectionnames(section_name, department, gradelevel) VALUES(@section_name, @department, @gradelevel);";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.Parameters.AddWithValue("@section_name", textBox1.Text);
                    command2.Parameters.AddWithValue("@gradelevel", comboBox2.Text);
                    var x = comboBox1.SelectedIndex + 1;
                    command2.Parameters.AddWithValue("@department", x.ToString());

                    command2.ExecuteNonQuery();
                }
            }
        }
        private void creator2()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "UPDATE sectionnames SET section_name = @section_name, department = @department, gradelevel = @gradelevel WHERE idsnames = @ids;";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.Parameters.AddWithValue("@section_name", textBox1.Text);
                    command2.Parameters.AddWithValue("@gradelevel", comboBox2.Text);
                    var aa = comboBox1.SelectedIndex + 1;
                    command2.Parameters.AddWithValue("@department", aa.ToString());
                    command2.Parameters.AddWithValue("@ids", x[0]);
                    command2.ExecuteNonQuery();
                }
            }
        }
        private void sectionupdater(string xy)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "UPDATE studdetails SET section = @sec WHERE idstddet = @iddd;";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.Parameters.AddWithValue("@sec", textBox1.Text);
                    command2.Parameters.AddWithValue("@iddd", xy);
                    command2.ExecuteNonQuery();
                }
            }
        }
        private void alterrer()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studdetails WHERE sectionid = '" + x[0] + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    sectionupdater(row["idstddet"].ToString());
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if(checker == 1)
           {
                creator();
                reference.loadData2();
                this.Dispose();
            }
           else if(checker == 2)
           { 
                creator2();
                alterrer();
                reference.loadData2();
                this.Dispose();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO CANCEL?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                reference.loadData2();
                this.Close();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.Text)
            {
                case "Pre-School":
                    comboBox2.Items.Add("Nursery");
                    comboBox2.Items.Add("Kinder");
                    comboBox2.Items.Add("Preparatory");
                    break;
                case "Grade-School":
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b,.-]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("The Text Must Can Only Consist Of Alphabets and Numbers, and The Characters: '-,.'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
