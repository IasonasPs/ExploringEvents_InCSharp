using System.Reflection;
using System;
using Delegates.Enums;
using System.Reflection.Metadata.Ecma335;
using Delegates.Pointers;
using Delegates.managers;
using System.Drawing;


namespace Delegates
{
    //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
    //Declaration
    public delegate void Writerdelegate(string text);
    //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

    internal class Program
    {
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }
        public static int Sum(int a, int b)
        { return a + b; }

        static void Main(string[] args)
        {
            #region FunctionPointer example
            //FunctionPointer.FPMain(args);
            #endregion <<------!

            #region Simplest delegate Instantiation and Invocation
            //Writerdelegate writerdelegate = new Writerdelegate(Write);
            //writerdelegate("Some text from wd"); 
            #endregion

            #region Simple Func Delegate
            //Func delegate Instantiation : 
            //Func < Type1, Type2..., ReturnType > DelegateName = new Func<Type1, Type2..., ReturnType>(MethodName)
            //Func <Type1,Type2....., ReturnType > DelegateName = MethodName;

            //Func<int, int, int> sumDelegate = Sum;
            //Console.WriteLine("A sum from 'sumDelegate'"+sumDelegate(12, 3));
            #endregion

            #region Simple Action Delegate
            //Action delegate Instantiation

            //Action < Type1, Type2...> DelegateName = new Action<Type1, Type2...>(MethodName);

            //Action < Type1, Type2...> DelegateNAme = MethodName;   

            //Action<string> writeActionDelegate = Write;

            //writeActionDelegate("Some text from writeActionDelegate");
            #endregion

            #region Operation managers
            //OperationManager op = new OperationManager(20, 10);

            //Console.WriteLine(op.Execute(Enums.Operation.Sum));
            //Console.WriteLine(op.Execute(Enums.Operation.Subtract));
            //Console.WriteLine(op.Execute(Enums.Operation.Multiply));
            //-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_

            //ExecutionManager executionManager = new ExecutionManager();

            //betterOperationManager betterOperationManager = new betterOperationManager(10,20,executionManager);

            //Console.WriteLine(  betterOperationManager.Execute(Operation.Sum));
            //Console.WriteLine(  betterOperationManager.Execute(Operation.Subtract));
            //Console.WriteLine(  betterOperationManager.Execute(Operation.Multiply)); 
            #endregion

            #region delegatesIntro
            //delegatesIntro.Action();
            //delegatesIntro.AnonymousMethod();
            //delegatesIntro.MulticastDelegate();
            #endregion

            //var x = 5;

            //bool control = x switch
            //{
            //    > 10 => true,
            //    < 23 => true,

            //};

            //value tuple
            var point = ( x: 1 ,y : 2);
            
            string quadrant = point switch
            {
                _ when point is { x:>0 ,y:>0}  => "Quadrant 1",
                //(x, y) when x < 0 && y > 0 => "Quadrant 2",
                //(x, y) when x < 0 && y < 0 => "Quadrant 3",
                //(x, y) when x > 0 && y < 0 => "Quadrant 4",
                _ => "On an axis"
            };
            
             (int x, int y) Test()
            {
                return (1,2);
            }
        
        
        }
        
    }
}