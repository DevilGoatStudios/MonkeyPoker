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
        //More test commit
        string Name { get; }
        string GetDescription();
    }
}
