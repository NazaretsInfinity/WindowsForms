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
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadOnWindowsStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.HideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SaveB = new System.Windows.Forms.Button();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.labelTime.ContextMenuStrip = this.ContextMenu;
            this.labelTime.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelTime.Location = new System.Drawing.Point(26, 21);
            this.labelTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(149, 64);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time ✿";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem,
            this.toolStripSeparator1,
            this.showControlsToolStripMenuItem,
            this.showDateToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.fontsToolStripMenuItem,
            this.toolStripSeparator3,
            this.loadOnWindowsStartupToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(250, 196);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.topMostToolStripMenuItem.Text = "TopMost";
            this.topMostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topMostToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.CheckOnClick = true;
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.showControlsToolStripMenuItem.Text = "Show Controls";
            this.showControlsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showControlsToolStripMenuItem_CheckedChanged);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.CheckOnClick = true;
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.showDateToolStripMenuItem.Text = "Show Date";
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.ShowDateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // foregroundColorToolStripMenuItem
            // 
            this.foregroundColorToolStripMenuItem.Name = "foregroundColorToolStripMenuItem";
            this.foregroundColorToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.foregroundColorToolStripMenuItem.Text = "Foreground color";
            this.foregroundColorToolStripMenuItem.Click += new System.EventHandler(this.foregroundColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fontsToolStripMenuItem
            // 
            this.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            this.fontsToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.fontsToolStripMenuItem.Text = "Fonts";
            this.fontsToolStripMenuItem.Click += new System.EventHandler(this.fontsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
            // 
            // loadOnWindowsStartupToolStripMenuItem
            // 
            this.loadOnWindowsStartupToolStripMenuItem.CheckOnClick = true;
            this.loadOnWindowsStartupToolStripMenuItem.Name = "loadOnWindowsStartupToolStripMenuItem";
            this.loadOnWindowsStartupToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.loadOnWindowsStartupToolStripMenuItem.Text = "Load on Windows Startup";
            this.loadOnWindowsStartupToolStripMenuItem.Click += new System.EventHandler(this.loadOnWindowsStartupToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.cbShowDate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbShowDate.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowDate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.cbShowDate.Location = new System.Drawing.Point(25, 136);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(192, 41);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Show Date";
            this.cbShowDate.UseVisualStyleBackColor = false;
            // 
            // HideControls
            // 
            this.HideControls.BackColor = System.Drawing.Color.Olive;
            this.HideControls.ForeColor = System.Drawing.Color.LightYellow;
            this.HideControls.Location = new System.Drawing.Point(25, 183);
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
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.notifyIconSystemTray_DoubleClick);
            this.notifyIconSystemTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseClick);
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.Olive;
            this.SaveB.ForeColor = System.Drawing.Color.LightYellow;
            this.SaveB.Location = new System.Drawing.Point(182, 183);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(94, 51);
            this.SaveB.TabIndex = 3;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(322, 268);
            this.Controls.Add(this.SaveB);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button HideControls;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadOnWindowsStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStripMenuItem foregroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.Button SaveB;
    }
}

