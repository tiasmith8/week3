using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class NumbersToWords
    {
        public string Convert(int number)
        {
            int partialNum = 0;
            string wordConcat = "";
            //Convert single digit numbers to words
            Dictionary<int, string> dictNumsToWords = new Dictionary<int, string>();

            //Add values for 0-19
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
            dictNumsToWords.Add(11, "eleven");
            dictNumsToWords.Add(12, "twelve");
            dictNumsToWords.Add(13, "thirteen");
            dictNumsToWords.Add(14, "fourteen");
            dictNumsToWords.Add(15, "fifteen");
            dictNumsToWords.Add(16, "sixteen");
            dictNumsToWords.Add(17, "seventeen");
            dictNumsToWords.Add(18, "eighteen");
            dictNumsToWords.Add(19, "nineteen");
            //20, 30, 40, 50, 60, 70, 80, 90
            dictNumsToWords.Add(20, "twenty");
            dictNumsToWords.Add(30, "thirty");
            dictNumsToWords.Add(40, "forty");
            dictNumsToWords.Add(50, "fifty");
            dictNumsToWords.Add(60, "sixty");
            dictNumsToWords.Add(70, "seventy");
            dictNumsToWords.Add(80, "eighty");
            dictNumsToWords.Add(90, "ninty");
            //dictNumsToWords.Add(100, "one hundred");

            //check if the value is in the dictionary
            if(dictNumsToWords.ContainsKey(number))
            {
                return dictNumsToWords[number];
            }
            //26 (2-digit numbers)
            else if(number > 20 && number < 100)
            {
                partialNum = number / 10 * 10;
                int remainder = number % 10;

                wordConcat = dictNumsToWords[partialNum] + "-" + dictNumsToWords[remainder];
            }



            return wordConcat;
        }



    }
}
