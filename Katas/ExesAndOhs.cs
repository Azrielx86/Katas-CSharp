using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KatasCS.Katas
{
    /// <summary>Class <c>ExesAndOhs</c></summary>
    public class ExesAndOhs
    {
        /// <summary>Comprueba si se tiene el mismo número de 'x' y 'o'.</summary>
        /// <returns>true si existen 'x' y 'o' en la misma cantidad</returns>
        public static bool XO(string input)
        {
            // return (input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o =='o') || (!input.Contains('x') && !input.Contains('o')));
            return input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o');
        }
    }

    [TestFixture]
    public class ExesAndOhsTests
    {
        [Test]
        public static void ExampleTests()
        {
            Assert.AreEqual(true, ExesAndOhs.XO("xo"));
            Assert.AreEqual(true, ExesAndOhs.XO("xxOo"));
            Assert.AreEqual(false, ExesAndOhs.XO("xxxm"));
            Assert.AreEqual(false, ExesAndOhs.XO("Oo"));
            Assert.AreEqual(false, ExesAndOhs.XO("ooom"));
        }
    }

}
