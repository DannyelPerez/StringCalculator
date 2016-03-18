using System.Collections.Generic;
using StringCalculator.Logic.Extensions;

namespace StringCalculator.Logic
{
    public class Parser : IParser
    {

        public int[] Parse(string numbers)
        {
            var delimeters = new List<char>() {',', '\n'};

            if(numbers.IsNullOrEmpty())
                return new int[0];

            numbers = ProcessCustomDelimiter(numbers, delimeters);

            var nums = numbers.Split(delimeters.ToArray());
            return nums.ToIntArray();
        }

        private string ProcessCustomDelimiter(string numbers, List<char> delimeters)
        {
            if (numbers.StartsWith("//"))
            {
                var prefix = numbers.Substring(0, 4);
                numbers = numbers.Substring(4, numbers.Length - 4);
                delimeters.Add(prefix[2]);
            }
            return numbers;
        }
    }
}