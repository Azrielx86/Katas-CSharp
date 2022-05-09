using System.Drawing;
using System;
using System.Numerics;
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
                var test = new Sample_Test_MoveZeroes();
                test.Test();

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
