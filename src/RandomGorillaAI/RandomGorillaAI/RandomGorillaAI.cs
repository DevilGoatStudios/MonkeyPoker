using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGorillaAI
{
    public class RandomGorillaAI : MonkeyPoker.IAI
    {
        public string Name
        {
            get { return "RandomGorillaAI"; }
        }

        public string GetDescription()
        {
            return "Have you ever wanted more randomness in your life? This gorilla is just what you needed all allong! Disclaimer : We cannot guarantee its capacity to play Poker";
        }
    }
}
