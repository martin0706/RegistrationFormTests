using AutoFixture;
using LiveDemoSeleniumAdvanced.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Factories
{
    public class PracticeFormFactory
    {

        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {

                Gender = "1",
                FirstName = new String(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", 8).Select(set => set[new Random().Next(set.Length)]).ToArray()),
                LastName = new String(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", 8).Select(set => set[new Random().Next(set.Length)]).ToArray()),
                Password = "12345",
                Day = new Fixture().Create<DateTime>().Day.ToString(),
                Month = "1",
                Year = new Fixture().Create<DateTime>().Year.ToString(),
                CompanyName = new Fixture().Create<string>(),
                Address = new Fixture().Create<string>(),
                City = new Fixture().Create<string>(),
                State = "4",
                PostCode = "12345",
                Phone = "12345",
                PhoneMobile = "12345",
                Alias = new String(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", 8).Select(set => set[new Random().Next(set.Length)]).ToArray()),
                Email = "abv@abd.bg",
                PhoneNumber = "12345"
            };
        }
    }
}
