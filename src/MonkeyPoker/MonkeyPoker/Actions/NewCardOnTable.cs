using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker.Actions
{
    public class NewCardOnTable : Action
    {
        public Card NewCard { get; set; }

        public NewCardOnTable()
            : base()
        { 
            PlayerId = -1; 
        }
    }
}
