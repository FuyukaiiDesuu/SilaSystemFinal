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

namespace MainSystem.LoginDashboard
{
    public partial class frmsyear : Form
    {
        public FormLogin reference { get; set; }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public frmsyear()
        {
            InitializeComponent();
            readdata();
        }

        private void frmsyear_Load(object sender, EventArgs e)
        {

        }
        private void readdata()
        {
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM schoolyear;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvsyear.DataSource = dt;
            }
            dgvsyear.Columns["idSchoolYear"].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            reference.Show();
            reference.getsyear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                DialogResult res = MessageBox.Show("Confirm School Year Creation!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    var dbconnect = new dbConnector();
                    using (dbconnection = dbconnect.connector())
                    {

                        dbconnection.Open();
                        using (var com = new MySqlCommand("INSERT INTO schoolyear(syear, statussyear) VALUES(@syear, @stat)", dbconnection))
                        {
                            com.Parameters.AddWithValue("@syear", textBox1.Text + " - " + textBox2.Text);
                            com.Parameters.AddWithValue("@stat", "Ready");
                            com.ExecuteNonQuery();
                        }
                    }
                    readdata();
                    MessageBox.Show("School Year Created Successfully, NOTE: Newley Created S.Y. Is Still Not Open", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string idsyear;
        public string syee;
        private void dgvsyear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idsyear = dgvsyear.Rows[e.RowIndex].Cells["idSchoolYear"].Value.ToString();
                syee = dgvsyear.Rows[e.RowIndex].Cells["syear"].Value.ToString();
                switch (dgvsyear.Rows[e.RowIndex].Cells["statussyear"].Value.ToString())
                {
                    case "Ready":
                        btnopen.Enabled = true;
                        btnclose.Enabled = false;
                        break;
                    case "Open":
                        btnopen.Enabled = false;
                        btnclose.Enabled = true;
                        break;
                    case "Closed":
                        btnopen.Enabled = true;
                        btnclose.Enabled = false;
                        break;

                }
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("School Year Will Be Closed!, Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {

                    dbconnection.Open();
                    using (var com = new MySqlCommand("UPDATE schoolyear SET statussyear = @stat WHERE idSchoolYear = @ayd;", dbconnection))
                    {
                        com.Parameters.AddWithValue("@ayd", idsyear);
                        com.Parameters.AddWithValue("@stat", "Open");
                        com.ExecuteNonQuery();
                    }
                    readdata();
                    MessageBox.Show("School Year Opened, Current School Year Will Be Set To S.Y. "+syee, "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("School Year Will Be Closed!, Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {

                    dbconnection.Open();
                    using (var com = new MySqlCommand("UPDATE schoolyear SET statussyear = @stat WHERE idSchoolYear = @ayd;", dbconnection))
                    {
                        com.Parameters.AddWithValue("@ayd", idsyear);
                        com.Parameters.AddWithValue("@stat", "Closed");
                        com.ExecuteNonQuery();
                    }
                }
                readdata();
                MessageBox.Show("School Year Opened, Current School Year Will Be Reset", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
