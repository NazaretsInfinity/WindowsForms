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
    public partial class AlarmList : Form
    {
        public AlarmList()
        {
            InitializeComponent();
           for (int i = 0; i < Properties.Settings.Default.My_alarms.Count; i++)
           AlarmsList.Items.Add(Properties.Settings.Default.My_alarms[i]);
            
        }

        private void AddB_MouseClick(object sender, MouseEventArgs e)
        {
            AddAlarms addAlarms = new AddAlarms();
 

            if(addAlarms.ShowDialog() == DialogResult.OK )
            {
                string newal = addAlarms.alarm.ToString();
                for(int i = 0;i <7;i++)
                {

                }
               //AlarmsList.Items.Add(addAlarms.alarm.ToString());
               //Properties.Settings.Default.My_alarms.Add(addAlarms.alarm.ToString());
               Properties.Settings.Default.Save();
            }

        }
        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close(); 
          // Properties.Settings.Default.My_alarms.Clear();
          // AlarmsList.Items.Clear();                
           Properties.Settings.Default.Save();
        }
    }
}
