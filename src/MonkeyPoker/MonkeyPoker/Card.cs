using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class Card
    {
        public enum Rank
        {
            [Description("A")]
            Ace = 1,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six,
            [Description("7")]
            Seven,
            [Description("8")]
            Eight,
            [Description("9")]
            Nine,
            [Description("0")]
            Ten,
            [Description("J")]
            Jack,
            [Description("Q")]
            Queen,
            [Description("K")]
            King
        }

        public enum Suit
        {
            [Description("d")]
            Diamonds,
            [Description("h")]
            Hearts,
            [Description("c")]
            Clubs,
            [Description("s")]
            Spades
        }

        public Rank CardRank { get; private set; }
        public Suit CardSuit { get; private set; }

        Card(Rank rank, Suit suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }

        public override string ToString()
        {
            return CardRank.ToString() + CardSuit.ToString();
        }
    }
}
