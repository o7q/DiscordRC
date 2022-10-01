﻿using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

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

        const string ver = "v1.0.0";
        const string settingsDir = "discordrc\\.settings";
        string sessDate = DateTime.Now.ToString("Mdy-hms");

        public program()
        {
            InitializeComponent();
        }

        private void program_Load(object sender, EventArgs e)
        {
            try { Directory.CreateDirectory("discordrc\\.settings"); } catch { }
            try { Directory.CreateDirectory("discordrc\\.logs"); } catch { }
        }

        private void program_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitHandler();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startHandler(false);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            startHandler(true);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitHandler();
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

        private void startHandler(bool isForSettings, bool progOpen = false)
        {         
            foreach (Process progOpenCheck in Process.GetProcesses()) if (progOpenCheck.ProcessName.Contains("discordrc_transit_dummy")) progOpen = true;
            if (progOpen == false)
            {
                if (!File.Exists(settingsDir + "\\.token.json"))
                {
                    MessageBox.Show("No bot token found.\nPlease configure it in settings.");
                    return;
                }

                if (isForSettings == false)
                {
                    try { File.WriteAllText("discordrc\\session@" + sessDate + ".bat", "@echo off & cd \"discordrc\" 2> nul & title DiscordRC " + ver + " & powershell -command \"\"node\\node.exe\" \"main.js\" /e | tee-object \".logs\\.log@" + sessDate + ".log\"\""); } catch { }
                    try { Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\discordrc\\session@" + sessDate + ".bat"); } catch { }
                }
                else
                {
                    settings settings_form = new settings();
                    settings_form.ShowDialog();
                }
            }
        }

        private void exitHandler()
        {
            try { File.Delete("discordrc\\session@" + sessDate + ".bat"); } catch { }
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