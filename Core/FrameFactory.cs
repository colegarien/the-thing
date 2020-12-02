using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class FrameFactory
    {
        public Frame CreateFrameStack()
        {
            return new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new Frame(new TenthFrame())))))))));
        }

    }
}
