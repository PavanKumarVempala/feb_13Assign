using SpecFlowProject07febAssess.Support;

namespace SpecFlowProject13febAssess.StepDefinitions
{
    [Binding]
    public sealed class SubtractionStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Subt subt;
        private int result;
        public SubtractionStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.subt = new Subt();
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first sub number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            subt.Fnum = number;
        }

        [Given("the second sub number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            subt.Snum = number;
        }

        [When("the two numbers are Subtraction")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            result = subt.Sub();
        }

        [Then("the sub result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(result);
        }

    }
}
