using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Person
    {
        private int age;
        private string name;

        public Person() //constructor overloading
        {
            age = 0;
            name = "Anonymous";
        }

        public Person(int a, string n)
        {
            age = a;
            name = n;
        }

        public virtual void display()
        {
            Console.WriteLine("**** Person's Info ****");
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Age:"+age);
        }
    }
}
