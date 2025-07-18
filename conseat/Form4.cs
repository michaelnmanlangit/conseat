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
    public partial class frmConcertDetails : Form
    {
        public frmConcertDetails(string id, string artistName, string eventDate, string eventTime, string venueName, Image artistImage)
        {
            InitializeComponent();

            lblArtistName.Text = artistName;
            lblDate.Text = eventDate;
            lblTime.Text = eventTime;
            lblVenue.Text = venueName;
            picImage.Image = artistImage;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
                            
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
    }
}
