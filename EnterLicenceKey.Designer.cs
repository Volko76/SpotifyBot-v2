namespace SpotifyBot
{
    partial class EnterLicenceKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLicence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnActivateLicence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLicence
            // 
            this.tbLicence.Location = new System.Drawing.Point(11, 93);
            this.tbLicence.Name = "tbLicence";
            this.tbLicence.Size = new System.Drawing.Size(269, 20);
            this.tbLicence.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your licence key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your username :";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(11, 28);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(269, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // btnActivateLicence
            // 
            this.btnActivateLicence.Location = new System.Drawing.Point(92, 136);
            this.btnActivateLicence.Name = "btnActivateLicence";
            this.btnActivateLicence.Size = new System.Drawing.Size(101, 23);
            this.btnActivateLicence.TabIndex = 4;
            this.btnActivateLicence.Text = "Activate licence";
            this.btnActivateLicence.UseVisualStyleBackColor = true;
            this.btnActivateLicence.Click += new System.EventHandler(this.btnActivateLicence_Click);
            // 
            // EnterLicenceKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 171);
            this.Controls.Add(this.btnActivateLicence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLicence);
            this.Name = "EnterLicenceKey";
            this.Text = "EnterLicenceKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLicence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnActivateLicence;
    }
}