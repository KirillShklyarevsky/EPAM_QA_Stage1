using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevelopmentAndBuildTools;
using System;

namespace CharCountTests
{
    [TestClass]
    public class CountOfNonRepeatingSymbolsTests
    {
        [TestMethod]
        public void CountOfNonRepeatingSymbolsInEmptyString()
        {
            Assert.AreEqual(0, SymbolsCounter.GetMaxCountOfNonRepeatingSymbolsInARow(string.Empty));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullException()
        {
            SymbolsCounter.GetMaxCountOfNonRepeatingSymbolsInARow(null);
        }

        [DataTestMethod]
        [DataRow("aBc", 3)]
        [DataRow("aaa", 1)]
        [DataRow("ssssdeefghrr", 5)]
        [DataRow("aba", 3)]
        public void CountOfNonRepeatingSymbolsInCorrectString(string data, int expected)
        {
            Assert.AreEqual(expected, SymbolsCounter.GetMaxCountOfNonRepeatingSymbolsInARow(data));
        }
    }
}