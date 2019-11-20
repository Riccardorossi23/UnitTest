using CaleLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calclibrary_tests
{
    [TestClass]
    public class Calc_Test
    {
        [TestMethod]
        public void PositiveSum()
        {
            int num1 = 3;
            int num2 = 4;
            int somma_aspettata = 7;
            int somma = Calcolatrice2.Somma(num1, num2);
            Assert.AreEqual(somma_aspettata, somma);
        }
        [TestMethod]
        public void NegativeSum()
        {
            int num1 = -3;
            int num2 = -5;
            int somma_aspettata = -8;
            int somma = Calcolatrice2.SommaNegative(num1, num2);
            Assert.AreEqual(somma_aspettata, somma);
        }
    }
}
