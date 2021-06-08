using DataAccessLayer;
using System;
using BuisnessLogicLayer;
namespace ConnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
               foreach(Employee emp in employeeDataAccess.GetEmployees())
               {
                   Console.WriteLine(emp.Empid+"\t"+emp.EmpName+"\t\t"+emp.City+"\t\t"+emp.Salary);
               }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Employee employee = employeeDataAccess.GetEmployee(1001);
            Console.WriteLine("Employee searched is:"+employee.EmpName+"\t\t"+employee.Salary);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            employeeDataAccess.AddEmployee("Akelarr 4", "California", 1007, 49000.00, 1, 7518861545);
            foreach (Employee emp in employeeDataAccess.GetEmployees())
            {
                Console.WriteLine(emp.Empid + "\t" + emp.EmpName + "\t\t" + emp.City + "\t\t" + emp.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            employeeDataAccess.DeleteEmployees("Sritam Das");

            Console.WriteLine();
            foreach (Employee emp in employeeDataAccess.GetEmployees())
            {
                Console.WriteLine(emp.Empid + "\t" + emp.EmpName + "\t\t" + emp.City + "\t\t" + emp.Salary);
            }

            Console.WriteLine();
            Console.WriteLine();
            employeeDataAccess.UpdateEmployees(1024,105000.00);

        }
    }
}
