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
    public partial class ucCustomerConcertCard : UserControl
    {

        public string ConcertID { get; set; }
        public string ArtistName { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public string VenueName { get; set; }
        public Image ArtistImage { get; set; }

        public ucCustomerConcertCard()
        {
            InitializeComponent();
        }

        public void SetData(string id, string artistName, string eventDate, string eventTime, string venueName, Image artistImage)
        {
            ConcertID = id;
            ArtistName = artistName;
            EventDate = eventDate;
            EventTime = eventTime;
            VenueName = venueName;
            ArtistImage = artistImage;

            lblArtistName.Text = artistName;
            picArtist.Image = artistImage;

            CenterLabel();
        }

        private void CenterLabel()
        {
           
        }

        public event EventHandler OnBuyClicked;

        

        private void ucCustomerConcertCard_Load(object sender, EventArgs e)
        {
            CenterLabel();
        }
    



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to buy a ticket for this concert?",
         "Confirm Purchase",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     );

            if (result == DialogResult.Yes)
            {
                OnBuyClicked?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                // Optional: do nothing or show cancellation
                MessageBox.Show("Purchase cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
