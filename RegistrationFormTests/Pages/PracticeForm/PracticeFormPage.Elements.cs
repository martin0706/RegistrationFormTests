using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace LiveDemoSeleniumAdvanced.Pages.PracticeForm
{
    public partial class PracticeFormPage:BasePage
    {

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

       // public IWebElement Email => Driver.FindElement(By.Id("userEmail"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Day => Driver.FindElement(By.Id("days"));

        public SelectElement Month => new SelectElement(Driver.FindElement(By.Id("months")));

        public IWebElement Year => Driver.FindElement(By.Id("years"));

        public IWebElement CompanyName => Driver.FindElement(By.Id("company"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public SelectElement State =>new SelectElement(Driver.FindElement(By.Id("id_state")));

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement Phone => Driver.FindElement(By.Id("phone"));

        public IWebElement PhoneMobile => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement Submit => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/div/ol/li"));

        public IWebElement Gender(string numberID) =>
            Driver.FindElement(By.Id($"id_gender{numberID}"));
    }
}

