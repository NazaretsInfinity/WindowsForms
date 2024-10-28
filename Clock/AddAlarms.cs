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

        }

        void initAlarm()
        {
            if (dateTimePickerDate.Enabled)alarm.Date = dateTimePickerDate.Value;
            alarm.Time = dateTimePickerTime.Value;
            alarm.Filename = FileNameSound.Text;
            for (int i = 0; i < checkedListBoxWeek.CheckedIndices.Count; ++i)
            {
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
