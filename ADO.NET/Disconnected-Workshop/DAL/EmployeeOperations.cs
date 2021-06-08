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
        DataSet dataSetObj;
        SqlCommandBuilder commadBuilderObj;

        public void Init()
        {
            sqlConnectionObj = new SqlConnection();
            sqlConnectionObj.ConnectionString =
                @"Data Source=.;Initial Catalog=Employee;User Id=sa;Password=cybage@123";
            sqlCommandObj = new SqlCommand();
            sqlCommandObj.Connection = sqlConnectionObj;
            sqlCommandObj.CommandType = CommandType.Text;
            sqlCommandObj.CommandText = "select * from tblEmployee";

            dataAdapterObj = new SqlDataAdapter(sqlCommandObj);
            dataSetObj = new DataSet();
            //dataAdapterObj.Fill(dataSetObj);
            //dataAdapterObj.FillSchema(dataSetObj,"tblEmployee");
            dataAdapterObj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataAdapterObj.Fill(dataSetObj);
        }
        public List<Employee> GetAllEmployeesWhoseSalLessThan3000()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                if (float.Parse(datarow[3].ToString()) < 3000)
                {
                    Employee employeeObj = new Employee

                    {
                        Dept = string.IsNullOrEmpty(datarow[0].ToString()) ? 0 : int.Parse(datarow[0].ToString()),
                        EmpName = string.IsNullOrEmpty(datarow[1].ToString()) ? null : datarow[1].ToString(),
                        Doj = string.IsNullOrEmpty(datarow[2].ToString()) ? DateTime.MinValue : Convert.ToDateTime(datarow[2].ToString()),
                        Salary = string.IsNullOrEmpty(datarow[3].ToString()) ? 0 : float.Parse(datarow[3].ToString()),
                        Design = string.IsNullOrEmpty(datarow[4].ToString()) ? null : datarow[4].ToString()
                    };
                    employees.Add(employeeObj);
                }
            }
            return employees;
        }

        public List<Employee> GetAllEmployeesWhoAreMANAGERorANALYST()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                if (datarow[4].ToString() == "Analyst" || datarow[4].ToString() == "Manager")
                {
                    Employee employeeObj = new Employee

                    {
                        Dept = string.IsNullOrEmpty(datarow[0].ToString()) ? 0 : int.Parse(datarow[0].ToString()),
                        EmpName = string.IsNullOrEmpty(datarow[1].ToString()) ? null : datarow[1].ToString(),
                        Doj = string.IsNullOrEmpty(datarow[2].ToString()) ? DateTime.MinValue : Convert.ToDateTime(datarow[2].ToString()),
                        Salary = string.IsNullOrEmpty(datarow[3].ToString()) ? 0 : float.Parse(datarow[3].ToString()),
                        Design = string.IsNullOrEmpty(datarow[4].ToString()) ? null : datarow[4].ToString()
                    };
                    employees.Add(employeeObj);
                }
            }
            return employees;
        }

        public List<Employee> GetAllEmployeesWhoWorkInDept20AndSalIsGThan2000()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                if (int.Parse(datarow[0].ToString()) == 20 && float.Parse(datarow[3].ToString()) > 2000)
                {
                    Employee employeeObj = new Employee

                    {
                        Dept = string.IsNullOrEmpty(datarow[0].ToString()) ? 0 : int.Parse(datarow[0].ToString()),
                        EmpName = string.IsNullOrEmpty(datarow[1].ToString()) ? null : datarow[1].ToString(),
                        Doj = string.IsNullOrEmpty(datarow[2].ToString()) ? DateTime.MinValue : Convert.ToDateTime(datarow[2].ToString()),
                        Salary = string.IsNullOrEmpty(datarow[3].ToString()) ? 0 : float.Parse(datarow[3].ToString()),
                        Design = string.IsNullOrEmpty(datarow[4].ToString()) ? null : datarow[4].ToString()
                    };
                    employees.Add(employeeObj);
                }
            }
            return employees;
        }

        public List<Employee> GetAllEmployeesWhoseNameStartWithJ()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                if (datarow[1].ToString().StartsWith("J"))
                {
                    Employee employeeObj = new Employee

                    {
                        Dept = string.IsNullOrEmpty(datarow[0].ToString()) ? 0 : int.Parse(datarow[0].ToString()),
                        EmpName = string.IsNullOrEmpty(datarow[1].ToString()) ? null : datarow[1].ToString(),
                        Doj = string.IsNullOrEmpty(datarow[2].ToString()) ? DateTime.MinValue : Convert.ToDateTime(datarow[2].ToString()),
                        Salary = string.IsNullOrEmpty(datarow[3].ToString()) ? 0 : float.Parse(datarow[3].ToString()),
                        Design = string.IsNullOrEmpty(datarow[4].ToString()) ? null : datarow[4].ToString()
                    };
                    employees.Add(employeeObj);
                }

            }
            return employees;
        }
        public List<Employee> GetAllEmployeesWhoseNameHasOLetter()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                if (datarow[1].ToString().Substring(1, 2) == "oo")
                {
                    Employee employeeObj = new Employee
                    {
                        Dept = string.IsNullOrEmpty(datarow[0].ToString()) ? 0 : int.Parse(datarow[0].ToString()),
                        EmpName = string.IsNullOrEmpty(datarow[1].ToString()) ? null : datarow[1].ToString(),
                        Doj = string.IsNullOrEmpty(datarow[2].ToString()) ? DateTime.MinValue : Convert.ToDateTime(datarow[2].ToString()),
                        Salary = string.IsNullOrEmpty(datarow[3].ToString()) ? 0 : float.Parse(datarow[3].ToString()),
                        Design = string.IsNullOrEmpty(datarow[4].ToString()) ? null : datarow[4].ToString()
                    };
                    employees.Add(employeeObj);
                }

            }
            return employees;
        }

        public bool UpdateEmployeeSalary()
        {
            List<Employee> employees = new List<Employee>();
            Init();

            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Select("Salary<8000"))
            {
                datarow[3] = 9000;
            }
            commadBuilderObj = new SqlCommandBuilder(dataAdapterObj);
            int UpdatedStatus = dataAdapterObj.Update(dataSetObj);
            if (UpdatedStatus > 0)
                return true;
            else
                return false;
        }

        public List<Employee> GetAllEmployeesAverageDeptWise()
        {
            List<Employee> employees = new List<Employee>();
            Init();
            sqlCommandObj.CommandText = "select DepartmentId,AVG(Salary) from tblEmployee group by DepartmentId";

            dataAdapterObj = new SqlDataAdapter(sqlCommandObj);
            dataSetObj = new DataSet();
            dataAdapterObj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataAdapterObj.Fill(dataSetObj);
            DataTable dataTableObj = dataSetObj.Tables[0];
            foreach (DataRow datarow in dataTableObj.Rows)
            {
                Employee employeeObj = new Employee

                {
                    Dept = int.Parse(datarow[0].ToString()),
                    Salary = float.Parse(datarow[1].ToString()),

                };
                employees.Add(employeeObj);
            }
            return employees;
        }
    }
}
