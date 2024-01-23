using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Subscribers
{
    public class Ear
    {
        public void Hear(object some,EventArgs e)
        {
            Console.WriteLine("I heared something!");
        }
    }
}
