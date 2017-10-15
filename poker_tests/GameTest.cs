using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace poker_tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void testDeal()
        {
            poker.Game game = new poker.Game(4);
            game.deal();
        }
    }
}
