using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    [TestFixture]
    class GameTest
    {
        private Game game;

        [SetUp]
        public void SetUp()
        {
            var frameFactory = new FrameFactory(); //TODO find a way to give the most minimal access to new up. Do acceptance tests
            game = new Game(frameFactory);
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

        [TestCase]
        public void test_rollStrike()
        {
            game.Roll(10);
            game.Roll(2);
            game.Roll(3);

            Assert.AreEqual(20, game.Score());
        }

        [TestCase]
        public void test_rollTurkey()
        {
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);

            Assert.AreEqual(60, game.Score());
        }

        [TestCase]
        public void test_tenthFrameScore()
        {
            rollGutterNineFrames();
            game.Roll(1);
            game.Roll(1);

            Assert.AreEqual(2, game.Score());
        }

        private void rollGutterNineFrames()
        {
            for (var i = 0; i < 18; i++)
            {
                game.Roll(0);
            }
        }

        [TestCase]
        public void test_perfectGame()
        {
            for (var i = 0; i < 12; i++)
            {
                game.Roll(10);
            }

            Assert.AreEqual(300, game.Score());
        }

    }
}
