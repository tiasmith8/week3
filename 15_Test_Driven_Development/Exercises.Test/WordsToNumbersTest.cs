using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Test
{
    [TestClass]
    public class WordsToNumbersTest
    {
        [TestMethod]
        public void SendingZeroReturns0()
        {
            WordsToNumbers zeroConversion = new WordsToNumbers();
            int actual = zeroConversion.Convert("zero");
            Assert.AreEqual(0, actual, "zero returns 0");
        }

        [DataTestMethod]
        [DataRow("one", 1, "1 returns one")]
        [DataRow("ten", 10, "10 returns ten")]
        [DataRow("twenty", 20, "20 returns twenty")]
        public void Convert_Under_21_To_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("twenty-one", 21, "twenty-one returns 21")]
        [DataRow("thirty-five", 35, "thirty-five returns 35")]
        public void Convert_2_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("one hundred", 100, "one hundred returns 100")]
        [DataRow("four hundred and ninety-eight", 498, "four hundred and ninety-eight returns 498")]
        [DataRow("two hundred and nine", 209, "two hundred and nine returns 209")]
        public void Convert_3_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("three thousand and four", 3004, "three thousand and four returns 3004")]
        [DataRow("five thousand and twenty-six", 5026, "five thousand and twenty-six returns 5026")]
        [DataRow("seven thousand and one hundred and eleven", 7111, "seven thousand and one hundred and eleven returns 7111")]
        public void Convert_4_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("forty thousand", 40000, "forty thousand returns 40000")]
        [DataRow("eighty-seven thousand and six hundred and fifty-four", 87654, "eighty-seven thousand and six hundred and fifty-four returns 87654")]
        public void Convert_5_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("four hundred thousand", 400000, "four hundred thousand returns 400000")]
        [DataRow("eight hundred and three thousand and three hundred and eight", 803308, "eight hundred and three thousand and three hundred and eight returns 803308")]
        [DataRow("nine hundred and ninety-nine thousand and nine hundred and ninety-nine", 999999, "nine hundred and ninety-nine thousand and nine hundred and ninety-nine returns 999999")]
        public void Convert_6_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

        [DataTestMethod]
        [DataRow("five hundred thousand and ten", 500_010, "five hundred thousand return 500_000")]
        [DataRow("eight hundred and three thousand and eight", 803008, "eight hundred and three thousand and three hundred and eight return 803008")]
        [DataRow("nine hundred and ninety-nine thousand and nine hundred and nine", 999909, "nine hundred and ninety-nine thousand and nine hundred and ninety-nine returns 999909")]
        public void Convert_Extra_Words_To_Numbers(string expected, int num, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }


    }
}
