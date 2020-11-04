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
            var score = rolls[0] + rolls[1] + rolls[2];

            /* TODO - implement this
             if first is a strike, add second and thrird -> if second is also strike, add third again?
            else if first+second is spare, add third

             */

            return score;
        }
    }
}
