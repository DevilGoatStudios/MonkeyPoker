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
        public List<IAI> ArtificialPlayers { get; private set; }

        private Dictionary<string, AppDomain> DLLList = new Dictionary<string, AppDomain>();

        public AIManager()
        {
            ArtificialPlayers = new List<IAI>();
        }

        public void LoadAIDlls()
        {
            // Cleaning old list
            ArtificialPlayers.Clear();

            Console.WriteLine("==================");
            Console.WriteLine("Loading AI Dlls");
            Console.WriteLine("==================");
            string[] items = Directory.GetFiles(".", "*.dll");
            foreach (string item in items)
            {
                try
                {
                    IAI ai = LoadAssembly(item);
                    ArtificialPlayers.Add(ai);
                    Console.WriteLine(item + " Loaded");
                }
                catch (Exception)
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
            foreach (IAI ai in ArtificialPlayers)
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
