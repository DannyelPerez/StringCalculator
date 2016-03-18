using System;

namespace StringCalculator.Logic
{
    public class InvalidNumberException : ArgumentException
    {
        public InvalidNumberException(string message) : base(message)
        {

        }
    }
}