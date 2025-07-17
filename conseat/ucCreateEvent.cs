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
    public partial class ucCreateEvent : UserControl
    {
        public ucCreateEvent()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
                    cmbVenue.Items.AddRange(new string[] {
            "Smart Araneta Coliseum",
            "Philippine Arena",
            "Mall of Asia Arena"
        });
        }
    }
}
