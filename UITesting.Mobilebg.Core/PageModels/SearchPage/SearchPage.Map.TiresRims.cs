namespace UITesting.Mobilebg.Core.PageModels
{
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using UITesting.Core.Extensions;
    
    public partial class SearchPage : BasePage
    {
        public IWebElement TabTiresRims 
        {
            get 
            {
                return Driver.FindElementAndWait(By.LinkText("Гуми и джанти"));
            } 
        }

        public SelectElement SelectType
        {
            get 
            {
                return SelectBrand;
            }
        }

        public IWebElement TiresPriceFrom
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("f31"));
            }
        }

        public IWebElement TiresPriceTo
        {
            get
            {
                return Driver.FindElementAndWait(By.Name("f32"));
            }
        }

        public SelectElement TiresWidth
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f10")));
            }
        }

        public SelectElement TiresHeigth
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f11")));
            }
        }

        public SelectElement TiresDiameter
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f12")));
            }
        }

        public SelectElement TiresType
        {
            get
            {
                return new SelectElement(Driver.FindElementAndWait(By.Name("f15")));
            }
        }
    }
}