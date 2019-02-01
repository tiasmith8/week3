using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalculatorTests
    {
        private const string Numbers = "";

        [TestMethod]
        public void StringCalculator_AddTestSendEmptyStringReceive0()
        {
            //Arrange  declare and intialize new string containing 2 numbers
            //instantiate a new object from the StringCalculator Class
            StringCalculator testAdd = new StringCalculator();
            string input = "";

            //Act declare and initliaze new int variable equal to Add(string numbers) 
            int result = testAdd.Add(input);
            //Assert
            //compare result of Add(string numbers) actual result with expected result
            //evaluate equality to detrmine if method .Add works. 
            Assert.AreEqual(0, result, "empty string returns 0");
        }

        [TestMethod]
        public void StringCalculator_AddTestWith1Returns1()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act - public int Add(string numbers)
            int actualValueReturned = unitTest.Add("1");

            //Assert
            Assert.AreEqual(1, actualValueReturned, "Sending string of 1 returns int 1.");

        }


    }
}
