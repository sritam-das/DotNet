using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("Nos. printed from PrintNumbers are:");
            lock (this)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine("Printed No is:" + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }


    class Program
    {
        
        static void PrintEvenNumbers()
        {
            Thread.CurrentThread.Name = "Even Thread";
            Console.WriteLine("Nos. printed from PrintEvenNumbers are:");
            for (int i = 1; i <= 10; i++)
            {
                if(i%2==0)
                    Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(Thread.CurrentThread.Name+":"+Thread.CurrentThread.Priority);
        }
        static void PrintOddNumbers()
        {
            Thread.CurrentThread.Name = "Odd Thread";
            Console.WriteLine("Nos. printed from PrintOddNumbers are:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(Thread.CurrentThread.Name + ":" + Thread.CurrentThread.Priority);
            Console.WriteLine("Thread Name:"+Thread.CurrentThread.Name);
        }

        static void Main(string[] args)
        {
            /*ThreadStart threadStartObj = PrintNumbers;
            Thread workerThread = new Thread(threadStartObj);
            workerThread.Start();
            workerThread.Priority = ThreadPriority.Highest;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nos. printed from Main method are:");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------");*/
            /*Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Priority);
            ThreadStart threadStartObj1 = PrintOddNumbers;
            Thread workerThread1 = new Thread(threadStartObj1);
            workerThread1.Priority = ThreadPriority.AboveNormal;
            
            ThreadStart threadStartObj2 = PrintEvenNumbers;
            Thread workerThread2 = new Thread(threadStartObj2);

            workerThread1.Start();
            workerThread2.Start();*/

            Printer p = new Printer();
            ThreadStart threadStartObj1 = p.PrintNumbers;
            Thread workerThread1 = new Thread(threadStartObj1);
            workerThread1.Priority = ThreadPriority.AboveNormal;

            ThreadStart threadStartObj2 = p.PrintNumbers;
            Thread workerThread2 = new Thread(threadStartObj2);

            workerThread1.Start();
            workerThread2.Start();

        }
    }
}
