using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace Enhance
{
    [Binding]
    public class UITestsStepDefinitions
    {
        private ChromeDriver driver;

        [Given(@"I opened the browser and navigated to trademe")]
        public void GivenIOpenedTheBrowserAndNavigatedToTrademe()
        {
            var DeviceDriver = ChromeDriverService.CreateDefaultService();
            DeviceDriver.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-infobars");
            driver = new ChromeDriver(DeviceDriver, options);
            driver.Navigate().GoToUrl("https://www.trademe.co.nz/");
        }

        [Given(@"I search an existing user car using reference (.*)")]
        public void GivenISearchAnExistingUserCarUsingReference(string referenceId)
        {
            //Click the motors link
            var motors = driver.FindElement(By.LinkText("Motors"));
            motors.Click();

            // Enter reference ID in the search box
            Thread.Sleep(3000);
            var keywords = WebElementExtensions.Wait(driver, By.TagName("input"));//driver.FindElement(By.TagName("input"));
            keywords.SendKeys(referenceId);

            // Click the search button 
            var search = driver.FindElement(By.XPath("//button[contains(text(),'Search')]"));
            search.Click();
        }

        [Then(@"I verify the number plate is (.*), kilometers as (.*), body (.*), seats (.*)")]
        public void ThenIVerifyTheNumberPlateIsKilometersAsBodySeats(string numberPlate, string kilometers, string bodyType, int seats)
        {
            Thread.Sleep(3000);
            var np = driver.FindElement(By.XPath("//div[2]//tg-tag[1]//span[1]//div[1]")).Text;            
            Assert.AreEqual(numberPlate, np.Replace("Number plate: \r\n", ""));
        }




    }
}
