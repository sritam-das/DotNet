using System;
using NSubDemo;
using NSubstitute;
using NUnit.Framework;

namespace NSubDemo.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase]
        public void WhenAddNumbersIsCalledChecksIfItIsCalled()
        {
            //arrange
            ICalculator calculatorObj = Substitute.For<ICalculator>();
            int result = 0;
            //act
            calculatorObj.AddNumbers(2, 2);
            //assert
            //calculatorObj.Received().AddNumbers(2, 2);
            // Assert.That(4, Is.EqualTo(calculatorObj.AddNumbers(2, 2).Returns(4)));
            //Assert.That((calculatorObj.AddNumbers(2, 2).Returns(4)),Is.EqualTo(4));
            //Assert.AreEqual(calculatorObj.AddNumbers(2, 2), 4);
            calculatorObj.Received().AddNumbers(Arg.Any<int>(),Arg.Any<int>());
        }
    }
}
