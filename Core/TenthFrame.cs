namespace BowlingGame
{
    class TenthFrame : Frame
    {
        private int[] rolls = new int[3];
        private int currentRoll = 0;


        public void Roll(int pins)
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

        public int Score()
        {
            var score = 0;

            /* TODO - implement this
             if first is a strike, add second and thrird -> if second is also strike, add third again?
            else if first+second is spare, add third

             */
            if (IsSpare())
            {
                score = rolls[0] + rolls[1] + SpareBonus();
            } else
            {
                score = rolls[0] + rolls[1];
            }

            return score;
        }

        private bool IsSpare()
        {
            return rolls[0] + rolls[1] == 10;
        }

        private int SpareBonus()
        {
            return rolls[2];
        }
    }
}
