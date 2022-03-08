using System;
using System.Collections;
using System.Linq;

namespace KatasCS.Katas
{
    public class DisemvowelClass
    {
        private static string[] vowels = { "a", "e", "i", "o", "u" };

        public static string Disemvowel(string str)
        {
            return string.Join(null , (str.Where(ch => !vowels.Contains(ch.ToString().ToLower()))));
        }
    }
}

// Tests
            // string str = DisemvowelClass.Disemvowel("This website is for losers LOL!");
            // Console.WriteLine(str);