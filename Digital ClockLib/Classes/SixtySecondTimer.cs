using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_ClockLib.Classes
{
    class SixtySecondTimer
    {
        private TimeManager TimeManager { get; set; }

        public SixtySecondTimer() { }
        public void HandleTimeout() { }
        public void SetTimeManager(TimeManager newTimeManager) { TimeManager = newTimeManager; }
        public void Start()
        {
            Timer timer = new Timer(60000);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Start();
        }
    }
}
