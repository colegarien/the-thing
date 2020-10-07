namespace BowlingGame
{
    public class Frame
    {
        private Frame nextFrame;
        private int[] rolls = new int[2];
        private int currentRoll = 0;

        public Frame()
        {

        }

        public Frame(Frame nextFrame)
        {
            this.nextFrame = nextFrame;
        }

        public void Roll(int pins)
        {
            if (IsFrameIncomplete())
            {
                rolls[currentRoll++] = pins;
            }
            else
            {
                nextFrame?.Roll(pins);
            }
        }

        private bool IsFrameIncomplete()
        {
            return rolls[0] != 10 && currentRoll < rolls.Length;
        }

        public int Score()
        {
            var score = rolls[0] + rolls[1];

            if (IsStrike())
            {
                score += StrikeBonus();
            }
            else if (IsSpare())
            {
                score += SpareBonus();
            }

            return score + NextFramesScore();
        }

        private int StrikeBonus()
        {
            return (nextFrame?.GetRoll(0) ?? 0) + (nextFrame?.GetRoll(1) ?? 0);
        }

        private bool IsStrike()
        {
            return rolls[0] == 10;
        }

        private bool IsSpare()
        {
            return rolls[0] + rolls[1] == 10;
        }

        private int SpareBonus()
        {
            return nextFrame?.GetRoll(0) ?? 0;
        }

        private int GetRoll(int rollIndex)
        {
            return rolls[rollIndex];
        }

        private int NextFramesScore()
        {
            return (nextFrame?.Score() ?? 0);
        }

    }
}
