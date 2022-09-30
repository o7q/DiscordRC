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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program));
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.titlebarBanner = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.rightBar = new System.Windows.Forms.Panel();
            this.leftBar = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.titlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).BeginInit();
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
            this.titlebarBanner.Location = new System.Drawing.Point(7, 6);
            this.titlebarBanner.Name = "titlebarBanner";
            this.titlebarBanner.Size = new System.Drawing.Size(75, 16);
            this.titlebarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlebarBanner.TabIndex = 2;
            this.titlebarBanner.TabStop = false;
            this.titlebarBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarBanner_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Gray;
            this.exitButton.Location = new System.Drawing.Point(345, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Gray;
            this.minimizeButton.Location = new System.Drawing.Point(321, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "─";
            this.minimizeButton.UseVisualStyleBackColor = true;
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
            this.startButton.Size = new System.Drawing.Size(166, 26);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Go Online";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rightBar
            // 
            this.rightBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.rightBar.Location = new System.Drawing.Point(286, 24);
            this.rightBar.Name = "rightBar";
            this.rightBar.Size = new System.Drawing.Size(81, 188);
            this.rightBar.TabIndex = 4;
            // 
            // leftBar
            // 
            this.leftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.leftBar.Location = new System.Drawing.Point(-1, 24);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(81, 188);
            this.leftBar.TabIndex = 5;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(253, 180);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(26, 26);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(366, 211);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.leftBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.rightBar);
            this.Controls.Add(this.titlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "DiscordRC";
            this.titlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlebarBanner)).EndInit();
            this.ResumeLayout(false);

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
    }
}

