using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzApp;

namespace TDDDemo
{
    /*
      FizzBuzzApp
     1) Print the nos. from 1 to 100
     2) If a number is 3 or divisible by 3 then print Fizz
     3) If a number is 5 or divisible by 5 then print Buzz
     4) If a number is divisible by 3 and 5 then print FizzBuzz
     5) Else print the same number
     */
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClass fizzBuzzAppObj = 
                new FizzBuzzClass();
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine
                    (fizzBuzzAppObj.FizzBuzz(i));
            }
        }
    }
}
