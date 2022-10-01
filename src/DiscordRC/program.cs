﻿using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DiscordRC
{
    public partial class program : Form
    {
        // configure mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // grab dlls for mousedown
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const string settingsDir = "discordrc\\.settings";

        public program()
        {
            InitializeComponent();
        }

        private void program_Load(object sender, EventArgs e)
        {
            try { Directory.CreateDirectory("discordrc\\.settings"); } catch { }
            try { Directory.CreateDirectory("discordrc\\.logs"); } catch { }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(settingsDir + "\\.token.json"))
            {
                MessageBox.Show("Please configure your bot token in settings.");
                return;
            }
            try { Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\discordrc\\start.bat"); } catch { }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings settings_form = new settings();
            settings_form.ShowDialog();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitColor(237, 66, 69, "White");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitColor(32, 34, 37, "Gray");
        }

        private void titlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void titlebarBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void exitColor(int r, int g, int b, string knownColor)
        {
            exitButton.BackColor = Color.FromArgb(r, g, b);
            exitButton.ForeColor = Color.FromName(knownColor);
        }

        private void mvFrm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}