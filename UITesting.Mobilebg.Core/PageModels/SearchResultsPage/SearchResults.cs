namespace UITesting.Mobilebg.Core.PageModels
{
    using System;
    using OpenQA.Selenium;

    public partial class SearchResults : BasePage
    {
        public SearchResults(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Gets the total results number from the current results page
        /// </summary>
        /// <returns>Returns an integer results or 0 if there aren't any</returns>
        public int GetResultCount()
        {
            string res = ResultsCount.Text;
            if (!res.Contains("Няма намерени обяви"))
            {
                string start = "от общо ";
                string end = " обяв"; //a/и
                string sub = res.Substring(res.IndexOf(start) + start.Length);
                return Convert.ToInt32(sub.Substring(0, sub.IndexOf(end)));
            }

            return 0;
        }
    }
}