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

        [TestMethod]
        public void StringCalculator_TestString12()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act
            int actual = unitTest.Add("1,2");

            //Assert
            Assert.AreEqual(3, actual, "1,2 should return 3");
        }

        [TestMethod]
        public void StringCalculator_TestStringMultipleNumbers()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act
            int actual = unitTest.Add("1,2,3");

            //Assert
            Assert.AreEqual(6, actual, "1,2,3 should return 6");

        }

        [TestMethod]
        public void StringCalculator_TestWithNewLineCharsAndCommas()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act
            int actual = unitTest.Add("5\n3,2");

            //Assert
            Assert.AreEqual(10, actual, "5\n3,2 should return 10");

        }

        [TestMethod]
        public void StringCalculator_Test_For_Input_Delimiter()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act
            int actual = unitTest.Add("//;\n1;2");

            //Assert
            Assert.AreEqual(10, actual, "//;\n1;2 should return 3");

        }


    }
}
