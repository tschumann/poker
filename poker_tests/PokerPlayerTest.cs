using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace poker_tests
{
    [TestClass]
    public class PokerPlayerTest
    {
        [TestMethod]
        public void testInstantiate()
        {
            poker.PokerPlayer player = new poker.PokerPlayer(null);
        }
    }
}
