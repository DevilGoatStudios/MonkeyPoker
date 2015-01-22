using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class Raise : Action
    {
        public int Value { get; set; }

        public Raise(int playerId) 
            : base()
        { 
            PlayerId = playerId; 
        }
    }
}
