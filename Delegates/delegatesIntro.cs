using System.ComponentModel.Design;

namespace Delegates
{
    internal static class delegatesIntro
    {
        delegate int myD(int x, int y);

        public delegate void Print(string text);

        #region Operations
        public static int Add(int x, int y)
        {
            Console.WriteLine("Sum : {0}", x + y);
            return x + y;
        }
        public static int Mult(int x, int y)
        {
            Console.WriteLine("Product : {0}", x * y);
            return x * y;
        }
        public static int Subtract(int x, int y)
        {
            Console.WriteLine("Diff : {0}", x - y);
            return x + y;
        } 
        public static int ErrorMethod(int x, int y)
        {
            throw new Exception("Error");
        }
        
        #endregion

        public static void Action()
        {
            List<string> list = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
            };


            list.ForEach(delegate (string name)
            {
                Console.WriteLine(name);
            });
        }
        public static void AnonymousMethod()
        {
            #region anonymous method {aka inline delegate}:
            //useful when the user wants to create an inline method
            //and also wants to pass parameter in the anonymous method like other methods.

            Print print = delegate (string someText)
            {
                Console.WriteLine("This is a text : {0} ,('from an anonymous function')", someText);
            };

            //print("sometext"); 
            #endregion
        }
        public static void MulticastDelegate()
        {
            #region Multicast delegate
            myD myD = new myD(delegatesIntro.Mult);
            myD += Mult;
            myD += Subtract;

            Console.WriteLine("- - - - - - - - - - - - - - - - - - \n" + "MyD : {0} ",myD(2,3)+ "\n- - - - - - - - - - - - - - - - - - ");

            #region using getInvocationList() on delegate's instance to catch a possible error
            //myD testDelegate = new myD(ErrorMethod);
            //testDelegate += Add;

            //Delegate[] delegates = testDelegate.GetInvocationList();

            //foreach (myD item in delegates)
            //{
            //    try
            //    {
            //        item(0, 2);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error caught");
            //    }
            //} 
            #endregion

            #endregion
        }
    }
}