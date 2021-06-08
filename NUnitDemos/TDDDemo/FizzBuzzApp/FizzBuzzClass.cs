using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class FizzBuzzClass
    {
        public string FizzBuzz(int input)
        {
            string output= string.Empty;
            if(input%3==0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Buzz";
            }
            if (string.IsNullOrEmpty(output))
            {
                output = input.ToString();
            }
            return output;
        }
    }
}
