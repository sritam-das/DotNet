using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class SM:Employee
    {
        int allowance;
        public SM() : base()
        {
            allowance = 0;
        }

        public SM(int a, string n, int eid, double sal,int allow) : base(a, n,eid,sal)
        {
            allowance = allow;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("**** Sales Manager's Info ****");
            Console.WriteLine("Allowance:" + allowance);
        }

        public override double CalculateSalary()
        {
            //return base.CalculateSalary() + allowance;
            return salary + allowance;
        }
    }
}
