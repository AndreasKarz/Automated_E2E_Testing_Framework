using APOM.Organisms;
using FunkyBDD.SxS.Selenium.WebDriver;
using OpenQA.Selenium;

namespace APOM.Pages
{
    public class SearchResultPage : Page
    {
        private static IWebElement parent;
        public SearchResult SearchResult;

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
            var test = driver.FindElementFirstOrDefault(By.CssSelector("div[data-template-name='searchresult']"));
            parent = driver.FindElement(By.TagName("body"));
            SearchResult = new SearchResult(parent);
        }

        public int Count => SearchResult.SearchResultCount;
    }
}
