namespace poker
{
    abstract class HandType
    {
        protected Hand hand;

        public HandType(Hand hand)
        {
            this.hand = hand;
        }

        public abstract bool IsHandType();
    }
}
