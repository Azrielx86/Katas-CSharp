using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class MxnWave
    {
        public List<string> wave(string str)
        {
            var list = new List<string>();
            str = str.ToLower();

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') continue;
                var charlist = str.ToCharArray();
                charlist[i] = Char.ToUpper(charlist[i]);
                list.Add(new String(charlist));
            }

            return list;
        }
    }

    [TestFixture]
    class MxnWaveTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            MxnWave kata = new MxnWave();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, kata.wave("hello"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            MxnWave kata = new MxnWave();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, kata.wave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            MxnWave kata = new MxnWave();
            List<string> result = new List<string> { };
            Assert.AreEqual(result, kata.wave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            MxnWave kata = new MxnWave();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, kata.wave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            MxnWave kata = new MxnWave();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, kata.wave(" gap "), "it should return '" + result + "'");
        }

    }
}