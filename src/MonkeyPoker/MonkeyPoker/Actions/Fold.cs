using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class Fold : Action
    {
        public Fold(int playerId)
            : base()
        { 
            PlayerId = playerId; 
        }
    }
}
