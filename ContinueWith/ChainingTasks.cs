using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueWith
{
    internal class ChainingTasks
    {
        public static void Chain()
        {

            Task<int> t1 = Task.Run(() => { return 5; });


            var t3 = t2.ContinueWith(t => t.Result * 3);

            t3.ContinueWith(t => Console.WriteLine(t.Result));

            Console.Read();
        }

        public static void BetterChain()
        {
            Task.Run(() => 5)
                .ContinueWith(t => t.Result * 2)
                .ContinueWith(t => { Console.WriteLine("2nd continue With"); return t.Result * 3; })
                .ContinueWith(t => Console.WriteLine($"This is the final result {t.Result}"));


        }

    }
}
