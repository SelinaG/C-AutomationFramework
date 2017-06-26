using UITests.Evo.PageObjects;
using TechTalk.SpecFlow;

namespace UITests.Evo.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        PersonalInfoPage _registrationPage = new PersonalInfoPage();
        PaymentInfoPage _paymentInfoPage = new PaymentInfoPage();

        [StepDefinition(@"I am on evo account register page")]
        public void GivenIAmOnEvoAccountRegisterPage()
        {           
            _registrationPage.Navigate();
        }

        [StepDefinition(@"I fill out the registration form with default evo user infomation")]
        public void GivenIFillOutTheRegistrationFormWithDefaultEvoUserInfomation()
        {
            _registrationPage.FillPersonalInfoForm();
            _paymentInfoPage.FillPaymentInfoForm();
        }
    }
}
