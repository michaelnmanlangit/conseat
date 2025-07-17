using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace conseat
{
    public partial class ucCreateEvent : UserControl
    {
        private string imagePath = "";

        public ucCreateEvent()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtEventName.Clear();
            txtArtistName.Clear();
            cmbVenue.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;
            txtPriceVIP.Clear();
            txtPriceGenAd.Clear();
            txtPriceUpperBox.Clear();

            
            pbArtistImage.Image = null;
            imagePath = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucCreateEvent_Load(object sender, EventArgs e)
        {
            cmbVenue.Items.Clear(); // Optional: clear existing items
            cmbVenue.Items.AddRange(new string[]
            {
                "Smart Araneta Coliseum",
                "Philippine Arena",
                "Mall of Asia Arena"
            });
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pbArtistImage.Image = Image.FromFile(imagePath);
                pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtEventName.Text) ||
                string.IsNullOrWhiteSpace(txtArtistName.Text) ||
                cmbVenue.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPriceVIP.Text) ||
                string.IsNullOrWhiteSpace(txtPriceGenAd.Text) ||
                string.IsNullOrWhiteSpace(txtPriceUpperBox.Text) ||
                string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please fill out all fields and upload an image.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                db.OpenConnection();

                
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                string query = @"INSERT INTO concert_events 
                         (event_name, artist_name, venue, event_date, event_time, price_vip, price_gen_ad, price_upper_box, image)
                         VALUES 
                         (@event, @artist, @venue, @date, @time, @vip, @genad, @upperbox, @image)";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@event", txtEventName.Text.Trim());
                    cmd.Parameters.AddWithValue("@artist", txtArtistName.Text.Trim());
                    cmd.Parameters.AddWithValue("@venue", cmbVenue.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@time", dtpTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@vip", Convert.ToDecimal(txtPriceVIP.Text));
                    cmd.Parameters.AddWithValue("@genad", Convert.ToDecimal(txtPriceGenAd.Text));
                    cmd.Parameters.AddWithValue("@upperbox", Convert.ToDecimal(txtPriceUpperBox.Text));
                    cmd.Parameters.AddWithValue("@image", imageBytes); // ✅ Add image as byte[]

                    cmd.ExecuteNonQuery();
                }

                db.CloseConnection();

                MessageBox.Show("Concert event saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbArtistImage_Click(object sender, EventArgs e)
        {

        }

        

        

        private void picBack_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
