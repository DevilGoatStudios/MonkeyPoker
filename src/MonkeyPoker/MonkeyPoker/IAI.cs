using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker 
{
    // Generic Interface for all AIs
    public interface IAI
    {
        string Name { get; }

        // @param two cards (vector or whatnot)
        void ReceiveStartingHand(List<Card> cards);

        // @return action executé par l'AI
        Action TakeAction();
    }
}
