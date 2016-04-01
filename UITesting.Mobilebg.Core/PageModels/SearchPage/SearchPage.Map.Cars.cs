namespace UITesting.Mobilebg.Core.PageModels
{
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using UITesting.Core.Extensions;

    public partial class SearchPage : BasePage
    {
        public IWebElement LinkAdvancedSearch
        {
            get
            {
                return Driver.FindElementAndWait(By.LinkText("Подробно търсене"));
            }
        }

        public IWebElement ButtonSearch
        {
            get
            {
                return Driver.FindElements(By.TagName("input"))
                    .FirstOrDefault(b => b.GetAttribute("value") == "Т Ъ Р С И");
            }
        }

        public SelectElement SelectBrand
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f5")));
            }
        }

        public SelectElement SelectModel
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f6")));
            }
        }

        public SelectElement SelectYearFrom
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f10")));
            }
        }

        public SelectElement SelectYearTo
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f11")));
            }
        }

        public SelectElement SelectSortedBy
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f20")));
            }
        }

        public IWebElement PriceFrom
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("f7"));
            }
        }

        public IWebElement PriceTo
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("f8"));
            }
        }

        public IWebElement HasPictureCheckbox
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("f22"));
            }
        }

        public IWebElement ClientsAllRadio
        {
            get
            {
                return Driver.FindElements(By.Name("f24")).ToList()[0];
            }
        }

        public IWebElement ClientsTradersRadio
        {
            get
            {
                return Driver.FindElements(By.Name("f24")).ToList()[1];
            }
        }

        public IWebElement ClientsPrivate
        {
            get
            {
                return Driver.FindElements(By.Name("f24")).ToList()[2];
            }
        }
    }
}