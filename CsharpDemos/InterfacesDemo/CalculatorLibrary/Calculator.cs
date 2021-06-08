using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : IArithmetic,ITrigonometry
    {
        public void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition is:"+(num1+num2));
        }

        string IArithmetic.Greet(string name)
        {
            return "Hello to " + name +" from Arithmetic Interface";
        }
        string ITrigonometry.Greet(string name)
        {
            return "Hello to " + name + " from Trigonometry Interface";
        }
        public void Cosine(double angle)
        {
            Console.WriteLine("Cosine is:"+Math.Cos(angle));
        }

        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication is:" + (num1 * num2));
        }

        public void Sine(double angle)
        {
            Console.WriteLine("Sine is:" + Math.Sin(angle));
        }
    }
}
