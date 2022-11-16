using System;
using System.IO;
using System.Timers;
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

        // configure global variables

        // misc.
        const string ver = "v1.1.0"; // version
        string sessDate; // session date
        int logReaderState = 0; // log reader state
        string logReaderInfo = "         [Click to show the previous log]"; // log reader info
        // pathing
        const string dir = "discordrc\\"; // main directory
        const string settingsDir = dir + "_settings\\"; // settings directory
        const string logsDir = dir + "_logs\\"; // logs directory

        public program()
        {
            InitializeComponent();
        }

        private void program_Load(object sender, EventArgs e)
        {
            // create folders
            try { Directory.CreateDirectory(settingsDir); } catch { }
            try { Directory.CreateDirectory(logsDir); } catch { }
            // create files
            try { File.WriteAllText(dir + "_start_debug.bat", "@echo off & cd \"discordrc\" 2> nul & title DiscordRC " + ver + "   [DEBUG] & powershell -command \"\"node\\node.exe\" \"main.js\" /e | tee-object \"_logs\\_debug.log\"\""); } catch { }

            // configure visuals
            logBox.Text = logReaderInfo;
            sessionInfoLabel.Text = "";

            // configure & start doTick
            System.Timers.Timer tick = new System.Timers.Timer();
            tick.Elapsed += new ElapsedEventHandler(doTick);
            tick.Interval = 1000;
            tick.Enabled = true;

            #region tooltipDictionary

            // components
            var component = new Control[] {
                minimizeButton, // 0
                exitButton, // 1
                logBox, // 2
                statusPicture, // 3
                sessionInfoLabel, // 4
                verLabel, // 5
                startButton, // 6
                settingsButton // 7
            };

            // tooltips
            string[] tooltip = {
                "Minimize", // 0
                "Close", // 1
                "Latest bot log (click to toggle view on and off)", // 2
                "Bot status", // 3
                "Session ID", // 4
                "Running " + ver, // 5
                "Start DiscordRC", // 6
                "Open the settings window", // 7
            };

            #endregion

            // configure tooltips
            for (int i = 0; i < 8; i++) programToolTip.SetToolTip(component[i], tooltip[i]);

            // configure tooltip draw
            programToolTip.AutoPopDelay = 10000;
            programToolTip.OwnerDraw = true;
            programToolTip.ForeColor = Color.FromArgb(220, 221, 222);
            programToolTip.BackColor = Color.FromArgb(47, 49, 54);
        }

        // draw tooltips
        private void programToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void doTick(object source, ElapsedEventArgs e)
        {
            processHandler(2);
        }

        private void program_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitHandler();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            processHandler(0);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            processHandler(1);
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

        private void logBox_MouseClick(object sender, MouseEventArgs e)
        {
            // refresh logbox
            if (logReaderState == 0)
            {
                string[] logPaths = { logsDir + "_latest.log", logsDir + "_" + sessDate + ".log" };
                for (int i = 0; i < 2; i++) try { logBox.Text = File.ReadAllText(logPaths[i]); } catch { }
                try { File.WriteAllText(logsDir + "_latest.log", logBox.Text); } catch { }
                if (logBox.Text != logReaderInfo) componentStyle("logBox", 220, 221, 222, null);
                logReaderState = 1;
            }
            else
            {
                logBox.Text = logReaderInfo;
                componentStyle("logBox", 120, 121, 122, null);
                logReaderState = 0;
            }
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

        private void processHandler(int mode, bool progOpen = false)
        {
            // check if rcbot is already running
            foreach (Process progOpenCheck in Process.GetProcesses()) if (progOpenCheck.ProcessName.Contains("rcbot_transit_dummy")) progOpen = true;
            if (progOpen == false)
            {
                componentStyle("statusOffline", 220, 221, 222, null);
                if (mode == 0)
                {
                    // check if the token is configured
                    if (!File.Exists(settingsDir + "_token.json"))
                    {
                        MessageBox.Show("Your bot token is not configured.");
                        return;
                    }

                    // start rcbot
                    logBox.Text = logReaderInfo;
                    try { File.WriteAllText(logsDir + "_latest.log", logBox.Text); } catch { }
                    componentStyle("logBox", 120, 121, 122, null);
                    sessDate = DateTime.Now.ToString("Mdy-hms");
                    sessionInfoLabel.Text = "Session ID: " + sessDate;
                    try { File.WriteAllText(dir + "_start.bat", File.Exists(settingsDir + "_enableLogging.setting") ? "@echo off & cd \"discordrc\" 2> nul & title DiscordRC " + ver + "   [" + sessDate + "] & powershell -command \"\"node\\node.exe\" \"main.js\" /e | tee-object \"_logs\\_" + sessDate + ".log\"\"" : "@echo off & cd \"discordrc\" 2> nul & title DiscordRC " + ver + "   [" + sessDate + "] & \"node\\node.exe\" \"main.js\""); } catch { }
                    ProcessStartInfo rcbot = new ProcessStartInfo();
                    rcbot.WindowStyle = ProcessWindowStyle.Minimized;
                    rcbot.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + dir + "_start.bat";
                    Process.Start(rcbot);
                }
                if (mode == 1)
                {
                    settings settings_form = new settings();
                    settings_form.ShowDialog();
                }
            }
            else componentStyle("statusOnline", 120, 121, 122, null);
        }

        private void exitHandler()
        {
            try { File.Delete(dir + "_start.bat"); } catch { }
        }

        private void componentStyle(string component, int r, int g, int b, string knownColor)
        {
            // exit button styling
            if (component == "exitButton")
            {
                exitButton.BackColor = Color.FromArgb(r, g, b);
                exitButton.ForeColor = Color.FromName(knownColor);
            }

            // logbox styling
            if (component == "logBox") logBox.ForeColor = Color.FromArgb(r, g, b);

            // status styling
            if (component == "statusOnline" || component == "statusOffline")
            {
                startButton.ForeColor = Color.FromArgb(r, g, b);
                settingsButton.Image = component == "statusOnline" ? Properties.Resources.cogOff : Properties.Resources.cog;
                statusPicture.Image = component == "statusOnline" ? Properties.Resources.online : Properties.Resources.offline;
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