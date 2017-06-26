using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace testAutomation.Setup
{
    public class CurrentDriver
    {
        public static IWebDriver Current {
            get
            {
                return (IWebDriver)ScenarioContext.Current["driver"];
            }
        }       
    }
}
