using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace KatasCS.Katas
{
    public class SqInRect
    {
        public static List<int>? sqInRect(int lng, int wdth)
        {
            if (lng == wdth) return null;

            List<int> sides = new List<int>();

            while (true)
            {
                if (lng < wdth)
                {
                    sides.Add(lng);
                    wdth -= lng;
                } 
                else if (lng > wdth)
                {
                    sides.Add(wdth);
                    lng -= wdth;
                }
                else if (lng == wdth)
                {
                    sides.Add(lng);
                    break;
                }
            }

            return sides;
        }
    }

    [TestFixture]
    public class SqInRectTests
    {
        [Test]
        public static void Test1()
        {
            List<int> r = new List<int> { 3, 2, 1, 1 };
            Assert.AreEqual(r, SqInRect.sqInRect(5, 3));
        }

        [Test]
        public static void Test2()
        {
            List<int> r = new List<int> { 4, 4, 4 };
            Assert.AreEqual(r, SqInRect.sqInRect(12, 4));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(null, SqInRect.sqInRect(5, 5));
        }
    }
}
