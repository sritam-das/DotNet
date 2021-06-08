using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesDemo
{
    [AttributeUsage(AttributeTargets.All,Inherited =true,AllowMultiple =true)]
    class AuthorAttribute:Attribute
    {
        string name;
        int age;
        public AuthorAttribute(string n)
        {
            name = n;
        }
        public int Age { get; set; }
        //public string Name { get; set; }
    }
    /*create a custom attribute called CopyrightAttribute that has Company name and the 
      year as the members*/
}
