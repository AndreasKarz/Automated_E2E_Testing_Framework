using APOM.Atoms;
using FunkyBDD.SxS.Selenium.APOM;
using FunkyBDD.SxS.Selenium.WebElement;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace APOM.Molecules
{
    public class QuickLinks : DefaultProps
    {
        private readonly Dictionary<string, Link> linkList = new Dictionary<string, Link>();

        private void initComponent()
        {
            foreach (var element in Component.FindElementsOrDefault(By.ClassName("m-link-list__item")))
            {
                var link = new Link(element);
                try
                {
                    linkList.Add(link.Text, link);
                }
                catch (System.Exception)
                {
                    //
                }
                
            }
        }

        public QuickLinks(IWebElement parent)
        {
            Component = parent.FindElementFirstOrDefault(By.CssSelector("*[data-g-name='QuickLinks']"));
            initComponent();
        }

        public QuickLinks(IWebElement parent, By by)
        {
            Component = parent.FindElementFirstOrDefault(by);
            initComponent();
        }

        public QuickLinks(IWebElement parent, string dataTestId)
        {
            Component = parent.FindElementFirstOrDefault(By.XPath($".//*[@data-test-id='{dataTestId}']"));
            initComponent();
        }

        public void Select(string link)
        {
            linkList[link].Click();
        }
    }
}
