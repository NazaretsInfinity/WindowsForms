namespace Clock
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
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.HideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Silver;
            this.labelTime.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelTime.Location = new System.Drawing.Point(26, 21);
            this.labelTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(195, 55);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time <3";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbShowDate.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cbShowDate.Location = new System.Drawing.Point(25, 119);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(183, 41);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Show Date";
            this.cbShowDate.UseVisualStyleBackColor = false;
            // 
            // HideControls
            // 
            this.HideControls.BackColor = System.Drawing.Color.DarkGray;
            this.HideControls.ForeColor = System.Drawing.Color.DarkBlue;
            this.HideControls.Location = new System.Drawing.Point(25, 166);
            this.HideControls.Name = "HideControls";
            this.HideControls.Size = new System.Drawing.Size(151, 51);
            this.HideControls.TabIndex = 2;
            this.HideControls.Text = "HideControls";
            this.HideControls.UseVisualStyleBackColor = false;
            this.HideControls.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HideControls_Click);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "ClockIcon";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseClick);
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.DateTextBox,
            this.showDateToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(161, 63);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Enabled = false;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.showDateToolStripMenuItem.Text = "ShowDate";
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.ShowDateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(528, 390);
            this.Controls.Add(this.HideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.ContextMenu.ResumeLayout(false);
            this.ContextMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button HideControls;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox DateTextBox;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
    }
}

