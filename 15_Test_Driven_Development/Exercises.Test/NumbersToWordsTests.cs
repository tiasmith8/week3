using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Test
{
    [TestClass]
    public class NumbersToWordsTests
    {
        [TestMethod]
        public void Convert_1_Digit_Number_0_To_Zero()
        {
            //Arrange
            NumbersToWords numsToWords = new NumbersToWords();

            //Act
            string word = numsToWords.Convert(0);

            //Assert
            Assert.AreEqual("zero", word, "0 returns zero");
        }

        [DataTestMethod]
        [DataRow(1, "one", "1 returns one")]
        [DataRow(7, "seven", "7 returns seven")]
        [DataRow(9, "nine", "9 returns nine")]
        public void Convert_Single_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

    }
}
