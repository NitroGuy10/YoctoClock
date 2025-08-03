
namespace YoctoClock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tooltipTitle = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMinimizationReminder = new System.Windows.Forms.CheckBox();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.checkBox24Hour = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowMultiple = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMinmize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(238, 256);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "YoctoClock";
            this.tooltipTitle.SetToolTip(this.lblTitle, "Thanks for using YoctoClock <3\r\n- NitroGuy");
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // tooltipTitle
            // 
            this.tooltipTitle.AutomaticDelay = 1000;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.BackColor = System.Drawing.Color.Black;
            this.pictureBoxClock.Location = new System.Drawing.Point(242, 3);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(76, 69);
            this.pictureBoxClock.TabIndex = 5;
            this.pictureBoxClock.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxMinimizationReminder);
            this.panel1.Controls.Add(this.checkBoxStartup);
            this.panel1.Controls.Add(this.checkBox24Hour);
            this.panel1.Controls.Add(this.checkBoxAllowMultiple);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pictureBoxClock);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 241);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // checkBoxMinimizationReminder
            // 
            this.checkBoxMinimizationReminder.AutoSize = true;
            this.checkBoxMinimizationReminder.Checked = true;
            this.checkBoxMinimizationReminder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizationReminder.Location = new System.Drawing.Point(12, 165);
            this.checkBoxMinimizationReminder.Name = "checkBoxMinimizationReminder";
            this.checkBoxMinimizationReminder.Size = new System.Drawing.Size(155, 17);
            this.checkBoxMinimizationReminder.TabIndex = 2;
            this.checkBoxMinimizationReminder.Text = "Show minimization reminder";
            this.checkBoxMinimizationReminder.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(12, 188);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(102, 17);
            this.checkBoxStartup.TabIndex = 3;
            this.checkBoxStartup.Text = "Open on startup";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            // 
            // checkBox24Hour
            // 
            this.checkBox24Hour.AutoSize = true;
            this.checkBox24Hour.Location = new System.Drawing.Point(12, 142);
            this.checkBox24Hour.Name = "checkBox24Hour";
            this.checkBox24Hour.Size = new System.Drawing.Size(106, 17);
            this.checkBox24Hour.TabIndex = 1;
            this.checkBox24Hour.Text = "Use 24-hour time";
            this.checkBox24Hour.UseVisualStyleBackColor = true;
            this.checkBox24Hour.CheckedChanged += new System.EventHandler(this.checkBox24Hour_CheckedChanged);
            // 
            // checkBoxAllowMultiple
            // 
            this.checkBoxAllowMultiple.AutoSize = true;
            this.checkBoxAllowMultiple.Location = new System.Drawing.Point(12, 211);
            this.checkBoxAllowMultiple.Name = "checkBoxAllowMultiple";
            this.checkBoxAllowMultiple.Size = new System.Drawing.Size(152, 17);
            this.checkBoxAllowMultiple.TabIndex = 4;
            this.checkBoxAllowMultiple.Text = "Allow multiple YoctoClocks";
            this.checkBoxAllowMultiple.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(7, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "(time)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "YoctoClock";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(106, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // lblMinmize
            // 
            this.lblMinmize.AutoSize = true;
            this.lblMinmize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinmize.Location = new System.Drawing.Point(3, 262);
            this.lblMinmize.Name = "lblMinmize";
            this.lblMinmize.Size = new System.Drawing.Size(178, 17);
            this.lblMinmize.TabIndex = 1;
            this.lblMinmize.Text = "So tiny, it\'s almost theoretical";
            this.lblMinmize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.lblMinmize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.lblMinmize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(346, 286);
            this.Controls.Add(this.lblMinmize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YoctoClock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip tooltipTitle;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.CheckBox checkBoxAllowMultiple;
        private System.Windows.Forms.Label lblMinmize;
        private System.Windows.Forms.CheckBox checkBox24Hour;
        private System.Windows.Forms.CheckBox checkBoxStartup;
        private System.Windows.Forms.CheckBox checkBoxMinimizationReminder;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

