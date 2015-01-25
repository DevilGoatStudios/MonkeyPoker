using MonkeyPoker;
using MonkeyPoker.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGorillaAI
{
    public class RandomGorillaAI : IAI
    { 

        public string Name
        {
            get { return "RandomGorillaAI"; }
        }

        private List<Card> mCardsInHand;
        private List<Card> mCardsOnTable;

        public RandomGorillaAI()
        {
            Console.Out.WriteLine("Action Constructor!");
            mCardsInHand = new List<Card>();
            mCardsOnTable = new List<Card>();
        }

        public void AddHandler(IActionHandler manager)
        {
            manager.ActionHappened += new MonkeyPoker.Action.ActionHandler(ReceiveAction);
        }

        public void ReceiveStartingHand(List<Card> cards)
        {
            mCardsInHand = cards;
        }

        private void ReceiveAction(dynamic action)
        {
            Console.Out.WriteLine("Action Received! " + action.GetType().Name);

            Type type = action.GetType();

            ReceiveActionCast(action);
        }

        private void ReceiveActionCast(NewCardOnTable action)
        {
            mCardsOnTable.Add(action.NewCard);
            Console.Out.WriteLine("Card on table by the random AI!");
            foreach(Card card in mCardsOnTable)
            {
                Console.Out.WriteLine(card.ToString());
            }
        }

        private void ReceiveActionCast(Fold action)
        {
            Console.Out.WriteLine("Player " + action.PlayerId + " fold");
        }

        public MonkeyPoker.Action TakeAction()
        {
            return null;
        }
    }
}
