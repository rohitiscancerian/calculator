using System.Linq;

namespace Utility
{
    public class Helper
    {   
        public char[] GetArrayOfDelimiters(string input)
        {
            var delimitersString = input.Substring(2, input.IndexOf('\n') - 2);
            return delimitersString.ToCharArray();
        }

        public string GetSubstringAfterFirstNewLine(string input)
        {
            var indexOfFirstNewLine = input.IndexOf('\n');
            var indexNextToNewLine = ++indexOfFirstNewLine;
            var numbersString = input.Substring(indexNextToNewLine, input.Length - indexNextToNewLine);
            return numbersString;
        }

        public int[] GetArrayOfNumbers(string input, char[] delimiters)
        {
            var numbersString = GetSubstringAfterFirstNewLine(input);
            var arrNumbers = numbersString.Split(delimiters);
            int i = 0;
            var a = (from s in arrNumbers where int.TryParse(s, out i) select i).ToArray();
            return a;
        }
    }
}
