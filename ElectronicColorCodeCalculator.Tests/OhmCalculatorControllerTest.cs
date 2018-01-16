using ElectronicColorCodeCalculator.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace ElectronicColorCodeCalculator.Tests
{
    
    
    /// <summary>
    ///This is a test class for OhmCalculatorControllerTest and is intended
    ///to contain all OhmCalculatorControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OhmCalculatorControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for OhmCalculatorController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\aravind\\Desktop\\Project\\ElectronicColorCodeCalculator\\ElectronicColorCodeCalculator", "/")]
        [UrlToTest("http://localhost:50215/")]
        public void OhmCalculatorControllerConstructorTest()
        {
            OhmCalculatorController target = new OhmCalculatorController();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\aravind\\Desktop\\Project\\ElectronicColorCodeCalculator\\ElectronicColorCodeCalculator", "/")]
        [UrlToTest("http://localhost:50215/")]
        public void IndexTest()
        {
            OhmCalculatorController target = new OhmCalculatorController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubmitNew
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\aravind\\Desktop\\Project\\ElectronicColorCodeCalculator\\ElectronicColorCodeCalculator", "/")]
        [UrlToTest("http://localhost:50215/")]
        public void SubmitNewTest()
        {
            OhmCalculatorController target = new OhmCalculatorController(); // TODO: Initialize to an appropriate value
            string bandA = string.Empty; // TODO: Initialize to an appropriate value
            string bandB = string.Empty; // TODO: Initialize to an appropriate value
            string bandC = string.Empty; // TODO: Initialize to an appropriate value
            string bandD = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.SubmitNew(bandA, bandB, bandC, bandD);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
