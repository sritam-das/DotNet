using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "Person: " + Name + " is " + Age + "yrs old";
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            #region 1D
            /*  int[] intArray = new int[5];
              intArray[0] = 10;
              intArray[1] = 20;
              intArray[2] = 30;
              intArray[3] = 40;
              intArray[4] = 50;
              string[] Fruits = {"Strawberry","Blueberry","Blackberry","Raspberry","Mulberry" };
              double[] doubleArray = new double[5]{10.10,20.20,30.30,40.40,50.50 };
              Console.WriteLine(intArray[0]+ " is first element");
              Console.WriteLine("Length of integer array:"+intArray.Length);
              Console.WriteLine("Array elements are:");

              for (int i=0;i<intArray.Length;i++)
              {
                  Console.Write(intArray[i]+"\t");
              }
              Console.WriteLine();

              //foreach(every element in collection)
              Console.WriteLine("Array elements are:");
              foreach (string fruit in Fruits)
              {
                  Console.Write(fruit+ "\t");
              }

              Console.WriteLine("Array elements are:");
              foreach (double element in doubleArray)
              {
                  Console.Write(element + "\t");
              }

              Console.WriteLine();
              object[] objectArray = { 10, 10.20, "Hello World", 'B', new Person { Age = 20, Name = "John" } };
              Console.WriteLine("Array elements are:");
              foreach (object element in objectArray)
              {
                  Console.Write(element + "\t");
              }
              Console.WriteLine();
              Person[] people = new Person[4] 
              {
                  new Person { Age = 20, Name = "John" },
                  new Person { Age = 22, Name = "Jenna" },
                  new Person { Age = 24, Name = "Jeccinta" },
                  new Person { Age = 26, Name = "Jared" }
              };
              Console.WriteLine("People in my family:");
              foreach(Person person in people)
              {
                  Console.Write(person+"\t");
              }
              Console.WriteLine();*/
            #endregion

            #region Multidimensional
            /*int[,] intArray = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            Console.WriteLine(intArray[1,0]);
            Console.WriteLine(intArray.Length);
            Console.WriteLine("Array elements is:");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");
            for (int i = 0; i <= intArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= intArray.GetUpperBound(1); j++)
                {
                    Console.Write(intArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,,] int3DArray = new int[2, 2, 3]
            {
                { {1,2,3 },{4,5,6} },
                {{7,8,9},{10,11,12}}
            };
            Console.WriteLine("Array elements is 3D array:");
            for (int i = 0; i < int3DArray.GetLength(0); i++)
            {
                for (int j = 0; j < int3DArray.GetLength(1); j++)
                {
                    for (int k = 0; k < int3DArray.GetLength(2); k++)
                            Console.Write(int3DArray[i, j,k] + "\t");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region JaggedArray
            //array of arrays
            int[][] intJaggedArray = new int[3][];
            intJaggedArray[0]=new int[] { 1, 2, 3, 4, 5 };
            intJaggedArray[1] = new int[] { 10 };
            intJaggedArray[2] = new int[] { 100, 200, 300};
            Console.WriteLine(intJaggedArray[0][2]);
            Console.WriteLine("Elements of Jagged array:");
           /* foreach(int[] elements in intJaggedArray)
            {
                foreach (int element in elements)
                {
                    Console.Write(element+"\t");
                }
                Console.WriteLine();
            }*/

            for(int i=0;i<intJaggedArray.Length;i++)
            {
                for(int j=0;j<intJaggedArray[i].Length; j++)
                {
                    Console.Write(intJaggedArray[i][j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("My Favourite fruits are:");
            string[][,] stringJaggedArray = new string[2][,];
            stringJaggedArray[0] = new string[3, 2]
            {
                {"Apple","Banana"},
                {"Blueberry","Raspberry"},
                {"Mulberry","Cherry"}
            };
            stringJaggedArray[1] = new string[2, 2]
            {
                {"Kiwi","Pineapple"},{"Strawberry","Orange"}
            };
            foreach (string[,] elements in stringJaggedArray)
            {
                foreach (string fruit in elements)
                {
                    Console.Write(fruit + "\t");
                }
                Console.WriteLine();
            }

            //Assignment: print elements of stringJaggedArray using the for-loop
            #endregion
        }
    }
}
