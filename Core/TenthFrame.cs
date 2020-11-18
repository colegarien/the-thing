namespace BowlingGame
{
    class TenthFrame : Frame
    {
        private readonly int[] rolls = new int[3];
        private int currentRoll = 0;


        public override void Roll(int pins)
        {
            if (IsFrameIncomplete())
            {
                rolls[currentRoll++] = pins;
            }
        }

        private bool IsFrameIncomplete()
        {
            return currentRoll < 2 || (currentRoll == 2 && rolls[0] + rolls[1] >= 10);
        }

        public override int Score()
        {
            return rolls[0] + rolls[1] + rolls[2];
        }

        protected override int GetRoll(int rollIndex)
        {
            return rollIndex < currentRoll
                ? rolls[rollIndex]
                : 0;
        }
    }
}
