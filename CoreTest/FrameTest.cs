using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    [TestFixture]
    class FrameTest
    {

        [TestCase]
        public void test_gutterFrame()
        {
            var frame = new Frame();
            frame.Roll(0);
            frame.Roll(0);

            Assert.AreEqual(0, frame.Score());
        }

        [TestCase]
        public void test_rollTwice()
        {
            var frame = new Frame();
            frame.Roll(5);
            frame.Roll(3);

            Assert.AreEqual(8, frame.Score());
        }


    }
}
