using System;
using NUnit.Framework;
using MyFirstTestingApp;
using System.IO;

namespace MyFirstTestingApp.Tests
{

    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculatorObj = null;
        FileStream fileStream = null;

        [SetUp][OneTimeSetUp]
        public void SetUp()
        {
            calculatorObj = new Calculator();
            //fileStream= new FileStream(@"D:\Demo\Sample.txt", FileMode.Open, FileAccess.Write);
        }
        #region Classic_model

        /* [TearDown][OneTimeTearDown]
         public void TearDown()
         {
             calculatorObj.Dispose();
             fileStream.Close();

         }

         [Test]
         public void WhenAddNumbersExecutesReturns3()
         {
             //AAA
             //arrange

             int result;

             //act
             result=calculatorObj.AddNumbers(2, 1);

             //assert->Classical Model
             //Assert.AreEqual(3, result);
             //Assert.Greater(4, result);
             //Assert.LessOrEqual(3, result);
             //Assert.IsNaN(result);
             Assert.AreNotSame(3, result);
         }
         //Write the 3 test cases for multiply method

         [TestCase(2,1)]
         [TestCase(2,2)]
         public void WhenAddNumbersExecutesReturnsValue(int num1,int num2)
         {
             //AAA
             //arrange

             int result;

             //act
             result = calculatorObj.AddNumbers(num1,num2);

             //assert
             Assert.AreEqual(3, result);

         }

         [TestCase(2, 1,ExpectedResult =3)]
         [TestCase(2, 2,ExpectedResult =4)]
         [TestCase(3,5,ExpectedResult =8,TestName ="8 is expected",
             Author ="Vrushali",Ignore ="This is old test")]
         public int WhenAddNumbersExecutesReturnsAValue(int num1, int num2)
         {
             //AAA
             //arrange

             int result;

             //act
             result = calculatorObj.AddNumbers(num1, num2);

             //assert
             return result;

         }
         */
        #endregion

        #region Constraint_model
        /*
         Constraint-based model: That() from Assert
         That(actual,constraint expresssion)
         Constraint expression: uses the Helper classes
         Helper classes: enhance the readability of your test case. Make test cases
         to be read like English
         1) Is
         2) Has
         3) Does
         4) Contains
         */
         [TestCase(2,1)]
        public void WhenAddNumbersExecutesReturnsValue(int num1,int num2)
        {
            int result = 0;
            result=calculatorObj.AddNumbers(num1, num2);
            string myString = string.Empty;
            myString = "Hello";
            //Assert.That(result, Is.EqualTo(3));
            Assert.That(myString, Is.Empty);
        }

        [Test]
        public void WhenStringsAreReceivedChecksAssertion()
        {
            string myQuote = "What a wonderful world!!!";
            //Assert.That(myQuote, Is.Empty);
            // Assert.That(myQuote, Is.EqualTo("what a wonderful world!!!").IgnoreCase);
            //Assert.That(myQuote, Does.Contain("worlds"));
            //Assert.That(myQuote, Does.StartWith("What"));
            //Assert.That(myQuote, Does.EndWith("!!!"));
           
        }

        [Test]
        public void WhenNumbersAreReceivedChecksAssertion()
        {
            int num1 = 2, num2 = 3, result = 0;
            result = calculatorObj.AddNumbers(2, 3);
            //Assert.That(result, Is.EqualTo(5.5).Within(0.5));
            //Assert.That(8.7, Is.EqualTo(8.5).Within(2).Percent);
            //Assert.That(9, Is.GreaterThanOrEqualTo(8));
            //Assert.That(9, Is.AtLeast(8));
            // Assert.That(9, Is.AtMost(10));
            Assert.That(9, Is.InRange(5, 10));
        }

        [Test]
        public void WhenDateTimesAreReceivedChecksAssertion()
        {
            DateTime dateTime = DateTime.Now;
            DateTime later = dateTime + TimeSpan.FromHours(2);
            //Assert.That(dateTime, Is.EqualTo(later));
            Assert.That(later,Is.EqualTo(dateTime).Within(TimeSpan.FromHours(3.0)));
        }

        [Test]
        public void WhenCollectionsAreReceivedChecksAssertion()
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            //Assert.That(intArray, Is.All.InRange(0, 6));
            object[] fruits = new object[]
            {
                "Starwberry","Blueberry","Raspberry","Mulberry","Cherry"
            };
            //Assert.That(fruits, Has.Some.EndsWith("Berry").IgnoreCase);
            //Assert.That(fruits, Has.Some.Contains("Berry").IgnoreCase);
            //Assert.That(fruits, Has.All.EndsWith("Berry").IgnoreCase);
            Assert.That(fruits, Is.All.Contains("Berry").IgnoreCase);
        }

        /* create 3 test cases using Is helper class for multiply method*/
        /*create a collection of strings and use atleast 3 methods from any 3 helper
          classes that are not shown in the demo*/
        #endregion
    }

}
