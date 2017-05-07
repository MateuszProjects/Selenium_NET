﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test.PageObjects
{
    class WikiMainPage
    {
        public IWebDriver driver;


        public WikiMainPage()
        {
            driver = new ChromeDriver();
            LoadPage();
        }

        public void LoadPage()
        {
            driver.Navigate().GoToUrl(ObjectRepository.MainPage.MainPageUrl);
        }

        public void Close()
        {
            driver.Quit();
        }

        public bool IsPageLoaded()
        {
            var WikiEx = driver.FindElement(ObjectRepository.MainPage.WelcomTextId);
            return WikiEx.Text.Contains(ObjectRepository.MainPage.WelcomeText);
        }

        public void InData()
        {  
             driver.FindElement(ObjectRepository.MainPage.DaneWiki).Click();
            driver.FindElement(ObjectRepository.MainPage.DaneSearch).Clear();
        
        }


    }
}
