using MonkeyPoker.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    class AIManager
    {
        public Dictionary<int, IAI> ArtificialPlayers { get; private set; }

        private int mNextArtificialPlayerId;
        // This event is triggered when any type of action happen
        // Eg. The dealer flip a card or another player bet some money
        event MonkeyPoker.Action.ActionHandler ActionHappened;

        public AIManager()
        {
            ArtificialPlayers = new Dictionary<int, IAI>();
            mNextArtificialPlayerId = 0;
        }

        public void LoadAIDlls()
        {
            // Cleaning old list
            ArtificialPlayers.Clear();
            mNextArtificialPlayerId = 0;

            Console.WriteLine("==================");
            Console.WriteLine("Loading AI Dlls");
            Console.WriteLine("==================");
            string[] items = Directory.GetFiles(".", "*.dll");
            foreach (string item in items)
            {
                try
                {
                    IAI ai = LoadAssembly(item);
                    ArtificialPlayers.Add(mNextArtificialPlayerId, ai);
                    ++mNextArtificialPlayerId;
                    Console.WriteLine(item + " Loaded");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to load " + item);
                }
            }
            Console.WriteLine("");
        }

        public void PrintAINamesAndDescriptions()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Printing AIs");
            Console.WriteLine("==================");
            foreach (IAI ai in ArtificialPlayers.Values)
            {
                if (null != ai)
                {
                    Console.WriteLine("Name : " + ai.Name);
                    Console.WriteLine("");
                }
            }
        }

        private IAI LoadAssembly(string assemblyPath)
        {
            string assembly = Path.GetFullPath(assemblyPath);
            Assembly ptrAssembly = Assembly.LoadFile(assembly);

            foreach (Type item in ptrAssembly.GetTypes())
            {
                if (!item.IsClass) continue;
                if (item.GetInterfaces().Contains(typeof(IAI)))
                {
                    return (IAI)Activator.CreateInstance(item);
                }
            }
            throw new Exception("Invalid DLL, Interface not found!");
        }
    }
}
