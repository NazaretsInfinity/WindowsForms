using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AddAlarms : Form
    {
        internal Alarm alarm { get; set; }
        
        public AddAlarms()
        {
            InitializeComponent();
            alarm = new Alarm();
            FileNameSound.MaximumSize = new Size(this.Width - 25, 30);
            OpenFileDialogSound.Filter = "MP-3 (*.mp3)|*.mp3|Flac (*.flac)|*.flac|All Audio|*.mp3;*flac";
        }
        public AddAlarms(string stralarm)
        {
            InitializeComponent();
            string[] comps = stralarm.Split(',');
            if (comps[0].Contains('/'))
            {
                checkBoxExactDate.Checked = true;
                dateTimePickerDate.Text = comps[0];
                dateTimePickerTime.Text = comps[1];

            }
            else
            {
                checkBoxExactDate.Checked = false;
                dateTimePickerTime.Text = comps[0];
                for (int i = 1; i < comps.Length; ++i)
                {
                    if (Alarm.WeekDayNames.Contains(comps[i]))
                    {
                        checkedListBoxWeek.SetItemChecked(i, true);
                    }
                }
            }
        }


        void initAlarm()
        {
            if (dateTimePickerDate.Enabled)alarm.Date = dateTimePickerDate.Value;
            alarm.Time = dateTimePickerTime.Value;
            alarm.Filename = FileNameSound.Text;
            for (int i = 0; i < checkedListBoxWeek.CheckedIndices.Count; ++i)
            {
                alarm.Weekdays[checkedListBoxWeek.CheckedIndices[i]] = true;
                Console.Write(checkedListBoxWeek.CheckedIndices[i] + "\t");
   // Property 'ChecckedIndices' is a collection, which contents  indexes of choosen Checks in checklistbox
            }
            Console.WriteLine();
        }
       

        private void checkBoxExactDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
            checkedListBoxWeek.Enabled = !((CheckBox)sender).Checked;
        }

        private void ChooseOkB_Click(object sender, EventArgs e)
        {
          initAlarm();
        }

        private void FileNameSound_TextChanged(object sender, EventArgs e)
        {
            ChooseOkB.Enabled = true;
        }

        private void ChooseFileB_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogSound.ShowDialog(this) == DialogResult.OK)
            {
                alarm.Filename = FileNameSound.Text = OpenFileDialogSound.FileName;
            }
        }
    }
}
