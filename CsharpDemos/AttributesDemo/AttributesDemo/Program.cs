using System;
using System.Reflection;

[assembly:CLSCompliant(true)]



namespace AttributesDemo
{
    [Author("Mary",Age =34)]
    class Program
    {
        [Obsolete("This is old function, instead use printNameNew")]
        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static void PrintNameNew(string name)
        {
            Console.WriteLine("Hello "+name);
        }

        [Author("John",Age =20)]
        public void AddNumbers(int num1,int num2)
        {
            Console.WriteLine("Addition is:{0}",num1+num2);
        }

        [Author("Jenna",Age =30)]
        public void MultiplyNumbers(int num1, int num2)
        {
            Console.WriteLine("Multiplication is:{0}", num1 * num2);
        }

        static void Main(string[] args)
        {
            PrintName("John");
        }
    }
}
