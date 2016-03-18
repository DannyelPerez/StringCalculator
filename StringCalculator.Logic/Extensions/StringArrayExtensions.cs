using System;

namespace StringCalculator.Logic.Extensions
{
    public static class StringArrayExtensions
    {
        

        public static int[] ToIntArray(this String[] value)
        {
            var intArray = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                intArray[i] = value[i].ToInt();
            }

            return intArray;
        }
    }
}