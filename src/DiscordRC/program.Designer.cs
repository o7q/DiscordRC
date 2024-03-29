﻿namespace DiscordRC
{
    partial class program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program));
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.titlebarBanner = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.rightBar = new System.Windows.Forms.Panel();
            this.leftBar = new System.Windows.Forms.Panel();
            this.verLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.statusPicture = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.sessionInfoLabel = new System.Windows.Forms.Label();
            this.programToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.titlebarPanel.Controls.Add(this.titlebarBanner);
            this.titlebarPanel.Controls.Add(this.exitButton);
            this.titlebarPanel.Controls.Add(this.minimizeButton);
            this.titlebarPanel.Location = new System.Drawing.Point(-5, -3);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(376, 27);
            this.titlebarPanel.TabIndex = 0;
            this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // titlebarBanner
            // 
            this.titlebarBanner.Image = ((System.Drawing.Image)(resources.GetObject("titlebarBanner.Image")));
            this.titlebarBanner.Location = new System.Drawing.Point(7, 7);
            this.titlebarBanner.Name = "titlebarBanner";
            this.titlebarBanner.Size = new System.Drawing.Size(75, 16);
            this.titlebarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarBanner.TabIndex = 0;
            this.titlebarBanner.TabStop = false;
            this.titlebarBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarBanner_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Gray;
            this.exitButton.Location = new System.Drawing.Point(350, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Gray;
            this.minimizeButton.Location = new System.Drawing.Point(319, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.Text = "─";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.startButton.Location = new System.Drawing.Point(87, 180);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 26);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Go Online";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rightBar
            // 
            this.rightBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.rightBar.Location = new System.Drawing.Point(291, 24);
            this.rightBar.Name = "rightBar";
            this.rightBar.Size = new System.Drawing.Size(81, 188);
            this.rightBar.TabIndex = 0;
            // 
            // leftBar
            // 
            this.leftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.leftBar.Location = new System.Drawing.Point(-1, 24);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(81, 188);
            this.leftBar.TabIndex = 0;
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.verLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.verLabel.Location = new System.Drawing.Point(256, 167);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(32, 12);
            this.verLabel.TabIndex = 0;
            this.verLabel.Text = "v1.1.0";
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.logBox.Location = new System.Drawing.Point(80, 24);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(211, 140);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "";
            this.logBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logBox_MouseClick);
            // 
            // statusPicture
            // 
            this.statusPicture.BackColor = System.Drawing.Color.Transparent;
            this.statusPicture.Image = global::DiscordRC.Properties.Resources.offline;
            this.statusPicture.Location = new System.Drawing.Point(87, 167);
            this.statusPicture.Name = "statusPicture";
            this.statusPicture.Size = new System.Drawing.Size(42, 10);
            this.statusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusPicture.TabIndex = 0;
            this.statusPicture.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.settingsButton.Image = global::DiscordRC.Properties.Resources.cog;
            this.settingsButton.Location = new System.Drawing.Point(259, 180);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(26, 26);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // sessionInfoLabel
            // 
            this.sessionInfoLabel.AutoSize = true;
            this.sessionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.sessionInfoLabel.Location = new System.Drawing.Point(130, 167);
            this.sessionInfoLabel.Name = "sessionInfoLabel";
            this.sessionInfoLabel.Size = new System.Drawing.Size(130, 12);
            this.sessionInfoLabel.TabIndex = 0;
            this.sessionInfoLabel.Text = "_________________________";
            // 
            // programToolTip
            // 
            this.programToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.programToolTip_Draw);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(371, 211);
            this.Controls.Add(this.sessionInfoLabel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.statusPicture);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.leftBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.rightBar);
            this.Controls.Add(this.titlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "DiscordRC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.program_FormClosing);
            this.Load += new System.EventHandler(this.program_Load);
            this.titlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox titlebarBanner;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel rightBar;
        private System.Windows.Forms.Panel leftBar;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.PictureBox statusPicture;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label sessionInfoLabel;
        private System.Windows.Forms.ToolTip programToolTip;
    }
}