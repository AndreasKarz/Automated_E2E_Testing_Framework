using APOM.Organisms;
using FunkyBDD.SxS.Selenium.WebDriver;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;
using System.Linq;

namespace APOM.Pages
{
    public class Page
    {
        public IWebElement Component { get; set; }
        public IWebDriver Driver { get; set; }
        public string Title { get; set; }

        public CookieDisclaimer Disclaimer { get; set; }

        public SearchBar SearchBar { get; set; }

        public Page(IWebDriver driver)
        {
            Driver = driver;
            Component = driver.FindElement(By.XPath("//body"));
            Title = driver.Title;
            Disclaimer = new CookieDisclaimer(Component);
            SearchBar = new SearchBar(Component);
    }

        public int GetScrollPos()
        {
            return Driver.GetScrollPosition();
        }

        public void ScrollY(int pos)
        {
            Driver.ExecuteScript($"window.scrollTo(0, {pos.ToString()});");
        }

        public void SetLangTo(string lang)
        {
            var nav = Driver.FindElementsOrDefault(By.CssSelector("nav[data-g-name='LanguageNavigation'] a"), 2);
            var setter = nav.Where(s => s.Text.ToLower() == lang.ToLower()).Select(s => s).FirstOrDefault();
            if(setter != null)
            {
                setter.ScrollTo();
                setter.Click();
            }
        }

        public void AcceptCookieDisclaimer() => Disclaimer.Confirm();

    }
}
