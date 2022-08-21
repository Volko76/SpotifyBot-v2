using SpotifyBot.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.Dism;
using System.Management.Automation;
using System.Collections.Generic;

namespace SpotifyBot
{

    public partial class Form1 : Form
    {
        string spotifyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Spotify\\Spotify.exe";
        string openVpnPath = "C:\\Program Files\\OpenVPN\\bin\\openvpn-gui.exe";
        string lastReaseach = "";
        string sandboxiePath = "C:\\Program Files\\Sandboxie\\Start.exe";
        //string[] Comptes = {};
        Dictionary<string, string> Comptes = new Dictionary<string, string>(){
        };
        int[] ListOfSpotifyLaunched = { };
        
        Click c = new Click();
        Point point = new Point();


        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(spotifyPath))
            {
                InstallSpotify();
            }
            if (!File.Exists(openVpnPath))
            {
                InstallOpenVpn();
            }
            lbInstanceOfSpotify.Items.Add("spotify1");
            lbInstanceOfSpotify.Items.Add("Spotify2");
            lbInstanceOfSpotify.Items.Add("spotify3");
            lbInstanceOfSpotify.Items.Add("spotify4");

        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            if (tbResearch.Text != lastReaseach)
            {
                PlaySong(tbResearch.Text);
                lastReaseach = tbResearch.Text;
            }
            else
            {
                PowerShell.Create().AddCommand("C:\\Users\\Volko\\AppData\\Roaming\\Spotify\\spotify.exe")
                  .Invoke();
                Thread.Sleep(5000);
                SendKeys.SendWait("^({left})");

            }
        }
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public void PlaySong(string song)
        {
            
            int i = 42;
            PowerShell.Create().AddCommand(sandboxiePath).AddParameter("/box", $"Spotify{i}").AddParameter("C:\\Users\\Volko\\AppData\\Roaming\\Spotify\\spotify.exe")
                   .AddParameter("-uri=", tbResearch.Text.ToString())
                  .Invoke();
            Thread.Sleep(5000);
            PlaySpotify();
           
        }
        void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void TestBtn_Click(object sender, EventArgs e)
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
                    lbComptes.SelectedIndex = 0;
                }
            }
            System.Diagnostics.Process.Start("C://Program Files//Sandboxie//Start.exe", $"/box:{lbInstanceOfSpotify.SelectedItem.ToString()} C://Users//Volko//AppData//Roaming//Spotify//spotify.exe -uri={tbResearch.Text} --username={lbComptes.GetItemText(lbComptes.SelectedItem)} --password={Comptes[lbComptes.GetItemText(lbComptes.SelectedItem)]}");
        }
        //Functions to access to bytes of the file we want to recreate
        public static byte[] Test()
        {
            return Properties.Resources.playSpotifyBtn;
        }
        public void PlaySpotify()
        {
            Image playSpotifyImage = Resources.playspotify;
            RecreateImageInProjectFolder(playSpotifyImage, "playspotify.png");

            string tempExeName = RecreateExeInProjectFolder("playSpotifyBtn");
            Process.Start(tempExeName);
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
        public void EnableFeature(string featureName)
        {
            DismApi.Initialize(DismLogLevel.LogErrorsWarningsInfo);
            try
            {
                var session = DismApi.OpenOnlineSession();
                DismApi.EnableFeature(session, featureName, false, true, null, progress =>
                {
                    Console.Write($"{progress.Total} / {progress.Current}");
                });
                Console.WriteLine();
            }
            finally
            {
                DismApi.Shutdown();
            }
        }
        public void ViewProcess()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] list = Process.GetProcessesByName("Spotify");
            foreach(var process in list)
            {
                MessageBox.Show( process.ProcessName + process.Id.ToString());
            }
        }
        public void Connexion()
        {
            RecreateImageInProjectFolder(Properties.Resources.connexionBtn, "connexionBtn.png");
            RecreateExeInProjectFolder("connexion");

        }
        public void RecreateImageInProjectFolder(Image img, string name)
        {
            img.Save(Directory.GetCurrentDirectory() + $"//{name}.png");
        }
        public string RecreateExeInProjectFolder(string name)
        {
            string tempExeName = Path.Combine(Directory.GetCurrentDirectory(), $"{name}.exe");
            if (!File.Exists(tempExeName))
            {
                using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Test();

                    fsDst.Write(bytes, 0, bytes.Length);
                }
            }
            return tempExeName;
        }
        public void resultSpotify()
        {
            string resultSpotify = RecreateExeInProjectFolder("resultSpotify");
            RecreateImageInProjectFolder(Properties.Resources.resultSpotify1, "resultSpotify");
            Thread.Sleep(3000);
            Process.Start(resultSpotify);
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
    }
}
