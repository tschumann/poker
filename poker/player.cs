using System.Collections.Generic;

class Player : Card.AbstractCardPlayer
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

    public int bet()
    {
        return 0;
    }

    public override Card.Card play()
    {
        return null;
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