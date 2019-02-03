using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class WordsToNumbers
    {
        public int Convert(string number)
        {
            int sum = 0;
            //Under 21
            if(dictNumsToWords.ContainsKey(number))
            {
                return dictNumsToWords[number];
            }

            //Over twenty-one", 21
            else //Split the 2 digit number
            {
                string[] split2DigitNumber = number.Split("-");
                foreach (string s in split2DigitNumber)
                {
                    sum += dictNumsToWords[s];
                }

            }



            return sum;

        }


        //Create dictionary
        Dictionary<string, int> dictNumsToWords = new Dictionary<string, int>();

        public WordsToNumbers()
        {
            //Add values for 0-19
            dictNumsToWords.Add("zero", 0);
            dictNumsToWords.Add("one", 1);
            dictNumsToWords.Add("two", 2);
            dictNumsToWords.Add("three", 3);
            dictNumsToWords.Add("four", 4);
            dictNumsToWords.Add("five", 5);
            dictNumsToWords.Add("six", 6);
            dictNumsToWords.Add("seven", 7);
            dictNumsToWords.Add("eight", 8);
            dictNumsToWords.Add("nine", 9);
            dictNumsToWords.Add("ten", 10);
            dictNumsToWords.Add("eleven", 11);
            dictNumsToWords.Add("twelve", 12);
            dictNumsToWords.Add("thirteen", 13);
            dictNumsToWords.Add("fourteen", 14);
            dictNumsToWords.Add("fifteen", 15);
            dictNumsToWords.Add("sixteen", 16);
            dictNumsToWords.Add("seventeen", 17);
            dictNumsToWords.Add("eighteen", 18);
            dictNumsToWords.Add("nineteen", 19);
            dictNumsToWords.Add("twenty", 20);
            //30, 40, 50, 60, 70, 80, 90
            dictNumsToWords.Add("thirty", 30);
            dictNumsToWords.Add("forty", 40);
            dictNumsToWords.Add("fifty", 50);
            dictNumsToWords.Add("sixty", 60);
            dictNumsToWords.Add("seventy", 70);
            dictNumsToWords.Add("eighty", 80);
            dictNumsToWords.Add("ninety", 90);
        }


    }
}
