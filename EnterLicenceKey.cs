using System;
using System.Threading;
using System.Windows.Forms;

namespace SpotifyBot
{
    public partial class EnterLicenceKey : Form
    {
        public Form mainForm;
        public string Tier = "";
        public EnterLicenceKey(Form form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void btnActivateLicence_Click(object sender, EventArgs e)
        {

            if (((tbUsername.Text.Length ^ 5 * (8 + 0)) * 99).ToString() == tbLicence.Text)
            {
                mainForm.Text = "SpotifyBot - Basic";
                SpotifyBot.Tier = 0;
                MessageBox.Show("Tier Basic Licence Activated");
            }
            else if (((tbUsername.Text.Length ^ 5 * (8 + 1)) * 99).ToString() == tbLicence.Text)
            {
                mainForm.Text = "SpotifyBot - Tier I";
                SpotifyBot.Tier = 1;
                MessageBox.Show("Tier I Licence Activated");
            }
            else if (((tbUsername.Text.Length ^ 5 * (8 + 2)) * 99).ToString() == tbLicence.Text)
            {
                mainForm.Text = "SpotifyBot - Tier II";
                SpotifyBot.Tier = 2;
                MessageBox.Show("Tier II Licence Activated");
            }
            else if (((tbUsername.Text.Length ^ 5 * (8 + 3)) * 99).ToString() == tbLicence.Text)
            {
                mainForm.Text = "SpotifyBot - Unlimited";
                SpotifyBot.Tier = 3;
                MessageBox.Show("Illimited Licence Activated");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            Thread.Sleep(1000);
        }
    }
}
