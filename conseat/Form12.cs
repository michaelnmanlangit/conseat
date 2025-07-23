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
    public partial class frmThanks : Form
    {
        public frmThanks()
        {
            InitializeComponent();
            
            // Wire up event handlers for the controls
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.lnkBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBuy_LinkClicked);
            this.Load += new System.EventHandler(this.frmThanks_Load);
        }

        private void frmThanks_Load(object sender, EventArgs e)
        {
            // Center the form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Set focus to prevent any control from being highlighted
            this.Focus();

            // If no custom message has been set, show default message
            if (label1.Text == "Thank You!")
            {
                SetDefaultThankYouMessage();
            }
        }

        private void SetDefaultThankYouMessage()
        {
            if (SessionManager.CurrentUser != null)
            {
                string userType = SessionManager.CurrentUser.Role == "Admin" ? "Admin" : "Customer";
                label1.Text = $"Thank You!\n\nYour transaction has been completed successfully.\n\nWelcome {userType}: {SessionManager.CurrentUser.Email}";
            }
            else
            {
                label1.Text = "Thank You!\n\nYour transaction has been completed successfully.";
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to home?", 
                "Go to Home", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NavigateToUserHome();
            }
        }

        private void lnkBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Would you like to buy more tickets?", 
                "Buy More Tickets", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NavigateToUserHome();
            }
        }

        private void NavigateToUserHome()
        {
            // Check if user is still logged in
            if (SessionManager.CurrentUser != null)
            {
                // Navigate back to the appropriate dashboard based on user role
                if (SessionManager.CurrentUser.Role == "Admin")
                {
                    frmAdminDashboard adminDashboard = new frmAdminDashboard(SessionManager.CurrentUser);
                    adminDashboard.Show();
                }
                else
                {
                    frmCustomHome customerHome = new frmCustomHome(SessionManager.CurrentUser);
                    customerHome.Show();
                }
                
                this.Close();
            }
            else
            {
                // User session expired, redirect to login
                MessageBox.Show("Your session has expired. Please login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                
                this.Close();
            }
        }

        // Method to display transaction details after payment
        public void SetTransactionDetails(string transactionId, string eventName, int ticketCount, decimal totalAmount)
        {
            // Enhance the thank you message with transaction details
            string message = "Thank You for Your Purchase!\n\n" +
                           "Your payment has been processed successfully.\n\n" +
                           $"Transaction Details:\n" +
                           $"Transaction ID: {transactionId}\n" +
                           $"Event: {eventName}\n" +
                           $"Tickets: {ticketCount}\n" +
                           $"Total Amount: ₱{totalAmount:N2}\n" +
                           $"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm")}\n\n" +
                           "Your seat has been reserved and you will receive a confirmation shortly.";

            label1.Text = message;
            
            // Make the label multi-line and adjust font size if needed
            label1.AutoSize = false;
            label1.Size = new Size(280, 250);
            label1.TextAlign = ContentAlignment.TopCenter;
            
            // Adjust font size if text is too long
            if (message.Length > 200)
            {
                label1.Font = new Font(label1.Font.FontFamily, 8, label1.Font.Style);
            }
        }

        // Method to set custom thank you message
        public void SetCustomMessage(string message)
        {
            label1.Text = message;
            label1.AutoSize = false;
            label1.Size = new Size(280, 200);
            label1.TextAlign = ContentAlignment.TopCenter;
        }

        // Handle form closing event
        private void frmThanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear concert context when leaving thank you page
            // Don't clear user session as they might want to continue shopping
        }

        // Method to show payment confirmation details
        public void ShowPaymentConfirmation(string paymentMethod, string seatInfo, decimal amount)
        {
            string message = "Payment Successful!\n\n" +
                           $"Payment Method: {paymentMethod}\n" +
                           $"Seat: {seatInfo}\n" +
                           $"Amount: ₱{amount:N2}\n" +
                           $"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm")}\n\n" +
                           "Thank you for your purchase!\n" +
                           "Your ticket confirmation will be sent to your email.";

            SetCustomMessage(message);
        }

        // Optional: Add logout functionality as a separate method
        public void LogoutUser()
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?", 
                "Logout Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear the current user session
                SessionManager.ClearSession();

                // Close all open forms except the main login form
                Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form form in openForms)
                {
                    if (form.Name != "frmLogin" && form != this)
                    {
                        form.Close();
                    }
                }

                // Show the login form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                
                this.Close();
            }
        }

        // Method to handle automatic timeout (optional)
        private Timer timeoutTimer;
        
        public void SetAutoRedirectTimer(int seconds = 30)
        {
            timeoutTimer = new Timer();
            timeoutTimer.Interval = seconds * 1000;
            timeoutTimer.Tick += (s, e) => {
                timeoutTimer.Stop();
                
                // Show countdown or direct redirect
                DialogResult result = MessageBox.Show(
                    "Would you like to continue shopping or go to home?",
                    "Session Timeout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    
                if (result == DialogResult.Yes)
                {
                    NavigateToUserHome();
                }
                else
                {
                    this.Close();
                }
            };
            timeoutTimer.Start();
        }

        private void lnkBuy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
