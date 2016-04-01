namespace UITesting.Core.Extensions
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Provides extension methods for Selenium WebDriver
    /// </summary>
    public static class WedDriverExtensions
    {
        /// <summary>
        /// Extension for IWebDriver that waits for an element to appear on the page and returns it when it does
        /// </summary>
        /// <param name="driver">Extends IWebDriver interface.</param>
        /// <param name="by">By object, provides a mechanism by which to find elements within a document.</param>
        /// <param name="timeoutInSeconds">Optional timeout, default is 10 sec.</param>
        /// <returns>Returns an object of type IWebElement once it has been located</returns>
        public static IWebElement FindElementAndWait(this IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }

            return driver.FindElement(by);
        }
    }
}