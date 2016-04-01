namespace UITesting.Mobilebg.Tests.Steps
{
    using TechTalk.SpecFlow;
    using UITesting.Mobilebg.Core.PageModels;

    public partial class SearchPageSteps
    {
        [When(@"Select Tire and Rims section")]
        public void WhenSelectTireAndRimsSection()
        {
            CurrentPage.As<SearchPage>().TabTiresRims.Click();
        }

        [When(@"I select Tires")]
        public void WhenISelectTires()
        {
            CurrentPage.As<SearchPage>().SelectType.SelectByValue("1");
        }

        [When(@"they are from (.*) to (.*) leva")]
        public void WhenTheyAreFromToLeva(int fromPrice, int toPrice)
        {
            CurrentPage.As<SearchPage>().TiresPriceFrom.SendKeys(fromPrice.ToString());
            CurrentPage.As<SearchPage>().TiresPriceTo.SendKeys(toPrice.ToString());
        }

        [When(@"they are with size (.*)/(.*)R(.*)")]
        public void WhenTheyAreWithSizeR(string width, string heigth, string diameter)
        {
            CurrentPage.As<SearchPage>().TiresWidth.SelectByText(width);
            CurrentPage.As<SearchPage>().TiresHeigth.SelectByText(heigth);
            CurrentPage.As<SearchPage>().TiresDiameter.SelectByText(diameter);
        }

        [When(@"are of type Summer\('(.*)'\)")]
        public void WhenAreOfTypeSummer(string type)
        {
            CurrentPage.As<SearchPage>().TiresType.SelectByText(type);
        }
    }
}