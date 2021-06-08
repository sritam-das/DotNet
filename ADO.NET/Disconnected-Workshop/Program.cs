using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Disconnected_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations opsObj = new EmployeeOperations();
            List<Employee> employees = opsObj.GetAllEmployeesWhoseSalLessThan3000();
            Console.WriteLine();
            Console.WriteLine("Employee Information salary greater than 3000");
            Console.WriteLine();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.EmpName + "\t\t" + employee.Doj + "\t\t" + employee.Salary + "\t\t" + employee.Design);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Employee Information Who are working as analyst or manager");
            Console.WriteLine();
            employees = opsObj.GetAllEmployeesWhoAreMANAGERorANALYST();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.EmpName + "\t\t" + employee.Doj + "\t\t" + employee.Salary + "\t\t" + employee.Design);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Employee Information Who are working in dept 20 and whose salary is greater than 2000");
            Console.WriteLine();
            employees = opsObj.GetAllEmployeesWhoWorkInDept20AndSalIsGThan2000();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.EmpName + "\t\t" + employee.Doj + "\t\t" + employee.Salary + "\t\t" + employee.Design);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Employee Information Whose name start with j letter");
            Console.WriteLine();
            employees = opsObj.GetAllEmployeesWhoseNameStartWithJ();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.EmpName + "\t\t" + employee.Doj + "\t\t" + employee.Salary + "\t\t" + employee.Design);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Employee Information Whose name has o letter at 2nd n 3rd position");
            Console.WriteLine();
            employees = opsObj.GetAllEmployeesWhoseNameHasOLetter();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.EmpName + "\t\t" + employee.Doj + "\t\t" + employee.Salary + "\t\t" + employee.Design);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
          /*  Console.WriteLine();
            if (opsObj.UpdateEmployeeSalary())
                Console.WriteLine("Employee salary updated successfully!!!");
            else
                Console.WriteLine("Oops!!! An error occurred!!!"); */
            Console.WriteLine(); 
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Employee Information about salary average dept wise");
            Console.WriteLine();
            employees = opsObj.GetAllEmployeesAverageDeptWise();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Dept + "\t\t" + employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
