using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            this.Top = 0;
            // this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);  
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if(cbShowDate.Checked)
            {
                labelTime.Text += $"\n{DateTime.Today.ToString("dd.MM.yyyy")}";
            }
        }


        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            //this.ShowInTaskbar = visible;
            cbShowDate.Visible = visible;
            HideControls.Visible = visible;
            labelTime.BackColor = visible ? Color.LightGoldenrodYellow: Color.Empty;
            labelTime.Left = visible ? 26 : this.Width - labelTime.Width;
            labelTime.Top = visible ? 21 : 0;
           
        }


        private void HideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(false);
            notifyIconSystemTray.ShowBalloonTip(3, "Crucial information", "To go back click 2 times at the time", ToolTipIcon.Info);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
          SetVisibility(true);
        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = labelTime.Text;
        }



        private void notifyIconSystemTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ContextMenu.Visible == false) ContextMenu.Show(this.Left,this.Top);
                else ContextMenu.Close();
            }
        }

        private void ShowDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowDate.Checked = cbShowDate.Checked ? false : true;
        }
    }
}
