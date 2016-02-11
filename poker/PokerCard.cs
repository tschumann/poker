﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PokerCard : Card.Card, IComparable
{
    public PokerCard(Suit suit, Rank rank) : base(suit, rank)
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