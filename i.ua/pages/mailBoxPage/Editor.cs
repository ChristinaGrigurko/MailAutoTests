using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutoTests.i.ua.pages.mailBoxPage
{
    class Editor
    {
        private IWebDriver driver;

        public Editor(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement inputTo()
        {
            return driver.FindElement(By.Id("to"));
        }

        private IWebElement inputSubject()
        {
            return driver.FindElement(By.CssSelector("[name=subject]"));
        }

        private IWebElement buttonSend()
        {
            return driver.FindElement(By.CssSelector("[name=send]"));
        }

        private IWebElement inputBody()
        {
            return driver.FindElement(By.Id("text"));
        }

        public void sendEmail(string to, string subject, string body)
        {
            Console.WriteLine("Enter field 'To'");
            inputTo().SendKeys(to);
            
            Console.WriteLine("Enter field 'Subject'");
            inputSubject().SendKeys(subject);

            Console.WriteLine("Enter field 'Body'");
            inputBody().SendKeys(body);

            Console.WriteLine("Click on button 'Send'");
            buttonSend().Click();
        }
    }
}
