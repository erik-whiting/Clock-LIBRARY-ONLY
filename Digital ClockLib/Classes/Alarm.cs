using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_ClockLib.Classes
{
    public class Alarm
    {
        public Alarm() { }
        public void On()
        {
            ModeManager modeMgr = new ModeManager();
            modeMgr.SetMode(Mode.ALARM_ON);
        }
        public void Off()
        {
            ModeManager modeMgr = new ModeManager();
            modeMgr.SetMode(Mode.ALARM_OFF);
        }
    }
}
