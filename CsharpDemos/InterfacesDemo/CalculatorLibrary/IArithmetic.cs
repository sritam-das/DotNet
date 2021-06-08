using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface IArithmetic
    {
        void Addition(int num1, int num2);
        void Multiplication(int num1, int num2);
        string Greet(string name);
    }
}
