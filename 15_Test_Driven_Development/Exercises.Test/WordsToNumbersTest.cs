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

    }
}
