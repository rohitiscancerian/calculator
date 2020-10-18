using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Interface;
using Utility;
using Validation;

namespace Calculator.Implementation
{
    public class CalculatorWithMutipleDelimiters : ICalculator
    {
        private Helper _helper;
        private Validator _validator;
        private Calculator _calculator;
        public CalculatorWithMutipleDelimiters()
        {
            _helper = new Helper();
            _validator = new Validator();
            _calculator = new Calculator();
        }
        public int Add(string input)
        {
            var arrayOfDelimiters = _helper.GetArrayOfDelimiters(input);
            var arrayOfNumbers = _helper.GetArrayOfNumbersAfterFirstNewline(input, arrayOfDelimiters);
            _validator.ThrowExceptionIfNegativeNumber(arrayOfNumbers);

            var result = _calculator.SumOfNumbersLessThan1000(arrayOfNumbers);
            return result;
        }
    }
}
