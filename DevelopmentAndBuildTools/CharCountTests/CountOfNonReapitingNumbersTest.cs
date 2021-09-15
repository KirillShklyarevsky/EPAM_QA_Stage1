using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevelopmentAndBuildTools;
using System;

namespace CharCountTests
{
    [TestClass]
    public class CountOfNonReapitingNumbersTest
    {
        [TestMethod]
        public void CountOfNonRepeatingSymbolsInEmptyString()
        {
            Assert.AreEqual(0, SymbolsCounter.GetMaxCountOfNonRepeatingNumbersInARow(string.Empty));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullException()
        {
            SymbolsCounter.GetMaxCountOfNonRepeatingNumbersInARow(null);
        }

        [DataTestMethod]
        [DataRow("A", 0)]
        [DataRow("1111", 1)]
        [DataRow("11A11", 1)]
        [DataRow("12A", 2)]
        [DataRow("123", 3)]
        [DataRow("1233", 3)]
        public void CountOfNonRepeatingNumbersInCorrectString(string data, int expected)
        {
            Assert.AreEqual(expected, SymbolsCounter.GetMaxCountOfNonRepeatingNumbersInARow(data));
        }
    }
}

