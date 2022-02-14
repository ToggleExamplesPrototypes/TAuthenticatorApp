using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TAuthenticatorApp
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            CenterToScreen();
            tmrA1.Start();
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = /*ABCDEFGHIJKLMNOPQRSTUVWXYZ*/"0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            new LandingPageNoSignup().Show();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void tmrA1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            lbAcc1Code.Text = RandomString(6);
            label2.Text = RandomString(6);
            label4.Text = RandomString(6);
            label6.Text = RandomString(6);
            label8.Text = RandomString(6);
            label10.Text = RandomString(6);
            label12.Text = RandomString(6);
            label14.Text = RandomString(6);
            label16.Text = RandomString(6);
            label18.Text = RandomString(6);
            label20.Text = RandomString(6);
            label22.Text = RandomString(6);
        }
    }
}
