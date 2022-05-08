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
            Console.WriteLine(new BigInteger(25826) * 4);


            try {
                // *Sitio para colocar los tests
                SumFctTests.Test1();
                SumFctTests.Test2();
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
