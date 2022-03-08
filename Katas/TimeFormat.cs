using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            double hrs = seconds / 3600.0;
            double min = (hrs - (int) hrs) * 60;
            double sec = (min - (int) min) * 60;
            return $"{Math.Floor(hrs), 00:00}:{Math.Floor(min), 00:00}:{sec, 00:00}";

            // * Mejor Manera: 
            // return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }

    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public static void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
            Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
            Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
            Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
        }
    }
}