using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        public void txtboxfill(IDictionary<string, string> dic)
        {
            //DateTime dt = DateTime.Parse(dic["bp"]);
            // dateTimePicker1.Value = dt;
            txtstno.Text = dic["bd"];
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
    }
}
