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
            lblVenue.Text = venueName;
            picImage.Image = artistImage;
            
            // Format date to display only date without time
            if (DateTime.TryParse(eventDate, out DateTime parsedDate))
            {
                lblDate.Text = parsedDate.ToString("MMMM dd, yyyy"); // e.g., "December 25, 2024"
                SessionManager.SetConcertContext(id, artistName, parsedDate, eventTime, venueName, artistImage);
            }
            else
            {
                lblDate.Text = eventDate; // fallback if parsing fails
            }

            // Format time to 12-hour format
            if (TimeSpan.TryParse(eventTime, out TimeSpan parsedTime))
            {
                DateTime timeOnly = DateTime.Today.Add(parsedTime);
                lblTime.Text = timeOnly.ToString("h:mm tt"); // e.g., "7:30 PM"
            }
            else if (DateTime.TryParse(eventTime, out DateTime parsedDateTime))
            {
                lblTime.Text = parsedDateTime.ToString("h:mm tt"); // e.g., "7:30 PM"
            }
            else
            {
                lblTime.Text = eventTime; // fallback if parsing fails
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
            
            // Instead of using SessionManager.ShowModalDialog, use a custom approach
            // that will close this form when the seat selection process completes
            this.Hide();
            
            selectSeatForm.FormClosed += (s, args) => {
                // When seat selection closes, close this concert details form too
                // (the payment flow will handle showing the thanks form)
                this.Close();
            };
            
            selectSeatForm.ShowDialog();
        }

        private void lblVenue_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
