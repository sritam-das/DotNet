using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary
            //write
            /*Person personObj = new Person
            {
                Age = 20,
                Name = "John",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };
            FileStream fileStreamObj = new FileStream(@"D:\Demo\PersonInfo.bin",
                FileMode.OpenOrCreate,FileAccess.Write);
            BinaryFormatter binaryFormatterObj = new BinaryFormatter();
            binaryFormatterObj.Serialize(fileStreamObj,personObj);
            fileStreamObj.Close();
            Console.WriteLine("Data is written to the file!!!");
            */
            /*FileStream fileStreamObj = new FileStream(@"D:\Demo\PersonInfo.bin",
                FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatterObj = new BinaryFormatter();
            Person personObj = null;
            personObj=(Person)binaryFormatterObj.Deserialize(fileStreamObj);
            fileStreamObj.Close();
            Console.WriteLine("Person's Info is:");
            Console.WriteLine("Name:{0}\tAge:{1}\tDoB:{2}\tAdditional Info:{3}",personObj.Name,personObj.Age,
                personObj.DOB,personObj.AdditionalInfo);*/
            //Xml
            /* XmlSerializer xmlSerializerObj = new XmlSerializer(typeof(Person));
             Person personObj = new Person
             {
                 Age = 20,
                 Name = "John",
                 DOB = DateTime.Now,
                 AdditionalInfo = "none"
             };
             FileStream fileStreamObj = new FileStream(@"D:\Demo\PersonInfo.xml",
                 FileMode.OpenOrCreate, FileAccess.Write);
             xmlSerializerObj.Serialize(fileStreamObj, personObj);
             fileStreamObj.Close();
             Console.WriteLine("Data is written to the file!!!");*/

           /* XmlSerializer xmlSerializerObj = new XmlSerializer(typeof(Person));
            FileStream fileStreamObj = new FileStream(@"D:\Demo\PersonInfo.xml",
                FileMode.Open, FileAccess.Read);
            Person personObj=(Person)xmlSerializerObj.Deserialize(fileStreamObj);
            fileStreamObj.Close();
            Console.WriteLine("Person's Info is:");
            Console.WriteLine("Name:{0}\tAge:{1}\tDoB:{2}\tAdditional Info:{3}", personObj.Name, personObj.Age,
                personObj.DOB, personObj.AdditionalInfo);*/

            /*
             Create a generic list of Person objects and perform serailization,deserialization using both
             Binary and Xml serialization classes
             */
        }
    }
}
