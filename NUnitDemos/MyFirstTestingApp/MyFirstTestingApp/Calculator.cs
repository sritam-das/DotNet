using System;

namespace MyFirstTestingApp
{
    public class Calculator:IDisposable
    {
        int[] arr = new int[5];
        public int AddNumbers(int num1,int num2)
        {
            return num1 + num2;
        }

        public void Dispose()
        {
            arr = null;
        }

        public int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        
    }
}
