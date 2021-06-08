using System;
using PersonLibrary;

namespace ConceptsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Properties
            /*Student studentObj1 = new Student();
            studentObj1.CreateStudent(1, "John", 10, Gender.Male);
            studentObj1.Display();

            Student studentObj2 = new Student();
            studentObj2.CreateStudent(2, "Jeccinta", 15, Gender.Female);
            studentObj2.Display();*/
            /* Person personObj1 = new Person();
             //personObj1.CreatePerson(1, "John Smith", 23, "Melbourne");
             //personObj1.Display();
             personObj1.Ssn = 1;
             personObj1.Name = "John Smith";
             personObj1.Age = 20;
             personObj1.City = "California";
             Console.WriteLine("{0} stays in {1}",personObj1.Name,personObj1.City);
             Console.WriteLine(personObj1.Ssn);

             Person personObj2 = new Person();
             personObj2.Ssn = 2;
             personObj2.Name = "Jenna Smith";
             personObj2.Age = 10;
             personObj2.City = "California";
             Console.WriteLine("{0} is {1}yrs old", personObj2.Name, personObj2.Age);

             //object initializer
             Person personObj3 = new Person() {Ssn=3,Name="Mary Jane",Age=30,City="New Jersey" };
             Console.WriteLine("{0} stays in {1}", personObj3.Name, personObj3.City);*/
            #endregion

            Person personObj1 = new Person();
            personObj1.Display();
            Person personObj2 = new Person(1, 20, "John", "Pune");
            personObj2.Display();

        }
    }
}
