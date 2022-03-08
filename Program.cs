using System.Drawing;
using System;
using NUnit.Framework;
using KatasCS.Katas;

namespace KatasCS
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                // *Sitio para colocar los tests
                HumanReadableTimeTest.HumanReadableTest();
            } catch (NUnit.Framework.AssertionException ae){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ae);
                Console.WriteLine("Tests no completados.");
                Environment.Exit(1);
            } finally {
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tests completados!");
            Console.ResetColor();
        }
    }
}
