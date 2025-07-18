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

        private string concertID;
        private bool isEditMode = false;

        public ucCreateEvent()
        {
            InitializeComponent();
            isEditMode = false;
            
        }

        // Overloaded constructor for editing an existing concert
        public ucCreateEvent(string id)
        {
            InitializeComponent();
            concertID = id;
            isEditMode = true;
            lblTitle.Text = "Edit Concert Event";
            LoadConcertData();

            
        }


        private void LoadConcertData()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                db.OpenConnection();

                string query = "SELECT * FROM concert_events WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", concertID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEventName.Text = reader["event_name"].ToString();
                            txtArtistName.Text = reader["artist_name"].ToString();
                            cmbVenue.SelectedItem = reader["venue"].ToString();
                            dtpDate.Value = Convert.ToDateTime(reader["event_date"]);
                            dtpTime.Value = DateTime.Today.Add((TimeSpan)reader["event_time"]);
                            txtPriceVIP.Text = reader["price_vip"].ToString();
                            txtPriceGenAd.Text = reader["price_gen_ad"].ToString();
                            txtPriceUpperBox.Text = reader["price_upper_box"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("image")))
                            {
                                byte[] imgBytes = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    pbArtistImage.Image = Image.FromStream(ms);
                                    pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading concert data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
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
            cmbVenue.Items.Clear(); // clear existing items
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
            if (string.IsNullOrWhiteSpace(txtEventName.Text) ||
                string.IsNullOrWhiteSpace(txtArtistName.Text) ||
                cmbVenue.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPriceVIP.Text) ||
                string.IsNullOrWhiteSpace(txtPriceGenAd.Text) ||
                string.IsNullOrWhiteSpace(txtPriceUpperBox.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                db.OpenConnection();

                byte[] imageBytes = null;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    imageBytes = File.ReadAllBytes(imagePath); // New image from file
                }
                else if (pbArtistImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbArtistImage.Image.Save(ms, pbArtistImage.Image.RawFormat);
                        imageBytes = ms.ToArray(); // Use existing image
                    }
                }

                string query;

                if (isEditMode)
                {
                    query = @"UPDATE concert_events 
                              SET event_name = @event, artist_name = @artist, venue = @venue,
                                  event_date = @date, event_time = @time,
                                  price_vip = @vip, price_gen_ad = @genad, price_upper_box = @upperbox,
                                  image = @image
                              WHERE id = @id";
                }
                else
                {
                    query = @"INSERT INTO concert_events 
                              (event_name, artist_name, venue, event_date, event_time, 
                               price_vip, price_gen_ad, price_upper_box, image)
                              VALUES
                              (@event, @artist, @venue, @date, @time,
                               @vip, @genad, @upperbox, @image)";
                }

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
                    cmd.Parameters.AddWithValue("@image", imageBytes);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@id", concertID);
                    }

                    cmd.ExecuteNonQuery();
                }

                db.CloseConnection();

                MessageBox.Show(isEditMode ? "Concert updated successfully!" : "Concert created successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!isEditMode)
                {
                    ClearFields();
                }
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
