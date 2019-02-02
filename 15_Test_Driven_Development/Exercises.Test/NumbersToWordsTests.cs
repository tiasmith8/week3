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
        [DataTestMethod]
        [DataRow(10, "ten", "10 returns ten")]
        [DataRow(14, "fourteen", "14 returns fourteen")]
        [DataRow(26, "twenty-six", "26 returns twenty-six")]
        public void Convert_Double_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        //3 digit numbers (two hundred and nine, three hundred, four hundred and ninety-eight)
        [DataTestMethod]
        [DataRow(100, "one hundred", "100 returns one hundred")]
        [DataRow(209, "two hundred and nine", "209 returns two hundred and nine")]
        [DataRow(498, "four hundred and ninety-eight")]
        public void Convert_Triple_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

    }
}
