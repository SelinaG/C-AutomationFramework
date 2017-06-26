using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using static Evo.Helper.StandardUserDetails;

namespace Evo.PageObjects
{
    public class PersonalInfoPage : BasePage
    {
        private readonly static String Url = ConfigurationManager.AppSettings["evoRegistrationUrl"];

        public PersonalInfoPage(IWebDriver driver) :base(driver, Url)
        {
            this.Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "MainContent_UserName")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_ConfirmPassword")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_GivenFirstName")]
        public IWebElement PreferredFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_LastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "BirthDate_Month")]
        public SelectElement MonthOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "BirthDate_Day")]
        public SelectElement DateOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "BirthDate_Year")]
        public SelectElement YearOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_RD_Gender_Male")]
        public IWebElement GenderMale { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_Contact_Street")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_Contact_City")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_Contact_ZipCode")]
        public IWebElement PostalCode { get; set; }
        
        [FindsBy(How = How.Id, Using = "MainContent_MobilePhone")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_DriverLicense")]
        public IWebElement DriverLicense { get; set; }

        [FindsBy(How = How.Id, Using = "DrivingLicense_ExpiryMonth")]
        public SelectElement MonthOfExpire { get; set; }

        [FindsBy(How = How.Id, Using = "DrivingLicense_ExpiryDay")]
        public SelectElement DateOfExpire { get; set; }

        [FindsBy(How = How.Id, Using = "DrivingLicense_ExpiryYear")]
        public SelectElement YearOfExpire { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_BtnNextStep")]
        public IWebElement BtnNextStep { get; set; }

        public PaymentInfoPage FillPersonalInfoForm()
        {
            var evoUser = new EvoPersonalInfo();
            Email.SendKeys(evoUser.Email);
            Password.SendKeys(evoUser.Password);
            ConfirmPassword.SendKeys(evoUser.ComfirmPassword);
            FirstName.SendKeys(evoUser.FirstName);
            LastName.SendKeys(evoUser.LastName);
            MonthOfBirth.SelectByValue(evoUser.MonthOfBirth);
            DateOfBirth.SelectByValue(evoUser.DateOfBirth);
            YearOfBirth.SelectByValue(evoUser.YearOfBirth);
            GenderMale.Click();
            Address.SendKeys(evoUser.HomeAddress);
            City.SendKeys(evoUser.City);
            PostalCode.SendKeys(evoUser.PostalCode);
            PhoneNumber.SendKeys(evoUser.PhoneNumber);
            DriverLicense.SendKeys(evoUser.DriverLicense);
            MonthOfExpire.SelectByValue(evoUser.MonthOfExpire);
            DateOfExpire.SelectByValue(evoUser.DateOfExpire);
            YearOfExpire.SelectByValue(evoUser.YearOfExpire);
            BtnNextStep.Click();
            return (new PaymentInfoPage(Driver));
        }


    }
}
