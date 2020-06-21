using AutoFixture;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
        }

        public void NavigateToForm(IWebDriver driver)
        {
            IWebElement signInButton = driver.FindElement(By.PartialLinkText(@"Sign in"));
            signInButton.Click();

            var fixture = new Fixture();
            var mail = fixture.Create<string>();
            var inputMail = driver.FindElement(By.Id("email_create"));
            inputMail.SendKeys(mail + "@abv.bg");

            IWebElement buttonCreator = driver.FindElement(By.Id("SubmitCreate"));
            buttonCreator.Submit();
        }

    }
}
