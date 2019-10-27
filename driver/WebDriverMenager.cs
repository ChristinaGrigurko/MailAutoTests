using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTests.driver
{
    class WebDriverMenager
    {
        private static WebDriverMenager instance;
        private IWebDriver driver;

        private WebDriverMenager()
        {

        }
        public static WebDriverMenager GetInstance()
        {
            if (instance == null)
            {
                instance = new WebDriverMenager();
            } 
            return instance;
        }

        public IWebDriver openBrowser(String url)
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
