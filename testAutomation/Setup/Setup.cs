using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace testAutomation.Setup
{
    [Binding]
    public class Setup
    {
        public static IWebDriver driver;
        private static bool localTest = true;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            try
            {
                if (Constants.Constants.forceRemote.ToLower().Equals("true"))
                {
                    localTest = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (!localTest)
            {
                //shut down stackbrowserlocal.exe
            }
            else
                driver.Quit();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var driverName = Constants.Constants.browser ?? "chrome";

            if (driver == null)
            {
                if (localTest)
                {
                    startLocalDriver(driverName.ToLower());
                }
                else
                {
                    startRemoteDriver(driverName.ToLower());
                }
            }

            if (driver != null)
            {
                ScenarioContext.Current["driver"] = driver;
                try
                {
                    driver.Manage().Window.Maximize();
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to maximize window, ignoring"); //for mobiles
                }
            }
        }
    


        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Dispose();
        }

        public static void startLocalDriver(String driverName)
        {
            switch (driverName)
            {
                case "chrome":
                    driver = new ChromeDriver();                    
                    break;

                case "ie11":
                    
                    break;

                case "firefox":
                    driver = new FirefoxDriver();                   
                    break;

                case "iphone6emu":
                    var ipone6Options = new ChromeOptions();
                    var ipone6Emu = new Dictionary<string, string>
                            {
                                {"deviceName", "Apple iPhone 6"}
                            };
                    ipone6Options.AddAdditionalCapability("mobileEmulation", ipone6Emu);
                    driver = new ChromeDriver(ipone6Options);
                    break;
                case "ipademu":
                    var ipadOptions = new ChromeOptions();
                    var ipadEmu = new Dictionary<string, string>
                            {
                                {"deviceName", "iPad"}
                            };
                    ipadOptions.AddAdditionalCapability("mobileEmulation", ipadEmu);
                    driver = new ChromeDriver(ipadOptions);
                    break;

                default:
                    driver = new ChromeDriver();                  
                    break;
            }
        }

        public static void startRemoteDriver(String driverName)
        {
            if (Process.GetProcessesByName("BrowserStackLocal").Length == 0)
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "BrowserStackLocal.exe",
                        Arguments = Constants.Constants.browserStackKey + " -forcelocal"
                    }
                }.Start();


            var capabilities = new DesiredCapabilities();

            capabilities.SetCapability(CapabilityType.Version, Constants.Constants.version);
            capabilities.SetCapability("os", Constants.Constants.os);
            capabilities.SetCapability("os_version", Constants.Constants.osVersion);
            capabilities.SetCapability("browserName", Constants.Constants.browser);

            capabilities.SetCapability("browserstack.user", Constants.Constants.browserStackUser);
            capabilities.SetCapability("browserstack.key", Constants.Constants.browserStackKey);
            capabilities.SetCapability("browserstack.local", true);

            capabilities.SetCapability("project", "BrowserStack Demo");
            capabilities.SetCapability("name", ScenarioContext.Current.ScenarioInfo.Title);

            driver = new RemoteWebDriver(new Uri(Constants.Constants.browserStackHub), capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));
            ScenarioContext.Current["driver"] = driver;
        }
    }
}
