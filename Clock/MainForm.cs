﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace Clock
{
    public partial class MainForm : Form
    {
        bool nextalarm = true;
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        FontChooser chooseFontDialog;
        AlarmList alarmList;
        Alarm alarm;
        string FontName { get; set; }
        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
            SetFontDirectory();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            alarmList = new AlarmList();
            alarm = new Alarm();
            //Properties.Settings.Default.My_alarms = new System.Collections.Specialized.StringCollection();
            //  LoadSettings();


            //labelTime.BackColor  = Properties.Settings.Default.MyBackColor;  
            //labelTime.ForeColor = Properties.Settings.Default.MyForeColor;

            this.Left = 300;// Screen.PrimaryScreen.Bounds.Width - this.Width;
            this.Top = 0;
            SetVisibility(false);
            chooseFontDialog = new FontChooser();
            // MessageBox.Show($"{Assembly.GetEntryAssembly().Location}", "Message", MessageBoxButtons.OK);
           
        }

        void SaveSettings()
        {
            StreamWriter sw = new StreamWriter("Settings.txt");
            sw.WriteLine(backgroundColorDialog.Color.ToArgb());
            sw.WriteLine(foregroundColorDialog.Color.ToArgb());
            // sw.WriteLine(chooseFontDialog.FontFile.Split('\\').Last());
            sw.Close();
        }
        void LoadSettings()
        {
            StreamReader sr = new StreamReader("Settings.txt");
            List<string> settings = new List<string>();
            while (!sr.EndOfStream)
            {
                settings.Add(sr.ReadLine());
            }
            sr.Close();
            backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[0]));
            foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[1]));
            labelTime.BackColor = backgroundColorDialog.Color;
            labelTime.ForeColor = foregroundColorDialog.Color;

            RegistryKey register = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if ((register.GetValueNames().Contains("THIS ONE")))
                loadOnWindowsStartupToolStripMenuItem.Checked = true;
            register.Dispose();
        }

        void SetFontDirectory()
        {
            string location = Assembly.GetEntryAssembly().Location; // full address to exe file
            string path = Path.GetDirectoryName(location); //from address we extract the way to file
                                                           //MessageBox.Show(Directory.GetCurrentDirectory());
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts");

            //MessageBox.Show(Directory.GetCurrentDirectory());
        }


        //ALARM AND TIMER
        void GetNextAlarm()
        {          
            List<Alarm> alarms = new List<Alarm>();
            foreach (Alarm item in alarmList.ListBoxAlarms.Items)
            {
                alarms.Add(item);
            }
            if (alarms.Min() != null)alarm = alarms.Min();
            Console.WriteLine(alarm);
            nextalarm = false;          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDate.Checked)
            {
                labelTime.Text += $"\n{DateTime.Today.ToString("dd.MM.yyyy")}";
            }

            //here we call GetNextAlarm
            if(alarmList.ListBoxAlarms.Items.Count!=0 && nextalarm)GetNextAlarm();
            
         
            if (DateTime.Now.Hour == alarm.Time.Hour &&
                DateTime.Now.Minute == alarm.Time.Minute &&
                DateTime.Now.Second == alarm.Time.Second &&
                alarm.WeekDaysToString().Contains(DateTime.Now.DayOfWeek.ToString()))
            {
                    MessageBox.Show("Alarm up", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nextalarm = true;
            }
        }


        //CONTROLS
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;
            //this.ShowInTaskbar = visible;
            cbShowDate.Visible = visible;
            HideControls.Visible = visible;
            SaveB.Visible = visible;
            labelTime.Left = visible ? 26 : this.Width - labelTime.Width - 40;
            labelTime.Top = visible ? 21 : 0;
            

        }

        private void HideControls_Click(object sender, EventArgs e)
        {
            //SetVisibility(false);
            showControlsToolStripMenuItem.Checked = false;
            notifyIconSystemTray.ShowBalloonTip(3, "Crucial information", "To go back click 2 times at the time", ToolTipIcon.Info);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {

            showControlsToolStripMenuItem.Checked = true;
            //SetVisibility(true);
        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = labelTime.Text;
        }

        private void notifyIconSystemTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ContextMenu.Visible == false) ContextMenu.Show(this.Left, this.Top);
                else ContextMenu.Close();
            }
        }


        //Context menu options events
        private void ShowDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowDate.Checked = !cbShowDate.Checked;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topMostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topMostToolStripMenuItem.Checked;
        }

        private void showControlsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }


        // LABEL APPEARANCE EVENTS
        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
                Properties.Settings.Default.MyForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
                Properties.Settings.Default.MyBackColor = backgroundColorDialog.Color;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chooseFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.Font = chooseFontDialog.ChosenFont;
            }
        }

        private void loadOnWindowsStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey register = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (!(register.GetValueNames().Contains("THIS ONE")))
            {
                register.SetValue("THIS ONE", Application.ExecutablePath);
                MessageBox.Show("Enabled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loadOnWindowsStartupToolStripMenuItem.Checked = false;
                register.DeleteValue("THIS ONE");
                MessageBox.Show("Disabled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            register.Dispose(); // free resources took by object
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Changes Saved", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.Save();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        //MOVING LABEL
        private void labelTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !HideControls.Visible)
            {
                int x = labelTime.Left + e.X - CursorLoc.X;// e.X and e.Y are relatively labelTime scope(start from its up left corner)
                int y = labelTime.Top + e.Y - CursorLoc.Y;

                if (x > 0 && x < this.Width - labelTime.Width)
                    labelTime.Left = x;                
                if (y > 0 && y < this.Height - labelTime.Height)
                    labelTime.Top = y;
                


            }
        }

        Point CursorLoc { get; set; }
        private void labelTime_MouseDown(object sender, MouseEventArgs e) // 'cause the button is being held down
        {                                                                 // 'click' needs to be released to perform the event.
           CursorLoc = e.Location;
           // if(!HideControls.Visible)
           // this.Location = new Point(0,0);
           // this.Width = Screen.PrimaryScreen.WorkingArea.Width;
           // this.Width = Screen.PrimaryScreen.WorkingArea.Height;
        }
       
       

 

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmList.ShowDialog(this);
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

       
    }
}