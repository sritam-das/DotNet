using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StoredProceduresDemo
{
    class Program
    {
        SqlConnection sqlConnectionObj;
        SqlCommand sqlCommandObj;
        SqlDataReader dataReaderObj;
        SqlDataAdapter dataAdapterObj;
        DataSet dataSetObj;

        public void Init()
        {
            sqlConnectionObj = new SqlConnection();
            sqlConnectionObj.ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeDBString"].ConnectionString;
            sqlConnectionObj.Open();
            sqlCommandObj = new SqlCommand();
            sqlCommandObj.Connection = sqlConnectionObj;
            sqlCommandObj.CommandType = CommandType.StoredProcedure;
            dataAdapterObj = new SqlDataAdapter();
            dataSetObj = new DataSet();
        }
        #region Connected Arc - SP
        public void GetAllEmployees()
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetAllEmployees";
                dataReaderObj = sqlCommandObj.ExecuteReader();
                Console.WriteLine("Employees Data:");
                Console.WriteLine("{0} |\t{1} |\t{2} |\t{3} |\t{4}",
                    dataReaderObj.GetName(0), dataReaderObj.GetName(1), dataReaderObj.GetName(2), dataReaderObj.GetName(4), dataReaderObj.GetName(6));
                while (dataReaderObj.Read())
                {
                    Console.WriteLine("EmployeeId: {0}\tName:{1}\tCity:{2}\tSalary:{3}\tContact{4}",
                        dataReaderObj["EmployeeId"], dataReaderObj["EmployeeName"], dataReaderObj["City"], dataReaderObj["Salary"], dataReaderObj["PhoneNo"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }

        public void GetEmployeeById(int id)
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeById";
                /*  SqlParameter sqlParameterObj;
                  sqlParameterObj = sqlCommandObj.Parameters.Add("@id", SqlDbType.Int);
                  sqlParameterObj.Value = id;*/
                sqlCommandObj.Parameters.AddWithValue("@id", id);
                dataReaderObj = sqlCommandObj.ExecuteReader();
                Console.WriteLine("Employees Data:");
                Console.WriteLine("{0} |\t{1} |\t{2} |\t{3} |\t{4}",
                    dataReaderObj.GetName(0), dataReaderObj.GetName(1), dataReaderObj.GetName(2), dataReaderObj.GetName(4), dataReaderObj.GetName(6));
                while (dataReaderObj.Read())
                {
                    Console.WriteLine("EmployeeId: {0}\tName:{1}\tCity:{2}\tSalary:{3}\tContact{4}",
                        dataReaderObj["EmployeeId"], dataReaderObj["EmployeeName"], dataReaderObj["City"], dataReaderObj["Salary"], dataReaderObj["PhoneNo"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }

        public void GetEmployeeByCity(string city)
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeByCity";
                /*  SqlParameter sqlParameterObj;
                  sqlParameterObj = sqlCommandObj.Parameters.Add("@id", SqlDbType.Int);
                  sqlParameterObj.Value = id;*/
                sqlCommandObj.Parameters.AddWithValue("@City", city);
                dataReaderObj = sqlCommandObj.ExecuteReader();
                Console.WriteLine("Employees Data:");
                while (dataReaderObj.Read())
                {
                    Console.WriteLine("EmployeeId: {0}\tName:{1}\tCity:{2}\tSalary:{3}\tContact{4}",
                        dataReaderObj[0], dataReaderObj[1], dataReaderObj[2], dataReaderObj[4], dataReaderObj[6]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }
        public void GetEmployeeCountByCity(string city)
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeCountByCity";
                SqlParameter sqlParameterObj;
                sqlParameterObj = sqlCommandObj.Parameters.Add("@count", SqlDbType.Int);
                sqlParameterObj.Direction = ParameterDirection.ReturnValue;
                sqlCommandObj.ExecuteNonQuery();
                sqlParameterObj = sqlCommandObj.Parameters["@count"];
                Console.WriteLine("Employee Count is {0}", sqlParameterObj.Value.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }

        public void GetEmployeeCount()
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeCount";
                SqlParameter sqlParameterObj;
                sqlParameterObj = sqlCommandObj.Parameters.Add("@count", SqlDbType.Int);
                sqlParameterObj.Direction = ParameterDirection.ReturnValue;
                sqlCommandObj.ExecuteNonQuery();
                sqlParameterObj = sqlCommandObj.Parameters["@count"];
                Console.WriteLine("Employee Count is {0}", sqlParameterObj.Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }


            /*
            Assignment Sp-3: create a function that takes the employeeId and displays
            the employee name,city and salary using the output parameters
            */

        public void GetAllEmployeeNameCitySalaryById(int id)
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeNameCitySalaryById";
                SqlParameter sqlParameterObj1 = new SqlParameter();
                sqlParameterObj1 = sqlCommandObj.Parameters.Add("@name", SqlDbType.VarChar, 20);
                sqlParameterObj1.Direction = ParameterDirection.Output;

                SqlParameter sqlParameterObj2 = new SqlParameter();
                sqlParameterObj2 = sqlCommandObj.Parameters.Add("@city", SqlDbType.VarChar, 20);
                sqlParameterObj2.Direction = ParameterDirection.Output;

                SqlParameter sqlParameterObj3 = new SqlParameter();
                sqlParameterObj3 = sqlCommandObj.Parameters.Add("@salary", SqlDbType.Decimal);
                sqlParameterObj3.Direction = ParameterDirection.Output;

                sqlCommandObj.Parameters.AddWithValue("@id", id);
                sqlCommandObj.ExecuteNonQuery();
                sqlParameterObj1 = sqlCommandObj.Parameters["@name"];
                sqlParameterObj2 = sqlCommandObj.Parameters["@city"];
                sqlParameterObj3 = sqlCommandObj.Parameters["@salary"];

                Console.WriteLine("name: " + sqlParameterObj1.Value.ToString() + " city: " + sqlParameterObj2.Value.ToString() +
                    " salary: " + sqlParameterObj3.Value.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }
        #endregion

        #region Disconnected Arc - SP
        public void DisplayEmployeeById(int id)
        {
            try
            {
                Init();
                sqlCommandObj.CommandText = "usp_GetEmployeeById";
                sqlCommandObj.Parameters.AddWithValue("@id", id);
                dataAdapterObj.SelectCommand = sqlCommandObj;
                dataAdapterObj.FillSchema(dataSetObj, SchemaType.Source, "tblEmployee");
                dataAdapterObj.Fill(dataSetObj, "tblEmployee");

                DataTable dataTableObj = dataSetObj.Tables["tblEmployee"];
                Console.WriteLine("Employees Data for {0}: ",id);
                foreach(DataRow dataRowObj in dataTableObj.Rows)
                {
                    Console.WriteLine("Id: {0}\tName: {1}\tCity: {2}",
                        dataRowObj[0],dataRowObj[1],dataRowObj[2]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnectionObj.Close();
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Program programObj = new Program();
            programObj.GetAllEmployees();
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            programObj.GetEmployeeById(1014);
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            programObj.GetEmployeeCountByCity("Munich");
            programObj.GetEmployeeCount();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            programObj.GetEmployeeByCity("California");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            programObj.GetAllEmployeeNameCitySalaryById(1001);
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
            programObj.DisplayEmployeeById(1005);

        }
    }
}
