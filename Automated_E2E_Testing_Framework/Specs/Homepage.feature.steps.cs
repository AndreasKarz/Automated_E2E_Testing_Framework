using APOM.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automated_E2E_Testing_Workshop.Specs
{
    [Binding]
    public sealed class HomepageSteps
    {
        private readonly ScenarioContext context;
        private readonly Homepage homepage;

        public HomepageSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
            homepage = new Homepage(Hooks.Page.Driver);
        }

        [When(@"I select the QuickLink '(.*)'")]
        public void WhenISelectTheQuickLink(string quickLink)
        {
            homepage.QuickLinks.Select(quickLink);
        }

        [Then(@"Sollte der Titel '(.*)' sein")]
        public void ThenSollteDieURLSein(string title)
        {
            Assert.AreEqual(title, Hooks.Driver.Title);
        }

        [Then(@"the disclaimer should be shown")]
        public void ThenTheDisclaimerShouldBeShown()
        {
            Assert.IsTrue(homepage.Disclaimer.Displayed);
        }

        [Then(@"the (.*), the (.*) and the (.*) should be correct")]
        public void ThenTheTheAndTheShouldBeCorrect(string title, string text, string linktext)
        {
            Assert.AreEqual(title, homepage.Disclaimer.Title);
            Assert.AreEqual(text, homepage.Disclaimer.Text);
            Assert.AreEqual(linktext, homepage.Disclaimer.Action.Link.Text);
        }

        [Then(@"the disclaimer should be away")]
        public void ThenTheDisclaimerShouldBeAway()
        {
            Assert.IsFalse(homepage.Disclaimer.Displayed);
        }
    }
}
