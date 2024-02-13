using SpecFlowProject07febAssess.Support;

namespace SpecFlowProject07febAssess.StepDefinitions
{
    [Binding]
    public sealed class MultiplicationStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Mult mul;
        private int result;
        public MultiplicationStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.mul = new Mult();
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first mul number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            mul.Fnum = number;
        }

        [Given("the second mul number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            mul.Snum = number;
        }

        [When("the two numbers are multiplicated")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            result = mul.Mul();
        }

        [Then("the mul result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(result);
        }

    }
}
