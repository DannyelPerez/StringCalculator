using System;
using System.Collections.Generic;
using System.Linq;
using StringCalculator.Logic.Extensions;

namespace StringCalculator.Logic
{
    public class Calculator
    {
        private readonly IParser _parser;

        public Calculator(IParser parser)
        {
            _parser = parser;
        }

        public int Add(string numbers)
        {
            var nums = _parser.Parse(numbers);
            var result = 0;
            foreach (var num in nums)
            {
                if(num < 0)
                    throw new InvalidNumberException("The nasty number is "+num);
                result += num;
            }   
            return result;
        }
    }
}