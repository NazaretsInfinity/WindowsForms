using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    internal class Alarm :IComparable

    {
         public int CompareTo(object other)
         {
           return this.Time.CompareTo((other as Alarm).Time);
         }

        public static readonly string[] WeekDayNames = new string[7]{"Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday", "Sunday"};
        public DateTime Date { get; set; } 
        public DateTime Time { get; set; }

        public bool[] Weekdays { get; private set; } 
        public string Filename { get; set; } = " ";

       
        public Alarm()
        {
            Weekdays = new bool[7];
        }

        string WeekDaysToString()
        {
            string days = ""; 
           
            for(int i = 0; i <WeekDayNames.Length; ++i)
            {
                if (Weekdays[i])
                days += WeekDayNames[i] + ", ";
            }
            return days;
        }

        public Alarm(Alarm other) : this()
        {
            this.Date = other.Date;
            this.Time = other.Time; 
            this.Filename = other.Filename;
            for(int i = 0;i < Weekdays.Length; ++i)this.Weekdays[i] = other.Weekdays[i];

        }

        public override string ToString()
        {
            string result = " ";
            if (Date != DateTime.MinValue) result += $"{Date.ToShortDateString()}, ";
            result += $"{Time.ToString("hh:mm:ss")}, {WeekDaysToString()}{Filename.Split('\\').Last()}";            
            return result;
            //ToLongTimeString()
        }
    }
}
