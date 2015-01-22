using MonkeyPoker.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager manager = new GameManager();

            manager.PlayGame();

            /*
            Deck test = new Deck();
            Card card = test.DrawCard();

            string pocket = test.DrawCard().ToString() + " " + test.DrawCard().ToString();
            string board = test.DrawCard().ToString() + " " + test.DrawCard().ToString() + " " + test.DrawCard().ToString() + " " + test.DrawCard().ToString() + " " + test.DrawCard().ToString();

            Console.WriteLine("pocket : " + pocket);
            Console.WriteLine("board : " + board);

            HoldemHand.Hand hand = new HoldemHand.Hand(pocket, board);
            uint handVal = hand.HandValue;
            Console.WriteLine("hand.handVal : " + handVal);
            Console.WriteLine("hand.Description : " + hand.Description);*/
        }
    }
}
