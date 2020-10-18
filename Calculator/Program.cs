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
            //string inputString = "1\n2,3";
            // string inputString = "1\n2,3,\n-89";
            //string inputString = "//;\n1;2";
            //string inputString = "//*%\n";            
            string inputString ="//*%\n1*2%3";
            int result = 0;
            var strategy = new CalculatorStrategy();

            result = strategy.GetCalculator(inputString).Add(inputString);

            Console.WriteLine("Result is : " + result);
            Console.ReadLine();
        }
    }
}
