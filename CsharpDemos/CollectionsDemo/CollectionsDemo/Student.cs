using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }

        /*public int CompareTo(Student other)
        {
            return StudentId.CompareTo(other.StudentId);
        }

        public int CompareTo(object other)
        {
            
            return StudentId.CompareTo((Student)other.StudentId);
        }*/

        public override string ToString()
        {
            return "Student:Id-" + StudentId + "\tName-" +StudentName+ "\tCity-" + City;
        }
    }
}
