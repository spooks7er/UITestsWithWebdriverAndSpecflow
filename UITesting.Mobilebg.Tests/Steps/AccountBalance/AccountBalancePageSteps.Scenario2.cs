namespace UITesting.Mobilebg.Tests.Steps.AccountBalance
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;
    using UITesting.Mobilebg.Core.PageModels;

    public partial class AccountBalancePageSteps : BaseSteps
    {
        [When(@"I select a payment (.*)")]
        public void WhenISelectAPayment(string option)
        {
            CurrentPage.As<AccountBalancePage>().SelectPayment(option);
        }

        [When(@"I agree to the terms")]
        public void WhenIAgreeToTheTerms()
        {
            CurrentPage.As<AccountBalancePage>().CheckboxTerms.Click();
        }

        [When(@"I click payment confirmation button")]
        public void WhenIClickPaymentConfirmationButton()
        {
            CurrentPage.As<AccountBalancePage>().ButtonPay.Click();
        }

        [Then(@"I see a payment confirmation code")]
        public void ThenISeeAPaymentConfirmationCode()
        {
            try
            {
                Console.WriteLine(CurrentPage.As<AccountBalancePage>().ConfirmationCode.Text); 
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Error Confirmation Code was not Found");
            }
        }
    }
}