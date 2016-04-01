namespace UITesting.Mobilebg.Core.PageModels
{
    using OpenQA.Selenium;
    using UITesting.Core.Extensions;

    public partial class AccountBalancePage
    {
        public IWebElement SliderBar
        {
            get
            {
                return Driver.FindElementAndWait(By.Id("slider_amount"));
            }
        }

        public IWebElement SliderDot
        {
            get
            {
                return SliderBar.FindElement(By.TagName("a"));
            }
        }

        public IWebElement LabelAmmount
        {
            get
            {
                return Driver.FindElementAndWait(By.Id("amount"));
            }
        }

        public IWebElement LabelBonusPerc
        {
            get
            {
                return Driver.FindElementAndWait(By.Id("perc_amount"));
            }
        }

        public IWebElement PaymentForm
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("payform"));
            }
        }

        public IWebElement CheckboxTerms
        {
            get
            {
                return PaymentForm.FindElement(By.Name("chkcond"));
            }
        }

        public IWebElement ButtonPay
        {
            get
            {
                return PaymentForm.FindElement(By.Id("paybutton"));
            }
        }

        public IWebElement ConfirmationCode
        {
            get
            {
                return Driver.FindElementAndWait(By.XPath("/html/body/div[2]/table[4]/tbody/tr/td[1]/div[2]/div[2]/div[1]/span"));
            }
        }
    }
}