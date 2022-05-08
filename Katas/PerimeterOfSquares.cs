using System;
using System.Numerics;
using System.Collections.Generic;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class SumFct
    {
        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger perimeters = new BigInteger();
            List<BigInteger> fibonacci = new List<BigInteger>() { 0, 1 };
            
            for (var i = 2; i <= n + 2; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                perimeters += fibonacci[i - 1];
            }

            return BigInteger.Multiply(perimeters, new BigInteger(4));
        }

        public static int Fibonacci(int n)
        {
            if (n.Equals(0) || n.Equals(1)) return 1;
            else return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }
    }

    [TestFixture]
    public class SumFctTests
    {

        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new BigInteger(80), SumFct.perimeter(new BigInteger(5)));
        }
        [Test]
        public static void Test2()
        {
            Assert.AreEqual(new BigInteger(216), SumFct.perimeter(new BigInteger(7)));
        }
    }
}