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
            AIManager manager = new AIManager();
            manager.LoadAIDlls();
            manager.PrintAINamesAndDescriptions();

            Deck test = new Deck();
            Card card = test.DrawCard();

            Console.WriteLine("==================");
            Console.WriteLine("Playing Poker");
            Console.WriteLine("==================");
            Console.WriteLine("nahhh its not implemented yet :(");
            Console.WriteLine("");
            Console.WriteLine(card.ToString());
        }
    }
}
