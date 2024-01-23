using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegates.Pointers
{
    #region Not sure about that
    //class Temp
    //{
    //    public void DoSomething() { Console.WriteLine("Doing something"); }
    //    public void DoSomethingElse() { Console.WriteLine("Doing something else"); }
    //    public void DoSomethingWithAString(string myString) { }
    //    public bool GetANewCat(string name) { return true; }
    //}
    //internal class FunctionPointer_Bonus_
    //{
    //    public static void FunctionPointerMain(string[] args)
    //    {
    //        Temp temp = new Temp();

    //        Action myPointer = null, myPointer2 = null;
    //        myPointer = temp.DoSomething;
    //        myPointer2 = temp.DoSomethingElse;
    //        myPointer += temp.DoSomethingElse;
    //        myPointer();

    //        Action myPointer01 = temp.DoSomething, myPointer11 = temp.DoSomethingElse;

    //        myPointer01();
    //        myPointer11();
    //    }
    //} 
    #endregion
    unsafe class FunctionPointer
    {
        static void Example(Action<int> a, delegate*<int, void> f)
        {
            a(4);
            f(45);
        }
        public static void Check(int x)
        {
            Console.WriteLine("testing example {0}", x);
        }
        public static void Log()
        {
            Console.WriteLine("Log method without parameters");
        }
        public static void Log(int val)
        {
            Console.WriteLine("Log method with 1 int parameter with value of {0}.", val);
        }
        public static void Use()
        {
            delegate*<void> a1 = &Log;   //Points to Log
            delegate*<int, void> a2 = &Log; //Points to Log overloaded method

            a1();
            a2(103);
        }


        public static void FPMain(string[] args)
        {
            delegate*<int, void> a2 = &Check; //Points to Check() method

            Example((a) => { Console.WriteLine(a); }, a2);

            Use();

        }
    }
}
