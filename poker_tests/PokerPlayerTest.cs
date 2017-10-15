using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace poker_tests
{
    [TestClass]
    public class PokerPlayerTest
    {
        [TestMethod]
        public void testInstantiate()
        {
            Card.IGame game = new poker.Game();
            poker.PokerPlayer player = new poker.PokerPlayer(game);
        }
    }
}
