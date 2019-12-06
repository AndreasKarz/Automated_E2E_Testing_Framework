using APOM.Molecules;
using OpenQA.Selenium;

namespace APOM.Pages
{
    public class Homepage: Page
    {
        public QuickLinks QuickLinks {get; set;}
        public Homepage(IWebDriver driver) : base(driver)
        {
            QuickLinks = new QuickLinks(Component);
        }

    }
}
