using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubDemo
{
    public interface ICalculator
    {
        int AddNumbers(int num1, int num2);
        int MultiplyNumbers(int num1, int num2);
    }
}
