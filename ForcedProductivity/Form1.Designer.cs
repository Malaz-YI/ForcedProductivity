namespace ForcedProductivity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_RunTask = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btn_ToggleFullscreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RunTask
            // 
            this.btn_RunTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btn_RunTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RunTask.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RunTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_RunTask.Location = new System.Drawing.Point(27, 31);
            this.btn_RunTask.Name = "btn_RunTask";
            this.btn_RunTask.Size = new System.Drawing.Size(131, 41);
            this.btn_RunTask.TabIndex = 0;
            this.btn_RunTask.Text = "Run Task";
            this.btn_RunTask.UseVisualStyleBackColor = false;
            this.btn_RunTask.Click += new System.EventHandler(this.btn_RunTask_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(131)))), ((int)(((byte)(61)))));
            this.txtTimer.Location = new System.Drawing.Point(27, 78);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(131, 35);
            this.txtTimer.TabIndex = 2;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ToggleFullscreen
            // 
            this.btn_ToggleFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ToggleFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_ToggleFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToggleFullscreen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToggleFullscreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ToggleFullscreen.Location = new System.Drawing.Point(27, 604);
            this.btn_ToggleFullscreen.Name = "btn_ToggleFullscreen";
            this.btn_ToggleFullscreen.Size = new System.Drawing.Size(131, 38);
            this.btn_ToggleFullscreen.TabIndex = 3;
            this.btn_ToggleFullscreen.Text = "Toggle Fullscreen";
            this.btn_ToggleFullscreen.UseVisualStyleBackColor = false;
            this.btn_ToggleFullscreen.Visible = false;
            this.btn_ToggleFullscreen.Click += new System.EventHandler(this.toggleFullScreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1217, 654);
            this.Controls.Add(this.btn_ToggleFullscreen);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btn_RunTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forced Productivity";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RunTask;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button btn_ToggleFullscreen;
    }
}

