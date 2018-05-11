using Microsoft.VisualStudio.TestTools.UnitTesting;
using poker;

namespace poker_tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void testDeal()
        {
            Game game = new Game(4);
            game.deal();
        }
    }
}
