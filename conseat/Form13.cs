using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conseat
{
    public partial class frmAdminDashboard : Form
    {
        private User _currentUser;

        public frmAdminDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        //form dashboard load
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

            SetupSortOptions();
            LoadConcertDashboard();
        }

        //sort options in the combo box
        private void SetupSortOptions()
        {
            cmbSort.Items.Clear();
            cmbSort.Items.AddRange(new string[] { "A-Z", "Z-A", "Time" });
            cmbSort.SelectedIndex = 0;
        }

        //load a user control into the main content panel
        private void LoadControl(UserControl control)
        {
            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }
        //load the concert dashboard
        private void LoadConcertDashboard()
        {
            pnlMainContent.Controls.Clear();

            pnlMainContent.Controls.Add(lblTitle);
            pnlMainContent.Controls.Add(txtSearch);
            pnlMainContent.Controls.Add(cmbSort);
            pnlMainContent.Controls.Add(flpConcerts);

            SetupSortOptions();
            LoadConcerts();
        }
        //logoclick to load the concert dashboard
        private void piclogo_Click(object sender, EventArgs e)
        {
            LoadConcertDashboard(); // Logo click → go home
        }
        // Button click events to create new concert 
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCreateEvent());
        }
        // Button click event to manage users
        private void btnManageSales_Click(object sender, EventArgs e)
        {
            LoadControl(new ucManageSales());
        }

        // Method to load concerts with keyword and sorting
        private void LoadConcerts(string keyword = "", string sort = "")
        {
            flpConcerts.Controls.Clear();

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            List<string> filters = new List<string>();
            string baseQuery = "SELECT id, artist_name, image FROM concert_events";

            if (!string.IsNullOrEmpty(keyword))
            {
                filters.Add("artist_name LIKE @keyword");
            }

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
                    query = baseQuery;
                    if (filters.Count > 0)
                        query += " WHERE " + string.Join(" AND ", filters);

                    query += " ORDER BY event_time ASC";
                    break;
                default:
                    query += " ORDER BY artist_name ASC";
                    break;
            }

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

                            var card = new ucConcertCard();
                            card.SetData(id, artistName, image);
                            card.OnEditClicked += (s, e) => EditConcert(card.ConcertID);
                            card.OnDeleteClicked += (s, e) => DeleteConcert(card.ConcertID);

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
        // Method to edit a concert
        private void EditConcert(string concertID)
        {
            LoadControl(new ucCreateEvent(concertID));
        }
        // Method to delete a concert
        private void DeleteConcert(string concertID)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this concert?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DBConnection db = new DBConnection();
                    db.OpenConnection();

                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM concert_events WHERE id = @id", db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", concertID);
                        cmd.ExecuteNonQuery();
                    }

                    db.CloseConnection();
                    LoadConcerts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting concert: " + ex.Message);
                }
            }
        }

        //search and sort events
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshConcerts();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshConcerts();
        }

        private void RefreshConcerts()
        {
            string keyword = txtSearch.Text.Trim();
            string sortOption = cmbSort.SelectedItem?.ToString() ?? "A-Z";
            LoadConcerts(keyword, sortOption);
        }

        // Logout button
        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.ClearSession();
                this.Close(); // This will trigger the FormClosed event in login form to show it again
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e) {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e) {
        
        }
    }
}
