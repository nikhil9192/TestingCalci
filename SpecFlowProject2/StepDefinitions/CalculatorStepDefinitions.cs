//using NewClassLibrary;
namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       NewClassLibrary.Calci temp=new NewClassLibrary.Calci();
        int ans;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number) =>
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            temp.Numb1 = number;
        //throw new PendingStepException();

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            temp.Numb2 = number;
            // throw new PendingStepException();
        }

        [When("the two numbers are Sub")]
        public void WhenTheTwoNumbersAreSub()
        {
            //TODO: implement act (action) logic

            ans = temp.Sub();
            // throw new PendingStepException();
        }

            [When("the two numbers are Add")]
            public void WhenTheTwoNumbersAreAdd()
            {
                //TODO: implement act (action) logic

                ans = temp.Add();
                // throw new PendingStepException();
            }


        [When("the two numbers are Mul")]
        public void WhenTheTwoNumbersAreMul()
        {
            //TODO: implement act (action) logic

            ans = temp.Mul();
            // throw new PendingStepException();
        }

        [When("the two numbers are Div")]
        public void WhenTheTwoNumbersAreDiv()
        {
            //TODO: implement act (action) logic

            ans = temp.Div();
            // throw new PendingStepException();
        }

        [When("the two numbers are Sqt")]
        public void WhenTheTwoNumbersAreSqt()
        {
            //TODO: implement act (action) logic

            ans = temp.Sqt();
            // throw new PendingStepException();
        }



        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            result.Should().Be(ans);
           // throw new PendingStepException();
        }
    }
}
