using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck();
            var r = new Random();

            var cr = mydeck.Cards.Select(c => c.ToString()).Where(c => c != null).ToArray();
            var shuffle = cr.OrderBy(card => r.Next());
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine("Coding test");

        }
    }
}
