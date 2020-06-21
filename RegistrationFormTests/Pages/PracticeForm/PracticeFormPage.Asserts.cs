using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages.PracticeForm
{
    public partial class PracticeFormPage:BasePage
    {
        public void AssertErrorBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("rgb(209, 176, 184)", element.GetCssValue("border-color"));
        }

        public void AssertSuccessBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("rgb(40, 167, 69);", element.GetCssValue("border-color"));
        }
    }
}
