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
    public partial class frmSelectUpper : Form
    {
        private DBConnection db = new DBConnection();
        List<string> selectedSeats = new List<string>();

        public frmSelectUpper()
        {
            InitializeComponent();
            
            // Subscribe to the seat reservation event
            frmSendPayment.SeatReserved += OnSeatReserved;
        }

        private void OnSeatReserved(string concertId, string seatType, string seatId)
        {
            // Only update if it's for the current concert and seat type
            if (concertId == SessionManager.CurrentConcertId && seatType == "Upper Box")
            {
                // Update the specific seat visual to show as reserved
                UpdateSeatVisual(seatId, true);
            }
        }

        private void UpdateSeatVisual(string seatId, bool isReserved)
        {
            // Find the seat picture box and update its appearance in both panels
            string seatPicName = "pic" + seatId;
            
            // Check main panel first
            PictureBox seatPic = panelSeats.Controls.Find(seatPicName, false).FirstOrDefault() as PictureBox;
            
            // If not found in main panel, check secondary panel
            if (seatPic == null)
            {
                Panel secondPanel = this.Controls.Find("panelSeats1", true).FirstOrDefault() as Panel;
                if (secondPanel != null)
                {
                    seatPic = secondPanel.Controls.Find(seatPicName, false).FirstOrDefault() as PictureBox;
                }
            }
            
            if (seatPic != null)
            {
                if (isReserved)
                {
                    seatPic.BackColor = Color.Red;
                    seatPic.Enabled = false;
                    seatPic.Click -= Seat_Click;
                    seatPic.MouseEnter -= Seat_MouseEnter;
                    seatPic.MouseLeave -= Seat_MouseLeave;
                }
                else
                {
                    seatPic.BackColor = Color.LightGray;
                    seatPic.Enabled = true;
                    seatPic.Click -= Seat_Click; // Remove first to prevent duplicates
                    seatPic.Click += Seat_Click;
                    seatPic.MouseEnter += Seat_MouseEnter;
                    seatPic.MouseLeave += Seat_MouseLeave;
                }
            }
        }

        private void frmSelectUpper_Load(object sender, EventArgs e)
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
            // Load seats from main panel
            LoadSeatsFromPanel(panelSeats, "Main Panel");
            
            // Check if there's a second panel and load from it too
            Panel secondPanel = this.Controls.Find("panelSeats1", true).FirstOrDefault() as Panel;
            if (secondPanel != null)
            {
                LoadSeatsFromPanel(secondPanel, "Secondary Panel");
            }
        }

        private void LoadSeatsFromPanel(Panel panel, string panelName)
        {
            // Check if panel exists and has controls
            if (panel == null || panel.Controls.Count == 0)
            {
                return; // Don't show message, just return silently
            }

            foreach (Control control in panel.Controls)
            {
                if (control is PictureBox seat)
                {
                    // Extract seat ID from PictureBox name
                    string seatId = "";
                    if (seat.Name.StartsWith("pic") && seat.Name.Length > 3)
                    {
                        seatId = seat.Name.Substring(3); // Remove "pic" prefix
                    }
                    
                    // Set up the seat PictureBox
                    seat.Tag = seatId;
                    seat.SizeMode = PictureBoxSizeMode.StretchImage;
                    seat.BorderStyle = BorderStyle.FixedSingle;
                    seat.Cursor = Cursors.Hand;

                    if (IsSeatReserved(seatId))
                    {
                        seat.BackColor = Color.Red;
                        seat.Enabled = false;
                        // You can set a reserved seat image here if you have one
                        // seat.Image = yourReservedSeatImage;
                    }
                    else
                    {
                        seat.BackColor = Color.LightGray;
                        seat.Enabled = true;
                        // You can set an available seat image here if you have one
                        // seat.Image = yourAvailableSeatImage;

                        seat.Click -= Seat_Click; // Prevent duplicate binding
                        seat.Click += Seat_Click;
                        
                        // Add hover effects
                        seat.MouseEnter += Seat_MouseEnter;
                        seat.MouseLeave += Seat_MouseLeave;
                    }
                }
            }
        }

        // Method to programmatically add image boxes to a panel
        private void AddImageBoxesToPanel(Panel panel, int rows, int cols, string prefix = "pic")
        {
            if (panel == null) return;

            panel.Controls.Clear(); // Clear existing controls

            int seatWidth = 40;
            int seatHeight = 40;
            int spacing = 5;
            
            char[] rowNames = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for (int row = 0; row < rows && row < rowNames.Length; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    PictureBox seatPic = new PictureBox
                    {
                        Name = $"{prefix}{rowNames[row]}{col}",
                        Size = new Size(seatWidth, seatHeight),
                        Location = new Point(
                            col * (seatWidth + spacing),
                            row * (seatHeight + spacing)
                        ),
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,
                        Tag = $"{rowNames[row]}{col}"
                    };

                    // Add event handlers
                    seatPic.Click += Seat_Click;
                    seatPic.MouseEnter += Seat_MouseEnter;
                    seatPic.MouseLeave += Seat_MouseLeave;

                    panel.Controls.Add(seatPic);
                }
            }
        }

        private void Seat_MouseEnter(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;
            if (seat != null && seat.Enabled && seat.BackColor != Color.LightGreen)
            {
                seat.BackColor = Color.LightBlue; // Hover color
            }
        }

        private void Seat_MouseLeave(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;
            if (seat != null && seat.Enabled && seat.BackColor != Color.LightGreen)
            {
                seat.BackColor = Color.LightGray; // Default color
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
                               AND seat_type = 'Upper Box' 
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

            // Reset all seats in all panels to default state
            ResetAllSeatsToDefault(panelSeats);
            
            // Check if there's a second panel and reset it too
            Panel secondPanel = this.Controls.Find("panelSeats1", true).FirstOrDefault() as Panel;
            if (secondPanel != null)
            {
                ResetAllSeatsToDefault(secondPanel);
            }

            selectedSeats.Clear();
            selectedSeats.Add(seatId);
            clickedSeat.BackColor = Color.LightGreen;

            // Update label - make sure lblSelected exists
            if (lblSelected != null)
            {
                lblSelected.Text = "Selected: Upper Box-" + seatId;
            }
            else
            {
                MessageBox.Show("lblSelected control not found!");
            }
        }

        private void ResetAllSeatsToDefault(Panel panel)
        {
            if (panel == null) return;

            foreach (Control control in panel.Controls)
            {
                if (control is PictureBox seat && seat.Enabled)
                {
                    if (seat.BackColor != Color.Red) // Don't change reserved seats
                        seat.BackColor = Color.LightGray;
                }
            }
        }

        private void lblSelected_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

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
            decimal upperBoxPrice = GetUpperBoxPriceFromDatabase();

            // Check if seat is already reserved before proceeding to checkout
            try
            {
                db.OpenConnection();
                
                string checkQuery = @"SELECT is_reserved FROM tbl_seats 
                                    WHERE concert_id = @concertId 
                                    AND seat_type = 'Upper Box' 
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
                frmCheckOut checkoutForm = new frmCheckOut("Upper Box", selectedSeatId, upperBoxPrice);
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

        private decimal GetUpperBoxPriceFromDatabase()
        {
            decimal price = 1500.00m; // default fallback
            
            try
            {
                db.OpenConnection();
                string query = "SELECT price_upper_box FROM concert_events WHERE id = @concertId";
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
                MessageBox.Show("Error getting Upper Box price: " + ex.Message);
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

        private void panelSeats1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Method to initialize additional seats programmatically
        private void InitializeAdditionalSeats()
        {
            // Example: Add seats to a panel programmatically
            // AddImageBoxesToPanel(panelSeats, 3, 5, "pic"); // 3 rows, 5 columns
        }

        // Individual seat click handlers for main panel seats
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

        // Individual seat click handlers for second panel seats (R-series)
        private void picRA1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRA2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRA3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRB1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRB2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRB3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRC1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRC3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRD1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRD3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRE1_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRE2_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
        private void picRE3_Click(object sender, EventArgs e) { Seat_Click(sender, e); }
    }
}
