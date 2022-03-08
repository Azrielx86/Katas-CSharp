using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class SplitStringClass
    {
        public static string[] SplitString(string str)
        {
            List<string> list = new List<string>();
            char[] strChars = str.ToCharArray();

            for (var i = 1; i <= strChars.Count(); i+=2)
            {
                list.Add(strChars.Length > i? string.Concat(strChars[i-1], strChars[i]) : string.Concat(strChars[i-1], '_'));
            }

            return list.ToArray();
        }
    }

    [TestFixture]
    public class SplitStringTests
    {
        [Test]
        public static void Test()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitStringClass.SplitString("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitStringClass.SplitString("abcdef"));
        }
    }
}
