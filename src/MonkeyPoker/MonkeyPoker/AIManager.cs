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
        public AIManager()
        {
            AIs = new List<IAI>();
        }

        public void LoadAIDlls()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Loading AI Dlls");
            Console.WriteLine("==================");
            string[] items = Directory.GetFiles(".", "*.dll");
            foreach (string item in items)
            {
                try
                {
                    IAI ai = LoadAssembly(item);
                    AIs.Add(ai);
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
            foreach (IAI ai in AIs)
            {
                if (null != ai)
                {
                    Console.WriteLine("Name : " + ai.Name);
                    Console.WriteLine("");
                }
            }
        }

        private List<IAI> AIs;
        private Dictionary<string, AppDomain> DLLList = new Dictionary<string, AppDomain>();

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

