using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace conseat
{
    public partial class frmCustomHome : Form
    {
        private User _currentUser;

        public frmCustomHome(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }


        // Set default sort options
        private void SetupSortOptions()
        {
            cmbSort.Items.Clear();
            cmbSort.Items.AddRange(new string[] { "A-Z", "Z-A", "Time" });
            cmbSort.SelectedIndex = 0;
        }

        // Load a UserControl into the main panel (if needed elsewhere)
        private void LoadControl(UserControl control)
        {
            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }

        // Load dashboard layout and refresh concert data
        private void LoadConcertDashboard()
        {
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(flpConcerts);

            SetupSortOptions();
            RefreshConcerts();
        }

        // Load concerts from database with optional filters
        private void LoadConcerts(string keyword = "", string sort = "")
        {
            flpConcerts.Controls.Clear(); // Clear current concert cards

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            // Build SQL query with filters
            List<string> filters = new List<string>();
            string baseQuery = "SELECT id, artist_name, image FROM concert_events";

            if (!string.IsNullOrEmpty(keyword))
                filters.Add("artist_name LIKE @keyword");

            string query = baseQuery;
            if (filters.Count > 0)
                query += " WHERE " + string.Join(" AND ", filters);

            // Apply sorting
            switch (sort)
            {
                case "A-Z":
                    query += " ORDER BY artist_name ASC";
                    break;
                case "Z-A":
                    query += " ORDER BY artist_name DESC";
                    break;
                case "Time":
                    query += " ORDER BY event_time ASC";
                    break;
                default:
                    query += " ORDER BY artist_name ASC";
                    break;
            }

            // Fetch data from database
            try
            {
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract concert info
                            string id = reader["id"].ToString();
                            string artistName = reader["artist_name"].ToString();
                            Image image = Properties.Resources.back_svgrepo_com1;

                            if (!reader.IsDBNull(reader.GetOrdinal("image")))
                            {
                                byte[] imgBytes = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    image = Image.FromStream(ms);
                                }
                            }

                            // Create and configure card
                            var card = new ucCustomerConcertCard();
                            card.SetData(id, artistName, image);

                            // Handle Buy button click
                            card.OnBuyClicked += (s, e) =>
                            {
                                MessageBox.Show($"You clicked Buy for {artistName}");
                                // You can redirect to ticket details page here
                            };

                            flpConcerts.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading concerts: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Refresh concert list with search and sort options
        private void RefreshConcerts()
        {
            string keyword = txtSearch.Text.Trim();
            string sortOption = cmbSort.SelectedItem?.ToString() ?? "A-Z";
            LoadConcerts(keyword, sortOption);
        }

        // Logo click reloads dashboard
        private void picLogo_Click(object sender, EventArgs e)
        {
            LoadConcertDashboard();
        }

        // Logout 
        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        // Text search updates concerts in real-time
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshConcerts();
        }

        // Sort dropdown
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshConcerts();
        }

        
        private void pnlMainContent_Paint(object sender, PaintEventArgs e) { }

        
        private void Form3_Load(object sender, EventArgs e) {

            SetupSortOptions();
            LoadConcertDashboard();
        }
    }
}
