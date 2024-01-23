using Observer_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern
{
    internal class Subject : ISubject
    {
        public int State { get; set; } = 0;

        //List of  Subscribers : 
        private List<IObserver> _observers = new List<IObserver>();



        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
            Console.WriteLine($"Observer named {(observer as ConcreteObserver).Name} attached");
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine($"Observer named {(observer as ConcreteObserver).Name} detached");
        }

        //trigger an observer in each subscriber
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ChangeState()
        {
            this.State = new Random().Next(1,100);
            this.Notify();
        }
    }
}
