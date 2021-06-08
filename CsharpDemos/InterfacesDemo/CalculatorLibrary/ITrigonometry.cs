using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ITrigonometry
    {
        void Sine(double angle);
        void Cosine(double angle);
        string Greet(string name);
    }
}
