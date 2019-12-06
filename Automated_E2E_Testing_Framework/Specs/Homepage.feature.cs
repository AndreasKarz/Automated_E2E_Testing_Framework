// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Automated_E2E_Testing_Workshop.Specs
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Homepage base functionalities")]
    [NUnit.Framework.CategoryAttribute("base")]
    public partial class HomepageBaseFunctionalitiesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "base"};
        
#line 1 "Homepage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Homepage base functionalities", "\tIn order to \r\n\t\tavoid silly mistakes\r\n\tAs a \r\n\t\tmath idiot\r\n\tI want to \r\n\t\tbe to" +
                    "ld the sum of two numbers", ProgrammingLanguage.CSharp, new string[] {
                        "base"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
#line hidden
#line 11
 testRunner.Given("I open the Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the language navigation")]
        [NUnit.Framework.CategoryAttribute("language")]
        [NUnit.Framework.TestCaseAttribute("DE", "Informationen zu Cookies", "Swiss Life möchte Ihnen stets den bestmöglichen Service bieten. Damit Sie unsere " +
            "Website optimal nutzen und wir diese fortlaufend verbessern können, verwenden wi" +
            "r Cookies. Durch die weitere Nutzung der Website stimmen Sie der Verwendung von " +
            "Cookies zu.", "Weitere Informationen zum Datenschutz", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "", "Swiss Life strives to always offer the best-possible service. We use cookies on o" +
            "ur website to enhance your experience and make ongoing improvements. By continui" +
            "ng to browse the site, you are agreeing to our use of cookies.", "Privacy policy", null)]
        [NUnit.Framework.TestCaseAttribute("FR", "", @"Swiss Life tient à vous offrir le meilleur service possible en tout temps. Afin que vous puissiez faire un usage optimal de notre site Web et que nous puissions continuellement l’améliorer, nous utilisons des cookies. En continuant à utiliser le site Web, vous consentez à l’usage de cookies.", "Déclaration relative à la protection des données", null)]
        [NUnit.Framework.TestCaseAttribute("IT", "", @"Swiss Life desidera offrirle sempre il servizio migliore in assoluto. Ci avvaliamo di cookie per garantirle un’esperienza ottimale del nostro sito web e per migliorarlo costantemente. Continuando a utilizzare il nostro sito web, lei esprime il suo consenso all’uso dei cookie.", "Dichiarazione sulla protezione dei dati", null)]
        public virtual void CheckTheLanguageNavigation(string lang, string title, string text, string linktext, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "language"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the language navigation", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
this.FeatureBackground();
#line hidden
#line 15
 testRunner.When(string.Format("I change the language to \'{0}\'", lang), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("the disclaimer should be shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
  testRunner.And(string.Format("the {0}, the {1} and the {2} should be correct", title, text, linktext), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Confirm the Cookie Disclaimer")]
        [NUnit.Framework.CategoryAttribute("disclaimer")]
        public virtual void ConfirmTheCookieDisclaimer()
        {
            string[] tagsOfScenario = new string[] {
                    "disclaimer"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm the Cookie Disclaimer", null, new string[] {
                        "disclaimer"});
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
this.FeatureBackground();
#line hidden
#line 27
 testRunner.Then("the disclaimer should be shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("I confirm the disclaimer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("the disclaimer should be away", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
