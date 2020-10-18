using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Interface;
using Utility;
using Validation;

namespace Calculator.Implementation
{
    public class CalculatorWithSingleDelimiter : ICalculator
    {
        private Helper _helper;
        private Validator _validator;
        private CalculatorUtility _calculator;
        public CalculatorWithSingleDelimiter()
        {
            _helper = new Helper();
            _validator = new Validator();
            _calculator = new CalculatorUtility();
        }
        public int Add(string input)
        {
            // to support first 2 use cases
            var arrayOfNumbers = _helper.GetArrayOfNumbers(input, new char[] { ',','\n' });
            _validator.ThrowExceptionIfNegativeNumber(arrayOfNumbers);

            var result = _calculator.SumOfNumbersLessThan1000(arrayOfNumbers);
            return result;
        }
    }
}
