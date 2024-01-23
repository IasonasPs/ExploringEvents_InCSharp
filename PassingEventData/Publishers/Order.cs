using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingEventData.Publishers
{
    public class Order
    {
        public event EventHandler<(string s,bool b)> ProcessCompleted;
        private  Stopwatch? _StopWatch;

        public void StartProcess(Stopwatch watch)
        {
            _StopWatch = watch;
            _StopWatch.Start();
            try
            {
                Console.WriteLine("ProcessStarted");
                OnProcessCompleted(true);
            }
            catch (Exception)
            {
                OnProcessCompleted(false);
            }
        }
        public virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, (_StopWatch.Elapsed.TotalMicroseconds.ToString() ,IsSuccessful));
        }

    }
}
