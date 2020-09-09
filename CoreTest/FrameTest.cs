using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTest
{
    [TestFixture]
    class FrameTest
    {

        [TestCase]
        public void test_createFrame()
        {
            var frame = new Frame();
            Assert.True(true);
        }

        [TestCase]
        public void test_rollTwice_calculateScore()
        {
            var frame = new Frame();
            frame.roll(5);
            frame.roll(3);

            Assert.AreEqual(8, frame.score());
        }

        [TestCase]
        public void test_twoFrames()
        {
            var frameTwo = new Frame();
            var frameOne = new Frame(frameTwo);

            frameOne.roll(5);
            frameOne.roll(3);

            frameTwo.roll(2);
            frameTwo.roll(2);


        }

    }
}
