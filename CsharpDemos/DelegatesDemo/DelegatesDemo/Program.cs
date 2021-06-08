using System;
namespace DelegatesDemo
{
    public delegate string GreetingDelegate(string name);
    public delegate void ProgramDelegate(int num1, int num2);
    public delegate void StringDelegate(string name);
    class Program
    {
        public event StringDelegate DisplayEvent;
        public string Greet(string name)
        {
            return "Hello " + name;
        }

        public static string sayHello(string name)
        {
            return "Hello " + name+" , from sayHello";
        }



        //public static void InvokeDelegate(ProgramDelegate del)
        //{
        //    //Console.WriteLine("Result:"+del(10, 10)) ;
        //}
        static void Main(string[] args)
        {
            #region single_cast
            //single-cast delegate
            //Program programObj = new Program();
            /*GreetingDelegate greetingDelegateObj = new GreetingDelegate(programObj.Greet);
            GreetingDelegate greetingDelegateObj1 = new GreetingDelegate(Program.sayHello);
            Console.WriteLine(greetingDelegateObj("john"));
            Console.WriteLine(greetingDelegateObj1("jannet"));*/

            //ProgramDelegate programDelegateObj = new ProgramDelegate(programObj.AddNumbers);
            // Console.WriteLine("Addition is:"+programDelegateObj.Invoke(10,20));
            //ProgramDelegate programDelegateObj1 = new ProgramDelegate(Program.MultiplyNumbers);
            /*Console.WriteLine("Multiplication is:" + programDelegateObj1.Invoke(2, 2));*/
            //Program.InvokeDelegate(programDelegateObj1);

            //assignment: Pass greet method as parameter and execute the same as callback
            #endregion

            #region multicast
            //one delegate instance with multiple functions
            /*Add_Mult add_Multobj = new Add_Mult();
            Div_Sub div_Subobj = new Div_Sub();
            ProgramDelegate programDelegateObj = new ProgramDelegate(add_Multobj.AddNumbers);
            programDelegateObj += Add_Mult.MultiplyNumbers;
            programDelegateObj(30,20);

            ProgramDelegate programDelegateObj1 = new ProgramDelegate(div_Subobj.SubtractNumbers);
            programDelegateObj1 += Div_Sub.DivideNumbers;
            programDelegateObj1(30, 2);*/

            /*StringDelegate stringDelegateObj = new StringDelegate(Add_Mult.HelloMsgFromAdd_Mult);
            StringDelegate stringDelegateObj1 = new StringDelegate(Div_Sub.HelloMsgFromDiv_Sub);
            StringDelegate stringDelegate = stringDelegateObj + stringDelegateObj1;
            stringDelegate("Hello All");
            Console.WriteLine("------------------------------------");
            stringDelegate = stringDelegateObj1 - stringDelegateObj;
            stringDelegate("Hello World!!!");*/
            #endregion

            #region Events
            Program programObj = new Program();
            StringDelegate stringDelegateObj = new StringDelegate(Add_Mult.HelloMsgFromAdd_Mult);
            StringDelegate stringDelegateObj1 = new StringDelegate(Div_Sub.HelloMsgFromDiv_Sub);
            //register the delegate with the event
            programObj.DisplayEvent += stringDelegateObj;
            programObj.DisplayEvent += stringDelegateObj1;
            //fire the event
            programObj.DisplayEvent("Hello All");

            //assignment: create an event which fires to execute all the methods i.e. addnumbers,
            //subtractnumbers, multiplynumbers and dividenumbers
            #endregion
        }
    }
}
