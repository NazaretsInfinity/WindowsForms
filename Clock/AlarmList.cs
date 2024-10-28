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
        }

        private void AddB_MouseClick(object sender, MouseEventArgs e)
        {
            AddAlarms addAlarms = new AddAlarms();
            addAlarms.ShowDialog();

            if(addAlarms.ShowDialog() == DialogResult.OK )
            {
               AlarmsList.Items.Add(addAlarms.alarm.ToString());
               AlarmsList.Items.Clear();
            }
        }
    }
}
