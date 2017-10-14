using System.Collections.Generic;

using Card;

namespace poker
{
    public class Game : Card.IGame
    {
        private List<ICardPlayer> players;
        private Deck deck;

        public Game()
        {
            this.players = new List<ICardPlayer>();
            this.deck = new Deck(this, false);
        }

        public void deal()
        {
            this.deck.shuffle();

            foreach (var player in this.players)
            {
                player.receive(this.deck.draw());
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
