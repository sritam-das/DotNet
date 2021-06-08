using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsDemo
{
    public enum Gender
    {
        Male,Female
    }
    class Student
    {
        int StudentId;
        string StudentName;
        int StudentAge;
        Gender Gender;

        public void CreateStudent(int id, string name,int age, Gender gender)
        {
            StudentId = id;
            StudentName = name;
            StudentAge = age;
            Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine("**** Student Information ****");
            Console.WriteLine("Id:{0}\tName:{1}\tAge:{2}\tGender:",
                StudentId,StudentName,StudentAge,Gender);
        }
    }
}
