using APOM.Atoms;
using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Molecules
{
    public class Action : DefaultProps
    {
        public Button Button;
        public Link Link;
        public Action(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.CssSelector("*[class$='__actions']"));
            Button = new Button(Component);
            Link = new Link(Component);
        }

        public Action(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
        }

        public Action(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
        }
    }
}
