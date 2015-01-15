using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Poker_Game_Classes
{
    public enum CardSuit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }

    public enum CardRank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Height,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    class Card
    {
        public CardSuit suit;
        public CardRank rank;

        public Card(CardSuit cardSuit, CardRank cardRank)
        {
            suit = cardSuit;
            rank = cardRank;
        }
    }
}
