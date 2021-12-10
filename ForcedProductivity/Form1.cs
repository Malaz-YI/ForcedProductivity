using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ForcedProductivity.Properties;

namespace ForcedProductivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int hour = Convert.ToInt32(Settings.Default.taskDurationHour);
            int minute = Convert.ToInt32(Settings.Default.taskDurationMinute);
            this.ShowInTaskbar = false;
        }
        public System.Windows.Forms.Timer myCountdown = new System.Windows.Forms.Timer();

        public int hours = Convert.ToInt32(Settings.Default.taskDurationHour);
        public int minutes = Convert.ToInt32(Settings.Default.taskDurationMinute);
        public int seconds = 1;


        public void TimerStart() {
            myCountdown.Tick -= MyCountdown_Tick;
            myCountdown.Enabled = true;
            myCountdown.Interval = 1000;
            myCountdown.Start();
            myCountdown.Tick += MyCountdown_Tick;
        }

        private void MyCountdown_Tick(object sender, EventArgs e)
        {
            if (hours>0 || minutes>0 || seconds>=0)
            {
                txtTimer.Text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
                if (seconds>0)
                {
                    seconds = seconds - 1;
                    if (seconds == 0 && minutes>0)
                    {
                        minutes = minutes - 1;
                        seconds = 59;
                    }
                    if (minutes == 0 && hours > 0)
                    {
                        hours = hours - 1;
                        minutes = 59;
                    }
                }
                else
                {
                    myCountdown.Enabled = false;
                    myCountdown.Stop();
                    toggleFullScreen.Visible = true;
                    System.Media.SoundPlayer endSound = new System.Media.SoundPlayer(@".\567205__ddmyzik__simple-clean-logo.wav");
                    endSound.Play();
                    Settings.Default.HasBeenRun = true;
                    Settings.Default.Save();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Redo at the end: !important
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@".\567204__ddmyzik__announcement-sound-4.wav");
            startSound.Play();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void button1_Click(object sender, EventArgs e)
        {
            myCountdown.Dispose();
            TimerStart();
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @Settings.Default["selectedTask"].ToString();
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            try
            {
                ExternalProcess.Start();
                ExternalProcess.WaitForInputIdle();
                while(ExternalProcess.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100);
                    ExternalProcess.Refresh();
                }
                SetParent(ExternalProcess.MainWindowHandle, this.Handle);
                this.WindowState = FormWindowState.Maximized;
             }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong!\n\nDetails:{ex.Message}");
                myCountdown.Enabled = false;
                myCountdown.Stop();
                toggleFullScreen.Visible = true;
                Settings.Default.HasBeenRun = true;
                Settings.Default.Save();
            }

        }

        private void toggleFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState ==  FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
