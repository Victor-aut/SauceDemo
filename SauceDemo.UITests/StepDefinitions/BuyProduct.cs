using System;
using TechTalk.SpecFlow;

namespace SauceDemo.UITests.StepDefinitions
{
    [Binding]
    public class BuyProduct
    {
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            throw new PendingStepException();
        }

        [Given(@"I add the '([^']*)' to my cart")]
        public void GivenIAddTheToMyCart(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the product added")]
        public void ThenIVerifyTheProductAdded(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            throw new PendingStepException();
        }

        [When(@"I fill the form and I click the continue button")]
        public void WhenIFillTheFormAndIClickTheContinueButton(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the overview data")]
        public void ThenIVerifyTheOverviewData(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"Click the Finish button")]
        public void ThenClickTheFinishButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I see the confirmation message")]
        public void ThenISeeTheConfirmationMessage(Table table)
        {
            throw new PendingStepException();
        }
    }
}
