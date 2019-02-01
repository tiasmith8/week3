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
            
            //testing for more than two numbers by means of string length
            if (numbers.Length >= 1)
            {
                // loop resulting string from split
                foreach (string element in numbers.Split(','))
                {
                    sum += int.Parse(element);
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}
