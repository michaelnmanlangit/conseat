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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            picEyeOpen.Visible = false;   // open eye hidden initially
            picEyeClosed.Visible = true;  // closed eye visible initially
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string hashedPassword = PasswordHelper.HashPassword(password);

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email=@em AND password=@pw";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@pw", hashedPassword);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    string userEmail = reader["email"].ToString();
                    int userId = Convert.ToInt32(reader["id"]);

                    User user;

                    if (role == "Admin")
                        user = new Admin();
                    else
                        user = new Customer();

                    user.Id = userId;
                    user.Email = userEmail;
                    user.Role = role;

                    // Set current user in session manager
                    SessionManager.CurrentUser = user;

                    MessageBox.Show(user.GetWelcomeMessage());

                    this.Hide(); // Hide instead of close to keep application running

                    if (role == "Admin")
                    {
                        frmAdminDashboard adminDashboard = new frmAdminDashboard(user);
                        adminDashboard.FormClosed += MainForm_FormClosed; // Handle when dashboard closes
                        adminDashboard.Show();
                    }
                    else
                    {
                        frmCustomHome customerHome = new frmCustomHome(user);
                        customerHome.FormClosed += MainForm_FormClosed; // Handle when home closes
                        customerHome.Show();
                    }
                    
                    // DON'T CLOSE - just hide so app keeps running
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Handle when main dashboard/home forms close - show login again or exit
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When the main form closes, show login again or exit
            this.Show();
            
            // Clear the session when returning to login
            SessionManager.ClearSession();
            
            // Clear the form fields for security
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SessionManager.ShowModalDialog(this, new frmSignUp());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picEyeOpen_Click(object sender, EventArgs e)
        {
            // Show password
            txtPassword.UseSystemPasswordChar = true;     // Hide password
            picEyeOpen.Visible = false;                   // Hide open eye
            picEyeClosed.Visible = true;                  // Show closed eye
        }

        private void picEyeClosed_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;    // Show password
            picEyeOpen.Visible = true;                    // Show open eye
            picEyeClosed.Visible = false;                 // Hide closed eye
        }
    }
}
