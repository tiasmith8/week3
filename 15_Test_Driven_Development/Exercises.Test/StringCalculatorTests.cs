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
            //Arrange - Declare and intialize new string containing 2 numbers
            //Instantiate a new object from the StringCalculator Class
            StringCalculator testAdd = new StringCalculator();
            string input = "";

            //Act - Declare and initliaze new int variable equal to Add(string numbers) 
            int result = testAdd.Add(input);
            //Assert
            //Compare result of Add(string numbers) actual result with expected result
            //Evaluate equality to detrmine if Add method works 
            Assert.AreEqual(0, result, "Empty string returns 0");
        }

        [TestMethod]
        public void StringCalculator_AddTestWith1Returns1()
        {
            //Arrange
            StringCalculator unitTest = new StringCalculator();

            //Act - public int Add(string numbers)
            int actualValueReturned = unitTest.Add("1");

            //Assert
            Assert.AreEqual(1, actualValueReturned, "Sending string of 1 returns integer 1");
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
            Assert.AreEqual(3, actual, "//;\n1;2 should return 3");
        }

        [DataTestMethod]
        [DataRow("//!\n4!9", 13, "//!\\n4!9 should return 13")]
        [DataRow("3\n5\n2,6", 16, "/3\\n5\\n2,6 should return 16")]
        [DataRow("3,5,9", 17, "3,5,9 should return 17")]
        public void CalculateExceptions(string input, int expected, string message)
        {
            StringCalculator sct = new StringCalculator();
            int actual = sct.Add(input);
            Assert.AreEqual(expected, actual, message);
        }
    }
}
