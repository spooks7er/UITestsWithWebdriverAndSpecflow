namespace UITesting.Mobilebg.Tests.Steps.AccountBalance
{
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using UITesting.Mobilebg.Core.PageModels;

    [Binding]
    public partial class AccountBalancePageSteps : BaseSteps
    {
        [Given(@"Navigated to Account Balance")]
        public void GivenNavigatedToAccountBalance()
        {
            CurrentPage = new AccountBalancePage(Driver);
            Driver.Navigate().GoToUrl("http://www.mobile.bg/pcgi/mobile.cgi?act=16&rub=5");
        }

        [When(@"I Move the slider with (.*) percent")]
        public void WhenIMoveTheSliderWithPercent(int offset)
        {
            CurrentPage.As<AccountBalancePage>().SliderSlider(offset);
        }

        [Then(@"The bonus should be (.*) percent")]
        public void ThenTheBonusShouldBePercent(int bonus)
        {
            var actual = CurrentPage.As<AccountBalancePage>().LabelBonusPerc.Text;
            Assert.IsTrue(actual.Contains(bonus.ToString()));
        }
    }
}