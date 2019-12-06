using APOM.Atoms;
using FunkyBDD.SxS.Selenium.APOM;
using OpenQA.Selenium;

namespace APOM.Organisms
{
    public class SearchResult : DefaultProps
    {
        public int SearchResultCount;
        public Header ResultHeader;

        private void initComponent()
        {
            SearchResultCount = int.Parse(Component.FindElement(By.CssSelector("*[data-result-count]")).GetAttribute("data-result-count"));
            var outline = Component.FindElement(By.ClassName("o-search-result__heading"));
            ResultHeader = new Header(outline);
        }

        public SearchResult(IWebElement parent)
        {
            Component = parent.FindElement(By.CssSelector("div[data-g-name='SearchResult']"));
            initComponent();
        }

        public SearchResult(IWebElement parent, By by)
        {
            Component = parent.FindElement(by);
            initComponent();
        }

        public SearchResult(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElement(By.XPath($".//*[@data-test-id='{dataTestId}']"));
            initComponent();
        }

        public string ResultMessage => ResultHeader.Text;

    }
}
