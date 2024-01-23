using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Publishers
{
    public static class Sound   //Publisher
    {
        public static event EventHandler soundCreated;

        public static void Explosion()
        {
            Console.WriteLine("Boom!");
            OnSoundCreated();
        }
        public static void DrumsPlaying()
        {
            Console.WriteLine("Drums playing!");
            OnSoundCreated();
        }
        static void OnSoundCreated()
        {
            soundCreated?.Invoke(null, EventArgs.Empty);
        }
    }
}
