using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class Link : DefaultProps
    {
        public Link(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.ClassName("a-link"));
        }

        public Link(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
        }

        public Link(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
        }

        public void Click()
        {
            //Component.ScrollTo();
            Component.Click(); 
        }

        public string Text => Component.Text;

        // Icon
    }
}
