using System;
using NUnit.Framework;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class FizzBuzzClassTests
    {
        [Test]
        public void WhenFizzBuzzExecutesWithOtherValueReturnsSameValue
            ([Values(1,2,4,7,8,11,13,14)]int input)
        {
            FizzBuzzClass fizzBuzzClassObj = new FizzBuzzClass();
            string result = string.Empty;
            result=fizzBuzzClassObj.FizzBuzz(input);
            Assert.That(result, Is.EqualTo(input.ToString()));
        }

        [Test]
        public void WhenFizzBuzzExecutesWith3ReturnsFizz
            ([Values(3,6,9,12)]int input)
        {
            FizzBuzzClass fizzBuzzClassObj = new FizzBuzzClass();
            string result = string.Empty;
            result = fizzBuzzClassObj.FizzBuzz(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void WhenFizzBuzzExecutesWith5ReturnsBuzz
            ([Values(5, 10)]int input)
        {
            FizzBuzzClass fizzBuzzClassObj = new FizzBuzzClass();
            string result = string.Empty;
            result = fizzBuzzClassObj.FizzBuzz(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void WhenFizzBuzzExecutesWith15ReturnsFizzBuzz
            ([Values(15)]int input)
        {
            FizzBuzzClass fizzBuzzClassObj = new FizzBuzzClass();
            string result = string.Empty;
            result = fizzBuzzClassObj.FizzBuzz(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
