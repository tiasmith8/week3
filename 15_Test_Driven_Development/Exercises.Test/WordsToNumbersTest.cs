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
        [DataRow("twenty-one", 21, "21 returns twenty-one")]
        [DataRow("thirty-five", 35, "35 returns thirty-five")]
        public void Convert_2_Digit_Words(string num, int expected, string message)
        {
            WordsToNumbers ntw = new WordsToNumbers();
            int actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

    }
}
