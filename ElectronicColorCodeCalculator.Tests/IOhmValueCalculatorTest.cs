using ElectronicColorCodeCalculator.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace ElectronicColorCodeCalculator.Tests
{
    
    
    /// <summary>
    ///This is a test class for IOhmValueCalculatorTest and is intended
    ///to contain all IOhmValueCalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IOhmValueCalculatorTest
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


        internal virtual IOhmValueCalculator CreateIOhmValueCalculator()
        {
            // TODO: Instantiate an appropriate concrete class.
            IOhmValueCalculator target = null;
            return target;
        }

        /// <summary>
        ///A test for CalculateOhmValue
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\aravind\\Desktop\\Project\\ElectronicColorCodeCalculator\\ElectronicColorCodeCalculator", "/")]
        [UrlToTest("http://localhost:50215/")]
        public void CalculateOhmValueTest()
        {
            IOhmValueCalculator target = CreateIOhmValueCalculator(); // TODO: Initialize to an appropriate value
            string bandAColor = string.Empty; // TODO: Initialize to an appropriate value
            string bandBColor = string.Empty; // TODO: Initialize to an appropriate value
            string bandCColor = string.Empty; // TODO: Initialize to an appropriate value
            string bandDColor = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
