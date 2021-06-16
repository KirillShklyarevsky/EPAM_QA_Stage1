using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevelopmentAndBuildTools;
using System;

namespace CharCountTests
{
    [TestClass]
    public class CountOfSymbolsTests
    {
        [TestMethod]
        public void CountOfNonRepeatingSymbolsInEmptyString()
        {
            Assert.AreEqual(0, CountOfSymbolsEntryPoint.MaxCountOfNonRepeatingSymbolsInARow(string.Empty));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullException()
        {
            CountOfSymbolsEntryPoint.MaxCountOfNonRepeatingSymbolsInARow(null);
        }

        [DataTestMethod]
        [DataRow("aBc", 3)]
        [DataRow("aaa", 1)]
        [DataRow("ssssdeefghrr", 5)]
        [DataRow("aba", 3)]
        public void CountOfNonRepeatingSymbolsInCorrectString(string data, int expected)
        {
            Assert.AreEqual(expected, CountOfSymbolsEntryPoint.MaxCountOfNonRepeatingSymbolsInARow(data));
        }
    }
}
