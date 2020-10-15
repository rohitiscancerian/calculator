using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;

namespace Calculator.Tests
{
    [TestClass]
    public class HelperTests
    {
        private Helper _sut;
        [TestInitialize]
        public void SetupTests()
        {
            _sut = new Helper();
        }

        [TestMethod]
        public void Should_ReturnEmptyArrayOfDelimitersInTheString()
        {
            string input = "//\n";            
            var delimiters = _sut.GetArrayOfDelimiters(input);
            Assert.AreEqual(0, delimiters.Length);
        }
        [TestMethod]
        public void Should_Return1ItemInArrayOfDelimitersInTheString()
        {
            string input = "//*\n";            
            var delimiters = _sut.GetArrayOfDelimiters(input);
            Assert.AreEqual(1, delimiters.Length);
        }
        [TestMethod]
        public void Should_Return2ItemsInArrayOfDelimitersInTheString()
        {
            string input = "//*%\n";            
            var delimiters = _sut.GetArrayOfDelimiters(input);
            Assert.AreEqual(2, delimiters.Length);
        }

        [TestMethod]
        public void Should_ReturnBlankStringAsSubstringAfterNewLine()
        {
            string input = "//*%\n";            
            var substringAfterNewline = _sut.GetSubstringAfterFirstNewLine(input);
            Assert.AreEqual(string.Empty, substringAfterNewline);
        }
        [TestMethod]
        public void Should_ReturnStringWithLength1AsSubstringAfterNewLine()
        {
            string input = "//*%\n1";            
            var substringAfterNewline = _sut.GetSubstringAfterFirstNewLine(input);
            Assert.AreEqual(1, substringAfterNewline.Length);
        }
        [TestMethod]
        public void Should_ReturnStringWithLength3AsSubstringAfterNewLine()
        {
            string input = "//*%\n1\n*";            
            var substringAfterNewline = _sut.GetSubstringAfterFirstNewLine(input);
            Assert.AreEqual(3, substringAfterNewline.Length);
        }

        [TestMethod]
        public void Should_ReturnArrayOfNumbersWith1Item()
        {
            string input = "1*";
            char[] delimiters = new char[] { '*','%' };            
            var arrayNumbers = _sut.GetArrayOfNumbers(input,delimiters);
            Assert.AreEqual(1, arrayNumbers.Length);
        }

        [TestMethod]
        public void Should_ReturnArrayOfNumbersWith2Items()
        {
            string input = "1*2";
            char[] delimiters = new char[] { '*', '%' };            
            var arrayNumbers = _sut.GetArrayOfNumbers(input, delimiters);
            Assert.AreEqual(2, arrayNumbers.Length);
        }

    }
}
