using System;
using fit;
using BowlingGame;

public class GutterGameFixture : ColumnFixture
{
    private Game game;
    private int roll;

    public GutterGameFixture()
    {
        this.game = new Game(new FrameFactory());
        this.roll = 0;
    }

    public void Roll(int roll)
    {
        game.Roll(roll);
    }

    public int Score()
    {
        return game.Score();
    }
}
