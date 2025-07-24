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
    public partial class frmCheckOut : Form
    {
        private string seatType;
        private string seatId;
        private decimal price;
        private DBConnection db = new DBConnection();
        
        public frmCheckOut(string seatType, string seatId, decimal price)
        {
            InitializeComponent();
            
            this.seatType = seatType;
            this.seatId = seatId;
            this.price = price;
        }

        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Get price from database based on seat type and concert
            decimal actualPrice = GetPriceFromDatabase();
            
            // Display concert and seat information
            if (SessionManager.CurrentConcertId != null)
            {
                lblArtistName.Text = SessionManager.CurrentConcertName;
                lblDateTime.Text = $"{SessionManager.CurrentConcertDate.ToShortDateString()} {SessionManager.CurrentConcertTime}";
                lblVenue.Text = SessionManager.CurrentConcertVenue;
                lblBlockSeatNo.Text = $"{seatType}-{seatId}";
                lblPrice.Text = $"₱{actualPrice:N2}";
                
                // Update the price variable with actual price from database
                this.price = actualPrice;

                // Load and display the concert image
                LoadConcertImage();
            }
        }

        private void LoadConcertImage()
        {
            try
            {
                // First try to get image from SessionManager if available
                if (SessionManager.CurrentConcertImage != null)
                {
                    picImage.Image = SessionManager.CurrentConcertImage;
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
                }

                // If not in session, load from database
                db.OpenConnection();
                string query = "SELECT image FROM concert_events WHERE id = @concertId";
                
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("image")))
                    {
                        byte[] imgBytes = (byte[])reader["image"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            Image concertImage = Image.FromStream(ms);
                            picImage.Image = concertImage;
                            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            
                            // Store in session for future use
                            SessionManager.CurrentConcertImage = concertImage;
                        }
                    }
                    else
                    {
                        // Use default image if no concert image available
                        SetDefaultImage();
                    }
                }
                else
                {
                    // Use default image if concert not found
                    SetDefaultImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading concert image: " + ex.Message);
                SetDefaultImage();
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SetDefaultImage()
        {
            try
            {
                // Try to use a default image from resources
                if (Properties.Resources.back_svgrepo_com1 != null)
                {
                    picImage.Image = Properties.Resources.back_svgrepo_com1;
                }
                else
                {
                    // Create a simple placeholder image if no default available
                    Bitmap placeholder = new Bitmap(200, 200);
                    using (Graphics g = Graphics.FromImage(placeholder))
                    {
                        g.Clear(Color.LightGray);
                        using (Font font = new Font("Arial", 12, FontStyle.Bold))
                        {
                            string text = "Concert\nImage";
                            SizeF textSize = g.MeasureString(text, font);
                            float x = (placeholder.Width - textSize.Width) / 2;
                            float y = (placeholder.Height - textSize.Height) / 2;
                            g.DrawString(text, font, Brushes.Black, x, y);
                        }
                    }
                    picImage.Image = placeholder;
                }
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error setting default image: " + ex.Message);
            }
        }

        private decimal GetPriceFromDatabase()
        {
            decimal seatPrice = 0m;
            
            try
            {
                db.OpenConnection();
                string query = @"SELECT price_vip, price_gen_ad, price_upper_box 
                               FROM concert_events 
                               WHERE id = @concertId";
                               
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    switch (seatType.ToLower())
                    {
                        case "vip":
                            if (!reader.IsDBNull(reader.GetOrdinal("price_vip")))
                                seatPrice = Convert.ToDecimal(reader["price_vip"]);
                            break;
                        case "gen ad":
                            if (!reader.IsDBNull(reader.GetOrdinal("price_gen_ad")))
                                seatPrice = Convert.ToDecimal(reader["price_gen_ad"]);
                            break;
                        case "upper box":
                            if (!reader.IsDBNull(reader.GetOrdinal("price_upper_box")))
                                seatPrice = Convert.ToDecimal(reader["price_upper_box"]);
                            break;
                        default:
                            seatPrice = this.price; // fallback to passed price
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting price: " + ex.Message);
                seatPrice = this.price; // fallback to passed price
            }
            finally
            {
                db.CloseConnection();
            }
            
            return seatPrice;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            // Optional: Show full-size image in a dialog
            if (picImage.Image != null)
            {
                ShowFullSizeImage();
            }
        }

        private void ShowFullSizeImage()
        {
            try
            {
                Form imageForm = new Form();
                imageForm.Text = $"{SessionManager.CurrentConcertName} - Concert Image";
                imageForm.Size = new Size(600, 600);
                imageForm.StartPosition = FormStartPosition.CenterParent;
                imageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                imageForm.MaximizeBox = false;
                imageForm.MinimizeBox = false;

                PictureBox fullSizePic = new PictureBox();
                fullSizePic.Dock = DockStyle.Fill;
                fullSizePic.Image = picImage.Image;
                fullSizePic.SizeMode = PictureBoxSizeMode.Zoom;

                imageForm.Controls.Add(fullSizePic);
                imageForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying full-size image: " + ex.Message);
            }
        }

        private void btnProceedPayment_Click(object sender, EventArgs e)
        {
            frmPaymentMethod paymentForm = new frmPaymentMethod(seatType, seatId, price);
            
            // Instead of using SessionManager.ShowModalDialog, use a custom approach
            // that will close this checkout form when the payment process completes
            this.Hide();
            
            paymentForm.FormClosed += (s, args) => {
                // When payment form closes, close this checkout form too
                // (the payment flow will handle showing the thanks form)
                this.Close();
            };
            
            paymentForm.ShowDialog();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblBlockSeatNo_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void lblVenue_Click(object sender, EventArgs e)
        {

        }

        private void lblArtistName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
