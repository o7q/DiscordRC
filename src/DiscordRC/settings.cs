using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

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

        // misc.
        bool doOnce = false;
        // pathing
        const string dir = "discordrc\\";
        const string settingsDir = dir + "@settings\\";
        const string logsDir = dir + "@logs\\";

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Activated(object sender, EventArgs e)
        {
            if (!File.Exists(settingsDir + "@c_sudoUsers")) try { File.WriteAllText(settingsDir + "@c_sudoUsers", ""); } catch { }

            if (File.Exists(settingsDir + "@token"))
            {
                try { tokenBox.Text = File.ReadAllText(settingsDir + "@token"); } catch { }
                tokenVis(false);
            }

            if (File.Exists(settingsDir + "@c_enableLogging") || !File.Exists(settingsDir + "@c_defaults"))
            {
                useLogsCheckbox.Checked = true;
                File.WriteAllText(settingsDir + "@c_defaults", "");
            }

            if (doOnce == false)
            {
                rfrshUsrLst();

                doOnce = true;
            }
        }

        private void acceptTokenButton_Click(object sender, EventArgs e)
        {
            if (tokenBox.Text == "") return;
            string[] tokenPaths = { settingsDir + "@token.json", settingsDir + "@token" };
            string[] tokenItems = { "{\"token\":\"" + tokenBox.Text + "\"}", tokenBox.Text };
            for (int i = 0; i < 2; i++)
            {
                try { File.WriteAllText(tokenPaths[i], tokenItems[i]); } catch { }
                try { File.SetAttributes(tokenPaths[i], FileAttributes.Hidden); } catch { }
            }
            tokenVis(false);
        }

        private void resetTokenButton_Click(object sender, EventArgs e)
        {
            string[] tokenPaths = { settingsDir + "@token.json", settingsDir + "@token" };
            for (int i = 0; i < 2; i++) try { File.Delete(tokenPaths[i]); } catch { }
            tokenVis(true);
        }

        private void useLogsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try { if (useLogsCheckbox.Checked == true) File.WriteAllText(settingsDir + "@c_enableLogging", ""); else File.Delete(settingsDir + "@c_enableLogging"); } catch { }
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            new List<string>(Directory.GetFiles(logsDir)).ForEach(file => { if (file.IndexOf("@log@", StringComparison.OrdinalIgnoreCase) >= 0) File.Delete(file); });
        }

        private void addSudoUserButton_Click(object sender, EventArgs e)
        {
            if (sudoUserAliasBox.Text != "" && sudoUserIDBox.Text != "")
            {
                try { File.AppendAllText(settingsDir + "@c_sudoUsers", sudoUserIDBox.Text + "|" + sudoUserAliasBox.Text + "\n"); } catch { }

                rfrshUsrLst();

                sudoUserAliasBox.Text = "";
                sudoUserIDBox.Text = "";
            }
        }

        private void removeSudoUserButton_Click(object sender, EventArgs e)
        {
            try { File.WriteAllLines(settingsDir + "@c_sudoUsers", File.ReadLines(settingsDir + "@c_sudoUsers").Where(l => l != File.ReadLines(settingsDir + "@c_sudoUsers").ElementAt(sudoUsersListBox.SelectedIndex)).ToList()); } catch { }

            while (sudoUsersListBox.SelectedItems.Count > 0) { sudoUsersListBox.Items.Remove(sudoUsersListBox.SelectedItems[0]); }
            if (sudoUsersListBox.Items.Count != 0) sudoUsersListBox.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitClr(237, 66, 69, "White");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitClr(32, 34, 37, "Gray");
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
            foreach (string userID in File.ReadAllLines(settingsDir + "@c_sudoUsers"))
            {
                string[] test = userID.Split('|');
                sudoUsersListBox.Items.Add(test[1]);
            }
        }

        private void exitClr(int r, int g, int b, string knownColor)
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