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

            //6 digits
            //nine hundred and ninety-nine thousand and nine hundred and ninety-nine", 999999
            if (number.Contains("thousand") && number.Contains("hundred"))
            {
                string[] thousand = number.Split(" thousand");
                if (thousand[0].Contains("hundred")){
                    sum+= Convert3Digits(thousand[0]) * 1000;
                }
                else if(dictNumsToWords.ContainsKey(thousand[0]))
                {
                    sum += ConvertUnder21(thousand[0]) * 1000; ;
                }
                else
                {
                    sum += Convert2Digits(thousand[0]) * 1000; ;
                }



                //sum += Convert3Digits(thousand[0]) * 1000;
                if (thousand[1].Length == 0)
                {
                    return sum;
                }
                else
                {
                    thousand[1] = thousand[1].Substring(5);
                    sum += Convert3Digits(thousand[1]);
                    return sum;
                }
            }

            //5-digits
            //eighty-seven thousand and six hundred and fifty-four", 87654
            else if (number.Contains("thousand"))
            {
                string[] thousand2 = number.Split(" thousand");
                if(dictNumsToWords.ContainsKey(thousand2[0]))
                {
                    sum += dictNumsToWords[thousand2[0]] *1000;
                    if(thousand2[1] == "")//if no more words
                    {
                        return sum;
                    }
                }
                else
                {
                    sum+= Convert2Digits(thousand2[1]) * 1000;
                }

                //sum += Convert3Digits(thousand2[0]) * 1000;
                if (thousand2[1].Length == 0)
                {
                    return sum;
                }
                else
                {
                    thousand2[1] = thousand2[1].Substring(5);

                    if(dictNumsToWords.ContainsKey(thousand2[1]))
                    {
                        sum += ConvertUnder21(thousand2[1]);
                        return sum;
                    }
                    else if(thousand2[1].Contains("-") && !thousand2[1].Contains("and"))
                    {
                        sum += Convert2Digits(thousand2[1]);
                        return sum;
                    }
                    sum += Convert3Digits(thousand2[1]);
                    return sum;
                }

            }

                //4 digits
                //three thousand and four", 3004
                //five thousand and twenty-six", 5026
                //seven thousand and one hundred and eleven", 7111
            else if (number.Contains(" thousand and "))
            {
                string[] thousand = number.Split(" thousand");
                sum += dictNumsToWords[thousand[0]] * 1000;
                sum+=Convert3Digits(number);
            }

            //3 digits
            else if (number.Contains("hundred"))
            {
                sum += Convert3Digits(number);
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

        public int Convert3Digits(string number)
        {
            int sum = 0;

            sum += ConvertUnder21(number.Substring(0, number.IndexOf(' '))) * 100;
            if (number.Contains("-"))
            {
                number = number.Substring(number.LastIndexOf(' ') + 1);
                sum += Convert2Digits(number);
            }
            else if (number.Contains("and"))
            {
                number = number.Substring(number.LastIndexOf(' ') + 1);
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
