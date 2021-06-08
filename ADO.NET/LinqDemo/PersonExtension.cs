using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class PersonExtension
    {
        public static Person[] where(Person[] people, FindPeople del)
        {
            int i = 0;
            Person[] teenagers = new Person[people.Length];
            foreach(Person personObj in people)
            {
                if(del(personObj))
                {
                    teenagers[i] = personObj;
                    i++;
                }
            }
            return teenagers;
        }
    }
}
