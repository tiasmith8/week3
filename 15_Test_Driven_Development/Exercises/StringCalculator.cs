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
            char delimeterChar=',';

            //If string is not empty
            if (numbers.Length >= 1)
            {
                //Input //;\n1;2 should return 3
                //If string is 3 or more characters
                if (numbers.Length > 2 && numbers.StartsWith("//"))
                {   //If the string starts with the delimeter marker
                    delimeterChar = numbers[2];
                    numbers = sum + numbers.Substring(3);
                }
                foreach (string element in numbers.Split(delimeterChar, '\n'))
                {
                    sum += int.Parse(element);
                }

                return sum;
            }
            //String is empty, so return 0
            else
            {
                return sum;
            }
        }
    }
}
