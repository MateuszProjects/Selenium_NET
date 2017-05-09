using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Test_Google.PageObjects;

namespace Selenium_Test_Google
{
    [TestClass]
    public class UnitTest1
    {
        GoogleMainPage googlePage;

        [TestInitialize]
        public void TestInitilize()
        {
            googlePage = new GoogleMainPage();

        }

        [TestMethod]
        public void HomePage()
        {
            googlePage.LoadPage();
        }
    }
}
