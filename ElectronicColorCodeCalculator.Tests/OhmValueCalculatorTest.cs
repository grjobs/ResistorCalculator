using ElectronicColorCodeCalculator.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace ElectronicColorCodeCalculator.Tests
{
    
    
    /// <summary>
    ///This is a test class for OhmValueCalculatorTest and is intended
    ///to contain all OhmValueCalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OhmValueCalculatorTest
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
        ///A test for OhmValueCalculator Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\aravind\\Desktop\\Project\\ElectronicColorCodeCalculator\\ElectronicColorCodeCalculator", "/")]
        [UrlToTest("http://localhost:50215/")]
        public void OhmValueCalculatorConstructorTest()
        {
            OhmValueCalculator target = new OhmValueCalculator();
            Assert.Inconclusive("TODO: Implement code to verify target");
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
        public void CalculateOhmValueTest()
        {
            OhmValueCalculator target = new OhmValueCalculator(); // TODO: Initialize to an appropriate value
            string bandAColor = "YE"; // TODO: Initialize to an appropriate value E,VT,RDGD
            string bandBColor = "VT"; // TODO: Initialize to an appropriate value
            string bandCColor = "RD"; // TODO: Initialize to an appropriate value
            string bandDColor = "GD"; // TODO: Initialize to an appropriate value
            int expected = 4935; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
