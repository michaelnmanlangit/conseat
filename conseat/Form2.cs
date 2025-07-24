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
    public partial class frmSignUp : Form
    {

        public frmSignUp()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            picEyeOpen.Visible = false;
            picEyeClosed.Visible = true;

            txtConfirmPassword.UseSystemPasswordChar = true;
            picConfirmEyeOpen.Visible = false;
            picConfirmEyeClosed.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = PasswordHelper.HashPassword(password);

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "INSERT INTO users (first_name, middle_name, last_name, email, password, role) " +
                               "VALUES (@fn, @mn, @ln, @em, @pw, @role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@mn", middleName);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@pw", hashedPassword);
                cmd.Parameters.AddWithValue("@role", "Customer"); // Always register as Customer

                cmd.ExecuteNonQuery();
                MessageBox.Show("Account created successfully!");
                this.Close();
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

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picEyeOpen_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeOpen.Visible = false;
            picEyeClosed.Visible = true;
        }

        private void picEyeClosed_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picEyeClosed.Visible = false;
            picEyeOpen.Visible = true;
        }

        private void picConfirmEyeOpen_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
            picConfirmEyeOpen.Visible = false;
            picConfirmEyeClosed.Visible = true;
        }

        private void picConfirmEyeClosed_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
            picConfirmEyeClosed.Visible = false;
            picConfirmEyeOpen.Visible = true;
        }
    }
    
}
