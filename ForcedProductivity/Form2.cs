using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForcedProductivity.Properties;

namespace ForcedProductivity
{
    public partial class Form2 : Form
    {
        OpenFileDialog selectFile;
        public Form2()
        {
            InitializeComponent();
            btn_SelectFile.FlatAppearance.BorderSize = 0;
            btn_SelectFile.AutoSize = false;
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            selectFile = new OpenFileDialog();
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                lbl_SelectedPath.Text = "Selected File: " + selectFile.FileName;
                Settings.Default["selectedTask"] = selectFile.FileName;
            }

            if (check_Startup.Checked == true && selectFile != null)
            {
                check_SpecificTime.Enabled = false;
                if (updown_Hour.Value > 0 || updown_Minute.Value > 0)
                {
                    if (selectFile != null && selectFile.FileName !="")
                    {
                        btn_SetUpTask.Visible = true;
                    }
                }
            }
            else
            {
                check_SpecificTime.Enabled = true;
                btn_SetUpTask.Visible = false;
            }
        }

        private void checkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Startup.Checked == true)
            {
                check_SpecificTime.Enabled = false;
                if (updown_Hour.Value > 0 || updown_Minute.Value > 0)
                {
                    if (selectFile != null)
                    {
                        btn_SetUpTask.Visible = true;
                        Settings.Default["RunAt_Type"] = "Startup";
                    }
                }
            }
            else
            {
                check_SpecificTime.Enabled = true;
                btn_SetUpTask.Visible = false;
            }
        }

        private void updown_Minute_ValueChanged(object sender, EventArgs e)
        {
            if ((updown_Minute.Value > 0 || updown_Hour.Value >0) && 
                check_Startup.Checked == true &&
                selectFile != null)
            {
                btn_SetUpTask.Visible = true;
            }
            else if ((updown_Minute.Value > 0 || updown_Hour.Value > 0) &&
                check_SpecificTime.Checked == true &&
                selectFile != null)
            {
                btn_SetUpTask.Visible = true;
            }
            else if (updown_Hour.Value <= 0 || updown_Minute.Value <= 0)
            {
                btn_SetUpTask.Visible = false;
            }
        }

        private void updown_Hour_ValueChanged(object sender, EventArgs e)
        {
            if ((updown_Minute.Value > 0 || updown_Hour.Value > 0) &&
                check_Startup.Checked == true &&
                selectFile != null)
            {
                btn_SetUpTask.Visible = true;
            }
            else if ((updown_Minute.Value > 0 || updown_Hour.Value > 0) &&
                check_SpecificTime.Checked == true &&
                selectFile != null)
            {
                btn_SetUpTask.Visible = true;
            }
            else if (updown_Hour.Value <= 0 || updown_Minute.Value <= 0)
            {
                btn_SetUpTask.Visible = false;
            }
        }

        private void check_SpecificTime_CheckedChanged(object sender, EventArgs e)
        {
            if (check_SpecificTime.Checked)
            {
                txtbox_Alarm.Visible = true;
                check_Startup.Enabled = false;
                Settings.Default["RunAt_Type"] = "SpecificTime";
                if (updown_Hour.Value > 0 || updown_Minute.Value > 0)
                {
                    btn_SetUpTask.Visible = true;
                }
                else
                {
                    btn_SetUpTask.Visible = false;
                }
            }
            else
            {
                txtbox_Alarm.Visible = false;
                check_Startup.Enabled = true;
            }
        
        }

        private void btn_SetUpTask_Click(object sender, EventArgs e)
        {
            Pending_Tasks formPendingTasks = new Pending_Tasks();
            if (check_Startup.Checked && selectFile.FileName != string.Empty && (updown_Hour.Value>0 || updown_Minute.Value>0))
            {

                // Run on startup
                string fileToCopy = @".\shortcut_RunAtStartup.lnk";
                string destinationDirectory = $"C:\\Users\\{Environment.UserName.ToString()}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
                File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy), true);

                // Store Variables & Go
                Settings.Default.RunAt_Type = "Startup";
                Settings.Default["selectedTask"] = selectFile.FileName;
                Settings.Default["taskDurationHour"] = updown_Hour.Value;
                Settings.Default["taskDurationMinute"] = updown_Minute.Value;
                Settings.Default.HasBeenRun = true;
                Settings.Default.Save();
                Pending_Tasks pendingTaks = new Pending_Tasks();
                pendingTaks.Show();
                this.Close();
            }
            else if (check_SpecificTime.Checked && selectFile != null && (updown_Hour.Value > 0 || updown_Minute.Value > 0) && txtbox_Alarm.Text != String.Empty)
            {
                try
                {
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-' };
                    string[] enteredAlarm_Text = txtbox_Alarm.Text.Trim().Split(delimiterChars);
                    string selectedAlarm_Hours = enteredAlarm_Text[0].ToString();
                    string selectedAlarm_Minutes = enteredAlarm_Text[1].ToString();
                    Settings.Default["setupAlarm"] = selectedAlarm_Hours + ":" + selectedAlarm_Minutes;
                    Settings.Default.RunAt_Type = "SpecificTime";
                    Settings.Default["selectedTask"] = selectFile.FileName;
                    Settings.Default["taskDurationHour"] = updown_Hour.Value;
                    Settings.Default["taskDurationMinute"] = updown_Minute.Value;
                    Pending_Tasks pendingTaks = new Pending_Tasks();

                    // Run on startup
                    string fileToCopy = @".\shortcut_RunAtStartup.lnk";
                    string destinationDirectory = $"C:\\Users\\{Environment.UserName.ToString()}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
                    File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy), true);
                    Settings.Default.Save();
                    this.Close();
                    pendingTaks.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Make sure you selected a file and entered a valid clock format!", "Check out time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Some information is still missing, make sure\n you entered everything correctly!", "Do A Recheck Please", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtbox_Alarm_Enter(object sender, EventArgs e)
        {
            txtbox_Alarm.Text = "";
            txtbox_Alarm.ForeColor = Color.Black;
            txtbox_Alarm.Enter -= txtbox_Alarm_Enter;
        }
    }
}
