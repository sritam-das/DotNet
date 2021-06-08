using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class EmployeeDataClass
    {
        SqlConnection sqlconnectionObj = new SqlConnection();
        SqlCommand sqlcommandObj = new SqlCommand();
        public void Init()
        {
          
            sqlconnectionObj.ConnectionString = @"Data Source=.;Initial Catalog=FrTpDotNetDB;
                                   User Id=sa;Password=cybage@123";
            sqlconnectionObj.Open();
            sqlcommandObj.Connection = sqlconnectionObj;
            sqlcommandObj.CommandType = CommandType.Text;
        }
        #region Getting All Employees
           public List<Employee> GetAllEmployees()
           {
               Init();
               List<Employee> employees = new List<Employee>();
               sqlcommandObj.CommandText = "select * from tblEmployee";
               SqlDataReader sqlDataReader = sqlcommandObj.ExecuteReader();

               while(sqlDataReader.Read())
               {
                   employees.Add(new Employee
                   {
                       Empid = int.Parse(sqlDataReader[0].ToString()),
                       EmpName = sqlDataReader[1].ToString(),
                       City = sqlDataReader[2].ToString(),
                       Salary = Convert.ToDouble(sqlDataReader[4].ToString())
                   });
               }
               sqlconnectionObj.Close();
               return employees;
           }    
        #endregion

        #region Getting Single Employee
        public Employee getEmployee(int id)
        {
            Employee searchedEmployee = null;
            Init();
            sqlcommandObj.CommandText = "select * from tblEmployee where employeeId="+id;
            SqlDataReader sqlDataReader = sqlcommandObj.ExecuteReader();
            while (sqlDataReader.Read())
            {


                searchedEmployee =
                    new Employee
                    {
                        Empid = int.Parse(sqlDataReader[0].ToString()),
                        EmpName = sqlDataReader[1].ToString(),
                        City = sqlDataReader[2].ToString(),
                        Salary = Convert.ToDouble(sqlDataReader[4].ToString())
                    };
               
            }
            sqlconnectionObj.Close();
            return searchedEmployee;
        }
        #endregion

        #region Adding New Employee
        public int InsertEmployee(string empName,string city,int mgrId,double sal,int deptid,long phNo)
        {
            Init();
            int rowsAffectedCount = 0;
            sqlcommandObj.CommandText = "insert into tblEmployee values('" + empName + "','" + city + "'," + mgrId + "," + sal + "," + deptid + "," + phNo + ")";
            rowsAffectedCount = sqlcommandObj.ExecuteNonQuery();
            sqlconnectionObj.Close();
            return rowsAffectedCount;
        }

        public int DeleteEmployee(string empName)
        {
            Init();
            int rowsAffectedCount = 0;
            sqlcommandObj.CommandText = "delete from tblEmployee where EmployeeName='" + empName + "'";
            rowsAffectedCount = sqlcommandObj.ExecuteNonQuery();
            sqlconnectionObj.Close();
            return rowsAffectedCount;
        }

        public int UpdateEmployee( int id,double salary)
        {
            Init();
            int rowsAffectedCount = 0;
            sqlcommandObj.CommandText = "update tblEmployee set Salary=" + salary + " where EmployeeId=" + id;
            rowsAffectedCount = sqlcommandObj.ExecuteNonQuery();
            sqlconnectionObj.Close();
            return rowsAffectedCount;
        }

        #endregion
    }
}
