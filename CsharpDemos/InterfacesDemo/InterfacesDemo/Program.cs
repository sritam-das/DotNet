using System;
using CalculatorLibrary;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IArithmetic arithmeticObj = new Calculator();
            arithmeticObj.Addition(10, 20);
            arithmeticObj.Multiplication(2, 3);
            Console.WriteLine(arithmeticObj.Greet("John"));
            ITrigonometry trigonometryObj = new Calculator();
            trigonometryObj.Sine(90);
            trigonometryObj.Cosine(90);
            Console.WriteLine(trigonometryObj.Greet("Jenna"));
        }
    }
}
