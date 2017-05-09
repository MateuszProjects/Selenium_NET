using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Test_Google.PageObjects
{
    class GoogleMainPage
    {
        public IWebDriver driver;

        public GoogleMainPage()
        {
            driver = new ChromeDriver();
            LoadPage();
        }

        public void LoadPage()
        {
            driver.Navigate().GoToUrl(ObjectRepository.MainPage.MainPageUrl);
        }

   
    }
}
