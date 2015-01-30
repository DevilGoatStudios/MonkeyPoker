using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class Player
    {
        public int ID { get; set; }
        public List<Card> Hand { get; set; }
        public int Stack { get; set; }
        public IAI Ai { get; set; }
    }
}
