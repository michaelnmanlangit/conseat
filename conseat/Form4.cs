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
        private string concertId;
        
        public frmConcertDetails(string id, string artistName, string eventDate, string eventTime, string venueName, Image artistImage)
        {
            InitializeComponent();

            concertId = id;
            lblArtistName.Text = artistName;
            lblDate.Text = eventDate;
            lblTime.Text = eventTime;
            lblVenue.Text = venueName;
            picImage.Image = artistImage;
            
            // Set concert context in session with image
            if (DateTime.TryParse(eventDate, out DateTime parsedDate))
            {
                SessionManager.SetConcertContext(id, artistName, parsedDate, eventTime, venueName, artistImage);
            }
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

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {
            frmSelectSeat selectSeatForm = new frmSelectSeat();
            selectSeatForm.ShowDialog(); // or Show()
        }

        private void lblVenue_Click(object sender, EventArgs e)
        {

        }
    }
}
