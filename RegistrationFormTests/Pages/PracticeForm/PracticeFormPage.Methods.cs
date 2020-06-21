using AutoFixture;
using LiveDemoSeleniumAdvanced.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages.PracticeForm
{
    public partial class PracticeFormPage:BasePage
    {
        public PracticeFormPage(IWebDriver driver)
           : base(driver)
        {
        }

        public void FillForm(PracticeFormModel user)
        {
            Gender(user.Gender).Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Day.SendKeys(user.Day);
            Month.SelectByValue(user.Month);
            Year.SendKeys(user.Year);
            CompanyName.SendKeys(user.CompanyName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.Address);
            State.SelectByValue(user.State);
            PostCode.SendKeys(user.PostCode);
            Phone.SendKeys(user.Phone);
            PhoneMobile.SendKeys(user.PhoneMobile);
            Alias.SendKeys(user.Alias);

            Submit.Click();
        }

        
    }
}
