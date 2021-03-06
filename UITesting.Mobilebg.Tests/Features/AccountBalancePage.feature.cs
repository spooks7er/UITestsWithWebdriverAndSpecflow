﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITesting.Mobilebg.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Account Balance Page")]
    public partial class AccountBalancePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountBalancePage.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Account Balance Page", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I have navigated to the url \'http://www.mobile.bg/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table1.AddRow(new string[] {
                        "tester22016@abv.bg",
                        "123456"});
#line 5
 testRunner.And("I have entered Username and Password", ((string)(null)), table1, "And ");
#line 8
 testRunner.And("Navigated to Account Balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Move Slider and Assert Balance Bonus Percent")]
        [NUnit.Framework.TestCaseAttribute("1", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("11", "2", new string[0])]
        [NUnit.Framework.TestCaseAttribute("51", "6", new string[0])]
        [NUnit.Framework.TestCaseAttribute("92", "10", new string[0])]
        [NUnit.Framework.TestCaseAttribute("100", "10", new string[0])]
        public virtual void MoveSliderAndAssertBalanceBonusPercent(string offset, string bonus, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Move Slider and Assert Balance Bonus Percent", exampleTags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 11
 testRunner.When(string.Format("I Move the slider with {0} percent", offset), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("The bonus should be {0} percent", bonus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("See a confirmation code after selecting a payment option")]
        [NUnit.Framework.TestCaseAttribute("В брой /EasyPay/", new string[0])]
        [NUnit.Framework.TestCaseAttribute("С банков превод", new string[0])]
        [NUnit.Framework.TestCaseAttribute("На банкомат", new string[0])]
        public virtual void SeeAConfirmationCodeAfterSelectingAPaymentOption(string option, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("See a confirmation code after selecting a payment option", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 22
 testRunner.When(string.Format("I select a payment {0}", option), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("I agree to the terms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I click payment confirmation button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("I see a payment confirmation code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
