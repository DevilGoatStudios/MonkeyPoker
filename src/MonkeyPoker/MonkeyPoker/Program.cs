using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    class Program
    {
        //Test commit
        static void Main(string[] args)
        {
            AIManager manager = new AIManager();
            manager.LoadAIDlls();
            manager.PrintAINamesAndDescriptions();

            Console.WriteLine("==================");
            Console.WriteLine("Playing Poker");
            Console.WriteLine("==================");
            Console.WriteLine("nahhh its not implemented yet :(");
            Console.WriteLine("");
        }
    }
}
