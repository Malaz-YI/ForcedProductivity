namespace ForcedProductivity
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.updown_Minute = new System.Windows.Forms.NumericUpDown();
            this.updown_Hour = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.lbl_SelectedPath = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.check_Startup = new System.Windows.Forms.CheckBox();
            this.check_SpecificTime = new System.Windows.Forms.CheckBox();
            this.btn_SetUpTask = new System.Windows.Forms.Button();
            this.txtbox_Alarm = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.updown_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // updown_Minute
            // 
            this.updown_Minute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updown_Minute.Location = new System.Drawing.Point(625, 266);
            this.updown_Minute.Margin = new System.Windows.Forms.Padding(4);
            this.updown_Minute.Name = "updown_Minute";
            this.updown_Minute.Size = new System.Drawing.Size(87, 27);
            this.updown_Minute.TabIndex = 1;
            this.updown_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updown_Minute.ValueChanged += new System.EventHandler(this.updown_Minute_ValueChanged);
            // 
            // updown_Hour
            // 
            this.updown_Hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updown_Hour.Location = new System.Drawing.Point(499, 266);
            this.updown_Hour.Margin = new System.Windows.Forms.Padding(4);
            this.updown_Hour.Name = "updown_Hour";
            this.updown_Hour.Size = new System.Drawing.Size(87, 27);
            this.updown_Hour.TabIndex = 2;
            this.updown_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updown_Hour.ValueChanged += new System.EventHandler(this.updown_Hour_ValueChanged);
            // 
            // lblHour
            // 
            this.lblHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(515, 243);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(51, 19);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Hours";
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMinutes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(635, 243);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(67, 19);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minutes";
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectFile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SelectFile.Location = new System.Drawing.Point(499, 82);
            this.btn_SelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SelectFile.Size = new System.Drawing.Size(213, 66);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "Select File Or App";
            this.btn_SelectFile.UseMnemonic = false;
            this.btn_SelectFile.UseVisualStyleBackColor = false;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // lbl_SelectedPath
            // 
            this.lbl_SelectedPath.AutoSize = true;
            this.lbl_SelectedPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_SelectedPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_SelectedPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_SelectedPath.Location = new System.Drawing.Point(0, 640);
            this.lbl_SelectedPath.Name = "lbl_SelectedPath";
            this.lbl_SelectedPath.Size = new System.Drawing.Size(62, 18);
            this.lbl_SelectedPath.TabIndex = 5;
            this.lbl_SelectedPath.Text = "______";
            this.lbl_SelectedPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.Location = new System.Drawing.Point(499, 194);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(213, 27);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Set Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_Startup
            // 
            this.check_Startup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_Startup.AutoSize = true;
            this.check_Startup.Location = new System.Drawing.Point(538, 345);
            this.check_Startup.Name = "check_Startup";
            this.check_Startup.Size = new System.Drawing.Size(134, 23);
            this.check_Startup.TabIndex = 3;
            this.check_Startup.Text = "Run At Startup";
            this.check_Startup.UseVisualStyleBackColor = true;
            this.check_Startup.CheckedChanged += new System.EventHandler(this.checkStartup_CheckedChanged);
            // 
            // check_SpecificTime
            // 
            this.check_SpecificTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_SpecificTime.AutoSize = true;
            this.check_SpecificTime.Location = new System.Drawing.Point(506, 396);
            this.check_SpecificTime.Name = "check_SpecificTime";
            this.check_SpecificTime.Size = new System.Drawing.Size(199, 23);
            this.check_SpecificTime.TabIndex = 4;
            this.check_SpecificTime.Text = "Run At A Specific Time";
            this.check_SpecificTime.UseVisualStyleBackColor = true;
            this.check_SpecificTime.CheckedChanged += new System.EventHandler(this.check_SpecificTime_CheckedChanged);
            // 
            // btn_SetUpTask
            // 
            this.btn_SetUpTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SetUpTask.BackColor = System.Drawing.Color.White;
            this.btn_SetUpTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetUpTask.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetUpTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btn_SetUpTask.Location = new System.Drawing.Point(499, 530);
            this.btn_SetUpTask.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SetUpTask.Name = "btn_SetUpTask";
            this.btn_SetUpTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SetUpTask.Size = new System.Drawing.Size(213, 66);
            this.btn_SetUpTask.TabIndex = 6;
            this.btn_SetUpTask.Text = "Set Up Task";
            this.btn_SetUpTask.UseMnemonic = false;
            this.btn_SetUpTask.UseVisualStyleBackColor = false;
            this.btn_SetUpTask.Visible = false;
            this.btn_SetUpTask.Click += new System.EventHandler(this.btn_SetUpTask_Click);
            // 
            // txtbox_Alarm
            // 
            this.txtbox_Alarm.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbox_Alarm.Location = new System.Drawing.Point(499, 445);
            this.txtbox_Alarm.Name = "txtbox_Alarm";
            this.txtbox_Alarm.Size = new System.Drawing.Size(213, 27);
            this.txtbox_Alarm.TabIndex = 5;
            this.txtbox_Alarm.Text = "13:25";
            this.txtbox_Alarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtbox_Alarm, "Enter time in the 24H format.\r\nExample: 12:05 AM should be typed as (00:05).");
            this.txtbox_Alarm.Visible = false;
            this.txtbox_Alarm.Enter += new System.EventHandler(this.txtbox_Alarm_Enter);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ShowAlways = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.txtbox_Alarm);
            this.Controls.Add(this.btn_SetUpTask);
            this.Controls.Add(this.check_SpecificTime);
            this.Controls.Add(this.check_Startup);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lbl_SelectedPath);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.updown_Hour);
            this.Controls.Add(this.updown_Minute);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Up A Task";
            ((System.ComponentModel.ISupportInitialize)(this.updown_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_Hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updown_Minute;
        private System.Windows.Forms.NumericUpDown updown_Hour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Label lbl_SelectedPath;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.CheckBox check_Startup;
        private System.Windows.Forms.CheckBox check_SpecificTime;
        private System.Windows.Forms.Button btn_SetUpTask;
        private System.Windows.Forms.TextBox txtbox_Alarm;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}