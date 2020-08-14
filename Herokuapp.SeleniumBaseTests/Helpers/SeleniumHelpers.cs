using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Herokuapp.SeleniumBaseTests.Helpers
{
    public static class SeleniumHelpers
    {
        private static WebDriverWait GetDriverWait(this IWebDriver driver, int secondsToWait)
            => new WebDriverWait(driver, TimeSpan.FromSeconds(secondsToWait));

        public static IWebElement GetVisibleElement(this IWebDriver driver, By elemenet, int secondsToWait = 5)
        {
            try
            {
                return driver.GetDriverWait(secondsToWait).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elemenet));
            }
            catch(WebDriverTimeoutException e)
            {
                throw new NotFoundException($"Elemenet with By method '{elemenet}' is not visible even after '{secondsToWait}' seconds", e);
            }
        }

        public static void WaitForPage(this IWebDriver driver, By essentialElement, int secondsToWait = 5)
            => GetVisibleElement(driver, essentialElement, secondsToWait);
        
    }
}
