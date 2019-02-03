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
        [DataRow(498, "four hundred and ninety-eight", "498 returns four hundred and ninety-eight")]
        [DataRow(951, "nine hundred and fifty-one", "951 returns nine hundred and fifty-one")]
        public void Convert_Triple_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }
        //4 digit numbers (three thousand and four, five thousand and twenty-six, 
        //seven thousand and one hundred and eleven)
        [DataTestMethod]
        [DataRow(3004, "three thousand and four", "3004 returns three thousand and four")]
        [DataRow(5026, "five thousand and twenty-six", "5026 returns five thousand and twenty-six")]
        [DataRow(7111, "seven thousand and one hundred and eleven", "7111 returns seven thousand and one hundred and eleven")]
        public void Convert_4_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        //5 digit numbers (forty thousand, eighty-seven thousand and six hundred and fifty-four)
        [DataTestMethod]
        [DataRow(40000, "forty thousand", "40_000 returns forty thousand")]
        [DataRow(87654, "eighty-seven thousand and six hundred and fifty-four", "87_654 returns eighty-seven thousand and six hundred and fifty-four")]
        //[DataRow(7111, "seven thousand and one hundred and eleven", "7111 returns seven thousand and one hundred and eleven")]
        public void Convert_5_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }
        //6 digit numbers 
        //6 digit numbers (five hundred thousand, eight hundred and three thousand 
        //and three hundred and eight, nine hundred and ninety-nine thousand 
        //and nine-hundred and ninety-nine)
        [DataTestMethod]
        [DataRow(500000, "five hundred thousand", "500_000 returns five hundred thousand")]
        [DataRow(803308, "eight hundred and three thousand and three hundred and eight", "eight hundred and three thousand and three hundred and eight")]
        [DataRow(999999, "nine hundred and ninety-nine thousand and nine hundred and ninety-nine", "nine hundred and ninety-nine thousand and nine hundred and ninety-nine")]
        public void Convert_6_Digit_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow(500_010, "five hundred thousand and ten", "500_000 returns five hundred thousand")]
        [DataRow(803008, "eight hundred and three thousand and eight", "803008 returns eight hundred and three thousand and three hundred and eight")]
        [DataRow(999909, "nine hundred and ninety-nine thousand and nine hundred and nine", "999909 returns nine hundred and ninety-nine thousand and nine hundred and ninety-nine")]
        public void Convert_Extra_Numbers_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

    }
}
