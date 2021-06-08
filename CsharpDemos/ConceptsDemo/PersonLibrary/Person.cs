using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Person
    {
        #region Properties
        /*        int ssn, age;
                string name,city;

                public int Ssn  //readonly property
                {
                    get
                    {
                        return ssn;
                    }
                    //set
                    //{
                    //    ssn = value;
                    //}
                }
                public int Age
                {
                    get
                    {
                        return age;
                    }
                    set
                    {
                        if (value > 18)
                            age = value;
                        else
                            age = 18;
                    }
                }
                public string Name
                {
                    get
                    {
                        return name;
                    }
                    set
                    {
                        name = value;
                    }
                }

                public string City  //writeonly property
                {
                    //get
                    //{
                    //    return city;
                    //}
                    set
                    {
                        city = value;
                    }
                }

                /*public void CreatePerson(int id, string name, int age, string city)
                {
                    SSN = id;
                    Age = age;
                    Name = name;
                    City = city;
                }

                public void Display()
                {
                    Console.WriteLine("**** Person Information ****");
                    Console.WriteLine("SSN:{0}\tName:{1}\tAge:{2}\tCity:",
                        SSN, Name, Age, City);
                }*/
        #endregion

        //auto implemented properties
        //public int Ssn { get; set; }
        //public int Age { get; set; }
        //public string Name { get; set; }
        //public string City { get; set; }

        private int ssn, age;
        private string name, city;

        public Person()
        {
            ssn = age = 0;
            name = city = "None";
        }

        public Person(int id, int age,string name,string city)
        {
            ssn = id;
            this.age = age;
            this.name = name;
            this.city = city;
        }

        public void Display()
        {
            Console.WriteLine("**** Person Information ****");
            Console.WriteLine("SSN:{0}\tName:{1}\tAge:{2}\tCity:{3}",
                ssn, name, age, city);
        }

        ~Person()
        {
            Console.WriteLine("Destructor called!!!");
        }

    }
}
