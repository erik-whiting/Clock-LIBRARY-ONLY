using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_ClockLib.Classes
{
    public class Time
    {
        private int hour { get; set; }
        private int minute { get; set; }

        public Time(int intHour, int intMinute)
        {
            hour = intHour;
            minute = intMinute;
        }
        public void AddOneMinute()
        {
            IncrementMinute();
        }
        public bool Equate(Time aTime) { return ((aTime.hour == GetHour()) & (aTime.minute == GetMinute())); }
        public int GetHour() { return hour; }
        public int GetMinute() { return minute; }
        public void IncrementHour() { hour = hour == 12 ? 1 : hour + 1; }
        public void IncrementMinute()
        {
            if (minute == 59)
            {
                minute = 0;
                IncrementHour();
            }
            else
            {
                minute += 1;
            }
            
        }
        
    }
}
