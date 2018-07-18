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
        public string idstud;
        public editStudent(string idstudent, IDictionary<string, string> dic)
        {
            InitializeComponent();
            idstud = idstudent;
            txtboxfill(dic);
        }
        public MySqlConnection dbconnection;
        private void updatevalue()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                using (var command = new MySqlCommand("UPDATE studentprofile set FirstName = @fn, LastName = @ln, MiddleName = @mn, DateOfBirth = @dof, PlaceOfBirth = @pof, Sex = @sex, Religion = @rel, Nickname = @nickname WHERE idstudentprofile = @ayd;", dbconnection))
                {
                    command.Parameters.AddWithValue("@ayd", idstud);
                    command.Parameters.AddWithValue("@fn", txtfn.Text);
                    command.Parameters.AddWithValue("@ln", txtln.Text);
                    command.Parameters.AddWithValue("@mn", txtmn.Text);
                    command.Parameters.AddWithValue("@dof", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pof", txtbp.Text);
                    command.Parameters.AddWithValue("@sex", txtsex.Text);
                    command.Parameters.AddWithValue("@rel", txtrel.Text);
                    command.Parameters.AddWithValue("@nickname", txtnn.Text);
                    command.ExecuteNonQuery();
                }
            }

        }
        public void txtboxfill(IDictionary<string, string> dic)
        {
            DateTime dt = DateTime.Parse(dic["bd"]);
            dateTimePicker1.Value = dt;
            txtstno.Text = idstud;
            txtfn.Text = dic["fn"];
            txtln.Text = dic["ln"];
            txtmn.Text = dic["mn"];
            txtbp.Text = dic["bp"];
            txtsex.Text = dic["sex"];
            txtrel.Text = dic["rel"];
            txtnn.Text = dic["nn"];
            
        }

        private void editStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //reference.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updatevalue();
            MessageBox.Show("Records Succesfully Altered!");
            reference.loadData();
            this.Close();
        }
    }
}
