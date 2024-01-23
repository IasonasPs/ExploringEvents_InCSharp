using PassingEventData.Publishers;
using PassingEventData.Subscribers;
using System.Diagnostics;

namespace PassingEventData
{
    internal class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("Hello, World!");
            Order order = new Order();
            order.ProcessCompleted += Email.OnOrderCreation;

            Stopwatch stopwatch = Stopwatch.StartNew(); 
            order.StartProcess(stopwatch);
        }
    }
}