using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Add_Mult
    {
        public void AddNumbers(int num1, int num2)
        {
            Console.WriteLine("Addition is:"+(num1 + num2));
        }

        public static void MultiplyNumbers(int num1, int num2)
        {
            Console.WriteLine("Multiplication is:" + (num1 * num2));
        }

        public static void HelloMsgFromAdd_Mult(string message)
        {
            Console.WriteLine("Message from Add_Mult:"+message);
        }
    }
}
