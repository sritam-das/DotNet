using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 10, num3 = 0;
            int[] arr = new int[] { 1, 2, 3, 4 };
            Person personObj = null;
            string num = "5.5";
            
            string msg = string.Empty;
            int age = 0;
            Console.WriteLine("Enter the value of age:");
            try
            {
                arr[2] = 10;
                num3 = num1 / num2;
                //msg = personObj.Name;
                //num3 = int.Parse(num);
                //age = Convert.ToInt32(Console.ReadLine());
                age = int.Parse(Console.ReadLine());
                if(age<18)
                {
                    throw new AgeException("Age should be greater than 18");
                }
            }
            catch(AgeException ex)
            {
                Console.WriteLine("Specific catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) //specific
            {
                Console.WriteLine("Specific catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Specific catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Specific catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Specific catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)   //generic
            {
                //Console.WriteLine("Oops!!! An error occurred!!!");
                Console.WriteLine("Generic catch block executed!!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program is terminating...");
            }

            //assignment1:perform the exception handling for null reference exception and format exception

            //assignment2: create a custom exception class that checks for invalid index of an array
            //If the index is>length of array or the index value is negative, through the custom exception
            //with appropriate error message

        }
    }
}
