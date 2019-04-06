namespace poker
{
    class RoyalFlush : HandType
    {
        public RoyalFlush(Hand hand) : base(hand)
        {
        }

        public override bool IsHandType()
        {
            Card.Card.Suit expectedSuit = this.hand.getCards()[0].suit;

            foreach (Card.Card card in this.hand.getCards())
            {
                if (card.suit != expectedSuit)
                {
                    return false;
                }
            }

            // TODO: check that expected ranks are present too

            return true;
        }
    }
}
