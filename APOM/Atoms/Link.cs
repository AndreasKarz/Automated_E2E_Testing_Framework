using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class Link : DefaultProps
    {
        public SvgIcon Icon { get; set; }

        private void initComponent()
        {
            Icon = new SvgIcon(Component);
        }

        public Link(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.ClassName("a-link"));
            initComponent();
        }

        public Link(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
            initComponent();
        }

        public Link(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
            initComponent();
        }

        public void Click()
        {
            Component.ScrollTo();
            Component.Click(); 
        }

        public string Text => Component.Text;

        public string Href => Component.GetAttribute("href");

        public string Target => Component.GetAttribute("target");

        public string IconType => Icon.Type;

    }
}
