using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhance
{
    internal static class WebElementExtensions
    {
        internal static IWebElement Wait(WebDriver driver, By by)
        {      
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 45));
            wait.Until(drv => drv.FindElement(by));
            return driver.FindElement(by);
        }
    }
}
