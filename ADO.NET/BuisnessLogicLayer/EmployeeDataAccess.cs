using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BuisnessLogicLayer
{
    public class EmployeeDataAccess
    {
        public List<Employee> GetEmployees()
        {
            EmployeeDataClass employeeDataClass = new EmployeeDataClass();
            return employeeDataClass.GetAllEmployees();
        }   

        public Employee GetEmployee(int id)
        {
            EmployeeDataClass employeeDataClass = new EmployeeDataClass();
            return employeeDataClass.getEmployee(id);
        }

        public string AddEmployee
            (string empName, string city, int mgrId, double sal, int deptid, long phNo)
        {
            EmployeeDataClass employeeDataClass = new EmployeeDataClass();
            if(employeeDataClass.InsertEmployee(empName,city,mgrId,sal,deptid,phNo)>0)
            {
                return "Data added successfully !!!";
            }
            else
            {
                return "No record created !!!";
            }
        }

        public string DeleteEmployees(string empName)
        {
            EmployeeDataClass employeeDataClass = new EmployeeDataClass();
            if (employeeDataClass.DeleteEmployee(empName) > 0)
            {
                return "Data deleted successfully !!!";
            }
            else
            {
                return "No record deleted !!!";
            }
        }

        public string UpdateEmployees(int id,double salary)
        {
            EmployeeDataClass employeeDataClass = new EmployeeDataClass();
            if (employeeDataClass.UpdateEmployee(id,salary) > 0)
            {
                return "Data updated successfully !!!";
            }
            else
            {
                return "No record updated !!!";
            }
        }

    }
}
