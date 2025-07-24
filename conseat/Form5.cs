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
    public partial class frmSelectSeat : Form
    {
        public frmSelectSeat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picUpperBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectUpper upperForm = new frmSelectUpper();
            upperForm.FormClosed += UpperForm_FormClosed;
            upperForm.ShowDialog();
        }

        private void picUpperBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectUpper upperForm = new frmSelectUpper();
            upperForm.FormClosed += UpperForm_FormClosed;
            upperForm.ShowDialog();
        }

        private void pivVip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectVip vipForm = new frmSelectVip();
            vipForm.FormClosed += VipForm_FormClosed;
            vipForm.ShowDialog();
        }

        private void picGenAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectGenAd genAdForm = new frmSelectGenAd();
            genAdForm.FormClosed += GenAdForm_FormClosed;
            genAdForm.ShowDialog();
        }

        private void UpperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void VipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void GenAdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void frmSelectSeat_Load(object sender, EventArgs e)
        {

        }
    }
}
