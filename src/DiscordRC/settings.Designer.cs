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
            this.acceptTokenButton = new System.Windows.Forms.Button();
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.titlebarBanner = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.botTokenLabel = new System.Windows.Forms.Label();
            this.resetTokenButton = new System.Windows.Forms.Button();
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.loggingLabel = new System.Windows.Forms.Label();
            this.useLogsCheckbox = new System.Windows.Forms.CheckBox();
            this.botLabel = new System.Windows.Forms.Label();
            this.leftBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenBox
            // 
            this.tokenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tokenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tokenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.tokenBox.Location = new System.Drawing.Point(96, 60);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(231, 13);
            this.tokenBox.TabIndex = 1;
            // 
            // acceptTokenButton
            // 
            this.acceptTokenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.acceptTokenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.acceptTokenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptTokenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptTokenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.acceptTokenButton.Location = new System.Drawing.Point(95, 74);
            this.acceptTokenButton.Name = "acceptTokenButton";
            this.acceptTokenButton.Size = new System.Drawing.Size(56, 23);
            this.acceptTokenButton.TabIndex = 2;
            this.acceptTokenButton.Text = "Register";
            this.acceptTokenButton.UseVisualStyleBackColor = false;
            this.acceptTokenButton.Click += new System.EventHandler(this.acceptTokenButton_Click);
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
            this.titlebarPanel.TabIndex = 0;
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
            this.settingsLabel.TabIndex = 0;
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
            this.titlebarBanner.TabIndex = 0;
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
            this.exitButton.TabIndex = 0;
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
            this.botTokenLabel.Location = new System.Drawing.Point(93, 44);
            this.botTokenLabel.Name = "botTokenLabel";
            this.botTokenLabel.Size = new System.Drawing.Size(41, 15);
            this.botTokenLabel.TabIndex = 0;
            this.botTokenLabel.Text = "Token";
            // 
            // resetTokenButton
            // 
            this.resetTokenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.resetTokenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.resetTokenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTokenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTokenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.resetTokenButton.Location = new System.Drawing.Point(151, 74);
            this.resetTokenButton.Name = "resetTokenButton";
            this.resetTokenButton.Size = new System.Drawing.Size(56, 23);
            this.resetTokenButton.TabIndex = 3;
            this.resetTokenButton.Text = "Reset";
            this.resetTokenButton.UseVisualStyleBackColor = false;
            this.resetTokenButton.Click += new System.EventHandler(this.resetTokenButton_Click);
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.clearLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.clearLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLogsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.clearLogsButton.Location = new System.Drawing.Point(95, 132);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogsButton.TabIndex = 5;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.UseVisualStyleBackColor = false;
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // loggingLabel
            // 
            this.loggingLabel.AutoSize = true;
            this.loggingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.loggingLabel.Location = new System.Drawing.Point(92, 98);
            this.loggingLabel.Name = "loggingLabel";
            this.loggingLabel.Size = new System.Drawing.Size(52, 15);
            this.loggingLabel.TabIndex = 0;
            this.loggingLabel.Text = "Logging";
            // 
            // useLogsCheckbox
            // 
            this.useLogsCheckbox.AutoSize = true;
            this.useLogsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useLogsCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.useLogsCheckbox.Location = new System.Drawing.Point(96, 115);
            this.useLogsCheckbox.Name = "useLogsCheckbox";
            this.useLogsCheckbox.Size = new System.Drawing.Size(100, 17);
            this.useLogsCheckbox.TabIndex = 4;
            this.useLogsCheckbox.Text = "Enable Logging";
            this.useLogsCheckbox.UseVisualStyleBackColor = true;
            this.useLogsCheckbox.CheckedChanged += new System.EventHandler(this.useLogsCheckbox_CheckedChanged);
            // 
            // botLabel
            // 
            this.botLabel.AutoSize = true;
            this.botLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.botLabel.Location = new System.Drawing.Point(84, 28);
            this.botLabel.Name = "botLabel";
            this.botLabel.Size = new System.Drawing.Size(56, 16);
            this.botLabel.TabIndex = 0;
            this.botLabel.Text = "Session";
            // 
            // leftBar
            // 
            this.leftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.leftBar.Location = new System.Drawing.Point(-1, 24);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(78, 326);
            this.leftBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(346, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 326);
            this.panel1.TabIndex = 0;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(423, 163);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftBar);
            this.Controls.Add(this.botLabel);
            this.Controls.Add(this.useLogsCheckbox);
            this.Controls.Add(this.loggingLabel);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.resetTokenButton);
            this.Controls.Add(this.botTokenLabel);
            this.Controls.Add(this.titlebarPanel);
            this.Controls.Add(this.acceptTokenButton);
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
        private System.Windows.Forms.Button acceptTokenButton;
        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label botTokenLabel;
        private System.Windows.Forms.Button resetTokenButton;
        private System.Windows.Forms.PictureBox titlebarBanner;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Label loggingLabel;
        private System.Windows.Forms.CheckBox useLogsCheckbox;
        private System.Windows.Forms.Label botLabel;
        private System.Windows.Forms.Panel leftBar;
        private System.Windows.Forms.Panel panel1;
    }
}