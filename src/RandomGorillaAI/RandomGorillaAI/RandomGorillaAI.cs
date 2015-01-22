using MonkeyPoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGorillaAI
{
    public class RandomGorillaAI : IAI
    {
        //public event EventHandler ActionHappened;

        public string Name
        {
            get { return "RandomGorillaAI"; }
        }

        public RandomGorillaAI()
        {
            Console.Out.WriteLine("Action Constructor!");
            
        }

        public void AddHandler(IActionHandler manager)
        {
            manager.ActionHappened += new MonkeyPoker.Action.ActionHandler(ReceiveAction);
        }

        public void ReceiveStartingHand(List<Card> cards)
        {
        }

        private void ReceiveAction(MonkeyPoker.Action action)
        {
            Console.Out.WriteLine("Action Received!");
        }

        public MonkeyPoker.Action TakeAction()
        {
            return null;
        }
    }
}
