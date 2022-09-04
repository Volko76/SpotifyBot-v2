using Microsoft.Dism;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SpotifyBot
{

    public partial class SpotifyBot : Form
    {
        public Form MainForm;
        string spotifyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Spotify\\Spotify.exe";
        string openVpnPath = "C:\\Program Files\\OpenVPN\\bin\\openvpn-gui.exe";
        string sandboxiePath = "C:\\Program Files\\Sandboxie-Plus\\Start.exe";
        string sandboxieSbiePath = "C:\\Program Files\\Sandboxie-Plus\\SbieIni.exe";
        string lastReaseach = "";
        public int sandboxNumber = 0;
        static public int Tier = 0; // 0 = basic (5 sandbox), 1 = premier tier (10 sandbox), 2 = deuxieme tier (30 sandbox), 3 = illimité
        //string[] Comptes = {};
        Dictionary<string, string> Comptes = new Dictionary<string, string>()
        {
        };
        int[] ListOfSpotifyLaunched = { };

        Click c = new Click();
        Point point = new Point();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,
                int nRightRect,
                int nTopRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
        


        public SpotifyBot()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnMusic.Height;
            PnlNav.Top = btnMusic.Top;
            PnlNav.Left = btnMusic.Left;
            btnMusic.BackColor = Color.FromArgb(46, 51, 73);
            MainForm = this;
            if (!File.Exists(spotifyPath))
            {
                InstallSpotify();
            }
            if (!File.Exists(openVpnPath))
            {
                InstallOpenVpn();
            }
            if (!File.Exists(sandboxiePath))
            {
                InstallSandboxie();
                MessageBox.Show("Please restart the app ...");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    sandboxNumber++;
                    Process.Start(sandboxieSbiePath, $"set spotify{i} Enabled y");
                    lbInstanceOfSpotify.Items.Add($"spotify{i}");
                }
            }
        }
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }
        private void btnResearch_Click(object sender, EventArgs e)
        {
            PlaySong(tbResearch.Text);
            /*if (tbResearch.Text != lastReaseach)
            {
                PlaySong(tbResearch.Text);
                lastReaseach = tbResearch.Text;
            }
            else
            {
                PowerShell.Create().AddCommand(spotifyPath)
                  .Invoke();
                Thread.Sleep(5000);
                SendKeys.SendWait("^({left})");

            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void PlaySong(string song)
        {
            if (lbComptes.Items.Count == 0)
            {
                MessageBox.Show("Veulliez ajouter un compte Spotify et le selectionner pour l'utiliser");
                return;
            }
            else
            {
                if (lbComptes.SelectedIndex == -1)
                {
                    MessageBox.Show("Veulliez selectionner un compte spotify !");
                    return;
                }
            }
            System.Diagnostics.Process.Start(sandboxiePath, $"/box:{lbInstanceOfSpotify.SelectedItem.ToString()} {spotifyPath} -uri={tbResearch.Text} --username={lbComptes.GetItemText(lbComptes.SelectedItem)} --password={Comptes[lbComptes.GetItemText(lbComptes.SelectedItem)]}");
            /*
            int i = 42;
            PowerShell.Create().AddCommand(sandboxiePath).AddParameter("/box", $"Spotify{i}").AddParameter("C:\\Users\\Volko\\AppData\\Roaming\\Spotify\\spotify.exe")
                   .AddParameter("-uri=", tbResearch.Text.ToString())
                  .Invoke();
            Thread.Sleep(5000);
            PlaySpotify();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Program Files\\OpenVPN\\config";
            openFileDialog1.Filter = "Fichier ovpn | *.ovpn";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Program Files\\OpenVPN\\bin\\openvpn-gui.exe",
                        Arguments = "--connect " + Path.GetFileName(selectedFileName),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = false,
                        WorkingDirectory = Path.GetDirectoryName(selectedFileName)
                    }
                };
                proc.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(spotifyPath);
        }



        void InstallSpotify()
        {
            MessageBox.Show("Nous allons installer Spotify dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://download.scdn.co/SpotifySetup.exe", "spotifyInstaller.exe");
            }
            Process.Start("spotifyInstaller.exe");
        }

        void InstallOpenVpn()
        {
            MessageBox.Show("Nous allons installer OpenVPN dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.7-I602-amd64.msi", "openvpnInstaller.msi");
            }
            Process.Start("openvpnInstaller.msi");
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(30000);
            ActivateApp("OpenVPN 2.5.7-I602");
            SendKeys.SendWait("{ENTER}");

            //Setup OpenVPN 2.5.7-I602
        }
        void InstallSandboxie()
        {
            MessageBox.Show("Nous allons installer Sandboxie dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://github.com/sandboxie-plus/Sandboxie/releases/download/v1.3.2/Sandboxie-Plus-x64-v1.3.2.exe", "sandboxieInstaller.exe");
            }
            Process.Start("sandboxieInstaller.exe", "/S");
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Tier.ToString());
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            listboxChansons.Items.Add(tbResearch.Text.ToString());
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            foreach (string item in listboxChansons.Items)
            {
                PlaySong(item);
                Thread.Sleep(5000);
            }
        }

        private void btnRemoveFromQueue_Click(object sender, EventArgs e)
        {
            foreach (string s in listboxChansons.SelectedItems.OfType<string>().ToList())
                listboxChansons.Items.Remove(s);
        }

        public void ViewProcess()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] list = Process.GetProcessesByName("Spotify");
            foreach (var process in list)
            {
                MessageBox.Show(process.ProcessName + process.Id.ToString());
            }
        }

        public void RecreateImageInProjectFolder(Image img, string name)
        {
            img.Save(Directory.GetCurrentDirectory() + $"//{name}.png");
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            Comptes.Add(tbUsername.Text, tbPassword.Text);
            lbComptes.Items.Add(tbUsername.Text);
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            Comptes.Remove(lbComptes.GetItemText(lbComptes.SelectedItem));
            lbComptes.Items.Remove(lbComptes.SelectedItem);
        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
            EnterLicenceKey enterLicenceKey = new EnterLicenceKey(this);
            enterLicenceKey.Show();
        }
        void AddInstance(int i)
        {
            Process.Start(sandboxieSbiePath, $"set spotify{i} Enabled y");
            lbInstanceOfSpotify.Items.Add($"spotify{i}");
            sandboxNumber++;
        }
        private void btnAddInstance_Click(object sender, EventArgs e)
        {
            int i = lbInstanceOfSpotify.Items.Count;
            if (Tier == 0)
            {
                if (i < 5)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 1)
            {
                if (i < 10)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 2)
            {
                if (i < 30)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 3)
            {
                AddInstance(sandboxNumber + 1);
            }


        }

        private void btnRemoveInstance_Click(object sender, EventArgs e)
        {
            Process.Start(sandboxieSbiePath, $"set {lbInstanceOfSpotify.SelectedItem} Enabled n");
            lbInstanceOfSpotify.Items.Remove(lbInstanceOfSpotify.SelectedItem);
        }

        private void SpotifyBot_Load(object sender, EventArgs e)
        {

        }
        #region MenuLeft
        private void btnMusic_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMusic.Height;
            PnlNav.Top = btnMusic.Top;
            PnlNav.Left = btnMusic.Left;
            btnMusic.BackColor = Color.FromArgb(46,51,73);

        }

        private void btnComptesSpotifyHome_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnComptesSpotifyHome.Height;
            PnlNav.Top = btnComptesSpotifyHome.Top;
            btnComptesSpotifyHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnInstanceHome_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnInstanceHome.Height;
            PnlNav.Top = btnInstanceHome.Top;
            btnInstanceHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnOpenVPNHome_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnOpenVPNHome.Height;
            PnlNav.Top = BtnOpenVPNHome.Top;
            BtnOpenVPNHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnMusic_Leave(object sender, EventArgs e)
        {
            btnMusic.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnComptesSpotifyHome_Leave(object sender, EventArgs e)
        {
            btnComptesSpotifyHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnInstanceHome_Leave(object sender, EventArgs e)
        {
            btnInstanceHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnOpenVPNHome_Leave(object sender, EventArgs e)
        {
            BtnOpenVPNHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion MenuLeft
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
