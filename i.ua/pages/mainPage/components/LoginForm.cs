using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTests.i.ua.pages.mainPage.components
{
    class LoginForm
    {
        private IWebElement webElement;

        public LoginForm(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        private IWebElement inputLogin()
        {
            return webElement.FindElement(By.CssSelector("[name=login]"));
        }

        private IWebElement inputPassword()
        {
            return webElement.FindElement(By.CssSelector("[name=pass]"));
        }

        private IWebElement buttonSubmit()
        {
            return webElement.FindElement(By.CssSelector("[type=submit]"));
        }

        public void authorize(string login, string password)
        {
            inputLogin().SendKeys(login);
            Console.WriteLine("Enter login");

            inputPassword().SendKeys(password);
            Console.WriteLine("Enter password");

            buttonSubmit().Click();
            Console.WriteLine("Click on button 'submit'");
        }
    }
}
