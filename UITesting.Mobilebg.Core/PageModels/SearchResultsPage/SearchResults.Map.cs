namespace UITesting.Mobilebg.Core.PageModels
{
    using OpenQA.Selenium;
    using UITesting.Core.Extensions;

    public partial class SearchResults
    {
        public IWebElement ResultsCount
        {
            get
            {
                return Driver.FindElementAndWait(By.XPath("/html/body/div[3]/table[4]/tbody/tr[1]/td[1]/form[3]/table[1]/tbody/tr/td"));
            }
        }
    }
}