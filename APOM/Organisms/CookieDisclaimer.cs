using APOM.Molecules;
using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Organisms
{
    public class CookieDisclaimer : DefaultProps
    {
        public Action Action { get; set; }

        private void initComponent()
        {
            Action = new Action(Component);
        }

        public CookieDisclaimer(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.CssSelector("div[data-g-name='CookieDisclaimer']"), 2);
            initComponent();
        }

        public CookieDisclaimer(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
            initComponent();
        }

        public CookieDisclaimer(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
            initComponent();
        }

        public void Confirm() => Action.Button.Click();

        public bool IsDisplayed => Component != null;

        public string Title => Component.FindElementFirstOrDefault(By.CssSelector("*[class$='__title']"), 1)?.Text ?? string.Empty;

        public string Text => Component.FindElementFirstOrDefault(By.CssSelector("*[class$='__text']"), 1)?.Text ?? string.Empty;
    }
}
