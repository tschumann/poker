using System.Collections.Generic;

using Card;

namespace poker
{
    public class Game : Card.IGame
    {
        private List<ICardPlayer> players;
        private Deck deck;

        public Game(int players)
        {
            this.players = new List<ICardPlayer>(players);
            this.deck = new Deck(this, false);

            for (int i = 0; i < players; i++)
            {
                this.players.Insert(i, new PokerPlayer(this));
            }
        }

        public void deal()
        {
            this.deck.shuffle();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < this.players.Count; j++)
                {
                    this.players[j].receive(this.deck.draw());
                }
            }
        }

        public Deck getDeck()
        {
            return this.deck;
        }

        public PokerPlayer getPlayer(int index)
        {
            return (PokerPlayer)this.players[index];
        }
        
        static void Main(string[] args)
        {
        }
    }
}
