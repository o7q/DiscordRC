using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
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

        const string settingsDir = "discordrc\\.settings";

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingsDir + "\\.token"))
            {
                try { tokenBox.Text = File.ReadAllText(settingsDir + "\\.token"); } catch { }
                tokenVis(false);
            }
        }

        private void acceptTokenButton_Click(object sender, EventArgs e)
        {
            string[] tokenPaths = { settingsDir + "\\.token.json", settingsDir + "\\.token" };
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
            string[] tokenPaths = { settingsDir + "\\.token.json", settingsDir + "\\.token" };
            for (int i = 0; i < 2; i++) try { File.Delete(tokenPaths[i]); } catch { }
            tokenVis(true);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tokenVis(bool vis)
        {
            if (vis == true)
            {
                tokenBox.Text = "";
                tokenBox.PasswordChar = '\0';
                tokenBox.ReadOnly = false;
            }
            if (vis == false)
            {
                tokenBox.PasswordChar = '•';
                tokenBox.ReadOnly = true;
            }
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

        private void settingsLabel_MouseDown(object sender, MouseEventArgs e)
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