using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace KatasCS.Katas
{
    public class StringToCamel
    {
        public static string ToCamelCase(string str)
        {
            // Regex.Matches(str, "\b\W+");
            return str;
        }
    }

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", StringToCamel.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", StringToCamel.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}