using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int MgrID { get; set; }
        public int? DeptID { get; set; }
        public double Salary { get; set; }
        public long? Phno { get; set; }
    }
}
