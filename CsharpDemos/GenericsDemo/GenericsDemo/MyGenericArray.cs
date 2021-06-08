using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class MyGenericArray<T>
    {
        T[] myArray;
        int size;
        public MyGenericArray()
        {
            myArray = new T[size];
        }
        public MyGenericArray(int sizeOfArray)
        {
            size = sizeOfArray;
            myArray = new T[size];
        }

       
        public T getElement(int index)
        {
            return myArray[index];
        }

        public void setElement(int index,T value)
        {
            myArray[index]=value;
        }

        public void displayArray()
        {
            Console.WriteLine("Array elements:");
            foreach(T element in myArray)
            {
                Console.WriteLine(element);
            }
        }

    }
}
