namespace UITesting.Mobilebg.Core.PageModels
{
    using OpenQA.Selenium;

    public abstract class BasePage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// Contstructor accepts IWebDriver as a parameter, the IWebDriver is used for the page object model in the derived page classes
        /// </summary>
        /// <param name="driver">Object of type IWebDriver</param>
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Gets the current instance of IWebDriver for the page
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        /// <summary>
        /// Generic method for casting abstract BasePage type to concrete page types
        /// </summary>
        /// <typeparam name="T">Generic page class derived from BasePage class</typeparam>
        /// <returns></returns>
        public T As<T>() where T : BasePage
        {
            return (T)this;
        }
    }
}