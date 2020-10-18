using Calculator.Interface;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Validation;
using Calculator.Implementation;
namespace Calculator
{
    /// <summary>
    /// Responsible to validate the input and determine what type of 
    /// Calculator object to create e.g. CalculatorWithMultipleDelimiter
    /// </summary>
    public class CalculatorStrategy
    {
        private Validator _validator ;
        public CalculatorStrategy()
        {
            _validator = new Validator();
        }
        public ICalculator GetCalculator(string input)
        {
            ICalculator calculator = null;
            if (_validator.IsInputWithMultipleDelimter(input) && !_validator.IsEndsWithNewLine(input))
            {
                calculator = new CalculatorWithMutipleDelimiters();
            }
            else if (!_validator.IsEndsWithNewLine(input))
            {
                calculator = new CalculatorWithSingleDelimiter();
            }
            else
            {
                Console.WriteLine("Input not OK");
                Console.ReadLine();
            }
            return calculator;
        }
    }
}
