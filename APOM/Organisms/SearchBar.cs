using APOM.Atoms;
using FunkyBDD.SxS.Selenium.APOM;
using OpenQA.Selenium;

namespace APOM.Organisms
{
    public class SearchBar : DefaultProps
    {
        public Link Link;
        public Input Input;

        private void initComponent(IWebElement parent) {
            Link = new Link(parent, By.Id("a11y-header-search-link"));
            Input = new Input(Component);
        }

        public SearchBar(IWebElement parent)
        {
            Component = parent.FindElement(By.CssSelector("div[data-g-name='SearchBox']"));
            initComponent(parent);
        }

        public SearchBar(IWebElement parent, By by)
        {
            Component = parent.FindElement(by);
            initComponent(parent);
        }

        public SearchBar(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElement(By.XPath($".//*[@data-test-id='{dataTestId}']"));
            initComponent(parent);
        }

        public void Open()
        {
            Link.Click();
        }

        public void SearchFor(string query)
        {
            Open();
            Input.Write(query);
        }

        public void SearchWithEnter() => Input.Write(Keys.Enter);
    }
}
