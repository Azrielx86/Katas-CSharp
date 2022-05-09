using System;
using NUnit.Framework;

namespace KatasCS.Katas
{
    public class MoveZeroesClass
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var list = new List<int>(arr);
            int removed = list.RemoveAll(x => x == 0);
            for (var i = 0; i < removed; i++) list.Add(0);

            return list.ToArray();
        }
    }

    [TestFixture]
    public class Sample_Test_MoveZeroes
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MoveZeroesClass.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            Assert.AreEqual(new int[] { 1, 4, 3, 1, 1, 1, 5, 5, 1, 5, 5, 4, 2, 1, 1, 4, 4, 5, 2, 4, 5, 2, 4, 1, 4, 1, 3, 0, 0, 0, 0, 0, 0, 0, 0 }, MoveZeroesClass.MoveZeroes(new int[] { 1, 4, 3, 1, 1, 1, 0, 5, 5, 1, 5, 5, 4, 0, 2, 1, 1, 4, 0, 4, 5, 0, 2, 0, 4, 5, 2, 4, 1, 0, 4, 1, 0, 0, 3 }));
        }
    }
}
