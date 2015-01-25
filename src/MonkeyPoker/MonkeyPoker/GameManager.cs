using MonkeyPoker.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class GameManager : IActionHandler
    {
        // This event is triggered when any type of action happen
        // Eg. The dealer flip a card or another player bet some money
        public event MonkeyPoker.Action.ActionHandler ActionHappened;

        private Deck       mDeck;
        private AIManager  mAiManager;
        private List<Card> mBoard;
        private Dictionary<int, List<Card>> mPlayersHand;

        public GameManager()
        {
            mAiManager = new AIManager();
            mDeck      = new Deck();
            mBoard     = new List<Card>();
            mPlayersHand = new Dictionary<int, List<Card>>();

            mAiManager.LoadAIDlls(this);
            mAiManager.PrintAINamesAndDescriptions();
        }

        public void PlayGame()
        {
            DealCardsToPlayers();

            TakeBets();

            PlayFlop();

            TakeBets();

            PlayTurn();

            TakeBets();

            PlayRiver();

            TakeBets();
        }

        private void DealCardsToPlayers()
        {
            foreach (KeyValuePair<int, IAI> artificialPlayer in mAiManager.ArtificialPlayers)
            {
                mPlayersHand.Add(artificialPlayer.Key, new List<Card>());
                mPlayersHand[artificialPlayer.Key].Add(mDeck.DrawCard());
                mPlayersHand[artificialPlayer.Key].Add(mDeck.DrawCard());

                // Send cards to player
                artificialPlayer.Value.ReceiveStartingHand(mPlayersHand[artificialPlayer.Key]);
            }
        }

        // The first three community cards
        private void PlayFlop()
        {
            mBoard.Add(mDeck.DrawCard());
            ActionHappened(new NewCardOnTable() {NewCard = mBoard.Last() });
            mBoard.Add(mDeck.DrawCard());
            ActionHappened(new NewCardOnTable() { NewCard = mBoard.Last() });
            mBoard.Add(mDeck.DrawCard());
            ActionHappened(new NewCardOnTable() { NewCard = mBoard.Last() });
        }

        //The fourth community card
        private void PlayTurn()
        {
            mBoard.Add(mDeck.DrawCard());
            ActionHappened(new NewCardOnTable() { NewCard = mBoard.Last() });
        }

        // The fifth and final community card
        private void PlayRiver()
        {
            mBoard.Add(mDeck.DrawCard());
            ActionHappened(new NewCardOnTable() { NewCard = mBoard.Last() });
        }

        private void TakeBets()
        {
            IAI lastPlayerWhoRaised = null;
            Queue<IAI> PlayersStillPresent = new Queue<IAI>();

            foreach (IAI player in mAiManager.ArtificialPlayers.Values)
            {
                PlayersStillPresent.Enqueue(player);
            }

            // Each player take turn until the betting round end
            while (PlayersStillPresent.Count > 1 && lastPlayerWhoRaised != PlayersStillPresent.Peek())
            {
                IAI currentPlayer = PlayersStillPresent.Dequeue();
                Action currentAction = currentPlayer.TakeAction();

                if (currentAction is Actions.Raise)
                {
                    PlayersStillPresent.Enqueue(currentPlayer);
                    lastPlayerWhoRaised = currentPlayer;
                }
                else if (currentAction is Actions.Check)
                {
                    PlayersStillPresent.Enqueue(currentPlayer);
                }
            }
        }
    }
}
