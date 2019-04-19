using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_ClockLib.Classes
{
    public class Display
    {
        public Display() { }

        public void ShowHour(int newHour)
        {
            if (newHour > 9)
            {
                //show tens place
            }
            else
            {
                //disable tens place
            }
        }
        public void ShowMinute(int newMinute)
        {
            if (newMinute > 9)
            {
                //display 0 in tens place
            }
            else
            {
                //show normal
            }
        }

    }
}
