using MailTests.i.ua.pages.mainPage.components;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailTests.i.ua.pages
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginForm loginForm()
        {
            clickOnButtonLogin();
            return new LoginForm(driver.FindElement(By.Id("FloatLogin")));     
        }

        public void clickOnButtonLogin()
        {
            driver.FindElement(By.ClassName("first")).Click();
        }

        public void clickOnMail()
        {
            driver.FindElement(By.ClassName("mbox_16")).Click();
        }
    }
}
