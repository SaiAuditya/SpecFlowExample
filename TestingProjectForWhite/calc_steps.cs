using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProjectForWhite
{
    [Binding]
    public class steps
    {
        public UITest Calculator = new UITest();

        [BeforeScenario]
        public void startTest()
        {
            Calculator.init();
        }

        [Given(@"Calculator is opened")]
        public void GivenCalculatorIsOpened()
        {
           Assert.IsTrue( Calculator.isOpned());
        }

        [When(@"I have entered (.*) into calc")]
        public void WhenIHaveEnteredIntoCalc(String p0)
        {
            Calculator.pressbuttonByText(p0);
        }

        [When(@"I have also entered (.*) into calc")]
        public void WhenIHaveAlsoEnteredIntoCalc(String p0)
        {
            Calculator.pressbuttonByText(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPressButtonWithText(String p0)
        {
            Calculator.pressbuttonByText(p0);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            Console.WriteLine("Printing" + Calculator.getResultText());
            Assert.AreEqual(Calculator.getResultText(), p0);

        }

        [When(@"I have opened calclator in (.*) mode")]
        public void WhenIHaveOpenedCalclatorInScientificMode(String p0)
        {
            Calculator.changeCalcMode(p0);
        }

        [When(@"I select (.*) as (.*)")]
        public void WhenISelectPaymentTypeMonthlyPayment(String p0, String p1)
        {
            Calculator.selectListBox(p0, p1);
        }

        [When(@"I enter (.*) as (.*)")]
        public void WhenIEnterTextinTextbox(String p0, float p1)
        {
            Calculator.enterTextByControlName(p0, p1);
        }

        [Then(@"the calculated results should be (.*)")]
        public void ThenTheCalculatedResultsShouldBe(double p0)
        {
            var actualvalue = Calculator.getTextByControlName("Monthly payment");

            if(Math.Abs(p0-Double.Parse(actualvalue)) <=0.01)
            {
                Assert.IsTrue(true);
            }else
            {
                Assert.Fail();
            }
        }

        [AfterScenario]
        public void close_calc()
        {
           Calculator.tearDown();
        }
    }
}
