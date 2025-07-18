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

        private void LoadControl(UserControl control)
        {
            pnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(control);
        }


        private void LoadConcerts(string keyword = "")
        {
            flpConcerts.Controls.Clear();

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            string query = "SELECT id, artist_name, image FROM concert_events";

            if (!string.IsNullOrEmpty(keyword))
            {
                query += " WHERE artist_name LIKE @keyword";
            }

            try
            {
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ucConcertCard card = new ucConcertCard();
                            string id = reader["id"].ToString();
                            string artistName = reader["artist_name"].ToString();

                            Image image = null;

                            if (!reader.IsDBNull(reader.GetOrdinal("image")))
                            {
                                byte[] imgBytes = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                image = Properties.Resources.back_svgrepo_com1; // or any default
                            }

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


        private void EditConcert(string concertID)
        {
            LoadControl(new ucCreateEvent(concertID));

        }

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
                    LoadConcerts(); // Refresh after deletion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting concert: " + ex.Message);
                }
            }
        }


        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadConcerts();
            picLogo.Image = Properties.Resources.logo;
        }

        




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)

        {
            LoadControl(new ucCreateEvent());



            
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            LoadControl(new ucManageSales());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadControl(new ucReports());
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void piclogo_Click(object sender, EventArgs e)
        {

        }
    }
}
