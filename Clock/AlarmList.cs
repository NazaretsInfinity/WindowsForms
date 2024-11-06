using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AlarmList : Form 
    {      
        public ListBox ListBoxAlarms
        { get => listBoxAlarms;
          private set=> listBoxAlarms = value;
        }
        public AlarmList()
        {
            InitializeComponent();
            // Properties.Settings.Default.My_alarms.Add(addAlarms.Alarm.ToString());
            // for (int i = 0; i < Properties.Settings.Default.My_alarms.Count; i++)
            // {
            //     ListBoxAlarms.Items.Add(new Alarm(Properties.Settings.Default.My_alarms[i]));
            // }

            StreamReader sr = new StreamReader("AlarmList.txt");
            while (!sr.EndOfStream)
            {
               ListBoxAlarms.Items.Add(new Alarm(sr.ReadLine()));
            }
            sr.Close();


        }

        private void AddB_MouseClick(object sender, MouseEventArgs e)
        {
            AddAlarms addAlarms = new AddAlarms();
            if (addAlarms.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter("AlarmList.txt",true);
               
                listBoxAlarms.Items.Add(addAlarms.Alarm);
                sw.WriteLine(addAlarms.Alarm);
                sw.Close();
            }
              
        }

        
        private void CancelB_Click(object sender, EventArgs e)
        {

            this.Close(); 
        }


        private void ListBoxAlarms_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem != null)
            {
                AddAlarms Addalarm = new AddAlarms((sender as ListBox).SelectedItem as Alarm);
                
                if(Addalarm.ShowDialog(this) == DialogResult.OK)
                {
                    listBoxAlarms.SelectedItem = Addalarm.Alarm;
                    listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = listBoxAlarms.Items[listBoxAlarms.SelectedIndex];
                }
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
           listBoxAlarms.Items.Remove(listBoxAlarms.SelectedItem);
            StreamWriter sw = new StreamWriter("AlarmList.txt");
            for (int i = 0; i < listBoxAlarms.Items.Count; ++i)
            {
                sw.WriteLine(listBoxAlarms.Items[i]);
            }
            sw.Close();
            // Properties.Settings.Default.My_alarms.RemoveAt(listBoxAlarms.SelectedIndex + 2);
            // Properties.Settings.Default.Save();
        }
    }
}
