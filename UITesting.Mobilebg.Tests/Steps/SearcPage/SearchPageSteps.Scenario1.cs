namespace UITesting.Mobilebg.Tests.Steps
{
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using UITesting.Mobilebg.Core.PageModels;

    [Binding]
    public partial class SearchPageSteps : BaseSteps
    {
        [When(@"I do advanced search")]
        public void WhenIDoAdvancedSearch()
        {
            CurrentPage = new SearchPage(Driver);

            CurrentPage.As<SearchPage>().LinkAdvancedSearch.Click();
        }

        [When(@"I look for '(.*)' doors car")]
        public void WhenILookForDoorsCar(string doorType)
        {
            CurrentPage.As<SearchPage>().CheckboxClick(doorType);
        }

        [When(@"it has pictures")]
        public void WhenItHasPictures()
        {
            CurrentPage.As<SearchPage>().HasPictureCheckbox.Click();
        }

        [When(@"it is from private users only")]
        public void WhenItIsFromPrivateUsersOnly()
        {
            CurrentPage.As<SearchPage>().ClientsPrivate.Click();
        }

        [When(@"it is from (.*) to (.*) year")]
        public void WhenItIsFromToYear(int fromYear, int toYear)
        {
            CurrentPage.As<SearchPage>().SetYearRange(fromYear, toYear);
        }

        [When(@"it is from (.*) to (.*) leva")]
        public void WhenItIsFromToLeva(int fromPrice, int toPrice)
        {
            CurrentPage.As<SearchPage>().PriceFrom.SendKeys(fromPrice.ToString());
            CurrentPage.As<SearchPage>().PriceTo.SendKeys(toPrice.ToString());
        }

        [When(@"it is sorted by price")]
        public void WhenItIsSortedByPrice()
        {
            CurrentPage.As<SearchPage>().SelectSortedBy.SelectByValue("3");
        }

        [Then(@"I must see at least (.*) result")]
        public void ThenIMustSeeAtLeastResult(int number)
        {
            CurrentPage = CurrentPage.As<SearchPage>().ClickSearch();
            int actual = CurrentPage.As<SearchResults>().GetResultCount();
            Assert.IsTrue(number <= actual);
        }
    }
}