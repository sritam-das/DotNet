using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            FileStream fileStreamObj = 
                new FileStream(@"D:\Demo\Sample.txt",FileMode.Open,FileAccess.Read);
            byte[] readText = new byte[fileStreamObj.Length];
            int startPosition = 0;
            int numOfBytesToBeRead = (int)fileStreamObj.Length;
            while(numOfBytesToBeRead>0>0)
            fileStreamObj.Read(readText, startPosition, numOfBytesToBeRead);
            #endregion
        }
    }
}
