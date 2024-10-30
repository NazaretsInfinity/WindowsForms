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
        internal Alarm Alarm { get; set; }
        
        public AddAlarms()
        {
            InitializeComponent();
            Alarm = new Alarm();
            FileNameSound.MaximumSize = new Size(this.Width - 25, 30);
            OpenFileDialogSound.Filter = "MP-3 (*.mp3)|*.mp3|Flac (*.flac)|*.flac|All Audio|*.mp3;*flac";
        }

        internal AddAlarms(Alarm alarm) : this()
        {
            this.Alarm = alarm;
            InitWindowFromAlarm();
        }

        void InitWindowFromAlarm()
        {
            if(Alarm.Date!= DateTime.MinValue)this.dateTimePickerDate.Text = Alarm.Date.ToShortDateString();
            if (Alarm.Time != DateTime.MinValue)this.dateTimePickerTime.Text = Alarm.Time.ToString("hh:mm:ss");
            this.FileNameSound.Text = Alarm.Filename;


            for (int i = 0; i < Alarm.Weekdays.Length; i++) Alarm.Weekdays[i] = false;
            for(int i = 0; i< Alarm.WeekDayNames.Length; i++)
            {
               // alarm.Weekdays[i] = checkedListBoxWeek.GetItemChecked(i);
                checkedListBoxWeek.SetItemChecked(i, Alarm.Weekdays[i]);
            }

           
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
                    if (Alarm.WeekDayNames.Contains(comps[i].Remove(0, 1)))
                        checkedListBoxWeek.SetItemChecked(Array.IndexOf(Alarm.WeekDayNames, comps[i].Remove(0, 1)), true);
            }
            FileNameSound.Text = comps.Last();
            
        }


        void initAlarm()
        {
            if (dateTimePickerDate.Enabled)Alarm.Date = dateTimePickerDate.Value;
            Alarm.Time = dateTimePickerTime.Value;
            Alarm.Filename = FileNameSound.Text;
            for (int i = 0; i < checkedListBoxWeek.CheckedIndices.Count; ++i)
            {
                Alarm.Weekdays[checkedListBoxWeek.CheckedIndices[i]] = true;
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
                Alarm.Filename = FileNameSound.Text = OpenFileDialogSound.FileName;
            }
        }
    }
}
