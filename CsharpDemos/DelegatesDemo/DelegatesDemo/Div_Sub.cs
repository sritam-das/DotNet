using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Div_Sub
    {
        public void SubtractNumbers(int num1, int num2)
        {
            Console.WriteLine("Subtraction is:" + (num1 - num2));
        }

        public static void DivideNumbers(int num1, int num2)
        {
            Console.WriteLine("Division is:" + (num1 / num2));
        }
        public static void HelloMsgFromDiv_Sub(string message)
        {
            Console.WriteLine("Message from Div_Sub:" + message);
        }
    }
}
