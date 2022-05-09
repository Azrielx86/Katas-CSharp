using System;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class EqualSides
    {
        public static int FindEvenIndex(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int left = 0, right = 0;

                for (var j = 0; j < i; j++)
                    left += arr[j];

                for (var k = i + 1; k < arr.Length; k++)
                    right += arr[k];

                if (left == right) return i;
            }

            return -1;
        }
    }

    [TestFixture]
    public class ValidateWordTest
    {
        [Test]
        public static void GenericTests()
        {
            Assert.AreEqual(3, EqualSides.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, EqualSides.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, EqualSides.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, EqualSides.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}