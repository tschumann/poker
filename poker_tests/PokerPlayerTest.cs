using Microsoft.VisualStudio.TestTools.UnitTesting;
using poker;

namespace poker_tests
{
    [TestClass]
    public class PokerPlayerTest
    {
        [TestMethod]
        public void testInstantiate()
        {
            Game game = new Game(1);
            // a player should have no cards by default
            Assert.AreEqual(0, game.getPlayer(0).getHand().Count);
            game.deal();
            // after dealing a player should have 5 cards
            Assert.AreEqual(5, game.getPlayer(0).getHand().Count);
        }
    }
}
