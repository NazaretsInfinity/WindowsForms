using AxWMPLib;
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
           
                LoadAlarmsFromFile("AlarmsList.txt");
           
        }

        private void AddB_MouseClick(object sender, MouseEventArgs e)
        {
            AddAlarms addAlarms = new AddAlarms();
            if (addAlarms.ShowDialog() == DialogResult.OK)
            {          
                listBoxAlarms.Items.Add(addAlarms.Alarm);              
            }
              
        }

        
        private void CancelB_Click(object sender, EventArgs e)
        {
            SaveAlarmsToFile("AlarmsList.csv");
            SaveAlarmsToFile("AlarmsList.txt");
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
            StreamWriter sw = new StreamWriter("AlarmsList.txt");
            for (int i = 0; i < listBoxAlarms.Items.Count; ++i)
            {
                sw.WriteLine(listBoxAlarms.Items[i]);
            }
            sw.Close();

        }
        public void SaveAlarmsToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach( Alarm alarm in listBoxAlarms.Items)
                sw.WriteLine(alarm.ToFilestring());
            sw.Close();
        }

        public void LoadAlarmsFromFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (sr.EndOfStream)
                {
                    string alarm = sr.ReadLine();
                    ListBoxAlarms.Items.Add(new Alarm(sr.ReadLine()));
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nope", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
