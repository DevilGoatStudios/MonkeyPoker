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
        Ace,
    }

    class Card
    {
        public CardSuit suit;
        public CardRank rank;
        public string code;

        public Card(CardSuit cardSuit, CardRank cardRank)
        {
            suit = cardSuit;
            rank = cardRank;
            code = getCardCode(suit, rank);
        }

        // Needed to use PokerSource hand evaluator
        private string getCardCode(CardSuit cardSuit, CardRank cardRank) 
        {
            string suitCode;
            string rankCode;
            string cardCode;

            switch (cardRank)
            {
                case CardRank.Two:
                    rankCode = @"2";
                    break;
                case CardRank.Three:
                    rankCode = @"3";
                    break;
                case CardRank.Four:
                    rankCode = @"4";
                    break;
                case CardRank.Five:
                    rankCode = @"5";
                    break;
                case CardRank.Six:
                    rankCode = @"6";
                    break;
                case CardRank.Seven:
                    rankCode = @"7";
                    break;
                case CardRank.Height:
                    rankCode = @"8";
                    break;
                case CardRank.Nine:
                    rankCode = @"9";
                    break;
                case CardRank.Ten:
                    rankCode = @"T";
                    break;
                case CardRank.Jack:
                    rankCode = @"J";
                    break;
                case CardRank.Queen:
                    rankCode = @"Q";
                    break;
                case CardRank.King:
                    rankCode = @"K";
                    break;
                case CardRank.Ace:
                    rankCode = @"A";
                    break;

                // TODO : Change for error exception
                default:
                    rankCode = @"A";
                    break;
            }

            switch (cardSuit)
            {
                case CardSuit.Clubs:
                    suitCode = @"c";
                    break;
                case CardSuit.Hearts:
                    suitCode = @"h";
                    break;
                case CardSuit.Spades:
                    suitCode = @"s";
                    break;
                case CardSuit.Diamonds:
                    suitCode = @"d";
                    break;

                // TODO : Change for error exception
                default:
                    suitCode = @"c";
                    break;
            }

            cardCode = string.Concat(rankCode, suitCode);

            return cardCode;
        }
    }
}
