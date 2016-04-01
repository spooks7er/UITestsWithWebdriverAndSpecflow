namespace UITesting.Mobilebg.Tests.Steps
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;
    using UITesting.Mobilebg.Core.PageModels;

    [Binding]
    public class LoginPageSteps : BaseSteps
    {
        [Given(@"I have navigated to the url '(.*)'")]
        public void GivenIHaveNavigatedToTheUrl(string url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
        }

        [Given(@"I have entered Username and Password")]
        public void GivenIHaveEnteredUsernameAndPass(Table table)
        {
            dynamic cred = table.CreateDynamicInstance();
            ScenarioContext.Current.Add("cred", cred);
            CurrentPage = new LoginPage(Driver);
            CurrentPage.As<LoginPage>().ButtonLogin.Click();
            CurrentPage.As<LoginPage>().Login(cred.Username.ToString(), cred.Password.ToString());
        }

        [Then(@"I should see my Firstname and Lastname in the profile box")]
        public void ThenIShouldSeeMyFirstnameAndLastnameInTheProfileBox()
        {
            dynamic cred = ScenarioContext.Current["cred"];
            string fullName = cred.Firstname.ToString() + " " + cred.Lastname.ToString();
            string actual = CurrentPage.As<LoginPage>().ProfileHeader.Text;
            Assert.AreEqual(fullName, actual);
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Driver.SwitchTo().Frame(CurrentPage.As<LoginPage>().LoginWindow);
            try
            {
                Assert.IsNotNull(CurrentPage.As<LoginPage>().ErrorInvalidCred);
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Error Message was not Found");
            }
        }
    }
}
