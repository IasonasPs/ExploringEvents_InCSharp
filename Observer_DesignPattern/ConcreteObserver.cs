using Observer_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern
{


    //Concrete Observers react to the updates issued by the subject(Publisher) they had subscribed to.
    internal class ConcreteObserver : IObserver
    {
        internal string Name { get; set; }
        public string Address;
        public ConcreteObserver(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Updating State of subject");
            Console.WriteLine("New Subject State is :{0}",(subject as Subject).State);
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        }
    }
}
