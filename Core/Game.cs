namespace BowlingGame
{
    public class Game
    {
        Frame head;

        public Game(FrameFactory frameFactory)
        {
            head = frameFactory.CreateFrameStack();
        }

        public void Roll(int pins)
        {
            head.Roll(pins);
        }

        public int Score()
        {
            return head.Score();
        }
    }
}
