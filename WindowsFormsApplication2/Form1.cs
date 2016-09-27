using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void BTNZzzz_Click(object sender, EventArgs e)
        {
            LBLGreeting.Text = "Okay, it's nap time!!"; 
        }

        private void BTNSad_Click(object sender, EventArgs e)
        {
            LBLGreeting.Text = "Turn that frown upsidedown.(:";
        }

        private void BTNHappy_Click(object sender, EventArgs e)
        {
            LBLGreeting.Text = "Oh, so I guess you haven't read 'April Raintree'.";
        }

        private void BTNAngry_Click(object sender, EventArgs e)
        {
            LBLGreeting.Text = "Cool of before I put you in the freezer!";
        }
    }
}
