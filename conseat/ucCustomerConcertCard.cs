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

        public ucCustomerConcertCard()
        {
            InitializeComponent();
        }

        public void SetData(string id, string artistName, Image artistImage)
        {
            ConcertID = id;
            lblArtistName.Text = artistName;
            picArtist.Image = artistImage;
            CenterLabel();
        }

        private void CenterLabel()
        {
           
        }

        public event EventHandler OnBuyClicked;

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
        }

        private void ucCustomerConcertCard_Load(object sender, EventArgs e)
        {
            CenterLabel();
        }
    



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
