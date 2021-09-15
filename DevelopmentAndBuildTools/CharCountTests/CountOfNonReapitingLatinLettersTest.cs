using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevelopmentAndBuildTools;
using System;

namespace CharCountTests
{
    [TestClass]
    public class CountOfNonReapitingLatinLettersTest
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
        [DataRow("a", 1)]
        [DataRow("abc", 3)]
        [DataRow("abc1", 3)]
        [DataRow("abc1abcd", 4)]
        public void CountOfNonRepeatingLatinLettersInCorrectString(string data, int expected)
        {
            Assert.AreEqual(expected, SymbolsCounter.GetMaxCountOfNonRepeatingLatinLettersInARow(data));
        }
    }
}
