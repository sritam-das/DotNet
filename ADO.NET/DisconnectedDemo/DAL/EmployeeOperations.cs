using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeOperations
    {
        SqlConnection sqlConnectionObj;
        SqlCommand sqlCommandObj;
        SqlDataAdapter dataAdapterObj;
        SqlCommandBuilder commandBuilderObj;
        DataSet dataSetObj;
        // Integrated Security=SSPI

        public void Init()
        {
            sqlConnectionObj = new SqlConnection();
            sqlConnectionObj.ConnectionString =
                @"Data Source=.;database=FrTpDotNetDB;User Id=sa;Password=cybage@123";
            sqlCommandObj = new SqlCommand();
            sqlCommandObj.Connection = sqlConnectionObj;
            sqlCommandObj.CommandType = CommandType.Text;
            sqlCommandObj.CommandText = "select * from Employee";

            //dataAdapterObj = new SqlDataAdapter("select * from tblEmployee",sqlConnectionObj);
            dataAdapterObj = new SqlDataAdapter(sqlCommandObj);
            dataSetObj = new DataSet();
            //dataAdapterObj.Fill(dataSetObj);
            //dataAdapterObj.FillSchema(dataSetObj,"tblEmployee")
            dataAdapterObj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataAdapterObj.Fill(dataSetObj);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Init();
            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow dataRow in dataTableObj.Rows)
            {
                Employee employeeObj = new Employee
                {
                    EmployeeID = Convert.ToInt32(dataRow[0].ToString()),
                    Name = dataRow[1].ToString(),
                    City = dataRow[2].ToString(),
                    MgrID = string.IsNullOrEmpty(dataRow[3].ToString()) ? 0 : int.Parse(dataRow[3].ToString()),
                    Salary = Convert.ToDouble(dataRow[4].ToString()),
                    DeptID = string.IsNullOrEmpty(dataRow[5].ToString()) ? 0 : int.Parse(dataRow[5].ToString()),
                    Phno = string.IsNullOrEmpty(dataRow[6].ToString()) ? 0 : Convert.ToInt64(dataRow[6].ToString())
                };
                employees.Add(employeeObj);
            }
            return employees;
        }

        public Employee GetEmployeeByID(int id)
        {

            Init();
            DataTable dataTableObj = dataSetObj.Tables[0];
            DataRow searchedRow = dataTableObj.Rows.Find(id);
            Employee searchedEmployee = new Employee
            {
                EmployeeID = Convert.ToInt32(searchedRow[0].ToString()),
                Name = searchedRow[1].ToString(),
                City = searchedRow[2].ToString(),
                MgrID = string.IsNullOrEmpty(searchedRow[3].ToString()) ? 0 : int.Parse(searchedRow[3].ToString()),
                Salary = Convert.ToDouble(searchedRow[4].ToString()),
                DeptID = string.IsNullOrEmpty(searchedRow[5].ToString()) ? 0 : int.Parse(searchedRow[5].ToString()),
                Phno = string.IsNullOrEmpty(searchedRow[6].ToString()) ? 0 : Convert.ToInt64(searchedRow[6].ToString())
            };
            return searchedEmployee;
        }

        //insert,update and delete

        public bool AddEmployee(string name, string city, int mgrId, double salary, int deptId, long phno)
        {
            Init();
            DataTable dataTableObj = dataSetObj.Tables[0];
            DataRow newRow = dataTableObj.NewRow();
            newRow[1] = name;
            newRow[2] = city;
            newRow[3] = mgrId;
            newRow[4] = salary;
            newRow[5] = deptId;
            newRow[6] = phno;
            dataTableObj.Rows.Add(newRow);

            commandBuilderObj = new SqlCommandBuilder(dataAdapterObj);
            int updatedStatus = dataAdapterObj.Update(dataSetObj);
            if (updatedStatus > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEmployee(int id, string name, string city, int mgrId, double salary, int deptId, long phno)
        {
            Init();
            DataTable dataTableObj = dataSetObj.Tables[0];
            DataRow searchedRow = dataTableObj.Rows.Find(id);
            searchedRow[1] = name;
            searchedRow[2] = city;
            searchedRow[3] = mgrId;
            searchedRow[4] = salary;
            searchedRow[5] = deptId;
            searchedRow[6] = phno;

            commandBuilderObj = new SqlCommandBuilder(dataAdapterObj);
            int updatedStatus = dataAdapterObj.Update(dataSetObj);
            if (updatedStatus > 0)
                return true;
            else
                return false;
        }
        public bool DeleteEmployee(int id)
        {
            Init();
            DataTable dataTableObj = dataSetObj.Tables[0];
            DataRow searchedRow = dataTableObj.Rows.Find(id);
            searchedRow.Delete();

            commandBuilderObj = new SqlCommandBuilder(dataAdapterObj);
            int updatedStatus = dataAdapterObj.Update(dataSetObj);
            if (updatedStatus > 0)
                return true;
            else
                return false;
        }
        public Employee GetEmployeeByIdUsingParameter(int id)
        {

            sqlConnectionObj = new SqlConnection();
            sqlConnectionObj.ConnectionString =
                @"Data Source=.;database=FrTpDotNetDB;Integrated Security=SSPI";
            sqlCommandObj = new SqlCommand();
            sqlCommandObj.Connection = sqlConnectionObj;
            sqlCommandObj.CommandType = CommandType.Text;
            sqlCommandObj.CommandText = "select * from tblEmployee where employeeid=@id";
            sqlCommandObj.Parameters.AddWithValue("@id", id);
            //dataAdapterObj = new SqlDataAdapter("select * from tblEmployee",sqlConnectionObj);
            dataAdapterObj = new SqlDataAdapter(sqlCommandObj);
            dataSetObj = new DataSet();

            dataAdapterObj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataAdapterObj.Fill(dataSetObj);
            DataTable dataTableObj = dataSetObj.Tables[0];

            Employee employeeObj = new Employee
            {
                EmployeeID = Convert.ToInt32(dataTableObj.Rows[0][0].ToString()),
                Name = dataTableObj.Rows[0][1].ToString(),
                City = dataTableObj.Rows[0][2].ToString(),
                MgrID = string.IsNullOrEmpty(dataTableObj.Rows[0][3].ToString()) ? 0 : int.Parse(dataTableObj.Rows[0][3].ToString()),
                Salary = Convert.ToDouble(dataTableObj.Rows[0][4].ToString()),
                DeptID = string.IsNullOrEmpty(dataTableObj.Rows[0][5].ToString()) ? 0 : int.Parse(dataTableObj.Rows[0][5].ToString()),
                Phno = string.IsNullOrEmpty(dataTableObj.Rows[0][6].ToString()) ? 0 : Convert.ToInt64(dataTableObj.Rows[0][6].ToString())
            };
            return employeeObj;

        }
    }
}
