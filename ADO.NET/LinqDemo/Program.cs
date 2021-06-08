using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    delegate bool FindPeople(Person personObj);
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person{SSN=100,Name="Sritam Das",Age=26 },
                  new Person{SSN=101,Name="Aday Pult",Age=11 },
                    new Person{SSN=102,Name="Ravi Kumar",Age=29 },
                      new Person{SSN=103,Name="Priya Bansal",Age=18 },
                        new Person{SSN=104,Name="viru P",Age=42 },
                          new Person{SSN=105,Name="Jay Das",Age=30 }
            };

            foreach(Person element in people)
            {
                if(element.Age<22)
                {
                    Console.WriteLine(element.Name);
                }
            }

            Console.WriteLine("_______________________________________");
            Person[] teenager = PersonExtension.where(people, delegate (Person personObj) {

                return  personObj.Age > 12 && personObj.Age < 26;
            });
            Console.WriteLine(teenager.Length);

            List<string> fruits = new List<string> { "strawberry", "blueberry" };
            var berries = from fruit in fruits
                          where fruit.Contains("berry")
                          select fruit;
            foreach(string fruit in berries)
            {
                Console.WriteLine(fruit);
            }
            
            


        }
    }
}
