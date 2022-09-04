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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnOpenVPNHome = new System.Windows.Forms.Button();
            this.btnInstanceHome = new System.Windows.Forms.Button();
            this.btnComptesSpotifyHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnResearchSong.Size = new System.Drawing.Size(295, 49);
            this.btnResearchSong.TabIndex = 0;
            this.btnResearchSong.Text = "Rechecher Chanson";
            this.btnResearchSong.UseVisualStyleBackColor = false;
            this.btnResearchSong.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(243, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect to openvpn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(243, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Launch Spotify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tbResearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TestBtn
            // 
            this.TestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TestBtn.FlatAppearance.BorderSize = 0;
            this.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TestBtn.Location = new System.Drawing.Point(242, 560);
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
            this.btnAddToQueue.Size = new System.Drawing.Size(292, 24);
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
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(292, 24);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(32, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Some User Text Here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(55, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "User Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(186, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1196, 51);
            this.panel6.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Image = global::SpotifyBot.Properties.Resources.closeTranspa;
            this.button3.Location = new System.Drawing.Point(1079, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 38);
            this.button3.TabIndex = 29;
            this.button3.Text = "Exit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.BtnOpenVPNHome.Click += new System.EventHandler(this.BtnOpenVPNHome_Click);
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
            this.btnInstanceHome.Click += new System.EventHandler(this.btnInstanceHome_Click);
            this.btnInstanceHome.Leave += new System.EventHandler(this.btnInstanceHome_Leave);
            // 
            // btnComptesSpotifyHome
            // 
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
            this.btnComptesSpotifyHome.Click += new System.EventHandler(this.btnComptesSpotifyHome_Click);
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
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnMusic
            // 
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
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            this.btnMusic.Leave += new System.EventHandler(this.btnMusic_Leave);
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
            // SpotifyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1372, 622);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResearchSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpotifyBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyBot - Tier Basic";
            this.Load += new System.EventHandler(this.SpotifyBot_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResearchSong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Button button3;
    }
}

