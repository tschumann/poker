using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace poker_tests
{
    [TestClass]
    public class PokerPlayerTest
    {
        [TestMethod]
        public void testInstantiate()
        {
            poker.Game game = new poker.Game(1);
            // a player should have no cards by default
            Assert.AreEqual(0, game.getPlayer(0).getHand().Count);
            poker.PokerPlayer player = new poker.PokerPlayer(game);
            // after dealing a player should have 5 cards
            // Assert.AreEqual(5, game.getPlayer(0).getHand().Count);
        }
    }
}
