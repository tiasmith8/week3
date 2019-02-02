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



    }
}
