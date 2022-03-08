using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class CategorizeMembers
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> members = new List<string>();

            foreach (int[] item in data)
            {
                if (item[0] >= 55 && item[1] > 7)
                    members.Add("Senior");
                else
                    members.Add("Open");
            }
            return members;
        }
        public static IEnumerable<string> OpenOrSeniorBetterOp(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
    }

    [TestFixture]
    public class KataOpenOrSeniorTests
    {
        [Test]
        public static void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }
    }
}