namespace UITesting.Mobilebg.Tests.Steps
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using TechTalk.SpecFlow;
    using UITesting.Mobilebg.Core.PageModels;

    public abstract class BaseSteps : Steps
    {
        private readonly IWebDriver driver;
        private BasePage currentPage;

        /// <summary>
        /// Constructor sets the current driver instance and adds it to ScenarioContext
        /// </summary>
        public BaseSteps()
        {
            if (!ScenarioContext.Current.ContainsKey("driver"))
            {
                this.driver = new FirefoxDriver();
                ScenarioContext.Current["driver"] = this.driver;
            }
            else
            {
                this.driver = ScenarioContext.Current.Get<IWebDriver>("driver");
            }
        }

        /// <summary>
        /// Public property, gets or sets the current page instance in ScenarioContext
        /// </summary>
        public BasePage CurrentPage
        {
            get
            {
                return ScenarioContext.Current.Get<BasePage>("currentPage");
            }
            set
            {
                currentPage = value;
                ScenarioContext.Current["currentPage"] = currentPage;
            }
        }

        /// <summary>
        /// Public property, gets the current IWebDriver instance in ScenarioContext
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return ScenarioContext.Current.Get<IWebDriver>("driver");
            }
        }

        /// <summary>
        /// Method called after each scenario to close the browser and quit webdriver.
        /// </summary>
        [AfterScenario]
        public void After()
        {
            if (Driver == null)
            {
                return;
            }

            Driver.Quit();
        }
    }
}