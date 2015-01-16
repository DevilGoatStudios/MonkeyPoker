using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGorillaAI
{
    public class RandomGorillaAI : MonkeyPoker.IAI
    {
        //public event EventHandler ActionHappened;

        public string Name
        {
            get { return "RandomGorillaAI"; }
        }

        public RandomGorillaAI()
        {
        }

        public void ReceiveStartingHand(List<MonkeyPoker.Card> cards)
        {
        }

        public MonkeyPoker.IAction TakeAction()
        {
            return null;
        }
    }
}
