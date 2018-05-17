using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestingProjectForWhite
{
    //<summary>
        //This test is to demonestrate the testing with excel data.
    //</summary>
    [TestClass]
    public class UnitTestWithCSV
    {

        private TestContext testContext;
        public UITest Calculator = new UITest();
        public TestContext TestContext {
            get { return testContext; }
            set { testContext = value; }
        }
        #region Additional test attributes
        [TestInitialize]
        public void MyTestInitialize() {
            Calculator.init();
        }
       
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup() {
            Calculator.tearDown();
        }
        
        #endregion
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\data\data.csv", "data#csv", DataAccessMethod.Sequential)]
        
        public void BasicOperations_DataSource_CSV()
        {
            Calculator.pressbuttonByText(TestContext.DataRow["a"].ToString());
            Calculator.pressbuttonByText(TestContext.DataRow["Operation"].ToString());
            Calculator.pressbuttonByText(TestContext.DataRow["b"].ToString());
            Calculator.pressbuttonByText("Equals");
            Assert.AreEqual(TestContext.DataRow["Result"].ToString(), Calculator.getResultText());
        }
    }
}
