using System;
using System.Linq;

namespace Validation
{
    public class Validator
    {
        /// <summary>
        /// This method checks if the input string is new version starting 
        /// with double forward slash (//) with multiple delimiters and not ending with \n
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsInputWithMultipleDelimter(string input)
        {
            if (input.Length <= 4) { return false; }

            var first2Chars = input.Substring(0, 2);
            if (first2Chars != "//") 
            {               
                return false;
            }           
            var delimitersString = input.Substring(2, input.IndexOf('\n') - 2);
            if(!(delimitersString.Length>0))
            {
                return false;
            }
            return true;
        }

        public bool IsEndsWithNewLine(string input)
        {
            if (input.EndsWith('\n'))
            {
                return true;
            }
            return false;
        }
        public void ThrowExceptionIfNegativeNumber(int[] arrayIntegers)
        {
            var arrayOfNegatives = arrayIntegers.Where(x => x < 0).ToArray();
            if (arrayOfNegatives.Length > 0)
            {
                throw new Exception("Negatives not allowed : " + string.Join(",", arrayOfNegatives));
            }
        }
    }
}
