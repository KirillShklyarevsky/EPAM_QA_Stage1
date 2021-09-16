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
            // arrange
            int expected = 0;

            // act
            int actual = SymbolsCounter.GetMaxCountOfNonRepeatingNumbersInARow(string.Empty);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullException()
        {
            // act
            SymbolsCounter.GetMaxCountOfNonRepeatingNumbersInARow(null);
        }

        [DataTestMethod]
        [DataRow("a", 1)]
        [DataRow("1", 0)]
        [DataRow("abc", 3)]
        [DataRow("abc1", 3)]
        [DataRow("abc1abcd", 4)]
        public void CountOfNonRepeatingLatinLettersInCorrectString(string data, int expected)
        {
            // act
            int actual = SymbolsCounter.GetMaxCountOfNonRepeatingLatinLettersInARow(data);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}