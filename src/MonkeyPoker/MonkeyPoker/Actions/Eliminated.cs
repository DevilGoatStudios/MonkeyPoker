using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class Eliminated : Action
    {
        public Eliminated(int playerId)
            : base()
        { 
            PlayerId = playerId; 
        }
    }
}
