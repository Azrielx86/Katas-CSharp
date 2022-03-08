using NUnit.Framework;

namespace KatasCS.Katas
{
    public class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string? numbersStr = string.Join(null, numbers);
            return string.Format("({0}) {1}-{2}", numbersStr.Substring(0, 3), numbersStr.Substring(3, 3), numbersStr.Substring(6, numbers.Length - 6));
        }

        public static string CreatePhoneNumberOtherSol(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }

    [TestFixture]
    public static class PhoneNumberTests
    {
        [Test]
        // [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        // [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static void FixedTest()
        {
            Assert.AreEqual("(123) 456-7890", PhoneNumber.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Assert.AreEqual("(111) 111-1111", PhoneNumber.CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}
