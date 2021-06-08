using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class GenericOps<T,U>
    {
        public static void Swap(T num1, T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Data after swapping:");
            Console.WriteLine("First Value:{0}\tSecond Value:{1}", num1, num2);
        }

        public static void Printdata(T num1, U num2)
        {
            Console.WriteLine("Data-1:{0},Data-2:{1}", num1, num2);
        }

    }
}
