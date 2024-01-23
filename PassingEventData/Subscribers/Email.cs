using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingEventData.Subscribers
{
    internal class Email
    {
        public static void OnOrderCreation( object sender,(string s,bool b) t)
        {
            Console.WriteLine("Process successful : {0}",t.b);
            Console.WriteLine("Total ms : {0}",t.s);
        }
    }
}
