using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class Action
    {
        public int PlayerId { get; protected set; }

        public delegate void ActionHandler(Action action);
    }
}
