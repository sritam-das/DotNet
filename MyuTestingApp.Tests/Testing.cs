using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyTestingApp;

namespace MyuTestingApp.Tests
{
    [TestFixture]
    public class Testing
    {
        Calculator calObj = new Calculator();

        [TestCase(5,7, ExpectedResult =12)]
        public int WhenAddNumberExecutesReturnsValue(int num1, int num2)
        {
            int result = calObj.AddNumber(5, 7);
            return result;
        }
        [TestCase(7,5)]
        public void WhenAddNumberExecutesReturnsValues(int num1, int num2)
        {
            int result = calObj.MultiplyNumber(num1, num2);
            Assert.AreEqual(35, result);
        }

        [Test]
        public void WhenMultiplyReturns20()
        {
            Calculator obj = new Calculator();
            int result;
            result = obj.MultiplyNumber(6, 4);
            Assert.GreaterOrEqual(28, result);
        }
        [Test]
        public void WhenStringsReceivedCheckAssertions()
        {
            string myQuote = "You will work as a Cloud Architect in Amazon!";
            // Assert.That(myQuote, Is.Empty);
            Assert.That(myQuote, Is.EqualTo("You will work as a Cloud Architect in Amazon!"));
        }
        [TestCase(10,20)]
        public void WhenNumbersReceivedCheckAssertion(int num1, int num2)
        {
            // Assert.That(calObj.AddNumber(num1, num2), Is.EqualTo(30));
            //  Assert.That(calObj.AddNumber(num1, num2), Is.EqualTo(30.5).Within(0.5));
            Assert.That(calObj.AddNumber(num1, num2), Is.AtLeast(25));
        }
        [Test]
        public void WhenDateTimeReceivedCheckAssertions()
        {
            DateTime dateTime = DateTime.Now;
            DateTime later = dateTime + TimeSpan.FromHours(2);
            Assert.That(dateTime, Is.EqualTo(later));
        }


    }
}
