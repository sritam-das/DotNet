using System;
using DataLibrary;

namespace OOPDemo
{
    class Program
    {
        public void AddNumbers(int num1,int num2)
        {
            Console.WriteLine("Addition:"+(num1+num2));
        }

        public void AddNumbers(int num1, int num2,int num3)
        {
            Console.WriteLine("Addition:" + (num1 + num2+num3));
        }

        public void AddNumbers(double num1, double num2)
        {
            Console.WriteLine("Addition:" + (num1 + num2));
        }


        static void Main(string[] args)
        {
            #region Inheritance
            //Person personObj = new Person(20, "John Smith");
            //Employee employeeObj = new Employee(100, 20000.00);
            //personObj.display();
            //employeeObj.display();

            //generic reference
            /* Person personObj = new Person(20, "John Smith");
             personObj.display();
             personObj=new Employee(10,"Jenna Smith",100, 20000.00);
             personObj.display();*/

            #endregion

            #region Method_overloading
            /*Program programObj = new Program();
            programObj.AddNumbers(10, 20);
            programObj.AddNumbers(10, 20, 30);
            programObj.AddNumbers(10.10, 20.20);*/
            #endregion

            #region Method_overriding
            /* Person personObj = new Employee(20, "John Smith", 100, 20000.00);
             personObj.display();
             Console.WriteLine("-----------------------------------------------------");
             /*Person personObj1 = new SM(30, "Jenna Smith", 101, 22000.00, 2200);
             personObj1.display();*/

            /*Employee employeeObj= new SM(30, "Jenna Smith", 101, 22000.00, 2200);
            employeeObj.display();
            Console.WriteLine(  "Total Salary of SM:"+ employeeObj.CalculateSalary());
            Console.WriteLine("-----------------------------------------------------");
            employeeObj =new Developer(32, "Mary Jane", 102, 25000.00, 20);
            employeeObj.display();
            Console.WriteLine("Total Salary of Developer:" + employeeObj.CalculateSalary());*/

            Console.WriteLine("List of employees:");
            Employee[] employees = new Employee[4]
            {
                new SM(30, "Jenna Smith", 101, 22000.00, 2200),
                new Developer(32, "Mary Jane", 102, 25000.00, 20),
                new SM(33, "Jared Smith", 103, 24000.00, 2400),
                new Developer(28, "Janet Jane", 104, 26000.00, 10)
            };

            for(int i=0;i<employees.Length;i++)
            {
                employees[i].display();
               // Console.WriteLine(employees[i]);
                Console.WriteLine("=======================================");
                //Console.WriteLine(employees[i]);-->Assignment
            }


            #endregion
        }
    }
}
