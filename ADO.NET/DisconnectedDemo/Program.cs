using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DisconnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations opsObj = new EmployeeOperations();
            List<Employee> employees = opsObj.GetAllEmployees();
            Console.WriteLine("Employee Information:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " stays in " + employee.City +
                    " and works in department:" + employee.DeptID);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Employee Info for 1001:");
            Employee empObj = opsObj.GetEmployeeByID(1001);
            Console.WriteLine(empObj.Name + " stays in " + empObj.City +
                    " and works in department:" + empObj.DeptID);
            Console.WriteLine("-------------------------------------------------------------------");
            /*if(opsObj.AddEmployee("Timothy Jared", "Melbourne", 1009, 20000.00, 3, 9876754423))
                Console.WriteLine("New employee created successfully!!!");
            else
                Console.WriteLine("Oops!!! An error occurred!!!");*/
            Console.WriteLine("-------------------------------------------------------------------");
            /* if (opsObj.UpdateEmployee(1009,"Jared Brown", "California", 1001, 25000.00, 2, 9876754439))
                 Console.WriteLine("Employee updated successfully!!!");
             else
                 Console.WriteLine("Oops!!! An error occurred!!!");*/
            /*if(opsObj.DeleteEmployee(1015))
                Console.WriteLine("Employee deleted successfully!!!");
            else
                Console.WriteLine("Oops!!! An error occurred!!!");*/
            Employee empObj1 = opsObj.GetEmployeeByIdUsingParameter(1011);
            Console.WriteLine(empObj1.EmployeeID + ":" + empObj1.Name + " stays in " + empObj1.City +
                    " and works in department:" + empObj1.DeptID);
            Console.ReadLine();
        }
    }
}
