using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add(string numbers)
        {
            //Arrange  declare and intialize new string containing 2 numbers
            //instantiate a new object from the StringCalculator Class
            StringCalculator testAdd = new StringCalculator();


            //Act declare and initliaze new int variable equal to Add(string numbers) 
            int result = testAdd.Add("");
            //Assert
            //compare result of Add(string numbers) actual result with expected result
            //evaluate equality to detrmine if method .Add works. 
            Assert.AreEqual(0, result, "empty string returns 0");
        }
    }
}
