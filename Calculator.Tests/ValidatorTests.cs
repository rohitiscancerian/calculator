using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Validation;

namespace Calculator.Tests
{
    [TestClass]
    public class ValidatorTests
    {
        private Validator _sut;
        [TestInitialize]
        public void SetupTests()
        {
            _sut = new Validator();
        }

        [TestMethod]
        public void Should_ReturnFalseIfStringNotStartWithDoubleForwardSlash()
        {
            string input = "\n";
            var valid = _sut.IsInputWithMultipleDelimter(input);
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void Should_ReturnTrueIfStringStartsWithDoubleForwardSlash()
        {
            string input = "//*\n1";
            var valid = _sut.IsInputWithMultipleDelimter(input);
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void Should_ReturnFalseIfStringDoesNotEndWithNewLine()
        {
            string input = "//*%\n1";
            var result = _sut.IsEndsWithNewLine(input);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Should_ReturnTrueIfStringEndsWithNewLine()
        {
            string input = "//*%\n";
            var result = _sut.IsEndsWithNewLine(input);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Should_ReturnFalseIfNoDelimiters()
        {
            string input = "//\n1";
            var valid = _sut.IsInputWithMultipleDelimter(input);
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void Should_ReturnTrueIfDelimiters()
        {
            string input = "//*%\n1*2";
            var valid = _sut.IsInputWithMultipleDelimter(input);
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Negatives not allowed : -12")]
        public void Should_ThrowExceptionIfNegativeNumbersInArray()
        {
            int[] intArray = new int[] { 1, 3, -12 };
            _sut.ThrowExceptionIfNegativeNumber(intArray);            
        }
    }
}
