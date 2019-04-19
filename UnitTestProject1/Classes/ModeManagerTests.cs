using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ModeManagerTests
    {
        ModeManager modeManager = new ModeManager();

        [TestMethod()]
        public void TimeSetTest()
        {
            modeManager.SetMode(Mode.SET_TIME);
            Assert.AreEqual(Mode.SET_TIME, modeManager.GetMode());
        }

        [TestMethod()]
        public void AlarmSetTest()
        {
            modeManager.SetMode(Mode.SET_ALARM);
            Assert.AreEqual(Mode.SET_ALARM, modeManager.GetMode());
        }

        [TestMethod()]
        public void AlarmOnTest()
        {
            modeManager.SetMode(Mode.ALARM_ON);
            Assert.AreEqual(Mode.ALARM_ON, modeManager.GetMode());
        }

        [TestMethod()]
        public void AlarmOffTest()
        {
            modeManager.SetMode(Mode.ALARM_OFF);
            Assert.AreEqual(Mode.ALARM_OFF, modeManager.GetMode());
        }
    }
}