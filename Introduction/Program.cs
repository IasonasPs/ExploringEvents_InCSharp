using Introduction.Publishers;
using Introduction.Subscribers;
using System.Threading.Channels;

namespace Introduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥
            Order order = new Order();
            order.ProcessCompleted += Email.Send; //register with an event
            order.StartProcess();
            //♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Ear ear = new Ear();
            Sound.soundCreated += ear.Hear; //register with an event
            Sound.Explosion();
            Console.WriteLine(".......Silence........");
            Sound.DrumsPlaying();
            //♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥♣♠♦♥
        }
    }
}