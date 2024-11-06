namespace Clock
{
    partial class AddAlarms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarms));
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxWeek = new System.Windows.Forms.CheckedListBox();
            this.ChooseFileB = new System.Windows.Forms.Button();
            this.ChooseCancelB = new System.Windows.Forms.Button();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExactDate = new System.Windows.Forms.CheckBox();
            this.FileNameSound = new System.Windows.Forms.Label();
            this.OpenFileDialogSound = new System.Windows.Forms.OpenFileDialog();
            this.ChooseOkB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.NavajoWhite;
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.YellowGreen;
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("MingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(14, 61);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerDate.RightToLeftLayout = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(278, 35);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // checkedListBoxWeek
            // 
            this.checkedListBoxWeek.BackColor = System.Drawing.Color.Goldenrod;
            this.checkedListBoxWeek.ColumnWidth = 130;
            this.checkedListBoxWeek.Font = new System.Drawing.Font("Niagara Engraved", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxWeek.ForeColor = System.Drawing.Color.LightYellow;
            this.checkedListBoxWeek.FormattingEnabled = true;
            this.checkedListBoxWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.checkedListBoxWeek.Location = new System.Drawing.Point(14, 103);
            this.checkedListBoxWeek.MultiColumn = true;
            this.checkedListBoxWeek.Name = "checkedListBoxWeek";
            this.checkedListBoxWeek.Size = new System.Drawing.Size(545, 80);
            this.checkedListBoxWeek.TabIndex = 1;
            // 
            // ChooseFileB
            // 
            this.ChooseFileB.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ChooseFileB.Location = new System.Drawing.Point(12, 244);
            this.ChooseFileB.Name = "ChooseFileB";
            this.ChooseFileB.Size = new System.Drawing.Size(148, 41);
            this.ChooseFileB.TabIndex = 2;
            this.ChooseFileB.Text = "Choose File";
            this.ChooseFileB.UseVisualStyleBackColor = true;
            this.ChooseFileB.Click += new System.EventHandler(this.ChooseFileB_Click);
            // 
            // ChooseCancelB
            // 
            this.ChooseCancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ChooseCancelB.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCancelB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ChooseCancelB.Location = new System.Drawing.Point(457, 244);
            this.ChooseCancelB.Name = "ChooseCancelB";
            this.ChooseCancelB.Size = new System.Drawing.Size(102, 41);
            this.ChooseCancelB.TabIndex = 4;
            this.ChooseCancelB.Text = "Cancel";
            this.ChooseCancelB.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarFont = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTime.CalendarForeColor = System.Drawing.Color.NavajoWhite;
            this.dateTimePickerTime.CalendarMonthBackground = System.Drawing.Color.YellowGreen;
            this.dateTimePickerTime.CalendarTitleForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dateTimePickerTime.Font = new System.Drawing.Font("MingLiU-ExtB", 13.8F);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(298, 61);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerTime.RightToLeftLayout = true;
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(262, 35);
            this.dateTimePickerTime.TabIndex = 5;
            // 
            // checkBoxExactDate
            // 
            this.checkBoxExactDate.AutoSize = true;
            this.checkBoxExactDate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.checkBoxExactDate.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExactDate.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxExactDate.Location = new System.Drawing.Point(14, 12);
            this.checkBoxExactDate.Name = "checkBoxExactDate";
            this.checkBoxExactDate.Size = new System.Drawing.Size(174, 34);
            this.checkBoxExactDate.TabIndex = 6;
            this.checkBoxExactDate.Text = "For the exact date";
            this.checkBoxExactDate.UseVisualStyleBackColor = false;
            this.checkBoxExactDate.CheckedChanged += new System.EventHandler(this.checkBoxExactDate_CheckedChanged);
            // 
            // FileNameSound
            // 
            this.FileNameSound.AutoSize = true;
            this.FileNameSound.BackColor = System.Drawing.Color.OliveDrab;
            this.FileNameSound.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameSound.ForeColor = System.Drawing.Color.Yellow;
            this.FileNameSound.Location = new System.Drawing.Point(12, 199);
            this.FileNameSound.Name = "FileNameSound";
            this.FileNameSound.Size = new System.Drawing.Size(91, 30);
            this.FileNameSound.TabIndex = 7;
            this.FileNameSound.Text = "File name:";
            this.FileNameSound.TextChanged += new System.EventHandler(this.FileNameSound_TextChanged);
            // 
            // OpenFileDialogSound
            // 
            this.OpenFileDialogSound.FileName = "OpenFileDialogSound";
            // 
            // ChooseOkB
            // 
            this.ChooseOkB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChooseOkB.Enabled = false;
            this.ChooseOkB.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOkB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ChooseOkB.Location = new System.Drawing.Point(359, 244);
            this.ChooseOkB.Name = "ChooseOkB";
            this.ChooseOkB.Size = new System.Drawing.Size(92, 41);
            this.ChooseOkB.TabIndex = 3;
            this.ChooseOkB.Text = "OK ";
            this.ChooseOkB.UseVisualStyleBackColor = true;
            this.ChooseOkB.Click += new System.EventHandler(this.ChooseOkB_Click);
            // 
            // AddAlarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(572, 297);
            this.Controls.Add(this.FileNameSound);
            this.Controls.Add(this.checkBoxExactDate);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.ChooseCancelB);
            this.Controls.Add(this.ChooseOkB);
            this.Controls.Add(this.ChooseFileB);
            this.Controls.Add(this.checkedListBoxWeek);
            this.Controls.Add(this.dateTimePickerDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAlarms";
            this.Text = "AddAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeek;
        private System.Windows.Forms.Button ChooseFileB;
        private System.Windows.Forms.Button ChooseCancelB;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.CheckBox checkBoxExactDate;
        private System.Windows.Forms.Label FileNameSound;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogSound;
        private System.Windows.Forms.Button ChooseOkB;
    }
}