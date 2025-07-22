using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conseat
{
    public partial class frmPaymentMethod : Form
    {
        private string seatType;
        private string seatId;
        private decimal price;
        
        public frmPaymentMethod(string seatType, string seatId, decimal price)
        {
            InitializeComponent();
            
            this.seatType = seatType;
            this.seatId = seatId;
            this.price = price;
        }

        public frmPaymentMethod()
        {
            InitializeComponent();
        }

        

        

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!rbtnGcash.Checked && !rbtnPaymaya.Checked && !rbtnCreditCard.Checked)
            {
                MessageBox.Show("Please select a payment method.", "No Payment Method Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paymentMethod = "";
            if (rbtnGcash.Checked) paymentMethod = "GCash";
            else if (rbtnPaymaya.Checked) paymentMethod = "PayMaya";
            else if (rbtnCreditCard.Checked) paymentMethod = "Credit Card";

            // Navigate to Send Payment form instead of showing completion message
            frmSendPayment sendPaymentForm = new frmSendPayment(paymentMethod, seatType, seatId, price);
            this.Hide();
            sendPaymentForm.ShowDialog();
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void rbtnGcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGcash.Checked)
            {
                // Manually uncheck other radio buttons
                rbtnPaymaya.Checked = false;
                rbtnCreditCard.Checked = false;
            }
        }

        private void rbtnPaymaya_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPaymaya.Checked)
            {
                // Manually uncheck other radio buttons
                rbtnGcash.Checked = false;
                rbtnCreditCard.Checked = false;
            }
        }

        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCreditCard.Checked)
            {
                // Manually uncheck other radio buttons
                rbtnGcash.Checked = false;
                rbtnPaymaya.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaymentMethod_Load_1(object sender, EventArgs e)
        {

            lblPrice.Text = $"₱{price:N2}";

            // Ensure radio buttons are properly grouped and none are selected initially
            rbtnGcash.Checked = false;
            rbtnPaymaya.Checked = false;
            rbtnCreditCard.Checked = false;

            // Set up radio button behavior
            rbtnGcash.CheckedChanged += rbtnGcash_CheckedChanged;
            rbtnPaymaya.CheckedChanged += rbtnPaymaya_CheckedChanged;
            rbtnCreditCard.CheckedChanged += rbtnCreditCard_CheckedChanged;
        }
    }
}
