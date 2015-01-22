using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public interface IActionHandler
    {
        // This event is triggered when any type of action happen
        // Eg. The dealer flip a card or another player bet some money
        event MonkeyPoker.Action.ActionHandler ActionHappened;
    }
}
