using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class Header : DefaultProps
    {
        public Header(IWebElement parent)
        {
            Component = parent.FindElement(By.ClassName("a-heading"));
        }

        public Header(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
        }

        public Header(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElement(By.XPath($".//*[@data-test-id='{dataTestId}']"));
        }

        public string Text => Component.Text;
    }
}
