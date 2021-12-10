using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForcedProductivity.Properties;
using System.Timers;
using System.Runtime.InteropServices;

namespace ForcedProductivity
{
    public partial class Pending_Tasks : Form
    {

        #region // Moving The Panel - For the mouse down event \\
        /// <summary>
        /// For making the upper panel able to move the whole windows 
        /// when the mouse is held over
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion
        int minimizeCounter = 0;
        int closeCounter = 0;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        Form1 _Form1 = new Form1();

        // The following 4 lines are supposed to get the system uptime, which is useful to prevent
        // any TASK from launching if the app gets run during the day.
        public static TimeSpan GetUpTime()
        {
            return TimeSpan.FromMilliseconds(GetTickCount64());
        }

        [DllImport("kernel32")]
        extern static UInt64 GetTickCount64();
        public Pending_Tasks()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        public void SendToTray()
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                myNotification.Visible = true;
                myNotification.BalloonTipText = "I Will Stay Here From Now On.";
                myNotification.BalloonTipTitle = "Hey...";
                this.ShowInTaskbar = false;
                if (minimizeCounter == 0)
                {
                    myNotification.ShowBalloonTip(1000);
                    minimizeCounter++;
                }
            }
        }

        private void Pending_Tasks_Load(object sender, EventArgs e)
        {
            if (Settings.Default.selectedTask.ToString() != null && Settings.Default.selectedTask.ToString() != string.Empty)
            {
                lbl_PendingTask.Text = Settings.Default.selectedTask.ToString();
                if (Settings.Default.RunAt_Type == "SpecificTime")
                {
                    lblClock.Text = "will run at " + Settings.Default.setupAlarm.ToString();
                }
                else
                {
                    lblClock.Text = "will run at any next startup!";
                    string[] uptime = GetUpTime().ToString().Split(':');
                    string hours = uptime[0];
                    string minutes = uptime[1];
                    int hourInt = Convert.ToInt32(hours);
                    int minuteInt = Convert.ToInt32(minutes);
                    // Run if uptime is less than 5 minutes
                    if (Settings.Default.HasBeenRun == false && hourInt==0 && minuteInt<5)
                    {
                        this.Close();
                        _Form1.Show();
                    }
                    else if (Settings.Default.HasBeenRun == true)
                    {
                        Settings.Default.HasBeenRun = false;
                        Settings.Default.Save();
                        if (hourInt == 0 && minuteInt < 5)
                        {
                            // Ask user if they want to run the task now?
                            DialogResult answer = MessageBox.Show("Are you sure you want to run the task " +
                                "now?\n\nSystem looks to have been just turned on very recently and we thought\nyou reopened " +
                                "the app because we missed running your scheduled task.\n\nLaucnh Task Now?","Run Task Now", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                            if (answer == DialogResult.Yes)
                            {
                                this.Close();
                                _Form1.Show();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                lbl_PendingTask.Text = "No task has been set up yet!";
            }

            myTimer.Enabled = true;
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            string savedAlarm = Settings.Default.setupAlarm.ToString();
            if (DateTime.Now.ToString("HH:mm").ToString() == savedAlarm)
            {
                //myTimer.Tick -= MyTimer_Tick;
                myTimer.Stop();
                myTimer.Enabled = false;
                this.Close();
                _Form1.Show();
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Tick -= MyTimer_Tick;
            Form2 _Form2 = new Form2();
            _Form2.Show();
            this.Hide();
            myNotification.Visible = false;
            Dispose();
        }

        private void myNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            myNotification.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (closeCounter == 0)
            {
                WindowState = FormWindowState.Minimized;
                SendToTray();
                closeCounter++;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are sure you want to close the application completely? \nThis will cancel any scheduled task!\n\nCompletely Exit Now?", "Be careful!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    myNotification.Visible = false;
                    Application.Exit();
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                    SendToTray();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            SendToTray();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Pending_Tasks_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                myNotification.Visible = false;
            }
        }

        private void contextMenu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are sure you want to close the application completely? \nThis will cancel any scheduled task!\n\nCompletely Exit Now?", "Be careful!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                myNotification.Visible = false;
                Application.Exit();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                SendToTray();
            }
        }

        private void openAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
    }
}
