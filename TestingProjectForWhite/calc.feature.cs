﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestingProjectForWhite
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CalcatorFunctionalTesting")]
    public partial class CalcatorFunctionalTestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "calc.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CalcatorFunctionalTesting", "       In order check\r\n       As a calc function\r\n       I want to test the Basic" +
                    " operations and Advanced operations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
        [NUnit.Framework.CategoryAttribute("BasicOperations")]
        [NUnit.Framework.TestCaseAttribute("1", "Add", "1", "2", null)]
        [NUnit.Framework.TestCaseAttribute("2", "Add", "2", "4", null)]
        public virtual void AddTwoNumbers(string a, string operation, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BasicOperations"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("Calculator is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When(string.Format("I have entered {0} into calc", a), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And(string.Format("I press {0}", operation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("I have also entered {0} into calc", b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I press Equals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subtract two numbers")]
        [NUnit.Framework.CategoryAttribute("BasicOperations")]
        [NUnit.Framework.TestCaseAttribute("1", "Subtract", "0", "1", null)]
        [NUnit.Framework.TestCaseAttribute("6", "Subtract", "2", "4", null)]
        public virtual void SubtractTwoNumbers(string a, string operation, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BasicOperations"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtract two numbers", @__tags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("Calculator is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.When(string.Format("I have entered {0} into calc", a), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And(string.Format("I press {0}", operation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And(string.Format("I have also entered {0} into calc", b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I press Equals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiply two numbers")]
        [NUnit.Framework.CategoryAttribute("BasicOperations")]
        [NUnit.Framework.TestCaseAttribute("1", "Multiply", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("6", "Multiply", "2", "12", null)]
        public virtual void MultiplyTwoNumbers(string a, string operation, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BasicOperations"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiply two numbers", @__tags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("Calculator is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.When(string.Format("I have entered {0} into calc", a), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And(string.Format("I press {0}", operation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And(string.Format("I have also entered {0} into calc", b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I press Equals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Factorial calculation")]
        [NUnit.Framework.CategoryAttribute("AdvancedOperation")]
        [NUnit.Framework.TestCaseAttribute("Scientific", "Factorial", "5", "120", null)]
        public virtual void FactorialCalculation(string mode, string operation, string a, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AdvancedOperation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Factorial calculation", @__tags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
testRunner.Given("Calculator is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
testRunner.When(string.Format("I have opened calclator in {0} mode", mode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
testRunner.And(string.Format("I press {0}", a), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
testRunner.And(string.Format("I press {0}", operation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mortagae monthly payment calculation")]
        [NUnit.Framework.CategoryAttribute("AdvancedOperation")]
        [NUnit.Framework.TestCaseAttribute("Mortgage", "Monthly Payment", "13000", "1000", "1", "1", "1005.42", null)]
        public virtual void MortagaeMonthlyPaymentCalculation(string mode, string paymentType, string purchagePrice, string downpayment, string term, string roi, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AdvancedOperation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mortagae monthly payment calculation", @__tags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
testRunner.Given("Calculator is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
testRunner.When(string.Format("I have opened calclator in {0} mode", mode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
testRunner.And(string.Format("I select Output Field as {0}", paymentType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
testRunner.And(string.Format("I enter Purchase price as  {0}", purchagePrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
testRunner.And(string.Format("I enter Down payment as {0}", downpayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
testRunner.And(string.Format("I enter Term (years) as  {0}", term), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
testRunner.And(string.Format("I enter Interest rate (%) as  {0}", roi), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
testRunner.And("I press Calculate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
testRunner.Then(string.Format("the calculated results should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
