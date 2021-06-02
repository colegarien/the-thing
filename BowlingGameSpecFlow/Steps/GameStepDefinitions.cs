using TechTalk.SpecFlow;

namespace BowlingGameSpecFlow.Steps
{
    [Binding]
    public sealed class GameStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public GameStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        // TODO: Implement the Gheirkin for Gutter, Sporadic, and Perfect game Acceptance TEsts -> https://github.com/colegarien/the-thing/wiki

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _scenarioContext.Pending();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _scenarioContext.Pending();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {

            _scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _scenarioContext.Pending();
        }
    }
}
