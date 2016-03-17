using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Logic.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this String value)
        {
            return String.IsNullOrEmpty(value);
        }

        public static int ToInt(this String value)
        {
            return Int32.Parse(value);
        }
    }
}
