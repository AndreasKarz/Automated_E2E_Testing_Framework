using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class Button : DefaultProps
    {
        public Button(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.TagName("button"), 2);
        }

        public Button(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
        }

        public Button(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
        }

        public void Click() => Component.Click();
    }
}
