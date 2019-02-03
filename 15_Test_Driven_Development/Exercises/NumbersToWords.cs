using System.Collections.Generic;

namespace Exercises
{
    public class NumbersToWords
    {
        //Create dictionary
        Dictionary<int, string> dictNumsToWords = new Dictionary<int, string>();

        public NumbersToWords()
        {
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
        }

        public string Convert(int number)
        {
            if(number.ToString().Length == 6) //6-digits
                return int.Parse(number.ToString().Substring(3)) == 0 ? CalculateThreeDigits(int.Parse(number.ToString().Substring(0, 3))) + " thousand" : CalculateThreeDigits(int.Parse(number.ToString().Substring(0, 3))) + " thousand" + " and " + CalculateThreeDigits(int.Parse(number.ToString().Substring(3)));
            if (number.ToString().Length == 5) //5-digits
                return int.Parse(number.ToString().Substring(2)) == 0 ? CalculateOneOrTwoDigits(int.Parse(number.ToString().Substring(0, 2))) + " thousand" : CalculateOneOrTwoDigits(int.Parse(number.ToString().Substring(0, 2))) + " thousand" + " and " + CalculateThreeDigits(int.Parse(number.ToString().Substring(2)));
            if (number.ToString().Length == 4)//4-digits
                return number % 1000 < 100 ? dictNumsToWords[number / 1000] + " thousand" + " and " + CalculateOneOrTwoDigits(number % 1000) : dictNumsToWords[number / 1000] + " thousand" + " and " + CalculateThreeDigits(number % 1000);
            if(number.ToString().Length < 3) //1 or 2 digits
                return CalculateOneOrTwoDigits(number);
            else //3 digits
                return CalculateThreeDigits(number);
        }

        //Method to calculate words for 1 or 2 digit number
        public string CalculateOneOrTwoDigits(int number)
        {
            return dictNumsToWords.ContainsKey(number) ? dictNumsToWords[number] : dictNumsToWords[number / 10 * 10] + "-" + dictNumsToWords[number % 10];
        }

        //Method to calculate words for 3 digits
        public string CalculateThreeDigits(int number)
        {
            return number % 100 == 0 ? dictNumsToWords[number / 100] + " hundred" : number % 100 != 0 && number / 100 != 0 ? dictNumsToWords[number / 100] + " hundred" + " and " + CalculateOneOrTwoDigits(number % 100) : CalculateOneOrTwoDigits(number % 100);
        }
    }
}