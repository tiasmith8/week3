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
        [DataRow(1, "one", "1 returns one")]
        [DataRow(10, "ten", "10 returns ten")]
        [DataRow(20, "twenty", "20 returns twenty")]
        public void Convert_Under_21_To_Words(int num, string expected, string message)
        {
            NumbersToWords ntw = new NumbersToWords();
            string actual = ntw.Convert(num);
            Assert.AreEqual(expected, actual, message);
        }

    }
}
