using System;
using System.Collections.Generic;

namespace KatasCS.Katas
{
    public class NarcissisticNumber
    {
        public static bool Narcissistic(int value)
        {
            int newValue = value;
            List<int> numbers = new List<int>();
            while (newValue > 0)
            {
                numbers.Add(newValue % 10);
                newValue /= 10;
            }

            numbers.ForEach(delegate (int number)
            {
                newValue += (int)Math.Pow((double)number, (double)numbers.Count);
            });

            return (value == newValue);
        }
        public static bool NarcissisticOtherVersion(int value)
        {
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }
    }
}

// Tests
// Console.WriteLine(NarcissisticNumber.Narcissistic(153));
// Console.WriteLine(NarcissisticNumber.Narcissistic(1652));