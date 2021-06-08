using System;
using System.Collections;


namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //arraylist
            /* ArrayList arrayListObj = new ArrayList();
             arrayListObj.Add(10);
             arrayListObj.Add(20.34);
             arrayListObj.Add("Hello World");
             arrayListObj.Add('D');
             arrayListObj.Add(true);
             arrayListObj.Add(new Student { StudentId = 10, StudentName = "Mark Thompson", City = "Barcelona" });
             Console.WriteLine("No. of elements in arraylist:"+arrayListObj.Count);
             Console.WriteLine("Capacity of arraylist:"+arrayListObj.Capacity);
             arrayListObj.Add(4.5f);
             arrayListObj.Add(33.3m);
             arrayListObj.Add("Johnson Mozart");
             Console.WriteLine("No. of elements in arraylist:" + arrayListObj.Count);
             Console.WriteLine("Capacity of arraylist:" + arrayListObj.Capacity);
             Console.WriteLine("--------------------------------------------------------");
             Console.WriteLine("Elements in arraylist:");
             foreach(object element in arrayListObj)
             {
                 Console.WriteLine(element);
             }
             Console.WriteLine("--------------------------------------------------------");
             arrayListObj.Remove(4.5f);
             Console.WriteLine("After remove:");
             Console.WriteLine("Elements in arraylist:");
             Console.WriteLine("No. of elements in arraylist:" + arrayListObj.Count);
             foreach (object element in arrayListObj)
             {
                 Console.WriteLine(element);
             }
             arrayListObj.RemoveRange(3, 2);
             Console.WriteLine("--------------------------------------------------------");
             Console.WriteLine("After remove:");
             Console.WriteLine("Elements in arraylist:");
             Console.WriteLine("No. of elements in arraylist:" + arrayListObj.Count);
             foreach (object element in arrayListObj)
             {
                 Console.WriteLine(element);
             }
             Console.WriteLine( arrayListObj.Contains(34.3m) );
             Console.WriteLine(arrayListObj.IndexOf(33.3m));
             */
            #endregion

            #region Hashtable
            /*Hashtable hashtableObj = new Hashtable();
            hashtableObj.Add(1, "C#");
            hashtableObj.Add(2, "Java");
            hashtableObj.Add(3, "Perl");
            hashtableObj.Add(10, "Python");
            hashtableObj.Add(9, "Javascript");
            hashtableObj.Add(14, "Visual Basic");
            hashtableObj.Add(21, "C");
            hashtableObj.Add(11, "C++");
            /*Console.WriteLine("Keys from hashtable:");
            foreach(object key in hashtableObj.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Values from hashtable:");
            foreach (object value in hashtableObj.Values)
            {
                Console.WriteLine(value);
            }*/
            /*foreach(DictionaryEntry entry in hashtableObj)
            {
                Console.WriteLine("Key:{0}\tValue:{1}",entry.Key,entry.Value);
            }
            */
            #endregion

            #region Sortedlist
            /*SortedList sortedListobj = new SortedList();
            sortedListobj.Add("001", "Pune");
            sortedListobj.Add("002", "Gandhinagar");
            sortedListobj.Add("006", "Hyderabad");
            sortedListobj.Add("004", "Chennai");
            sortedListobj.Add("019", "Delhi");
            sortedListobj.Add("051", "Noida");
            sortedListobj.Add("003", "Jamshedpur");
            sortedListobj.Add("009", "Srinagar");
            Console.WriteLine("Elements in sortedlist:");
            foreach(DictionaryEntry entry in sortedListobj)
            {
                Console.WriteLine("Key:{0}\t\tValues:{1}",entry.Key,entry.Value);
            }
            */
            #endregion

            #region Queue_Stack
            /*Queue queueObj = new Queue();
            queueObj.Enqueue(10);
            queueObj.Enqueue("Hello");
            queueObj.Enqueue(29.77);
            queueObj.Enqueue(true);
            Console.WriteLine("Elements in queue:");
            foreach(object element in queueObj)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Count:" + queueObj.Count);
            Console.WriteLine(  "Element at the beginning:"+queueObj.Peek());
            Console.WriteLine("Removed element is:"+queueObj.Dequeue());
            Console.WriteLine("Count:" + queueObj.Count);
            Console.WriteLine("Element at the beginning:" + queueObj.Peek());*/

            Stack stackObj = new Stack();
            stackObj.Push(10);
            stackObj.Push("Hello");
            stackObj.Push(29.77);
            stackObj.Push(true);
            Console.WriteLine("Elements in stack:");
            foreach (object element in stackObj)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Count:" + stackObj.Count);
            Console.WriteLine("Element at the top:" + stackObj.Peek());
            Console.WriteLine("Removed element is:" + stackObj.Pop());
            Console.WriteLine("Count:" + stackObj.Count);
            Console.WriteLine("Element at the top:" + stackObj.Peek());
            #endregion
        }
    }
}
