using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class NumbersToWords
    {
        public string Convert(int number)
        {
            //string wordToReturn = "zero";

            //Convert single digit numbers to words
            Dictionary<int, string> dictNumsToWords = new Dictionary<int, string>();

            //Add values for 0-10
            dictNumsToWords.Add(0, "zero");
            dictNumsToWords.Add(1, "one");
            dictNumsToWords.Add(2, "two");
            dictNumsToWords.Add(3, "three");
            dictNumsToWords.Add(4, "four");
            dictNumsToWords.Add(5, "five");
            dictNumsToWords.Add(6, "six");
            dictNumsToWords.Add(7, "seven");
            dictNumsToWords.Add(8, "eight");
            dictNumsToWords.Add(9, "nine");
            dictNumsToWords.Add(10, "ten");

            return dictNumsToWords[number];
        }



    }
}
