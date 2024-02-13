using SpecFlowProject07febAssess.Support;

namespace SpecFlowProject07febAssess.StepDefinitions
{
    [Binding]
    public sealed class DivisionStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Divi divi;
        private int result;
        public DivisionStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.divi = new Divi();
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef


        [Given("the first divis number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            divi.Fnum = number;
        }

        [Given("the second divis number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            divi.Snum = number;
        }



        [When("the two numbers are Divided")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            result = divi.Div();
        }

        [Then("the div result shoul d be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(result);
        }

    }
}
