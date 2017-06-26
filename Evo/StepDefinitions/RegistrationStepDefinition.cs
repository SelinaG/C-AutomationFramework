
using Evo.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Evo.Helper;
using static Evo.Helper.StandardUserDetails;

namespace Evo.StepDefinitions
{
    [Binding]
    public sealed class RegistrationStepDefinition
    {
        private static IWebDriver driver;
        PersonalInfoPage _registrationPage;
        PaymentInfoPage _paymentInfoPage = new PaymentInfoPage(driver);

        [StepDefinition(@"I am on evo account register page")]
        public void GivenIAmOnEvoAccountRegisterPage()
        {
            _registrationPage = new PersonalInfoPage(driver);
        }

        [Given(@"I fill out the registration form with default evo user infomation")]
        public void GivenIFillOutTheRegistrationFormWithDefaultEvoUserInfomation()
        {
            _registrationPage.FillPersonalInfoForm();
            _paymentInfoPage.FillPaymentInfoForm();
        }
    }
}
