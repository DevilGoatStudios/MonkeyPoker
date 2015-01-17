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
        private Random mRandomGenerator;
        private int mCardsInDeck;

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

            mCardsInDeck = mDeck.Count;
            mRandomGenerator = new Random();
        }

        public Card DrawCard()
        {
            int index = mRandomGenerator.Next(mCardsInDeck);
            Card card = mDeck[index];
            --mCardsInDeck;
            Card temp = mDeck[index];
            mDeck[index] = mDeck[mCardsInDeck];
            mDeck[mCardsInDeck] = temp;
            return card;
        }

        /// <summary>
        /// Reset the deck
        /// </summary>
        public void Shuffle()
        {
            mCardsInDeck = mDeck.Count;
        }
    }
}
