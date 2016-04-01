namespace UITesting.Mobilebg.Core.PageModels
{
    using System.Linq;
    using OpenQA.Selenium;
    using UITesting.Core.Extensions;

    public partial class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Checks a single chekbox in the array of checkboxes on the page by a given label text
        /// </summary>
        /// <param name="labelText">The label tex of the checkbox</param>
        public void CheckboxClick(string labelText)
        {
            IWebElement table = Driver.FindElementAndWait(By.XPath("/html/body/div[3]/form/table/tbody/tr/td/table[6]"));
            var checkbox = table.FindElements(By.TagName("label"))
                .FirstOrDefault(s => s.Text.Contains(labelText));
            checkbox.Click();
        }

        /// <summary>
        /// Sets the year range on the current form
        /// </summary>
        /// <param name="from">Year From</param>
        /// <param name="to">Year To</param>
        public void SetYearRange(int from, int to)
        {
            SelectYearFrom.SelectByValue(from.ToString());
            SelectYearTo.SelectByValue(to.ToString());
        }

        /// <summary>
        /// Clicks the rearch button on the current page and returns a new page object of the results page
        /// </summary>
        /// <returns>Page object of type ResultsPage</returns>
        public SearchResults ClickSearch()
        {
            ButtonSearch.Click();
            return new SearchResults(Driver);
        }
    }
}