using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueWith {
    internal class ContinuationOptions {

        public int MyProperty {
            get;
            set;
        }

        static int GetRandomNumber( int min, int max ) {
            if(min >= max) {
                throw new ArgumentException($"The {min} must be less than {max}");
            }

            Thread.Sleep(1000);
            return new Random().Next(min, max);
        }


        int GetInt( string message ) {
            int n = 0;
            while(true) {

            }
        }
    }
}
