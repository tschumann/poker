using System;
using System.Collections.Generic;

class PokerCard : Card.Card, IComparable
{
    public PokerCard(Suit suit, Rank rank, Card.IGame game) : base(suit, rank, game)
    {
    }

    public int CompareTo(object obj)
    {
        if (((Card.Card)obj).rank == this.rank)
        {
            return 0;
        }

        return 0;
    }    
}
