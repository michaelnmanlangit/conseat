using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace conseat
{
    public partial class frmSelectVip : Form
    {
        private DBConnection db = new DBConnection();
        List<string> selectedSeats = new List<string>();

        public frmSelectVip()
        {
            InitializeComponent();
        }

        private void frmSelectVip_Load(object sender, EventArgs e)
        {
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

            // Check DB connection once on load
            try
            {
                db.OpenConnection();
                MessageBox.Show("Database connected successfully!");
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        private bool IsSeatReserved(string seatId)
        {
            bool reserved = false;
            try
            {
                db.OpenConnection();
                string query = "SELECT is_reserved FROM tbl_vip_seats WHERE seat_id = @seatId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
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

            lblSelected.Text = "Selected: " + seatId;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select a seat first.", "No Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSeatId = selectedSeats[0]; // Only one selection at a time

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=concertdb"))
                {
                    conn.Open();
                    string query = "UPDATE tbl_vip_seats SET is_reserved = TRUE WHERE seat_id = @seatId AND is_reserved = FALSE";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@seatId", selectedSeatId);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Seat reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshSeats();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reserve the seat. It may already be reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void RefreshSeats()
        {
            foreach (Control control in panelSeats.Controls)
            {
                if (control is PictureBox seat)
                {
                    string seatId = seat.Name.Substring(3);

                    if (IsSeatReserved(seatId))
                    {
                        seat.BackColor = Color.Red;
                        seat.Enabled = false;
                        seat.Click -= Seat_Click;
                    }
                    else
                    {
                        seat.BackColor = Color.LightGray;
                        seat.Enabled = true;

                        seat.Click -= Seat_Click; // Remove before adding to prevent multiple handlers
                        seat.Click += Seat_Click;
                    }
                }
            }

            selectedSeats.Clear();
            lblSelected.Text = "Selected:";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // (Your code here if needed)
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // (Your code here if needed)
        }
    }
}



