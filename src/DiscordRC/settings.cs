using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DiscordRC
{
    public partial class settings : Form
    {
        // configure mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // grab dlls for mousedown
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // configure global variables

        // pathing
        const string dir = "discordrc\\";               // main directory
        const string settingsDir = dir + "_settings\\"; // settings directory
        const string logsDir = dir + "_logs\\";         // logs directory

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Activated(object sender, EventArgs e)
        {
            // create folders
            if (!File.Exists(settingsDir + "_sudoUsers.setting")) try { File.WriteAllText(settingsDir + "_sudoUsers.setting", ""); } catch { }
            if (File.Exists(settingsDir + "_tokenMask"))
            {
                try { tokenBox.Text = File.ReadAllText(settingsDir + "_tokenMask"); } catch { }
                tokenVis(false);
            }
            if (File.Exists(settingsDir + "_enableLogging.setting") || !File.Exists(settingsDir + "_defaults.setting"))
            {
                useLogsCheckbox.Checked = true;
                File.WriteAllText(settingsDir + "_defaults.setting", "");
            }

            rfrshUsrLst();

            #region tooltipDictionary

            // components
            var component = new Control[] {
                exitButton, // 0
                tokenBox, // 1
                acceptTokenButton, // 2
                resetTokenButton, // 3
                useLogsCheckbox, // 4
                clearLogsButton, // 5
                sudoUserAliasBox, // 6
                sudoUserIDBox, // 7
                addSudoUserButton, // 8
                removeSudoUserButton, // 9
                sudoUsersListBox // 10
            };

            // tooltips
            string[] tooltip = {
                "Close", // 0
                "Discord bot token input", // 1
                "Register specified bot token", // 2
                "Reset specified bot token", // 3
                "Enable the saving of console output to a file", // 4
                "Delete all logs with the \".log\" keyword", // 5
                "Nickname for sudo user", // 6
                "ID for sudo user", // 7
                "Add a sudo user with the specified arguments", // 8
                "Remove the selected sudo user", // 9
                "List of registered sudo users", // 10
            };

            #endregion

            // configure tooltips
            for (int i = 0; i < 11; i++) settingsToolTip.SetToolTip(component[i], tooltip[i]);

            // configure tooltip draw
            settingsToolTip.AutoPopDelay = 10000;
            settingsToolTip.OwnerDraw = true;
            settingsToolTip.ForeColor = Color.FromArgb(220, 221, 222);
            settingsToolTip.BackColor = Color.FromArgb(47, 49, 54);
        }

        private void settingsToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void acceptTokenButton_Click(object sender, EventArgs e)
        {
            // configure & store token
            if (tokenBox.Text == "") return;
            int tokenLength = tokenBox.Text.Length;
            string tokenMask = null;
            for (int i = 0; i < tokenLength; i++) { tokenMask += "."; }
            string[] tokenPaths = { settingsDir + "_token.json", settingsDir + "_tokenMask" };
            string[] tokenItems = { "{\"token\":\"" + tokenBox.Text + "\"}", tokenMask };
            for (int i = 0; i < 2; i++)
            {
                try { File.WriteAllText(tokenPaths[i], tokenItems[i]); } catch { }
                try { File.SetAttributes(tokenPaths[i], FileAttributes.Hidden); } catch { }
            }
            tokenVis(false);
        }

        private void resetTokenButton_Click(object sender, EventArgs e)
        {
            // delete token
            string[] tokenPaths = { settingsDir + "_token.json", settingsDir + "_tokenMask" };
            for (int i = 0; i < 2; i++) try { File.Delete(tokenPaths[i]); } catch { }
            tokenVis(true);
        }

        private void useLogsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try { if (useLogsCheckbox.Checked == true) File.WriteAllText(settingsDir + "_enableLogging.setting", ""); else File.Delete(settingsDir + "_enableLogging.setting"); } catch { }
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            new List<string>(Directory.GetFiles(logsDir)).ForEach(file => { if (file.IndexOf(".log", StringComparison.OrdinalIgnoreCase) >= 0) File.Delete(file); });
        }

        private void addSudoUserButton_Click(object sender, EventArgs e)
        {
            if (sudoUserAliasBox.Text != "" && sudoUserIDBox.Text != "")
            {
                try { File.AppendAllText(settingsDir + "_sudoUsers.setting", sudoUserIDBox.Text + "|" + sudoUserAliasBox.Text + "\n"); } catch { }

                rfrshUsrLst();

                sudoUserAliasBox.Text = "";
                sudoUserIDBox.Text = "";
            }
        }

        private void removeSudoUserButton_Click(object sender, EventArgs e)
        {
            try { File.WriteAllLines(settingsDir + "_sudoUsers.setting", File.ReadLines(settingsDir + "_sudoUsers.setting").Where(l => l != File.ReadLines(settingsDir + "_sudoUsers.setting").ElementAt(sudoUsersListBox.SelectedIndex)).ToList()); } catch { }

            while (sudoUsersListBox.SelectedItems.Count > 0) { sudoUsersListBox.Items.Remove(sudoUsersListBox.SelectedItems[0]); }
            if (sudoUsersListBox.Items.Count != 0) sudoUsersListBox.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            componentStyle("exitButton", 237, 66, 69, "White");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            componentStyle("exitButton", 32, 34, 37, "Gray");
        }

        private void titlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void titlebarBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void settingsLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void tokenVis(bool vis)
        {
            if (vis == true) tokenBox.Text = "";
            tokenBox.PasswordChar = vis == true ? '\0' : '•';
            tokenBox.ReadOnly = vis == true ? false : true;
        }

        private void rfrshUsrLst()
        {
            sudoUsersListBox.Items.Clear();
            foreach (string userData in File.ReadAllLines(settingsDir + "_sudoUsers.setting")) sudoUsersListBox.Items.Add(userData.Split('|').ToArray()[1]);
        }

        private void componentStyle(string component, int r, int g, int b, string knownColor)
        {
            if (component == "exitButton")
            {
                exitButton.BackColor = Color.FromArgb(r, g, b);
                exitButton.ForeColor = Color.FromName(knownColor);
            }
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