using System;
using System.Collections.Generic;
using System.Text;
using static Practice.CardType;

namespace Practice
{
   
    public class Card
    {
        protected Suit _suit;
        protected string _cardvalue;
        public Card()
        {
        }
        public Card(Suit Suit, string Cardvalue)
        {
            _suit = Suit;
            _cardvalue = Cardvalue;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}", _cardvalue, _suit);
        }

    }
}

