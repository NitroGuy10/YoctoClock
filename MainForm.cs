using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoctoClock
{
    public partial class MainForm : Form
    {
        private bool isMouseDown = false;
        private bool showedMinimizationReminder = false;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTimeComponents();
        }

        // Make the window itself draggable
        private void WindowMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void WindowMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the time zone selection and color
            //if (timeZoneComboBox.SelectedValue != null)
            //{
            //    Properties.Settings.Default.LastTimeZone = timeZoneComboBox.SelectedValue.ToString();
            //}
            //Properties.Settings.Default.LastColor = timeLabel.ForeColor;
            //Properties.Settings.Default.Save();
        }

        // Fires every second
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeComponents();
        }

        private void checkBox24Hour_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTimeComponents();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApplication();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();  // Hide from taskbar and screen

                if (checkBoxMinimizationReminder.Checked && !showedMinimizationReminder)
                {
                    showedMinimizationReminder = true;
                    notifyIcon.Visible = true;
                    notifyIcon.ShowBalloonTip(1000, "YoctoClock", "YoctoClock is still running in the system tray.", ToolTipIcon.Info);
                }
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowApplication();
            }
        }


        //string[] options

        //////////

        private void UpdateTimeComponents()
        {
            try
            {
                //// Get the selected TimeZoneInfo object from the ComboBox
                //if (timeZoneComboBox.SelectedItem is TimeZoneInfo selectedTimeZone)
                //{
                //    // Get the current time in UTC
                DateTime utcNow = DateTime.UtcNow;

                // Convert the UTC time to the selected time zone's time
                //DateTime zonedTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, selectedTimeZone);

                // Format the time as 12-hour with AM/PM and update the label
                //timeLabel.Text = zonedTime.ToString("h:mm:ss tt");
                string timeString = utcNow.ToString(checkBox24Hour.Checked ? "HH:mm:ss" : "h:mm:ss tt");
                lblTime.Text = timeString;
                notifyIcon.Text = timeString;
            }
            catch (Exception ex)
            {
                updateTimer.Stop();
                lblTime.Text = "Error";
                MessageBox.Show("An error occurred while updating the time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowApplication()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        
    }
}
