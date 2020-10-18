using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private CalculatorUtility _sut;
        [TestInitialize]
        public void SetupTests()
        {
            _sut = new CalculatorUtility();
        }
        [TestMethod]
        public void Should_ReturnArrayWithOneElement()
        {
            int[] intArray = new int[] { 1, 3,-12 };
            var resultArray = _sut.GetNegativeNumbersIfAny(intArray);
            Assert.AreEqual(1, resultArray.Length);
        }
        [TestMethod]
        public void Should_ReturnArrayWithZeroElement()
        {
            int[] intArray = new int[] { 1, 3, 12 };
            var resultArray = _sut.GetNegativeNumbersIfAny(intArray);
            Assert.AreEqual(0, resultArray.Length);
        }

        [TestMethod]
        public void Should_ReturnSumExcludingValuesGreaterThan1000()
        {
            int[] intArray = new int[] { 1, 3, 12, 1001 };
            var result = _sut.SumOfNumbersLessThan1000(intArray);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Should_ReturnSumIncludingValuesLessThanOrEqualTo1000()
        {
            int[] intArray = new int[] { 1, 3, 12, 1000 };
            var result = _sut.SumOfNumbersLessThan1000(intArray);
            Assert.AreEqual(1016, result);
        }

    }
}
