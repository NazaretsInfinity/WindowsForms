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
           ListBoxAlarms.Items.Add(Properties.Settings.Default.My_alarms[i]);
            
        }

        private void AddB_MouseClick(object sender, MouseEventArgs e)
        {
            AddAlarms addAlarms = new AddAlarms();
            if (addAlarms.ShowDialog() == DialogResult.OK)
            {
                ListBoxAlarms.Items.Add(addAlarms.Alarm);
                Properties.Settings.Default.My_alarms.Add(addAlarms.Alarm.ToString());
            }
               Properties.Settings.Default.Save();
        }

        
        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void ListBoxAlarms_DoubleClick(object sender, EventArgs e)
        {
            if (ListBoxAlarms.SelectedItem != null)
            {
                //AddAlarms Addalarm = new AddAlarms(ListBoxAlarms.SelectedItem.ToString());
                AddAlarms Addalarm = new AddAlarms((sender as ListBox).SelectedItem as Alarm);
                
                if(Addalarm.ShowDialog(this) == DialogResult.OK)
                {
                    ListBoxAlarms.SelectedItem = Addalarm.Alarm;
                    ListBoxAlarms.Items[ListBoxAlarms.SelectedIndex] = ListBoxAlarms.Items[ListBoxAlarms.SelectedIndex];
                }
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            ListBoxAlarms.Items.Remove(ListBoxAlarms.SelectedItem);
           
           Properties.Settings.Default.My_alarms.RemoveAt(ListBoxAlarms.SelectedIndex + 2);
           Properties.Settings.Default.Save();
        }
    }
}
