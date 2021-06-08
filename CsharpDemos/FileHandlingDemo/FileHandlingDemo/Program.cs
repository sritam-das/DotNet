using System;
using System.Collections.Generic;
using System.IO;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            //read
            /*FileStream fileStreamObj = new FileStream(@"D:\Demo\Sample.txt",
                FileMode.Open, FileAccess.Read);
            byte[] readBuffer = new byte[fileStreamObj.Length];
            int startPosition = 0;
            int bytesToRead = (int)fileStreamObj.Length;
            while (bytesToRead > 0)
            {
                int data = fileStreamObj.Read(readBuffer, startPosition, bytesToRead);
                if(data==0)
                {
                    break;
                }
                startPosition += data;
                bytesToRead -= data;
            }
            Console.WriteLine("Data from file:");
            foreach(byte charachter in readBuffer)
            {
                Console.Write((char)charachter);
            }
            Console.WriteLine("-----------------------------------");
            
            fileStreamObj.Close();

            //write
            FileStream fileStreamObj1 = new FileStream(@"D:\Demo\Sample1.txt",
                FileMode.OpenOrCreate, FileAccess.Write,FileShare.None);
            fileStreamObj1.Write(readBuffer, 0, readBuffer.Length);
            Console.WriteLine("Data is written to the file!!!");
            fileStreamObj1.Close();*/

            #endregion

            #region Character_IO
            //read
            /* StreamReader streamReaderObj = new StreamReader(@"D:\Demo\Sample.txt");
             string data = string.Empty;
             /* while((data=streamReaderObj.ReadLine())!=null)
               {
                   Console.WriteLine(data);
               }*/
            /*data=streamReaderObj.ReadToEnd();
            Console.WriteLine(data);
            streamReaderObj.Close();

            //write
            StreamWriter streamWriterObj = new StreamWriter(@"D:\Demo\Sample1.txt");
            streamWriterObj.WriteLine(data);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Data is written to the file!!!");
            streamWriterObj.Close();*/
            #endregion

            #region Binary_IO
            //write
            //FileStream fileStreamobj = new FileStream(@"D:\Demo\MyBinaryFile.bin",
            //    FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            /*BinaryWriter binaryWriterObj = new BinaryWriter(fileStreamobj);
            string name = "John Smith";
            int age = 23;
            double height = 5.7;
            bool isMarried = false;
            char gender = 'M';
            binaryWriterObj.Write(name);
            binaryWriterObj.Write(age);
            binaryWriterObj.Write(height);
            binaryWriterObj.Write(isMarried);
            binaryWriterObj.Write(gender);
            Console.WriteLine("Data is written to the file!!!");
            binaryWriterObj.Close();*/
            FileStream fileStreamobj = new FileStream(@"D:\Demo\MyBinaryFile.bin",
               FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BinaryReader binaryReaderObj = new BinaryReader(fileStreamobj);
            string name = binaryReaderObj.ReadString();
            int age = binaryReaderObj.ReadInt32();
            double height = binaryReaderObj.ReadDouble();
            bool isMarried = binaryReaderObj.ReadBoolean();
            char gender = binaryReaderObj.ReadChar();
            binaryReaderObj.Close();
            fileStreamobj.Close();
            Console.WriteLine("Data from file is:");
            Console.WriteLine("{0} is {1}yrs old {2} who is Married:{3} and has a height of {4}",
                name,age,gender,isMarried,height);

            #endregion
        }
    }
}
