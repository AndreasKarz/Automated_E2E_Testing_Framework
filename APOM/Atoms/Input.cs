using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class Input : DefaultProps
    {
        public Input(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.TagName("input"), 1);
        }

        public Input(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by, 1);
        }

        public Input(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"), 1);
        }

        public void Write(string text) => Component.SendKeys(text);
    }
}
