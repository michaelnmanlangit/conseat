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
            
            // Ensure the form is on top
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
            
            // Set focus to prevent any control from being highlighted
            this.Focus();

            // Close any remaining reservation forms that might still be open
            SessionManager.CloseAllReservationForms(this);

            // Set simple thank you message
            SetSimpleThankYouMessage();
            
            // Remove TopMost after a short delay so it doesn't stay always on top
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, args) =>
            {
                this.TopMost = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void SetSimpleThankYouMessage()
        {
           
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
                // Hide current form first to prevent flickering
                this.Hide();
                
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
                
                // Close this form after showing the new one
                this.Close();
            }
            else
            {
                // User session expired, redirect to login
                MessageBox.Show("Your session has expired. Please login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        // Handle form closing event
        private void frmThanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear concert context when leaving thank you page
            // Don't clear user session as they might want to continue shopping
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

                // Hide current form first
                this.Hide();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
