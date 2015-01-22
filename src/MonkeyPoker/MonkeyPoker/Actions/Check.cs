using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class Check : Action
    {
        public Check(int playerId)
            : base()
        { 
            PlayerId = playerId; 
        }
    }
}
