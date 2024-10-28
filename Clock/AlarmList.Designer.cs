namespace Clock
{
    partial class AlarmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList));
            this.AlarmsList = new System.Windows.Forms.ListBox();
            this.AddB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlarmsList
            // 
            this.AlarmsList.BackColor = System.Drawing.Color.OliveDrab;
            this.AlarmsList.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmsList.ForeColor = System.Drawing.Color.Gold;
            this.AlarmsList.FormattingEnabled = true;
            this.AlarmsList.ItemHeight = 29;
            this.AlarmsList.Location = new System.Drawing.Point(12, 22);
            this.AlarmsList.Name = "AlarmsList";
            this.AlarmsList.Size = new System.Drawing.Size(494, 178);
            this.AlarmsList.TabIndex = 0;
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.AddB.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddB.ForeColor = System.Drawing.Color.OldLace;
            this.AddB.Location = new System.Drawing.Point(512, 67);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(136, 51);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Add";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddB_MouseClick);
            // 
            // CancelB
            // 
            this.CancelB.BackColor = System.Drawing.Color.Tan;
            this.CancelB.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Bold);
            this.CancelB.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.CancelB.Location = new System.Drawing.Point(512, 124);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(136, 51);
            this.CancelB.TabIndex = 2;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = false;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(671, 220);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.AlarmsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmList";
            this.Text = "AlarmList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AlarmsList;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button CancelB;
    }
}