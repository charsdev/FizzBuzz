using NUnit.Framework;
using FizzBuzzNS;

namespace TestFizzBuzz
{
    public class Tests
    {
        FizzBuzz _fizzbuzz;

        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(0, ExpectedResult = "FizzBuzz")]
        [TestCase(52, ExpectedResult = "52")]
        public string GivenANumber_ReturnFizzBuzz(int index)
        {
            return _fizzbuzz.GetList(100)[index];
        }
    }
}