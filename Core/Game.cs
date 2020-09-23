using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Game
    {
        Frame head;

        public Game()
        {
            head = new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame())))))))));
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
