using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Logic;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_empty_string_return_zero()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("");
            Assert.AreEqual(0,result,"Expected 0 when string is empty");
        }

        [TestMethod]
        public void Add_one_number_return_same_number()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("2");
            Assert.AreEqual(2,result,"Expected same number when one parameter");
        }
        [TestMethod]
        public void Add_null_return_zero()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add(null);
            Assert.AreEqual(0, result, "Expected 0 when string is empty");
        }

        [TestMethod]
        public void Add_two_numbers_return_sum()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("2,3");
            Assert.AreEqual(5, result, "Expected 5");
        }

        [TestMethod]
        public void Add_three_numbers_return_sum()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("2,3,4");
            Assert.AreEqual(9, result, "Expected 9");
        }

        [TestMethod]
        public void Add_five_numbers_return_sum()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("2,3,4,5,6");
            Assert.AreEqual(20, result, "Expected 20");
        }

        [TestMethod]
        public void Add_five_numbers_with_new_line_return_sum()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("2\n3,4\n5,6");
            Assert.AreEqual(20, result, "Expected 20");
        }

        [TestMethod]
        public void Add_two_numbers_with_custom_delimiter()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("//;\n1;2");
            Assert.AreEqual(3, result, "Expected 3");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void Add_negative_numbers_is_invalid()
        {
            var calculator = new Calculator(new Parser());
            var result = calculator.Add("1,-2");

        }
    }
}
