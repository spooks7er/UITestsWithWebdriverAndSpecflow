namespace UITesting.Mobilebg.Core.PageModels
{
    using OpenQA.Selenium;
    using UITesting.Core.Extensions;

    public partial class LoginPage
    {
        public IWebElement ProfileBox
        {
            get
            {
                return Driver.FindElementAndWait(By.Id("blocklog"));
            }
        }

        public IWebElement ButtonLogin
        {
            get
            {
                return ProfileBox.FindElement(By.LinkText("ВХОД"));
            }
        }

        public IWebElement ProfileHeader
        {
            get
            {
                return ProfileBox.FindElement(By.XPath("table/tbody/tr[1]/td/span"));
            }
        }

        public IWebElement LoginWindow
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("register"));
            }
        }

        public IWebElement InputUsername
        {
            get
            {
                return Driver.FindElement(By.Name("usr"));
            }
        }

        public IWebElement InputPassword
        {
            get
            {
                return Driver.FindElement(By.Name("pwd"));
            }
        }

        public IWebElement ButtonLoginConfirm
        {
            get
            {
                return Driver.FindElement(By.LinkText("ВХОД"));
            }
        }

        public IWebElement ErrorInvalidCred
        {
            get
            {
                return Driver.FindElement(By.Id("sendPassError"));
            }
        }
    }
}