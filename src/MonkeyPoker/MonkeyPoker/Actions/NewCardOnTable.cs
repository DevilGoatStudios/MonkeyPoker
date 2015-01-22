using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class NewCardOnTable : Action
    {
        public List<Card> NewCard { get; set; }

        public NewCardOnTable(int playerId)
            : base()
        { 
            PlayerId = playerId; 
        }
    }
}
