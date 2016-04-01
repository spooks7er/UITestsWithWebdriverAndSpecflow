namespace UITesting.Mobilebg.Core.PageModels
{
    using OpenQA.Selenium;

    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Logs in the current login form usign username and password
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        public void Login(string username, string password)
        {
            Driver.SwitchTo().Frame(LoginWindow);
            InputUsername.SendKeys(username);
            InputPassword.SendKeys(password);
            ButtonLoginConfirm.Click();
            Driver.SwitchTo().DefaultContent();
        }
    }
}