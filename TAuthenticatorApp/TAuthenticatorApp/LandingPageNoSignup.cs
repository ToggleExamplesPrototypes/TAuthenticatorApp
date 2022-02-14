using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TAuthenticatorApp
{
    public partial class LandingPageNoSignup : Form
    {
        public LandingPageNoSignup()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/ToggleCorp/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/ToggleCorp/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            new frmCredits().Show();
        }

        private void btnContinueNoAccount_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            new frmMainForm().Show();
        }
    }
}
