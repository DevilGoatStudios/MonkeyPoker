using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyPoker
{
    public class GameManager
    {
        private Deck       mDeck;
        private AIManager  mAiManager;
        private List<Card> mBoard;

        public GameManager()
        {
            mAiManager = new AIManager();
            mDeck      = new Deck();
            mBoard     = new List<Card>();

            mAiManager.LoadAIDlls();
            mAiManager.PrintAINamesAndDescriptions();
        }

        public void PlayGame()
        {
            DealCardsToPlayers();

            // Take bets

            PlayFlop();

            // Take bets

            PlayTurn();

            // Take bets

            PlayFlop();

            // Take bets
        }

        private void DealCardsToPlayers()
        {
            foreach (IAI artificialPlayer in mAiManager.ArtificialPlayers)
            {
                Card card1 = mDeck.DrawCard();
                Card card2 = mDeck.DrawCard();

                // @todo
                // Send event/action to the AI so it knows its cards
            }
        }

        // The first three community cards
        private void PlayFlop()
        {
            mBoard.Add(mDeck.DrawCard());
            mBoard.Add(mDeck.DrawCard());
            mBoard.Add(mDeck.DrawCard());

            // @todo
            // Send event/action to AIs so they know the flop
        }

        //The fourth community card
        private void PlayTurn()
        {
            mBoard.Add(mDeck.DrawCard());

            // @todo
            // Send event/action to AIs so they know the turn
        }

        // The fifth and final community card
        private void PlayRiver()
        {
            mBoard.Add(mDeck.DrawCard());

            // @todo
            // Send event/action to AIs so they know the river
        }
    }
}
