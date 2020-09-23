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
            if (currentRoll < rolls.Length)
            {
                rolls[currentRoll++] = pins;
            }
            else
            {
                nextFrame?.Roll(pins);
            }
        }

        public int Score()
        {
            var score = 0;
            foreach (var roll in rolls)
            {
                score += roll;
            }
            return score + (nextFrame?.Score() ?? 0);
        }

    }
}
