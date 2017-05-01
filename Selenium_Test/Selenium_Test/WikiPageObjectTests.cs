using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Test.PageObjects;

namespace Selenium_Test
{
    [TestClass]
    public class WikiPageObjectTests
    {
        WikiMainPage mainPage;
        [TestInitialize]
        public void TestInitilize()
        {
            mainPage = new WikiMainPage();
            mainPage.LoadPage();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            mainPage.Close();
        }

        [TestMethod]
        public void ShouldLoadHomePageWhenClickOnLogo()
        {

            Assert.IsTrue(mainPage.IsPageLoaded());
        }
    }
}
