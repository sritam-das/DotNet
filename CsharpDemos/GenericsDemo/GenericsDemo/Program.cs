using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    //generic method
    //generic classes
    //generic collections
    class Program
    {
        
        static void Main(string[] args)
        {
            /*int num1 = 10, num2 = 20;
            double value1 = 20.20, value2 = 30.30;
            string str1 = "Hello", str2 = "World";
            
            Console.WriteLine("Data before swapping:");
            Console.WriteLine("First Value:{0}\tSecond Value:{1}", num1, num2);
            GenericOps<int,int>.Swap(num1, num2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Data before swapping:");
            Console.WriteLine("First Value:{0}\tSecond Value:{1}", value1, value2);
            
            GenericOps<double,double>.Swap(value1, value2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Data before swapping:");
            Console.WriteLine("First Value:{0}\tSecond Value:{1}", str1, str2);

            GenericOps<string,string>.Swap(str1, str2);
            Console.WriteLine("=======================================================");
            GenericOps<int, double>.Printdata(num1, value1);
            GenericOps<int, string>.Printdata(num2, str1);*/

            MyGenericArray<string> myGenericArrayObj = new MyGenericArray<string>(5);
            myGenericArrayObj.setElement(0, "What");
            myGenericArrayObj.setElement(1, "A");
            myGenericArrayObj.setElement(2, "Wonderful");
            myGenericArrayObj.setElement(3, "World!!!");
            Console.WriteLine("Element at position 3:"+myGenericArrayObj.getElement(3));
            Console.WriteLine();
            myGenericArrayObj.displayArray();
        }
    }
}
