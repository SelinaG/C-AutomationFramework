using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using static Evo.Helper.StandardUserDetails;

namespace Evo.PageObjects
{
    public class PaymentInfoPage : BasePage
    {
        private static readonly string Url = ""; 
        public PaymentInfoPage(IWebDriver driver) : base(driver, Url)
        {
            this.Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "MainContent_CC_CardHolderName")]
        public IWebElement CardHolderName;

        [FindsBy(How = How.Id, Using = "monerisDataInput")]
        public IWebElement CardNumber;

        [FindsBy(How = How.Id, Using = "MainContent_CC_ExpMonth")]
        public SelectElement MonthOfExpire;

        [FindsBy(How = How.Id, Using = "MainContent_CC_ExpYear")]
        public SelectElement YearOfExpire;

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
