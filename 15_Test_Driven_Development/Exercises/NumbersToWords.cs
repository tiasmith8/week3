using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class NumbersToWords
    {
        public string Convert(int number)
        {
            //passing 6 digits gets into long territory
            int digitOne = 0;
            int digitTwo = 0;
            int digitThree = 0;
            int digitFour = 0;
            int digitFive = 0;
            int digitSix = 0;


            int firstDigit = 0;
            int secondDigit = 0;
            int thirdDigit = 0;
            int fourthDigit = 0;
            int fifthDigit = 0;
            int sixthDigit = 0;
            string wordConcat = "";

            //Create dictionary
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
            dictNumsToWords.Add(20, "twenty");
            //30, 40, 50, 60, 70, 80, 90
            dictNumsToWords.Add(30, "thirty");
            dictNumsToWords.Add(40, "forty");
            dictNumsToWords.Add(50, "fifty");
            dictNumsToWords.Add(60, "sixty");
            dictNumsToWords.Add(70, "seventy");
            dictNumsToWords.Add(80, "eighty");
            dictNumsToWords.Add(90, "ninety");

            //5-digits
            if (number.ToString().Length == 5)
            {
                //5-digit number 87_654 => forty thousand
                digitFive = number / 1000;
                if (number % 1000 == 0 || digitFive < 21)
                {
                    wordConcat += dictNumsToWords[digitFive] + " thousand";
                }
                else
                {   
                    wordConcat += dictNumsToWords[digitFive-digitFive % 10] + "-"
                        + dictNumsToWords[digitFive % 10] + " thousand";
                }
                digitThree = int.Parse(number.ToString().Substring(2)) / 100; //657
                if (digitThree != 0)
                {
                    wordConcat += " and " + dictNumsToWords[digitThree] + " hundred";
                }
                digitTwo = int.Parse(number.ToString().Substring(3)) / 10; //33
                if (digitTwo != 0 && int.Parse(number.ToString().Substring(2)) > 21)
                {
                    wordConcat += " and " + dictNumsToWords[digitTwo * 10] + "-"; //30
                }
                if (int.Parse(number.ToString().Substring(3)) < 21 && int.Parse(number.ToString().Substring(3))>0) //less than 21
                {
                    wordConcat += " and " + dictNumsToWords[int.Parse(number.ToString().Substring(3))];
                    return wordConcat;
                }
                digitOne = int.Parse(number.ToString().Substring(4));
                if (digitOne != 0)
                {
                    wordConcat += dictNumsToWords[digitOne];
                }
            }


            //4-digit length
            if (number.ToString().Length == 4)
            {
                //4-digit numbers 3004 : three thousand and four
                digitFour = number / 1000;
                wordConcat = dictNumsToWords[digitFour] + " thousand";
            
                //3333 - operate on next 3 digits
                digitThree = int.Parse(number.ToString().Substring(1)) / 100; //333
                if (digitThree != 0)
                {
                    wordConcat += " and " + dictNumsToWords[digitThree] + " hundred";
                }
                digitTwo = int.Parse(number.ToString().Substring(2)) / 10; //33
                if (digitTwo != 0 && int.Parse(number.ToString().Substring(2)) > 21)
                {
                    wordConcat += " and " + dictNumsToWords[digitTwo* 10] + "-"; //30
                }
                if(int.Parse(number.ToString().Substring(2)) < 21) //less than 21
                {
                    wordConcat += " and " + dictNumsToWords[int.Parse(number.ToString().Substring(2))];
                    return wordConcat;
                }
                digitOne = int.Parse(number.ToString().Substring(3));
                if(digitOne != 0)
                {
                    wordConcat += dictNumsToWords[digitOne];
                }
            }


            //Check if the value is in the dictionary
            if (dictNumsToWords.ContainsKey(number))
            {
                return dictNumsToWords[number];
            }
            //(2-digit numbers)
            else if(number > 20 && number < 100)
            {
                firstDigit = number / 10 * 10;
                secondDigit = number % 10;
                wordConcat = dictNumsToWords[firstDigit] + "-" + dictNumsToWords[secondDigit];
            }
            //Triple digits
            else if(number >= 100 && number <=999)
            {
                firstDigit = number / 100; //4
                secondDigit = number % 100;//98
                if(secondDigit == 0)
                {
                    wordConcat = dictNumsToWords[firstDigit] + " hundred";
                }
                else if(secondDigit < 21)
                {
                    wordConcat = dictNumsToWords[firstDigit] + " hundred and "
                        + dictNumsToWords[secondDigit];
                }
                else if(secondDigit > 21)//secondDigit is greater than 20
                {
                    thirdDigit = secondDigit / 10 * 10;//90
                    secondDigit = secondDigit % 10;//8
                    wordConcat = dictNumsToWords[firstDigit] + " hundred and " +
                        dictNumsToWords[thirdDigit] + "-" + dictNumsToWords[secondDigit];
                }
            }

            return wordConcat;
        }




    }
}
