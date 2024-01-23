using Introduction.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Publishers
{
    //We declare a delegate
    public delegate void Notify();
    
    public class Order //The class which raises events 
    {
        //We declare an event of delegate type Notify !
        public event Notify ProcessCompleted;
        //The Notify delegate specifies the signature for the ProcessCompleted event handler.
        //It specifies that the event handler method in subscriber class must have a void return
        //type and no parameters
        
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
