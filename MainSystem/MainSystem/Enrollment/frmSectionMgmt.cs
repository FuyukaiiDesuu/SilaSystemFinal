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

namespace MainSystem
{
    public partial class frmSectionMgmt : Form
    {
        public EnrollmentConsole reference { get; set; }
        //public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        private MySqlConnection dbconnection;
        public frmSectionMgmt()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn cbclm = new DataGridViewCheckBoxColumn();
            cbclm.HeaderText = "Select";
            dataGridView1.Columns.Add(cbclm);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            loadData();
            loadData2();
            
        }
        public void loadSearch()
        {
            var dbconnect = new dbConnector();
            string query = "select * from studentprofile inner join studdetails on studentprofile.idstudentprofile = studdetails.idstddet" +
                " WHERE studentprofile.Status = 1" +
                " AND studdetails.section LIKE '%"+textBox2.Text+"%';";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(query, dbconnection);
                DataSet data = new DataSet();
                ad.Fill(data);
                dataGridView2.DataSource = data.Tables[0];

                dataGridView2.Columns["idstudentprofile"].Visible = true;
                dataGridView2.Columns["FirstName"].Visible = true;
                dataGridView2.Columns["LastName"].Visible = true;
                dataGridView2.Columns["MiddleName"].Visible = true;
                dataGridView2.Columns["DateOfBirth"].Visible = true;
                dataGridView2.Columns["PlaceOfBirth"].Visible = false;
                dataGridView2.Columns["Sex"].Visible = true;
                dataGridView2.Columns["Religion"].Visible = false;
                dataGridView2.Columns["Nickname"].Visible = false;
                dataGridView2.Columns["idstuddet"].Visible = false;
                dataGridView2.Columns["Status"].Visible = false;
                dataGridView2.Columns["department"].Visible = false;
                dataGridView2.Columns["level"].Visible = true;
                dataGridView2.Columns["school_year"].Visible = false;
                dataGridView2.Columns["idstddet"].Visible = false;
                dataGridView2.Columns["section"].Visible = true;

                dataGridView2.Columns["idstudentprofile"].HeaderText = "Student ID No.";
                dataGridView2.Columns["FirstName"].HeaderText = "First Name";
                dataGridView2.Columns["LastName"].HeaderText = "Last Name";
                dataGridView2.Columns["MiddleName"].HeaderText = "Middle Name";

            }
            dbconnection.Close();
        }
        public void loadData2()
        {
            var dbconnect = new dbConnector();
            string query = "select * from sectionnames;";
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(query, dbconnection);
                DataSet data = new DataSet();
                ad.Fill(data);
                dataGridView2.DataSource = data.Tables[0];
                dataGridView2.Columns["idsnames"].Visible = false;
                dataGridView2.Columns["department"].Visible = false;
                dataGridView2.Columns["gradelevel"].HeaderText = "LEVEL";
                dataGridView2.Columns["section_name"].HeaderText = "SECTION NAME";
            }
            dbconnection.Close();


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
                dataGridView1.Columns["sectionid"].Visible = false ;

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
        private Boolean checkifcheckerchecked()
        {
            var x = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    x = true;
                }
            }
            if(x)
            {
                return true;
            }
            else
            {
                MessageBox.Show("NO STUDENT/S ARE CURRENTLY SELECTED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string secid;
        private void button5_Click(object sender, EventArgs e)
        {
            if (checkifcheckerchecked())
            {
                secinput = new sectioninput();
                if (secinput.ShowDialog() == DialogResult.OK)
                {
                    sectionname = secinput.sectioninputt;
                    secid = secinput.sectionid;
                    idlistgrabber();
                    var dbconnect = new dbConnector();
                    using (dbconnection = dbconnect.connector())
                    {
                        dbconnection.Open();
                        foreach (string id in stdlistid)
                        {
                            string query2 = "UPDATE studdetails SET section = @sec, sectionid = @secid WHERE idstddet = @idstud;";
                            using (var command2 = new MySqlCommand(query2, dbconnection))
                            {
                                command2.Parameters.AddWithValue("@sec", sectionname);
                                command2.Parameters.AddWithValue("@secid", secid);
                                command2.Parameters.AddWithValue("@idstud", id);
                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                    loadData();
                    loadData2();
                }
                else
                {
                    loadData();
                    loadData2();
                }
            }
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadSearch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Enrollment.sectioncreator screate;
        private void createsect_Click(object sender, EventArgs e)
        {
            screate = new Enrollment.sectioncreator(1, list);
            screate.reference = this;
            screate.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkifcheckerchecked())
            {
                DialogResult res = MessageBox.Show("SELECTED STUDENT/S WILL BE REMOVED FROM CURRENT SECTIONS!", "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(res == DialogResult.OK)
                {
                    idlistgrabber();
                    var dbconnect = new dbConnector();
                    using (dbconnection = dbconnect.connector())
                    {
                        dbconnection.Open();
                        foreach (string id in stdlistid)
                        {
                            string query2 = "UPDATE studdetails SET section = @sec, sectionid = @secid WHERE idstddet = @idstud;";
                            using (var command2 = new MySqlCommand(query2, dbconnection))
                            {
                                command2.Parameters.AddWithValue("@sec", null);
                                command2.Parameters.AddWithValue("@secid", null);
                                command2.Parameters.AddWithValue("@idstud", id);
                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                    loadData();
                    loadData2();
                }
                
            }
        }
        public List<string> list;
        private void updatesect_Click(object sender, EventArgs e)
        {
            screate = new Enrollment.sectioncreator(2, list);
            screate.reference = this;
            screate.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list = new List<string>();
            updatesect.Enabled = true;
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells["department"].Value.ToString());
                list.Add(dataGridView2.Rows[e.RowIndex].Cells["idsnames"].Value.ToString());
                list.Add(dataGridView2.Rows[e.RowIndex].Cells["section_name"].Value.ToString());
                list.Add(dataGridView2.Rows[e.RowIndex].Cells["department"].Value.ToString());
                list.Add(dataGridView2.Rows[e.RowIndex].Cells["gradelevel"].Value.ToString());
            }
               
        }
    }
}
