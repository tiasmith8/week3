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

            //5 digits
            //"forty thousand", 40000,
            //eighty-seven thousand and six hundred and fifty-four", 87654
            if (number.Contains("thousand"))
            {
                string[] thousand = number.Split(" thousand");
                if (thousand[0].Contains('-'))
                {
                    sum+= Convert2Digits(thousand[0]) * 1000;     
                }
                else
                {
                    sum += ConvertUnder21(thousand[0]) * 1000;
                }
                if(thousand[1].Length>0)
                {
                    number = thousand[1].Substring(5);
                }
                else
                {
                    return sum;
                }
                
                if (number.Contains(" hundred and "))
                {   //		number	"six hundred and fifty-four"	string

                    string[] hundred = number.Split(" hundred and ");
                    sum += dictNumsToWords[hundred[0]] * 100;
                    number = hundred[1];
                }
                if(number.Contains('-'))
                {
                    sum += Convert2Digits(number);
                }
                else
                {
                    sum += ConvertUnder21(number);
                }
                    return sum;
                
            }

                //4 digits
                //three thousand and four", 3004
                //five thousand and twenty-six", 5026
                //seven thousand and one hundred and eleven", 7111
            if (number.Contains(" thousand and "))
            {
                string[] thousand = number.Split(" thousand");
                sum += dictNumsToWords[thousand[0]] * 1000;
                if (thousand[1].Contains("hundred"))
                {
                    thousand[1] = thousand[1].Substring(4);
                    thousand = thousand[1].Split(" hundred ");
                    sum += dictNumsToWords[thousand[0]] * 100;
                    number = thousand[1].Substring(4);
                }
                if (number.Contains('-'))
                {
                    sum += Convert2Digits(thousand[1].Substring(4));
                }
                else if(thousand[1].Length>0)
                {
                    sum += ConvertUnder21(thousand[1].Substring(4));
                }

            }

            //3 digits
            else if (number.Contains("hundred"))
            {
                sum += ConvertUnder21(number.Substring(0, number.IndexOf(' '))) * 100;
                if (number.Contains("-"))
                {
                    number = number.Substring(number.LastIndexOf(' ') + 1);
                    sum += Convert2Digits(number);
                }
                else if(number.Contains("and"))
                {
                    number = number.Substring(number.LastIndexOf(' ') + 1);
                    sum += ConvertUnder21(number);
                }
            }


            //Over twenty-one", 21
            else if (number.Contains('-'))//Split the 2 digit number
            {
                sum += Convert2Digits(number);
            }

            //Under 21
            else //(dictNumsToWords.ContainsKey(number))
            {
                sum += ConvertUnder21(number);
            }


            return sum;

        }

        public int Convert2Digits(string number)
        {
            int sum = 0;
            string[] split2DigitNumber = number.Split("-");
            foreach (string s in split2DigitNumber)
            {
                sum += dictNumsToWords[s];
            }

            return sum;
        }

        public int ConvertUnder21(string number)
        {
            return dictNumsToWords[number];
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
