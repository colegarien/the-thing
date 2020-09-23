using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    [TestFixture]
    class GameTest
    {
        [TestCase]
        public void test_rollTwice()
        {
            var game = new Game();

            game.Roll(2);
            game.Roll(3);

            Assert.AreEqual(5, game.Score());
        }

        [TestCase]
        public void test_rollTwoFrames()
        {
            var game = new Game();

            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);

            Assert.AreEqual(14, game.Score());
        }

        [TestCase]
        public void test_rollAllOnes()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.Score());
        }
    }
}
