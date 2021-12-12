namespace ForcedProductivity
{
    partial class Pending_Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pending_Tasks));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.btn_ChangeTask = new System.Windows.Forms.Button();
            this.lbl_PendingTask = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.myNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Body.SuspendLayout();
            this.panel_Upper.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.panel_Upper);
            this.panel_Body.Controls.Add(this.lbl_Clock);
            this.panel_Body.Controls.Add(this.btn_ChangeTask);
            this.panel_Body.Controls.Add(this.lbl_PendingTask);
            this.panel_Body.Controls.Add(this.lbl_Title);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(961, 578);
            this.panel_Body.TabIndex = 0;
            // 
            // panel_Upper
            // 
            this.panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.panel_Upper.Controls.Add(this.btn_Minimize);
            this.panel_Upper.Controls.Add(this.btn_Close);
            this.panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(961, 29);
            this.panel_Upper.TabIndex = 5;
            this.panel_Upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Upper_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Minimize.Location = new System.Drawing.Point(913, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(24, 29);
            this.btn_Minimize.TabIndex = 7;
            this.btn_Minimize.Text = "_";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_Close.Location = new System.Drawing.Point(937, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 29);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lbl_Clock.Location = new System.Drawing.Point(20, 128);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(161, 23);
            this.lbl_Clock.TabIndex = 4;
            this.lbl_Clock.Text = "when it will launch";
            // 
            // btn_ChangeTask
            // 
            this.btn_ChangeTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.btn_ChangeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeTask.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTask.Location = new System.Drawing.Point(841, 537);
            this.btn_ChangeTask.Name = "btn_ChangeTask";
            this.btn_ChangeTask.Size = new System.Drawing.Size(108, 29);
            this.btn_ChangeTask.TabIndex = 3;
            this.btn_ChangeTask.Text = "Change Task";
            this.btn_ChangeTask.UseVisualStyleBackColor = false;
            this.btn_ChangeTask.Click += new System.EventHandler(this.btn_ChangeTask_Click);
            // 
            // lbl_PendingTask
            // 
            this.lbl_PendingTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PendingTask.AutoSize = true;
            this.lbl_PendingTask.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PendingTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(109)))), ((int)(((byte)(191)))));
            this.lbl_PendingTask.Location = new System.Drawing.Point(20, 85);
            this.lbl_PendingTask.Name = "lbl_PendingTask";
            this.lbl_PendingTask.Size = new System.Drawing.Size(237, 23);
            this.lbl_PendingTask.TabIndex = 2;
            this.lbl_PendingTask.Text = "No task has been set up yet!";
            this.lbl_PendingTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(20, 39);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(138, 26);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Pending Task:";
            // 
            // myNotification
            // 
            this.myNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.myNotification.BalloonTipText = "Hey...";
            this.myNotification.BalloonTipTitle = "I Will Stay Here From Now On.";
            this.myNotification.ContextMenuStrip = this.contextMenuStrip1;
            this.myNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotification.Icon")));
            this.myNotification.Text = "Forced Productivity";
            this.myNotification.Visible = true;
            this.myNotification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotification_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAppToolStripMenuItem,
            this.contextMenu_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openAppToolStripMenuItem
            // 
            this.openAppToolStripMenuItem.Name = "openAppToolStripMenuItem";
            this.openAppToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openAppToolStripMenuItem.Text = "Open";
            this.openAppToolStripMenuItem.Click += new System.EventHandler(this.contextMenu_Open_Click);
            // 
            // contextMenu_Exit
            // 
            this.contextMenu_Exit.Name = "contextMenu_Exit";
            this.contextMenu_Exit.Size = new System.Drawing.Size(103, 22);
            this.contextMenu_Exit.Text = "Exit";
            this.contextMenu_Exit.Click += new System.EventHandler(this.contextMenu_Exit_Click);
            // 
            // Pending_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(961, 578);
            this.Controls.Add(this.panel_Body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pending_Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forced Productivity";
            this.Load += new System.EventHandler(this.Pending_Tasks_Load);
            this.Resize += new System.EventHandler(this.Pending_Tasks_Resize);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.panel_Upper.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label lbl_PendingTask;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_ChangeTask;
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.NotifyIcon myNotification;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem openAppToolStripMenuItem;
    }
}