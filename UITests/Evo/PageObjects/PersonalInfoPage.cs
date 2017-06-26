using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using UITests.Evo.Helper;
using testAutomation.Setup;
using static UITests.Evo.Helper.UserDetails;

namespace UITests.Evo.PageObjects
{
    public class PersonalInfoPage
    {
        private String Url = ConfigurationManager.AppSettings["evoRegistrationUrl"];
        private IWebDriver driver;

        public PersonalInfoPage()
        {
            this.driver = CurrentDriver.Current;
            PageFactory.InitElements(driver, this);            
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(Url);
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
        private IWebElement MonthOfBirthWebElement { get; set; }
        public SelectElement MonthOfBirth
        {
            get { return new SelectElement(MonthOfBirthWebElement); }
        }

        [FindsBy(How = How.Id, Using = "BirthDate_Day")]
        public IWebElement DateOfBirthWebElement { get; set; }
        public SelectElement DateOfBirth
        {
            get { return new SelectElement(DateOfBirthWebElement); }
        }

        [FindsBy(How = How.Id, Using = "BirthDate_Year")]
        public IWebElement YearOfBirthWebElement { get; set; }
        public SelectElement YearOfBirth
        {
            get { return new SelectElement(YearOfBirthWebElement); }
        }

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
        public IWebElement MonthOfExpireWebElement { get; set; }
        public SelectElement MonthOfExpire
        {
            get { return new SelectElement(YearOfBirthWebElement); }
        }

        [FindsBy(How = How.Id, Using = "DrivingLicense_ExpiryDay")]
        public IWebElement DateOfExpireWebElement { get; set; }
        public SelectElement DateOfExpire
        {
            get { return new SelectElement(DateOfExpireWebElement); }
        }

        [FindsBy(How = How.Id, Using = "DrivingLicense_ExpiryYear")]
        public IWebElement YearOfExpireWebElement { get; set; }
        public SelectElement YearOfExpire
        {
            get { return new SelectElement(YearOfExpireWebElement); }
        }

        [FindsBy(How = How.Id, Using = "MainContent_BtnNextStep")]
        public IWebElement BtnNextStep { get; set; }

        public PaymentInfoPage FillPersonalInfoForm()
        {
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
            return (new PaymentInfoPage());
        }
    }
}
