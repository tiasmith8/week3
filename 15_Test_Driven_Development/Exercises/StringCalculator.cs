using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    //"1,2"
    public class StringCalculator
    {
        public int Add(string numbers)

        {
            int sum = 0;
            
            //testing for more than two numbers by means of string length
            if (numbers.Length >= 1)
            {
                //string[] numbersBrokenOut = numbers.Split(',');

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
