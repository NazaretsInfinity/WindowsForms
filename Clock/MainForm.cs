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
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        public MainForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            //this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            this.Top = 0;
            SetVisibility(false);
           
           backgroundColorDialog = new ColorDialog();
           foregroundColorDialog = new ColorDialog();
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
            labelTime.BackColor = visible ? Color.LightGoldenrodYellow: Color.LightYellow;
            labelTime.Left = visible ? 26 : this.Width - labelTime.Width;
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
            if(!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
            }
        }
    }
}
