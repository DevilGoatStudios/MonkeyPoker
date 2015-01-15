using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Poker_Game_Classes
{
    class Hand
    {
        public Card[] cards;

        public Hand(Card card1, Card card2, Card card3, Card card4, Card card5)
        {
            cards = new Card[5] {card1, card2, card3, card4, card5};
        }
    }
}
