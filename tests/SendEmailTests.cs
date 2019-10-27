using MailAutoTests.helper;
using MailTests.driver;
using MailTests.i.ua;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailTests.tests
{
    [TestFixture]
    public class SendEmailTests
    {
        private IWebDriver driver;
        private Application app;

        private string subject = "";
        private string body = "";

        [TestFixtureSetUp]
        public void biforeTest()
        {
            WebDriverMenager menager = WebDriverMenager.GetInstance();
            driver = menager.openBrowser("https://i.ua");
            app = new Application(driver);

            subject = "test" + RandomNumeric.getRandomNumber();
            body = "test" + RandomNumeric.getRandomNumber();
        }

        [Test]
        public void login()
        {
            Console.WriteLine("Autorized with login and password");
            app.mainPage().loginForm().authorize("wizardstest", "Qwerty_123456");
            app.mainPage().clickOnMail();

            app.mailBoxPage().clickOnButtonCreateMail();

            app.editor().sendEmail("wizardstest@i.ua", subject, body);
            Thread.Sleep(1000);

            app.mailBoxPage().clickOnButtonEnteries();

            Assert.AreEqual("tro-lo-lo", app.mailBoxPage().getNameFromEmail());
            Assert.AreEqual(subject, app.mailBoxPage().getSubjectFromEmail());
        }

        [TestFixtureTearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
