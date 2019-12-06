using FunkyBDD.SxS.Selenium.Browserstack;
using FunkyBDD.SxS.Selenium.WebDriver;
using OpenQA.Selenium;
using SwissLife.SxS.Helpers;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using APOM.Pages;

namespace Automated_E2E_Testing_Workshop
{
    [Binding]
    public sealed class Hooks
    {
        public static Homepage Page;
        public static IWebDriver Driver;
        public static Browser Browser;
        private static FeatureContext featureContext;
        private static ScenarioContext scenarioContext;
        private static string _testURL;

        #region Before methods
        [BeforeTestRun]
        public static void InitFramework()
        {
            if (Environment.GetEnvironmentVariable("TEST_URL") == null)
            {
                _testURL = "https://www.swisslife.ch/de/private.html";
            }
            else
            {
                _testURL = Environment.GetEnvironmentVariable("TEST_URL");
            }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext injectedContext)
        {
            featureContext = injectedContext;
            if (!featureContext.FeatureInfo.Tags.Contains("API"))
            {
                if (Environment.GetEnvironmentVariable("TEST_BROWSER") == null)
                {
                    Browser = new Browser("FirefoxLocal");
                }
                else
                {
                    Browser = new Browser(Environment.GetEnvironmentVariable("TEST_BROWSER"));
                }
                Driver = Browser.Driver;
                Driver.SetSeleniumFlag();
            }
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext injectedContext)
        {
            scenarioContext = injectedContext;
        }
        #endregion

        [Given(@"I open the Homepage"), Given(@"Die Homepage ist geöffnet")]
        public void IOpenTheTestPage()
        {
            Driver.Navigate().GoToUrl(_testURL);
            Page = new Homepage(Driver);
        }

        [Given(@"The language is set to '(.*)'"), When(@"I change the language to '(.*)'"), Given(@"Die Sprache ist auf '(.*)' gestellt")]
        public void GivenTheLanguageIsSetTo(string lang)
        {
            Page.SetLangTo(lang);
            Page = new Homepage(Driver); /* ReInit the Page, otherwise all elements will be staled! */
        }

        [When(@"I confirm the disclaimer"), When(@"Ich den Disclaimer bestätige")]
        public void WennIchDenDisclaimerBestatige()
        {
            Page.AcceptCookieDisclaimer();
        }

        #region After methods
        [AfterScenario]
        public void AfterScenarion()
        {
            if (Driver != null)
            {
                var screenShotFileName = $"{featureContext.FeatureInfo.Title}__{scenarioContext.ScenarioInfo.Title}.png";
                screenShotFileName = FileHelpers.RemoveIllegalFileNameChars(screenShotFileName);
                Driver.MakeScreenshot(screenShotFileName);
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            if (Browser != null)
            {
                Browser.DisposeDriver();
            }
        }
        #endregion

    }
}
