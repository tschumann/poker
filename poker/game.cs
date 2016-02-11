using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Card;

namespace poker
{
    class Game
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
