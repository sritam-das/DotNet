using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public abstract class Employee:Person
    {
        int empId;
        protected double salary;

        public Employee():base()
        {
            empId = 0;
            salary = 0.0;
        }

        public Employee(int a, string n,int eid, double sal):base(a,n)
        {
            empId = eid;
            salary = sal;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("**** Employee's Info ****");
            Console.WriteLine("Employee ID:" + empId);
            Console.WriteLine("Basic Salary:" + salary);
        }

        public abstract double CalculateSalary();
       
    }
}
