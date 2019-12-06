using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;

namespace APOM.Atoms
{
    public class SvgIcon : DefaultProps
    {
        private string getType()
        {
            var classString = Component.GetAttribute("class");
            var classes = classString.Split(' ');
            var iconType = classes[classes.Length-1];
            iconType = iconType.Replace("a-svg--", "");
            return iconType;
        }

        public SvgIcon(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.ClassName("a-svg--icon"), 2);
        }

        public SvgIcon(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
        }

        public SvgIcon(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
        }

        public string Type => getType();
    }
}
