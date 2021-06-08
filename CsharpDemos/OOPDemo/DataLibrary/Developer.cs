using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Developer:Employee
    {
        int noOfHours;
        public Developer() : base()
        {
            noOfHours = 0;
        }

        public Developer(int a, string n, int eid, double sal, int hrs) : base(a, n, eid, sal)
        {
            noOfHours = hrs;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("**** Developer's Info ****");
            Console.WriteLine("No. of hours:" + noOfHours);
        }

        public override double CalculateSalary()
        {
            //return base.CalculateSalary() + allowance;
            return salary + 100*noOfHours;
        }
    }
}
