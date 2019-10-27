using MailAutoTests.i.ua.pages.mailBoxPage;
using MailTests.i.ua.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTests.i.ua
{
    class Application
    {
        private IWebDriver driver;

        public Application(IWebDriver driver)
        {
            this.driver = driver;
        }

        public MainPage mainPage()
        {
            return new MainPage(driver);
        }

        public MailBoxPage mailBoxPage()
        {
            return new MailBoxPage(driver);
        }

        public Editor editor()
        {
            return new Editor(driver);
        }
    }
}
