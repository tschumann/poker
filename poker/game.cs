using System.Collections.Generic;

using Card;

namespace poker
{
    public class Game : Card.IGame
    {
        protected List<ICardPlayer> players;

        public Game()
        {
            this.players = new List<ICardPlayer>();
        }
        
        static void Main(string[] args)
        {
        }
    }
}
