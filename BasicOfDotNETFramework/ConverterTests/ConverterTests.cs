using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOfDotNETFramework;
using System;

namespace ConverterTests
{
    [TestClass]
    public class ConverterTests
    {
        [DataRow(0, 2, "0")]
        [DataRow(222, 2, "11011110")]
        [DataRow(7, 3, "21")]
        [DataRow(7, 8, "7")]
        [DataRow(16, 8, "20")]
        [DataRow(5, 10, "5")]
        [DataRow(20, 16, "14")]
        [DataRow(666, 16, "29A")]
        [DataRow(666, 20, "1D6")]
        [DataRow(20, 20, "10")]
        [TestMethod]
        public void ConvertToNumeralSystem(int number, int systemBase, string expected)
        {
            Assert.AreEqual(expected, ConverterEntryPoint.ConvertToAnotherSystem(number, systemBase));
        }

        [DataRow(5, "5")]
        [DataRow(10, "A")]
        [DataRow(19, "I")]
        [TestMethod()]
        public void IfResidueConvertToStringCorrect(int residue, string expected)
        {
            Assert.AreEqual(ConverterEntryPoint.ConvertResidueToString(residue), expected);
        }

        [TestMethod()]
        public void IfReverseStringIsWorksCorrect()
        {
            string expected = "abcdef";
            string actual = ConverterEntryPoint.ReverseString("fedcba");

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfThrowExceptionThenNumberIsNegative()
        {
            ConverterEntryPoint.ConvertToAnotherSystem(-10, 2);
        }

        [DataRow(21)]
        [DataRow(1)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfThrowExceptionThenSystemBaseIsNotInRange(int systemBase)
        {
            ConverterEntryPoint.ConvertToAnotherSystem(10, systemBase);
        }
    }
}