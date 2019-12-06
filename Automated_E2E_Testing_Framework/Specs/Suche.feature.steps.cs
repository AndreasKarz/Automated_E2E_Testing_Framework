using APOM.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automated_E2E_Testing_Workshop.Specs
{
    [Binding]
    public sealed class Suche
    {
        private readonly ScenarioContext context;
        private readonly Homepage homepage;
        private SearchResultPage searchResultPage;

        public Suche(ScenarioContext injectedContext)
        {
            context = injectedContext;
            homepage = new Homepage(Hooks.Page.Driver);
            if(homepage.Disclaimer.Displayed)
            {
                homepage.AcceptCookieDisclaimer();
            }
        }

        [When(@"Ich nach dem Begriff '(.*)' suche")]
        public void WennIchNachDemBegriffSuche(string suchbegriff)
        {
            homepage.SearchBar.SearchFor(suchbegriff);
            homepage.SearchBar.SearchWithEnter();
            searchResultPage = new SearchResultPage(Hooks.Page.Driver);
        }

        [Then(@"Werden mindestens (.*) Resultate gefunden")]
        public void DannWerdenMindestensResultateGefunden(int anzahl)
        {
            Assert.GreaterOrEqual(searchResultPage.Count, anzahl);
        }

        [Then(@"Wird die Meldung '(.*)' angezeigt")]
        public void DannWirdDieMeldungAngezeigt(string meldung)
        {
            Assert.AreEqual(0, searchResultPage.Count);
            Assert.AreEqual(meldung, searchResultPage.SearchResult.ResultMessage);
        }

    }
}
