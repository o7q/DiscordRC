namespace DiscordRC
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.acceptToken = new System.Windows.Forms.Button();
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.titlebarBanner = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.botTokenLabel = new System.Windows.Forms.Label();
            this.resetToken = new System.Windows.Forms.Button();
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenBox
            // 
            this.tokenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tokenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tokenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.tokenBox.Location = new System.Drawing.Point(7, 44);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(408, 19);
            this.tokenBox.TabIndex = 0;
            // 
            // acceptToken
            // 
            this.acceptToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.acceptToken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.acceptToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.acceptToken.Location = new System.Drawing.Point(6, 64);
            this.acceptToken.Name = "acceptToken";
            this.acceptToken.Size = new System.Drawing.Size(56, 23);
            this.acceptToken.TabIndex = 1;
            this.acceptToken.Text = "Register";
            this.acceptToken.UseVisualStyleBackColor = false;
            this.acceptToken.Click += new System.EventHandler(this.acceptToken_Click);
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.titlebarPanel.Controls.Add(this.settingsLabel);
            this.titlebarPanel.Controls.Add(this.titlebarBanner);
            this.titlebarPanel.Controls.Add(this.exitButton);
            this.titlebarPanel.Location = new System.Drawing.Point(-2, -3);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(426, 27);
            this.titlebarPanel.TabIndex = 2;
            this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.settingsLabel.Location = new System.Drawing.Point(76, 8);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(39, 12);
            this.settingsLabel.TabIndex = 5;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settingsLabel_MouseDown);
            // 
            // titlebarBanner
            // 
            this.titlebarBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.titlebarBanner.Image = ((System.Drawing.Image)(resources.GetObject("titlebarBanner.Image")));
            this.titlebarBanner.Location = new System.Drawing.Point(4, 7);
            this.titlebarBanner.Name = "titlebarBanner";
            this.titlebarBanner.Size = new System.Drawing.Size(75, 16);
            this.titlebarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarBanner.TabIndex = 5;
            this.titlebarBanner.TabStop = false;
            this.titlebarBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarBanner_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Gray;
            this.exitButton.Location = new System.Drawing.Point(399, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // botTokenLabel
            // 
            this.botTokenLabel.AutoSize = true;
            this.botTokenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botTokenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.botTokenLabel.Location = new System.Drawing.Point(4, 27);
            this.botTokenLabel.Name = "botTokenLabel";
            this.botTokenLabel.Size = new System.Drawing.Size(62, 15);
            this.botTokenLabel.TabIndex = 3;
            this.botTokenLabel.Text = "Bot Token";
            // 
            // resetToken
            // 
            this.resetToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.resetToken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.resetToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.resetToken.Location = new System.Drawing.Point(61, 64);
            this.resetToken.Name = "resetToken";
            this.resetToken.Size = new System.Drawing.Size(56, 23);
            this.resetToken.TabIndex = 4;
            this.resetToken.Text = "Reset";
            this.resetToken.UseVisualStyleBackColor = false;
            this.resetToken.Click += new System.EventHandler(this.resetToken_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.resetToken);
            this.Controls.Add(this.botTokenLabel);
            this.Controls.Add(this.titlebarPanel);
            this.Controls.Add(this.acceptToken);
            this.Controls.Add(this.tokenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "DiscordRC Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Button acceptToken;
        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label botTokenLabel;
        private System.Windows.Forms.Button resetToken;
        private System.Windows.Forms.PictureBox titlebarBanner;
        private System.Windows.Forms.Label settingsLabel;
    }
}