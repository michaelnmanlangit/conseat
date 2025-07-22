using MySql.Data.MySqlClient;
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
    public partial class frmSelectGenAd : Form
    {
        private DBConnection db = new DBConnection();
        List<string> selectedSeats = new List<string>();

        public frmSelectGenAd()
        {
            InitializeComponent();
            
            // Subscribe to the seat reservation event
            frmSendPayment.SeatReserved += OnSeatReserved;
        }

        private void frmSelectGenAd_Load(object sender, EventArgs e)
        {
            LoadSeats();
            // Initialize label
            if (lblSelected != null)
            {
                lblSelected.Text = "Selected: None";
            }
        }

        private void LoadSeats()
        {
            // Check if panelSeats exists and has controls
            if (panelSeats == null || panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("No seat controls found in panelSeats");
                return;
            }

            foreach (Control control in panelSeats.Controls)
            {
                if (control is PictureBox seat)
                {
                    string seatId = seat.Name.Substring(3); // Assumes seat names like picA1, picB2
                    seat.Tag = seatId;

                    if (IsSeatReserved(seatId))
                    {
                        seat.BackColor = Color.Red;
                        seat.Enabled = false;
                    }
                    else
                    {
                        seat.BackColor = Color.LightGray;
                        seat.Enabled = true;

                        seat.Click -= Seat_Click; // Prevent duplicate binding
                        seat.Click += Seat_Click;
                    }
                }
            }
        }

        private bool IsSeatReserved(string seatId)
        {
            bool reserved = false;
            try
            {
                db.OpenConnection();
                
                // First check if we have valid context
                if (string.IsNullOrEmpty(SessionManager.CurrentConcertId))
                {
                    // For testing purposes, if no concert is selected, just return false
                    return false;
                }

                string query = @"SELECT is_reserved FROM tbl_seats 
                               WHERE concert_id = @concertId 
                               AND seat_type = 'Gen Ad' 
                               AND seat_id = @seatId";
                               
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                cmd.Parameters.AddWithValue("@seatId", seatId);

                object result = cmd.ExecuteScalar();
                if (result != null && Convert.ToBoolean(result) == true)
                {
                    reserved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking seat: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return reserved;
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            PictureBox clickedSeat = sender as PictureBox;
            if (clickedSeat?.Tag == null)
            {
                MessageBox.Show("Seat tag is null");
                return;
            }
            
            string seatId = clickedSeat.Tag.ToString();

            foreach (Control control in panelSeats.Controls)
            {
                if (control is PictureBox seat)
                {
                    if (seat.BackColor != Color.Red)
                        seat.BackColor = Color.LightGray;
                }
            }

            selectedSeats.Clear();
            selectedSeats.Add(seatId);
            clickedSeat.BackColor = Color.LightGreen;

            // Update label - make sure lblSelected exists
            if (lblSelected != null)
            {
                lblSelected.Text = "Selected: Gen Ad-" + seatId;
            }
            else
            {
                MessageBox.Show("lblSelected control not found!");
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select a seat first.", "No Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Please login first.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(SessionManager.CurrentConcertId))
            {
                MessageBox.Show("Concert information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSeatId = selectedSeats[0];
            decimal genAdPrice = GetGenAdPriceFromDatabase();

            // Check if seat is already reserved before proceeding to checkout
            try
            {
                db.OpenConnection();
                
                string checkQuery = @"SELECT is_reserved FROM tbl_seats 
                                    WHERE concert_id = @concertId 
                                    AND seat_type = 'Gen Ad' 
                                    AND seat_id = @seatId";
                                    
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                checkCmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                checkCmd.Parameters.AddWithValue("@seatId", selectedSeatId);
                
                object result = checkCmd.ExecuteScalar();
                
                if (result != null && Convert.ToBoolean(result) == true)
                {
                    MessageBox.Show("This seat is already reserved.", "Seat Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Seat is available, proceed to checkout WITHOUT reserving it yet
                // The seat will only be reserved after successful payment
                frmCheckOut checkoutForm = new frmCheckOut("Gen Ad", selectedSeatId, genAdPrice);
                this.Hide();
                checkoutForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private decimal GetGenAdPriceFromDatabase()
        {
            decimal price = 800.00m; // default fallback
            
            try
            {
                db.OpenConnection();
                string query = "SELECT price_gen_ad FROM concert_events WHERE id = @concertId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    price = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting Gen Ad price: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            
            return price;
        }

        private void panelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSelected_Click(object sender, EventArgs e)
        {

        }

        private void OnSeatReserved(string concertId, string seatType, string seatId)
        {
            // Only update if it's for the current concert and seat type
            if (concertId == SessionManager.CurrentConcertId && seatType == "Gen Ad")
            {
                // Update the specific seat visual to show as reserved
                UpdateSeatVisual(seatId, true);
            }
        }

        private void UpdateSeatVisual(string seatId, bool isReserved)
        {
            // Find the seat picture box and update its appearance
            string seatPicName = "pic" + seatId;
            PictureBox seatPic = panelSeats.Controls.Find(seatPicName, false).FirstOrDefault() as PictureBox;
            
            if (seatPic != null)
            {
                if (isReserved)
                {
                    seatPic.BackColor = Color.Red;
                    seatPic.Enabled = false;
                    seatPic.Click -= Seat_Click;
                }
                else
                {
                    seatPic.BackColor = Color.LightGray;
                    seatPic.Enabled = true;
                    seatPic.Click -= Seat_Click; // Remove first to prevent duplicates
                    seatPic.Click += Seat_Click;
                }
            }
        }

        // Add individual seat click handlers to ensure they all work
        private void picA1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picA2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picA3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picA4_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picA5_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picB1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picB2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picB3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picB4_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picB5_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picC1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picC2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picC3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picC4_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picC5_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picD1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picD2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picD3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picD4_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picD5_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
    }
}
