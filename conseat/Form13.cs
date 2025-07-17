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



        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
          
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
    }
}
