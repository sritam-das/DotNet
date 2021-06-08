using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum MonthsOfYear
    {
        January,Februray,March,April,May,June,July,August,September,October,November,December
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Values in enum:");
            foreach(int value in Enum.GetValues(typeof(MonthsOfYear)))
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enum constants are:");
            Console.WriteLine("Values in enum:");
            foreach (string value in Enum.GetNames(typeof(MonthsOfYear)))
            {
                Console.WriteLine(value);
            }

            string JohnBirthMonth = MonthsOfYear.December.ToString();
            Console.WriteLine("john's birth month:"+JohnBirthMonth);
        }
    }
}
