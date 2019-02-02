using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    //Calculates sum of 2 or or more integers from a string
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;
            string delimeterFedIn;
            char delimeterChar;

            //testing for more than two numbers by means of string length
            if (numbers.Length >= 1)
            {
                //Test for - //;\n1;2 should return 3
                //Assuming at least 3 characters
                if(numbers.Length > 2)
                {
                    string firstThree = numbers.Substring(0, 3);
                    char[] characterArrayDelimiter;

                    if (firstThree.Substring(0,2).Equals("//"))
                    {
                        //String representation
                        delimeterFedIn = firstThree.Substring(2);
                        //Convert a string of length 1 to a character
                        characterArrayDelimiter = delimeterFedIn.ToCharArray();
                        delimeterChar = Convert.ToChar(delimeterFedIn);

                    }
                    numbers.Split()
                    foreach (string element in numbers.Split(',', , '\n'))
                    {
                        sum += int.Parse(element);
                    }
                    return sum;



                }
                

                //Split based on \n and ,
                // loop resulting string from split
                foreach (string element in numbers.Split(',', '\n'))
                {
                    sum += int.Parse(element);
                }
                return sum;
            }
            else
            {
                return sum;
            }
        }
    }
}
