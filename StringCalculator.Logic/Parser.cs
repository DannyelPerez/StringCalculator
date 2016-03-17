using System.Collections.Generic;
using StringCalculator.Logic.Extensions;

namespace StringCalculator.Logic
{
    public class Parser : IParser
    {
        public string[] Parse(string numbers)
        {
            var delimeters = new List<char>() {',', '\n'};

            if(numbers.IsNullOrEmpty())
                return new string[0];

            if (numbers.StartsWith("//"))
            {
                var prefix = numbers.Substring(0,4);
                numbers = numbers.Substring(4, numbers.Length - 4);
                delimeters.Add(prefix[2]);
            }

            var nums = numbers.Split(delimeters.ToArray());
            return nums;
        }
    }
}