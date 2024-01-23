using Introduction.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Publishers
{
    //The class which raises events 

    public delegate void Notify();


    public delegate void MyEventHandler(object sender, EventArgs e);
    public class Order
    {
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process started");
            Thread.Sleep(3000);
            OnProcessComplete(); 
        }
        protected virtual void OnProcessComplete()
        {
            ProcessCompleted?.Invoke(); // Here the event is triggered
        }
    }
}
