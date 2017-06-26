using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using testAutomation.Setup;
using static UITests.Evo.Helper.UserDetails;

namespace UITests.Evo.PageObjects
{
    public class PaymentInfoPage
    { 
        private IWebDriver driver;
        public PaymentInfoPage()
        {
            this.driver = CurrentDriver.Current;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "MainContent_CC_CardHolderName")]
        public IWebElement CardHolderName;

        [FindsBy(How = How.Id, Using = "monerisDataInput")]
        public IWebElement CardNumber;

        [FindsBy(How = How.Id, Using = "MainContent_CC_ExpMonth")]
        public IWebElement MonthOfExpireT;
        public SelectElement MonthOfExpire
        {
            get { return new SelectElement(MonthOfExpireT); }
        }

        [FindsBy(How = How.Id, Using = "MainContent_CC_ExpYear")]
        public IWebElement YearOfExpireT;
        public SelectElement YearOfExpire
        {
            get { return new SelectElement(YearOfExpireT); }
        }

        [FindsBy(How = How.Id, Using = "MainContent_CC_CVSCode")]
        public IWebElement CvvCode;

        public void FillPaymentInfoForm()
        {
            var evoPayment = new EvoPaymentInfo();
            CardHolderName.SendKeys(evoPayment.CardHolderName);
            CardNumber.SendKeys(evoPayment.CardNumber);
            MonthOfExpire.SelectByValue(evoPayment.MonthOfExpire);
            YearOfExpire.SelectByValue(evoPayment.YearOfExpire);
            CvvCode.SendKeys(evoPayment.CvvCode);
        }
    }
}
