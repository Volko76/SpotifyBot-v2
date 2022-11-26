namespace SpotifyBot
{
    partial class SpotifyBot
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResearchSong = new System.Windows.Forms.Button();
            this.btnConnectOpenVPN = new System.Windows.Forms.Button();
            this.btnLaunchSpotify = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbResearch = new System.Windows.Forms.TextBox();
            this.TestBtn = new System.Windows.Forms.Button();
            this.listboxChansons = new System.Windows.Forms.ListBox();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayQueue = new System.Windows.Forms.Button();
            this.btnRemoveFromQueue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.RemoveAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAccount = new System.Windows.Forms.Button();
            this.lbComptes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInstanceOfSpotify = new System.Windows.Forms.ListBox();
            this.UpgradeBtn = new System.Windows.Forms.Button();
            this.btnRemoveInstance = new System.Windows.Forms.Button();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnOpenVPNHome = new System.Windows.Forms.Button();
            this.btnInstanceHome = new System.Windows.Forms.Button();
            this.btnComptesSpotifyHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tierLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbIntervalMusic = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lbIntervalMusic = new System.Windows.Forms.Label();
            this.btnStopRepeat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIntervalMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResearchSong
            // 
            this.btnResearchSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnResearchSong.FlatAppearance.BorderSize = 0;
            this.btnResearchSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResearchSong.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResearchSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnResearchSong.Location = new System.Drawing.Point(242, 221);
            this.btnResearchSong.Name = "btnResearchSong";
            this.btnResearchSong.Size = new System.Drawing.Size(295, 36);
            this.btnResearchSong.TabIndex = 0;
            this.btnResearchSong.Text = "Rechecher Chanson";
            this.btnResearchSong.UseVisualStyleBackColor = false;
            this.btnResearchSong.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnConnectOpenVPN
            // 
            this.btnConnectOpenVPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnConnectOpenVPN.FlatAppearance.BorderSize = 0;
            this.btnConnectOpenVPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectOpenVPN.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectOpenVPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConnectOpenVPN.Location = new System.Drawing.Point(243, 127);
            this.btnConnectOpenVPN.Name = "btnConnectOpenVPN";
            this.btnConnectOpenVPN.Size = new System.Drawing.Size(295, 49);
            this.btnConnectOpenVPN.TabIndex = 1;
            this.btnConnectOpenVPN.Text = "Connect to openvpn";
            this.btnConnectOpenVPN.UseVisualStyleBackColor = false;
            this.btnConnectOpenVPN.Click += new System.EventHandler(this.btnConnectOpenVPN_Click);
            // 
            // btnLaunchSpotify
            // 
            this.btnLaunchSpotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLaunchSpotify.FlatAppearance.BorderSize = 0;
            this.btnLaunchSpotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchSpotify.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchSpotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLaunchSpotify.Location = new System.Drawing.Point(243, 72);
            this.btnLaunchSpotify.Name = "btnLaunchSpotify";
            this.btnLaunchSpotify.Size = new System.Drawing.Size(295, 49);
            this.btnLaunchSpotify.TabIndex = 2;
            this.btnLaunchSpotify.Text = "Launch Spotify";
            this.btnLaunchSpotify.UseVisualStyleBackColor = false;
            this.btnLaunchSpotify.Click += new System.EventHandler(this.btnLaunchSpotify_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbResearch
            // 
            this.tbResearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbResearch.Location = new System.Drawing.Point(243, 195);
            this.tbResearch.Name = "tbResearch";
            this.tbResearch.Size = new System.Drawing.Size(294, 20);
            this.tbResearch.TabIndex = 3;
            // 
            // TestBtn
            // 
            this.TestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TestBtn.FlatAppearance.BorderSize = 0;
            this.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TestBtn.Location = new System.Drawing.Point(689, 553);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(294, 46);
            this.TestBtn.TabIndex = 5;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = false;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // listboxChansons
            // 
            this.listboxChansons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.listboxChansons.FormattingEnabled = true;
            this.listboxChansons.Location = new System.Drawing.Point(243, 352);
            this.listboxChansons.Name = "listboxChansons";
            this.listboxChansons.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxChansons.Size = new System.Drawing.Size(294, 147);
            this.listboxChansons.TabIndex = 6;
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAddToQueue.FlatAppearance.BorderSize = 0;
            this.btnAddToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToQueue.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddToQueue.Location = new System.Drawing.Point(242, 286);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(295, 24);
            this.btnAddToQueue.TabIndex = 7;
            this.btnAddToQueue.Text = "Ajouter à la queue";
            this.btnAddToQueue.UseVisualStyleBackColor = false;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Queue :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(286, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entrez le nom de la chanson ou du chanteur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlayQueue
            // 
            this.btnPlayQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPlayQueue.FlatAppearance.BorderSize = 0;
            this.btnPlayQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayQueue.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPlayQueue.Location = new System.Drawing.Point(242, 505);
            this.btnPlayQueue.Name = "btnPlayQueue";
            this.btnPlayQueue.Size = new System.Drawing.Size(295, 49);
            this.btnPlayQueue.TabIndex = 10;
            this.btnPlayQueue.Text = "Jouer la queue";
            this.btnPlayQueue.UseVisualStyleBackColor = false;
            this.btnPlayQueue.Click += new System.EventHandler(this.btnPlayQueue_Click);
            // 
            // btnRemoveFromQueue
            // 
            this.btnRemoveFromQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRemoveFromQueue.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromQueue.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveFromQueue.Location = new System.Drawing.Point(242, 312);
            this.btnRemoveFromQueue.Name = "btnRemoveFromQueue";
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(295, 24);
            this.btnRemoveFromQueue.TabIndex = 11;
            this.btnRemoveFromQueue.Text = "Supprimer de la queue";
            this.btnRemoveFromQueue.UseVisualStyleBackColor = false;
            this.btnRemoveFromQueue.Click += new System.EventHandler(this.btnRemoveFromQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(135, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbUsername.Location = new System.Drawing.Point(15, 28);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(294, 22);
            this.tbUsername.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(135, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbPassword.Location = new System.Drawing.Point(15, 77);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(294, 22);
            this.tbPassword.TabIndex = 14;
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RemoveAccount.FlatAppearance.BorderSize = 0;
            this.RemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccount.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RemoveAccount.Location = new System.Drawing.Point(17, 39);
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.Size = new System.Drawing.Size(292, 24);
            this.RemoveAccount.TabIndex = 19;
            this.RemoveAccount.Text = "Supprimer de la liste";
            this.RemoveAccount.UseVisualStyleBackColor = false;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(88, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Queue des comptes Spotify :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddAccount
            // 
            this.AddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddAccount.FlatAppearance.BorderSize = 0;
            this.AddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccount.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddAccount.Location = new System.Drawing.Point(17, 12);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(292, 24);
            this.AddAccount.TabIndex = 17;
            this.AddAccount.Text = "Ajouter à la liste de compte";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // lbComptes
            // 
            this.lbComptes.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbComptes.FormattingEnabled = true;
            this.lbComptes.Location = new System.Drawing.Point(14, 82);
            this.lbComptes.Name = "lbComptes";
            this.lbComptes.Size = new System.Drawing.Size(294, 147);
            this.lbComptes.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(1045, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Queue des instances Spotify :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInstanceOfSpotify
            // 
            this.lbInstanceOfSpotify.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstanceOfSpotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbInstanceOfSpotify.FormattingEnabled = true;
            this.lbInstanceOfSpotify.Location = new System.Drawing.Point(20, 81);
            this.lbInstanceOfSpotify.Name = "lbInstanceOfSpotify";
            this.lbInstanceOfSpotify.Size = new System.Drawing.Size(294, 147);
            this.lbInstanceOfSpotify.Sorted = true;
            this.lbInstanceOfSpotify.TabIndex = 22;
            // 
            // UpgradeBtn
            // 
            this.UpgradeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpgradeBtn.FlatAppearance.BorderSize = 0;
            this.UpgradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UpgradeBtn.Location = new System.Drawing.Point(19, 355);
            this.UpgradeBtn.Name = "UpgradeBtn";
            this.UpgradeBtn.Size = new System.Drawing.Size(294, 33);
            this.UpgradeBtn.TabIndex = 23;
            this.UpgradeBtn.Text = "Upgrade";
            this.UpgradeBtn.UseVisualStyleBackColor = false;
            this.UpgradeBtn.Click += new System.EventHandler(this.UpgradeBtn_Click);
            // 
            // btnRemoveInstance
            // 
            this.btnRemoveInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRemoveInstance.FlatAppearance.BorderSize = 0;
            this.btnRemoveInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInstance.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveInstance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveInstance.Location = new System.Drawing.Point(22, 46);
            this.btnRemoveInstance.Name = "btnRemoveInstance";
            this.btnRemoveInstance.Size = new System.Drawing.Size(292, 24);
            this.btnRemoveInstance.TabIndex = 25;
            this.btnRemoveInstance.Text = "Supprimer de la liste";
            this.btnRemoveInstance.UseVisualStyleBackColor = false;
            this.btnRemoveInstance.Click += new System.EventHandler(this.btnRemoveInstance_Click);
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAddInstance.FlatAppearance.BorderSize = 0;
            this.btnAddInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstance.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddInstance.Location = new System.Drawing.Point(22, 16);
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(292, 24);
            this.btnAddInstance.TabIndex = 24;
            this.btnAddInstance.Text = "Ajouter à la liste d\'instance Spotify";
            this.btnAddInstance.UseVisualStyleBackColor = false;
            this.btnAddInstance.Click += new System.EventHandler(this.btnAddInstance_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(16, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 65);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tiers :\r\n    -Basic : 5 instances\r\n    -Tier I : 10 instances\r\n    -Tier II : 30 " +
    "instances\r\n    -Unlimited : unlimited instances\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnOpenVPNHome);
            this.panel1.Controls.Add(this.btnInstanceHome);
            this.panel1.Controls.Add(this.btnComptesSpotifyHome);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnMusic);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 622);
            this.panel1.TabIndex = 27;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 28;
            // 
            // BtnOpenVPNHome
            // 
            this.BtnOpenVPNHome.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BtnOpenVPNHome.FlatAppearance.BorderSize = 0;
            this.BtnOpenVPNHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenVPNHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenVPNHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnOpenVPNHome.Image = global::SpotifyBot.Properties.Resources.logo_openvpn__1___1_;
            this.BtnOpenVPNHome.Location = new System.Drawing.Point(0, 276);
            this.BtnOpenVPNHome.Name = "BtnOpenVPNHome";
            this.BtnOpenVPNHome.Size = new System.Drawing.Size(186, 42);
            this.BtnOpenVPNHome.TabIndex = 5;
            this.BtnOpenVPNHome.Text = "OpenVPN";
            this.BtnOpenVPNHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOpenVPNHome.UseVisualStyleBackColor = true;
            this.BtnOpenVPNHome.Enter += new System.EventHandler(this.BtnOpenVPNHome_Enter);
            this.BtnOpenVPNHome.Leave += new System.EventHandler(this.BtnOpenVPNHome_Leave);
            // 
            // btnInstanceHome
            // 
            this.btnInstanceHome.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnInstanceHome.FlatAppearance.BorderSize = 0;
            this.btnInstanceHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstanceHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanceHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInstanceHome.Image = global::SpotifyBot.Properties.Resources.instance__1_;
            this.btnInstanceHome.Location = new System.Drawing.Point(0, 236);
            this.btnInstanceHome.Name = "btnInstanceHome";
            this.btnInstanceHome.Size = new System.Drawing.Size(186, 42);
            this.btnInstanceHome.TabIndex = 4;
            this.btnInstanceHome.Text = "Instances";
            this.btnInstanceHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInstanceHome.UseVisualStyleBackColor = true;
            this.btnInstanceHome.Enter += new System.EventHandler(this.btnInstanceHome_Enter);
            this.btnInstanceHome.Leave += new System.EventHandler(this.btnInstanceHome_Leave);
            // 
            // btnComptesSpotifyHome
            // 
            this.btnComptesSpotifyHome.CausesValidation = false;
            this.btnComptesSpotifyHome.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnComptesSpotifyHome.FlatAppearance.BorderSize = 0;
            this.btnComptesSpotifyHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComptesSpotifyHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComptesSpotifyHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnComptesSpotifyHome.Image = global::SpotifyBot.Properties.Resources.spotifypng__1_1;
            this.btnComptesSpotifyHome.Location = new System.Drawing.Point(0, 190);
            this.btnComptesSpotifyHome.Name = "btnComptesSpotifyHome";
            this.btnComptesSpotifyHome.Size = new System.Drawing.Size(186, 42);
            this.btnComptesSpotifyHome.TabIndex = 3;
            this.btnComptesSpotifyHome.Text = "Comptes";
            this.btnComptesSpotifyHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnComptesSpotifyHome.UseVisualStyleBackColor = true;
            this.btnComptesSpotifyHome.Enter += new System.EventHandler(this.btnComptesSpotifyHome_Enter);
            this.btnComptesSpotifyHome.Leave += new System.EventHandler(this.btnComptesSpotifyHome_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::SpotifyBot.Properties.Resources.musique__1_1;
            this.btnSettings.Location = new System.Drawing.Point(0, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Enter += new System.EventHandler(this.btnSettings_Enter);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnMusic
            // 
            this.btnMusic.CausesValidation = false;
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMusic.Image = global::SpotifyBot.Properties.Resources.musique__1_1;
            this.btnMusic.Location = new System.Drawing.Point(0, 144);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(186, 42);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.Text = "Music";
            this.btnMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Enter += new System.EventHandler(this.btnMusic_Enter);
            this.btnMusic.Leave += new System.EventHandler(this.btnMusic_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tierLabel);
            this.panel2.Controls.Add(this.userLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // tierLabel
            // 
            this.tierLabel.AutoSize = true;
            this.tierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.tierLabel.Location = new System.Drawing.Point(68, 118);
            this.tierLabel.Name = "tierLabel";
            this.tierLabel.Size = new System.Drawing.Size(55, 12);
            this.tierLabel.TabIndex = 2;
            this.tierLabel.Text = "Tier Basic";
            this.tierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.userLabel.Location = new System.Drawing.Point(55, 88);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(85, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User Name";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpotifyBot.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Music";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.tbUsername);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbPassword);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(598, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 124);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel4.Controls.Add(this.AddAccount);
            this.panel4.Controls.Add(this.lbComptes);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.RemoveAccount);
            this.panel4.Location = new System.Drawing.Point(598, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 245);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel5.Controls.Add(this.btnAddInstance);
            this.panel5.Controls.Add(this.lbInstanceOfSpotify);
            this.panel5.Controls.Add(this.UpgradeBtn);
            this.panel5.Controls.Add(this.btnRemoveInstance);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(958, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 394);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(186, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1196, 51);
            this.panel6.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Image = global::SpotifyBot.Properties.Resources.closeTranspa;
            this.btnExit.Location = new System.Drawing.Point(1079, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 38);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbIntervalMusic
            // 
            this.tbIntervalMusic.Location = new System.Drawing.Point(242, 565);
            this.tbIntervalMusic.Maximum = 700000;
            this.tbIntervalMusic.Minimum = 20000;
            this.tbIntervalMusic.Name = "tbIntervalMusic";
            this.tbIntervalMusic.Size = new System.Drawing.Size(295, 45);
            this.tbIntervalMusic.TabIndex = 33;
            this.tbIntervalMusic.Value = 20000;
            this.tbIntervalMusic.Scroll += new System.EventHandler(this.tbIntervalMusic_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(306, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Temps entre chaque chanson (min)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbIntervalMusic
            // 
            this.lbIntervalMusic.AutoSize = true;
            this.lbIntervalMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbIntervalMusic.Location = new System.Drawing.Point(533, 570);
            this.lbIntervalMusic.Name = "lbIntervalMusic";
            this.lbIntervalMusic.Size = new System.Drawing.Size(13, 13);
            this.lbIntervalMusic.TabIndex = 35;
            this.lbIntervalMusic.Text = "0";
            this.lbIntervalMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStopRepeat
            // 
            this.btnStopRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnStopRepeat.FlatAppearance.BorderSize = 0;
            this.btnStopRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopRepeat.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStopRepeat.Location = new System.Drawing.Point(242, 259);
            this.btnStopRepeat.Name = "btnStopRepeat";
            this.btnStopRepeat.Size = new System.Drawing.Size(295, 25);
            this.btnStopRepeat.TabIndex = 36;
            this.btnStopRepeat.Text = "Stop Répéter";
            this.btnStopRepeat.UseVisualStyleBackColor = false;
            this.btnStopRepeat.Click += new System.EventHandler(this.btnStopRepeat_Click);
            // 
            // SpotifyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1372, 622);
            this.ControlBox = false;
            this.Controls.Add(this.btnStopRepeat);
            this.Controls.Add(this.lbIntervalMusic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbIntervalMusic);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveFromQueue);
            this.Controls.Add(this.btnPlayQueue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.listboxChansons);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.tbResearch);
            this.Controls.Add(this.btnLaunchSpotify);
            this.Controls.Add(this.btnConnectOpenVPN);
            this.Controls.Add(this.btnResearchSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpotifyBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.SpotifyBot_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpotifyBot_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIntervalMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Panel6_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnResearchSong;
        private System.Windows.Forms.Button btnConnectOpenVPN;
        private System.Windows.Forms.Button btnLaunchSpotify;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbResearch;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.ListBox listboxChansons;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayQueue;
        private System.Windows.Forms.Button btnRemoveFromQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button RemoveAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.ListBox lbComptes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbInstanceOfSpotify;
        private System.Windows.Forms.Button UpgradeBtn;
        private System.Windows.Forms.Button btnRemoveInstance;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label tierLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button btnComptesSpotifyHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInstanceHome;
        private System.Windows.Forms.Button BtnOpenVPNHome;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar tbIntervalMusic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbIntervalMusic;
        private System.Windows.Forms.Button btnStopRepeat;
    }
}

