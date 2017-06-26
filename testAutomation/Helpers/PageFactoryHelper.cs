using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAutomation.Helpers
{
    class PageFactoryHelper
    {
        public SelectElement ConvertToSelectElement(IWebElement element)
        {
            return new SelectElement(element);
        }
    }
}