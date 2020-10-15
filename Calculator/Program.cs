using System;
using System.Linq;
using System.Text.RegularExpressions;
using Validation;
using Utility;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputString = "//*%\n1*2\n%3*-1001*%4";
            // string inputString = "1\n2,3,\n-89";
            //string inputString = "//;\n1;2";
            string inputString = "//*%\n";
            Calculator calc = new Calculator();
            Validator validator = new Validator();
            Helper helper = new Helper();
            int result = 0;
            if(validator.IsInputWithMultipleDelimter(inputString) && !validator.IsEndsWithNewLine(inputString))
            {
               
                var arrayOfDelimiters = helper.GetArrayOfDelimiters(inputString);
                var arrayOfNumbers = helper.GetArrayOfNumbers(inputString,arrayOfDelimiters);
                validator.ThrowExceptionIfNegativeNumber(arrayOfNumbers);                

                result = calc.SumOfNumbersLessThan1000(arrayOfNumbers);                
            }
            else if(!validator.IsEndsWithNewLine(inputString))
            {
                // to support first 2 use cases
                var arrayOfNumbers = helper.GetArrayOfNumbers(inputString,new char[] { ',' });
                validator.ThrowExceptionIfNegativeNumber(arrayOfNumbers);
                result = calc.SumOfNumbersLessThan1000(arrayOfNumbers);
            }
            else
            {
                Console.WriteLine("Input not OK");
                Console.ReadLine();
            }

            Console.WriteLine("Result is : " + result);
            Console.ReadLine();
        }
    }
}
