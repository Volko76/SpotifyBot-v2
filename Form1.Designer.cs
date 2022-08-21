namespace SpotifyBot
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnResearchSong
            // 
            this.btnResearchSong.Location = new System.Drawing.Point(11, 185);
            this.btnResearchSong.Name = "btnResearchSong";
            this.btnResearchSong.Size = new System.Drawing.Size(295, 49);
            this.btnResearchSong.TabIndex = 0;
            this.btnResearchSong.Text = "Rechecher Chanson";
            this.btnResearchSong.UseVisualStyleBackColor = true;
            this.btnResearchSong.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect to openvpn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Launch Spotify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbResearch
            // 
            this.tbResearch.Location = new System.Drawing.Point(12, 159);
            this.tbResearch.Name = "tbResearch";
            this.tbResearch.Size = new System.Drawing.Size(294, 20);
            this.tbResearch.TabIndex = 3;
            this.tbResearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(11, 524);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(294, 46);
            this.TestBtn.TabIndex = 5;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // listboxChansons
            // 
            this.listboxChansons.FormattingEnabled = true;
            this.listboxChansons.Location = new System.Drawing.Point(12, 316);
            this.listboxChansons.Name = "listboxChansons";
            this.listboxChansons.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxChansons.Size = new System.Drawing.Size(294, 147);
            this.listboxChansons.TabIndex = 6;
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Location = new System.Drawing.Point(15, 246);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(292, 24);
            this.btnAddToQueue.TabIndex = 7;
            this.btnAddToQueue.Text = "Ajouter à la queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(55, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entrez le nom de la chanson ou du chanteur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlayQueue
            // 
            this.btnPlayQueue.Location = new System.Drawing.Point(11, 469);
            this.btnPlayQueue.Name = "btnPlayQueue";
            this.btnPlayQueue.Size = new System.Drawing.Size(295, 49);
            this.btnPlayQueue.TabIndex = 10;
            this.btnPlayQueue.Text = "Jouer la queue";
            this.btnPlayQueue.UseVisualStyleBackColor = true;
            this.btnPlayQueue.Click += new System.EventHandler(this.btnPlayQueue_Click);
            // 
            // btnRemoveFromQueue
            // 
            this.btnRemoveFromQueue.Location = new System.Drawing.Point(16, 270);
            this.btnRemoveFromQueue.Name = "btnRemoveFromQueue";
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(292, 24);
            this.btnRemoveFromQueue.TabIndex = 11;
            this.btnRemoveFromQueue.Text = "Supprimer de la queue";
            this.btnRemoveFromQueue.UseVisualStyleBackColor = true;
            this.btnRemoveFromQueue.Click += new System.EventHandler(this.btnRemoveFromQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(369, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(294, 20);
            this.tbUsername.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(369, 107);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(294, 20);
            this.tbPassword.TabIndex = 14;
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.Location = new System.Drawing.Point(372, 183);
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.Size = new System.Drawing.Size(292, 24);
            this.RemoveAccount.TabIndex = 19;
            this.RemoveAccount.Text = "Supprimer de la liste";
            this.RemoveAccount.UseVisualStyleBackColor = true;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Queue des comptes Spotify :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(371, 159);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(292, 24);
            this.AddAccount.TabIndex = 17;
            this.AddAccount.Text = "Ajouter à la liste de compte";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // lbComptes
            // 
            this.lbComptes.FormattingEnabled = true;
            this.lbComptes.Location = new System.Drawing.Point(368, 229);
            this.lbComptes.Name = "lbComptes";
            this.lbComptes.Size = new System.Drawing.Size(294, 147);
            this.lbComptes.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Queue des comptes Spotify :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInstanceOfSpotify
            // 
            this.lbInstanceOfSpotify.FormattingEnabled = true;
            this.lbInstanceOfSpotify.Location = new System.Drawing.Point(369, 405);
            this.lbInstanceOfSpotify.Name = "lbInstanceOfSpotify";
            this.lbInstanceOfSpotify.Size = new System.Drawing.Size(294, 147);
            this.lbInstanceOfSpotify.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 564);
            this.Controls.Add(this.lbInstanceOfSpotify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemoveAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.lbComptes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

