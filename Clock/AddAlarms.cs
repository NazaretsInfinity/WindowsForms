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
        internal Alarm alarm;
        public string alarmname;
        public AddAlarms()
        {
            InitializeComponent();
            alarm = new Alarm();    
        }

       

        private void checkBoxExactDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
            checkedListBoxWeek.Enabled = !((CheckBox)sender).Checked;
        }

        private void ChooseOkB_Click(object sender, EventArgs e)
        {
           if (dateTimePickerDate.Enabled) alarm.Date = dateTimePickerDate.Value;
           alarm.Time = dateTimePickerTime.Value;
           for(int i = 0; i < 7;++i)
            {
                alarm.Weekdays[i] = checkedListBoxWeek.GetItemChecked(i);   
            }
           this.Close();        
        }
    }
}
