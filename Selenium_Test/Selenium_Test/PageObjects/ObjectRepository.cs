using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test.PageObjects
{
    internal class ObjectRepository
    {
        public class MainPage
        {
            public const string WelcomeText = "Witaj w Wikipedii,";
            public static By WelcomTextId = By.Id("main-page-welcome");
            public static string MainPageUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
        }
    }
}
