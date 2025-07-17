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
    public partial class frmCustomerHome : Form
    {
        private User _currentUser;

        public frmCustomerHome(User user)
        {
            InitializeComponent();

            _currentUser = user;
            lblWelcome.Text = $"Hi, {user.Email}!\nRole: {user.Role}";
        }


        private void frmCustomerHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
