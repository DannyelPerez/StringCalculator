using System;
using System.Collections.Generic;
using System.Linq;
using StringCalculator.Logic.Extensions;

namespace StringCalculator.Logic
{
    public class Calculator
    {
        private readonly IParser _parser = new Parser();

        public int Add(string numbers)
        {
            var nums = _parser.Parse(numbers);
            var result = 0;
            foreach (var num in nums)
            {
                result += num.ToInt();
            }
            return result;
        }
    }
}