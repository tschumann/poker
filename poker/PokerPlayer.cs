
namespace poker
{
    public class PokerPlayer : Card.AbstractCardPlayer
    {
        public enum HandType
        {
            HIGH_CARD,
            PAIR,
            TWO_PAIR,
            THREE_OF_A_KIND,
            STRAIGHT,
            FLUSH,
            FULL_HOUSE,
            FOUR_OF_A_KIND,
            STRAIGHT_FLUSH,
        }

        public PokerPlayer(Card.IGame game) : base(game)
        {
        }

        public int bet()
        {
            return 0;
        }

        /*
         * With a hand of five cards, decide which to throw and which to keep.
         */
        public override Card.Card play()
        {
            // TODO: find any two or more of a kinds, any in order, any of the same suit etc
            return null;
        }

        public override Card.Card swap(Card.Card card)
        {
            return card;
        }

        public HandType getHandType()
        {
            bool allSameSuit = false;
            bool allInOrder = false;

            if (allSameSuit && allInOrder)
            {
                return HandType.STRAIGHT_FLUSH;
            }
            if (allSameSuit && !allInOrder)
            {
                return HandType.FLUSH;
            }
            if (!allSameSuit && allInOrder)
            {
                return HandType.STRAIGHT;
            }

            return HandType.HIGH_CARD;
        }
    }
}