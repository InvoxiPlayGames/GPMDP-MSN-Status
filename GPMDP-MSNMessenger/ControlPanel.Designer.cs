namespace GPMDP_MSNMessenger
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appTitleText = new System.Windows.Forms.Label();
            this.appSubtitleText = new System.Windows.Forms.Label();
            this.currentlyPlayingLabel = new System.Windows.Forms.Label();
            this.currentlyPlayingText = new System.Windows.Forms.Label();
            this.statusesEnabledCheck = new System.Windows.Forms.CheckBox();
            this.statusesEnabledLabel = new System.Windows.Forms.Label();
            this.ShowPausedLabel = new System.Windows.Forms.Label();
            this.ShowPausedCheck = new System.Windows.Forms.CheckBox();
            this.StartWindowsLabel = new System.Windows.Forms.Label();
            this.StartWindowsCheck = new System.Windows.Forms.CheckBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.iconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.ContextMenuStrip = this.iconContextMenu;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "GPMDP MSN Status";
            this.notificationIcon.Visible = true;
            this.notificationIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notificationIcon_DoubleClick);
            // 
            // iconContextMenu
            // 
            this.iconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWindowToolStripMenuItem,
            this.enabledToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.iconContextMenu.Name = "contextMenuStrip1";
            this.iconContextMenu.Size = new System.Drawing.Size(154, 76);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openWindowToolStripMenuItem.Text = "Open Window";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.CheckOnClick = true;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appTitleText
            // 
            this.appTitleText.AutoSize = true;
            this.appTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleText.Location = new System.Drawing.Point(12, 9);
            this.appTitleText.Name = "appTitleText";
            this.appTitleText.Size = new System.Drawing.Size(351, 15);
            this.appTitleText.TabIndex = 0;
            this.appTitleText.Text = "GPMDP MSN Status by InvoxiPlayGames (version 1.0)";
            // 
            // appSubtitleText
            // 
            this.appSubtitleText.AutoSize = true;
            this.appSubtitleText.Location = new System.Drawing.Point(12, 24);
            this.appSubtitleText.Name = "appSubtitleText";
            this.appSubtitleText.Size = new System.Drawing.Size(146, 13);
            this.appSubtitleText.TabIndex = 1;
            this.appSubtitleText.Text = "For use with MSN Messenger";
            // 
            // currentlyPlayingLabel
            // 
            this.currentlyPlayingLabel.AutoSize = true;
            this.currentlyPlayingLabel.Location = new System.Drawing.Point(12, 50);
            this.currentlyPlayingLabel.Name = "currentlyPlayingLabel";
            this.currentlyPlayingLabel.Size = new System.Drawing.Size(88, 13);
            this.currentlyPlayingLabel.TabIndex = 2;
            this.currentlyPlayingLabel.Text = "Currently Playing:";
            // 
            // currentlyPlayingText
            // 
            this.currentlyPlayingText.AutoSize = true;
            this.currentlyPlayingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyPlayingText.Location = new System.Drawing.Point(137, 50);
            this.currentlyPlayingText.Name = "currentlyPlayingText";
            this.currentlyPlayingText.Size = new System.Drawing.Size(77, 13);
            this.currentlyPlayingText.TabIndex = 3;
            this.currentlyPlayingText.Text = "Artist - Song";
            // 
            // statusesEnabledCheck
            // 
            this.statusesEnabledCheck.AutoSize = true;
            this.statusesEnabledCheck.Location = new System.Drawing.Point(13, 74);
            this.statusesEnabledCheck.Name = "statusesEnabledCheck";
            this.statusesEnabledCheck.Size = new System.Drawing.Size(109, 17);
            this.statusesEnabledCheck.TabIndex = 4;
            this.statusesEnabledCheck.Text = "Statuses Enabled";
            this.statusesEnabledCheck.UseVisualStyleBackColor = true;
            this.statusesEnabledCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusesEnabledLabel
            // 
            this.statusesEnabledLabel.AutoSize = true;
            this.statusesEnabledLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.statusesEnabledLabel.Location = new System.Drawing.Point(170, 75);
            this.statusesEnabledLabel.Name = "statusesEnabledLabel";
            this.statusesEnabledLabel.Size = new System.Drawing.Size(207, 13);
            this.statusesEnabledLabel.TabIndex = 5;
            this.statusesEnabledLabel.Text = "(Make sure to have them enabled in MSN)";
            // 
            // ShowPausedLabel
            // 
            this.ShowPausedLabel.AutoSize = true;
            this.ShowPausedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ShowPausedLabel.Location = new System.Drawing.Point(186, 98);
            this.ShowPausedLabel.Name = "ShowPausedLabel";
            this.ShowPausedLabel.Size = new System.Drawing.Size(192, 13);
            this.ShowPausedLabel.TabIndex = 7;
            this.ShowPausedLabel.Text = "Stops showing the status when paused";
            // 
            // ShowPausedCheck
            // 
            this.ShowPausedCheck.AutoSize = true;
            this.ShowPausedCheck.Location = new System.Drawing.Point(13, 97);
            this.ShowPausedCheck.Name = "ShowPausedCheck";
            this.ShowPausedCheck.Size = new System.Drawing.Size(157, 17);
            this.ShowPausedCheck.TabIndex = 6;
            this.ShowPausedCheck.Text = "Stop showing when paused";
            this.ShowPausedCheck.UseVisualStyleBackColor = true;
            this.ShowPausedCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // StartWindowsLabel
            // 
            this.StartWindowsLabel.AutoSize = true;
            this.StartWindowsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StartWindowsLabel.Location = new System.Drawing.Point(256, 121);
            this.StartWindowsLabel.Name = "StartWindowsLabel";
            this.StartWindowsLabel.Size = new System.Drawing.Size(121, 13);
            this.StartWindowsLabel.TabIndex = 9;
            this.StartWindowsLabel.Text = "Coming soon. Someday.";
            // 
            // StartWindowsCheck
            // 
            this.StartWindowsCheck.AutoSize = true;
            this.StartWindowsCheck.Enabled = false;
            this.StartWindowsCheck.Location = new System.Drawing.Point(13, 120);
            this.StartWindowsCheck.Name = "StartWindowsCheck";
            this.StartWindowsCheck.Size = new System.Drawing.Size(117, 17);
            this.StartWindowsCheck.TabIndex = 8;
            this.StartWindowsCheck.Text = "Start with Windows";
            this.StartWindowsCheck.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(301, 140);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(12, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 1000;
            this.statusTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ControlPanel
            // 
            this.AcceptButton = this.doneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.StartWindowsLabel);
            this.Controls.Add(this.StartWindowsCheck);
            this.Controls.Add(this.ShowPausedLabel);
            this.Controls.Add(this.ShowPausedCheck);
            this.Controls.Add(this.statusesEnabledLabel);
            this.Controls.Add(this.statusesEnabledCheck);
            this.Controls.Add(this.currentlyPlayingText);
            this.Controls.Add(this.currentlyPlayingLabel);
            this.Controls.Add(this.appSubtitleText);
            this.Controls.Add(this.appTitleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 210);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPMDP MSN Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.iconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.Label appTitleText;
        private System.Windows.Forms.Label appSubtitleText;
        private System.Windows.Forms.Label currentlyPlayingLabel;
        private System.Windows.Forms.Label currentlyPlayingText;
        private System.Windows.Forms.CheckBox statusesEnabledCheck;
        private System.Windows.Forms.Label statusesEnabledLabel;
        private System.Windows.Forms.Label ShowPausedLabel;
        private System.Windows.Forms.CheckBox ShowPausedCheck;
        private System.Windows.Forms.Label StartWindowsLabel;
        private System.Windows.Forms.CheckBox StartWindowsCheck;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ContextMenuStrip iconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer statusTimer;
    }
}

