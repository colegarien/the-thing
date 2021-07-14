using BowlingGame;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace BowlingGameSpecFlow.Steps
{
    [Binding]
    public sealed class GameStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Game _game;
        private int _finalScore;

        public GameStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _game = new Game(new FrameFactory());
        }

        // TODO : think of a better way to replace this "Given", it super general and bad.. think about what sorts of options would be helpful for a QA
        [Given("a roll knocks ([0-9]+) pins over")]
        public void GivenARollKnocksPinsOver(int pins)
        {
            _game.Roll(pins);
        }

        [When("the game is over")]
        public void WhenTheGameIsOver()
        {
            _finalScore = _game.Score();
        }

        [Then("the score should be (.*)")]
        public void ThenTheScoreShouldBe(int finalScore)
        {
            _finalScore.Should().Be(finalScore);
        }
    }
}
