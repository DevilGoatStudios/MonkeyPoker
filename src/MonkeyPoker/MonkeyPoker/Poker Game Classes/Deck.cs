using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Poker_Game_Classes
{
    class Deck
    {
        private List<Card> cardList;
        private Random randomGenerator;

        public Deck()
        {
            cardList = new List<Card>();
            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Card card = new Card(suit, rank);
                    cardList.Add(card);
                }
            }

            randomGenerator = new Random();
        }

        public Card GetRandomCardFromDeck()
        {
            int randomCardIndex = randomGenerator.Next(cardList.Count);
            Card randomCard = cardList[randomCardIndex];
            cardList.RemoveAt(randomCardIndex);

            return randomCard;
        }
    }
}
