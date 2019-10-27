using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTests.i.ua.pages
{
    class MailBoxPage
    {
        private IWebDriver driver;

        public MailBoxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnButtonCreateMail()
        {
            driver.FindElement(By.CssSelector(".make_message [href]")).Click();
        }

        public void clickOnButtonEnteries()
        {
            driver.FindElement(By.CssSelector(".new")).Click();
        }

        public String getNameFromEmail()
        {
            return driver.FindElement(By.CssSelector(".row.new [class=frm]")).Text;
        }

        public String getSubjectFromEmail()
        {
            return driver.FindElement(By.CssSelector(".row.new [class=sbj]")).Text;
        }
    }
}
