using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Digital_ClockLib.Classes;

namespace UnitTestProject1
{
    [TestClass]
    public class TimeTest
    {
        public int startHour = 1;
        public int startMin = 30;

        [TestMethod]
        public void CreateTimeTest()
        {
            Time time = new Time(startHour, startMin);
            Assert.AreEqual(startHour, time.GetHour());
            Assert.AreEqual(startMin, time.GetMinute());
        }

        [TestMethod()]
        public void IncrementTimeTest()
        {
            Time time = new Time(startHour, startMin);
            time.IncrementHour();
            time.IncrementMinute();
            Assert.AreEqual(startHour + 1, time.GetHour());
            Assert.AreEqual(startMin + 1, time.GetMinute());
        }

        [TestMethod()]
        public void FiftyNinePlusOneMinutesTest()
        {
            Time time = new Time(startHour, 59);
            time.IncrementMinute();
            Assert.AreEqual(startHour + 1, time.GetHour());
            Assert.AreEqual(0, time.GetMinute());
        }

        [TestMethod()]
        public void TwelveFiftyNineTest()
        {
            Time time = new Time(12, 59);
            time.IncrementMinute();
            Assert.AreEqual(1, time.GetHour());
            Assert.AreEqual(0, time.GetMinute());
        }

    }
}
