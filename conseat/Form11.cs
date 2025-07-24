using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace conseat
{
    public partial class frmSendPayment : Form
    {
        private string paymentMethod;
        private string seatType;
        private string seatId;
        private decimal price;
        private DBConnection db = new DBConnection();
        private string placeholderText = "";

        // Static event to notify other forms about seat reservation updates
        public static event Action<string, string, string> SeatReserved;

        // Constructor with parameters from payment method form
        public frmSendPayment(string paymentMethod, string seatType, string seatId, decimal price)
        {
            InitializeComponent();
            this.paymentMethod = paymentMethod;
            this.seatType = seatType;
            this.seatId = seatId;
            this.price = price;
        }

        // Default constructor
        public frmSendPayment()
        {
            InitializeComponent();
        }

        private void frmGcash_Load(object sender, EventArgs e)
        {
            // Set up the form based on payment method
            if (!string.IsNullOrEmpty(paymentMethod))
            {
                lblPayment.Text = $"Send to {paymentMethod}";
                
                // Set placeholder text and validation based on payment method
                switch (paymentMethod.ToLower())
                {
                    case "gcash":
                        placeholderText = "Enter GCash number (09XXXXXXXXX)";
                        break;
                    case "paymaya":
                        placeholderText = "Enter PayMaya number (09XXXXXXXXX)";
                        break;
                    case "credit card":
                        placeholderText = "Enter card number (XXXX-XXXX-XXXX-XXXX)";
                        break;
                    default:
                        placeholderText = "Enter payment details";
                        break;
                }
            }
            else
            {
                lblPayment.Text = "Send Payment";
                placeholderText = "Enter payment details";
            }

            // Set placeholder text manually for .NET Framework compatibility
            SetPlaceholder();

            // Set focus to text box
            txtNumber.Focus();

            // Add event handlers
            picBack.Click += picBack_Click;
            txtNumber.KeyPress += txtNumber_KeyPress;
            txtNumber.Enter += txtNumber_Enter;
            txtNumber.Leave += txtNumber_Leave;

            // Initialize send button state
            btnSend.Enabled = false;
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                txtNumber.Text = placeholderText;
                txtNumber.ForeColor = Color.Gray;
            }
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            if (txtNumber.Text == placeholderText)
            {
                txtNumber.Text = "";
                txtNumber.ForeColor = Color.Black;
            }
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                txtNumber.Text = placeholderText;
                txtNumber.ForeColor = Color.Gray;
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back? Your payment process will be cancelled.",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }

        private void ProcessPayment()
        {
            // Get actual input text (not placeholder)
            string inputText = txtNumber.Text == placeholderText ? "" : txtNumber.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter your payment details.", "Missing Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.Focus();
                return;
            }

            // Validate number format based on payment method
            if (!IsValidPaymentNumber(inputText))
            {
                return;
            }

            // Show confirmation dialog with payment details
            string confirmationMessage = $"Confirm Payment Details:\n\n" +
                                       $"Payment Method: {paymentMethod}\n" +
                                       $"Account/Number: {inputText}\n" +
                                       $"Seat: {seatType}-{seatId}\n" +
                                       $"Amount: ₱{price:N2}\n\n" +
                                       $"Proceed with payment?";

            DialogResult confirm = MessageBox.Show(confirmationMessage, "Confirm Payment", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Disable the send button to prevent double submission
                btnSend.Enabled = false;
                btnSend.Text = "Processing...";

                // Process the payment
                if (SavePaymentToDatabase(inputText))
                {
                    ShowPaymentSuccess();
                }
                else
                {
                    // Re-enable button if payment failed
                    btnSend.Enabled = true;
                    btnSend.Text = "Send";
                }
            }
        }

        private bool IsValidPaymentNumber(string number)
        {
            string cleanNumber = number.Replace("-", "").Replace(" ", "");

            switch (paymentMethod.ToLower())
            {
                case "gcash":
                case "paymaya":
                    // Validate Philippine mobile number format
                    if (!cleanNumber.StartsWith("09") || cleanNumber.Length != 11)
                    {
                        MessageBox.Show("Please enter a valid Philippine mobile number (09XXXXXXXXX).", 
                            "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumber.Focus();
                        return false;
                    }
                    break;
                case "credit card":
                    // Basic credit card validation (13-19 digits)
                    if (cleanNumber.Length < 13 || cleanNumber.Length > 19 || !cleanNumber.All(char.IsDigit))
                    {
                        MessageBox.Show("Please enter a valid credit card number.", 
                            "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumber.Focus();
                        return false;
                    }
                    break;
            }

            return true;
        }

        private bool SavePaymentToDatabase(string paymentNumber)
        {
            try
            {
                db.OpenConnection();

                // First, ensure the payments table exists
                CreatePaymentTableIfNotExists();

                // Insert payment record
                string paymentQuery = @"INSERT INTO tbl_payments 
                                      (user_id, concert_id, seat_type, seat_id, payment_method, 
                                       payment_number, amount, payment_date, payment_status) 
                                      VALUES (@userId, @concertId, @seatType, @seatId, @paymentMethod, 
                                             @paymentNumber, @amount, @paymentDate, 'Completed')";

                MySqlCommand paymentCmd = new MySqlCommand(paymentQuery, db.GetConnection());
                paymentCmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUser.Id);
                paymentCmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                paymentCmd.Parameters.AddWithValue("@seatType", seatType);
                paymentCmd.Parameters.AddWithValue("@seatId", seatId);
                paymentCmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                paymentCmd.Parameters.AddWithValue("@paymentNumber", paymentNumber);
                paymentCmd.Parameters.AddWithValue("@amount", price);
                paymentCmd.Parameters.AddWithValue("@paymentDate", DateTime.Now);

                int paymentResult = paymentCmd.ExecuteNonQuery();

                if (paymentResult > 0)
                {
                    // NOW reserve the seat in database (only after successful payment)
                    if (ReserveSeatInDatabase())
                    {
                        // Notify all open forms about the seat reservation
                        SeatReserved?.Invoke(SessionManager.CurrentConcertId, seatType, seatId);
                        return true;
                    }
                    else
                    {
                        // If seat reservation fails, we should ideally rollback the payment
                        // For now, we'll just log this issue
                        MessageBox.Show("Payment recorded but seat reservation failed. Please contact support.", 
                                      "Partial Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message, "Payment Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private bool ReserveSeatInDatabase()
        {
            try
            {
                // Check if seat already exists and is reserved
                string checkQuery = @"SELECT id, is_reserved FROM tbl_seats 
                                    WHERE concert_id = @concertId 
                                    AND seat_type = @seatType 
                                    AND seat_id = @seatId";
                                    
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                checkCmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                checkCmd.Parameters.AddWithValue("@seatType", seatType);
                checkCmd.Parameters.AddWithValue("@seatId", seatId);
                
                MySqlDataReader reader = checkCmd.ExecuteReader();
                
                if (reader.Read())
                {
                    // Seat exists, check if it's already reserved
                    bool isReserved = Convert.ToBoolean(reader["is_reserved"]);
                    reader.Close();
                    
                    if (isReserved)
                    {
                        MessageBox.Show("This seat was just reserved by another user.", "Seat Unavailable", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    
                    // Update existing seat to reserved
                    string updateQuery = @"UPDATE tbl_seats 
                                         SET is_reserved = TRUE, user_id = @userId
                                         WHERE concert_id = @concertId 
                                         AND seat_type = @seatType 
                                         AND seat_id = @seatId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.GetConnection());
                    updateCmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUser.Id);
                    updateCmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                    updateCmd.Parameters.AddWithValue("@seatType", seatType);
                    updateCmd.Parameters.AddWithValue("@seatId", seatId);

                    return updateCmd.ExecuteNonQuery() > 0;
                }
                else
                {
                    reader.Close();
                    
                    // Seat doesn't exist, create new seat record as reserved
                    string insertQuery = @"INSERT INTO tbl_seats (concert_id, user_id, seat_type, seat_id, is_reserved) 
                                         VALUES (@concertId, @userId, @seatType, @seatId, TRUE)";
                                         
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, db.GetConnection());
                    insertCmd.Parameters.AddWithValue("@concertId", SessionManager.CurrentConcertId);
                    insertCmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUser.Id);
                    insertCmd.Parameters.AddWithValue("@seatType", seatType);
                    insertCmd.Parameters.AddWithValue("@seatId", seatId);
                    
                    return insertCmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reserving seat: " + ex.Message, "Reservation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CreatePaymentTableIfNotExists()
        {
            try
            {
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS tbl_payments (
                                          id INT AUTO_INCREMENT PRIMARY KEY,
                                          user_id INT NOT NULL,
                                          concert_id VARCHAR(50) NOT NULL,
                                          seat_type VARCHAR(50) NOT NULL,
                                          seat_id VARCHAR(50) NOT NULL,
                                          payment_method VARCHAR(50) NOT NULL,
                                          payment_number VARCHAR(100) NOT NULL,
                                          amount DECIMAL(10,2) NOT NULL,
                                          payment_date DATETIME NOT NULL,
                                          payment_status VARCHAR(20) DEFAULT 'Completed',
                                          created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                                          )";

                MySqlCommand createCmd = new MySqlCommand(createTableQuery, db.GetConnection());
                createCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log the error but don't stop the payment process
                System.Diagnostics.Debug.WriteLine("Error creating payment table: " + ex.Message);
            }
        }

        private void ShowPaymentSuccess()
        {
            string successMessage = $"Payment Successful!\n\n" +
                                   $"Payment Method: {paymentMethod}\n" +
                                   $"Seat: {seatType}-{seatId}\n" +
                                   $"Amount: ₱{price:N2}\n" +
                                   $"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm")}\n\n" +
                                   $"Your ticket has been confirmed and the seat is now reserved!";

            MessageBox.Show(successMessage, "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to Thank You form (Form12) after successful payment
            NavigateToThanksForm();
        }

        private void NavigateToThanksForm()
        {
            try
            {
                // Create the thank you form
                frmThanks thanksForm = new frmThanks();

                // Set the thanks form to be topmost and centered
                thanksForm.TopMost = true;
                thanksForm.StartPosition = FormStartPosition.CenterScreen;
                thanksForm.WindowState = FormWindowState.Normal;

                // Show the thanks form FIRST
                thanksForm.Show();
                
                // Force it to be on top and focused
                thanksForm.BringToFront();
                thanksForm.Activate();
                thanksForm.Focus();

                // Close ALL forms in the entire reservation/checkout chain
                // This includes ALL forms except the main dashboard and the thanks form
                Form[] allOpenForms = Application.OpenForms.Cast<Form>().ToArray();
                
                foreach (Form form in allOpenForms)
                {
                    // Close forms by type name to be more specific
                    string formTypeName = form.GetType().Name;
                    
                    if (formTypeName == "frmConcertDetails" ||      // Form4 - Concert Details
                        formTypeName == "frmSelectSeat" ||          // Form5 - Seat Selection
                        formTypeName == "frmSelectVip" ||           // Form6 - VIP Selection  
                        formTypeName == "frmCheckOut" ||            // Form7 - Checkout
                        formTypeName == "frmSelectUpper" ||         // Form8 - Upper Box Selection
                        formTypeName == "frmSelectGenAd" ||         // Form9 - General Admission Selection
                        formTypeName == "frmPaymentMethod" ||       // Form10 - Payment Method
                        formTypeName == "frmSendPayment" ||         // Form11 - Send Payment
                        form.Name.Contains("Payment") || 
                        form.Name.Contains("Select") || 
                        form.Name.Contains("CheckOut") ||
                        form.Name.Contains("Concert") ||
                        form == this)
                    {
                        if (form != thanksForm) // Don't close the thanks form
                        {
                            try
                            {
                                form.Close();
                            }
                            catch (Exception ex)
                            {
                                // Log but don't stop the process
                                System.Diagnostics.Debug.WriteLine($"Error closing form {form.Name}: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment completed successfully, but there was an error navigating to the confirmation page: {ex.Message}", 
                              "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                // Fallback: navigate to home
                NavigateToHome();
            }
        }

        private void NavigateToHome()
        {
            // Try to find an existing customer form or main form
            foreach (Form form in Application.OpenForms)
            {
                // Look for any main form that's not a dialog
                if (form.Name.Contains("Custom") || form.Name.Contains("Main") || form.Name.Contains("Home"))
                {
                    form.Show();
                    form.BringToFront();
                    this.Close();
                    return;
                }
            }

            // If no suitable form found, just close this form
            MessageBox.Show("Payment completed successfully. The seat has been reserved and you can now close this window.", 
                          "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event - no specific functionality needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Enable/disable send button based on input (excluding placeholder text)
            string currentText = txtNumber.Text;
            btnSend.Enabled = !string.IsNullOrWhiteSpace(currentText) && currentText != placeholderText;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle Enter key press to submit payment
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (btnSend.Enabled)
                {
                    ProcessPayment();
                }
            }

            // For credit card, allow digits, spaces, and dashes
            if (paymentMethod?.ToLower() == "credit card")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            // For mobile payments, allow only digits
            else if (paymentMethod?.ToLower() == "gcash" || paymentMethod?.ToLower() == "paymaya")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
