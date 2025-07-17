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
    public partial class ucConcertCard : UserControl
    {


        public string ConcertID { get; set; }

        public ucConcertCard()
        {
            InitializeComponent();
        }

        public void SetData(string id, string artistName, Image artistImage)
        {
            ConcertID = id;
            lblArtistName.Text = artistName;
            picArtist.Image = artistImage;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Raise event to parent form
            this.OnEditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.OnDeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler OnEditClicked;
        public event EventHandler OnDeleteClicked;


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     
        private void lblArtistName_Click(object sender, EventArgs e)
        {

        }

        private void ucConcertCard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
