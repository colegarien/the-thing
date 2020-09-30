using BowlingGame;
using NUnit.Framework;
using System.Linq.Expressions;

namespace BowlingGameTest
{
    [TestFixture]
    class GameTest
    {
        private Game game;

        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }

        [TestCase]
        public void test_rollTwice()
        {
            game.Roll(2);
            game.Roll(3);

            Assert.AreEqual(5, game.Score());
        }

        [TestCase]
        public void test_rollTwoFrames()
        {
            game.Roll(2);
            game.Roll(3);
            game.Roll(4);
            game.Roll(5);

            Assert.AreEqual(14, game.Score());
        }

        [TestCase]
        public void test_rollAllOnes()
        {
            for (var i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.Score());
        }

        [TestCase]
        public void test_rollSpare()
        {
            RollSpare();
            game.Roll(5);
            game.Roll(4);


            Assert.AreEqual(24, game.Score());
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }

        // TODO add strike test

    }
}
