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
    public partial class frmAddTransaction : Form
    {
        public frmAddTransaction()
        {
            InitializeComponent();
        }

        private void grpNewPayment_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddTransaction_Load(object sender, EventArgs e)
        {
            //For Disabling Cheque Textbox if text in Payment to is empty or doesnt match with the word CHEQUE
            disableTextbox();
        }


        private void cmbPaymentType_TextChanged(object sender, EventArgs e)
        {
            //For Disabling Cheque Textbox if text in Payment to doesnt match with the word CHEQUE
            if (cmbPaymentType.Text == "CHEQUE")
            {
                txtChequeNo.Enabled = true;
            }
            else
            {
                txtChequeNo.Enabled = false;
            }
        }

        private void disableTextbox()
        {
            txtChequeNo.Enabled = !string.IsNullOrWhiteSpace(cmbPaymentType.Text);
        }
    }
}
