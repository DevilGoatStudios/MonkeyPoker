using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class Deck
    {
        private List<Card> mDeck;

        public Deck()
        {
            mDeck = new List<Card>();

            foreach (Card.Suit suit in (Card.Suit[]) Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in (Card.Rank[]) Enum.GetValues(typeof(Card.Rank)))
                {
                    mDeck.Add(new Card(rank, suit));
                }
            }
        }
    }
}
