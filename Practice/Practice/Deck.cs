using System;
using System.Collections.Generic;
using System.Text;
using static Practice.CardType;

namespace Practice
{
    public class Deck
    {
        public int TotalCards { get; }
        readonly string[] numbers = new string[] { "2", "3", "4", "5", "6" };
        public Deck()
        {
            TotalCards = 52;
            Cards = new List<Card>(TotalCards);

            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (var v in numbers)
                {
                    Card c = new Card(s,v);
                    Cards.Add(c);
                }
            }
        }
        public List<Card> Cards { get; }
    }
}
