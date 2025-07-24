using System;
using System.Windows.Forms;

namespace conseat
{
    // INHERITANCE: frmThanks inherits from Form
    public partial class frmThanks : Form
    {
        // ENCAPSULATION: Private fields to hide internal state
        private Timer _autoRedirectTimer;
        private readonly IUserNotificationService _notificationService;
        private bool _disposed = false;

        // ENCAPSULATION: Public properties with controlled access
        public int AutoRedirectSeconds { get; set; } = 30;
        public bool IsAutoRedirectEnabled { get; set; } = false;

        // ABSTRACTION: Constructor abstracts initialization complexity
        public frmThanks()
        {
            InitializeComponent();
            
            // POLYMORPHISM: Using interface for flexible notification service
            _notificationService = new UserNotificationService();
            
            InitializeEventHandlers();
        }

        // ENCAPSULATION: Private method to encapsulate event handler setup
        private void InitializeEventHandlers()
        {
            this.picHome.Click += PicHome_Click;
            this.lnkBuy.LinkClicked += LnkBuy_LinkClicked;
            this.Load += FrmThanks_Load;
            this.FormClosing += FrmThanks_FormClosing;
        }

        // ABSTRACTION: High-level form loading process
        private void FrmThanks_Load(object sender, EventArgs e)
        {
            ConfigureFormAppearance();
            CleanupPreviousForms();
            DisplayThankYouMessage();
            
            if (IsAutoRedirectEnabled)
            {
                StartAutoRedirectTimer();
            }
        }

        // ENCAPSULATION: Private method to configure form appearance
        private void ConfigureFormAppearance()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
            this.Focus();

            // Remove TopMost after delay
            var topMostTimer = new Timer { Interval = 1000 };
            topMostTimer.Tick += (s, args) =>
            {
                this.TopMost = false;
                topMostTimer.Stop();
                topMostTimer.Dispose();
            };
            topMostTimer.Start();
        }

        // ABSTRACTION: Abstract form cleanup
        private void CleanupPreviousForms()
        {
            SessionManager.CloseAllReservationForms(this);
        }

        // ABSTRACTION: Abstract message display
        private void DisplayThankYouMessage()
        {
            if (SessionManager.CurrentUser != null)
            {
                // POLYMORPHISM: Different messages based on user type
                var personalizedMessage = SessionManager.CurrentUser.GetUserTypeDescription() == "System Administrator"
                    ? "Thank you for managing the system!"
                    : "Thank you for your purchase!";
                
                // Could display personalized message in a label
                // this.lblMessage.Text = personalizedMessage;
            }
        }

        // ENCAPSULATION: Event handler with validation
        private void PicHome_Click(object sender, EventArgs e)
        {
            if (_notificationService.ShowConfirmation("Are you sure you want to go to home?", "Go to Home"))
            {
                NavigateToUserHome();
            }
        }

        // ENCAPSULATION: Event handler with validation  
        private void LnkBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_notificationService.ShowConfirmation("Would you like to buy more tickets?", "Buy More Tickets"))
            {
                NavigateToUserHome();
            }
        }

        // ABSTRACTION: High-level navigation method
        private void NavigateToUserHome()
        {
            if (SessionManager.IsUserLoggedIn())
            {
                SessionManager.NavigateToUserHome(this);
            }
            else
            {
                HandleSessionExpired();
            }
        }

        // ENCAPSULATION: Private method to handle session expiration
        private void HandleSessionExpired()
        {
            _notificationService.ShowInformation("Your session has expired. Please login again.", "Session Expired");
            SessionManager.NavigateToLogin(this);
        }

        // ENCAPSULATION: Private timer management
        private void StartAutoRedirectTimer()
        {
            _autoRedirectTimer = new Timer { Interval = AutoRedirectSeconds * 1000 };
            _autoRedirectTimer.Tick += AutoRedirectTimer_Tick;
            _autoRedirectTimer.Start();
        }

        // ENCAPSULATION: Private event handler for auto-redirect
        private void AutoRedirectTimer_Tick(object sender, EventArgs e)
        {
            _autoRedirectTimer?.Stop();
            
            if (_notificationService.ShowConfirmation(
                "Would you like to continue shopping or go to home?",
                "Session Timeout"))
            {
                NavigateToUserHome();
            }
            else
            {
                this.Close();
            }
        }

        // ABSTRACTION: Public method to enable auto-redirect
        public void EnableAutoRedirect(int seconds = 30)
        {
            AutoRedirectSeconds = seconds;
            IsAutoRedirectEnabled = true;
        }

        // ABSTRACTION: Public method for logout
        public void InitiateLogout()
        {
            if (_notificationService.ShowConfirmation("Are you sure you want to logout?", "Logout Confirmation"))
            {
                SessionManager.NavigateToLogin(this);
            }
        }

        // ENCAPSULATION: Clean resource disposal
        private void FrmThanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeResources();
        }

        // ENCAPSULATION: Internal cleanup method (accessible by designer)
        internal void DisposeResources()
        {
            if (!_disposed)
            {
                _autoRedirectTimer?.Stop();
                _autoRedirectTimer?.Dispose();
                _disposed = true;
            }
        }

        // Required empty event handlers for designer compatibility
        private void lnkBuy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LnkBuy_LinkClicked(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty implementation for designer compatibility
        }
    }

    // ABSTRACTION: Interface for user notification services
    public interface IUserNotificationService
    {
        bool ShowConfirmation(string message, string title);
        void ShowInformation(string message, string title);
        void ShowError(string message, string title);
    }

    // INHERITANCE: Implements IUserNotificationService
    // ENCAPSULATION: Encapsulates MessageBox complexity
    public class UserNotificationService : IUserNotificationService
    {
        // POLYMORPHISM: Different notification types with consistent interface
        public bool ShowConfirmation(string message, string title)
        {
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public void ShowInformation(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
