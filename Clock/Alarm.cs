using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    internal class Alarm
    {

        public DateTime Date { get; set; } 
        public DateTime Time { get; set; }

        public bool[] Weekdays { get; private set; } = new bool[7];
        public string Filename { get; set; }

       

        public override string ToString()
        {
            string result = " ";
            if (Date != DateTime.MinValue) result += $"{Date.ToShortDateString()}, ";
            //else result += $"{Weekdays}, ";
            result += $"{Time.ToShortTimeString()}, {Filename}";            
            return result; 

        }
    }
}
