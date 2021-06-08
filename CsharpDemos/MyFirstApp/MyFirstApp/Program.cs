using System;
using System.Text;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Types
            /*
            //value type
            int intVar;
            intVar = 10;
            double doubleVar = 10.345;
            bool boolVar = true;
            //reference type
            string stringVar = "Hello";
            object objectVar = "Hello World!!!";
            objectVar = 10;
            objectVar = true;
            long someVariable = 20;
            someVariable = intVar;
            intVar = (int)someVariable;

            int i = 10;
            object o;
            o = i;//boxing
            i = (int)o;//unboxing

            string myFirstString = "First";
            myFirstString += " Name";
        
            string path = @"D:\Demo\Text.txt";
            StringBuilder stringBuilderobj = new StringBuilder("Hello");
            stringBuilderobj.Append(" World!!");
            Console.WriteLine("String builder oobject is:"+stringBuilderobj);

            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Integer value is:"+intVar);
            Console.WriteLine("String value is:" + stringVar);
            Console.WriteLine("Double value is:" + doubleVar);
            Console.WriteLine("Boolean value is:" + boolVar);
            Console.WriteLine("Size of integer:"+sizeof(double));
            Console.ReadKey();*/
            #endregion

            #region String_DateTime

            /*string someQuote = "And I think to myself, what a wonderful world!!!";
                    Console.WriteLine(someQuote.ToLower());
                    Console.WriteLine(someQuote.ToUpper());
                    Console.WriteLine(someQuote.Length);
                    Console.WriteLine(someQuote.IndexOf("myself"));
                    Console.WriteLine(someQuote.Contains("Think"));
                    string[] strings=someQuote.Split(',');
                    Console.WriteLine(strings.Length);
                    char[] chars=someQuote.ToCharArray();
                    Console.WriteLine(chars.Length);*/
            /* DateTime dateTimeObj = new DateTime();
             dateTimeObj = DateTime.Now;
             dateTimeObj = new DateTime(2021, 05, 23,12,23,34);
             Console.WriteLine(dateTimeObj.ToLongDateString());
             Console.WriteLine(dateTimeObj.ToString("F"));*/
            #endregion

            int? a = 10;
            a = null;
            Nullable<double> b = null;
            b = 23.34;

            var stringVar = "Hello All";
            Console.WriteLine(stringVar.GetType());
            var num1 = 10;
            Console.WriteLine(num1.GetType());
            num1 = 23;
            var num2=23.34;
            

        }
    }
}
