using AutoFixture;
using LiveDemoSeleniumAdvanced.Factories;
using LiveDemoSeleniumAdvanced.Models;
using LiveDemoSeleniumAdvanced.Pages.PracticeForm;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Tests.Forms
{
    class PracticeFormTests:BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;
        

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _practiceFormPage = new PracticeFormPage(Driver);
            _user = PracticeFormFactory.Create();
             NavigateToForm(Driver);
        }

        [Test]
        public void CheckURL_When_FillRegistrationFormWithValidData()
        {
            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("http://automationpractice.com/index.php?controller=my-account",Driver.Url.ToString());
        }

        [Test]
        public void Check_Registration_When_Try_Pass_Whithout_Lastname()
        {
            //Arange
            _user.LastName = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("lastname is required.", _practiceFormPage.ErrorMessage.Text);
        }

        [Test]
        public void Check_Registration_When_Try_To_Insert_Invalid_Format_Post_Code()
        {
            //Arange
            _user.PostCode = "12";

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", _practiceFormPage.ErrorMessage.Text);

        }

        [Test]
        public void Check_Registration_When_Try_To_Insert_Invalid_Format_City()
        {
            //Arange
            _user.City= string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("city is required.", _practiceFormPage.ErrorMessage.Text);

        }

        [Test]
        public void Check_Registration_When_Try_To_Insert_Invalid_Format_Phone()
        {
            //Arange
            _user.Phone = "oooooo";

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("phone is invalid.", _practiceFormPage.ErrorMessage.Text);

        }

        [Test]
        public void Check_Registration_When_Try_To_Insert_Invalid_Format_Address()
        {
            //Arange
            _user.Address = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("address1 is required.", _practiceFormPage.ErrorMessage.Text);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
