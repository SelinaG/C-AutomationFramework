using OpenQA.Selenium;

namespace Evo.PageObjects
{
    public class BasePage
    {
        private IWebDriver driver;        

        protected BasePage(IWebDriver driver, string Url = "")
        {
            this.driver = driver;
            if (Url != string.Empty)
            {
                driver.Navigate().GoToUrl(Url);
            }           
        }
        
       public string Title {
            get { return driver.Title; }
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }
    }
}
