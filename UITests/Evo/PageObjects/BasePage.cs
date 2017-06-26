using OpenQA.Selenium;
using testAutomation.Setup;

namespace UITests.Evo.PageObjects
{
    /// <summary>
    /// common across pages module
    /// </summary>
    public class BasePage
    {
        private IWebDriver driver;
        private readonly string WebUrl;

        protected BasePage(IWebDriver driver, string Url = "")
        {
            this.driver = CurrentDriver.Current;
            WebUrl = Url;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(WebUrl);
        }

        public string Title
        {
            get { return driver.Title; }
        }
    }
}
