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

        }

        private void btnProceedPayment_Click(object sender, EventArgs e)
        {
            frmPaymentMethod paymentForm = new frmPaymentMethod(seatType, seatId, price);
            this.Hide();
            paymentForm.ShowDialog();
            this.Close();
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
