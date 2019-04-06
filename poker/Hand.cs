using System.Collections.Generic;

namespace poker
{
    class Hand
    {
        private List<Card.Card> hand;

        public Hand(List<Card.Card> hand)
        {
            this.hand = hand;
        }

        public List<Card.Card> getCards()
        {
            return new List<Card.Card>(this.hand);
        }
    }
}
